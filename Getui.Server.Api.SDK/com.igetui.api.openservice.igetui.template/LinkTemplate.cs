using System;
using System.Collections.Generic;
using com.gexin.rp.sdk.dto;
using com.igetui.api.openservice.igetui.template.style;
using Newtonsoft.Json;

namespace com.igetui.api.openservice.igetui.template
{
	// Token: 0x0200004E RID: 78
	public class LinkTemplate : AbstractTemplate
	{
		// Token: 0x060005DD RID: 1501 RVA: 0x0000D768 File Offset: 0x0000B968
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

        // Token: 0x17000278 RID: 632
        // (get) Token: 0x060005DE RID: 1502 RVA: 0x0000D7F9 File Offset: 0x0000B9F9
        // (set) Token: 0x060005DF RID: 1503 RVA: 0x0000D801 File Offset: 0x0000BA01
        public bool IsRing { get; set; } = true;

        // Token: 0x17000279 RID: 633
        // (get) Token: 0x060005E0 RID: 1504 RVA: 0x0000D80A File Offset: 0x0000BA0A
        // (set) Token: 0x060005E1 RID: 1505 RVA: 0x0000D812 File Offset: 0x0000BA12
        public bool IsVibrate { get; set; } = true;

        // Token: 0x1700027A RID: 634
        // (get) Token: 0x060005E2 RID: 1506 RVA: 0x0000D81B File Offset: 0x0000BA1B
        // (set) Token: 0x060005E3 RID: 1507 RVA: 0x0000D823 File Offset: 0x0000BA23
        public bool IsClearable { get; set; } = true;

        // Token: 0x1700027B RID: 635
        // (get) Token: 0x060005E4 RID: 1508 RVA: 0x0000D82C File Offset: 0x0000BA2C
        // (set) Token: 0x060005E5 RID: 1509 RVA: 0x0000D834 File Offset: 0x0000BA34
        public string Text { get; set; }

        // Token: 0x1700027C RID: 636
        // (get) Token: 0x060005E6 RID: 1510 RVA: 0x0000D83D File Offset: 0x0000BA3D
        // (set) Token: 0x060005E7 RID: 1511 RVA: 0x0000D845 File Offset: 0x0000BA45
        public string Title { get; set; }

        // Token: 0x1700027D RID: 637
        // (get) Token: 0x060005E8 RID: 1512 RVA: 0x0000D84E File Offset: 0x0000BA4E
        // (set) Token: 0x060005E9 RID: 1513 RVA: 0x0000D856 File Offset: 0x0000BA56
        public string Logo { get; set; } = "";

        // Token: 0x1700027E RID: 638
        // (get) Token: 0x060005EA RID: 1514 RVA: 0x0000D85F File Offset: 0x0000BA5F
        // (set) Token: 0x060005EB RID: 1515 RVA: 0x0000D867 File Offset: 0x0000BA67
        public string LogoURL
		{
			get
			{
				return logoURL;
			}
			set
			{
				logoURL = value;
			}
		}

        // Token: 0x1700027F RID: 639
        // (get) Token: 0x060005EC RID: 1516 RVA: 0x0000D870 File Offset: 0x0000BA70
        // (set) Token: 0x060005ED RID: 1517 RVA: 0x0000D878 File Offset: 0x0000BA78
        public string Url { get; set; }

        // Token: 0x060005EE RID: 1518 RVA: 0x0000D884 File Offset: 0x0000BA84
        public override List<ActionChain> getActionChain()
		{
			List<ActionChain> list = new List<ActionChain>();
			ActionChain item = ActionChain.CreateBuilder().SetActionId(1).SetType(ActionChain.Types.Type.Goto).SetNext(10000).Build();
			ActionChain item2 = (style == null) ? ActionChain.CreateBuilder().SetActionId(10000).SetType(ActionChain.Types.Type.mmsinbox2).SetStype("notification").AddField(InnerFiled.CreateBuilder().SetKey("notifyid").SetVal((notifyid == null) ? "" : notifyid.ToString()).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("title").SetVal(Title).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("text").SetVal(Text).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("logo").SetVal(Logo).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("logo_url").SetVal(logoURL).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("notifyStyle").SetVal(notifyStyle.ToString()).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_noring").SetVal((!IsRing).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_noclear").SetVal((!IsClearable).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_novibrate").SetVal((!IsVibrate).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).SetNext(10010).Build() : style.getActionChain().ToBuilder().AddField(InnerFiled.CreateBuilder().SetKey("notifyid").SetVal((notifyid == null) ? "" : notifyid.ToString()).SetType(InnerFiled.Types.Type.str).Build()).Build();
			ActionChain item3 = ActionChain.CreateBuilder().SetActionId(10010).SetType(ActionChain.Types.Type.Goto).SetNext(10030).Build();
			ActionChain item4 = ActionChain.CreateBuilder().SetActionId(10030).SetType(ActionChain.Types.Type.startweb).SetUrl(Url).SetNext(100).Build();
			ActionChain item5 = ActionChain.CreateBuilder().SetActionId(100).SetType(ActionChain.Types.Type.eoa).Build();
			list.Add(item);
			list.Add(item2);
			list.Add(item3);
			list.Add(item4);
			list.Add(item5);
			return list;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x0000DBD0 File Offset: 0x0000BDD0
		public override string getPushType()
		{
			return "NotifyMsg";
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0000DBD7 File Offset: 0x0000BDD7
		protected override int getTemplateId()
		{
			return 1;
		}

        // Token: 0x04000341 RID: 833
        private string logoURL = "";

        // Token: 0x04000346 RID: 838
        private AbstractNotifyStyle style;

		// Token: 0x04000347 RID: 839
		private int notifyStyle;

		// Token: 0x04000348 RID: 840
		private int? notifyid;
	}
}
