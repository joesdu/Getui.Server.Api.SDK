using System;
using com.gexin.rp.sdk.dto;

namespace com.igetui.api.openservice.igetui.template.style
{
	// Token: 0x02000054 RID: 84
	public abstract class AbstractNotifyStyle : INotifyStyle
	{
		// Token: 0x06000655 RID: 1621 RVA: 0x0000ED50 File Offset: 0x0000CF50
		public AbstractNotifyStyle()
		{
			actionChainBuilder = ActionChain.CreateBuilder().SetActionId(10000).SetType(ActionChain.Types.Type.mmsinbox2).SetStype("notification").SetNext(10010);
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x0000EDA8 File Offset: 0x0000CFA8
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x0000EDB0 File Offset: 0x0000CFB0
		public bool IsRing
		{
			get
			{
				return isRing;
			}
			set
			{
				isRing = value;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x0000EDB9 File Offset: 0x0000CFB9
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x0000EDC1 File Offset: 0x0000CFC1
		public bool IsVibrate
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

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x0000EDCA File Offset: 0x0000CFCA
		// (set) Token: 0x0600065B RID: 1627 RVA: 0x0000EDD2 File Offset: 0x0000CFD2
		public bool IsClearable
		{
			get
			{
				return isClearable;
			}
			set
			{
				isClearable = value;
			}
		}

		// Token: 0x0600065C RID: 1628
		public abstract ActionChain getActionChain();

		// Token: 0x04000374 RID: 884
		protected bool isRing = true;

		// Token: 0x04000375 RID: 885
		protected bool isVibrate = true;

		// Token: 0x04000376 RID: 886
		protected bool isClearable = true;

		// Token: 0x04000377 RID: 887
		protected ActionChain.Builder actionChainBuilder;
	}
}
