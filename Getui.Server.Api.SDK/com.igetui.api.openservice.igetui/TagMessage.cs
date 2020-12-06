using System;
using System.Collections.Generic;

namespace com.igetui.api.openservice.igetui
{
	// Token: 0x0200004A RID: 74
	public class TagMessage : Message
	{
        // Token: 0x17000270 RID: 624
        // (get) Token: 0x060005B9 RID: 1465 RVA: 0x0000D053 File Offset: 0x0000B253
        // (set) Token: 0x060005BA RID: 1466 RVA: 0x0000D05B File Offset: 0x0000B25B
        public List<string> AppIdList { get; set; }

        // Token: 0x17000271 RID: 625
        // (get) Token: 0x060005BB RID: 1467 RVA: 0x0000D064 File Offset: 0x0000B264
        // (set) Token: 0x060005BC RID: 1468 RVA: 0x0000D06C File Offset: 0x0000B26C
        public string Tag { get; set; }

        // Token: 0x17000272 RID: 626
        // (get) Token: 0x060005BD RID: 1469 RVA: 0x0000D075 File Offset: 0x0000B275
        // (set) Token: 0x060005BE RID: 1470 RVA: 0x0000D07D File Offset: 0x0000B27D
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

        // Token: 0x04000333 RID: 819
        private int speed;
	}
}
