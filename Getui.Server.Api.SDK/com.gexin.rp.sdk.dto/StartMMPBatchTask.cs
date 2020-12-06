using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    // Token: 0x02000010 RID: 16
    [DebuggerNonUserCode]
	public sealed class StartMMPBatchTask : GeneratedMessage<StartMMPBatchTask, StartMMPBatchTask.Builder>
	{
		// Token: 0x06000138 RID: 312 RVA: 0x00003D3F File Offset: 0x00001F3F
		private StartMMPBatchTask()
		{
		}

        // Token: 0x17000087 RID: 135
        // (get) Token: 0x06000139 RID: 313 RVA: 0x00003D6D File Offset: 0x00001F6D
        public static StartMMPBatchTask DefaultInstance { get; } = new StartMMPBatchTask().MakeReadOnly();

        // Token: 0x17000088 RID: 136
        // (get) Token: 0x0600013A RID: 314 RVA: 0x00003D74 File Offset: 0x00001F74
        public override StartMMPBatchTask DefaultInstanceForType => DefaultInstance;

        // Token: 0x17000089 RID: 137
        // (get) Token: 0x0600013B RID: 315 RVA: 0x00003D7B File Offset: 0x00001F7B
        protected override StartMMPBatchTask ThisMessage => this;

        // Token: 0x1700008A RID: 138
        // (get) Token: 0x0600013C RID: 316 RVA: 0x00003D7E File Offset: 0x00001F7E
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_StartMMPBatchTask__Descriptor;

        // Token: 0x1700008B RID: 139
        // (get) Token: 0x0600013D RID: 317 RVA: 0x00003D85 File Offset: 0x00001F85
        protected override FieldAccessorTable<StartMMPBatchTask, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_StartMMPBatchTask__FieldAccessorTable;

        // Token: 0x1700008C RID: 140
        // (get) Token: 0x0600013E RID: 318 RVA: 0x00003D8C File Offset: 0x00001F8C
        public bool HasMessage { get; private set; }

        // Token: 0x1700008D RID: 141
        // (get) Token: 0x0600013F RID: 319 RVA: 0x00003D94 File Offset: 0x00001F94
        public MMPMessage Message => message_ ?? MMPMessage.DefaultInstance;

        // Token: 0x1700008E RID: 142
        // (get) Token: 0x06000140 RID: 320 RVA: 0x00003DA5 File Offset: 0x00001FA5
        public bool HasExpire { get; private set; }

        // Token: 0x1700008F RID: 143
        // (get) Token: 0x06000141 RID: 321 RVA: 0x00003DAD File Offset: 0x00001FAD
        public long Expire => expire_;

        // Token: 0x17000090 RID: 144
        // (get) Token: 0x06000142 RID: 322 RVA: 0x00003DB5 File Offset: 0x00001FB5
        public bool HasSeqId { get; private set; }

        // Token: 0x17000091 RID: 145
        // (get) Token: 0x06000143 RID: 323 RVA: 0x00003DBD File Offset: 0x00001FBD
        public string SeqId => seqId_;

        // Token: 0x17000092 RID: 146
        // (get) Token: 0x06000144 RID: 324 RVA: 0x00003DC5 File Offset: 0x00001FC5
        public bool HasTaskGroupName { get; private set; }

        // Token: 0x17000093 RID: 147
        // (get) Token: 0x06000145 RID: 325 RVA: 0x00003DCD File Offset: 0x00001FCD
        public string TaskGroupName => taskGroupName_;

        // Token: 0x17000094 RID: 148
        // (get) Token: 0x06000146 RID: 326 RVA: 0x00003DD5 File Offset: 0x00001FD5
        public override bool IsInitialized => HasMessage && HasExpire && Message.IsInitialized;

        // Token: 0x06000147 RID: 327 RVA: 0x00003DFC File Offset: 0x00001FFC
        public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] startMMPBatchTaskFieldNames = _startMMPBatchTaskFieldNames;
			if (HasMessage)
			{
				output.WriteMessage(1, startMMPBatchTaskFieldNames[1], Message);
			}
			if (HasExpire)
			{
				output.WriteInt64(2, startMMPBatchTaskFieldNames[0], Expire);
			}
			if (HasSeqId)
			{
				output.WriteString(3, startMMPBatchTaskFieldNames[2], SeqId);
			}
			if (HasTaskGroupName)
			{
				output.WriteString(4, startMMPBatchTaskFieldNames[3], TaskGroupName);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00003E84 File Offset: 0x00002084
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
				if (HasSeqId)
				{
					num += CodedOutputStream.ComputeStringSize(3, SeqId);
				}
				if (HasTaskGroupName)
				{
					num += CodedOutputStream.ComputeStringSize(4, TaskGroupName);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00003F12 File Offset: 0x00002112
		public static StartMMPBatchTask ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00003F24 File Offset: 0x00002124
		public static StartMMPBatchTask ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00003F37 File Offset: 0x00002137
		public static StartMMPBatchTask ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00003F49 File Offset: 0x00002149
		public static StartMMPBatchTask ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00003F5C File Offset: 0x0000215C
		public static StartMMPBatchTask ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00003F6E File Offset: 0x0000216E
		public static StartMMPBatchTask ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00003F81 File Offset: 0x00002181
		public static StartMMPBatchTask ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00003F93 File Offset: 0x00002193
		public static StartMMPBatchTask ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00003FA6 File Offset: 0x000021A6
		public static StartMMPBatchTask ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00003FB8 File Offset: 0x000021B8
		public static StartMMPBatchTask ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00003FCB File Offset: 0x000021CB
		private StartMMPBatchTask MakeReadOnly()
		{
			return this;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00003FCE File Offset: 0x000021CE
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00003FD5 File Offset: 0x000021D5
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00003FDD File Offset: 0x000021DD
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00003FE4 File Offset: 0x000021E4
		public static Builder CreateBuilder(StartMMPBatchTask prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00003FEC File Offset: 0x000021EC
		static StartMMPBatchTask()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x040000E1 RID: 225
        private static readonly string[] _startMMPBatchTaskFieldNames = new string[]
		{
			"expire",
			"message",
			"seqId",
			"taskGroupName"
		};

		// Token: 0x040000E2 RID: 226
		private static readonly uint[] _startMMPBatchTaskFieldTags = new uint[]
		{
			16U,
			10U,
			26U,
			34U
		};

		// Token: 0x040000E3 RID: 227
		public const int MessageFieldNumber = 1;

        // Token: 0x040000E5 RID: 229
        private MMPMessage message_;

		// Token: 0x040000E6 RID: 230
		public const int ExpireFieldNumber = 2;

        // Token: 0x040000E8 RID: 232
        private long expire_ = 72L;

		// Token: 0x040000E9 RID: 233
		public const int SeqIdFieldNumber = 3;

        // Token: 0x040000EB RID: 235
        private string seqId_ = "";

		// Token: 0x040000EC RID: 236
		public const int TaskGroupNameFieldNumber = 4;

        // Token: 0x040000EE RID: 238
        private string taskGroupName_ = "";

		// Token: 0x040000EF RID: 239
		private int memoizedSerializedSize = -1;

		// Token: 0x0200006B RID: 107
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<StartMMPBatchTask, Builder>
		{
            // Token: 0x17000333 RID: 819
            // (get) Token: 0x060007F2 RID: 2034 RVA: 0x000131E7 File Offset: 0x000113E7
            protected override Builder ThisBuilder => this;

            // Token: 0x060007F3 RID: 2035 RVA: 0x000131EA File Offset: 0x000113EA
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x060007F4 RID: 2036 RVA: 0x00013204 File Offset: 0x00011404
			internal Builder(StartMMPBatchTask cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x060007F5 RID: 2037 RVA: 0x0001321C File Offset: 0x0001141C
			private StartMMPBatchTask PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					StartMMPBatchTask other = result;
					result = new StartMMPBatchTask();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x17000334 RID: 820
            // (get) Token: 0x060007F6 RID: 2038 RVA: 0x00013258 File Offset: 0x00011458
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x17000335 RID: 821
            // (get) Token: 0x060007F7 RID: 2039 RVA: 0x00013265 File Offset: 0x00011465
            protected override StartMMPBatchTask MessageBeingBuilt => PrepareBuilder();

            // Token: 0x060007F8 RID: 2040 RVA: 0x0001326D File Offset: 0x0001146D
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x060007F9 RID: 2041 RVA: 0x00013282 File Offset: 0x00011482
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x17000336 RID: 822
            // (get) Token: 0x060007FA RID: 2042 RVA: 0x000132A8 File Offset: 0x000114A8
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x17000337 RID: 823
            // (get) Token: 0x060007FB RID: 2043 RVA: 0x000132AF File Offset: 0x000114AF
            public override StartMMPBatchTask DefaultInstanceForType => DefaultInstance;

            // Token: 0x060007FC RID: 2044 RVA: 0x000132B6 File Offset: 0x000114B6
            public override StartMMPBatchTask BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x060007FD RID: 2045 RVA: 0x000132D9 File Offset: 0x000114D9
			public override Builder MergeFrom(IMessage other)
			{
				if (other is StartMMPBatchTask)
				{
					return MergeFrom((StartMMPBatchTask)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x060007FE RID: 2046 RVA: 0x000132FC File Offset: 0x000114FC
			public override Builder MergeFrom(StartMMPBatchTask other)
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
				if (other.HasSeqId)
				{
					SeqId = other.SeqId;
				}
				if (other.HasTaskGroupName)
				{
					TaskGroupName = other.TaskGroupName;
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x060007FF RID: 2047 RVA: 0x00013379 File Offset: 0x00011579
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x06000800 RID: 2048 RVA: 0x00013388 File Offset: 0x00011588
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_startMMPBatchTaskFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _startMMPBatchTaskFieldTags[num2];
                    }
                    if (num <= 10U)
                    {
                        if (num == 0U)
                        {
                            throw InvalidProtocolBufferException.InvalidTag();
                        }
                        if (num == 10U)
                        {
                            MMPMessage.Builder builder2 = MMPMessage.CreateBuilder();
                            if (result.HasMessage)
                            {
                                builder2.MergeFrom(Message);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            Message = builder2.BuildPartial();
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 16U)
                        {
                            result.HasExpire = input.ReadInt64(ref result.expire_);
                            continue;
                        }
                        if (num == 26U)
                        {
                            result.HasSeqId = input.ReadString(ref result.seqId_);
                            continue;
                        }
                        if (num == 34U)
                        {
                            result.HasTaskGroupName = input.ReadString(ref result.taskGroupName_);
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

            // Token: 0x17000338 RID: 824
            // (get) Token: 0x06000801 RID: 2049 RVA: 0x00013501 File Offset: 0x00011701
            public bool HasMessage => result.HasMessage;

            // Token: 0x17000339 RID: 825
            // (get) Token: 0x06000802 RID: 2050 RVA: 0x0001350E File Offset: 0x0001170E
            // (set) Token: 0x06000803 RID: 2051 RVA: 0x0001351B File Offset: 0x0001171B
            public MMPMessage Message
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

			// Token: 0x06000804 RID: 2052 RVA: 0x00013525 File Offset: 0x00011725
			public Builder SetMessage(MMPMessage value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasMessage = true;
				result.message_ = value;
				return this;
			}

			// Token: 0x06000805 RID: 2053 RVA: 0x00013552 File Offset: 0x00011752
			public Builder SetMessage(MMPMessage.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.HasMessage = true;
				result.message_ = builderForValue.Build();
				return this;
			}

			// Token: 0x06000806 RID: 2054 RVA: 0x00013584 File Offset: 0x00011784
			public Builder MergeMessage(MMPMessage value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				if (result.HasMessage && result.message_ != MMPMessage.DefaultInstance)
				{
					result.message_ = MMPMessage.CreateBuilder(result.message_).MergeFrom(value).BuildPartial();
				}
				else
				{
					result.message_ = value;
				}
				result.HasMessage = true;
				return this;
			}

			// Token: 0x06000807 RID: 2055 RVA: 0x00013603 File Offset: 0x00011803
			public Builder ClearMessage()
			{
				PrepareBuilder();
				result.HasMessage = false;
				result.message_ = null;
				return this;
			}

            // Token: 0x1700033A RID: 826
            // (get) Token: 0x06000808 RID: 2056 RVA: 0x00013625 File Offset: 0x00011825
            public bool HasExpire => result.HasExpire;

            // Token: 0x1700033B RID: 827
            // (get) Token: 0x06000809 RID: 2057 RVA: 0x00013632 File Offset: 0x00011832
            // (set) Token: 0x0600080A RID: 2058 RVA: 0x0001363F File Offset: 0x0001183F
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

			// Token: 0x0600080B RID: 2059 RVA: 0x00013649 File Offset: 0x00011849
			public Builder SetExpire(long value)
			{
				PrepareBuilder();
				result.HasExpire = true;
				result.expire_ = value;
				return this;
			}

			// Token: 0x0600080C RID: 2060 RVA: 0x0001366B File Offset: 0x0001186B
			public Builder ClearExpire()
			{
				PrepareBuilder();
				result.HasExpire = false;
				result.expire_ = 72L;
				return this;
			}

            // Token: 0x1700033C RID: 828
            // (get) Token: 0x0600080D RID: 2061 RVA: 0x0001368F File Offset: 0x0001188F
            public bool HasSeqId => result.HasSeqId;

            // Token: 0x1700033D RID: 829
            // (get) Token: 0x0600080E RID: 2062 RVA: 0x0001369C File Offset: 0x0001189C
            // (set) Token: 0x0600080F RID: 2063 RVA: 0x000136A9 File Offset: 0x000118A9
            public string SeqId
			{
				get
				{
					return result.SeqId;
				}
				set
				{
					SetSeqId(value);
				}
			}

			// Token: 0x06000810 RID: 2064 RVA: 0x000136B3 File Offset: 0x000118B3
			public Builder SetSeqId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasSeqId = true;
				result.seqId_ = value;
				return this;
			}

			// Token: 0x06000811 RID: 2065 RVA: 0x000136E0 File Offset: 0x000118E0
			public Builder ClearSeqId()
			{
				PrepareBuilder();
				result.HasSeqId = false;
				result.seqId_ = "";
				return this;
			}

            // Token: 0x1700033E RID: 830
            // (get) Token: 0x06000812 RID: 2066 RVA: 0x00013706 File Offset: 0x00011906
            public bool HasTaskGroupName => result.HasTaskGroupName;

            // Token: 0x1700033F RID: 831
            // (get) Token: 0x06000813 RID: 2067 RVA: 0x00013713 File Offset: 0x00011913
            // (set) Token: 0x06000814 RID: 2068 RVA: 0x00013720 File Offset: 0x00011920
            public string TaskGroupName
			{
				get
				{
					return result.TaskGroupName;
				}
				set
				{
					SetTaskGroupName(value);
				}
			}

			// Token: 0x06000815 RID: 2069 RVA: 0x0001372A File Offset: 0x0001192A
			public Builder SetTaskGroupName(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasTaskGroupName = true;
				result.taskGroupName_ = value;
				return this;
			}

			// Token: 0x06000816 RID: 2070 RVA: 0x00013757 File Offset: 0x00011957
			public Builder ClearTaskGroupName()
			{
				PrepareBuilder();
				result.HasTaskGroupName = false;
				result.taskGroupName_ = "";
				return this;
			}

			// Token: 0x040003C7 RID: 967
			private bool resultIsReadOnly;

			// Token: 0x040003C8 RID: 968
			private StartMMPBatchTask result;
		}
	}
}
