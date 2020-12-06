using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using com.gexin.rp.sdk.dto;
using com.igetui.api.openservice.igetui.template.style;
using com.igetui.api.openservice.payload;
using Newtonsoft.Json;

namespace com.igetui.api.openservice.igetui.template
{
	// Token: 0x02000052 RID: 82
	public class StartActivityTemplate : AbstractTemplate
	{
		// Token: 0x06000641 RID: 1601 RVA: 0x0000E8B4 File Offset: 0x0000CAB4
		public void setNotifyid(int? notifyid)
		{
			int? num = notifyid;
			int num2 = 0;
			if (num.GetValueOrDefault() < num2 & num != null)
			{
				throw new Exception("notifyid need greater than 0");
			}
			if (!getPushInfoBuilder().InvalidAPN)
			{
				Dictionary<string, object> dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(getPushInfoBuilder().ApnJson);
				if (string.IsNullOrEmpty((string)dictionary["apns-collapse-id"]))
				{
					dictionary.Add("apns-collapse-id", notifyid);
					string apnJson = JsonConvert.SerializeObject(dictionary);
                    getPushInfoBuilder().SetApnJson(apnJson);
				}
			}
			this.notifyid = notifyid;
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0000E948 File Offset: 0x0000CB48
		public new void setAPNInfo(Payload apn)
		{
			if (apn is APNPayload)
			{
				APNPayload apnpayload = (APNPayload)apn;
				if (notifyid != null && string.IsNullOrEmpty(apnpayload.getApnsCollapseId()))
				{
					apnpayload.setApnsCollapseId(notifyid.ToString());
				}
			}
			base.setAPNInfo(apn);
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0000E99C File Offset: 0x0000CB9C
		public override string getPushType()
		{
			return "StartActivity";
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0000E9A4 File Offset: 0x0000CBA4
		public override List<ActionChain> getActionChain()
		{
			List<ActionChain> list = new List<ActionChain>();
			ActionChain item = ActionChain.CreateBuilder().SetActionId(1).SetType(ActionChain.Types.Type.Goto).SetNext(10000).Build();
			ActionChain item2 = style.getActionChain().ToBuilder().AddField(InnerFiled.CreateBuilder().SetKey("notifyid").SetVal((notifyid == null) ? "" : (string.Concat(notifyid) ?? "")).SetType(InnerFiled.Types.Type.str).Build()).Build();
			ActionChain item3 = ActionChain.CreateBuilder().SetActionId(10010).SetType(ActionChain.Types.Type.Goto).SetNext(11220).Build();
			ActionChain item4 = ActionChain.CreateBuilder().SetActionId(11220).SetType(ActionChain.Types.Type.mmsinbox2).SetStype("startmyactivity").AddField(InnerFiled.CreateBuilder().SetKey("uri").SetVal(getIntent()).SetType(InnerFiled.Types.Type.str)).AddField(InnerFiled.CreateBuilder().SetKey("do_failed").SetVal("100").SetType(InnerFiled.Types.Type.str)).SetNext(100).Build();
			ActionChain item5 = ActionChain.CreateBuilder().SetActionId(100).SetType(ActionChain.Types.Type.eoa).Build();
			list.Add(item);
			list.Add(item2);
			list.Add(item3);
			list.Add(item4);
			list.Add(item5);
			return list;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0000EB16 File Offset: 0x0000CD16
		private string getIntent()
		{
			if (intent != null)
			{
				return intent;
			}
			return "";
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0000EB2C File Offset: 0x0000CD2C
		public void setStyle(AbstractNotifyStyle style)
		{
			this.style = style;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0000EB35 File Offset: 0x0000CD35
		public bool setIntent(string intent)
		{
			if (intent.Length <= 1000 && Regex.IsMatch(intent, pattern))
			{
				this.intent = intent;
				return true;
			}
			return false;
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0000EB5C File Offset: 0x0000CD5C
		protected override int getTemplateId()
		{
			return 7;
		}

		// Token: 0x0400036E RID: 878
		private string intent;

		// Token: 0x0400036F RID: 879
		private int? notifyid;

		// Token: 0x04000370 RID: 880
		private string pattern = "^(intent:).*(;end)$";

		// Token: 0x04000371 RID: 881
		private AbstractNotifyStyle style;
	}
}
