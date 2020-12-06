using System;
using System.Collections.Generic;

namespace com.igetui.api.openservice.igetui
{
	// Token: 0x02000044 RID: 68
	public class AppMessage : Message
	{
        // Token: 0x17000262 RID: 610
        // (get) Token: 0x06000592 RID: 1426 RVA: 0x0000CE41 File Offset: 0x0000B041
        // (set) Token: 0x06000593 RID: 1427 RVA: 0x0000CE49 File Offset: 0x0000B049
        public AppConditions Conditions { get; set; }

        // Token: 0x17000263 RID: 611
        // (get) Token: 0x06000594 RID: 1428 RVA: 0x0000CE52 File Offset: 0x0000B052
        // (set) Token: 0x06000595 RID: 1429 RVA: 0x0000CE5A File Offset: 0x0000B05A
        public string PushTime { get; set; }

        // Token: 0x17000264 RID: 612
        // (get) Token: 0x06000596 RID: 1430 RVA: 0x0000CE63 File Offset: 0x0000B063
        // (set) Token: 0x06000597 RID: 1431 RVA: 0x0000CE6B File Offset: 0x0000B06B
        public List<string> TagList { get; set; } = new List<string>();

        // Token: 0x17000265 RID: 613
        // (get) Token: 0x06000598 RID: 1432 RVA: 0x0000CE74 File Offset: 0x0000B074
        // (set) Token: 0x06000599 RID: 1433 RVA: 0x0000CE7C File Offset: 0x0000B07C
        public List<string> AppIdList { get; set; }

        // Token: 0x17000266 RID: 614
        // (get) Token: 0x0600059A RID: 1434 RVA: 0x0000CE85 File Offset: 0x0000B085
        // (set) Token: 0x0600059B RID: 1435 RVA: 0x0000CE8D File Offset: 0x0000B08D
        public List<string> PhoneTypeList { get; set; } = new List<string>();

        // Token: 0x17000267 RID: 615
        // (get) Token: 0x0600059C RID: 1436 RVA: 0x0000CE96 File Offset: 0x0000B096
        // (set) Token: 0x0600059D RID: 1437 RVA: 0x0000CE9E File Offset: 0x0000B09E
        public List<string> ProvinceList
		{
			get
			{
				return provinceList;
			}
			set
			{
				provinceList = value;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x0000CEA7 File Offset: 0x0000B0A7
		// (set) Token: 0x0600059F RID: 1439 RVA: 0x0000CEAF File Offset: 0x0000B0AF
		public int Speed
		{
			get
			{
				return speed;
			}
			set
			{
				speed = value;
			}
		}

        // Token: 0x04000321 RID: 801
        private List<string> provinceList = new List<string>();

        // Token: 0x04000323 RID: 803
        private int speed;
    }
}
