using System;
using System.Collections.Generic;
using com.gexin.rp.sdk.dto;
using com.igetui.api.openservice.igetui.template.style;
using com.igetui.api.openservice.payload;
using Newtonsoft.Json;

namespace com.igetui.api.openservice.igetui.template
{
	// Token: 0x0200004F RID: 79
	public class NotificationTemplate : AbstractTemplate
	{
		// Token: 0x060005F2 RID: 1522 RVA: 0x0000DC10 File Offset: 0x0000BE10
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

        // Token: 0x17000280 RID: 640
        // (get) Token: 0x060005F3 RID: 1523 RVA: 0x0000DCA1 File Offset: 0x0000BEA1
        // (set) Token: 0x060005F4 RID: 1524 RVA: 0x0000DCA9 File Offset: 0x0000BEA9
        public bool IsRing { get; set; } = true;

        // Token: 0x17000281 RID: 641
        // (get) Token: 0x060005F5 RID: 1525 RVA: 0x0000DCB2 File Offset: 0x0000BEB2
        // (set) Token: 0x060005F6 RID: 1526 RVA: 0x0000DCBA File Offset: 0x0000BEBA
        public bool IsVibrate { get; set; } = true;

        // Token: 0x17000282 RID: 642
        // (get) Token: 0x060005F7 RID: 1527 RVA: 0x0000DCC3 File Offset: 0x0000BEC3
        // (set) Token: 0x060005F8 RID: 1528 RVA: 0x0000DCCB File Offset: 0x0000BECB
        public bool IsClearable { get; set; } = true;

        // Token: 0x17000283 RID: 643
        // (get) Token: 0x060005F9 RID: 1529 RVA: 0x0000DCD4 File Offset: 0x0000BED4
        // (set) Token: 0x060005FA RID: 1530 RVA: 0x0000DCDC File Offset: 0x0000BEDC
        public string Text { get; set; }

        // Token: 0x17000284 RID: 644
        // (get) Token: 0x060005FB RID: 1531 RVA: 0x0000DCE5 File Offset: 0x0000BEE5
        // (set) Token: 0x060005FC RID: 1532 RVA: 0x0000DCED File Offset: 0x0000BEED
        public string Title { get; set; }

        // Token: 0x17000285 RID: 645
        // (get) Token: 0x060005FD RID: 1533 RVA: 0x0000DCF6 File Offset: 0x0000BEF6
        // (set) Token: 0x060005FE RID: 1534 RVA: 0x0000DCFE File Offset: 0x0000BEFE
        public string Logo { get; set; } = "";

        // Token: 0x17000286 RID: 646
        // (get) Token: 0x060005FF RID: 1535 RVA: 0x0000DD07 File Offset: 0x0000BF07
        // (set) Token: 0x06000600 RID: 1536 RVA: 0x0000DD0F File Offset: 0x0000BF0F
        public string LogoURL { get; set; } = "";

        // Token: 0x17000287 RID: 647
        // (get) Token: 0x06000601 RID: 1537 RVA: 0x0000DD18 File Offset: 0x0000BF18
        // (set) Token: 0x06000602 RID: 1538 RVA: 0x0000DD20 File Offset: 0x0000BF20
        public int TransmissionType { get; set; }

        // Token: 0x17000288 RID: 648
        // (get) Token: 0x06000603 RID: 1539 RVA: 0x0000DD29 File Offset: 0x0000BF29
        // (set) Token: 0x06000604 RID: 1540 RVA: 0x0000DD31 File Offset: 0x0000BF31
        public string TransmissionContent
		{
			get
			{
				return transmissionContent;
			}
			set
			{
				transmissionContent = value;
			}
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0000DD3C File Offset: 0x0000BF3C
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

		// Token: 0x06000606 RID: 1542 RVA: 0x0000DD90 File Offset: 0x0000BF90
		public override List<ActionChain> getActionChain()
		{
			List<ActionChain> list = new List<ActionChain>();
			ActionChain item = ActionChain.CreateBuilder().SetActionId(1).SetType(ActionChain.Types.Type.Goto).SetNext(10000).Build();
			ActionChain item2 = (style == null) ? ActionChain.CreateBuilder().SetActionId(10000).SetType(ActionChain.Types.Type.mmsinbox2).SetStype("notification").AddField(InnerFiled.CreateBuilder().SetKey("notifyid").SetVal((notifyid == null) ? "" : notifyid.ToString()).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("title").SetVal(Title).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("text").SetVal(Text).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("logo").SetVal(Logo).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("logo_url").SetVal(LogoURL).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("notifyStyle").SetVal(notifyStyle.ToString()).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_noring").SetVal((!IsRing).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_noclear").SetVal((!IsClearable).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_novibrate").SetVal((!IsVibrate).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).SetNext(10010).Build() : style.getActionChain().ToBuilder().AddField(InnerFiled.CreateBuilder().SetKey("notifyid").SetVal((notifyid == null) ? "" : notifyid.ToString()).SetType(InnerFiled.Types.Type.str).Build()).Build();
			ActionChain item3 = ActionChain.CreateBuilder().SetActionId(10010).SetType(ActionChain.Types.Type.Goto).SetNext(10030).Build();
			AppStartUp appstartupid = AppStartUp.CreateBuilder().SetAndroid("").SetSymbia("").SetIos("").Build();
			ActionChain item4 = ActionChain.CreateBuilder().SetActionId(10030).SetType(ActionChain.Types.Type.startapp).SetAppid("").SetAutostart(1 == TransmissionType).SetAppstartupid(appstartupid).SetFailedAction(100).SetNext(100).Build();
			ActionChain item5 = ActionChain.CreateBuilder().SetActionId(100).SetType(ActionChain.Types.Type.eoa).Build();
			list.Add(item);
			list.Add(item2);
			list.Add(item3);
			list.Add(item4);
			list.Add(item5);
			return list;
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x0000E121 File Offset: 0x0000C321
		public override string getTransmissionContent()
		{
			return transmissionContent;
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0000E129 File Offset: 0x0000C329
		public override string getPushType()
		{
			return "NotifyMsg";
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0000E130 File Offset: 0x0000C330
		public void setStyle(AbstractNotifyStyle style)
		{
			this.style = style;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0000E139 File Offset: 0x0000C339
		protected override int getTemplateId()
		{
			return 0;
		}

        // Token: 0x0400034E RID: 846
        private string transmissionContent;

        // Token: 0x04000352 RID: 850
        private int notifyStyle;

		// Token: 0x04000353 RID: 851
		private int? notifyid;

		// Token: 0x04000354 RID: 852
		private AbstractNotifyStyle style;
	}
}
