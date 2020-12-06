using System;

namespace com.igetui.api.openservice.igetui
{
	// Token: 0x02000045 RID: 69
	public class GroupMessage
	{
        // Token: 0x17000269 RID: 617
        // (get) Token: 0x060005A1 RID: 1441 RVA: 0x0000CEE1 File Offset: 0x0000B0E1
        // (set) Token: 0x060005A2 RID: 1442 RVA: 0x0000CEE9 File Offset: 0x0000B0E9
        public string GroupId { get; set; }

        // Token: 0x1700026A RID: 618
        // (get) Token: 0x060005A3 RID: 1443 RVA: 0x0000CEF2 File Offset: 0x0000B0F2
        // (set) Token: 0x060005A4 RID: 1444 RVA: 0x0000CEFA File Offset: 0x0000B0FA
        public string RequestId { get; set; }

        // Token: 0x1700026B RID: 619
        // (get) Token: 0x060005A5 RID: 1445 RVA: 0x0000CF03 File Offset: 0x0000B103
        // (set) Token: 0x060005A6 RID: 1446 RVA: 0x0000CF0B File Offset: 0x0000B10B
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

        // Token: 0x04000328 RID: 808
        private ITemplate data;
	}
}
