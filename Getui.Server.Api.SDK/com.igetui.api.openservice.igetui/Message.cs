using System;

namespace com.igetui.api.openservice.igetui
{
	// Token: 0x02000048 RID: 72
	public class Message : IPacket
	{
        // Token: 0x1700026C RID: 620
        // (get) Token: 0x060005AF RID: 1455 RVA: 0x0000CFFF File Offset: 0x0000B1FF
        // (set) Token: 0x060005B0 RID: 1456 RVA: 0x0000D007 File Offset: 0x0000B207
        public bool IsOffline { get; set; }

        // Token: 0x1700026D RID: 621
        // (get) Token: 0x060005B1 RID: 1457 RVA: 0x0000D010 File Offset: 0x0000B210
        // (set) Token: 0x060005B2 RID: 1458 RVA: 0x0000D018 File Offset: 0x0000B218
        public long OfflineExpireTime { get; set; }

        // Token: 0x1700026E RID: 622
        // (get) Token: 0x060005B3 RID: 1459 RVA: 0x0000D021 File Offset: 0x0000B221
        // (set) Token: 0x060005B4 RID: 1460 RVA: 0x0000D029 File Offset: 0x0000B229
        public int PushNetWorkType { get; set; }

        // Token: 0x1700026F RID: 623
        // (get) Token: 0x060005B5 RID: 1461 RVA: 0x0000D032 File Offset: 0x0000B232
        // (set) Token: 0x060005B6 RID: 1462 RVA: 0x0000D03A File Offset: 0x0000B23A
        public ITemplate Data
		{
			get
			{
				return data;
			}
			set
			{
				data = value;
			}
		}

        // Token: 0x04000330 RID: 816
        private ITemplate data;
	}
}
