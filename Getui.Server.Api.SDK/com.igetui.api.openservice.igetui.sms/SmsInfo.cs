using System;
using System.Collections.Generic;

namespace com.igetui.api.openservice.igetui.sms
{
	// Token: 0x0200005B RID: 91
	public class SmsInfo
	{
        // Token: 0x170002BE RID: 702
        // (get) Token: 0x060006A2 RID: 1698 RVA: 0x0000F829 File Offset: 0x0000DA29
        // (set) Token: 0x060006A3 RID: 1699 RVA: 0x0000F831 File Offset: 0x0000DA31
        public string SmsTemplateId { get; set; }

        // Token: 0x170002BF RID: 703
        // (get) Token: 0x060006A4 RID: 1700 RVA: 0x0000F83A File Offset: 0x0000DA3A
        // (set) Token: 0x060006A5 RID: 1701 RVA: 0x0000F842 File Offset: 0x0000DA42
        public Dictionary<string, string> SmsContent { get; set; }

        // Token: 0x170002C0 RID: 704
        // (get) Token: 0x060006A6 RID: 1702 RVA: 0x0000F84B File Offset: 0x0000DA4B
        // (set) Token: 0x060006A7 RID: 1703 RVA: 0x0000F853 File Offset: 0x0000DA53
        public long OfflineSendtime { get; set; }

        // Token: 0x170002C1 RID: 705
        // (get) Token: 0x060006A8 RID: 1704 RVA: 0x0000F85C File Offset: 0x0000DA5C
        // (set) Token: 0x060006A9 RID: 1705 RVA: 0x0000F864 File Offset: 0x0000DA64
        public string Url { get; set; }

        // Token: 0x170002C2 RID: 706
        // (get) Token: 0x060006AA RID: 1706 RVA: 0x0000F86D File Offset: 0x0000DA6D
        // (set) Token: 0x060006AB RID: 1707 RVA: 0x0000F875 File Offset: 0x0000DA75
        public bool IsApplink { get; set; }

        // Token: 0x170002C3 RID: 707
        // (get) Token: 0x060006AC RID: 1708 RVA: 0x0000F87E File Offset: 0x0000DA7E
        // (set) Token: 0x060006AD RID: 1709 RVA: 0x0000F886 File Offset: 0x0000DA86
        public string Payload
		{
			get
			{
				return payload;
			}
			set
			{
				payload = value;
			}
		}

        // Token: 0x04000399 RID: 921
        private string payload;
	}
}
