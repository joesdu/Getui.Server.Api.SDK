using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace com.igetui.api.openservice.utils
{
    // Token: 0x0200003F RID: 63
    internal static class Util
	{
		// Token: 0x0600055C RID: 1372 RVA: 0x0000C624 File Offset: 0x0000A824
		public static void SetCertificatePolicy()
		{
			ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(RemoteCertificateValidate));
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0000C646 File Offset: 0x0000A846
		private static bool RemoteCertificateValidate(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors error)
		{
			return true;
		}
	}
}
