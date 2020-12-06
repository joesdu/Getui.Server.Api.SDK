using System;
using com.gexin.rp.sdk.dto;

namespace com.igetui.api.openservice.igetui.template.style
{
	// Token: 0x02000056 RID: 86
	public class Style0 : AbstractNotifyStyle
	{
        // Token: 0x170002A3 RID: 675
        // (get) Token: 0x0600065E RID: 1630 RVA: 0x0000EDDB File Offset: 0x0000CFDB
        // (set) Token: 0x0600065F RID: 1631 RVA: 0x0000EDE3 File Offset: 0x0000CFE3
        public string Text { get; set; }

        // Token: 0x170002A4 RID: 676
        // (get) Token: 0x06000660 RID: 1632 RVA: 0x0000EDEC File Offset: 0x0000CFEC
        // (set) Token: 0x06000661 RID: 1633 RVA: 0x0000EDF4 File Offset: 0x0000CFF4
        public string Title { get; set; }

        // Token: 0x170002A5 RID: 677
        // (get) Token: 0x06000662 RID: 1634 RVA: 0x0000EDFD File Offset: 0x0000CFFD
        // (set) Token: 0x06000663 RID: 1635 RVA: 0x0000EE05 File Offset: 0x0000D005
        public string Logo { get; set; } = "";

        // Token: 0x170002A6 RID: 678
        // (get) Token: 0x06000664 RID: 1636 RVA: 0x0000EE0E File Offset: 0x0000D00E
        // (set) Token: 0x06000665 RID: 1637 RVA: 0x0000EE16 File Offset: 0x0000D016
        public string LogoUrl { get; set; } = "";

        // Token: 0x170002A7 RID: 679
        // (get) Token: 0x06000666 RID: 1638 RVA: 0x0000EE1F File Offset: 0x0000D01F
        // (set) Token: 0x06000667 RID: 1639 RVA: 0x0000EE27 File Offset: 0x0000D027
        public new bool IsRing { get; set; } = true;

        // Token: 0x170002A8 RID: 680
        // (get) Token: 0x06000668 RID: 1640 RVA: 0x0000EE30 File Offset: 0x0000D030
        // (set) Token: 0x06000669 RID: 1641 RVA: 0x0000EE38 File Offset: 0x0000D038
        public new bool IsVibrate
		{
			get
			{
				return isVibrate;
			}
			set
			{
				isVibrate = value;
			}
		}

        // Token: 0x170002A9 RID: 681
        // (get) Token: 0x0600066A RID: 1642 RVA: 0x0000EE41 File Offset: 0x0000D041
        // (set) Token: 0x0600066B RID: 1643 RVA: 0x0000EE49 File Offset: 0x0000D049
        public new bool IsClearable { get; set; } = true;

        // Token: 0x0600066C RID: 1644 RVA: 0x0000EE54 File Offset: 0x0000D054
        public override ActionChain getActionChain()
		{
			return actionChainBuilder.AddField(InnerFiled.CreateBuilder().SetKey("title").SetVal(Title).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("text").SetVal(Text).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("logo").SetVal(Logo).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("logo_url").SetVal(LogoUrl).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("notifyStyle").SetVal("0").SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_noring").SetVal((!IsRing).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_noclear").SetVal((!IsClearable).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_novibrate").SetVal((!isVibrate).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).Build();
		}

        // Token: 0x0400037D RID: 893
        private new bool isVibrate = true;
    }
}
