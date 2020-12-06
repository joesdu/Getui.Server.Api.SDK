using com.gexin.rp.sdk.dto;

namespace com.igetui.api.openservice.igetui.template.style
{
    // Token: 0x02000059 RID: 89
    public class Style6 : AbstractNotifyStyle
	{
        // Token: 0x170002B0 RID: 688
        // (get) Token: 0x0600067E RID: 1662 RVA: 0x0000F3F9 File Offset: 0x0000D5F9
        // (set) Token: 0x0600067F RID: 1663 RVA: 0x0000F401 File Offset: 0x0000D601
        public string BigStyle { get; set; } = "";

        // Token: 0x170002B1 RID: 689
        // (get) Token: 0x06000680 RID: 1664 RVA: 0x0000F40A File Offset: 0x0000D60A
        // (set) Token: 0x06000681 RID: 1665 RVA: 0x0000F412 File Offset: 0x0000D612
        public string BigImageUrl { get; set; } = "";

        // Token: 0x170002B2 RID: 690
        // (get) Token: 0x06000682 RID: 1666 RVA: 0x0000F41B File Offset: 0x0000D61B
        // (set) Token: 0x06000683 RID: 1667 RVA: 0x0000F423 File Offset: 0x0000D623
        public string BigText { get; set; } = "";

        // Token: 0x170002B3 RID: 691
        // (get) Token: 0x06000684 RID: 1668 RVA: 0x0000F42C File Offset: 0x0000D62C
        // (set) Token: 0x06000685 RID: 1669 RVA: 0x0000F434 File Offset: 0x0000D634
        public string BannerUrl { get; set; } = "";

        // Token: 0x170002B4 RID: 692
        // (get) Token: 0x06000686 RID: 1670 RVA: 0x0000F43D File Offset: 0x0000D63D
        // (set) Token: 0x06000687 RID: 1671 RVA: 0x0000F445 File Offset: 0x0000D645
        public string Text { get; set; }

        // Token: 0x170002B5 RID: 693
        // (get) Token: 0x06000688 RID: 1672 RVA: 0x0000F44E File Offset: 0x0000D64E
        // (set) Token: 0x06000689 RID: 1673 RVA: 0x0000F456 File Offset: 0x0000D656
        public string Title { get; set; }

        // Token: 0x170002B6 RID: 694
        // (get) Token: 0x0600068A RID: 1674 RVA: 0x0000F45F File Offset: 0x0000D65F
        // (set) Token: 0x0600068B RID: 1675 RVA: 0x0000F467 File Offset: 0x0000D667
        public string Logo { get; set; } = "";

        // Token: 0x170002B7 RID: 695
        // (get) Token: 0x0600068C RID: 1676 RVA: 0x0000F470 File Offset: 0x0000D670
        // (set) Token: 0x0600068D RID: 1677 RVA: 0x0000F478 File Offset: 0x0000D678
        public string LogoUrl { get; set; } = "";

        // Token: 0x0600068E RID: 1678 RVA: 0x0000F481 File Offset: 0x0000D681
        public void setBigStyle1(string bigImageUrl)
		{
			BigStyle = "1";
			BigImageUrl = bigImageUrl;
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0000F495 File Offset: 0x0000D695
		public void setBigStyle2(string bigText)
		{
			BigStyle = "2";
			BigText = bigText;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0000F4A9 File Offset: 0x0000D6A9
		public void setBigStyle3(string bigImageUrl, string bannerUrl)
		{
			BigStyle = "3";
			BigImageUrl = bigImageUrl;
			BannerUrl = bannerUrl;
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0000F4C4 File Offset: 0x0000D6C4
		public override ActionChain getActionChain()
		{
			return actionChainBuilder.AddField(InnerFiled.CreateBuilder().SetKey("title").SetVal(Title).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("text").SetVal(Text).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("logo").SetVal(Logo).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("logo_url").SetVal(LogoUrl).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("notifyStyle").SetVal("6").SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_noring").SetVal((!isRing).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_noclear").SetVal((!isClearable).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_novibrate").SetVal((!isVibrate).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("bigStyle").SetVal(BigStyle).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("big_image_url").SetVal(BigImageUrl).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("banner_url").SetVal(BannerUrl).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("big_text").SetVal(BigText).SetType(InnerFiled.Types.Type.str).Build()).Build();
		}
    }
}
