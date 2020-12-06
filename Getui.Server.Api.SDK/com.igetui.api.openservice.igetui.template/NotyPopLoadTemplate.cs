using System;
using System.Collections.Generic;
using com.gexin.rp.sdk.dto;
using com.igetui.api.openservice.igetui.template.style;

namespace com.igetui.api.openservice.igetui.template
{
	// Token: 0x02000050 RID: 80
	public class NotyPopLoadTemplate : AbstractTemplate
	{
		// Token: 0x0600060C RID: 1548 RVA: 0x0000E170 File Offset: 0x0000C370
		public void setNotifyid(int? notifyid)
		{
			int? num = notifyid;
			int num2 = 0;
			if (num.GetValueOrDefault() < num2 & num != null)
			{
				throw new Exception("notifyid need greater than 0");
			}
			this.notifyid = notifyid;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0000E1A8 File Offset: 0x0000C3A8
		public override List<ActionChain> getActionChain()
		{
			List<ActionChain> list = new List<ActionChain>();
			ActionChain item = ActionChain.CreateBuilder().SetActionId(1).SetType(ActionChain.Types.Type.Goto).SetNext(10000).Build();
			ActionChain item2 = (style == null) ? ActionChain.CreateBuilder().SetActionId(10000).SetType(ActionChain.Types.Type.mmsinbox2).SetStype("notification").AddField(InnerFiled.CreateBuilder().SetKey("notifyid").SetVal((notifyid == null) ? "" : notifyid.ToString()).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("title").SetVal(NotyTitle).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("text").SetVal(NotyContent).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("logo").SetVal(NotyIcon).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("logo_url").SetVal(LogoURL).SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("notifyStyle").SetVal(string.Concat(notifyStyle) ?? "").SetType(InnerFiled.Types.Type.str).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_noring").SetVal((!IsBelled).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_noclear").SetVal((!IsCleared).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).AddField(InnerFiled.CreateBuilder().SetKey("is_novibrate").SetVal((!IsVibrationed).Equals(true) ? "true" : "false").SetType(InnerFiled.Types.Type.boole).Build()).SetNext(10010).Build() : style.getActionChain().ToBuilder().AddField(InnerFiled.CreateBuilder().SetKey("notifyid").SetVal((notifyid == null) ? "" : notifyid.ToString()).SetType(InnerFiled.Types.Type.str).Build()).Build();
			ActionChain item3 = ActionChain.CreateBuilder().SetActionId(10010).SetType(ActionChain.Types.Type.Goto).SetNext(10020).Build();
			Button value = Button.CreateBuilder().SetText(PopButton1).SetNext(10040).Build();
			Button value2 = Button.CreateBuilder().SetText(PopButton2).SetNext(100).Build();
			ActionChain item4 = ActionChain.CreateBuilder().SetActionId(10020).SetType(ActionChain.Types.Type.popup).SetTitle(PopTitle).SetText(PopContent).SetImg(popImage).AddButtons(value).AddButtons(value2).SetNext(6).Build();
			AppStartUp appstartupid = AppStartUp.CreateBuilder().SetAndroid(AndroidMark).SetSymbia(SymbianMark).SetIos(iphoneMark).Build();
			ActionChain item5 = ActionChain.CreateBuilder().SetActionId(10040).SetType(ActionChain.Types.Type.appdownload).SetName(LoadTitle).SetUrl(LoadUrl).SetLogo(LoadIcon).SetLogoURL(LogoURL).SetAutoInstall(IsAutoInstall).SetAutostart(IsActived).SetAppstartupid(appstartupid).SetNext(6).Build();
			ActionChain item6 = ActionChain.CreateBuilder().SetActionId(100).SetType(ActionChain.Types.Type.eoa).Build();
			list.Add(item);
			list.Add(item2);
			list.Add(item3);
			list.Add(item4);
			list.Add(item5);
			list.Add(item6);
			return list;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0000E604 File Offset: 0x0000C804
		public override string getPushType()
		{
			return "NotyPopLoadTemplate";
		}

        // Token: 0x17000289 RID: 649
        // (get) Token: 0x0600060F RID: 1551 RVA: 0x0000E60B File Offset: 0x0000C80B
        // (set) Token: 0x06000610 RID: 1552 RVA: 0x0000E613 File Offset: 0x0000C813
        public string NotyIcon { get; set; }

        // Token: 0x1700028A RID: 650
        // (get) Token: 0x06000611 RID: 1553 RVA: 0x0000E61C File Offset: 0x0000C81C
        // (set) Token: 0x06000612 RID: 1554 RVA: 0x0000E624 File Offset: 0x0000C824
        public string LogoURL { get; set; } = "";

        // Token: 0x1700028B RID: 651
        // (get) Token: 0x06000613 RID: 1555 RVA: 0x0000E62D File Offset: 0x0000C82D
        // (set) Token: 0x06000614 RID: 1556 RVA: 0x0000E635 File Offset: 0x0000C835
        public string NotyTitle { get; set; }

        // Token: 0x1700028C RID: 652
        // (get) Token: 0x06000615 RID: 1557 RVA: 0x0000E63E File Offset: 0x0000C83E
        // (set) Token: 0x06000616 RID: 1558 RVA: 0x0000E646 File Offset: 0x0000C846
        public string NotyContent { get; set; }

        // Token: 0x1700028D RID: 653
        // (get) Token: 0x06000617 RID: 1559 RVA: 0x0000E64F File Offset: 0x0000C84F
        // (set) Token: 0x06000618 RID: 1560 RVA: 0x0000E657 File Offset: 0x0000C857
        public bool IsCleared { get; set; } = true;

        // Token: 0x1700028E RID: 654
        // (get) Token: 0x06000619 RID: 1561 RVA: 0x0000E660 File Offset: 0x0000C860
        // (set) Token: 0x0600061A RID: 1562 RVA: 0x0000E668 File Offset: 0x0000C868
        public bool IsBelled { get; set; } = true;

        // Token: 0x1700028F RID: 655
        // (get) Token: 0x0600061B RID: 1563 RVA: 0x0000E671 File Offset: 0x0000C871
        // (set) Token: 0x0600061C RID: 1564 RVA: 0x0000E679 File Offset: 0x0000C879
        public bool IsVibrationed { get; set; } = true;

        // Token: 0x17000290 RID: 656
        // (get) Token: 0x0600061D RID: 1565 RVA: 0x0000E682 File Offset: 0x0000C882
        // (set) Token: 0x0600061E RID: 1566 RVA: 0x0000E68A File Offset: 0x0000C88A
        public string PopTitle { get; set; }

        // Token: 0x17000291 RID: 657
        // (get) Token: 0x0600061F RID: 1567 RVA: 0x0000E693 File Offset: 0x0000C893
        // (set) Token: 0x06000620 RID: 1568 RVA: 0x0000E69B File Offset: 0x0000C89B
        public string PopContent { get; set; }

        // Token: 0x17000292 RID: 658
        // (get) Token: 0x06000621 RID: 1569 RVA: 0x0000E6A4 File Offset: 0x0000C8A4
        // (set) Token: 0x06000622 RID: 1570 RVA: 0x0000E6AC File Offset: 0x0000C8AC
        public string PopImage
		{
			get
			{
				return popImage;
			}
			set
			{
				popImage = value;
			}
		}

        // Token: 0x17000293 RID: 659
        // (get) Token: 0x06000623 RID: 1571 RVA: 0x0000E6B5 File Offset: 0x0000C8B5
        // (set) Token: 0x06000624 RID: 1572 RVA: 0x0000E6BD File Offset: 0x0000C8BD
        public string PopButton1 { get; set; }

        // Token: 0x17000294 RID: 660
        // (get) Token: 0x06000625 RID: 1573 RVA: 0x0000E6C6 File Offset: 0x0000C8C6
        // (set) Token: 0x06000626 RID: 1574 RVA: 0x0000E6CE File Offset: 0x0000C8CE
        public string PopButton2 { get; set; }

        // Token: 0x17000295 RID: 661
        // (get) Token: 0x06000627 RID: 1575 RVA: 0x0000E6D7 File Offset: 0x0000C8D7
        // (set) Token: 0x06000628 RID: 1576 RVA: 0x0000E6DF File Offset: 0x0000C8DF
        public string LoadIcon { get; set; }

        // Token: 0x17000296 RID: 662
        // (get) Token: 0x06000629 RID: 1577 RVA: 0x0000E6E8 File Offset: 0x0000C8E8
        // (set) Token: 0x0600062A RID: 1578 RVA: 0x0000E6F0 File Offset: 0x0000C8F0
        public string LoadTitle { get; set; }

        // Token: 0x17000297 RID: 663
        // (get) Token: 0x0600062B RID: 1579 RVA: 0x0000E6F9 File Offset: 0x0000C8F9
        // (set) Token: 0x0600062C RID: 1580 RVA: 0x0000E701 File Offset: 0x0000C901
        public string LoadUrl { get; set; }

        // Token: 0x17000298 RID: 664
        // (get) Token: 0x0600062D RID: 1581 RVA: 0x0000E70A File Offset: 0x0000C90A
        // (set) Token: 0x0600062E RID: 1582 RVA: 0x0000E712 File Offset: 0x0000C912
        public bool IsAutoInstall { get; set; }

        // Token: 0x17000299 RID: 665
        // (get) Token: 0x0600062F RID: 1583 RVA: 0x0000E71B File Offset: 0x0000C91B
        // (set) Token: 0x06000630 RID: 1584 RVA: 0x0000E723 File Offset: 0x0000C923
        public bool IsActived { get; set; }

        // Token: 0x1700029A RID: 666
        // (get) Token: 0x06000631 RID: 1585 RVA: 0x0000E72C File Offset: 0x0000C92C
        // (set) Token: 0x06000632 RID: 1586 RVA: 0x0000E734 File Offset: 0x0000C934
        public string AndroidMark { get; set; } = "";

        // Token: 0x1700029B RID: 667
        // (get) Token: 0x06000633 RID: 1587 RVA: 0x0000E73D File Offset: 0x0000C93D
        // (set) Token: 0x06000634 RID: 1588 RVA: 0x0000E745 File Offset: 0x0000C945
        public string SymbianMark { get; set; } = "";

        // Token: 0x1700029C RID: 668
        // (get) Token: 0x06000635 RID: 1589 RVA: 0x0000E74E File Offset: 0x0000C94E
        // (set) Token: 0x06000636 RID: 1590 RVA: 0x0000E756 File Offset: 0x0000C956
        public string IphoneMark
		{
			get
			{
				return iphoneMark;
			}
			set
			{
				iphoneMark = value;
			}
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0000E75F File Offset: 0x0000C95F
		protected override int getTemplateId()
		{
			return 2;
		}

        // Token: 0x0400035E RID: 862
        private string popImage;

        // Token: 0x04000368 RID: 872
        private string iphoneMark = "";

		// Token: 0x04000369 RID: 873
		private int? notifyid;

		// Token: 0x0400036A RID: 874
		private AbstractNotifyStyle style;

		// Token: 0x0400036B RID: 875
		private int notifyStyle;
	}
}
