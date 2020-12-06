using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    // Token: 0x0200001B RID: 27
    [DebuggerNonUserCode]
	public sealed class OSMessage : GeneratedMessage<OSMessage, OSMessage.Builder>
	{
		// Token: 0x06000292 RID: 658 RVA: 0x00005D4E File Offset: 0x00003F4E
		private OSMessage()
		{
		}

        // Token: 0x17000116 RID: 278
        // (get) Token: 0x06000293 RID: 659 RVA: 0x00005D70 File Offset: 0x00003F70
        public static OSMessage DefaultInstance { get; } = new OSMessage().MakeReadOnly();

        // Token: 0x17000117 RID: 279
        // (get) Token: 0x06000294 RID: 660 RVA: 0x00005D77 File Offset: 0x00003F77
        public override OSMessage DefaultInstanceForType => DefaultInstance;

        // Token: 0x17000118 RID: 280
        // (get) Token: 0x06000295 RID: 661 RVA: 0x00005D7E File Offset: 0x00003F7E
        protected override OSMessage ThisMessage => this;

        // Token: 0x17000119 RID: 281
        // (get) Token: 0x06000296 RID: 662 RVA: 0x00005D81 File Offset: 0x00003F81
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_OSMessage__Descriptor;

        // Token: 0x1700011A RID: 282
        // (get) Token: 0x06000297 RID: 663 RVA: 0x00005D88 File Offset: 0x00003F88
        protected override FieldAccessorTable<OSMessage, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_OSMessage__FieldAccessorTable;

        // Token: 0x1700011B RID: 283
        // (get) Token: 0x06000298 RID: 664 RVA: 0x00005D8F File Offset: 0x00003F8F
        public bool HasIsOffline { get; private set; }

        // Token: 0x1700011C RID: 284
        // (get) Token: 0x06000299 RID: 665 RVA: 0x00005D97 File Offset: 0x00003F97
        public bool IsOffline => isOffline_;

        // Token: 0x1700011D RID: 285
        // (get) Token: 0x0600029A RID: 666 RVA: 0x00005D9F File Offset: 0x00003F9F
        public bool HasOfflineExpireTime { get; private set; }

        // Token: 0x1700011E RID: 286
        // (get) Token: 0x0600029B RID: 667 RVA: 0x00005DA7 File Offset: 0x00003FA7
        public long OfflineExpireTime => offlineExpireTime_;

        // Token: 0x1700011F RID: 287
        // (get) Token: 0x0600029C RID: 668 RVA: 0x00005DAF File Offset: 0x00003FAF
        public bool HasTransparent { get; private set; }

        // Token: 0x17000120 RID: 288
        // (get) Token: 0x0600029D RID: 669 RVA: 0x00005DB7 File Offset: 0x00003FB7
        public Transparent Transparent => transparent_ ?? Transparent.DefaultInstance;

        // Token: 0x17000121 RID: 289
        // (get) Token: 0x0600029E RID: 670 RVA: 0x00005DC8 File Offset: 0x00003FC8
        public bool HasExtraData { get; private set; }

        // Token: 0x17000122 RID: 290
        // (get) Token: 0x0600029F RID: 671 RVA: 0x00005DD0 File Offset: 0x00003FD0
        public string ExtraData => extraData_;

        // Token: 0x17000123 RID: 291
        // (get) Token: 0x060002A0 RID: 672 RVA: 0x00005DD8 File Offset: 0x00003FD8
        public bool HasMsgType { get; private set; }

        // Token: 0x17000124 RID: 292
        // (get) Token: 0x060002A1 RID: 673 RVA: 0x00005DE0 File Offset: 0x00003FE0
        public int MsgType => msgType_;

        // Token: 0x17000125 RID: 293
        // (get) Token: 0x060002A2 RID: 674 RVA: 0x00005DE8 File Offset: 0x00003FE8
        public bool HasMsgTraceFlag { get; private set; }

        // Token: 0x17000126 RID: 294
        // (get) Token: 0x060002A3 RID: 675 RVA: 0x00005DF0 File Offset: 0x00003FF0
        public int MsgTraceFlag => msgTraceFlag_;

        // Token: 0x17000127 RID: 295
        // (get) Token: 0x060002A4 RID: 676 RVA: 0x00005DF8 File Offset: 0x00003FF8
        public bool HasPriority { get; private set; }

        // Token: 0x17000128 RID: 296
        // (get) Token: 0x060002A5 RID: 677 RVA: 0x00005E00 File Offset: 0x00004000
        public int Priority => priority_;

        // Token: 0x17000129 RID: 297
        // (get) Token: 0x060002A6 RID: 678 RVA: 0x00005E08 File Offset: 0x00004008
        public override bool IsInitialized => HasIsOffline && HasOfflineExpireTime && (!HasTransparent || Transparent.IsInitialized);

        // Token: 0x060002A7 RID: 679 RVA: 0x00005E38 File Offset: 0x00004038
        public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] oSMessageFieldNames = _oSMessageFieldNames;
			if (HasIsOffline)
			{
				output.WriteBool(2, oSMessageFieldNames[1], IsOffline);
			}
			if (HasOfflineExpireTime)
			{
				output.WriteInt64(3, oSMessageFieldNames[4], OfflineExpireTime);
			}
			if (HasTransparent)
			{
				output.WriteMessage(4, oSMessageFieldNames[6], Transparent);
			}
			if (HasExtraData)
			{
				output.WriteString(5, oSMessageFieldNames[0], ExtraData);
			}
			if (HasMsgType)
			{
				output.WriteInt32(6, oSMessageFieldNames[3], MsgType);
			}
			if (HasMsgTraceFlag)
			{
				output.WriteInt32(7, oSMessageFieldNames[2], MsgTraceFlag);
			}
			if (HasPriority)
			{
				output.WriteInt32(8, oSMessageFieldNames[5], Priority);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x00005F08 File Offset: 0x00004108
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
				if (HasIsOffline)
				{
					num += CodedOutputStream.ComputeBoolSize(2, IsOffline);
				}
				if (HasOfflineExpireTime)
				{
					num += CodedOutputStream.ComputeInt64Size(3, OfflineExpireTime);
				}
				if (HasTransparent)
				{
					num += CodedOutputStream.ComputeMessageSize(4, Transparent);
				}
				if (HasExtraData)
				{
					num += CodedOutputStream.ComputeStringSize(5, ExtraData);
				}
				if (HasMsgType)
				{
					num += CodedOutputStream.ComputeInt32Size(6, MsgType);
				}
				if (HasMsgTraceFlag)
				{
					num += CodedOutputStream.ComputeInt32Size(7, MsgTraceFlag);
				}
				if (HasPriority)
				{
					num += CodedOutputStream.ComputeInt32Size(8, Priority);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00005FDB File Offset: 0x000041DB
		public static OSMessage ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00005FED File Offset: 0x000041ED
		public static OSMessage ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00006000 File Offset: 0x00004200
		public static OSMessage ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00006012 File Offset: 0x00004212
		public static OSMessage ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00006025 File Offset: 0x00004225
		public static OSMessage ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00006037 File Offset: 0x00004237
		public static OSMessage ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000604A File Offset: 0x0000424A
		public static OSMessage ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000605C File Offset: 0x0000425C
		public static OSMessage ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000606F File Offset: 0x0000426F
		public static OSMessage ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00006081 File Offset: 0x00004281
		public static OSMessage ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00006094 File Offset: 0x00004294
		private OSMessage MakeReadOnly()
		{
			return this;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00006097 File Offset: 0x00004297
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000609E File Offset: 0x0000429E
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x000060A6 File Offset: 0x000042A6
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000060AD File Offset: 0x000042AD
		public static Builder CreateBuilder(OSMessage prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x000060B8 File Offset: 0x000042B8
		static OSMessage()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x0400016B RID: 363
        private static readonly string[] _oSMessageFieldNames = new string[]
		{
			"extraData",
			"isOffline",
			"msgTraceFlag",
			"msgType",
			"offlineExpireTime",
			"priority",
			"transparent"
		};

		// Token: 0x0400016C RID: 364
		private static readonly uint[] _oSMessageFieldTags = new uint[]
		{
			42U,
			16U,
			56U,
			48U,
			24U,
			64U,
			34U
		};

		// Token: 0x0400016D RID: 365
		public const int IsOfflineFieldNumber = 2;

        // Token: 0x0400016F RID: 367
        private bool isOffline_;

		// Token: 0x04000170 RID: 368
		public const int OfflineExpireTimeFieldNumber = 3;

        // Token: 0x04000172 RID: 370
        private long offlineExpireTime_ = 1L;

		// Token: 0x04000173 RID: 371
		public const int TransparentFieldNumber = 4;

        // Token: 0x04000175 RID: 373
        private Transparent transparent_;

		// Token: 0x04000176 RID: 374
		public const int ExtraDataFieldNumber = 5;

        // Token: 0x04000178 RID: 376
        private string extraData_ = "";

		// Token: 0x04000179 RID: 377
		public const int MsgTypeFieldNumber = 6;

        // Token: 0x0400017B RID: 379
        private int msgType_;

		// Token: 0x0400017C RID: 380
		public const int MsgTraceFlagFieldNumber = 7;

        // Token: 0x0400017E RID: 382
        private int msgTraceFlag_;

		// Token: 0x0400017F RID: 383
		public const int PriorityFieldNumber = 8;

        // Token: 0x04000181 RID: 385
        private int priority_;

		// Token: 0x04000182 RID: 386
		private int memoizedSerializedSize = -1;

		// Token: 0x02000077 RID: 119
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<OSMessage, Builder>
		{
            // Token: 0x170003AC RID: 940
            // (get) Token: 0x06000950 RID: 2384 RVA: 0x0001636E File Offset: 0x0001456E
            protected override Builder ThisBuilder => this;

            // Token: 0x06000951 RID: 2385 RVA: 0x00016371 File Offset: 0x00014571
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x06000952 RID: 2386 RVA: 0x0001638B File Offset: 0x0001458B
			internal Builder(OSMessage cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x06000953 RID: 2387 RVA: 0x000163A4 File Offset: 0x000145A4
			private OSMessage PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					OSMessage other = result;
					result = new OSMessage();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x170003AD RID: 941
            // (get) Token: 0x06000954 RID: 2388 RVA: 0x000163E0 File Offset: 0x000145E0
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x170003AE RID: 942
            // (get) Token: 0x06000955 RID: 2389 RVA: 0x000163ED File Offset: 0x000145ED
            protected override OSMessage MessageBeingBuilt => PrepareBuilder();

            // Token: 0x06000956 RID: 2390 RVA: 0x000163F5 File Offset: 0x000145F5
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x06000957 RID: 2391 RVA: 0x0001640A File Offset: 0x0001460A
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x170003AF RID: 943
            // (get) Token: 0x06000958 RID: 2392 RVA: 0x00016430 File Offset: 0x00014630
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x170003B0 RID: 944
            // (get) Token: 0x06000959 RID: 2393 RVA: 0x00016437 File Offset: 0x00014637
            public override OSMessage DefaultInstanceForType => DefaultInstance;

            // Token: 0x0600095A RID: 2394 RVA: 0x0001643E File Offset: 0x0001463E
            public override OSMessage BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x0600095B RID: 2395 RVA: 0x00016461 File Offset: 0x00014661
			public override Builder MergeFrom(IMessage other)
			{
				if (other is OSMessage)
				{
					return MergeFrom((OSMessage)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x0600095C RID: 2396 RVA: 0x00016484 File Offset: 0x00014684
			public override Builder MergeFrom(OSMessage other)
			{
				if (other == DefaultInstance)
				{
					return this;
				}
				PrepareBuilder();
				if (other.HasIsOffline)
				{
					IsOffline = other.IsOffline;
				}
				if (other.HasOfflineExpireTime)
				{
					OfflineExpireTime = other.OfflineExpireTime;
				}
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
				if (other.HasPriority)
				{
					Priority = other.Priority;
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x0600095D RID: 2397 RVA: 0x0001653D File Offset: 0x0001473D
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x0600095E RID: 2398 RVA: 0x0001654C File Offset: 0x0001474C
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_oSMessageFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _oSMessageFieldTags[num2];
                    }
                    if (num <= 34U)
                    {
                        if (num <= 16U)
                        {
                            if (num == 0U)
                            {
                                throw InvalidProtocolBufferException.InvalidTag();
                            }
                            if (num == 16U)
                            {
                                result.HasIsOffline = input.ReadBool(ref result.isOffline_);
                                continue;
                            }
                        }
                        else
                        {
                            if (num == 24U)
                            {
                                result.HasOfflineExpireTime = input.ReadInt64(ref result.offlineExpireTime_);
                                continue;
                            }
                            if (num == 34U)
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
                    }
                    else if (num <= 48U)
                    {
                        if (num == 42U)
                        {
                            result.HasExtraData = input.ReadString(ref result.extraData_);
                            continue;
                        }
                        if (num == 48U)
                        {
                            result.HasMsgType = input.ReadInt32(ref result.msgType_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 56U)
                        {
                            result.HasMsgTraceFlag = input.ReadInt32(ref result.msgTraceFlag_);
                            continue;
                        }
                        if (num == 64U)
                        {
                            result.HasPriority = input.ReadInt32(ref result.priority_);
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

            // Token: 0x170003B1 RID: 945
            // (get) Token: 0x0600095F RID: 2399 RVA: 0x0001674B File Offset: 0x0001494B
            public bool HasIsOffline => result.HasIsOffline;

            // Token: 0x170003B2 RID: 946
            // (get) Token: 0x06000960 RID: 2400 RVA: 0x00016758 File Offset: 0x00014958
            // (set) Token: 0x06000961 RID: 2401 RVA: 0x00016765 File Offset: 0x00014965
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

			// Token: 0x06000962 RID: 2402 RVA: 0x0001676F File Offset: 0x0001496F
			public Builder SetIsOffline(bool value)
			{
				PrepareBuilder();
				result.HasIsOffline = true;
				result.isOffline_ = value;
				return this;
			}

			// Token: 0x06000963 RID: 2403 RVA: 0x00016791 File Offset: 0x00014991
			public Builder ClearIsOffline()
			{
				PrepareBuilder();
				result.HasIsOffline = false;
				result.isOffline_ = false;
				return this;
			}

            // Token: 0x170003B3 RID: 947
            // (get) Token: 0x06000964 RID: 2404 RVA: 0x000167B3 File Offset: 0x000149B3
            public bool HasOfflineExpireTime => result.HasOfflineExpireTime;

            // Token: 0x170003B4 RID: 948
            // (get) Token: 0x06000965 RID: 2405 RVA: 0x000167C0 File Offset: 0x000149C0
            // (set) Token: 0x06000966 RID: 2406 RVA: 0x000167CD File Offset: 0x000149CD
            public long OfflineExpireTime
			{
				get
				{
					return result.OfflineExpireTime;
				}
				set
				{
					SetOfflineExpireTime(value);
				}
			}

			// Token: 0x06000967 RID: 2407 RVA: 0x000167D7 File Offset: 0x000149D7
			public Builder SetOfflineExpireTime(long value)
			{
				PrepareBuilder();
				result.HasOfflineExpireTime = true;
				result.offlineExpireTime_ = value;
				return this;
			}

			// Token: 0x06000968 RID: 2408 RVA: 0x000167F9 File Offset: 0x000149F9
			public Builder ClearOfflineExpireTime()
			{
				PrepareBuilder();
				result.HasOfflineExpireTime = false;
				result.offlineExpireTime_ = 1L;
				return this;
			}

            // Token: 0x170003B5 RID: 949
            // (get) Token: 0x06000969 RID: 2409 RVA: 0x0001681C File Offset: 0x00014A1C
            public bool HasTransparent => result.HasTransparent;

            // Token: 0x170003B6 RID: 950
            // (get) Token: 0x0600096A RID: 2410 RVA: 0x00016829 File Offset: 0x00014A29
            // (set) Token: 0x0600096B RID: 2411 RVA: 0x00016836 File Offset: 0x00014A36
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

			// Token: 0x0600096C RID: 2412 RVA: 0x00016840 File Offset: 0x00014A40
			public Builder SetTransparent(Transparent value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasTransparent = true;
				result.transparent_ = value;
				return this;
			}

			// Token: 0x0600096D RID: 2413 RVA: 0x0001686D File Offset: 0x00014A6D
			public Builder SetTransparent(Transparent.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.HasTransparent = true;
				result.transparent_ = builderForValue.Build();
				return this;
			}

			// Token: 0x0600096E RID: 2414 RVA: 0x000168A0 File Offset: 0x00014AA0
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

			// Token: 0x0600096F RID: 2415 RVA: 0x0001691F File Offset: 0x00014B1F
			public Builder ClearTransparent()
			{
				PrepareBuilder();
				result.HasTransparent = false;
				result.transparent_ = null;
				return this;
			}

            // Token: 0x170003B7 RID: 951
            // (get) Token: 0x06000970 RID: 2416 RVA: 0x00016941 File Offset: 0x00014B41
            public bool HasExtraData => result.HasExtraData;

            // Token: 0x170003B8 RID: 952
            // (get) Token: 0x06000971 RID: 2417 RVA: 0x0001694E File Offset: 0x00014B4E
            // (set) Token: 0x06000972 RID: 2418 RVA: 0x0001695B File Offset: 0x00014B5B
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

			// Token: 0x06000973 RID: 2419 RVA: 0x00016965 File Offset: 0x00014B65
			public Builder SetExtraData(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasExtraData = true;
				result.extraData_ = value;
				return this;
			}

			// Token: 0x06000974 RID: 2420 RVA: 0x00016992 File Offset: 0x00014B92
			public Builder ClearExtraData()
			{
				PrepareBuilder();
				result.HasExtraData = false;
				result.extraData_ = "";
				return this;
			}

            // Token: 0x170003B9 RID: 953
            // (get) Token: 0x06000975 RID: 2421 RVA: 0x000169B8 File Offset: 0x00014BB8
            public bool HasMsgType => result.HasMsgType;

            // Token: 0x170003BA RID: 954
            // (get) Token: 0x06000976 RID: 2422 RVA: 0x000169C5 File Offset: 0x00014BC5
            // (set) Token: 0x06000977 RID: 2423 RVA: 0x000169D2 File Offset: 0x00014BD2
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

			// Token: 0x06000978 RID: 2424 RVA: 0x000169DC File Offset: 0x00014BDC
			public Builder SetMsgType(int value)
			{
				PrepareBuilder();
				result.HasMsgType = true;
				result.msgType_ = value;
				return this;
			}

			// Token: 0x06000979 RID: 2425 RVA: 0x000169FE File Offset: 0x00014BFE
			public Builder ClearMsgType()
			{
				PrepareBuilder();
				result.HasMsgType = false;
				result.msgType_ = 0;
				return this;
			}

            // Token: 0x170003BB RID: 955
            // (get) Token: 0x0600097A RID: 2426 RVA: 0x00016A20 File Offset: 0x00014C20
            public bool HasMsgTraceFlag => result.HasMsgTraceFlag;

            // Token: 0x170003BC RID: 956
            // (get) Token: 0x0600097B RID: 2427 RVA: 0x00016A2D File Offset: 0x00014C2D
            // (set) Token: 0x0600097C RID: 2428 RVA: 0x00016A3A File Offset: 0x00014C3A
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

			// Token: 0x0600097D RID: 2429 RVA: 0x00016A44 File Offset: 0x00014C44
			public Builder SetMsgTraceFlag(int value)
			{
				PrepareBuilder();
				result.HasMsgTraceFlag = true;
				result.msgTraceFlag_ = value;
				return this;
			}

			// Token: 0x0600097E RID: 2430 RVA: 0x00016A66 File Offset: 0x00014C66
			public Builder ClearMsgTraceFlag()
			{
				PrepareBuilder();
				result.HasMsgTraceFlag = false;
				result.msgTraceFlag_ = 0;
				return this;
			}

            // Token: 0x170003BD RID: 957
            // (get) Token: 0x0600097F RID: 2431 RVA: 0x00016A88 File Offset: 0x00014C88
            public bool HasPriority => result.HasPriority;

            // Token: 0x170003BE RID: 958
            // (get) Token: 0x06000980 RID: 2432 RVA: 0x00016A95 File Offset: 0x00014C95
            // (set) Token: 0x06000981 RID: 2433 RVA: 0x00016AA2 File Offset: 0x00014CA2
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

			// Token: 0x06000982 RID: 2434 RVA: 0x00016AAC File Offset: 0x00014CAC
			public Builder SetPriority(int value)
			{
				PrepareBuilder();
				result.HasPriority = true;
				result.priority_ = value;
				return this;
			}

			// Token: 0x06000983 RID: 2435 RVA: 0x00016ACE File Offset: 0x00014CCE
			public Builder ClearPriority()
			{
				PrepareBuilder();
				result.HasPriority = false;
				result.priority_ = 0;
				return this;
			}

			// Token: 0x040003DD RID: 989
			private bool resultIsReadOnly;

			// Token: 0x040003DE RID: 990
			private OSMessage result;
		}
	}
}
