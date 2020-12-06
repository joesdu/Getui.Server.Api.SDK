using System;
using com.gexin.rp.sdk.dto;

namespace com.igetui.api.openservice.igetui.template.notify
{
	// Token: 0x0200005A RID: 90
	public class Notify
	{
		// Token: 0x06000693 RID: 1683 RVA: 0x0000F779 File Offset: 0x0000D979
		public int? getNotifyId()
		{
			return notifyId;
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0000F784 File Offset: 0x0000D984
		public void setNotifyId(int? notifyId)
		{
			int? num = notifyId;
			int num2 = 0;
			if (num.GetValueOrDefault() < num2 & num != null)
			{
				throw new Exception("notifyId need greater than 0");
			}
			this.notifyId = notifyId;
		}

        // Token: 0x170002B8 RID: 696
        // (get) Token: 0x06000695 RID: 1685 RVA: 0x0000F7BB File Offset: 0x0000D9BB
        // (set) Token: 0x06000696 RID: 1686 RVA: 0x0000F7C3 File Offset: 0x0000D9C3
        public string Title { get; set; }

        // Token: 0x170002B9 RID: 697
        // (get) Token: 0x06000697 RID: 1687 RVA: 0x0000F7CC File Offset: 0x0000D9CC
        // (set) Token: 0x06000698 RID: 1688 RVA: 0x0000F7D4 File Offset: 0x0000D9D4
        public string Content { get; set; }

        // Token: 0x170002BA RID: 698
        // (get) Token: 0x06000699 RID: 1689 RVA: 0x0000F7DD File Offset: 0x0000D9DD
        // (set) Token: 0x0600069A RID: 1690 RVA: 0x0000F7E5 File Offset: 0x0000D9E5
        public string Payload { get; set; }

        // Token: 0x170002BB RID: 699
        // (get) Token: 0x0600069B RID: 1691 RVA: 0x0000F7EE File Offset: 0x0000D9EE
        // (set) Token: 0x0600069C RID: 1692 RVA: 0x0000F7F6 File Offset: 0x0000D9F6
        public string Url { get; set; }

        // Token: 0x170002BC RID: 700
        // (get) Token: 0x0600069D RID: 1693 RVA: 0x0000F7FF File Offset: 0x0000D9FF
        // (set) Token: 0x0600069E RID: 1694 RVA: 0x0000F807 File Offset: 0x0000DA07
        public string Intent { get; set; }

        // Token: 0x170002BD RID: 701
        // (get) Token: 0x0600069F RID: 1695 RVA: 0x0000F810 File Offset: 0x0000DA10
        // (set) Token: 0x060006A0 RID: 1696 RVA: 0x0000F818 File Offset: 0x0000DA18
        public NotifyInfo.Types.Type Type { get; set; }

        // Token: 0x04000393 RID: 915
        private int? notifyId;
	}
}
