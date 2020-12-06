using System;
using System.Collections.Generic;
using com.gexin.rp.sdk.dto;

namespace com.igetui.api.openservice.igetui.template
{
	// Token: 0x02000051 RID: 81
	public class RevokeTemplate : AbstractTemplate
	{
		// Token: 0x06000639 RID: 1593 RVA: 0x0000E7B8 File Offset: 0x0000C9B8
		public bool isForce()
		{
			return force;
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0000E7C0 File Offset: 0x0000C9C0
		public void setForce(bool value)
		{
			force = value;
		}

        // Token: 0x1700029D RID: 669
        // (get) Token: 0x0600063B RID: 1595 RVA: 0x0000E7C9 File Offset: 0x0000C9C9
        // (set) Token: 0x0600063C RID: 1596 RVA: 0x0000E7D1 File Offset: 0x0000C9D1
        public string OldTaskId { get; set; }

        // Token: 0x0600063D RID: 1597 RVA: 0x0000E7DC File Offset: 0x0000C9DC
        public override List<ActionChain> getActionChain()
		{
			List<ActionChain> list = new List<ActionChain>();
			ActionChain item = ActionChain.CreateBuilder().SetActionId(1).SetType(ActionChain.Types.Type.mmsinbox2).SetStype("terminatetask").AddField(InnerFiled.CreateBuilder().SetKey("taskid").SetVal(OldTaskId).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("force").SetVal(force ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).SetNext(100).Build();
			ActionChain item2 = ActionChain.CreateBuilder().SetActionId(100).SetType(ActionChain.Types.Type.eoa).Build();
			list.Add(item);
			list.Add(item2);
			return list;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0000E89F File Offset: 0x0000CA9F
		public override string getPushType()
		{
			return "Revoke";
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0000E8A6 File Offset: 0x0000CAA6
		protected override int getTemplateId()
		{
			return 8;
		}

		// Token: 0x0400036C RID: 876
		private bool force;
    }
}
