using System;
using com.gexin.rp.sdk.dto;

namespace com.igetui.api.openservice.igetui.template.style
{
	// Token: 0x02000058 RID: 88
	public class Style4 : AbstractNotifyStyle
	{
        // Token: 0x170002AE RID: 686
        // (get) Token: 0x06000679 RID: 1657 RVA: 0x0000F273 File Offset: 0x0000D473
        // (set) Token: 0x0600067A RID: 1658 RVA: 0x0000F27B File Offset: 0x0000D47B
        public string Logo { get; set; } = "";

        // Token: 0x170002AF RID: 687
        // (get) Token: 0x0600067B RID: 1659 RVA: 0x0000F284 File Offset: 0x0000D484
        // (set) Token: 0x0600067C RID: 1660 RVA: 0x0000F28C File Offset: 0x0000D48C
        public string Banner_url { get; set; } = "";

        // Token: 0x0600067D RID: 1661 RVA: 0x0000F298 File Offset: 0x0000D498
        public override ActionChain getActionChain()
		{
			return actionChainBuilder.AddField(InnerFiled.CreateBuilder().SetKey("logo").SetVal(Logo).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("banner_url").SetVal(Banner_url).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_noring").SetVal((!isRing).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_noclear").SetVal((!isClearable).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_novibrate").SetVal((!isVibrate).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("notifyStyle").SetVal("4").SetType(InnerFiled.Types.Type.str).Build()).Build();
		}
    }
}
