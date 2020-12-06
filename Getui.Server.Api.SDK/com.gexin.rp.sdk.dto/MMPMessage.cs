using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    // Token: 0x0200001C RID: 28
    [DebuggerNonUserCode]
	public sealed class MMPMessage : GeneratedMessage<MMPMessage, MMPMessage.Builder>
	{
		// Token: 0x060002B9 RID: 697 RVA: 0x00006133 File Offset: 0x00004333
		private MMPMessage()
		{
		}

        // Token: 0x1700012B RID: 299
        // (get) Token: 0x060002BA RID: 698 RVA: 0x00006166 File Offset: 0x00004366
        public static MMPMessage DefaultInstance { get; } = new MMPMessage().MakeReadOnly();

        // Token: 0x1700012C RID: 300
        // (get) Token: 0x060002BB RID: 699 RVA: 0x0000616D File Offset: 0x0000436D
        public override MMPMessage DefaultInstanceForType => DefaultInstance;

        // Token: 0x1700012D RID: 301
        // (get) Token: 0x060002BC RID: 700 RVA: 0x00006174 File Offset: 0x00004374
        protected override MMPMessage ThisMessage => this;

        // Token: 0x1700012E RID: 302
        // (get) Token: 0x060002BD RID: 701 RVA: 0x00006177 File Offset: 0x00004377
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_MMPMessage__Descriptor;

        // Token: 0x1700012F RID: 303
        // (get) Token: 0x060002BE RID: 702 RVA: 0x0000617E File Offset: 0x0000437E
        protected override FieldAccessorTable<MMPMessage, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_MMPMessage__FieldAccessorTable;

        // Token: 0x17000130 RID: 304
        // (get) Token: 0x060002BF RID: 703 RVA: 0x00006185 File Offset: 0x00004385
        public bool HasTransparent { get; private set; }

        // Token: 0x17000131 RID: 305
        // (get) Token: 0x060002C0 RID: 704 RVA: 0x0000618D File Offset: 0x0000438D
        public Transparent Transparent => transparent_ ?? Transparent.DefaultInstance;

        // Token: 0x17000132 RID: 306
        // (get) Token: 0x060002C1 RID: 705 RVA: 0x0000619E File Offset: 0x0000439E
        public bool HasExtraData { get; private set; }

        // Token: 0x17000133 RID: 307
        // (get) Token: 0x060002C2 RID: 706 RVA: 0x000061A6 File Offset: 0x000043A6
        public string ExtraData => extraData_;

        // Token: 0x17000134 RID: 308
        // (get) Token: 0x060002C3 RID: 707 RVA: 0x000061AE File Offset: 0x000043AE
        public bool HasMsgType { get; private set; }

        // Token: 0x17000135 RID: 309
        // (get) Token: 0x060002C4 RID: 708 RVA: 0x000061B6 File Offset: 0x000043B6
        public int MsgType => msgType_;

        // Token: 0x17000136 RID: 310
        // (get) Token: 0x060002C5 RID: 709 RVA: 0x000061BE File Offset: 0x000043BE
        public bool HasMsgTraceFlag { get; private set; }

        // Token: 0x17000137 RID: 311
        // (get) Token: 0x060002C6 RID: 710 RVA: 0x000061C6 File Offset: 0x000043C6
        public int MsgTraceFlag => msgTraceFlag_;

        // Token: 0x17000138 RID: 312
        // (get) Token: 0x060002C7 RID: 711 RVA: 0x000061CE File Offset: 0x000043CE
        public bool HasMsgOfflineExpire { get; private set; }

        // Token: 0x17000139 RID: 313
        // (get) Token: 0x060002C8 RID: 712 RVA: 0x000061D6 File Offset: 0x000043D6
        public long MsgOfflineExpire => msgOfflineExpire_;

        // Token: 0x1700013A RID: 314
        // (get) Token: 0x060002C9 RID: 713 RVA: 0x000061DE File Offset: 0x000043DE
        public bool HasIsOffline { get; private set; }

        // Token: 0x1700013B RID: 315
        // (get) Token: 0x060002CA RID: 714 RVA: 0x000061E6 File Offset: 0x000043E6
        public bool IsOffline => isOffline_;

        // Token: 0x1700013C RID: 316
        // (get) Token: 0x060002CB RID: 715 RVA: 0x000061EE File Offset: 0x000043EE
        public bool HasPriority { get; private set; }

        // Token: 0x1700013D RID: 317
        // (get) Token: 0x060002CC RID: 716 RVA: 0x000061F6 File Offset: 0x000043F6
        public int Priority => priority_;

        // Token: 0x1700013E RID: 318
        // (get) Token: 0x060002CD RID: 717 RVA: 0x000061FE File Offset: 0x000043FE
        public bool HasCdnUrl { get; private set; }

        // Token: 0x1700013F RID: 319
        // (get) Token: 0x060002CE RID: 718 RVA: 0x00006206 File Offset: 0x00004406
        public string CdnUrl => cdnUrl_;

        // Token: 0x17000140 RID: 320
        // (get) Token: 0x060002CF RID: 719 RVA: 0x0000620E File Offset: 0x0000440E
        public bool HasIsSync { get; private set; }

        // Token: 0x17000141 RID: 321
        // (get) Token: 0x060002D0 RID: 720 RVA: 0x00006216 File Offset: 0x00004416
        public bool IsSync => isSync_;

        // Token: 0x17000142 RID: 322
        // (get) Token: 0x060002D1 RID: 721 RVA: 0x0000621E File Offset: 0x0000441E
        public override bool IsInitialized => !HasTransparent || Transparent.IsInitialized;

        // Token: 0x060002D2 RID: 722 RVA: 0x00006238 File Offset: 0x00004438
        public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] mMPMessageFieldNames = _mMPMessageFieldNames;
			if (HasTransparent)
			{
				output.WriteMessage(2, mMPMessageFieldNames[8], Transparent);
			}
			if (HasExtraData)
			{
				output.WriteString(3, mMPMessageFieldNames[1], ExtraData);
			}
			if (HasMsgType)
			{
				output.WriteInt32(4, mMPMessageFieldNames[6], MsgType);
			}
			if (HasMsgTraceFlag)
			{
				output.WriteInt32(5, mMPMessageFieldNames[5], MsgTraceFlag);
			}
			if (HasMsgOfflineExpire)
			{
				output.WriteInt64(6, mMPMessageFieldNames[4], MsgOfflineExpire);
			}
			if (HasIsOffline)
			{
				output.WriteBool(7, mMPMessageFieldNames[2], IsOffline);
			}
			if (HasPriority)
			{
				output.WriteInt32(8, mMPMessageFieldNames[7], Priority);
			}
			if (HasCdnUrl)
			{
				output.WriteString(9, mMPMessageFieldNames[0], CdnUrl);
			}
			if (HasIsSync)
			{
				output.WriteBool(10, mMPMessageFieldNames[3], IsSync);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x00006338 File Offset: 0x00004538
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
				if (HasTransparent)
				{
					num += CodedOutputStream.ComputeMessageSize(2, Transparent);
				}
				if (HasExtraData)
				{
					num += CodedOutputStream.ComputeStringSize(3, ExtraData);
				}
				if (HasMsgType)
				{
					num += CodedOutputStream.ComputeInt32Size(4, MsgType);
				}
				if (HasMsgTraceFlag)
				{
					num += CodedOutputStream.ComputeInt32Size(5, MsgTraceFlag);
				}
				if (HasMsgOfflineExpire)
				{
					num += CodedOutputStream.ComputeInt64Size(6, MsgOfflineExpire);
				}
				if (HasIsOffline)
				{
					num += CodedOutputStream.ComputeBoolSize(7, IsOffline);
				}
				if (HasPriority)
				{
					num += CodedOutputStream.ComputeInt32Size(8, Priority);
				}
				if (HasCdnUrl)
				{
					num += CodedOutputStream.ComputeStringSize(9, CdnUrl);
				}
				if (HasIsSync)
				{
					num += CodedOutputStream.ComputeBoolSize(10, IsSync);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000643B File Offset: 0x0000463B
		public static MMPMessage ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000644D File Offset: 0x0000464D
		public static MMPMessage ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00006460 File Offset: 0x00004660
		public static MMPMessage ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00006472 File Offset: 0x00004672
		public static MMPMessage ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00006485 File Offset: 0x00004685
		public static MMPMessage ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00006497 File Offset: 0x00004697
		public static MMPMessage ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060002DA RID: 730 RVA: 0x000064AA File Offset: 0x000046AA
		public static MMPMessage ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x060002DB RID: 731 RVA: 0x000064BC File Offset: 0x000046BC
		public static MMPMessage ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000064CF File Offset: 0x000046CF
		public static MMPMessage ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x060002DD RID: 733 RVA: 0x000064E1 File Offset: 0x000046E1
		public static MMPMessage ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060002DE RID: 734 RVA: 0x000064F4 File Offset: 0x000046F4
		private MMPMessage MakeReadOnly()
		{
			return this;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x000064F7 File Offset: 0x000046F7
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x000064FE File Offset: 0x000046FE
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00006506 File Offset: 0x00004706
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000650D File Offset: 0x0000470D
		public static Builder CreateBuilder(MMPMessage prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00006518 File Offset: 0x00004718
		static MMPMessage()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x04000184 RID: 388
        private static readonly string[] _mMPMessageFieldNames = new string[]
		{
			"cdnUrl",
			"extraData",
			"isOffline",
			"isSync",
			"msgOfflineExpire",
			"msgTraceFlag",
			"msgType",
			"priority",
			"transparent"
		};

		// Token: 0x04000185 RID: 389
		private static readonly uint[] _mMPMessageFieldTags = new uint[]
		{
			74U,
			26U,
			56U,
			80U,
			48U,
			40U,
			32U,
			64U,
			18U
		};

		// Token: 0x04000186 RID: 390
		public const int TransparentFieldNumber = 2;

        // Token: 0x04000188 RID: 392
        private Transparent transparent_;

		// Token: 0x04000189 RID: 393
		public const int ExtraDataFieldNumber = 3;

        // Token: 0x0400018B RID: 395
        private string extraData_ = "";

		// Token: 0x0400018C RID: 396
		public const int MsgTypeFieldNumber = 4;

        // Token: 0x0400018E RID: 398
        private int msgType_;

		// Token: 0x0400018F RID: 399
		public const int MsgTraceFlagFieldNumber = 5;

        // Token: 0x04000191 RID: 401
        private int msgTraceFlag_;

		// Token: 0x04000192 RID: 402
		public const int MsgOfflineExpireFieldNumber = 6;

        // Token: 0x04000194 RID: 404
        private long msgOfflineExpire_;

		// Token: 0x04000195 RID: 405
		public const int IsOfflineFieldNumber = 7;

        // Token: 0x04000197 RID: 407
        private bool isOffline_ = true;

		// Token: 0x04000198 RID: 408
		public const int PriorityFieldNumber = 8;

        // Token: 0x0400019A RID: 410
        private int priority_;

		// Token: 0x0400019B RID: 411
		public const int CdnUrlFieldNumber = 9;

        // Token: 0x0400019D RID: 413
        private string cdnUrl_ = "";

		// Token: 0x0400019E RID: 414
		public const int IsSyncFieldNumber = 10;

        // Token: 0x040001A0 RID: 416
        private bool isSync_ = true;

		// Token: 0x040001A1 RID: 417
		private int memoizedSerializedSize = -1;

		// Token: 0x02000078 RID: 120
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<MMPMessage, Builder>
		{
            // Token: 0x170003BF RID: 959
            // (get) Token: 0x06000984 RID: 2436 RVA: 0x00016AF0 File Offset: 0x00014CF0
            protected override Builder ThisBuilder => this;

            // Token: 0x06000985 RID: 2437 RVA: 0x00016AF3 File Offset: 0x00014CF3
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x06000986 RID: 2438 RVA: 0x00016B0D File Offset: 0x00014D0D
			internal Builder(MMPMessage cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x06000987 RID: 2439 RVA: 0x00016B24 File Offset: 0x00014D24
			private MMPMessage PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					MMPMessage other = result;
					result = new MMPMessage();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x170003C0 RID: 960
            // (get) Token: 0x06000988 RID: 2440 RVA: 0x00016B60 File Offset: 0x00014D60
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x170003C1 RID: 961
            // (get) Token: 0x06000989 RID: 2441 RVA: 0x00016B6D File Offset: 0x00014D6D
            protected override MMPMessage MessageBeingBuilt => PrepareBuilder();

            // Token: 0x0600098A RID: 2442 RVA: 0x00016B75 File Offset: 0x00014D75
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x0600098B RID: 2443 RVA: 0x00016B8A File Offset: 0x00014D8A
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x170003C2 RID: 962
            // (get) Token: 0x0600098C RID: 2444 RVA: 0x00016BB0 File Offset: 0x00014DB0
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x170003C3 RID: 963
            // (get) Token: 0x0600098D RID: 2445 RVA: 0x00016BB7 File Offset: 0x00014DB7
            public override MMPMessage DefaultInstanceForType => DefaultInstance;

            // Token: 0x0600098E RID: 2446 RVA: 0x00016BBE File Offset: 0x00014DBE
            public override MMPMessage BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x0600098F RID: 2447 RVA: 0x00016BE1 File Offset: 0x00014DE1
			public override Builder MergeFrom(IMessage other)
			{
				if (other is MMPMessage)
				{
					return MergeFrom((MMPMessage)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x06000990 RID: 2448 RVA: 0x00016C04 File Offset: 0x00014E04
			public override Builder MergeFrom(MMPMessage other)
			{
				if (other == DefaultInstance)
				{
					return this;
				}
				PrepareBuilder();
				if (other.HasTransparent)
				{
					MergeTransparent(other.Transparent);
				}
				if (other.HasExtraData)
				{
					ExtraData = other.ExtraData;
				}
				if (other.HasMsgType)
				{
					MsgType = other.MsgType;
				}
				if (other.HasMsgTraceFlag)
				{
					MsgTraceFlag = other.MsgTraceFlag;
				}
				if (other.HasMsgOfflineExpire)
				{
					MsgOfflineExpire = other.MsgOfflineExpire;
				}
				if (other.HasIsOffline)
				{
					IsOffline = other.IsOffline;
				}
				if (other.HasPriority)
				{
					Priority = other.Priority;
				}
				if (other.HasCdnUrl)
				{
					CdnUrl = other.CdnUrl;
				}
				if (other.HasIsSync)
				{
					IsSync = other.IsSync;
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x06000991 RID: 2449 RVA: 0x00016CE5 File Offset: 0x00014EE5
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x06000992 RID: 2450 RVA: 0x00016CF4 File Offset: 0x00014EF4
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_mMPMessageFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _mMPMessageFieldTags[num2];
                    }
                    if (num <= 40U)
                    {
                        if (num <= 18U)
                        {
                            if (num == 0U)
                            {
                                throw InvalidProtocolBufferException.InvalidTag();
                            }
                            if (num == 18U)
                            {
                                Transparent.Builder builder2 = Transparent.CreateBuilder();
                                if (result.HasTransparent)
                                {
                                    builder2.MergeFrom(Transparent);
                                }
                                input.ReadMessage(builder2, extensionRegistry);
                                Transparent = builder2.BuildPartial();
                                continue;
                            }
                        }
                        else
                        {
                            if (num == 26U)
                            {
                                result.HasExtraData = input.ReadString(ref result.extraData_);
                                continue;
                            }
                            if (num == 32U)
                            {
                                result.HasMsgType = input.ReadInt32(ref result.msgType_);
                                continue;
                            }
                            if (num == 40U)
                            {
                                result.HasMsgTraceFlag = input.ReadInt32(ref result.msgTraceFlag_);
                                continue;
                            }
                        }
                    }
                    else if (num <= 56U)
                    {
                        if (num == 48U)
                        {
                            result.HasMsgOfflineExpire = input.ReadInt64(ref result.msgOfflineExpire_);
                            continue;
                        }
                        if (num == 56U)
                        {
                            result.HasIsOffline = input.ReadBool(ref result.isOffline_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 64U)
                        {
                            result.HasPriority = input.ReadInt32(ref result.priority_);
                            continue;
                        }
                        if (num == 74U)
                        {
                            result.HasCdnUrl = input.ReadString(ref result.cdnUrl_);
                            continue;
                        }
                        if (num == 80U)
                        {
                            result.HasIsSync = input.ReadBool(ref result.isSync_);
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

            // Token: 0x170003C4 RID: 964
            // (get) Token: 0x06000993 RID: 2451 RVA: 0x00016F48 File Offset: 0x00015148
            public bool HasTransparent => result.HasTransparent;

            // Token: 0x170003C5 RID: 965
            // (get) Token: 0x06000994 RID: 2452 RVA: 0x00016F55 File Offset: 0x00015155
            // (set) Token: 0x06000995 RID: 2453 RVA: 0x00016F62 File Offset: 0x00015162
            public Transparent Transparent
			{
				get
				{
					return result.Transparent;
				}
				set
				{
					SetTransparent(value);
				}
			}

			// Token: 0x06000996 RID: 2454 RVA: 0x00016F6C File Offset: 0x0001516C
			public Builder SetTransparent(Transparent value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasTransparent = true;
				result.transparent_ = value;
				return this;
			}

			// Token: 0x06000997 RID: 2455 RVA: 0x00016F99 File Offset: 0x00015199
			public Builder SetTransparent(Transparent.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.HasTransparent = true;
				result.transparent_ = builderForValue.Build();
				return this;
			}

			// Token: 0x06000998 RID: 2456 RVA: 0x00016FCC File Offset: 0x000151CC
			public Builder MergeTransparent(Transparent value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				if (result.HasTransparent && result.transparent_ != Transparent.DefaultInstance)
				{
					result.transparent_ = Transparent.CreateBuilder(result.transparent_).MergeFrom(value).BuildPartial();
				}
				else
				{
					result.transparent_ = value;
				}
				result.HasTransparent = true;
				return this;
			}

			// Token: 0x06000999 RID: 2457 RVA: 0x0001704B File Offset: 0x0001524B
			public Builder ClearTransparent()
			{
				PrepareBuilder();
				result.HasTransparent = false;
				result.transparent_ = null;
				return this;
			}

            // Token: 0x170003C6 RID: 966
            // (get) Token: 0x0600099A RID: 2458 RVA: 0x0001706D File Offset: 0x0001526D
            public bool HasExtraData => result.HasExtraData;

            // Token: 0x170003C7 RID: 967
            // (get) Token: 0x0600099B RID: 2459 RVA: 0x0001707A File Offset: 0x0001527A
            // (set) Token: 0x0600099C RID: 2460 RVA: 0x00017087 File Offset: 0x00015287
            public string ExtraData
			{
				get
				{
					return result.ExtraData;
				}
				set
				{
					SetExtraData(value);
				}
			}

			// Token: 0x0600099D RID: 2461 RVA: 0x00017091 File Offset: 0x00015291
			public Builder SetExtraData(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasExtraData = true;
				result.extraData_ = value;
				return this;
			}

			// Token: 0x0600099E RID: 2462 RVA: 0x000170BE File Offset: 0x000152BE
			public Builder ClearExtraData()
			{
				PrepareBuilder();
				result.HasExtraData = false;
				result.extraData_ = "";
				return this;
			}

            // Token: 0x170003C8 RID: 968
            // (get) Token: 0x0600099F RID: 2463 RVA: 0x000170E4 File Offset: 0x000152E4
            public bool HasMsgType => result.HasMsgType;

            // Token: 0x170003C9 RID: 969
            // (get) Token: 0x060009A0 RID: 2464 RVA: 0x000170F1 File Offset: 0x000152F1
            // (set) Token: 0x060009A1 RID: 2465 RVA: 0x000170FE File Offset: 0x000152FE
            public int MsgType
			{
				get
				{
					return result.MsgType;
				}
				set
				{
					SetMsgType(value);
				}
			}

			// Token: 0x060009A2 RID: 2466 RVA: 0x00017108 File Offset: 0x00015308
			public Builder SetMsgType(int value)
			{
				PrepareBuilder();
				result.HasMsgType = true;
				result.msgType_ = value;
				return this;
			}

			// Token: 0x060009A3 RID: 2467 RVA: 0x0001712A File Offset: 0x0001532A
			public Builder ClearMsgType()
			{
				PrepareBuilder();
				result.HasMsgType = false;
				result.msgType_ = 0;
				return this;
			}

            // Token: 0x170003CA RID: 970
            // (get) Token: 0x060009A4 RID: 2468 RVA: 0x0001714C File Offset: 0x0001534C
            public bool HasMsgTraceFlag => result.HasMsgTraceFlag;

            // Token: 0x170003CB RID: 971
            // (get) Token: 0x060009A5 RID: 2469 RVA: 0x00017159 File Offset: 0x00015359
            // (set) Token: 0x060009A6 RID: 2470 RVA: 0x00017166 File Offset: 0x00015366
            public int MsgTraceFlag
			{
				get
				{
					return result.MsgTraceFlag;
				}
				set
				{
					SetMsgTraceFlag(value);
				}
			}

			// Token: 0x060009A7 RID: 2471 RVA: 0x00017170 File Offset: 0x00015370
			public Builder SetMsgTraceFlag(int value)
			{
				PrepareBuilder();
				result.HasMsgTraceFlag = true;
				result.msgTraceFlag_ = value;
				return this;
			}

			// Token: 0x060009A8 RID: 2472 RVA: 0x00017192 File Offset: 0x00015392
			public Builder ClearMsgTraceFlag()
			{
				PrepareBuilder();
				result.HasMsgTraceFlag = false;
				result.msgTraceFlag_ = 0;
				return this;
			}

            // Token: 0x170003CC RID: 972
            // (get) Token: 0x060009A9 RID: 2473 RVA: 0x000171B4 File Offset: 0x000153B4
            public bool HasMsgOfflineExpire => result.HasMsgOfflineExpire;

            // Token: 0x170003CD RID: 973
            // (get) Token: 0x060009AA RID: 2474 RVA: 0x000171C1 File Offset: 0x000153C1
            // (set) Token: 0x060009AB RID: 2475 RVA: 0x000171CE File Offset: 0x000153CE
            public long MsgOfflineExpire
			{
				get
				{
					return result.MsgOfflineExpire;
				}
				set
				{
					SetMsgOfflineExpire(value);
				}
			}

			// Token: 0x060009AC RID: 2476 RVA: 0x000171D8 File Offset: 0x000153D8
			public Builder SetMsgOfflineExpire(long value)
			{
				PrepareBuilder();
				result.HasMsgOfflineExpire = true;
				result.msgOfflineExpire_ = value;
				return this;
			}

			// Token: 0x060009AD RID: 2477 RVA: 0x000171FA File Offset: 0x000153FA
			public Builder ClearMsgOfflineExpire()
			{
				PrepareBuilder();
				result.HasMsgOfflineExpire = false;
				result.msgOfflineExpire_ = 0L;
				return this;
			}

            // Token: 0x170003CE RID: 974
            // (get) Token: 0x060009AE RID: 2478 RVA: 0x0001721D File Offset: 0x0001541D
            public bool HasIsOffline => result.HasIsOffline;

            // Token: 0x170003CF RID: 975
            // (get) Token: 0x060009AF RID: 2479 RVA: 0x0001722A File Offset: 0x0001542A
            // (set) Token: 0x060009B0 RID: 2480 RVA: 0x00017237 File Offset: 0x00015437
            public bool IsOffline
			{
				get
				{
					return result.IsOffline;
				}
				set
				{
					SetIsOffline(value);
				}
			}

			// Token: 0x060009B1 RID: 2481 RVA: 0x00017241 File Offset: 0x00015441
			public Builder SetIsOffline(bool value)
			{
				PrepareBuilder();
				result.HasIsOffline = true;
				result.isOffline_ = value;
				return this;
			}

			// Token: 0x060009B2 RID: 2482 RVA: 0x00017263 File Offset: 0x00015463
			public Builder ClearIsOffline()
			{
				PrepareBuilder();
				result.HasIsOffline = false;
				result.isOffline_ = true;
				return this;
			}

            // Token: 0x170003D0 RID: 976
            // (get) Token: 0x060009B3 RID: 2483 RVA: 0x00017285 File Offset: 0x00015485
            public bool HasPriority => result.HasPriority;

            // Token: 0x170003D1 RID: 977
            // (get) Token: 0x060009B4 RID: 2484 RVA: 0x00017292 File Offset: 0x00015492
            // (set) Token: 0x060009B5 RID: 2485 RVA: 0x0001729F File Offset: 0x0001549F
            public int Priority
			{
				get
				{
					return result.Priority;
				}
				set
				{
					SetPriority(value);
				}
			}

			// Token: 0x060009B6 RID: 2486 RVA: 0x000172A9 File Offset: 0x000154A9
			public Builder SetPriority(int value)
			{
				PrepareBuilder();
				result.HasPriority = true;
				result.priority_ = value;
				return this;
			}

			// Token: 0x060009B7 RID: 2487 RVA: 0x000172CB File Offset: 0x000154CB
			public Builder ClearPriority()
			{
				PrepareBuilder();
				result.HasPriority = false;
				result.priority_ = 0;
				return this;
			}

            // Token: 0x170003D2 RID: 978
            // (get) Token: 0x060009B8 RID: 2488 RVA: 0x000172ED File Offset: 0x000154ED
            public bool HasCdnUrl => result.HasCdnUrl;

            // Token: 0x170003D3 RID: 979
            // (get) Token: 0x060009B9 RID: 2489 RVA: 0x000172FA File Offset: 0x000154FA
            // (set) Token: 0x060009BA RID: 2490 RVA: 0x00017307 File Offset: 0x00015507
            public string CdnUrl
			{
				get
				{
					return result.CdnUrl;
				}
				set
				{
					SetCdnUrl(value);
				}
			}

			// Token: 0x060009BB RID: 2491 RVA: 0x00017311 File Offset: 0x00015511
			public Builder SetCdnUrl(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasCdnUrl = true;
				result.cdnUrl_ = value;
				return this;
			}

			// Token: 0x060009BC RID: 2492 RVA: 0x0001733E File Offset: 0x0001553E
			public Builder ClearCdnUrl()
			{
				PrepareBuilder();
				result.HasCdnUrl = false;
				result.cdnUrl_ = "";
				return this;
			}

            // Token: 0x170003D4 RID: 980
            // (get) Token: 0x060009BD RID: 2493 RVA: 0x00017364 File Offset: 0x00015564
            public bool HasIsSync => result.HasIsSync;

            // Token: 0x170003D5 RID: 981
            // (get) Token: 0x060009BE RID: 2494 RVA: 0x00017371 File Offset: 0x00015571
            // (set) Token: 0x060009BF RID: 2495 RVA: 0x0001737E File Offset: 0x0001557E
            public bool IsSync
			{
				get
				{
					return result.IsSync;
				}
				set
				{
					SetIsSync(value);
				}
			}

			// Token: 0x060009C0 RID: 2496 RVA: 0x00017388 File Offset: 0x00015588
			public Builder SetIsSync(bool value)
			{
				PrepareBuilder();
				result.HasIsSync = true;
				result.isSync_ = value;
				return this;
			}

			// Token: 0x060009C1 RID: 2497 RVA: 0x000173AA File Offset: 0x000155AA
			public Builder ClearIsSync()
			{
				PrepareBuilder();
				result.HasIsSync = false;
				result.isSync_ = true;
				return this;
			}

			// Token: 0x040003DF RID: 991
			private bool resultIsReadOnly;

			// Token: 0x040003E0 RID: 992
			private MMPMessage result;
		}
	}
}
