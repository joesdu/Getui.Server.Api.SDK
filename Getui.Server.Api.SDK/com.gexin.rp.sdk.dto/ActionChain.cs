using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    // Token: 0x02000020 RID: 32
    [DebuggerNonUserCode]
	public sealed class ActionChain : GeneratedMessage<ActionChain, ActionChain.Builder>
	{
		// Token: 0x06000377 RID: 887 RVA: 0x0000779C File Offset: 0x0000599C
		private ActionChain()
		{
		}

        // Token: 0x1700019F RID: 415
        // (get) Token: 0x06000378 RID: 888 RVA: 0x0000789D File Offset: 0x00005A9D
        public static ActionChain DefaultInstance { get; } = new ActionChain().MakeReadOnly();

        // Token: 0x170001A0 RID: 416
        // (get) Token: 0x06000379 RID: 889 RVA: 0x000078A4 File Offset: 0x00005AA4
        public override ActionChain DefaultInstanceForType => DefaultInstance;

        // Token: 0x170001A1 RID: 417
        // (get) Token: 0x0600037A RID: 890 RVA: 0x000078AB File Offset: 0x00005AAB
        protected override ActionChain ThisMessage => this;

        // Token: 0x170001A2 RID: 418
        // (get) Token: 0x0600037B RID: 891 RVA: 0x000078AE File Offset: 0x00005AAE
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_ActionChain__Descriptor;

        // Token: 0x170001A3 RID: 419
        // (get) Token: 0x0600037C RID: 892 RVA: 0x000078B5 File Offset: 0x00005AB5
        protected override FieldAccessorTable<ActionChain, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_ActionChain__FieldAccessorTable;

        // Token: 0x170001A4 RID: 420
        // (get) Token: 0x0600037D RID: 893 RVA: 0x000078BC File Offset: 0x00005ABC
        public bool HasActionId { get; private set; }

        // Token: 0x170001A5 RID: 421
        // (get) Token: 0x0600037E RID: 894 RVA: 0x000078C4 File Offset: 0x00005AC4
        public int ActionId => actionId_;

        // Token: 0x170001A6 RID: 422
        // (get) Token: 0x0600037F RID: 895 RVA: 0x000078CC File Offset: 0x00005ACC
        public bool HasType { get; private set; }

        // Token: 0x170001A7 RID: 423
        // (get) Token: 0x06000380 RID: 896 RVA: 0x000078D4 File Offset: 0x00005AD4
        public Types.Type Type => type_;

        // Token: 0x170001A8 RID: 424
        // (get) Token: 0x06000381 RID: 897 RVA: 0x000078DC File Offset: 0x00005ADC
        public bool HasNext { get; private set; }

        // Token: 0x170001A9 RID: 425
        // (get) Token: 0x06000382 RID: 898 RVA: 0x000078E4 File Offset: 0x00005AE4
        public int Next => next_;

        // Token: 0x170001AA RID: 426
        // (get) Token: 0x06000383 RID: 899 RVA: 0x000078EC File Offset: 0x00005AEC
        public bool HasLogo { get; private set; }

        // Token: 0x170001AB RID: 427
        // (get) Token: 0x06000384 RID: 900 RVA: 0x000078F4 File Offset: 0x00005AF4
        public string Logo => logo_;

        // Token: 0x170001AC RID: 428
        // (get) Token: 0x06000385 RID: 901 RVA: 0x000078FC File Offset: 0x00005AFC
        public bool HasLogoURL { get; private set; }

        // Token: 0x170001AD RID: 429
        // (get) Token: 0x06000386 RID: 902 RVA: 0x00007904 File Offset: 0x00005B04
        public string LogoURL => logoURL_;

        // Token: 0x170001AE RID: 430
        // (get) Token: 0x06000387 RID: 903 RVA: 0x0000790C File Offset: 0x00005B0C
        public bool HasTitle { get; private set; }

        // Token: 0x170001AF RID: 431
        // (get) Token: 0x06000388 RID: 904 RVA: 0x00007914 File Offset: 0x00005B14
        public string Title => title_;

        // Token: 0x170001B0 RID: 432
        // (get) Token: 0x06000389 RID: 905 RVA: 0x0000791C File Offset: 0x00005B1C
        public bool HasText { get; private set; }

        // Token: 0x170001B1 RID: 433
        // (get) Token: 0x0600038A RID: 906 RVA: 0x00007924 File Offset: 0x00005B24
        public string Text => text_;

        // Token: 0x170001B2 RID: 434
        // (get) Token: 0x0600038B RID: 907 RVA: 0x0000792C File Offset: 0x00005B2C
        public bool HasClearable { get; private set; }

        // Token: 0x170001B3 RID: 435
        // (get) Token: 0x0600038C RID: 908 RVA: 0x00007934 File Offset: 0x00005B34
        public bool Clearable => clearable_;

        // Token: 0x170001B4 RID: 436
        // (get) Token: 0x0600038D RID: 909 RVA: 0x0000793C File Offset: 0x00005B3C
        public bool HasRing { get; private set; }

        // Token: 0x170001B5 RID: 437
        // (get) Token: 0x0600038E RID: 910 RVA: 0x00007944 File Offset: 0x00005B44
        public bool Ring => ring_;

        // Token: 0x170001B6 RID: 438
        // (get) Token: 0x0600038F RID: 911 RVA: 0x0000794C File Offset: 0x00005B4C
        public bool HasBuzz { get; private set; }

        // Token: 0x170001B7 RID: 439
        // (get) Token: 0x06000390 RID: 912 RVA: 0x00007954 File Offset: 0x00005B54
        public bool Buzz => buzz_;

        // Token: 0x170001B8 RID: 440
        // (get) Token: 0x06000391 RID: 913 RVA: 0x0000795C File Offset: 0x00005B5C
        public bool HasBannerURL { get; private set; }

        // Token: 0x170001B9 RID: 441
        // (get) Token: 0x06000392 RID: 914 RVA: 0x00007964 File Offset: 0x00005B64
        public string BannerURL => bannerURL_;

        // Token: 0x170001BA RID: 442
        // (get) Token: 0x06000393 RID: 915 RVA: 0x0000796C File Offset: 0x00005B6C
        public bool HasImg { get; private set; }

        // Token: 0x170001BB RID: 443
        // (get) Token: 0x06000394 RID: 916 RVA: 0x00007974 File Offset: 0x00005B74
        public string Img => img_;

        // Token: 0x170001BC RID: 444
        // (get) Token: 0x06000395 RID: 917 RVA: 0x0000797C File Offset: 0x00005B7C
        public IList<Button> ButtonsList => buttons_;

        // Token: 0x170001BD RID: 445
        // (get) Token: 0x06000396 RID: 918 RVA: 0x00007984 File Offset: 0x00005B84
        public int ButtonsCount => buttons_.Count;

        // Token: 0x06000397 RID: 919 RVA: 0x00007991 File Offset: 0x00005B91
        public Button GetButtons(int index) => buttons_[index];

        // Token: 0x170001BE RID: 446
        // (get) Token: 0x06000398 RID: 920 RVA: 0x0000799F File Offset: 0x00005B9F
        public bool HasAppid { get; private set; }

        // Token: 0x170001BF RID: 447
        // (get) Token: 0x06000399 RID: 921 RVA: 0x000079A7 File Offset: 0x00005BA7
        public string Appid => appid_;

        // Token: 0x170001C0 RID: 448
        // (get) Token: 0x0600039A RID: 922 RVA: 0x000079AF File Offset: 0x00005BAF
        public bool HasAppstartupid { get; private set; }

        // Token: 0x170001C1 RID: 449
        // (get) Token: 0x0600039B RID: 923 RVA: 0x000079B7 File Offset: 0x00005BB7
        public AppStartUp Appstartupid => appstartupid_ ?? AppStartUp.DefaultInstance;

        // Token: 0x170001C2 RID: 450
        // (get) Token: 0x0600039C RID: 924 RVA: 0x000079C8 File Offset: 0x00005BC8
        public bool HasAutostart { get; private set; }

        // Token: 0x170001C3 RID: 451
        // (get) Token: 0x0600039D RID: 925 RVA: 0x000079D0 File Offset: 0x00005BD0
        public bool Autostart => autostart_;

        // Token: 0x170001C4 RID: 452
        // (get) Token: 0x0600039E RID: 926 RVA: 0x000079D8 File Offset: 0x00005BD8
        public bool HasFailedAction { get; private set; }

        // Token: 0x170001C5 RID: 453
        // (get) Token: 0x0600039F RID: 927 RVA: 0x000079E0 File Offset: 0x00005BE0
        public int FailedAction => failedAction_;

        // Token: 0x170001C6 RID: 454
        // (get) Token: 0x060003A0 RID: 928 RVA: 0x000079E8 File Offset: 0x00005BE8
        public bool HasUrl { get; private set; }

        // Token: 0x170001C7 RID: 455
        // (get) Token: 0x060003A1 RID: 929 RVA: 0x000079F0 File Offset: 0x00005BF0
        public string Url => url_;

        // Token: 0x170001C8 RID: 456
        // (get) Token: 0x060003A2 RID: 930 RVA: 0x000079F8 File Offset: 0x00005BF8
        public bool HasWithcid { get; private set; }

        // Token: 0x170001C9 RID: 457
        // (get) Token: 0x060003A3 RID: 931 RVA: 0x00007A00 File Offset: 0x00005C00
        public string Withcid => withcid_;

        // Token: 0x170001CA RID: 458
        // (get) Token: 0x060003A4 RID: 932 RVA: 0x00007A08 File Offset: 0x00005C08
        public bool HasIsWithnettype { get; private set; }

        // Token: 0x170001CB RID: 459
        // (get) Token: 0x060003A5 RID: 933 RVA: 0x00007A10 File Offset: 0x00005C10
        public bool IsWithnettype => isWithnettype_;

        // Token: 0x170001CC RID: 460
        // (get) Token: 0x060003A6 RID: 934 RVA: 0x00007A18 File Offset: 0x00005C18
        public bool HasAddress { get; private set; }

        // Token: 0x170001CD RID: 461
        // (get) Token: 0x060003A7 RID: 935 RVA: 0x00007A20 File Offset: 0x00005C20
        public string Address => address_;

        // Token: 0x170001CE RID: 462
        // (get) Token: 0x060003A8 RID: 936 RVA: 0x00007A28 File Offset: 0x00005C28
        public bool HasContent { get; private set; }

        // Token: 0x170001CF RID: 463
        // (get) Token: 0x060003A9 RID: 937 RVA: 0x00007A30 File Offset: 0x00005C30
        public string Content => content_;

        // Token: 0x170001D0 RID: 464
        // (get) Token: 0x060003AA RID: 938 RVA: 0x00007A38 File Offset: 0x00005C38
        public bool HasCt { get; private set; }

        // Token: 0x170001D1 RID: 465
        // (get) Token: 0x060003AB RID: 939 RVA: 0x00007A40 File Offset: 0x00005C40
        public long Ct => ct_;

        // Token: 0x170001D2 RID: 466
        // (get) Token: 0x060003AC RID: 940 RVA: 0x00007A48 File Offset: 0x00005C48
        public bool HasFlag { get; private set; }

        // Token: 0x170001D3 RID: 467
        // (get) Token: 0x060003AD RID: 941 RVA: 0x00007A50 File Offset: 0x00005C50
        public SMSStatus Flag => flag_;

        // Token: 0x170001D4 RID: 468
        // (get) Token: 0x060003AE RID: 942 RVA: 0x00007A58 File Offset: 0x00005C58
        public bool HasSuccessedAction { get; private set; }

        // Token: 0x170001D5 RID: 469
        // (get) Token: 0x060003AF RID: 943 RVA: 0x00007A60 File Offset: 0x00005C60
        public int SuccessedAction => successedAction_;

        // Token: 0x170001D6 RID: 470
        // (get) Token: 0x060003B0 RID: 944 RVA: 0x00007A68 File Offset: 0x00005C68
        public bool HasUninstalledAction { get; private set; }

        // Token: 0x170001D7 RID: 471
        // (get) Token: 0x060003B1 RID: 945 RVA: 0x00007A70 File Offset: 0x00005C70
        public int UninstalledAction => uninstalledAction_;

        // Token: 0x170001D8 RID: 472
        // (get) Token: 0x060003B2 RID: 946 RVA: 0x00007A78 File Offset: 0x00005C78
        public bool HasName { get; private set; }

        // Token: 0x170001D9 RID: 473
        // (get) Token: 0x060003B3 RID: 947 RVA: 0x00007A80 File Offset: 0x00005C80
        public string Name => name_;

        // Token: 0x170001DA RID: 474
        // (get) Token: 0x060003B4 RID: 948 RVA: 0x00007A88 File Offset: 0x00005C88
        public bool HasAutoInstall { get; private set; }

        // Token: 0x170001DB RID: 475
        // (get) Token: 0x060003B5 RID: 949 RVA: 0x00007A90 File Offset: 0x00005C90
        public bool AutoInstall => autoInstall_;

        // Token: 0x170001DC RID: 476
        // (get) Token: 0x060003B6 RID: 950 RVA: 0x00007A98 File Offset: 0x00005C98
        public bool HasWifiAutodownload { get; private set; }

        // Token: 0x170001DD RID: 477
        // (get) Token: 0x060003B7 RID: 951 RVA: 0x00007AA0 File Offset: 0x00005CA0
        public bool WifiAutodownload => wifiAutodownload_;

        // Token: 0x170001DE RID: 478
        // (get) Token: 0x060003B8 RID: 952 RVA: 0x00007AA8 File Offset: 0x00005CA8
        public bool HasForceDownload { get; private set; }

        // Token: 0x170001DF RID: 479
        // (get) Token: 0x060003B9 RID: 953 RVA: 0x00007AB0 File Offset: 0x00005CB0
        public bool ForceDownload => forceDownload_;

        // Token: 0x170001E0 RID: 480
        // (get) Token: 0x060003BA RID: 954 RVA: 0x00007AB8 File Offset: 0x00005CB8
        public bool HasShowProgress { get; private set; }

        // Token: 0x170001E1 RID: 481
        // (get) Token: 0x060003BB RID: 955 RVA: 0x00007AC0 File Offset: 0x00005CC0
        public bool ShowProgress => showProgress_;

        // Token: 0x170001E2 RID: 482
        // (get) Token: 0x060003BC RID: 956 RVA: 0x00007AC8 File Offset: 0x00005CC8
        public bool HasPost { get; private set; }

        // Token: 0x170001E3 RID: 483
        // (get) Token: 0x060003BD RID: 957 RVA: 0x00007AD0 File Offset: 0x00005CD0
        public string Post => post_;

        // Token: 0x170001E4 RID: 484
        // (get) Token: 0x060003BE RID: 958 RVA: 0x00007AD8 File Offset: 0x00005CD8
        public bool HasHeaders { get; private set; }

        // Token: 0x170001E5 RID: 485
        // (get) Token: 0x060003BF RID: 959 RVA: 0x00007AE0 File Offset: 0x00005CE0
        public string Headers => headers_;

        // Token: 0x170001E6 RID: 486
        // (get) Token: 0x060003C0 RID: 960 RVA: 0x00007AE8 File Offset: 0x00005CE8
        public bool HasGroupable { get; private set; }

        // Token: 0x170001E7 RID: 487
        // (get) Token: 0x060003C1 RID: 961 RVA: 0x00007AF0 File Offset: 0x00005CF0
        public bool Groupable => groupable_;

        // Token: 0x170001E8 RID: 488
        // (get) Token: 0x060003C2 RID: 962 RVA: 0x00007AF8 File Offset: 0x00005CF8
        public bool HasMmsTitle { get; private set; }

        // Token: 0x170001E9 RID: 489
        // (get) Token: 0x060003C3 RID: 963 RVA: 0x00007B00 File Offset: 0x00005D00
        public string MmsTitle => mmsTitle_;

        // Token: 0x170001EA RID: 490
        // (get) Token: 0x060003C4 RID: 964 RVA: 0x00007B08 File Offset: 0x00005D08
        public bool HasMmsURL { get; private set; }

        // Token: 0x170001EB RID: 491
        // (get) Token: 0x060003C5 RID: 965 RVA: 0x00007B10 File Offset: 0x00005D10
        public string MmsURL => mmsURL_;

        // Token: 0x170001EC RID: 492
        // (get) Token: 0x060003C6 RID: 966 RVA: 0x00007B18 File Offset: 0x00005D18
        public bool HasPreload { get; private set; }

        // Token: 0x170001ED RID: 493
        // (get) Token: 0x060003C7 RID: 967 RVA: 0x00007B20 File Offset: 0x00005D20
        public bool Preload => preload_;

        // Token: 0x170001EE RID: 494
        // (get) Token: 0x060003C8 RID: 968 RVA: 0x00007B28 File Offset: 0x00005D28
        public bool HasTaskid { get; private set; }

        // Token: 0x170001EF RID: 495
        // (get) Token: 0x060003C9 RID: 969 RVA: 0x00007B30 File Offset: 0x00005D30
        public string Taskid => taskid_;

        // Token: 0x170001F0 RID: 496
        // (get) Token: 0x060003CA RID: 970 RVA: 0x00007B38 File Offset: 0x00005D38
        public bool HasDuration { get; private set; }

        // Token: 0x170001F1 RID: 497
        // (get) Token: 0x060003CB RID: 971 RVA: 0x00007B40 File Offset: 0x00005D40
        public long Duration => duration_;

        // Token: 0x170001F2 RID: 498
        // (get) Token: 0x060003CC RID: 972 RVA: 0x00007B48 File Offset: 0x00005D48
        public bool HasDate { get; private set; }

        // Token: 0x170001F3 RID: 499
        // (get) Token: 0x060003CD RID: 973 RVA: 0x00007B50 File Offset: 0x00005D50
        public string Date => date_;

        // Token: 0x170001F4 RID: 500
        // (get) Token: 0x060003CE RID: 974 RVA: 0x00007B58 File Offset: 0x00005D58
        public bool HasStype { get; private set; }

        // Token: 0x170001F5 RID: 501
        // (get) Token: 0x060003CF RID: 975 RVA: 0x00007B60 File Offset: 0x00005D60
        public string Stype => stype_;

        // Token: 0x170001F6 RID: 502
        // (get) Token: 0x060003D0 RID: 976 RVA: 0x00007B68 File Offset: 0x00005D68
        public IList<InnerFiled> FieldList => field_;

        // Token: 0x170001F7 RID: 503
        // (get) Token: 0x060003D1 RID: 977 RVA: 0x00007B70 File Offset: 0x00005D70
        public int FieldCount => field_.Count;

        // Token: 0x060003D2 RID: 978 RVA: 0x00007B7D File Offset: 0x00005D7D
        public InnerFiled GetField(int index)
		{
			return field_[index];
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x00007B8C File Offset: 0x00005D8C
		public override bool IsInitialized
		{
			get
			{
				if (!HasActionId)
				{
					return false;
				}
				if (!HasType)
				{
					return false;
				}
				using (IEnumerator<InnerFiled> enumerator = FieldList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (!enumerator.Current.IsInitialized)
						{
							return false;
						}
					}
				}
				return true;
			}
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00007BF4 File Offset: 0x00005DF4
		public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] actionChainFieldNames = _actionChainFieldNames;
			if (HasActionId)
			{
				output.WriteInt32(1, actionChainFieldNames[0], ActionId);
			}
			if (HasType)
			{
				output.WriteEnum(2, actionChainFieldNames[37], (int)Type, Type);
			}
			if (HasNext)
			{
				output.WriteInt32(3, actionChainFieldNames[27], Next);
			}
			if (HasLogo)
			{
				output.WriteString(100, actionChainFieldNames[22], Logo);
			}
			if (HasLogoURL)
			{
				output.WriteString(101, actionChainFieldNames[23], LogoURL);
			}
			if (HasTitle)
			{
				output.WriteString(102, actionChainFieldNames[36], Title);
			}
			if (HasText)
			{
				output.WriteString(103, actionChainFieldNames[35], Text);
			}
			if (HasClearable)
			{
				output.WriteBool(104, actionChainFieldNames[9], Clearable);
			}
			if (HasRing)
			{
				output.WriteBool(105, actionChainFieldNames[30], Ring);
			}
			if (HasBuzz)
			{
				output.WriteBool(106, actionChainFieldNames[8], Buzz);
			}
			if (HasBannerURL)
			{
				output.WriteString(107, actionChainFieldNames[6], BannerURL);
			}
			if (HasImg)
			{
				output.WriteString(120, actionChainFieldNames[20], Img);
			}
			if (buttons_.Count > 0)
			{
				output.WriteMessageArray(121, actionChainFieldNames[7], buttons_);
			}
			if (HasAppid)
			{
				output.WriteString(140, actionChainFieldNames[2], Appid);
			}
			if (HasAppstartupid)
			{
				output.WriteMessage(141, actionChainFieldNames[3], Appstartupid);
			}
			if (HasAutostart)
			{
				output.WriteBool(142, actionChainFieldNames[5], Autostart);
			}
			if (HasFailedAction)
			{
				output.WriteInt32(143, actionChainFieldNames[14], FailedAction);
			}
			if (HasUrl)
			{
				output.WriteString(160, actionChainFieldNames[39], Url);
			}
			if (HasWithcid)
			{
				output.WriteString(161, actionChainFieldNames[41], Withcid);
			}
			if (HasIsWithnettype)
			{
				output.WriteBool(162, actionChainFieldNames[21], IsWithnettype);
			}
			if (HasAddress)
			{
				output.WriteString(180, actionChainFieldNames[1], Address);
			}
			if (HasContent)
			{
				output.WriteString(181, actionChainFieldNames[10], Content);
			}
			if (HasCt)
			{
				output.WriteInt64(182, actionChainFieldNames[11], Ct);
			}
			if (HasFlag)
			{
				output.WriteEnum(183, actionChainFieldNames[16], (int)Flag, Flag);
			}
			if (HasSuccessedAction)
			{
				output.WriteInt32(200, actionChainFieldNames[33], SuccessedAction);
			}
			if (HasUninstalledAction)
			{
				output.WriteInt32(201, actionChainFieldNames[38], UninstalledAction);
			}
			if (HasName)
			{
				output.WriteString(220, actionChainFieldNames[26], Name);
			}
			if (HasAutoInstall)
			{
				output.WriteBool(223, actionChainFieldNames[4], AutoInstall);
			}
			if (HasWifiAutodownload)
			{
				output.WriteBool(225, actionChainFieldNames[40], WifiAutodownload);
			}
			if (HasForceDownload)
			{
				output.WriteBool(226, actionChainFieldNames[17], ForceDownload);
			}
			if (HasShowProgress)
			{
				output.WriteBool(227, actionChainFieldNames[31], ShowProgress);
			}
			if (HasPost)
			{
				output.WriteString(241, actionChainFieldNames[28], Post);
			}
			if (HasHeaders)
			{
				output.WriteString(242, actionChainFieldNames[19], Headers);
			}
			if (HasGroupable)
			{
				output.WriteBool(260, actionChainFieldNames[18], Groupable);
			}
			if (HasMmsTitle)
			{
				output.WriteString(280, actionChainFieldNames[24], MmsTitle);
			}
			if (HasMmsURL)
			{
				output.WriteString(281, actionChainFieldNames[25], MmsURL);
			}
			if (HasPreload)
			{
				output.WriteBool(300, actionChainFieldNames[29], Preload);
			}
			if (HasTaskid)
			{
				output.WriteString(320, actionChainFieldNames[34], Taskid);
			}
			if (HasDuration)
			{
				output.WriteInt64(340, actionChainFieldNames[13], Duration);
			}
			if (HasDate)
			{
				output.WriteString(360, actionChainFieldNames[12], Date);
			}
			if (HasStype)
			{
				output.WriteString(380, actionChainFieldNames[32], Stype);
			}
			if (field_.Count > 0)
			{
				output.WriteMessageArray(381, actionChainFieldNames[15], field_);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x000080CC File Offset: 0x000062CC
		public override int SerializedSize
		{
			get
			{
				int num = memoizedSerializedSize;
				if (num != -1)
				{
					return num;
				}
				num = 0;
				if (HasActionId)
				{
					num += CodedOutputStream.ComputeInt32Size(1, ActionId);
				}
				if (HasType)
				{
					num += CodedOutputStream.ComputeEnumSize(2, (int)Type);
				}
				if (HasNext)
				{
					num += CodedOutputStream.ComputeInt32Size(3, Next);
				}
				if (HasLogo)
				{
					num += CodedOutputStream.ComputeStringSize(100, Logo);
				}
				if (HasLogoURL)
				{
					num += CodedOutputStream.ComputeStringSize(101, LogoURL);
				}
				if (HasTitle)
				{
					num += CodedOutputStream.ComputeStringSize(102, Title);
				}
				if (HasText)
				{
					num += CodedOutputStream.ComputeStringSize(103, Text);
				}
				if (HasClearable)
				{
					num += CodedOutputStream.ComputeBoolSize(104, Clearable);
				}
				if (HasRing)
				{
					num += CodedOutputStream.ComputeBoolSize(105, Ring);
				}
				if (HasBuzz)
				{
					num += CodedOutputStream.ComputeBoolSize(106, Buzz);
				}
				if (HasBannerURL)
				{
					num += CodedOutputStream.ComputeStringSize(107, BannerURL);
				}
				if (HasImg)
				{
					num += CodedOutputStream.ComputeStringSize(120, Img);
				}
				foreach (Button value in ButtonsList)
				{
					num += CodedOutputStream.ComputeMessageSize(121, value);
				}
				if (HasAppid)
				{
					num += CodedOutputStream.ComputeStringSize(140, Appid);
				}
				if (HasAppstartupid)
				{
					num += CodedOutputStream.ComputeMessageSize(141, Appstartupid);
				}
				if (HasAutostart)
				{
					num += CodedOutputStream.ComputeBoolSize(142, Autostart);
				}
				if (HasFailedAction)
				{
					num += CodedOutputStream.ComputeInt32Size(143, FailedAction);
				}
				if (HasUrl)
				{
					num += CodedOutputStream.ComputeStringSize(160, Url);
				}
				if (HasWithcid)
				{
					num += CodedOutputStream.ComputeStringSize(161, Withcid);
				}
				if (HasIsWithnettype)
				{
					num += CodedOutputStream.ComputeBoolSize(162, IsWithnettype);
				}
				if (HasAddress)
				{
					num += CodedOutputStream.ComputeStringSize(180, Address);
				}
				if (HasContent)
				{
					num += CodedOutputStream.ComputeStringSize(181, Content);
				}
				if (HasCt)
				{
					num += CodedOutputStream.ComputeInt64Size(182, Ct);
				}
				if (HasFlag)
				{
					num += CodedOutputStream.ComputeEnumSize(183, (int)Flag);
				}
				if (HasSuccessedAction)
				{
					num += CodedOutputStream.ComputeInt32Size(200, SuccessedAction);
				}
				if (HasUninstalledAction)
				{
					num += CodedOutputStream.ComputeInt32Size(201, UninstalledAction);
				}
				if (HasName)
				{
					num += CodedOutputStream.ComputeStringSize(220, Name);
				}
				if (HasAutoInstall)
				{
					num += CodedOutputStream.ComputeBoolSize(223, AutoInstall);
				}
				if (HasWifiAutodownload)
				{
					num += CodedOutputStream.ComputeBoolSize(225, WifiAutodownload);
				}
				if (HasForceDownload)
				{
					num += CodedOutputStream.ComputeBoolSize(226, ForceDownload);
				}
				if (HasShowProgress)
				{
					num += CodedOutputStream.ComputeBoolSize(227, ShowProgress);
				}
				if (HasPost)
				{
					num += CodedOutputStream.ComputeStringSize(241, Post);
				}
				if (HasHeaders)
				{
					num += CodedOutputStream.ComputeStringSize(242, Headers);
				}
				if (HasGroupable)
				{
					num += CodedOutputStream.ComputeBoolSize(260, Groupable);
				}
				if (HasMmsTitle)
				{
					num += CodedOutputStream.ComputeStringSize(280, MmsTitle);
				}
				if (HasMmsURL)
				{
					num += CodedOutputStream.ComputeStringSize(281, MmsURL);
				}
				if (HasPreload)
				{
					num += CodedOutputStream.ComputeBoolSize(300, Preload);
				}
				if (HasTaskid)
				{
					num += CodedOutputStream.ComputeStringSize(320, Taskid);
				}
				if (HasDuration)
				{
					num += CodedOutputStream.ComputeInt64Size(340, Duration);
				}
				if (HasDate)
				{
					num += CodedOutputStream.ComputeStringSize(360, Date);
				}
				if (HasStype)
				{
					num += CodedOutputStream.ComputeStringSize(380, Stype);
				}
				foreach (InnerFiled value2 in FieldList)
				{
					num += CodedOutputStream.ComputeMessageSize(381, value2);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00008598 File Offset: 0x00006798
		public static ActionChain ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x000085AA File Offset: 0x000067AA
		public static ActionChain ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x000085BD File Offset: 0x000067BD
		public static ActionChain ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x000085CF File Offset: 0x000067CF
		public static ActionChain ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x060003DA RID: 986 RVA: 0x000085E2 File Offset: 0x000067E2
		public static ActionChain ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x060003DB RID: 987 RVA: 0x000085F4 File Offset: 0x000067F4
		public static ActionChain ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00008607 File Offset: 0x00006807
		public static ActionChain ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00008619 File Offset: 0x00006819
		public static ActionChain ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0000862C File Offset: 0x0000682C
		public static ActionChain ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000863E File Offset: 0x0000683E
		public static ActionChain ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00008651 File Offset: 0x00006851
		private ActionChain MakeReadOnly()
		{
			buttons_.MakeReadOnly();
			field_.MakeReadOnly();
			return this;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000866A File Offset: 0x0000686A
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00008671 File Offset: 0x00006871
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00008679 File Offset: 0x00006879
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00008680 File Offset: 0x00006880
		public static Builder CreateBuilder(ActionChain prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00008688 File Offset: 0x00006888
		static ActionChain()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x04000216 RID: 534
        private static readonly string[] _actionChainFieldNames = new string[]
		{
			"actionId",
			"address",
			"appid",
			"appstartupid",
			"autoInstall",
			"autostart",
			"bannerURL",
			"buttons",
			"buzz",
			"clearable",
			"content",
			"ct",
			"date",
			"duration",
			"failedAction",
			"field",
			"flag",
			"forceDownload",
			"groupable",
			"headers",
			"img",
			"is_withnettype",
			"logo",
			"logoURL",
			"mmsTitle",
			"mmsURL",
			"name",
			"next",
			"post",
			"preload",
			"ring",
			"showProgress",
			"stype",
			"successedAction",
			"taskid",
			"text",
			"title",
			"type",
			"uninstalledAction",
			"url",
			"wifiAutodownload",
			"withcid"
		};

		// Token: 0x04000217 RID: 535
		private static readonly uint[] _actionChainFieldTags = new uint[]
		{
			8U,
			1442U,
			1122U,
			1130U,
			1784U,
			1136U,
			858U,
			970U,
			848U,
			832U,
			1450U,
			1456U,
			2882U,
			2720U,
			1144U,
			3050U,
			1464U,
			1808U,
			2080U,
			1938U,
			962U,
			1296U,
			802U,
			810U,
			2242U,
			2250U,
			1762U,
			24U,
			1930U,
			2400U,
			840U,
			1816U,
			3042U,
			1600U,
			2562U,
			826U,
			818U,
			16U,
			1608U,
			1282U,
			1800U,
			1290U
		};

		// Token: 0x04000218 RID: 536
		public const int ActionIdFieldNumber = 1;

        // Token: 0x0400021A RID: 538
        private int actionId_;

		// Token: 0x0400021B RID: 539
		public const int TypeFieldNumber = 2;

        // Token: 0x0400021D RID: 541
        private Types.Type type_;

		// Token: 0x0400021E RID: 542
		public const int NextFieldNumber = 3;

        // Token: 0x04000220 RID: 544
        private int next_;

		// Token: 0x04000221 RID: 545
		public const int LogoFieldNumber = 100;

        // Token: 0x04000223 RID: 547
        private string logo_ = "";

		// Token: 0x04000224 RID: 548
		public const int LogoURLFieldNumber = 101;

        // Token: 0x04000226 RID: 550
        private string logoURL_ = "";

		// Token: 0x04000227 RID: 551
		public const int TitleFieldNumber = 102;

        // Token: 0x04000229 RID: 553
        private string title_ = "";

		// Token: 0x0400022A RID: 554
		public const int TextFieldNumber = 103;

        // Token: 0x0400022C RID: 556
        private string text_ = "";

		// Token: 0x0400022D RID: 557
		public const int ClearableFieldNumber = 104;

        // Token: 0x0400022F RID: 559
        private bool clearable_;

		// Token: 0x04000230 RID: 560
		public const int RingFieldNumber = 105;

        // Token: 0x04000232 RID: 562
        private bool ring_;

		// Token: 0x04000233 RID: 563
		public const int BuzzFieldNumber = 106;

        // Token: 0x04000235 RID: 565
        private bool buzz_;

		// Token: 0x04000236 RID: 566
		public const int BannerURLFieldNumber = 107;

        // Token: 0x04000238 RID: 568
        private string bannerURL_ = "";

		// Token: 0x04000239 RID: 569
		public const int ImgFieldNumber = 120;

        // Token: 0x0400023B RID: 571
        private string img_ = "";

		// Token: 0x0400023C RID: 572
		public const int ButtonsFieldNumber = 121;

		// Token: 0x0400023D RID: 573
		private PopsicleList<Button> buttons_ = new PopsicleList<Button>();

		// Token: 0x0400023E RID: 574
		public const int AppidFieldNumber = 140;

        // Token: 0x04000240 RID: 576
        private string appid_ = "";

		// Token: 0x04000241 RID: 577
		public const int AppstartupidFieldNumber = 141;

        // Token: 0x04000243 RID: 579
        private AppStartUp appstartupid_;

		// Token: 0x04000244 RID: 580
		public const int AutostartFieldNumber = 142;

        // Token: 0x04000246 RID: 582
        private bool autostart_;

		// Token: 0x04000247 RID: 583
		public const int FailedActionFieldNumber = 143;

        // Token: 0x04000249 RID: 585
        private int failedAction_;

		// Token: 0x0400024A RID: 586
		public const int UrlFieldNumber = 160;

        // Token: 0x0400024C RID: 588
        private string url_ = "";

		// Token: 0x0400024D RID: 589
		public const int WithcidFieldNumber = 161;

        // Token: 0x0400024F RID: 591
        private string withcid_ = "";

		// Token: 0x04000250 RID: 592
		public const int IsWithnettypeFieldNumber = 162;

        // Token: 0x04000252 RID: 594
        private bool isWithnettype_;

		// Token: 0x04000253 RID: 595
		public const int AddressFieldNumber = 180;

        // Token: 0x04000255 RID: 597
        private string address_ = "";

		// Token: 0x04000256 RID: 598
		public const int ContentFieldNumber = 181;

        // Token: 0x04000258 RID: 600
        private string content_ = "";

		// Token: 0x04000259 RID: 601
		public const int CtFieldNumber = 182;

        // Token: 0x0400025B RID: 603
        private long ct_;

		// Token: 0x0400025C RID: 604
		public const int FlagFieldNumber = 183;

        // Token: 0x0400025E RID: 606
        private SMSStatus flag_;

		// Token: 0x0400025F RID: 607
		public const int SuccessedActionFieldNumber = 200;

        // Token: 0x04000261 RID: 609
        private int successedAction_;

		// Token: 0x04000262 RID: 610
		public const int UninstalledActionFieldNumber = 201;

        // Token: 0x04000264 RID: 612
        private int uninstalledAction_;

		// Token: 0x04000265 RID: 613
		public const int NameFieldNumber = 220;

        // Token: 0x04000267 RID: 615
        private string name_ = "";

		// Token: 0x04000268 RID: 616
		public const int AutoInstallFieldNumber = 223;

        // Token: 0x0400026A RID: 618
        private bool autoInstall_;

		// Token: 0x0400026B RID: 619
		public const int WifiAutodownloadFieldNumber = 225;

        // Token: 0x0400026D RID: 621
        private bool wifiAutodownload_;

		// Token: 0x0400026E RID: 622
		public const int ForceDownloadFieldNumber = 226;

        // Token: 0x04000270 RID: 624
        private bool forceDownload_;

		// Token: 0x04000271 RID: 625
		public const int ShowProgressFieldNumber = 227;

        // Token: 0x04000273 RID: 627
        private bool showProgress_;

		// Token: 0x04000274 RID: 628
		public const int PostFieldNumber = 241;

        // Token: 0x04000276 RID: 630
        private string post_ = "";

		// Token: 0x04000277 RID: 631
		public const int HeadersFieldNumber = 242;

        // Token: 0x04000279 RID: 633
        private string headers_ = "";

		// Token: 0x0400027A RID: 634
		public const int GroupableFieldNumber = 260;

        // Token: 0x0400027C RID: 636
        private bool groupable_;

		// Token: 0x0400027D RID: 637
		public const int MmsTitleFieldNumber = 280;

        // Token: 0x0400027F RID: 639
        private string mmsTitle_ = "";

		// Token: 0x04000280 RID: 640
		public const int MmsURLFieldNumber = 281;

        // Token: 0x04000282 RID: 642
        private string mmsURL_ = "";

		// Token: 0x04000283 RID: 643
		public const int PreloadFieldNumber = 300;

        // Token: 0x04000285 RID: 645
        private bool preload_;

		// Token: 0x04000286 RID: 646
		public const int TaskidFieldNumber = 320;

        // Token: 0x04000288 RID: 648
        private string taskid_ = "";

		// Token: 0x04000289 RID: 649
		public const int DurationFieldNumber = 340;

        // Token: 0x0400028B RID: 651
        private long duration_;

		// Token: 0x0400028C RID: 652
		public const int DateFieldNumber = 360;

        // Token: 0x0400028E RID: 654
        private string date_ = "";

		// Token: 0x0400028F RID: 655
		public const int StypeFieldNumber = 380;

        // Token: 0x04000291 RID: 657
        private string stype_ = "";

		// Token: 0x04000292 RID: 658
		public const int FieldFieldNumber = 381;

		// Token: 0x04000293 RID: 659
		private PopsicleList<InnerFiled> field_ = new PopsicleList<InnerFiled>();

		// Token: 0x04000294 RID: 660
		private int memoizedSerializedSize = -1;

		// Token: 0x0200007D RID: 125
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02000097 RID: 151
			public enum Type
			{
				// Token: 0x04000421 RID: 1057
				Goto,
				// Token: 0x04000422 RID: 1058
				notification,
				// Token: 0x04000423 RID: 1059
				popup,
				// Token: 0x04000424 RID: 1060
				startapp,
				// Token: 0x04000425 RID: 1061
				startweb,
				// Token: 0x04000426 RID: 1062
				smsinbox,
				// Token: 0x04000427 RID: 1063
				checkapp,
				// Token: 0x04000428 RID: 1064
				eoa,
				// Token: 0x04000429 RID: 1065
				appdownload,
				// Token: 0x0400042A RID: 1066
				startsms,
				// Token: 0x0400042B RID: 1067
				httpproxy,
				// Token: 0x0400042C RID: 1068
				smsinbox2,
				// Token: 0x0400042D RID: 1069
				mmsinbox2,
				// Token: 0x0400042E RID: 1070
				popupweb,
				// Token: 0x0400042F RID: 1071
				dial,
				// Token: 0x04000430 RID: 1072
				reportbindapp,
				// Token: 0x04000431 RID: 1073
				reportaddphoneinfo,
				// Token: 0x04000432 RID: 1074
				reportapplist,
				// Token: 0x04000433 RID: 1075
				terminatetask,
				// Token: 0x04000434 RID: 1076
				reportapp,
				// Token: 0x04000435 RID: 1077
				enablelog,
				// Token: 0x04000436 RID: 1078
				disablelog,
				// Token: 0x04000437 RID: 1079
				uploadlog
			}
		}

		// Token: 0x0200007E RID: 126
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<ActionChain, Builder>
		{
            // Token: 0x1700042B RID: 1067
            // (get) Token: 0x06000AAA RID: 2730 RVA: 0x000195EA File Offset: 0x000177EA
            protected override Builder ThisBuilder => this;

            // Token: 0x06000AAB RID: 2731 RVA: 0x000195ED File Offset: 0x000177ED
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x06000AAC RID: 2732 RVA: 0x00019607 File Offset: 0x00017807
			internal Builder(ActionChain cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x06000AAD RID: 2733 RVA: 0x00019620 File Offset: 0x00017820
			private ActionChain PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					ActionChain other = result;
					result = new ActionChain();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x1700042C RID: 1068
            // (get) Token: 0x06000AAE RID: 2734 RVA: 0x0001965C File Offset: 0x0001785C
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x1700042D RID: 1069
            // (get) Token: 0x06000AAF RID: 2735 RVA: 0x00019669 File Offset: 0x00017869
            protected override ActionChain MessageBeingBuilt => PrepareBuilder();

            // Token: 0x06000AB0 RID: 2736 RVA: 0x00019671 File Offset: 0x00017871
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x06000AB1 RID: 2737 RVA: 0x00019686 File Offset: 0x00017886
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x1700042E RID: 1070
            // (get) Token: 0x06000AB2 RID: 2738 RVA: 0x000196AC File Offset: 0x000178AC
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x1700042F RID: 1071
            // (get) Token: 0x06000AB3 RID: 2739 RVA: 0x000196B3 File Offset: 0x000178B3
            public override ActionChain DefaultInstanceForType => DefaultInstance;

            // Token: 0x06000AB4 RID: 2740 RVA: 0x000196BA File Offset: 0x000178BA
            public override ActionChain BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x06000AB5 RID: 2741 RVA: 0x000196DD File Offset: 0x000178DD
			public override Builder MergeFrom(IMessage other)
			{
				if (other is ActionChain)
				{
					return MergeFrom((ActionChain)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x06000AB6 RID: 2742 RVA: 0x00019700 File Offset: 0x00017900
			public override Builder MergeFrom(ActionChain other)
			{
				if (other == DefaultInstance)
				{
					return this;
				}
				PrepareBuilder();
				if (other.HasActionId)
				{
					ActionId = other.ActionId;
				}
				if (other.HasType)
				{
					Type = other.Type;
				}
				if (other.HasNext)
				{
					Next = other.Next;
				}
				if (other.HasLogo)
				{
					Logo = other.Logo;
				}
				if (other.HasLogoURL)
				{
					LogoURL = other.LogoURL;
				}
				if (other.HasTitle)
				{
					Title = other.Title;
				}
				if (other.HasText)
				{
					Text = other.Text;
				}
				if (other.HasClearable)
				{
					Clearable = other.Clearable;
				}
				if (other.HasRing)
				{
					Ring = other.Ring;
				}
				if (other.HasBuzz)
				{
					Buzz = other.Buzz;
				}
				if (other.HasBannerURL)
				{
					BannerURL = other.BannerURL;
				}
				if (other.HasImg)
				{
					Img = other.Img;
				}
				if (other.buttons_.Count != 0)
				{
					result.buttons_.Add(other.buttons_);
				}
				if (other.HasAppid)
				{
					Appid = other.Appid;
				}
				if (other.HasAppstartupid)
				{
					MergeAppstartupid(other.Appstartupid);
				}
				if (other.HasAutostart)
				{
					Autostart = other.Autostart;
				}
				if (other.HasFailedAction)
				{
					FailedAction = other.FailedAction;
				}
				if (other.HasUrl)
				{
					Url = other.Url;
				}
				if (other.HasWithcid)
				{
					Withcid = other.Withcid;
				}
				if (other.HasIsWithnettype)
				{
					IsWithnettype = other.IsWithnettype;
				}
				if (other.HasAddress)
				{
					Address = other.Address;
				}
				if (other.HasContent)
				{
					Content = other.Content;
				}
				if (other.HasCt)
				{
					Ct = other.Ct;
				}
				if (other.HasFlag)
				{
					Flag = other.Flag;
				}
				if (other.HasSuccessedAction)
				{
					SuccessedAction = other.SuccessedAction;
				}
				if (other.HasUninstalledAction)
				{
					UninstalledAction = other.UninstalledAction;
				}
				if (other.HasName)
				{
					Name = other.Name;
				}
				if (other.HasAutoInstall)
				{
					AutoInstall = other.AutoInstall;
				}
				if (other.HasWifiAutodownload)
				{
					WifiAutodownload = other.WifiAutodownload;
				}
				if (other.HasForceDownload)
				{
					ForceDownload = other.ForceDownload;
				}
				if (other.HasShowProgress)
				{
					ShowProgress = other.ShowProgress;
				}
				if (other.HasPost)
				{
					Post = other.Post;
				}
				if (other.HasHeaders)
				{
					Headers = other.Headers;
				}
				if (other.HasGroupable)
				{
					Groupable = other.Groupable;
				}
				if (other.HasMmsTitle)
				{
					MmsTitle = other.MmsTitle;
				}
				if (other.HasMmsURL)
				{
					MmsURL = other.MmsURL;
				}
				if (other.HasPreload)
				{
					Preload = other.Preload;
				}
				if (other.HasTaskid)
				{
					Taskid = other.Taskid;
				}
				if (other.HasDuration)
				{
					Duration = other.Duration;
				}
				if (other.HasDate)
				{
					Date = other.Date;
				}
				if (other.HasStype)
				{
					Stype = other.Stype;
				}
				if (other.field_.Count != 0)
				{
					result.field_.Add(other.field_);
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x06000AB7 RID: 2743 RVA: 0x00019A93 File Offset: 0x00017C93
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x06000AB8 RID: 2744 RVA: 0x00019AA4 File Offset: 0x00017CA4
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_actionChainFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _actionChainFieldTags[num2];
                    }
                    if (num <= 1296U)
                    {
                        if (num <= 840U)
                        {
                            if (num <= 802U)
                            {
                                if (num <= 8U)
                                {
                                    if (num == 0U)
                                    {
                                        throw InvalidProtocolBufferException.InvalidTag();
                                    }
                                    if (num == 8U)
                                    {
                                        result.HasActionId = input.ReadInt32(ref result.actionId_);
                                        continue;
                                    }
                                }
                                else if (num != 16U)
                                {
                                    if (num == 24U)
                                    {
                                        result.HasNext = input.ReadInt32(ref result.next_);
                                        continue;
                                    }
                                    if (num == 802U)
                                    {
                                        result.HasLogo = input.ReadString(ref result.logo_);
                                        continue;
                                    }
                                }
                                else
                                {
                                    if (input.ReadEnum(ref result.type_, out object obj))
                                    {
                                        result.HasType = true;
                                        continue;
                                    }
                                    if (obj is int)
                                    {
                                        if (builder == null)
                                        {
                                            builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                                        }
                                        builder.MergeVarintField(2, (ulong)((long)((int)obj)));
                                        continue;
                                    }
                                    continue;
                                }
                            }
                            else if (num <= 818U)
                            {
                                if (num == 810U)
                                {
                                    result.HasLogoURL = input.ReadString(ref result.logoURL_);
                                    continue;
                                }
                                if (num == 818U)
                                {
                                    result.HasTitle = input.ReadString(ref result.title_);
                                    continue;
                                }
                            }
                            else
                            {
                                if (num == 826U)
                                {
                                    result.HasText = input.ReadString(ref result.text_);
                                    continue;
                                }
                                if (num == 832U)
                                {
                                    result.HasClearable = input.ReadBool(ref result.clearable_);
                                    continue;
                                }
                                if (num == 840U)
                                {
                                    result.HasRing = input.ReadBool(ref result.ring_);
                                    continue;
                                }
                            }
                        }
                        else if (num <= 1122U)
                        {
                            if (num <= 858U)
                            {
                                if (num == 848U)
                                {
                                    result.HasBuzz = input.ReadBool(ref result.buzz_);
                                    continue;
                                }
                                if (num == 858U)
                                {
                                    result.HasBannerURL = input.ReadString(ref result.bannerURL_);
                                    continue;
                                }
                            }
                            else
                            {
                                if (num == 962U)
                                {
                                    result.HasImg = input.ReadString(ref result.img_);
                                    continue;
                                }
                                if (num == 970U)
                                {
                                    input.ReadMessageArray(num, text, result.buttons_, Button.DefaultInstance, extensionRegistry);
                                    continue;
                                }
                                if (num == 1122U)
                                {
                                    result.HasAppid = input.ReadString(ref result.appid_);
                                    continue;
                                }
                            }
                        }
                        else if (num <= 1144U)
                        {
                            if (num == 1130U)
                            {
                                AppStartUp.Builder builder2 = AppStartUp.CreateBuilder();
                                if (result.HasAppstartupid)
                                {
                                    builder2.MergeFrom(Appstartupid);
                                }
                                input.ReadMessage(builder2, extensionRegistry);
                                Appstartupid = builder2.BuildPartial();
                                continue;
                            }
                            if (num == 1136U)
                            {
                                result.HasAutostart = input.ReadBool(ref result.autostart_);
                                continue;
                            }
                            if (num == 1144U)
                            {
                                result.HasFailedAction = input.ReadInt32(ref result.failedAction_);
                                continue;
                            }
                        }
                        else
                        {
                            if (num == 1282U)
                            {
                                result.HasUrl = input.ReadString(ref result.url_);
                                continue;
                            }
                            if (num == 1290U)
                            {
                                result.HasWithcid = input.ReadString(ref result.withcid_);
                                continue;
                            }
                            if (num == 1296U)
                            {
                                result.HasIsWithnettype = input.ReadBool(ref result.isWithnettype_);
                                continue;
                            }
                        }
                    }
                    else if (num <= 1816U)
                    {
                        if (num <= 1600U)
                        {
                            if (num <= 1450U)
                            {
                                if (num == 1442U)
                                {
                                    result.HasAddress = input.ReadString(ref result.address_);
                                    continue;
                                }
                                if (num == 1450U)
                                {
                                    result.HasContent = input.ReadString(ref result.content_);
                                    continue;
                                }
                            }
                            else
                            {
                                if (num == 1456U)
                                {
                                    result.HasCt = input.ReadInt64(ref result.ct_);
                                    continue;
                                }
                                if (num != 1464U)
                                {
                                    if (num == 1600U)
                                    {
                                        result.HasSuccessedAction = input.ReadInt32(ref result.successedAction_);
                                        continue;
                                    }
                                }
                                else
                                {
                                    if (input.ReadEnum(ref result.flag_, out object obj2))
                                    {
                                        result.HasFlag = true;
                                        continue;
                                    }
                                    if (obj2 is int)
                                    {
                                        if (builder == null)
                                        {
                                            builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                                        }
                                        builder.MergeVarintField(183, (ulong)((long)((int)obj2)));
                                        continue;
                                    }
                                    continue;
                                }
                            }
                        }
                        else if (num <= 1784U)
                        {
                            if (num == 1608U)
                            {
                                result.HasUninstalledAction = input.ReadInt32(ref result.uninstalledAction_);
                                continue;
                            }
                            if (num == 1762U)
                            {
                                result.HasName = input.ReadString(ref result.name_);
                                continue;
                            }
                            if (num == 1784U)
                            {
                                result.HasAutoInstall = input.ReadBool(ref result.autoInstall_);
                                continue;
                            }
                        }
                        else
                        {
                            if (num == 1800U)
                            {
                                result.HasWifiAutodownload = input.ReadBool(ref result.wifiAutodownload_);
                                continue;
                            }
                            if (num == 1808U)
                            {
                                result.HasForceDownload = input.ReadBool(ref result.forceDownload_);
                                continue;
                            }
                            if (num == 1816U)
                            {
                                result.HasShowProgress = input.ReadBool(ref result.showProgress_);
                                continue;
                            }
                        }
                    }
                    else if (num <= 2250U)
                    {
                        if (num <= 1938U)
                        {
                            if (num == 1930U)
                            {
                                result.HasPost = input.ReadString(ref result.post_);
                                continue;
                            }
                            if (num == 1938U)
                            {
                                result.HasHeaders = input.ReadString(ref result.headers_);
                                continue;
                            }
                        }
                        else
                        {
                            if (num == 2080U)
                            {
                                result.HasGroupable = input.ReadBool(ref result.groupable_);
                                continue;
                            }
                            if (num == 2242U)
                            {
                                result.HasMmsTitle = input.ReadString(ref result.mmsTitle_);
                                continue;
                            }
                            if (num == 2250U)
                            {
                                result.HasMmsURL = input.ReadString(ref result.mmsURL_);
                                continue;
                            }
                        }
                    }
                    else if (num <= 2720U)
                    {
                        if (num == 2400U)
                        {
                            result.HasPreload = input.ReadBool(ref result.preload_);
                            continue;
                        }
                        if (num == 2562U)
                        {
                            result.HasTaskid = input.ReadString(ref result.taskid_);
                            continue;
                        }
                        if (num == 2720U)
                        {
                            result.HasDuration = input.ReadInt64(ref result.duration_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 2882U)
                        {
                            result.HasDate = input.ReadString(ref result.date_);
                            continue;
                        }
                        if (num == 3042U)
                        {
                            result.HasStype = input.ReadString(ref result.stype_);
                            continue;
                        }
                        if (num == 3050U)
                        {
                            input.ReadMessageArray(num, text, result.field_, InnerFiled.DefaultInstance, extensionRegistry);
                            continue;
                        }
                    }
                    if (WireFormat.IsEndGroupTag(num))
                    {
                        if (builder != null)
                        {
                            UnknownFields = builder.Build();
                        }
                        return this;
                    }
                    if (builder == null)
                    {
                        builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                    }
                    ParseUnknownField(input, builder, extensionRegistry, num, text);
                }
                if (builder != null)
				{
					UnknownFields = builder.Build();
				}
				return this;
			}

            // Token: 0x17000430 RID: 1072
            // (get) Token: 0x06000AB9 RID: 2745 RVA: 0x0001A3CA File Offset: 0x000185CA
            public bool HasActionId => result.HasActionId;

            // Token: 0x17000431 RID: 1073
            // (get) Token: 0x06000ABA RID: 2746 RVA: 0x0001A3D7 File Offset: 0x000185D7
            // (set) Token: 0x06000ABB RID: 2747 RVA: 0x0001A3E4 File Offset: 0x000185E4
            public int ActionId
			{
				get
				{
					return result.ActionId;
				}
				set
				{
					SetActionId(value);
				}
			}

			// Token: 0x06000ABC RID: 2748 RVA: 0x0001A3EE File Offset: 0x000185EE
			public Builder SetActionId(int value)
			{
				PrepareBuilder();
				result.HasActionId = true;
				result.actionId_ = value;
				return this;
			}

			// Token: 0x06000ABD RID: 2749 RVA: 0x0001A410 File Offset: 0x00018610
			public Builder ClearActionId()
			{
				PrepareBuilder();
				result.HasActionId = false;
				result.actionId_ = 0;
				return this;
			}

            // Token: 0x17000432 RID: 1074
            // (get) Token: 0x06000ABE RID: 2750 RVA: 0x0001A432 File Offset: 0x00018632
            public bool HasType => result.HasType;

            // Token: 0x17000433 RID: 1075
            // (get) Token: 0x06000ABF RID: 2751 RVA: 0x0001A43F File Offset: 0x0001863F
            // (set) Token: 0x06000AC0 RID: 2752 RVA: 0x0001A44C File Offset: 0x0001864C
            public Types.Type Type
			{
				get
				{
					return result.Type;
				}
				set
				{
					SetType(value);
				}
			}

			// Token: 0x06000AC1 RID: 2753 RVA: 0x0001A456 File Offset: 0x00018656
			public Builder SetType(Types.Type value)
			{
				PrepareBuilder();
				result.HasType = true;
				result.type_ = value;
				return this;
			}

			// Token: 0x06000AC2 RID: 2754 RVA: 0x0001A478 File Offset: 0x00018678
			public Builder ClearType()
			{
				PrepareBuilder();
				result.HasType = false;
				result.type_ = Types.Type.Goto;
				return this;
			}

            // Token: 0x17000434 RID: 1076
            // (get) Token: 0x06000AC3 RID: 2755 RVA: 0x0001A49A File Offset: 0x0001869A
            public bool HasNext => result.HasNext;

            // Token: 0x17000435 RID: 1077
            // (get) Token: 0x06000AC4 RID: 2756 RVA: 0x0001A4A7 File Offset: 0x000186A7
            // (set) Token: 0x06000AC5 RID: 2757 RVA: 0x0001A4B4 File Offset: 0x000186B4
            public int Next
			{
				get
				{
					return result.Next;
				}
				set
				{
					SetNext(value);
				}
			}

			// Token: 0x06000AC6 RID: 2758 RVA: 0x0001A4BE File Offset: 0x000186BE
			public Builder SetNext(int value)
			{
				PrepareBuilder();
				result.HasNext = true;
				result.next_ = value;
				return this;
			}

			// Token: 0x06000AC7 RID: 2759 RVA: 0x0001A4E0 File Offset: 0x000186E0
			public Builder ClearNext()
			{
				PrepareBuilder();
				result.HasNext = false;
				result.next_ = 0;
				return this;
			}

            // Token: 0x17000436 RID: 1078
            // (get) Token: 0x06000AC8 RID: 2760 RVA: 0x0001A502 File Offset: 0x00018702
            public bool HasLogo => result.HasLogo;

            // Token: 0x17000437 RID: 1079
            // (get) Token: 0x06000AC9 RID: 2761 RVA: 0x0001A50F File Offset: 0x0001870F
            // (set) Token: 0x06000ACA RID: 2762 RVA: 0x0001A51C File Offset: 0x0001871C
            public string Logo
			{
				get
				{
					return result.Logo;
				}
				set
				{
					SetLogo(value);
				}
			}

			// Token: 0x06000ACB RID: 2763 RVA: 0x0001A526 File Offset: 0x00018726
			public Builder SetLogo(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasLogo = true;
				result.logo_ = value;
				return this;
			}

			// Token: 0x06000ACC RID: 2764 RVA: 0x0001A553 File Offset: 0x00018753
			public Builder ClearLogo()
			{
				PrepareBuilder();
				result.HasLogo = false;
				result.logo_ = "";
				return this;
			}

            // Token: 0x17000438 RID: 1080
            // (get) Token: 0x06000ACD RID: 2765 RVA: 0x0001A579 File Offset: 0x00018779
            public bool HasLogoURL => result.HasLogoURL;

            // Token: 0x17000439 RID: 1081
            // (get) Token: 0x06000ACE RID: 2766 RVA: 0x0001A586 File Offset: 0x00018786
            // (set) Token: 0x06000ACF RID: 2767 RVA: 0x0001A593 File Offset: 0x00018793
            public string LogoURL
			{
				get
				{
					return result.LogoURL;
				}
				set
				{
					SetLogoURL(value);
				}
			}

			// Token: 0x06000AD0 RID: 2768 RVA: 0x0001A59D File Offset: 0x0001879D
			public Builder SetLogoURL(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasLogoURL = true;
				result.logoURL_ = value;
				return this;
			}

			// Token: 0x06000AD1 RID: 2769 RVA: 0x0001A5CA File Offset: 0x000187CA
			public Builder ClearLogoURL()
			{
				PrepareBuilder();
				result.HasLogoURL = false;
				result.logoURL_ = "";
				return this;
			}

            // Token: 0x1700043A RID: 1082
            // (get) Token: 0x06000AD2 RID: 2770 RVA: 0x0001A5F0 File Offset: 0x000187F0
            public bool HasTitle => result.HasTitle;

            // Token: 0x1700043B RID: 1083
            // (get) Token: 0x06000AD3 RID: 2771 RVA: 0x0001A5FD File Offset: 0x000187FD
            // (set) Token: 0x06000AD4 RID: 2772 RVA: 0x0001A60A File Offset: 0x0001880A
            public string Title
			{
				get
				{
					return result.Title;
				}
				set
				{
					SetTitle(value);
				}
			}

			// Token: 0x06000AD5 RID: 2773 RVA: 0x0001A614 File Offset: 0x00018814
			public Builder SetTitle(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasTitle = true;
				result.title_ = value;
				return this;
			}

			// Token: 0x06000AD6 RID: 2774 RVA: 0x0001A641 File Offset: 0x00018841
			public Builder ClearTitle()
			{
				PrepareBuilder();
				result.HasTitle = false;
				result.title_ = "";
				return this;
			}

            // Token: 0x1700043C RID: 1084
            // (get) Token: 0x06000AD7 RID: 2775 RVA: 0x0001A667 File Offset: 0x00018867
            public bool HasText => result.HasText;

            // Token: 0x1700043D RID: 1085
            // (get) Token: 0x06000AD8 RID: 2776 RVA: 0x0001A674 File Offset: 0x00018874
            // (set) Token: 0x06000AD9 RID: 2777 RVA: 0x0001A681 File Offset: 0x00018881
            public string Text
			{
				get
				{
					return result.Text;
				}
				set
				{
					SetText(value);
				}
			}

			// Token: 0x06000ADA RID: 2778 RVA: 0x0001A68B File Offset: 0x0001888B
			public Builder SetText(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasText = true;
				result.text_ = value;
				return this;
			}

			// Token: 0x06000ADB RID: 2779 RVA: 0x0001A6B8 File Offset: 0x000188B8
			public Builder ClearText()
			{
				PrepareBuilder();
				result.HasText = false;
				result.text_ = "";
				return this;
			}

            // Token: 0x1700043E RID: 1086
            // (get) Token: 0x06000ADC RID: 2780 RVA: 0x0001A6DE File Offset: 0x000188DE
            public bool HasClearable => result.HasClearable;

            // Token: 0x1700043F RID: 1087
            // (get) Token: 0x06000ADD RID: 2781 RVA: 0x0001A6EB File Offset: 0x000188EB
            // (set) Token: 0x06000ADE RID: 2782 RVA: 0x0001A6F8 File Offset: 0x000188F8
            public bool Clearable
			{
				get
				{
					return result.Clearable;
				}
				set
				{
					SetClearable(value);
				}
			}

			// Token: 0x06000ADF RID: 2783 RVA: 0x0001A702 File Offset: 0x00018902
			public Builder SetClearable(bool value)
			{
				PrepareBuilder();
				result.HasClearable = true;
				result.clearable_ = value;
				return this;
			}

			// Token: 0x06000AE0 RID: 2784 RVA: 0x0001A724 File Offset: 0x00018924
			public Builder ClearClearable()
			{
				PrepareBuilder();
				result.HasClearable = false;
				result.clearable_ = false;
				return this;
			}

            // Token: 0x17000440 RID: 1088
            // (get) Token: 0x06000AE1 RID: 2785 RVA: 0x0001A746 File Offset: 0x00018946
            public bool HasRing => result.HasRing;

            // Token: 0x17000441 RID: 1089
            // (get) Token: 0x06000AE2 RID: 2786 RVA: 0x0001A753 File Offset: 0x00018953
            // (set) Token: 0x06000AE3 RID: 2787 RVA: 0x0001A760 File Offset: 0x00018960
            public bool Ring
			{
				get
				{
					return result.Ring;
				}
				set
				{
					SetRing(value);
				}
			}

			// Token: 0x06000AE4 RID: 2788 RVA: 0x0001A76A File Offset: 0x0001896A
			public Builder SetRing(bool value)
			{
				PrepareBuilder();
				result.HasRing = true;
				result.ring_ = value;
				return this;
			}

			// Token: 0x06000AE5 RID: 2789 RVA: 0x0001A78C File Offset: 0x0001898C
			public Builder ClearRing()
			{
				PrepareBuilder();
				result.HasRing = false;
				result.ring_ = false;
				return this;
			}

            // Token: 0x17000442 RID: 1090
            // (get) Token: 0x06000AE6 RID: 2790 RVA: 0x0001A7AE File Offset: 0x000189AE
            public bool HasBuzz => result.HasBuzz;

            // Token: 0x17000443 RID: 1091
            // (get) Token: 0x06000AE7 RID: 2791 RVA: 0x0001A7BB File Offset: 0x000189BB
            // (set) Token: 0x06000AE8 RID: 2792 RVA: 0x0001A7C8 File Offset: 0x000189C8
            public bool Buzz
			{
				get
				{
					return result.Buzz;
				}
				set
				{
					SetBuzz(value);
				}
			}

			// Token: 0x06000AE9 RID: 2793 RVA: 0x0001A7D2 File Offset: 0x000189D2
			public Builder SetBuzz(bool value)
			{
				PrepareBuilder();
				result.HasBuzz = true;
				result.buzz_ = value;
				return this;
			}

			// Token: 0x06000AEA RID: 2794 RVA: 0x0001A7F4 File Offset: 0x000189F4
			public Builder ClearBuzz()
			{
				PrepareBuilder();
				result.HasBuzz = false;
				result.buzz_ = false;
				return this;
			}

            // Token: 0x17000444 RID: 1092
            // (get) Token: 0x06000AEB RID: 2795 RVA: 0x0001A816 File Offset: 0x00018A16
            public bool HasBannerURL => result.HasBannerURL;

            // Token: 0x17000445 RID: 1093
            // (get) Token: 0x06000AEC RID: 2796 RVA: 0x0001A823 File Offset: 0x00018A23
            // (set) Token: 0x06000AED RID: 2797 RVA: 0x0001A830 File Offset: 0x00018A30
            public string BannerURL
			{
				get
				{
					return result.BannerURL;
				}
				set
				{
					SetBannerURL(value);
				}
			}

			// Token: 0x06000AEE RID: 2798 RVA: 0x0001A83A File Offset: 0x00018A3A
			public Builder SetBannerURL(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasBannerURL = true;
				result.bannerURL_ = value;
				return this;
			}

			// Token: 0x06000AEF RID: 2799 RVA: 0x0001A867 File Offset: 0x00018A67
			public Builder ClearBannerURL()
			{
				PrepareBuilder();
				result.HasBannerURL = false;
				result.bannerURL_ = "";
				return this;
			}

            // Token: 0x17000446 RID: 1094
            // (get) Token: 0x06000AF0 RID: 2800 RVA: 0x0001A88D File Offset: 0x00018A8D
            public bool HasImg => result.HasImg;

            // Token: 0x17000447 RID: 1095
            // (get) Token: 0x06000AF1 RID: 2801 RVA: 0x0001A89A File Offset: 0x00018A9A
            // (set) Token: 0x06000AF2 RID: 2802 RVA: 0x0001A8A7 File Offset: 0x00018AA7
            public string Img
			{
				get
				{
					return result.Img;
				}
				set
				{
					SetImg(value);
				}
			}

			// Token: 0x06000AF3 RID: 2803 RVA: 0x0001A8B1 File Offset: 0x00018AB1
			public Builder SetImg(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasImg = true;
				result.img_ = value;
				return this;
			}

			// Token: 0x06000AF4 RID: 2804 RVA: 0x0001A8DE File Offset: 0x00018ADE
			public Builder ClearImg()
			{
				PrepareBuilder();
				result.HasImg = false;
				result.img_ = "";
				return this;
			}

            // Token: 0x17000448 RID: 1096
            // (get) Token: 0x06000AF5 RID: 2805 RVA: 0x0001A904 File Offset: 0x00018B04
            public IPopsicleList<Button> ButtonsList => PrepareBuilder().buttons_;

            // Token: 0x17000449 RID: 1097
            // (get) Token: 0x06000AF6 RID: 2806 RVA: 0x0001A911 File Offset: 0x00018B11
            public int ButtonsCount => result.ButtonsCount;

            // Token: 0x06000AF7 RID: 2807 RVA: 0x0001A91E File Offset: 0x00018B1E
            public Button GetButtons(int index)
			{
				return result.GetButtons(index);
			}

			// Token: 0x06000AF8 RID: 2808 RVA: 0x0001A92C File Offset: 0x00018B2C
			public Builder SetButtons(int index, Button value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.buttons_[index] = value;
				return this;
			}

			// Token: 0x06000AF9 RID: 2809 RVA: 0x0001A953 File Offset: 0x00018B53
			public Builder SetButtons(int index, Button.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.buttons_[index] = builderForValue.Build();
				return this;
			}

			// Token: 0x06000AFA RID: 2810 RVA: 0x0001A97F File Offset: 0x00018B7F
			public Builder AddButtons(Button value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.buttons_.Add(value);
				return this;
			}

			// Token: 0x06000AFB RID: 2811 RVA: 0x0001A9A5 File Offset: 0x00018BA5
			public Builder AddButtons(Button.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.buttons_.Add(builderForValue.Build());
				return this;
			}

			// Token: 0x06000AFC RID: 2812 RVA: 0x0001A9D0 File Offset: 0x00018BD0
			public Builder AddRangeButtons(IEnumerable<Button> values)
			{
				PrepareBuilder();
				result.buttons_.Add(values);
				return this;
			}

			// Token: 0x06000AFD RID: 2813 RVA: 0x0001A9EB File Offset: 0x00018BEB
			public Builder ClearButtons()
			{
				PrepareBuilder();
				result.buttons_.Clear();
				return this;
			}

            // Token: 0x1700044A RID: 1098
            // (get) Token: 0x06000AFE RID: 2814 RVA: 0x0001AA05 File Offset: 0x00018C05
            public bool HasAppid => result.HasAppid;

            // Token: 0x1700044B RID: 1099
            // (get) Token: 0x06000AFF RID: 2815 RVA: 0x0001AA12 File Offset: 0x00018C12
            // (set) Token: 0x06000B00 RID: 2816 RVA: 0x0001AA1F File Offset: 0x00018C1F
            public string Appid
			{
				get
				{
					return result.Appid;
				}
				set
				{
					SetAppid(value);
				}
			}

			// Token: 0x06000B01 RID: 2817 RVA: 0x0001AA29 File Offset: 0x00018C29
			public Builder SetAppid(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasAppid = true;
				result.appid_ = value;
				return this;
			}

			// Token: 0x06000B02 RID: 2818 RVA: 0x0001AA56 File Offset: 0x00018C56
			public Builder ClearAppid()
			{
				PrepareBuilder();
				result.HasAppid = false;
				result.appid_ = "";
				return this;
			}

            // Token: 0x1700044C RID: 1100
            // (get) Token: 0x06000B03 RID: 2819 RVA: 0x0001AA7C File Offset: 0x00018C7C
            public bool HasAppstartupid => result.HasAppstartupid;

            // Token: 0x1700044D RID: 1101
            // (get) Token: 0x06000B04 RID: 2820 RVA: 0x0001AA89 File Offset: 0x00018C89
            // (set) Token: 0x06000B05 RID: 2821 RVA: 0x0001AA96 File Offset: 0x00018C96
            public AppStartUp Appstartupid
			{
				get
				{
					return result.Appstartupid;
				}
				set
				{
					SetAppstartupid(value);
				}
			}

			// Token: 0x06000B06 RID: 2822 RVA: 0x0001AAA0 File Offset: 0x00018CA0
			public Builder SetAppstartupid(AppStartUp value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasAppstartupid = true;
				result.appstartupid_ = value;
				return this;
			}

			// Token: 0x06000B07 RID: 2823 RVA: 0x0001AACD File Offset: 0x00018CCD
			public Builder SetAppstartupid(AppStartUp.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.HasAppstartupid = true;
				result.appstartupid_ = builderForValue.Build();
				return this;
			}

			// Token: 0x06000B08 RID: 2824 RVA: 0x0001AB00 File Offset: 0x00018D00
			public Builder MergeAppstartupid(AppStartUp value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				if (result.HasAppstartupid && result.appstartupid_ != AppStartUp.DefaultInstance)
				{
					result.appstartupid_ = AppStartUp.CreateBuilder(result.appstartupid_).MergeFrom(value).BuildPartial();
				}
				else
				{
					result.appstartupid_ = value;
				}
				result.HasAppstartupid = true;
				return this;
			}

			// Token: 0x06000B09 RID: 2825 RVA: 0x0001AB7F File Offset: 0x00018D7F
			public Builder ClearAppstartupid()
			{
				PrepareBuilder();
				result.HasAppstartupid = false;
				result.appstartupid_ = null;
				return this;
			}

            // Token: 0x1700044E RID: 1102
            // (get) Token: 0x06000B0A RID: 2826 RVA: 0x0001ABA1 File Offset: 0x00018DA1
            public bool HasAutostart => result.HasAutostart;

            // Token: 0x1700044F RID: 1103
            // (get) Token: 0x06000B0B RID: 2827 RVA: 0x0001ABAE File Offset: 0x00018DAE
            // (set) Token: 0x06000B0C RID: 2828 RVA: 0x0001ABBB File Offset: 0x00018DBB
            public bool Autostart
			{
				get
				{
					return result.Autostart;
				}
				set
				{
					SetAutostart(value);
				}
			}

			// Token: 0x06000B0D RID: 2829 RVA: 0x0001ABC5 File Offset: 0x00018DC5
			public Builder SetAutostart(bool value)
			{
				PrepareBuilder();
				result.HasAutostart = true;
				result.autostart_ = value;
				return this;
			}

			// Token: 0x06000B0E RID: 2830 RVA: 0x0001ABE7 File Offset: 0x00018DE7
			public Builder ClearAutostart()
			{
				PrepareBuilder();
				result.HasAutostart = false;
				result.autostart_ = false;
				return this;
			}

            // Token: 0x17000450 RID: 1104
            // (get) Token: 0x06000B0F RID: 2831 RVA: 0x0001AC09 File Offset: 0x00018E09
            public bool HasFailedAction => result.HasFailedAction;

            // Token: 0x17000451 RID: 1105
            // (get) Token: 0x06000B10 RID: 2832 RVA: 0x0001AC16 File Offset: 0x00018E16
            // (set) Token: 0x06000B11 RID: 2833 RVA: 0x0001AC23 File Offset: 0x00018E23
            public int FailedAction
			{
				get
				{
					return result.FailedAction;
				}
				set
				{
					SetFailedAction(value);
				}
			}

			// Token: 0x06000B12 RID: 2834 RVA: 0x0001AC2D File Offset: 0x00018E2D
			public Builder SetFailedAction(int value)
			{
				PrepareBuilder();
				result.HasFailedAction = true;
				result.failedAction_ = value;
				return this;
			}

			// Token: 0x06000B13 RID: 2835 RVA: 0x0001AC4F File Offset: 0x00018E4F
			public Builder ClearFailedAction()
			{
				PrepareBuilder();
				result.HasFailedAction = false;
				result.failedAction_ = 0;
				return this;
			}

            // Token: 0x17000452 RID: 1106
            // (get) Token: 0x06000B14 RID: 2836 RVA: 0x0001AC71 File Offset: 0x00018E71
            public bool HasUrl => result.HasUrl;

            // Token: 0x17000453 RID: 1107
            // (get) Token: 0x06000B15 RID: 2837 RVA: 0x0001AC7E File Offset: 0x00018E7E
            // (set) Token: 0x06000B16 RID: 2838 RVA: 0x0001AC8B File Offset: 0x00018E8B
            public string Url
			{
				get
				{
					return result.Url;
				}
				set
				{
					SetUrl(value);
				}
			}

			// Token: 0x06000B17 RID: 2839 RVA: 0x0001AC95 File Offset: 0x00018E95
			public Builder SetUrl(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasUrl = true;
				result.url_ = value;
				return this;
			}

			// Token: 0x06000B18 RID: 2840 RVA: 0x0001ACC2 File Offset: 0x00018EC2
			public Builder ClearUrl()
			{
				PrepareBuilder();
				result.HasUrl = false;
				result.url_ = "";
				return this;
			}

            // Token: 0x17000454 RID: 1108
            // (get) Token: 0x06000B19 RID: 2841 RVA: 0x0001ACE8 File Offset: 0x00018EE8
            public bool HasWithcid => result.HasWithcid;

            // Token: 0x17000455 RID: 1109
            // (get) Token: 0x06000B1A RID: 2842 RVA: 0x0001ACF5 File Offset: 0x00018EF5
            // (set) Token: 0x06000B1B RID: 2843 RVA: 0x0001AD02 File Offset: 0x00018F02
            public string Withcid
			{
				get
				{
					return result.Withcid;
				}
				set
				{
					SetWithcid(value);
				}
			}

			// Token: 0x06000B1C RID: 2844 RVA: 0x0001AD0C File Offset: 0x00018F0C
			public Builder SetWithcid(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasWithcid = true;
				result.withcid_ = value;
				return this;
			}

			// Token: 0x06000B1D RID: 2845 RVA: 0x0001AD39 File Offset: 0x00018F39
			public Builder ClearWithcid()
			{
				PrepareBuilder();
				result.HasWithcid = false;
				result.withcid_ = "";
				return this;
			}

            // Token: 0x17000456 RID: 1110
            // (get) Token: 0x06000B1E RID: 2846 RVA: 0x0001AD5F File Offset: 0x00018F5F
            public bool HasIsWithnettype => result.HasIsWithnettype;

            // Token: 0x17000457 RID: 1111
            // (get) Token: 0x06000B1F RID: 2847 RVA: 0x0001AD6C File Offset: 0x00018F6C
            // (set) Token: 0x06000B20 RID: 2848 RVA: 0x0001AD79 File Offset: 0x00018F79
            public bool IsWithnettype
			{
				get
				{
					return result.IsWithnettype;
				}
				set
				{
					SetIsWithnettype(value);
				}
			}

			// Token: 0x06000B21 RID: 2849 RVA: 0x0001AD83 File Offset: 0x00018F83
			public Builder SetIsWithnettype(bool value)
			{
				PrepareBuilder();
				result.HasIsWithnettype = true;
				result.isWithnettype_ = value;
				return this;
			}

			// Token: 0x06000B22 RID: 2850 RVA: 0x0001ADA5 File Offset: 0x00018FA5
			public Builder ClearIsWithnettype()
			{
				PrepareBuilder();
				result.HasIsWithnettype = false;
				result.isWithnettype_ = false;
				return this;
			}

            // Token: 0x17000458 RID: 1112
            // (get) Token: 0x06000B23 RID: 2851 RVA: 0x0001ADC7 File Offset: 0x00018FC7
            public bool HasAddress => result.HasAddress;

            // Token: 0x17000459 RID: 1113
            // (get) Token: 0x06000B24 RID: 2852 RVA: 0x0001ADD4 File Offset: 0x00018FD4
            // (set) Token: 0x06000B25 RID: 2853 RVA: 0x0001ADE1 File Offset: 0x00018FE1
            public string Address
			{
				get
				{
					return result.Address;
				}
				set
				{
					SetAddress(value);
				}
			}

			// Token: 0x06000B26 RID: 2854 RVA: 0x0001ADEB File Offset: 0x00018FEB
			public Builder SetAddress(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasAddress = true;
				result.address_ = value;
				return this;
			}

			// Token: 0x06000B27 RID: 2855 RVA: 0x0001AE18 File Offset: 0x00019018
			public Builder ClearAddress()
			{
				PrepareBuilder();
				result.HasAddress = false;
				result.address_ = "";
				return this;
			}

            // Token: 0x1700045A RID: 1114
            // (get) Token: 0x06000B28 RID: 2856 RVA: 0x0001AE3E File Offset: 0x0001903E
            public bool HasContent => result.HasContent;

            // Token: 0x1700045B RID: 1115
            // (get) Token: 0x06000B29 RID: 2857 RVA: 0x0001AE4B File Offset: 0x0001904B
            // (set) Token: 0x06000B2A RID: 2858 RVA: 0x0001AE58 File Offset: 0x00019058
            public string Content
			{
				get
				{
					return result.Content;
				}
				set
				{
					SetContent(value);
				}
			}

			// Token: 0x06000B2B RID: 2859 RVA: 0x0001AE62 File Offset: 0x00019062
			public Builder SetContent(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasContent = true;
				result.content_ = value;
				return this;
			}

			// Token: 0x06000B2C RID: 2860 RVA: 0x0001AE8F File Offset: 0x0001908F
			public Builder ClearContent()
			{
				PrepareBuilder();
				result.HasContent = false;
				result.content_ = "";
				return this;
			}

            // Token: 0x1700045C RID: 1116
            // (get) Token: 0x06000B2D RID: 2861 RVA: 0x0001AEB5 File Offset: 0x000190B5
            public bool HasCt => result.HasCt;

            // Token: 0x1700045D RID: 1117
            // (get) Token: 0x06000B2E RID: 2862 RVA: 0x0001AEC2 File Offset: 0x000190C2
            // (set) Token: 0x06000B2F RID: 2863 RVA: 0x0001AECF File Offset: 0x000190CF
            public long Ct
			{
				get
				{
					return result.Ct;
				}
				set
				{
					SetCt(value);
				}
			}

			// Token: 0x06000B30 RID: 2864 RVA: 0x0001AED9 File Offset: 0x000190D9
			public Builder SetCt(long value)
			{
				PrepareBuilder();
				result.HasCt = true;
				result.ct_ = value;
				return this;
			}

			// Token: 0x06000B31 RID: 2865 RVA: 0x0001AEFB File Offset: 0x000190FB
			public Builder ClearCt()
			{
				PrepareBuilder();
				result.HasCt = false;
				result.ct_ = 0L;
				return this;
			}

            // Token: 0x1700045E RID: 1118
            // (get) Token: 0x06000B32 RID: 2866 RVA: 0x0001AF1E File Offset: 0x0001911E
            public bool HasFlag => result.HasFlag;

            // Token: 0x1700045F RID: 1119
            // (get) Token: 0x06000B33 RID: 2867 RVA: 0x0001AF2B File Offset: 0x0001912B
            // (set) Token: 0x06000B34 RID: 2868 RVA: 0x0001AF38 File Offset: 0x00019138
            public SMSStatus Flag
			{
				get
				{
					return result.Flag;
				}
				set
				{
					SetFlag(value);
				}
			}

			// Token: 0x06000B35 RID: 2869 RVA: 0x0001AF42 File Offset: 0x00019142
			public Builder SetFlag(SMSStatus value)
			{
				PrepareBuilder();
				result.HasFlag = true;
				result.flag_ = value;
				return this;
			}

			// Token: 0x06000B36 RID: 2870 RVA: 0x0001AF64 File Offset: 0x00019164
			public Builder ClearFlag()
			{
				PrepareBuilder();
				result.HasFlag = false;
				result.flag_ = SMSStatus.unread;
				return this;
			}

            // Token: 0x17000460 RID: 1120
            // (get) Token: 0x06000B37 RID: 2871 RVA: 0x0001AF86 File Offset: 0x00019186
            public bool HasSuccessedAction => result.HasSuccessedAction;

            // Token: 0x17000461 RID: 1121
            // (get) Token: 0x06000B38 RID: 2872 RVA: 0x0001AF93 File Offset: 0x00019193
            // (set) Token: 0x06000B39 RID: 2873 RVA: 0x0001AFA0 File Offset: 0x000191A0
            public int SuccessedAction
			{
				get
				{
					return result.SuccessedAction;
				}
				set
				{
					SetSuccessedAction(value);
				}
			}

			// Token: 0x06000B3A RID: 2874 RVA: 0x0001AFAA File Offset: 0x000191AA
			public Builder SetSuccessedAction(int value)
			{
				PrepareBuilder();
				result.HasSuccessedAction = true;
				result.successedAction_ = value;
				return this;
			}

			// Token: 0x06000B3B RID: 2875 RVA: 0x0001AFCC File Offset: 0x000191CC
			public Builder ClearSuccessedAction()
			{
				PrepareBuilder();
				result.HasSuccessedAction = false;
				result.successedAction_ = 0;
				return this;
			}

            // Token: 0x17000462 RID: 1122
            // (get) Token: 0x06000B3C RID: 2876 RVA: 0x0001AFEE File Offset: 0x000191EE
            public bool HasUninstalledAction => result.HasUninstalledAction;

            // Token: 0x17000463 RID: 1123
            // (get) Token: 0x06000B3D RID: 2877 RVA: 0x0001AFFB File Offset: 0x000191FB
            // (set) Token: 0x06000B3E RID: 2878 RVA: 0x0001B008 File Offset: 0x00019208
            public int UninstalledAction
			{
				get
				{
					return result.UninstalledAction;
				}
				set
				{
					SetUninstalledAction(value);
				}
			}

			// Token: 0x06000B3F RID: 2879 RVA: 0x0001B012 File Offset: 0x00019212
			public Builder SetUninstalledAction(int value)
			{
				PrepareBuilder();
				result.HasUninstalledAction = true;
				result.uninstalledAction_ = value;
				return this;
			}

			// Token: 0x06000B40 RID: 2880 RVA: 0x0001B034 File Offset: 0x00019234
			public Builder ClearUninstalledAction()
			{
				PrepareBuilder();
				result.HasUninstalledAction = false;
				result.uninstalledAction_ = 0;
				return this;
			}

            // Token: 0x17000464 RID: 1124
            // (get) Token: 0x06000B41 RID: 2881 RVA: 0x0001B056 File Offset: 0x00019256
            public bool HasName => result.HasName;

            // Token: 0x17000465 RID: 1125
            // (get) Token: 0x06000B42 RID: 2882 RVA: 0x0001B063 File Offset: 0x00019263
            // (set) Token: 0x06000B43 RID: 2883 RVA: 0x0001B070 File Offset: 0x00019270
            public string Name
			{
				get
				{
					return result.Name;
				}
				set
				{
					SetName(value);
				}
			}

			// Token: 0x06000B44 RID: 2884 RVA: 0x0001B07A File Offset: 0x0001927A
			public Builder SetName(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasName = true;
				result.name_ = value;
				return this;
			}

			// Token: 0x06000B45 RID: 2885 RVA: 0x0001B0A7 File Offset: 0x000192A7
			public Builder ClearName()
			{
				PrepareBuilder();
				result.HasName = false;
				result.name_ = "";
				return this;
			}

            // Token: 0x17000466 RID: 1126
            // (get) Token: 0x06000B46 RID: 2886 RVA: 0x0001B0CD File Offset: 0x000192CD
            public bool HasAutoInstall => result.HasAutoInstall;

            // Token: 0x17000467 RID: 1127
            // (get) Token: 0x06000B47 RID: 2887 RVA: 0x0001B0DA File Offset: 0x000192DA
            // (set) Token: 0x06000B48 RID: 2888 RVA: 0x0001B0E7 File Offset: 0x000192E7
            public bool AutoInstall
			{
				get
				{
					return result.AutoInstall;
				}
				set
				{
					SetAutoInstall(value);
				}
			}

			// Token: 0x06000B49 RID: 2889 RVA: 0x0001B0F1 File Offset: 0x000192F1
			public Builder SetAutoInstall(bool value)
			{
				PrepareBuilder();
				result.HasAutoInstall = true;
				result.autoInstall_ = value;
				return this;
			}

			// Token: 0x06000B4A RID: 2890 RVA: 0x0001B113 File Offset: 0x00019313
			public Builder ClearAutoInstall()
			{
				PrepareBuilder();
				result.HasAutoInstall = false;
				result.autoInstall_ = false;
				return this;
			}

            // Token: 0x17000468 RID: 1128
            // (get) Token: 0x06000B4B RID: 2891 RVA: 0x0001B135 File Offset: 0x00019335
            public bool HasWifiAutodownload => result.HasWifiAutodownload;

            // Token: 0x17000469 RID: 1129
            // (get) Token: 0x06000B4C RID: 2892 RVA: 0x0001B142 File Offset: 0x00019342
            // (set) Token: 0x06000B4D RID: 2893 RVA: 0x0001B14F File Offset: 0x0001934F
            public bool WifiAutodownload
			{
				get
				{
					return result.WifiAutodownload;
				}
				set
				{
					SetWifiAutodownload(value);
				}
			}

			// Token: 0x06000B4E RID: 2894 RVA: 0x0001B159 File Offset: 0x00019359
			public Builder SetWifiAutodownload(bool value)
			{
				PrepareBuilder();
				result.HasWifiAutodownload = true;
				result.wifiAutodownload_ = value;
				return this;
			}

			// Token: 0x06000B4F RID: 2895 RVA: 0x0001B17B File Offset: 0x0001937B
			public Builder ClearWifiAutodownload()
			{
				PrepareBuilder();
				result.HasWifiAutodownload = false;
				result.wifiAutodownload_ = false;
				return this;
			}

            // Token: 0x1700046A RID: 1130
            // (get) Token: 0x06000B50 RID: 2896 RVA: 0x0001B19D File Offset: 0x0001939D
            public bool HasForceDownload => result.HasForceDownload;

            // Token: 0x1700046B RID: 1131
            // (get) Token: 0x06000B51 RID: 2897 RVA: 0x0001B1AA File Offset: 0x000193AA
            // (set) Token: 0x06000B52 RID: 2898 RVA: 0x0001B1B7 File Offset: 0x000193B7
            public bool ForceDownload
			{
				get
				{
					return result.ForceDownload;
				}
				set
				{
					SetForceDownload(value);
				}
			}

			// Token: 0x06000B53 RID: 2899 RVA: 0x0001B1C1 File Offset: 0x000193C1
			public Builder SetForceDownload(bool value)
			{
				PrepareBuilder();
				result.HasForceDownload = true;
				result.forceDownload_ = value;
				return this;
			}

			// Token: 0x06000B54 RID: 2900 RVA: 0x0001B1E3 File Offset: 0x000193E3
			public Builder ClearForceDownload()
			{
				PrepareBuilder();
				result.HasForceDownload = false;
				result.forceDownload_ = false;
				return this;
			}

            // Token: 0x1700046C RID: 1132
            // (get) Token: 0x06000B55 RID: 2901 RVA: 0x0001B205 File Offset: 0x00019405
            public bool HasShowProgress => result.HasShowProgress;

            // Token: 0x1700046D RID: 1133
            // (get) Token: 0x06000B56 RID: 2902 RVA: 0x0001B212 File Offset: 0x00019412
            // (set) Token: 0x06000B57 RID: 2903 RVA: 0x0001B21F File Offset: 0x0001941F
            public bool ShowProgress
			{
				get
				{
					return result.ShowProgress;
				}
				set
				{
					SetShowProgress(value);
				}
			}

			// Token: 0x06000B58 RID: 2904 RVA: 0x0001B229 File Offset: 0x00019429
			public Builder SetShowProgress(bool value)
			{
				PrepareBuilder();
				result.HasShowProgress = true;
				result.showProgress_ = value;
				return this;
			}

			// Token: 0x06000B59 RID: 2905 RVA: 0x0001B24B File Offset: 0x0001944B
			public Builder ClearShowProgress()
			{
				PrepareBuilder();
				result.HasShowProgress = false;
				result.showProgress_ = false;
				return this;
			}

            // Token: 0x1700046E RID: 1134
            // (get) Token: 0x06000B5A RID: 2906 RVA: 0x0001B26D File Offset: 0x0001946D
            public bool HasPost => result.HasPost;

            // Token: 0x1700046F RID: 1135
            // (get) Token: 0x06000B5B RID: 2907 RVA: 0x0001B27A File Offset: 0x0001947A
            // (set) Token: 0x06000B5C RID: 2908 RVA: 0x0001B287 File Offset: 0x00019487
            public string Post
			{
				get
				{
					return result.Post;
				}
				set
				{
					SetPost(value);
				}
			}

			// Token: 0x06000B5D RID: 2909 RVA: 0x0001B291 File Offset: 0x00019491
			public Builder SetPost(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasPost = true;
				result.post_ = value;
				return this;
			}

			// Token: 0x06000B5E RID: 2910 RVA: 0x0001B2BE File Offset: 0x000194BE
			public Builder ClearPost()
			{
				PrepareBuilder();
				result.HasPost = false;
				result.post_ = "";
				return this;
			}

            // Token: 0x17000470 RID: 1136
            // (get) Token: 0x06000B5F RID: 2911 RVA: 0x0001B2E4 File Offset: 0x000194E4
            public bool HasHeaders => result.HasHeaders;

            // Token: 0x17000471 RID: 1137
            // (get) Token: 0x06000B60 RID: 2912 RVA: 0x0001B2F1 File Offset: 0x000194F1
            // (set) Token: 0x06000B61 RID: 2913 RVA: 0x0001B2FE File Offset: 0x000194FE
            public string Headers
			{
				get
				{
					return result.Headers;
				}
				set
				{
					SetHeaders(value);
				}
			}

			// Token: 0x06000B62 RID: 2914 RVA: 0x0001B308 File Offset: 0x00019508
			public Builder SetHeaders(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasHeaders = true;
				result.headers_ = value;
				return this;
			}

			// Token: 0x06000B63 RID: 2915 RVA: 0x0001B335 File Offset: 0x00019535
			public Builder ClearHeaders()
			{
				PrepareBuilder();
				result.HasHeaders = false;
				result.headers_ = "";
				return this;
			}

            // Token: 0x17000472 RID: 1138
            // (get) Token: 0x06000B64 RID: 2916 RVA: 0x0001B35B File Offset: 0x0001955B
            public bool HasGroupable => result.HasGroupable;

            // Token: 0x17000473 RID: 1139
            // (get) Token: 0x06000B65 RID: 2917 RVA: 0x0001B368 File Offset: 0x00019568
            // (set) Token: 0x06000B66 RID: 2918 RVA: 0x0001B375 File Offset: 0x00019575
            public bool Groupable
			{
				get
				{
					return result.Groupable;
				}
				set
				{
					SetGroupable(value);
				}
			}

			// Token: 0x06000B67 RID: 2919 RVA: 0x0001B37F File Offset: 0x0001957F
			public Builder SetGroupable(bool value)
			{
				PrepareBuilder();
				result.HasGroupable = true;
				result.groupable_ = value;
				return this;
			}

			// Token: 0x06000B68 RID: 2920 RVA: 0x0001B3A1 File Offset: 0x000195A1
			public Builder ClearGroupable()
			{
				PrepareBuilder();
				result.HasGroupable = false;
				result.groupable_ = false;
				return this;
			}

            // Token: 0x17000474 RID: 1140
            // (get) Token: 0x06000B69 RID: 2921 RVA: 0x0001B3C3 File Offset: 0x000195C3
            public bool HasMmsTitle => result.HasMmsTitle;

            // Token: 0x17000475 RID: 1141
            // (get) Token: 0x06000B6A RID: 2922 RVA: 0x0001B3D0 File Offset: 0x000195D0
            // (set) Token: 0x06000B6B RID: 2923 RVA: 0x0001B3DD File Offset: 0x000195DD
            public string MmsTitle
			{
				get
				{
					return result.MmsTitle;
				}
				set
				{
					SetMmsTitle(value);
				}
			}

			// Token: 0x06000B6C RID: 2924 RVA: 0x0001B3E7 File Offset: 0x000195E7
			public Builder SetMmsTitle(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasMmsTitle = true;
				result.mmsTitle_ = value;
				return this;
			}

			// Token: 0x06000B6D RID: 2925 RVA: 0x0001B414 File Offset: 0x00019614
			public Builder ClearMmsTitle()
			{
				PrepareBuilder();
				result.HasMmsTitle = false;
				result.mmsTitle_ = "";
				return this;
			}

            // Token: 0x17000476 RID: 1142
            // (get) Token: 0x06000B6E RID: 2926 RVA: 0x0001B43A File Offset: 0x0001963A
            public bool HasMmsURL => result.HasMmsURL;

            // Token: 0x17000477 RID: 1143
            // (get) Token: 0x06000B6F RID: 2927 RVA: 0x0001B447 File Offset: 0x00019647
            // (set) Token: 0x06000B70 RID: 2928 RVA: 0x0001B454 File Offset: 0x00019654
            public string MmsURL
			{
				get
				{
					return result.MmsURL;
				}
				set
				{
					SetMmsURL(value);
				}
			}

			// Token: 0x06000B71 RID: 2929 RVA: 0x0001B45E File Offset: 0x0001965E
			public Builder SetMmsURL(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasMmsURL = true;
				result.mmsURL_ = value;
				return this;
			}

			// Token: 0x06000B72 RID: 2930 RVA: 0x0001B48B File Offset: 0x0001968B
			public Builder ClearMmsURL()
			{
				PrepareBuilder();
				result.HasMmsURL = false;
				result.mmsURL_ = "";
				return this;
			}

            // Token: 0x17000478 RID: 1144
            // (get) Token: 0x06000B73 RID: 2931 RVA: 0x0001B4B1 File Offset: 0x000196B1
            public bool HasPreload => result.HasPreload;

            // Token: 0x17000479 RID: 1145
            // (get) Token: 0x06000B74 RID: 2932 RVA: 0x0001B4BE File Offset: 0x000196BE
            // (set) Token: 0x06000B75 RID: 2933 RVA: 0x0001B4CB File Offset: 0x000196CB
            public bool Preload
			{
				get
				{
					return result.Preload;
				}
				set
				{
					SetPreload(value);
				}
			}

			// Token: 0x06000B76 RID: 2934 RVA: 0x0001B4D5 File Offset: 0x000196D5
			public Builder SetPreload(bool value)
			{
				PrepareBuilder();
				result.HasPreload = true;
				result.preload_ = value;
				return this;
			}

			// Token: 0x06000B77 RID: 2935 RVA: 0x0001B4F7 File Offset: 0x000196F7
			public Builder ClearPreload()
			{
				PrepareBuilder();
				result.HasPreload = false;
				result.preload_ = false;
				return this;
			}

            // Token: 0x1700047A RID: 1146
            // (get) Token: 0x06000B78 RID: 2936 RVA: 0x0001B519 File Offset: 0x00019719
            public bool HasTaskid => result.HasTaskid;

            // Token: 0x1700047B RID: 1147
            // (get) Token: 0x06000B79 RID: 2937 RVA: 0x0001B526 File Offset: 0x00019726
            // (set) Token: 0x06000B7A RID: 2938 RVA: 0x0001B533 File Offset: 0x00019733
            public string Taskid
			{
				get
				{
					return result.Taskid;
				}
				set
				{
					SetTaskid(value);
				}
			}

			// Token: 0x06000B7B RID: 2939 RVA: 0x0001B53D File Offset: 0x0001973D
			public Builder SetTaskid(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasTaskid = true;
				result.taskid_ = value;
				return this;
			}

			// Token: 0x06000B7C RID: 2940 RVA: 0x0001B56A File Offset: 0x0001976A
			public Builder ClearTaskid()
			{
				PrepareBuilder();
				result.HasTaskid = false;
				result.taskid_ = "";
				return this;
			}

            // Token: 0x1700047C RID: 1148
            // (get) Token: 0x06000B7D RID: 2941 RVA: 0x0001B590 File Offset: 0x00019790
            public bool HasDuration => result.HasDuration;

            // Token: 0x1700047D RID: 1149
            // (get) Token: 0x06000B7E RID: 2942 RVA: 0x0001B59D File Offset: 0x0001979D
            // (set) Token: 0x06000B7F RID: 2943 RVA: 0x0001B5AA File Offset: 0x000197AA
            public long Duration
			{
				get
				{
					return result.Duration;
				}
				set
				{
					SetDuration(value);
				}
			}

			// Token: 0x06000B80 RID: 2944 RVA: 0x0001B5B4 File Offset: 0x000197B4
			public Builder SetDuration(long value)
			{
				PrepareBuilder();
				result.HasDuration = true;
				result.duration_ = value;
				return this;
			}

			// Token: 0x06000B81 RID: 2945 RVA: 0x0001B5D6 File Offset: 0x000197D6
			public Builder ClearDuration()
			{
				PrepareBuilder();
				result.HasDuration = false;
				result.duration_ = 0L;
				return this;
			}

            // Token: 0x1700047E RID: 1150
            // (get) Token: 0x06000B82 RID: 2946 RVA: 0x0001B5F9 File Offset: 0x000197F9
            public bool HasDate => result.HasDate;

            // Token: 0x1700047F RID: 1151
            // (get) Token: 0x06000B83 RID: 2947 RVA: 0x0001B606 File Offset: 0x00019806
            // (set) Token: 0x06000B84 RID: 2948 RVA: 0x0001B613 File Offset: 0x00019813
            public string Date
			{
				get
				{
					return result.Date;
				}
				set
				{
					SetDate(value);
				}
			}

			// Token: 0x06000B85 RID: 2949 RVA: 0x0001B61D File Offset: 0x0001981D
			public Builder SetDate(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasDate = true;
				result.date_ = value;
				return this;
			}

			// Token: 0x06000B86 RID: 2950 RVA: 0x0001B64A File Offset: 0x0001984A
			public Builder ClearDate()
			{
				PrepareBuilder();
				result.HasDate = false;
				result.date_ = "";
				return this;
			}

            // Token: 0x17000480 RID: 1152
            // (get) Token: 0x06000B87 RID: 2951 RVA: 0x0001B670 File Offset: 0x00019870
            public bool HasStype => result.HasStype;

            // Token: 0x17000481 RID: 1153
            // (get) Token: 0x06000B88 RID: 2952 RVA: 0x0001B67D File Offset: 0x0001987D
            // (set) Token: 0x06000B89 RID: 2953 RVA: 0x0001B68A File Offset: 0x0001988A
            public string Stype
			{
				get
				{
					return result.Stype;
				}
				set
				{
					SetStype(value);
				}
			}

			// Token: 0x06000B8A RID: 2954 RVA: 0x0001B694 File Offset: 0x00019894
			public Builder SetStype(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasStype = true;
				result.stype_ = value;
				return this;
			}

			// Token: 0x06000B8B RID: 2955 RVA: 0x0001B6C1 File Offset: 0x000198C1
			public Builder ClearStype()
			{
				PrepareBuilder();
				result.HasStype = false;
				result.stype_ = "";
				return this;
			}

            // Token: 0x17000482 RID: 1154
            // (get) Token: 0x06000B8C RID: 2956 RVA: 0x0001B6E7 File Offset: 0x000198E7
            public IPopsicleList<InnerFiled> FieldList => PrepareBuilder().field_;

            // Token: 0x17000483 RID: 1155
            // (get) Token: 0x06000B8D RID: 2957 RVA: 0x0001B6F4 File Offset: 0x000198F4
            public int FieldCount => result.FieldCount;

            // Token: 0x06000B8E RID: 2958 RVA: 0x0001B701 File Offset: 0x00019901
            public InnerFiled GetField(int index)
			{
				return result.GetField(index);
			}

			// Token: 0x06000B8F RID: 2959 RVA: 0x0001B70F File Offset: 0x0001990F
			public Builder SetField(int index, InnerFiled value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.field_[index] = value;
				return this;
			}

			// Token: 0x06000B90 RID: 2960 RVA: 0x0001B736 File Offset: 0x00019936
			public Builder SetField(int index, InnerFiled.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.field_[index] = builderForValue.Build();
				return this;
			}

			// Token: 0x06000B91 RID: 2961 RVA: 0x0001B762 File Offset: 0x00019962
			public Builder AddField(InnerFiled value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.field_.Add(value);
				return this;
			}

			// Token: 0x06000B92 RID: 2962 RVA: 0x0001B788 File Offset: 0x00019988
			public Builder AddField(InnerFiled.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.field_.Add(builderForValue.Build());
				return this;
			}

			// Token: 0x06000B93 RID: 2963 RVA: 0x0001B7B3 File Offset: 0x000199B3
			public Builder AddRangeField(IEnumerable<InnerFiled> values)
			{
				PrepareBuilder();
				result.field_.Add(values);
				return this;
			}

			// Token: 0x06000B94 RID: 2964 RVA: 0x0001B7CE File Offset: 0x000199CE
			public Builder ClearField()
			{
				PrepareBuilder();
				result.field_.Clear();
				return this;
			}

			// Token: 0x040003E7 RID: 999
			private bool resultIsReadOnly;

			// Token: 0x040003E8 RID: 1000
			private ActionChain result;
		}
	}
}
