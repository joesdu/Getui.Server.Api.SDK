using System;
using System.Collections.Generic;

namespace com.igetui.api.openservice
{
	// Token: 0x0200002A RID: 42
	public class GtConfig
	{
		// Token: 0x060004AB RID: 1195 RVA: 0x00009C14 File Offset: 0x00007E14
		public static bool isPushSingleBatchAsync()
		{
			string environmentVariable = Environment.GetEnvironmentVariable("gexin_pushSingleBatch_needAsync");
			return "true".Equals(environmentVariable);
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00009C38 File Offset: 0x00007E38
		public static bool isPushListNeedAliasDetails()
		{
			string environmentVariable = Environment.GetEnvironmentVariable("gexin_pushList_needAliasDetails");
			string environmentVariable2 = Environment.GetEnvironmentVariable("needAliasDetails");
			if (environmentVariable2 != null)
			{
				return environmentVariable2.Equals("true");
			}
			return environmentVariable != null && environmentVariable.Equals("true");
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00009C7C File Offset: 0x00007E7C
		public static bool isPushListAsync()
		{
			string environmentVariable = Environment.GetEnvironmentVariable("gexin_pushList_needAsync");
			return "true".Equals(environmentVariable);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00009CA0 File Offset: 0x00007EA0
		public static bool isPushListNeedDetails()
		{
			string environmentVariable = Environment.GetEnvironmentVariable("gexin_pushList_needDetails");
			string environmentVariable2 = Environment.GetEnvironmentVariable("needDetails");
			if (environmentVariable2 != null)
			{
				return environmentVariable2.Equals("true");
			}
			return environmentVariable != null && environmentVariable.Equals("true");
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00009CE2 File Offset: 0x00007EE2
		public static string getHttpProxyIp()
		{
			return Environment.GetEnvironmentVariable("gexin_http_proxy_ip");
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00009CF0 File Offset: 0x00007EF0
		public static int getTagListLimit()
		{
			string environmentVariable = Environment.GetEnvironmentVariable("gexin_tagList_limit");
			if (environmentVariable == null)
			{
				return 10;
			}
			return int.Parse(environmentVariable);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00009D14 File Offset: 0x00007F14
		public static int getHttpProxyPort()
		{
			string environmentVariable = Environment.GetEnvironmentVariable("gexin_http_proxy_port");
			if (environmentVariable == null)
			{
				return 80;
			}
			return int.Parse(environmentVariable);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00009D38 File Offset: 0x00007F38
		public static string getHttpProxyUser()
		{
			return Environment.GetEnvironmentVariable("gexin_http_proxy_username");
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00009D44 File Offset: 0x00007F44
		public static string getHttpProxyPasswd()
		{
			return Environment.GetEnvironmentVariable("gexin_http_proxy_passwd");
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00009D50 File Offset: 0x00007F50
		public static int getSyncListLimit()
		{
			string environmentVariable = Environment.GetEnvironmentVariable("gexin_pushList_syncLimit");
			if (environmentVariable == null)
			{
				return 1000;
			}
			return int.Parse(environmentVariable);
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00009D78 File Offset: 0x00007F78
		public static int getMaxLenOfBlackCidList()
		{
			string environmentVariable = Environment.GetEnvironmentVariable("gexin_max_blkCid_length");
			if (environmentVariable == null)
			{
				return 1000;
			}
			return int.Parse(environmentVariable);
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00009DA0 File Offset: 0x00007FA0
		public static int getAsyncListLimit()
		{
			string environmentVariable = Environment.GetEnvironmentVariable("gexin_pushList_asyncLimit");
			if (environmentVariable == null)
			{
				return 10000;
			}
			return int.Parse(environmentVariable);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00009DC8 File Offset: 0x00007FC8
		public static int getHttpConnectionTimeOut()
		{
			string environmentVariable = Environment.GetEnvironmentVariable("gexin_http_connection_timeout");
			if (environmentVariable == null)
			{
				return 60000;
			}
			return int.Parse(environmentVariable);
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00009DF0 File Offset: 0x00007FF0
		public static int getHttpSoTimeOut()
		{
			string environmentVariable = Environment.GetEnvironmentVariable("gexin_http_so_timeout");
			if (environmentVariable == null)
			{
				return 30000;
			}
			return int.Parse(environmentVariable);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00009E18 File Offset: 0x00008018
		public static int getHttpTryCount()
		{
			string environmentVariable = Environment.GetEnvironmentVariable("gexin_http_tryCount");
			if (environmentVariable == null)
			{
				return 3;
			}
			return int.Parse(environmentVariable);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00009E3C File Offset: 0x0000803C
		public static int getHttpInspectInterval()
		{
			string environmentVariable = Environment.GetEnvironmentVariable("gexin_http_inspect_interval");
			if (environmentVariable == null)
			{
				return 60000;
			}
			return int.Parse(environmentVariable);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00009E64 File Offset: 0x00008064
		public static List<string> getDefaultDomainUrl(bool useSSL)
		{
			List<string> list = new List<string>();
			string environmentVariable = Environment.GetEnvironmentVariable("gexin_default_domainurl");
			if (string.IsNullOrEmpty(environmentVariable))
			{
				if (useSSL)
				{
					list.Add("https://cncapi.getui.com/serviceex");
					list.Add("https://telapi.getui.com/serviceex");
					list.Add("https://api.getui.com/serviceex");
					list.Add("https://sdk1api.getui.com/serviceex");
					list.Add("https://sdk2api.getui.com/serviceex");
					list.Add("https://sdk3api.getui.com/serviceex");
				}
				else
				{
					list.Add("http://sdk.open.api.igexin.com/serviceex");
					list.Add("http://sdk.open.api.gepush.com/serviceex");
					list.Add("http://sdk.open.api.getui.net/serviceex");
					list.Add("http://sdk1.open.api.igexin.com/serviceex");
					list.Add("http://sdk2.open.api.igexin.com/serviceex");
					list.Add("http://sdk3.open.api.igexin.com/serviceex");
				}
			}
			else
			{
				foreach (string text in environmentVariable.Split(',', StringSplitOptions.None))
				{
					if ((!text.StartsWith("https://") || useSSL) && (!text.StartsWith("http://") || !useSSL))
					{
						if (!text.StartsWith("http") && useSSL)
						{
							list.Add("https://" + text);
						}
						else
						{
							list.Add(text);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00009F8C File Offset: 0x0000818C
		public static int getTransIntentLength()
		{
			string environmentVariable = Environment.GetEnvironmentVariable("trans_intent_length");
			if (environmentVariable == null)
			{
				return 1000;
			}
			return int.Parse(environmentVariable);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00009FB3 File Offset: 0x000081B3
		public static string getSDKVersion()
		{
			return "4.1.0.1";
		}
	}
}
