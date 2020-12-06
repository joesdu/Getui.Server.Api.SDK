using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    // Token: 0x02000011 RID: 17
    [DebuggerNonUserCode]
	public sealed class StartOSBatchTask : GeneratedMessage<StartOSBatchTask, StartOSBatchTask.Builder>
	{
		// Token: 0x06000159 RID: 345 RVA: 0x0000404F File Offset: 0x0000224F
		private StartOSBatchTask()
		{
		}

        // Token: 0x17000096 RID: 150
        // (get) Token: 0x0600015A RID: 346 RVA: 0x00004067 File Offset: 0x00002267
        public static StartOSBatchTask DefaultInstance { get; } = new StartOSBatchTask().MakeReadOnly();

        // Token: 0x17000097 RID: 151
        // (get) Token: 0x0600015B RID: 347 RVA: 0x0000406E File Offset: 0x0000226E
        public override StartOSBatchTask DefaultInstanceForType => DefaultInstance;

        // Token: 0x17000098 RID: 152
        // (get) Token: 0x0600015C RID: 348 RVA: 0x00004075 File Offset: 0x00002275
        protected override StartOSBatchTask ThisMessage => this;

        // Token: 0x17000099 RID: 153
        // (get) Token: 0x0600015D RID: 349 RVA: 0x00004078 File Offset: 0x00002278
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_StartOSBatchTask__Descriptor;

        // Token: 0x1700009A RID: 154
        // (get) Token: 0x0600015E RID: 350 RVA: 0x0000407F File Offset: 0x0000227F
        protected override FieldAccessorTable<StartOSBatchTask, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_StartOSBatchTask__FieldAccessorTable;

        // Token: 0x1700009B RID: 155
        // (get) Token: 0x0600015F RID: 351 RVA: 0x00004086 File Offset: 0x00002286
        public bool HasMessage { get; private set; }

        // Token: 0x1700009C RID: 156
        // (get) Token: 0x06000160 RID: 352 RVA: 0x0000408E File Offset: 0x0000228E
        public OSMessage Message => message_ ?? OSMessage.DefaultInstance;

        // Token: 0x1700009D RID: 157
        // (get) Token: 0x06000161 RID: 353 RVA: 0x0000409F File Offset: 0x0000229F
        public bool HasExpire { get; private set; }

        // Token: 0x1700009E RID: 158
        // (get) Token: 0x06000162 RID: 354 RVA: 0x000040A7 File Offset: 0x000022A7
        public long Expire => expire_;

        // Token: 0x1700009F RID: 159
        // (get) Token: 0x06000163 RID: 355 RVA: 0x000040AF File Offset: 0x000022AF
        public override bool IsInitialized => HasMessage && HasExpire && Message.IsInitialized;

        // Token: 0x06000164 RID: 356 RVA: 0x000040D8 File Offset: 0x000022D8
        public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] startOSBatchTaskFieldNames = _startOSBatchTaskFieldNames;
			if (HasMessage)
			{
				output.WriteMessage(1, startOSBatchTaskFieldNames[1], Message);
			}
			if (HasExpire)
			{
				output.WriteInt64(2, startOSBatchTaskFieldNames[0], Expire);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00004130 File Offset: 0x00002330
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
					num += CodedOutputStream.ComputeMessageSize(1, Message);
				}
				if (HasExpire)
				{
					num += CodedOutputStream.ComputeInt64Size(2, Expire);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00004190 File Offset: 0x00002390
		public static StartOSBatchTask ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000041A2 File Offset: 0x000023A2
		public static StartOSBatchTask ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000041B5 File Offset: 0x000023B5
		public static StartOSBatchTask ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000041C7 File Offset: 0x000023C7
		public static StartOSBatchTask ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000041DA File Offset: 0x000023DA
		public static StartOSBatchTask ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000041EC File Offset: 0x000023EC
		public static StartOSBatchTask ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000041FF File Offset: 0x000023FF
		public static StartOSBatchTask ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00004211 File Offset: 0x00002411
		public static StartOSBatchTask ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00004224 File Offset: 0x00002424
		public static StartOSBatchTask ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00004236 File Offset: 0x00002436
		public static StartOSBatchTask ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00004249 File Offset: 0x00002449
		private StartOSBatchTask MakeReadOnly()
		{
			return this;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000424C File Offset: 0x0000244C
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00004253 File Offset: 0x00002453
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000425B File Offset: 0x0000245B
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00004262 File Offset: 0x00002462
		public static Builder CreateBuilder(StartOSBatchTask prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000426C File Offset: 0x0000246C
		static StartOSBatchTask()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x040000F1 RID: 241
        private static readonly string[] _startOSBatchTaskFieldNames = new string[]
		{
			"expire",
			"message"
		};

		// Token: 0x040000F2 RID: 242
		private static readonly uint[] _startOSBatchTaskFieldTags = new uint[]
		{
			16U,
			10U
		};

		// Token: 0x040000F3 RID: 243
		public const int MessageFieldNumber = 1;

        // Token: 0x040000F5 RID: 245
        private OSMessage message_;

		// Token: 0x040000F6 RID: 246
		public const int ExpireFieldNumber = 2;

        // Token: 0x040000F8 RID: 248
        private long expire_ = 72L;

		// Token: 0x040000F9 RID: 249
		private int memoizedSerializedSize = -1;

		// Token: 0x0200006C RID: 108
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<StartOSBatchTask, Builder>
		{
            // Token: 0x17000340 RID: 832
            // (get) Token: 0x06000817 RID: 2071 RVA: 0x0001377D File Offset: 0x0001197D
            protected override Builder ThisBuilder => this;

            // Token: 0x06000818 RID: 2072 RVA: 0x00013780 File Offset: 0x00011980
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x06000819 RID: 2073 RVA: 0x0001379A File Offset: 0x0001199A
			internal Builder(StartOSBatchTask cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x0600081A RID: 2074 RVA: 0x000137B0 File Offset: 0x000119B0
			private StartOSBatchTask PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					StartOSBatchTask other = result;
					result = new StartOSBatchTask();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x17000341 RID: 833
            // (get) Token: 0x0600081B RID: 2075 RVA: 0x000137EC File Offset: 0x000119EC
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x17000342 RID: 834
            // (get) Token: 0x0600081C RID: 2076 RVA: 0x000137F9 File Offset: 0x000119F9
            protected override StartOSBatchTask MessageBeingBuilt => PrepareBuilder();

            // Token: 0x0600081D RID: 2077 RVA: 0x00013801 File Offset: 0x00011A01
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x0600081E RID: 2078 RVA: 0x00013816 File Offset: 0x00011A16
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x17000343 RID: 835
            // (get) Token: 0x0600081F RID: 2079 RVA: 0x0001383C File Offset: 0x00011A3C
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x17000344 RID: 836
            // (get) Token: 0x06000820 RID: 2080 RVA: 0x00013843 File Offset: 0x00011A43
            public override StartOSBatchTask DefaultInstanceForType => DefaultInstance;

            // Token: 0x06000821 RID: 2081 RVA: 0x0001384A File Offset: 0x00011A4A
            public override StartOSBatchTask BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x06000822 RID: 2082 RVA: 0x0001386D File Offset: 0x00011A6D
			public override Builder MergeFrom(IMessage other)
			{
				if (other is StartOSBatchTask)
				{
					return MergeFrom((StartOSBatchTask)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x06000823 RID: 2083 RVA: 0x00013890 File Offset: 0x00011A90
			public override Builder MergeFrom(StartOSBatchTask other)
			{
				if (other == DefaultInstance)
				{
					return this;
				}
				PrepareBuilder();
				if (other.HasMessage)
				{
					MergeMessage(other.Message);
				}
				if (other.HasExpire)
				{
					Expire = other.Expire;
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x06000824 RID: 2084 RVA: 0x000138E5 File Offset: 0x00011AE5
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x06000825 RID: 2085 RVA: 0x000138F4 File Offset: 0x00011AF4
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_startOSBatchTaskFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _startOSBatchTaskFieldTags[num2];
                    }
                    if (num == 0U)
                    {
                        throw InvalidProtocolBufferException.InvalidTag();
                    }
                    if (num != 10U)
                    {
                        if (num != 16U)
                        {
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
                        else
                        {
                            result.HasExpire = input.ReadInt64(ref result.expire_);
                        }
                    }
                    else
                    {
                        OSMessage.Builder builder2 = OSMessage.CreateBuilder();
                        if (result.HasMessage)
                        {
                            builder2.MergeFrom(Message);
                        }
                        input.ReadMessage(builder2, extensionRegistry);
                        Message = builder2.BuildPartial();
                    }
                }
                if (builder != null)
				{
					UnknownFields = builder.Build();
				}
				return this;
			}

            // Token: 0x17000345 RID: 837
            // (get) Token: 0x06000826 RID: 2086 RVA: 0x00013A14 File Offset: 0x00011C14
            public bool HasMessage => result.HasMessage;

            // Token: 0x17000346 RID: 838
            // (get) Token: 0x06000827 RID: 2087 RVA: 0x00013A21 File Offset: 0x00011C21
            // (set) Token: 0x06000828 RID: 2088 RVA: 0x00013A2E File Offset: 0x00011C2E
            public OSMessage Message
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

			// Token: 0x06000829 RID: 2089 RVA: 0x00013A38 File Offset: 0x00011C38
			public Builder SetMessage(OSMessage value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasMessage = true;
				result.message_ = value;
				return this;
			}

			// Token: 0x0600082A RID: 2090 RVA: 0x00013A65 File Offset: 0x00011C65
			public Builder SetMessage(OSMessage.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.HasMessage = true;
				result.message_ = builderForValue.Build();
				return this;
			}

			// Token: 0x0600082B RID: 2091 RVA: 0x00013A98 File Offset: 0x00011C98
			public Builder MergeMessage(OSMessage value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				if (result.HasMessage && result.message_ != OSMessage.DefaultInstance)
				{
					result.message_ = OSMessage.CreateBuilder(result.message_).MergeFrom(value).BuildPartial();
				}
				else
				{
					result.message_ = value;
				}
				result.HasMessage = true;
				return this;
			}

			// Token: 0x0600082C RID: 2092 RVA: 0x00013B17 File Offset: 0x00011D17
			public Builder ClearMessage()
			{
				PrepareBuilder();
				result.HasMessage = false;
				result.message_ = null;
				return this;
			}

            // Token: 0x17000347 RID: 839
            // (get) Token: 0x0600082D RID: 2093 RVA: 0x00013B39 File Offset: 0x00011D39
            public bool HasExpire => result.HasExpire;

            // Token: 0x17000348 RID: 840
            // (get) Token: 0x0600082E RID: 2094 RVA: 0x00013B46 File Offset: 0x00011D46
            // (set) Token: 0x0600082F RID: 2095 RVA: 0x00013B53 File Offset: 0x00011D53
            public long Expire
			{
				get
				{
					return result.Expire;
				}
				set
				{
					SetExpire(value);
				}
			}

			// Token: 0x06000830 RID: 2096 RVA: 0x00013B5D File Offset: 0x00011D5D
			public Builder SetExpire(long value)
			{
				PrepareBuilder();
				result.HasExpire = true;
				result.expire_ = value;
				return this;
			}

			// Token: 0x06000831 RID: 2097 RVA: 0x00013B7F File Offset: 0x00011D7F
			public Builder ClearExpire()
			{
				PrepareBuilder();
				result.HasExpire = false;
				result.expire_ = 72L;
				return this;
			}

			// Token: 0x040003C9 RID: 969
			private bool resultIsReadOnly;

			// Token: 0x040003CA RID: 970
			private StartOSBatchTask result;
		}
	}
}
