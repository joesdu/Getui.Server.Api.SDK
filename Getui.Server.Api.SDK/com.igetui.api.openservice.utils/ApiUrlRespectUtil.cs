using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;

namespace com.igetui.api.openservice.utils
{
    // Token: 0x0200003B RID: 59
    internal class ApiUrlRespectUtil
	{
		// Token: 0x0600054F RID: 1359 RVA: 0x0000C21C File Offset: 0x0000A41C
		public static string getFastest(string appKey, List<string> hosts)
		{
            flag = false;
            url = "";
			int num = hosts.Count();
			if (num == 0)
			{
				throw new Exception("can't get fastest host from empty list");
			}
			if (num == 1)
			{
				return hosts[0];
			}
			if (!appFastUrlDict.ContainsKey(appKey))
			{
				object obj = thisLock;
				lock (obj)
				{
					if (!appFastUrlDict.ContainsKey(appKey))
					{
						for (int i = 0; i < num; i++)
						{
							new Thread(new ParameterizedThreadStart(ThreadMethod))
							{
								IsBackground = true
							}.Start(hosts[i]);
						}
						while (!flag)
						{
							Thread.Sleep(1);
						}
                        appFastUrlDict[appKey] = url;
					}
				}
			}
			return appFastUrlDict[appKey];
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0000C314 File Offset: 0x0000A514
		public static void setProxy(HttpProxy p)
		{
            proxy = p;
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0000C31C File Offset: 0x0000A51C
		private static void ThreadMethod(object ob)
		{
			string requestUriString = (string)ob;
			HttpWebRequest httpWebRequest = null;
			HttpWebResponse httpWebResponse = null;
			try
			{
				httpWebRequest = (WebRequest.Create(requestUriString) as HttpWebRequest);
				WebProxy webProxy = proxy.getWebProxy();
				if (webProxy != null)
				{
					httpWebRequest.Proxy = webProxy;
				}
				httpWebRequest.Timeout = 30000;
				httpWebRequest.Method = "HEAD";
				httpWebRequest.ProtocolVersion = new Version(1, 1);
				httpWebResponse = (httpWebRequest.GetResponse() as HttpWebResponse);
				if (httpWebResponse.StatusCode == HttpStatusCode.OK && !flag)
				{
                    flag = true;
                    url = requestUriString;
				}
			}
			catch (Exception value)
			{
				Console.WriteLine(value);
			}
			finally
			{
				if (httpWebRequest != null)
				{
					httpWebRequest.Abort();
					httpWebRequest = null;
				}
				if (httpWebResponse != null)
				{
					httpWebResponse.Close();
					httpWebRequest = null;
				}
			}
		}

		// Token: 0x04000301 RID: 769
		private static object thisLock = new object();

		// Token: 0x04000302 RID: 770
		private static volatile bool flag;

		// Token: 0x04000303 RID: 771
		private static volatile string url;

		// Token: 0x04000304 RID: 772
		private static volatile Dictionary<string, string> appFastUrlDict = new Dictionary<string, string>();

		// Token: 0x04000305 RID: 773
		private static HttpProxy proxy;
	}
}
