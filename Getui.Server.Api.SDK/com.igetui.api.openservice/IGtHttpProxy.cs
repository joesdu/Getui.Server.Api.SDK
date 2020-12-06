using System;

namespace com.igetui.api.openservice
{
	// Token: 0x0200002E RID: 46
	public class IGtHttpProxy
	{
		// Token: 0x060004C8 RID: 1224 RVA: 0x0000A114 File Offset: 0x00008314
		public IGtHttpProxy()
		{
			string httpProxyIp = GtConfig.getHttpProxyIp();
			int httpProxyPort = GtConfig.getHttpProxyPort();
			if (!string.IsNullOrWhiteSpace(httpProxyIp))
			{
				Host = httpProxyIp;
				Port = httpProxyPort;
				User = GtConfig.getHttpProxyUser();
				_passwd = GtConfig.getHttpProxyPasswd();
			}
		}

        // Token: 0x1700024A RID: 586
        // (get) Token: 0x060004C9 RID: 1225 RVA: 0x0000A15F File Offset: 0x0000835F
        // (set) Token: 0x060004CA RID: 1226 RVA: 0x0000A167 File Offset: 0x00008367
        public string Host { get; set; }

        // Token: 0x1700024B RID: 587
        // (get) Token: 0x060004CB RID: 1227 RVA: 0x0000A170 File Offset: 0x00008370
        // (set) Token: 0x060004CC RID: 1228 RVA: 0x0000A178 File Offset: 0x00008378
        public int Port { get; set; }

        // Token: 0x1700024C RID: 588
        // (get) Token: 0x060004CD RID: 1229 RVA: 0x0000A181 File Offset: 0x00008381
        // (set) Token: 0x060004CE RID: 1230 RVA: 0x0000A189 File Offset: 0x00008389
        public string User { get; set; }

        // Token: 0x1700024D RID: 589
        // (get) Token: 0x060004CF RID: 1231 RVA: 0x0000A192 File Offset: 0x00008392
        // (set) Token: 0x060004D0 RID: 1232 RVA: 0x0000A19A File Offset: 0x0000839A
        public string Password
		{
			get
			{
				return _passwd;
			}
			set
			{
				_passwd = value;
			}
		}

        // Token: 0x040002F5 RID: 757
        private string _passwd;
	}
}
