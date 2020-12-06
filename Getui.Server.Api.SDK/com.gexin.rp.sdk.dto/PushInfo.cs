using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    // Token: 0x0200001E RID: 30
    [DebuggerNonUserCode]
	public sealed class PushInfo : GeneratedMessage<PushInfo, PushInfo.Builder>
	{
		// Token: 0x06000317 RID: 791 RVA: 0x00006CB0 File Offset: 0x00004EB0
		private PushInfo()
		{
		}

        // Token: 0x17000163 RID: 355
        // (get) Token: 0x06000318 RID: 792 RVA: 0x00006D43 File Offset: 0x00004F43
        public static PushInfo DefaultInstance { get; } = new PushInfo().MakeReadOnly();

        // Token: 0x17000164 RID: 356
        // (get) Token: 0x06000319 RID: 793 RVA: 0x00006D4A File Offset: 0x00004F4A
        public override PushInfo DefaultInstanceForType => DefaultInstance;

        // Token: 0x17000165 RID: 357
        // (get) Token: 0x0600031A RID: 794 RVA: 0x00006D51 File Offset: 0x00004F51
        protected override PushInfo ThisMessage => this;

        // Token: 0x17000166 RID: 358
        // (get) Token: 0x0600031B RID: 795 RVA: 0x00006D54 File Offset: 0x00004F54
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_PushInfo__Descriptor;

        // Token: 0x17000167 RID: 359
        // (get) Token: 0x0600031C RID: 796 RVA: 0x00006D5B File Offset: 0x00004F5B
        protected override FieldAccessorTable<PushInfo, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_PushInfo__FieldAccessorTable;

        // Token: 0x17000168 RID: 360
        // (get) Token: 0x0600031D RID: 797 RVA: 0x00006D62 File Offset: 0x00004F62
        public bool HasMessage { get; private set; }

        // Token: 0x17000169 RID: 361
        // (get) Token: 0x0600031E RID: 798 RVA: 0x00006D6A File Offset: 0x00004F6A
        public string Message => message_;

        // Token: 0x1700016A RID: 362
        // (get) Token: 0x0600031F RID: 799 RVA: 0x00006D72 File Offset: 0x00004F72
        public bool HasActionKey { get; private set; }

        // Token: 0x1700016B RID: 363
        // (get) Token: 0x06000320 RID: 800 RVA: 0x00006D7A File Offset: 0x00004F7A
        public string ActionKey => actionKey_;

        // Token: 0x1700016C RID: 364
        // (get) Token: 0x06000321 RID: 801 RVA: 0x00006D82 File Offset: 0x00004F82
        public bool HasSound { get; private set; }

        // Token: 0x1700016D RID: 365
        // (get) Token: 0x06000322 RID: 802 RVA: 0x00006D8A File Offset: 0x00004F8A
        public string Sound => sound_;

        // Token: 0x1700016E RID: 366
        // (get) Token: 0x06000323 RID: 803 RVA: 0x00006D92 File Offset: 0x00004F92
        public bool HasBadge { get; private set; }

        // Token: 0x1700016F RID: 367
        // (get) Token: 0x06000324 RID: 804 RVA: 0x00006D9A File Offset: 0x00004F9A
        public string Badge => badge_;

        // Token: 0x17000170 RID: 368
        // (get) Token: 0x06000325 RID: 805 RVA: 0x00006DA2 File Offset: 0x00004FA2
        public bool HasPayload { get; private set; }

        // Token: 0x17000171 RID: 369
        // (get) Token: 0x06000326 RID: 806 RVA: 0x00006DAA File Offset: 0x00004FAA
        public string Payload => payload_;

        // Token: 0x17000172 RID: 370
        // (get) Token: 0x06000327 RID: 807 RVA: 0x00006DB2 File Offset: 0x00004FB2
        public bool HasLocKey { get; private set; }

        // Token: 0x17000173 RID: 371
        // (get) Token: 0x06000328 RID: 808 RVA: 0x00006DBA File Offset: 0x00004FBA
        public string LocKey => locKey_;

        // Token: 0x17000174 RID: 372
        // (get) Token: 0x06000329 RID: 809 RVA: 0x00006DC2 File Offset: 0x00004FC2
        public bool HasLocArgs { get; private set; }

        // Token: 0x17000175 RID: 373
        // (get) Token: 0x0600032A RID: 810 RVA: 0x00006DCA File Offset: 0x00004FCA
        public string LocArgs => locArgs_;

        // Token: 0x17000176 RID: 374
        // (get) Token: 0x0600032B RID: 811 RVA: 0x00006DD2 File Offset: 0x00004FD2
        public bool HasActionLocKey { get; private set; }

        // Token: 0x17000177 RID: 375
        // (get) Token: 0x0600032C RID: 812 RVA: 0x00006DDA File Offset: 0x00004FDA
        public string ActionLocKey => actionLocKey_;

        // Token: 0x17000178 RID: 376
        // (get) Token: 0x0600032D RID: 813 RVA: 0x00006DE2 File Offset: 0x00004FE2
        public bool HasLaunchImage { get; private set; }

        // Token: 0x17000179 RID: 377
        // (get) Token: 0x0600032E RID: 814 RVA: 0x00006DEA File Offset: 0x00004FEA
        public string LaunchImage => launchImage_;

        // Token: 0x1700017A RID: 378
        // (get) Token: 0x0600032F RID: 815 RVA: 0x00006DF2 File Offset: 0x00004FF2
        public bool HasContentAvailable { get; private set; }

        // Token: 0x1700017B RID: 379
        // (get) Token: 0x06000330 RID: 816 RVA: 0x00006DFA File Offset: 0x00004FFA
        public int ContentAvailable => contentAvailable_;

        // Token: 0x1700017C RID: 380
        // (get) Token: 0x06000331 RID: 817 RVA: 0x00006E02 File Offset: 0x00005002
        public bool HasInvalidAPN { get; private set; }

        // Token: 0x1700017D RID: 381
        // (get) Token: 0x06000332 RID: 818 RVA: 0x00006E0A File Offset: 0x0000500A
        public bool InvalidAPN => invalidAPN_;

        // Token: 0x1700017E RID: 382
        // (get) Token: 0x06000333 RID: 819 RVA: 0x00006E12 File Offset: 0x00005012
        public bool HasApnJson { get; private set; }

        // Token: 0x1700017F RID: 383
        // (get) Token: 0x06000334 RID: 820 RVA: 0x00006E1A File Offset: 0x0000501A
        public string ApnJson => apnJson_;

        // Token: 0x17000180 RID: 384
        // (get) Token: 0x06000335 RID: 821 RVA: 0x00006E22 File Offset: 0x00005022
        public bool HasInvalidMPN { get; private set; }

        // Token: 0x17000181 RID: 385
        // (get) Token: 0x06000336 RID: 822 RVA: 0x00006E2A File Offset: 0x0000502A
        public bool InvalidMPN => invalidMPN_;

        // Token: 0x17000182 RID: 386
        // (get) Token: 0x06000337 RID: 823 RVA: 0x00006E32 File Offset: 0x00005032
        public bool HasMpnXml { get; private set; }

        // Token: 0x17000183 RID: 387
        // (get) Token: 0x06000338 RID: 824 RVA: 0x00006E3A File Offset: 0x0000503A
        public string MpnXml => mpnXml_;

        // Token: 0x17000184 RID: 388
        // (get) Token: 0x06000339 RID: 825 RVA: 0x00006E42 File Offset: 0x00005042
        public bool HasValidNotify { get; private set; }

        // Token: 0x17000185 RID: 389
        // (get) Token: 0x0600033A RID: 826 RVA: 0x00006E4A File Offset: 0x0000504A
        public bool ValidNotify => validNotify_;

        // Token: 0x17000186 RID: 390
        // (get) Token: 0x0600033B RID: 827 RVA: 0x00006E52 File Offset: 0x00005052
        public bool HasNotifyInfo { get; private set; }

        // Token: 0x17000187 RID: 391
        // (get) Token: 0x0600033C RID: 828 RVA: 0x00006E5A File Offset: 0x0000505A
        public NotifyInfo NotifyInfo => notifyInfo_ ?? NotifyInfo.DefaultInstance;

        // Token: 0x17000188 RID: 392
        // (get) Token: 0x0600033D RID: 829 RVA: 0x00006E6B File Offset: 0x0000506B
        public override bool IsInitialized => !HasNotifyInfo || NotifyInfo.IsInitialized;

        // Token: 0x0600033E RID: 830 RVA: 0x00006E88 File Offset: 0x00005088
        public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] pushInfoFieldNames = _pushInfoFieldNames;
			if (HasMessage)
			{
				output.WriteString(1, pushInfoFieldNames[10], Message);
			}
			if (HasActionKey)
			{
				output.WriteString(2, pushInfoFieldNames[0], ActionKey);
			}
			if (HasSound)
			{
				output.WriteString(3, pushInfoFieldNames[14], Sound);
			}
			if (HasBadge)
			{
				output.WriteString(4, pushInfoFieldNames[3], Badge);
			}
			if (HasPayload)
			{
				output.WriteString(5, pushInfoFieldNames[13], Payload);
			}
			if (HasLocKey)
			{
				output.WriteString(6, pushInfoFieldNames[9], LocKey);
			}
			if (HasLocArgs)
			{
				output.WriteString(7, pushInfoFieldNames[8], LocArgs);
			}
			if (HasActionLocKey)
			{
				output.WriteString(8, pushInfoFieldNames[1], ActionLocKey);
			}
			if (HasLaunchImage)
			{
				output.WriteString(9, pushInfoFieldNames[7], LaunchImage);
			}
			if (HasContentAvailable)
			{
				output.WriteInt32(10, pushInfoFieldNames[4], ContentAvailable);
			}
			if (HasInvalidAPN)
			{
				output.WriteBool(11, pushInfoFieldNames[5], InvalidAPN);
			}
			if (HasApnJson)
			{
				output.WriteString(12, pushInfoFieldNames[2], ApnJson);
			}
			if (HasInvalidMPN)
			{
				output.WriteBool(13, pushInfoFieldNames[6], InvalidMPN);
			}
			if (HasMpnXml)
			{
				output.WriteString(14, pushInfoFieldNames[11], MpnXml);
			}
			if (HasValidNotify)
			{
				output.WriteBool(15, pushInfoFieldNames[15], ValidNotify);
			}
			if (HasNotifyInfo)
			{
				output.WriteMessage(16, pushInfoFieldNames[12], NotifyInfo);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600033F RID: 831 RVA: 0x00007040 File Offset: 0x00005240
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
				if (HasMessage)
				{
					num += CodedOutputStream.ComputeStringSize(1, Message);
				}
				if (HasActionKey)
				{
					num += CodedOutputStream.ComputeStringSize(2, ActionKey);
				}
				if (HasSound)
				{
					num += CodedOutputStream.ComputeStringSize(3, Sound);
				}
				if (HasBadge)
				{
					num += CodedOutputStream.ComputeStringSize(4, Badge);
				}
				if (HasPayload)
				{
					num += CodedOutputStream.ComputeStringSize(5, Payload);
				}
				if (HasLocKey)
				{
					num += CodedOutputStream.ComputeStringSize(6, LocKey);
				}
				if (HasLocArgs)
				{
					num += CodedOutputStream.ComputeStringSize(7, LocArgs);
				}
				if (HasActionLocKey)
				{
					num += CodedOutputStream.ComputeStringSize(8, ActionLocKey);
				}
				if (HasLaunchImage)
				{
					num += CodedOutputStream.ComputeStringSize(9, LaunchImage);
				}
				if (HasContentAvailable)
				{
					num += CodedOutputStream.ComputeInt32Size(10, ContentAvailable);
				}
				if (HasInvalidAPN)
				{
					num += CodedOutputStream.ComputeBoolSize(11, InvalidAPN);
				}
				if (HasApnJson)
				{
					num += CodedOutputStream.ComputeStringSize(12, ApnJson);
				}
				if (HasInvalidMPN)
				{
					num += CodedOutputStream.ComputeBoolSize(13, InvalidMPN);
				}
				if (HasMpnXml)
				{
					num += CodedOutputStream.ComputeStringSize(14, MpnXml);
				}
				if (HasValidNotify)
				{
					num += CodedOutputStream.ComputeBoolSize(15, ValidNotify);
				}
				if (HasNotifyInfo)
				{
					num += CodedOutputStream.ComputeMessageSize(16, NotifyInfo);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x000071EA File Offset: 0x000053EA
		public static PushInfo ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000341 RID: 833 RVA: 0x000071FC File Offset: 0x000053FC
		public static PushInfo ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000720F File Offset: 0x0000540F
		public static PushInfo ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00007221 File Offset: 0x00005421
		public static PushInfo ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00007234 File Offset: 0x00005434
		public static PushInfo ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00007246 File Offset: 0x00005446
		public static PushInfo ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00007259 File Offset: 0x00005459
		public static PushInfo ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000726B File Offset: 0x0000546B
		public static PushInfo ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000727E File Offset: 0x0000547E
		public static PushInfo ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00007290 File Offset: 0x00005490
		public static PushInfo ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600034A RID: 842 RVA: 0x000072A3 File Offset: 0x000054A3
		private PushInfo MakeReadOnly()
		{
			return this;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x000072A6 File Offset: 0x000054A6
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x0600034C RID: 844 RVA: 0x000072AD File Offset: 0x000054AD
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x000072B5 File Offset: 0x000054B5
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x0600034E RID: 846 RVA: 0x000072BC File Offset: 0x000054BC
		public static Builder CreateBuilder(PushInfo prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x000072C4 File Offset: 0x000054C4
		static PushInfo()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x040001C9 RID: 457
        private static readonly string[] _pushInfoFieldNames = new string[]
		{
			"actionKey",
			"actionLocKey",
			"apnJson",
			"badge",
			"contentAvailable",
			"invalidAPN",
			"invalidMPN",
			"launchImage",
			"locArgs",
			"locKey",
			"message",
			"mpnXml",
			"notifyInfo",
			"payload",
			"sound",
			"validNotify"
		};

		// Token: 0x040001CA RID: 458
		private static readonly uint[] _pushInfoFieldTags = new uint[]
		{
			18U,
			66U,
			98U,
			34U,
			80U,
			88U,
			104U,
			74U,
			58U,
			50U,
			10U,
			114U,
			130U,
			42U,
			26U,
			120U
		};

		// Token: 0x040001CB RID: 459
		public const int MessageFieldNumber = 1;

        // Token: 0x040001CD RID: 461
        private string message_ = "";

		// Token: 0x040001CE RID: 462
		public const int ActionKeyFieldNumber = 2;

        // Token: 0x040001D0 RID: 464
        private string actionKey_ = "";

		// Token: 0x040001D1 RID: 465
		public const int SoundFieldNumber = 3;

        // Token: 0x040001D3 RID: 467
        private string sound_ = "";

		// Token: 0x040001D4 RID: 468
		public const int BadgeFieldNumber = 4;

        // Token: 0x040001D6 RID: 470
        private string badge_ = "";

		// Token: 0x040001D7 RID: 471
		public const int PayloadFieldNumber = 5;

        // Token: 0x040001D9 RID: 473
        private string payload_ = "";

		// Token: 0x040001DA RID: 474
		public const int LocKeyFieldNumber = 6;

        // Token: 0x040001DC RID: 476
        private string locKey_ = "";

		// Token: 0x040001DD RID: 477
		public const int LocArgsFieldNumber = 7;

        // Token: 0x040001DF RID: 479
        private string locArgs_ = "";

		// Token: 0x040001E0 RID: 480
		public const int ActionLocKeyFieldNumber = 8;

        // Token: 0x040001E2 RID: 482
        private string actionLocKey_ = "";

		// Token: 0x040001E3 RID: 483
		public const int LaunchImageFieldNumber = 9;

        // Token: 0x040001E5 RID: 485
        private string launchImage_ = "";

		// Token: 0x040001E6 RID: 486
		public const int ContentAvailableFieldNumber = 10;

        // Token: 0x040001E8 RID: 488
        private int contentAvailable_;

		// Token: 0x040001E9 RID: 489
		public const int InvalidAPNFieldNumber = 11;

        // Token: 0x040001EB RID: 491
        private bool invalidAPN_;

		// Token: 0x040001EC RID: 492
		public const int ApnJsonFieldNumber = 12;

        // Token: 0x040001EE RID: 494
        private string apnJson_ = "";

		// Token: 0x040001EF RID: 495
		public const int InvalidMPNFieldNumber = 13;

        // Token: 0x040001F1 RID: 497
        private bool invalidMPN_;

		// Token: 0x040001F2 RID: 498
		public const int MpnXmlFieldNumber = 14;

        // Token: 0x040001F4 RID: 500
        private string mpnXml_ = "";

		// Token: 0x040001F5 RID: 501
		public const int ValidNotifyFieldNumber = 15;

        // Token: 0x040001F7 RID: 503
        private bool validNotify_;

		// Token: 0x040001F8 RID: 504
		public const int NotifyInfoFieldNumber = 16;

        // Token: 0x040001FA RID: 506
        private NotifyInfo notifyInfo_;

		// Token: 0x040001FB RID: 507
		private int memoizedSerializedSize = -1;

		// Token: 0x0200007A RID: 122
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<PushInfo, Builder>
		{
            // Token: 0x170003F3 RID: 1011
            // (get) Token: 0x06000A17 RID: 2583 RVA: 0x000180B5 File Offset: 0x000162B5
            protected override Builder ThisBuilder => this;

            // Token: 0x06000A18 RID: 2584 RVA: 0x000180B8 File Offset: 0x000162B8
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x06000A19 RID: 2585 RVA: 0x000180D2 File Offset: 0x000162D2
			internal Builder(PushInfo cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x06000A1A RID: 2586 RVA: 0x000180E8 File Offset: 0x000162E8
			private PushInfo PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					PushInfo other = result;
					result = new PushInfo();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x170003F4 RID: 1012
            // (get) Token: 0x06000A1B RID: 2587 RVA: 0x00018124 File Offset: 0x00016324
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x170003F5 RID: 1013
            // (get) Token: 0x06000A1C RID: 2588 RVA: 0x00018131 File Offset: 0x00016331
            protected override PushInfo MessageBeingBuilt => PrepareBuilder();

            // Token: 0x06000A1D RID: 2589 RVA: 0x00018139 File Offset: 0x00016339
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x06000A1E RID: 2590 RVA: 0x0001814E File Offset: 0x0001634E
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x170003F6 RID: 1014
            // (get) Token: 0x06000A1F RID: 2591 RVA: 0x00018174 File Offset: 0x00016374
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x170003F7 RID: 1015
            // (get) Token: 0x06000A20 RID: 2592 RVA: 0x0001817B File Offset: 0x0001637B
            public override PushInfo DefaultInstanceForType => DefaultInstance;

            // Token: 0x06000A21 RID: 2593 RVA: 0x00018182 File Offset: 0x00016382
            public override PushInfo BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x06000A22 RID: 2594 RVA: 0x000181A5 File Offset: 0x000163A5
			public override Builder MergeFrom(IMessage other)
			{
				if (other is PushInfo)
				{
					return MergeFrom((PushInfo)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x06000A23 RID: 2595 RVA: 0x000181C8 File Offset: 0x000163C8
			public override Builder MergeFrom(PushInfo other)
			{
				if (other == DefaultInstance)
				{
					return this;
				}
				PrepareBuilder();
				if (other.HasMessage)
				{
					Message = other.Message;
				}
				if (other.HasActionKey)
				{
					ActionKey = other.ActionKey;
				}
				if (other.HasSound)
				{
					Sound = other.Sound;
				}
				if (other.HasBadge)
				{
					Badge = other.Badge;
				}
				if (other.HasPayload)
				{
					Payload = other.Payload;
				}
				if (other.HasLocKey)
				{
					LocKey = other.LocKey;
				}
				if (other.HasLocArgs)
				{
					LocArgs = other.LocArgs;
				}
				if (other.HasActionLocKey)
				{
					ActionLocKey = other.ActionLocKey;
				}
				if (other.HasLaunchImage)
				{
					LaunchImage = other.LaunchImage;
				}
				if (other.HasContentAvailable)
				{
					ContentAvailable = other.ContentAvailable;
				}
				if (other.HasInvalidAPN)
				{
					InvalidAPN = other.InvalidAPN;
				}
				if (other.HasApnJson)
				{
					ApnJson = other.ApnJson;
				}
				if (other.HasInvalidMPN)
				{
					InvalidMPN = other.InvalidMPN;
				}
				if (other.HasMpnXml)
				{
					MpnXml = other.MpnXml;
				}
				if (other.HasValidNotify)
				{
					ValidNotify = other.ValidNotify;
				}
				if (other.HasNotifyInfo)
				{
					MergeNotifyInfo(other.NotifyInfo);
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x06000A24 RID: 2596 RVA: 0x00018335 File Offset: 0x00016535
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x06000A25 RID: 2597 RVA: 0x00018344 File Offset: 0x00016544
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_pushInfoFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _pushInfoFieldTags[num2];
                    }
                    if (num <= 58U)
                    {
                        if (num <= 26U)
                        {
                            if (num <= 10U)
                            {
                                if (num == 0U)
                                {
                                    throw InvalidProtocolBufferException.InvalidTag();
                                }
                                if (num == 10U)
                                {
                                    result.HasMessage = input.ReadString(ref result.message_);
                                    continue;
                                }
                            }
                            else
                            {
                                if (num == 18U)
                                {
                                    result.HasActionKey = input.ReadString(ref result.actionKey_);
                                    continue;
                                }
                                if (num == 26U)
                                {
                                    result.HasSound = input.ReadString(ref result.sound_);
                                    continue;
                                }
                            }
                        }
                        else if (num <= 42U)
                        {
                            if (num == 34U)
                            {
                                result.HasBadge = input.ReadString(ref result.badge_);
                                continue;
                            }
                            if (num == 42U)
                            {
                                result.HasPayload = input.ReadString(ref result.payload_);
                                continue;
                            }
                        }
                        else
                        {
                            if (num == 50U)
                            {
                                result.HasLocKey = input.ReadString(ref result.locKey_);
                                continue;
                            }
                            if (num == 58U)
                            {
                                result.HasLocArgs = input.ReadString(ref result.locArgs_);
                                continue;
                            }
                        }
                    }
                    else if (num <= 88U)
                    {
                        if (num <= 74U)
                        {
                            if (num == 66U)
                            {
                                result.HasActionLocKey = input.ReadString(ref result.actionLocKey_);
                                continue;
                            }
                            if (num == 74U)
                            {
                                result.HasLaunchImage = input.ReadString(ref result.launchImage_);
                                continue;
                            }
                        }
                        else
                        {
                            if (num == 80U)
                            {
                                result.HasContentAvailable = input.ReadInt32(ref result.contentAvailable_);
                                continue;
                            }
                            if (num == 88U)
                            {
                                result.HasInvalidAPN = input.ReadBool(ref result.invalidAPN_);
                                continue;
                            }
                        }
                    }
                    else if (num <= 104U)
                    {
                        if (num == 98U)
                        {
                            result.HasApnJson = input.ReadString(ref result.apnJson_);
                            continue;
                        }
                        if (num == 104U)
                        {
                            result.HasInvalidMPN = input.ReadBool(ref result.invalidMPN_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 114U)
                        {
                            result.HasMpnXml = input.ReadString(ref result.mpnXml_);
                            continue;
                        }
                        if (num == 120U)
                        {
                            result.HasValidNotify = input.ReadBool(ref result.validNotify_);
                            continue;
                        }
                        if (num == 130U)
                        {
                            NotifyInfo.Builder builder2 = NotifyInfo.CreateBuilder();
                            if (result.HasNotifyInfo)
                            {
                                builder2.MergeFrom(NotifyInfo);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            NotifyInfo = builder2.BuildPartial();
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

            // Token: 0x170003F8 RID: 1016
            // (get) Token: 0x06000A26 RID: 2598 RVA: 0x000186E2 File Offset: 0x000168E2
            public bool HasMessage => result.HasMessage;

            // Token: 0x170003F9 RID: 1017
            // (get) Token: 0x06000A27 RID: 2599 RVA: 0x000186EF File Offset: 0x000168EF
            // (set) Token: 0x06000A28 RID: 2600 RVA: 0x000186FC File Offset: 0x000168FC
            public string Message
			{
				get
				{
					return result.Message;
				}
				set
				{
					SetMessage(value);
				}
			}

			// Token: 0x06000A29 RID: 2601 RVA: 0x00018706 File Offset: 0x00016906
			public Builder SetMessage(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasMessage = true;
				result.message_ = value;
				return this;
			}

			// Token: 0x06000A2A RID: 2602 RVA: 0x00018733 File Offset: 0x00016933
			public Builder ClearMessage()
			{
				PrepareBuilder();
				result.HasMessage = false;
				result.message_ = "";
				return this;
			}

            // Token: 0x170003FA RID: 1018
            // (get) Token: 0x06000A2B RID: 2603 RVA: 0x00018759 File Offset: 0x00016959
            public bool HasActionKey => result.HasActionKey;

            // Token: 0x170003FB RID: 1019
            // (get) Token: 0x06000A2C RID: 2604 RVA: 0x00018766 File Offset: 0x00016966
            // (set) Token: 0x06000A2D RID: 2605 RVA: 0x00018773 File Offset: 0x00016973
            public string ActionKey
			{
				get
				{
					return result.ActionKey;
				}
				set
				{
					SetActionKey(value);
				}
			}

			// Token: 0x06000A2E RID: 2606 RVA: 0x0001877D File Offset: 0x0001697D
			public Builder SetActionKey(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasActionKey = true;
				result.actionKey_ = value;
				return this;
			}

			// Token: 0x06000A2F RID: 2607 RVA: 0x000187AA File Offset: 0x000169AA
			public Builder ClearActionKey()
			{
				PrepareBuilder();
				result.HasActionKey = false;
				result.actionKey_ = "";
				return this;
			}

            // Token: 0x170003FC RID: 1020
            // (get) Token: 0x06000A30 RID: 2608 RVA: 0x000187D0 File Offset: 0x000169D0
            public bool HasSound => result.HasSound;

            // Token: 0x170003FD RID: 1021
            // (get) Token: 0x06000A31 RID: 2609 RVA: 0x000187DD File Offset: 0x000169DD
            // (set) Token: 0x06000A32 RID: 2610 RVA: 0x000187EA File Offset: 0x000169EA
            public string Sound
			{
				get
				{
					return result.Sound;
				}
				set
				{
					SetSound(value);
				}
			}

			// Token: 0x06000A33 RID: 2611 RVA: 0x000187F4 File Offset: 0x000169F4
			public Builder SetSound(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasSound = true;
				result.sound_ = value;
				return this;
			}

			// Token: 0x06000A34 RID: 2612 RVA: 0x00018821 File Offset: 0x00016A21
			public Builder ClearSound()
			{
				PrepareBuilder();
				result.HasSound = false;
				result.sound_ = "";
				return this;
			}

            // Token: 0x170003FE RID: 1022
            // (get) Token: 0x06000A35 RID: 2613 RVA: 0x00018847 File Offset: 0x00016A47
            public bool HasBadge => result.HasBadge;

            // Token: 0x170003FF RID: 1023
            // (get) Token: 0x06000A36 RID: 2614 RVA: 0x00018854 File Offset: 0x00016A54
            // (set) Token: 0x06000A37 RID: 2615 RVA: 0x00018861 File Offset: 0x00016A61
            public string Badge
			{
				get
				{
					return result.Badge;
				}
				set
				{
					SetBadge(value);
				}
			}

			// Token: 0x06000A38 RID: 2616 RVA: 0x0001886B File Offset: 0x00016A6B
			public Builder SetBadge(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasBadge = true;
				result.badge_ = value;
				return this;
			}

			// Token: 0x06000A39 RID: 2617 RVA: 0x00018898 File Offset: 0x00016A98
			public Builder ClearBadge()
			{
				PrepareBuilder();
				result.HasBadge = false;
				result.badge_ = "";
				return this;
			}

            // Token: 0x17000400 RID: 1024
            // (get) Token: 0x06000A3A RID: 2618 RVA: 0x000188BE File Offset: 0x00016ABE
            public bool HasPayload => result.HasPayload;

            // Token: 0x17000401 RID: 1025
            // (get) Token: 0x06000A3B RID: 2619 RVA: 0x000188CB File Offset: 0x00016ACB
            // (set) Token: 0x06000A3C RID: 2620 RVA: 0x000188D8 File Offset: 0x00016AD8
            public string Payload
			{
				get
				{
					return result.Payload;
				}
				set
				{
					SetPayload(value);
				}
			}

			// Token: 0x06000A3D RID: 2621 RVA: 0x000188E2 File Offset: 0x00016AE2
			public Builder SetPayload(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasPayload = true;
				result.payload_ = value;
				return this;
			}

			// Token: 0x06000A3E RID: 2622 RVA: 0x0001890F File Offset: 0x00016B0F
			public Builder ClearPayload()
			{
				PrepareBuilder();
				result.HasPayload = false;
				result.payload_ = "";
				return this;
			}

            // Token: 0x17000402 RID: 1026
            // (get) Token: 0x06000A3F RID: 2623 RVA: 0x00018935 File Offset: 0x00016B35
            public bool HasLocKey => result.HasLocKey;

            // Token: 0x17000403 RID: 1027
            // (get) Token: 0x06000A40 RID: 2624 RVA: 0x00018942 File Offset: 0x00016B42
            // (set) Token: 0x06000A41 RID: 2625 RVA: 0x0001894F File Offset: 0x00016B4F
            public string LocKey
			{
				get
				{
					return result.LocKey;
				}
				set
				{
					SetLocKey(value);
				}
			}

			// Token: 0x06000A42 RID: 2626 RVA: 0x00018959 File Offset: 0x00016B59
			public Builder SetLocKey(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasLocKey = true;
				result.locKey_ = value;
				return this;
			}

			// Token: 0x06000A43 RID: 2627 RVA: 0x00018986 File Offset: 0x00016B86
			public Builder ClearLocKey()
			{
				PrepareBuilder();
				result.HasLocKey = false;
				result.locKey_ = "";
				return this;
			}

            // Token: 0x17000404 RID: 1028
            // (get) Token: 0x06000A44 RID: 2628 RVA: 0x000189AC File Offset: 0x00016BAC
            public bool HasLocArgs => result.HasLocArgs;

            // Token: 0x17000405 RID: 1029
            // (get) Token: 0x06000A45 RID: 2629 RVA: 0x000189B9 File Offset: 0x00016BB9
            // (set) Token: 0x06000A46 RID: 2630 RVA: 0x000189C6 File Offset: 0x00016BC6
            public string LocArgs
			{
				get
				{
					return result.LocArgs;
				}
				set
				{
					SetLocArgs(value);
				}
			}

			// Token: 0x06000A47 RID: 2631 RVA: 0x000189D0 File Offset: 0x00016BD0
			public Builder SetLocArgs(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasLocArgs = true;
				result.locArgs_ = value;
				return this;
			}

			// Token: 0x06000A48 RID: 2632 RVA: 0x000189FD File Offset: 0x00016BFD
			public Builder ClearLocArgs()
			{
				PrepareBuilder();
				result.HasLocArgs = false;
				result.locArgs_ = "";
				return this;
			}

            // Token: 0x17000406 RID: 1030
            // (get) Token: 0x06000A49 RID: 2633 RVA: 0x00018A23 File Offset: 0x00016C23
            public bool HasActionLocKey => result.HasActionLocKey;

            // Token: 0x17000407 RID: 1031
            // (get) Token: 0x06000A4A RID: 2634 RVA: 0x00018A30 File Offset: 0x00016C30
            // (set) Token: 0x06000A4B RID: 2635 RVA: 0x00018A3D File Offset: 0x00016C3D
            public string ActionLocKey
			{
				get
				{
					return result.ActionLocKey;
				}
				set
				{
					SetActionLocKey(value);
				}
			}

			// Token: 0x06000A4C RID: 2636 RVA: 0x00018A47 File Offset: 0x00016C47
			public Builder SetActionLocKey(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasActionLocKey = true;
				result.actionLocKey_ = value;
				return this;
			}

			// Token: 0x06000A4D RID: 2637 RVA: 0x00018A74 File Offset: 0x00016C74
			public Builder ClearActionLocKey()
			{
				PrepareBuilder();
				result.HasActionLocKey = false;
				result.actionLocKey_ = "";
				return this;
			}

            // Token: 0x17000408 RID: 1032
            // (get) Token: 0x06000A4E RID: 2638 RVA: 0x00018A9A File Offset: 0x00016C9A
            public bool HasLaunchImage => result.HasLaunchImage;

            // Token: 0x17000409 RID: 1033
            // (get) Token: 0x06000A4F RID: 2639 RVA: 0x00018AA7 File Offset: 0x00016CA7
            // (set) Token: 0x06000A50 RID: 2640 RVA: 0x00018AB4 File Offset: 0x00016CB4
            public string LaunchImage
			{
				get
				{
					return result.LaunchImage;
				}
				set
				{
					SetLaunchImage(value);
				}
			}

			// Token: 0x06000A51 RID: 2641 RVA: 0x00018ABE File Offset: 0x00016CBE
			public Builder SetLaunchImage(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasLaunchImage = true;
				result.launchImage_ = value;
				return this;
			}

			// Token: 0x06000A52 RID: 2642 RVA: 0x00018AEB File Offset: 0x00016CEB
			public Builder ClearLaunchImage()
			{
				PrepareBuilder();
				result.HasLaunchImage = false;
				result.launchImage_ = "";
				return this;
			}

            // Token: 0x1700040A RID: 1034
            // (get) Token: 0x06000A53 RID: 2643 RVA: 0x00018B11 File Offset: 0x00016D11
            public bool HasContentAvailable => result.HasContentAvailable;

            // Token: 0x1700040B RID: 1035
            // (get) Token: 0x06000A54 RID: 2644 RVA: 0x00018B1E File Offset: 0x00016D1E
            // (set) Token: 0x06000A55 RID: 2645 RVA: 0x00018B2B File Offset: 0x00016D2B
            public int ContentAvailable
			{
				get
				{
					return result.ContentAvailable;
				}
				set
				{
					SetContentAvailable(value);
				}
			}

			// Token: 0x06000A56 RID: 2646 RVA: 0x00018B35 File Offset: 0x00016D35
			public Builder SetContentAvailable(int value)
			{
				PrepareBuilder();
				result.HasContentAvailable = true;
				result.contentAvailable_ = value;
				return this;
			}

			// Token: 0x06000A57 RID: 2647 RVA: 0x00018B57 File Offset: 0x00016D57
			public Builder ClearContentAvailable()
			{
				PrepareBuilder();
				result.HasContentAvailable = false;
				result.contentAvailable_ = 0;
				return this;
			}

            // Token: 0x1700040C RID: 1036
            // (get) Token: 0x06000A58 RID: 2648 RVA: 0x00018B79 File Offset: 0x00016D79
            public bool HasInvalidAPN => result.HasInvalidAPN;

            // Token: 0x1700040D RID: 1037
            // (get) Token: 0x06000A59 RID: 2649 RVA: 0x00018B86 File Offset: 0x00016D86
            // (set) Token: 0x06000A5A RID: 2650 RVA: 0x00018B93 File Offset: 0x00016D93
            public bool InvalidAPN
			{
				get
				{
					return result.InvalidAPN;
				}
				set
				{
					SetInvalidAPN(value);
				}
			}

			// Token: 0x06000A5B RID: 2651 RVA: 0x00018B9D File Offset: 0x00016D9D
			public Builder SetInvalidAPN(bool value)
			{
				PrepareBuilder();
				result.HasInvalidAPN = true;
				result.invalidAPN_ = value;
				return this;
			}

			// Token: 0x06000A5C RID: 2652 RVA: 0x00018BBF File Offset: 0x00016DBF
			public Builder ClearInvalidAPN()
			{
				PrepareBuilder();
				result.HasInvalidAPN = false;
				result.invalidAPN_ = false;
				return this;
			}

            // Token: 0x1700040E RID: 1038
            // (get) Token: 0x06000A5D RID: 2653 RVA: 0x00018BE1 File Offset: 0x00016DE1
            public bool HasApnJson => result.HasApnJson;

            // Token: 0x1700040F RID: 1039
            // (get) Token: 0x06000A5E RID: 2654 RVA: 0x00018BEE File Offset: 0x00016DEE
            // (set) Token: 0x06000A5F RID: 2655 RVA: 0x00018BFB File Offset: 0x00016DFB
            public string ApnJson
			{
				get
				{
					return result.ApnJson;
				}
				set
				{
					SetApnJson(value);
				}
			}

			// Token: 0x06000A60 RID: 2656 RVA: 0x00018C05 File Offset: 0x00016E05
			public Builder SetApnJson(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasApnJson = true;
				result.apnJson_ = value;
				return this;
			}

			// Token: 0x06000A61 RID: 2657 RVA: 0x00018C32 File Offset: 0x00016E32
			public Builder ClearApnJson()
			{
				PrepareBuilder();
				result.HasApnJson = false;
				result.apnJson_ = "";
				return this;
			}

            // Token: 0x17000410 RID: 1040
            // (get) Token: 0x06000A62 RID: 2658 RVA: 0x00018C58 File Offset: 0x00016E58
            public bool HasInvalidMPN => result.HasInvalidMPN;

            // Token: 0x17000411 RID: 1041
            // (get) Token: 0x06000A63 RID: 2659 RVA: 0x00018C65 File Offset: 0x00016E65
            // (set) Token: 0x06000A64 RID: 2660 RVA: 0x00018C72 File Offset: 0x00016E72
            public bool InvalidMPN
			{
				get
				{
					return result.InvalidMPN;
				}
				set
				{
					SetInvalidMPN(value);
				}
			}

			// Token: 0x06000A65 RID: 2661 RVA: 0x00018C7C File Offset: 0x00016E7C
			public Builder SetInvalidMPN(bool value)
			{
				PrepareBuilder();
				result.HasInvalidMPN = true;
				result.invalidMPN_ = value;
				return this;
			}

			// Token: 0x06000A66 RID: 2662 RVA: 0x00018C9E File Offset: 0x00016E9E
			public Builder ClearInvalidMPN()
			{
				PrepareBuilder();
				result.HasInvalidMPN = false;
				result.invalidMPN_ = false;
				return this;
			}

            // Token: 0x17000412 RID: 1042
            // (get) Token: 0x06000A67 RID: 2663 RVA: 0x00018CC0 File Offset: 0x00016EC0
            public bool HasMpnXml => result.HasMpnXml;

            // Token: 0x17000413 RID: 1043
            // (get) Token: 0x06000A68 RID: 2664 RVA: 0x00018CCD File Offset: 0x00016ECD
            // (set) Token: 0x06000A69 RID: 2665 RVA: 0x00018CDA File Offset: 0x00016EDA
            public string MpnXml
			{
				get
				{
					return result.MpnXml;
				}
				set
				{
					SetMpnXml(value);
				}
			}

			// Token: 0x06000A6A RID: 2666 RVA: 0x00018CE4 File Offset: 0x00016EE4
			public Builder SetMpnXml(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasMpnXml = true;
				result.mpnXml_ = value;
				return this;
			}

			// Token: 0x06000A6B RID: 2667 RVA: 0x00018D11 File Offset: 0x00016F11
			public Builder ClearMpnXml()
			{
				PrepareBuilder();
				result.HasMpnXml = false;
				result.mpnXml_ = "";
				return this;
			}

            // Token: 0x17000414 RID: 1044
            // (get) Token: 0x06000A6C RID: 2668 RVA: 0x00018D37 File Offset: 0x00016F37
            public bool HasValidNotify => result.HasValidNotify;

            // Token: 0x17000415 RID: 1045
            // (get) Token: 0x06000A6D RID: 2669 RVA: 0x00018D44 File Offset: 0x00016F44
            // (set) Token: 0x06000A6E RID: 2670 RVA: 0x00018D51 File Offset: 0x00016F51
            public bool ValidNotify
			{
				get
				{
					return result.ValidNotify;
				}
				set
				{
					SetValidNotify(value);
				}
			}

			// Token: 0x06000A6F RID: 2671 RVA: 0x00018D5B File Offset: 0x00016F5B
			public Builder SetValidNotify(bool value)
			{
				PrepareBuilder();
				result.HasValidNotify = true;
				result.validNotify_ = value;
				return this;
			}

			// Token: 0x06000A70 RID: 2672 RVA: 0x00018D7D File Offset: 0x00016F7D
			public Builder ClearValidNotify()
			{
				PrepareBuilder();
				result.HasValidNotify = false;
				result.validNotify_ = false;
				return this;
			}

            // Token: 0x17000416 RID: 1046
            // (get) Token: 0x06000A71 RID: 2673 RVA: 0x00018D9F File Offset: 0x00016F9F
            public bool HasNotifyInfo => result.HasNotifyInfo;

            // Token: 0x17000417 RID: 1047
            // (get) Token: 0x06000A72 RID: 2674 RVA: 0x00018DAC File Offset: 0x00016FAC
            // (set) Token: 0x06000A73 RID: 2675 RVA: 0x00018DB9 File Offset: 0x00016FB9
            public NotifyInfo NotifyInfo
			{
				get
				{
					return result.NotifyInfo;
				}
				set
				{
					SetNotifyInfo(value);
				}
			}

			// Token: 0x06000A74 RID: 2676 RVA: 0x00018DC3 File Offset: 0x00016FC3
			public Builder SetNotifyInfo(NotifyInfo value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasNotifyInfo = true;
				result.notifyInfo_ = value;
				return this;
			}

			// Token: 0x06000A75 RID: 2677 RVA: 0x00018DF0 File Offset: 0x00016FF0
			public Builder SetNotifyInfo(NotifyInfo.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.HasNotifyInfo = true;
				result.notifyInfo_ = builderForValue.Build();
				return this;
			}

			// Token: 0x06000A76 RID: 2678 RVA: 0x00018E24 File Offset: 0x00017024
			public Builder MergeNotifyInfo(NotifyInfo value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				if (result.HasNotifyInfo && result.notifyInfo_ != NotifyInfo.DefaultInstance)
				{
					result.notifyInfo_ = NotifyInfo.CreateBuilder(result.notifyInfo_).MergeFrom(value).BuildPartial();
				}
				else
				{
					result.notifyInfo_ = value;
				}
				result.HasNotifyInfo = true;
				return this;
			}

			// Token: 0x06000A77 RID: 2679 RVA: 0x00018EA3 File Offset: 0x000170A3
			public Builder ClearNotifyInfo()
			{
				PrepareBuilder();
				result.HasNotifyInfo = false;
				result.notifyInfo_ = null;
				return this;
			}

			// Token: 0x040003E3 RID: 995
			private bool resultIsReadOnly;

			// Token: 0x040003E4 RID: 996
			private PushInfo result;
		}
	}
}
