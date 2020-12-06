using System;
using com.gexin.rp.sdk.dto;

namespace com.igetui.api.openservice.igetui.template.style
{
	// Token: 0x02000057 RID: 87
	public class Style1 : AbstractNotifyStyle
	{
        // Token: 0x170002AA RID: 682
        // (get) Token: 0x0600066F RID: 1647 RVA: 0x0000F05A File Offset: 0x0000D25A
        // (set) Token: 0x06000670 RID: 1648 RVA: 0x0000F062 File Offset: 0x0000D262
        public string Text { get; set; }

        // Token: 0x170002AB RID: 683
        // (get) Token: 0x06000671 RID: 1649 RVA: 0x0000F06B File Offset: 0x0000D26B
        // (set) Token: 0x06000672 RID: 1650 RVA: 0x0000F073 File Offset: 0x0000D273
        public string Title { get; set; }

        // Token: 0x170002AC RID: 684
        // (get) Token: 0x06000673 RID: 1651 RVA: 0x0000F07C File Offset: 0x0000D27C
        // (set) Token: 0x06000674 RID: 1652 RVA: 0x0000F084 File Offset: 0x0000D284
        public string Logo { get; set; } = "";

        // Token: 0x170002AD RID: 685
        // (get) Token: 0x06000675 RID: 1653 RVA: 0x0000F08D File Offset: 0x0000D28D
        // (set) Token: 0x06000676 RID: 1654 RVA: 0x0000F095 File Offset: 0x0000D295
        public string LogoUrl
		{
			get
			{
				return logoUrl;
			}
			set
			{
				logoUrl = value;
			}
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x0000F0A0 File Offset: 0x0000D2A0
		public override ActionChain getActionChain()
		{
			return actionChainBuilder.AddField(InnerFiled.CreateBuilder().SetKey("title").SetVal(Title).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("text").SetVal(Text).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("logo").SetVal(Logo).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("logo_url").SetVal(logoUrl).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("notifyStyle").SetVal("1").SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_noring").SetVal((!isRing).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_noclear").SetVal((!isClearable).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_novibrate").SetVal((!isVibrate).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).Build();
		}

        // Token: 0x04000382 RID: 898
        private string logoUrl = "";
	}
}
