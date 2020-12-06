using System;
using System.Collections.Generic;
using com.gexin.rp.sdk.dto;
using com.igetui.api.openservice.igetui.template.notify;
using com.igetui.api.openservice.payload;
using Newtonsoft.Json;

namespace com.igetui.api.openservice.igetui.template
{
	// Token: 0x02000053 RID: 83
	public class TransmissionTemplate : AbstractTemplate
	{
		// Token: 0x1700029E RID: 670
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x0000EB72 File Offset: 0x0000CD72
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x0000EB7A File Offset: 0x0000CD7A
		public int TransmissionType { get; set; }

		// Token: 0x0600064C RID: 1612 RVA: 0x0000EB84 File Offset: 0x0000CD84
		public new void set3rdNotifyInfo(Notify notify)
		{
			if (!getPushInfoBuilder().InvalidAPN && notify.getNotifyId() != null)
			{
				Dictionary<string, object> dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(getPushInfoBuilder().ApnJson);
				if (string.IsNullOrEmpty((string)dictionary["apns-collapse-id"]))
				{
					dictionary.Add("apns-collapse-id", notify.getNotifyId());
					string apnJson = JsonConvert.SerializeObject(dictionary);
                    getPushInfoBuilder().SetApnJson(apnJson);
				}
			}
			base.set3rdNotifyInfo(notify);
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0000EC08 File Offset: 0x0000CE08
		public new void setAPNInfo(Payload apn)
		{
			if (apn is APNPayload)
			{
				APNPayload apnpayload = (APNPayload)apn;
				string notifyId = getPushInfo().NotifyInfo.NotifyId;
				if (notifyId != null && string.IsNullOrEmpty(apnpayload.getApnsCollapseId()))
				{
					apnpayload.setApnsCollapseId(notifyId);
				}
			}
			base.setAPNInfo(apn);
		}

        // Token: 0x1700029F RID: 671
        // (get) Token: 0x0600064E RID: 1614 RVA: 0x0000EC53 File Offset: 0x0000CE53
        // (set) Token: 0x0600064F RID: 1615 RVA: 0x0000EC5B File Offset: 0x0000CE5B
        public string TransmissionContent { get; set; }

        // Token: 0x06000650 RID: 1616 RVA: 0x0000EC64 File Offset: 0x0000CE64
        public override List<ActionChain> getActionChain()
		{
			List<ActionChain> list = new List<ActionChain>();
			ActionChain item = ActionChain.CreateBuilder().SetActionId(1).SetType(ActionChain.Types.Type.Goto).SetNext(10030).Build();
			AppStartUp appstartupid = AppStartUp.CreateBuilder().SetAndroid("").SetSymbia("").SetIos("").Build();
			ActionChain item2 = ActionChain.CreateBuilder().SetActionId(10030).SetType(ActionChain.Types.Type.startapp).SetAppid("").SetAutostart(1 == TransmissionType).SetAppstartupid(appstartupid).SetFailedAction(100).SetNext(100).Build();
			ActionChain item3 = ActionChain.CreateBuilder().SetActionId(100).SetType(ActionChain.Types.Type.eoa).Build();
			list.Add(item);
			list.Add(item2);
			list.Add(item3);
			return list;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x0000ED34 File Offset: 0x0000CF34
		public override string getTransmissionContent()
		{
			return TransmissionContent;
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0000ED3C File Offset: 0x0000CF3C
		public override string getPushType()
		{
			return "TransmissionMsg";
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0000ED43 File Offset: 0x0000CF43
		protected override int getTemplateId()
		{
			return 4;
		}
    }
}
