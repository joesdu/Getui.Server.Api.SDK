using System;
using System.Net;

namespace com.igetui.api.openservice
{
	// Token: 0x0200002B RID: 43
	internal class HttpProxy
	{
		// Token: 0x060004BF RID: 1215 RVA: 0x00009FC4 File Offset: 0x000081C4
		public HttpProxy(IGtHttpProxy p)
		{
			if (!string.IsNullOrWhiteSpace(p.Host) && p.Host.Length > 0)
			{
				isProxy = true;
			}
			else
			{
				isProxy = false;
			}
			if (p.User == null)
			{
				p.User = "";
			}
			if (p.Password == null)
			{
				p.Password = "";
			}
			if (!string.IsNullOrWhiteSpace(p.User) || !string.IsNullOrWhiteSpace(p.Password))
			{
				isProxyAuth = true;
			}
			else
			{
				isProxyAuth = false;
			}
			proxy = p;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0000A05C File Offset: 0x0000825C
		public WebProxy getWebProxy()
		{
			WebProxy webProxy = null;
			if (isProxy)
			{
				webProxy = new WebProxy();
				if (!proxy.Host.ToLower().StartsWith("http"))
				{
					proxy.Host = "http://" + proxy.Host;
				}
				webProxy.Address = new Uri(proxy.Host + ":" + proxy.Port);
				if (isProxyAuth)
				{
					webProxy.Credentials = new NetworkCredential(proxy.User, proxy.Password);
				}
			}
			return webProxy;
		}

		// Token: 0x040002EF RID: 751
		private IGtHttpProxy proxy;

		// Token: 0x040002F0 RID: 752
		private bool isProxy;

		// Token: 0x040002F1 RID: 753
		private bool isProxyAuth;
	}
}
