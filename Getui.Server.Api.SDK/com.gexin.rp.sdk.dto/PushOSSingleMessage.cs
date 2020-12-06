using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    // Token: 0x0200000D RID: 13
    [DebuggerNonUserCode]
	public sealed class PushOSSingleMessage : GeneratedMessage<PushOSSingleMessage, PushOSSingleMessage.Builder>
	{
		// Token: 0x060000D8 RID: 216 RVA: 0x000033EF File Offset: 0x000015EF
		private PushOSSingleMessage()
		{
		}

        // Token: 0x1700005E RID: 94
        // (get) Token: 0x060000D9 RID: 217 RVA: 0x00003409 File Offset: 0x00001609
        public static PushOSSingleMessage DefaultInstance { get; } = new PushOSSingleMessage().MakeReadOnly();

        // Token: 0x1700005F RID: 95
        // (get) Token: 0x060000DA RID: 218 RVA: 0x00003410 File Offset: 0x00001610
        public override PushOSSingleMessage DefaultInstanceForType => DefaultInstance;

        // Token: 0x17000060 RID: 96
        // (get) Token: 0x060000DB RID: 219 RVA: 0x00003417 File Offset: 0x00001617
        protected override PushOSSingleMessage ThisMessage => this;

        // Token: 0x17000061 RID: 97
        // (get) Token: 0x060000DC RID: 220 RVA: 0x0000341A File Offset: 0x0000161A
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_PushOSSingleMessage__Descriptor;

        // Token: 0x17000062 RID: 98
        // (get) Token: 0x060000DD RID: 221 RVA: 0x00003421 File Offset: 0x00001621
        protected override FieldAccessorTable<PushOSSingleMessage, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_PushOSSingleMessage__FieldAccessorTable;

        // Token: 0x17000063 RID: 99
        // (get) Token: 0x060000DE RID: 222 RVA: 0x00003428 File Offset: 0x00001628
        public bool HasSeqId { get; private set; }

        // Token: 0x17000064 RID: 100
        // (get) Token: 0x060000DF RID: 223 RVA: 0x00003430 File Offset: 0x00001630
        public string SeqId => seqId_;

        // Token: 0x17000065 RID: 101
        // (get) Token: 0x060000E0 RID: 224 RVA: 0x00003438 File Offset: 0x00001638
        public bool HasMessage { get; private set; }

        // Token: 0x17000066 RID: 102
        // (get) Token: 0x060000E1 RID: 225 RVA: 0x00003440 File Offset: 0x00001640
        public OSMessage Message => message_ ?? OSMessage.DefaultInstance;

        // Token: 0x17000067 RID: 103
        // (get) Token: 0x060000E2 RID: 226 RVA: 0x00003451 File Offset: 0x00001651
        public bool HasTarget { get; private set; }

        // Token: 0x17000068 RID: 104
        // (get) Token: 0x060000E3 RID: 227 RVA: 0x00003459 File Offset: 0x00001659
        public Target Target => target_ ?? Target.DefaultInstance;

        // Token: 0x17000069 RID: 105
        // (get) Token: 0x060000E4 RID: 228 RVA: 0x0000346A File Offset: 0x0000166A
        public override bool IsInitialized => HasSeqId && HasMessage && HasTarget && Message.IsInitialized && Target.IsInitialized;

        // Token: 0x060000E5 RID: 229 RVA: 0x000034AC File Offset: 0x000016AC
        public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] pushOSSingleMessageFieldNames = _pushOSSingleMessageFieldNames;
			if (HasSeqId)
			{
				output.WriteString(1, pushOSSingleMessageFieldNames[1], SeqId);
			}
			if (HasMessage)
			{
				output.WriteMessage(2, pushOSSingleMessageFieldNames[0], Message);
			}
			if (HasTarget)
			{
				output.WriteMessage(3, pushOSSingleMessageFieldNames[2], Target);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x0000351C File Offset: 0x0000171C
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
				if (HasSeqId)
				{
					num += CodedOutputStream.ComputeStringSize(1, SeqId);
				}
				if (HasMessage)
				{
					num += CodedOutputStream.ComputeMessageSize(2, Message);
				}
				if (HasTarget)
				{
					num += CodedOutputStream.ComputeMessageSize(3, Target);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00003593 File Offset: 0x00001793
		public static PushOSSingleMessage ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000035A5 File Offset: 0x000017A5
		public static PushOSSingleMessage ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000035B8 File Offset: 0x000017B8
		public static PushOSSingleMessage ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000035CA File Offset: 0x000017CA
		public static PushOSSingleMessage ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000035DD File Offset: 0x000017DD
		public static PushOSSingleMessage ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000035EF File Offset: 0x000017EF
		public static PushOSSingleMessage ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00003602 File Offset: 0x00001802
		public static PushOSSingleMessage ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00003614 File Offset: 0x00001814
		public static PushOSSingleMessage ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00003627 File Offset: 0x00001827
		public static PushOSSingleMessage ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00003639 File Offset: 0x00001839
		public static PushOSSingleMessage ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000364C File Offset: 0x0000184C
		private PushOSSingleMessage MakeReadOnly()
		{
			return this;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000364F File Offset: 0x0000184F
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00003656 File Offset: 0x00001856
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000365E File Offset: 0x0000185E
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00003665 File Offset: 0x00001865
		public static Builder CreateBuilder(PushOSSingleMessage prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00003670 File Offset: 0x00001870
		static PushOSSingleMessage()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x040000B8 RID: 184
        private static readonly string[] _pushOSSingleMessageFieldNames = new string[]
		{
			"message",
			"seqId",
			"target"
		};

		// Token: 0x040000B9 RID: 185
		private static readonly uint[] _pushOSSingleMessageFieldTags = new uint[]
		{
			18U,
			10U,
			26U
		};

		// Token: 0x040000BA RID: 186
		public const int SeqIdFieldNumber = 1;

        // Token: 0x040000BC RID: 188
        private string seqId_ = "";

		// Token: 0x040000BD RID: 189
		public const int MessageFieldNumber = 2;

        // Token: 0x040000BF RID: 191
        private OSMessage message_;

		// Token: 0x040000C0 RID: 192
		public const int TargetFieldNumber = 3;

        // Token: 0x040000C2 RID: 194
        private Target target_;

		// Token: 0x040000C3 RID: 195
		private int memoizedSerializedSize = -1;

		// Token: 0x02000068 RID: 104
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<PushOSSingleMessage, Builder>
		{
            // Token: 0x17000310 RID: 784
            // (get) Token: 0x06000787 RID: 1927 RVA: 0x0001211B File Offset: 0x0001031B
            protected override Builder ThisBuilder => this;

            // Token: 0x06000788 RID: 1928 RVA: 0x0001211E File Offset: 0x0001031E
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x06000789 RID: 1929 RVA: 0x00012138 File Offset: 0x00010338
			internal Builder(PushOSSingleMessage cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x0600078A RID: 1930 RVA: 0x00012150 File Offset: 0x00010350
			private PushOSSingleMessage PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					PushOSSingleMessage other = result;
					result = new PushOSSingleMessage();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x17000311 RID: 785
            // (get) Token: 0x0600078B RID: 1931 RVA: 0x0001218C File Offset: 0x0001038C
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x17000312 RID: 786
            // (get) Token: 0x0600078C RID: 1932 RVA: 0x00012199 File Offset: 0x00010399
            protected override PushOSSingleMessage MessageBeingBuilt => PrepareBuilder();

            // Token: 0x0600078D RID: 1933 RVA: 0x000121A1 File Offset: 0x000103A1
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x0600078E RID: 1934 RVA: 0x000121B6 File Offset: 0x000103B6
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x17000313 RID: 787
            // (get) Token: 0x0600078F RID: 1935 RVA: 0x000121DC File Offset: 0x000103DC
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x17000314 RID: 788
            // (get) Token: 0x06000790 RID: 1936 RVA: 0x000121E3 File Offset: 0x000103E3
            public override PushOSSingleMessage DefaultInstanceForType => DefaultInstance;

            // Token: 0x06000791 RID: 1937 RVA: 0x000121EA File Offset: 0x000103EA
            public override PushOSSingleMessage BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x06000792 RID: 1938 RVA: 0x0001220D File Offset: 0x0001040D
			public override Builder MergeFrom(IMessage other)
			{
				if (other is PushOSSingleMessage)
				{
					return MergeFrom((PushOSSingleMessage)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x06000793 RID: 1939 RVA: 0x00012230 File Offset: 0x00010430
			public override Builder MergeFrom(PushOSSingleMessage other)
			{
				if (other == DefaultInstance)
				{
					return this;
				}
				PrepareBuilder();
				if (other.HasSeqId)
				{
					SeqId = other.SeqId;
				}
				if (other.HasMessage)
				{
					MergeMessage(other.Message);
				}
				if (other.HasTarget)
				{
					MergeTarget(other.Target);
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x06000794 RID: 1940 RVA: 0x0001229A File Offset: 0x0001049A
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x06000795 RID: 1941 RVA: 0x000122A8 File Offset: 0x000104A8
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_pushOSSingleMessageFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _pushOSSingleMessageFieldTags[num2];
                    }
                    if (num <= 10U)
                    {
                        if (num == 0U)
                        {
                            throw InvalidProtocolBufferException.InvalidTag();
                        }
                        if (num == 10U)
                        {
                            result.HasSeqId = input.ReadString(ref result.seqId_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 18U)
                        {
                            OSMessage.Builder builder2 = OSMessage.CreateBuilder();
                            if (result.HasMessage)
                            {
                                builder2.MergeFrom(Message);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            Message = builder2.BuildPartial();
                            continue;
                        }
                        if (num == 26U)
                        {
                            Target.Builder builder3 = Target.CreateBuilder();
                            if (result.HasTarget)
                            {
                                builder3.MergeFrom(Target);
                            }
                            input.ReadMessage(builder3, extensionRegistry);
                            Target = builder3.BuildPartial();
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

            // Token: 0x17000315 RID: 789
            // (get) Token: 0x06000796 RID: 1942 RVA: 0x00012414 File Offset: 0x00010614
            public bool HasSeqId => result.HasSeqId;

            // Token: 0x17000316 RID: 790
            // (get) Token: 0x06000797 RID: 1943 RVA: 0x00012421 File Offset: 0x00010621
            // (set) Token: 0x06000798 RID: 1944 RVA: 0x0001242E File Offset: 0x0001062E
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

			// Token: 0x06000799 RID: 1945 RVA: 0x00012438 File Offset: 0x00010638
			public Builder SetSeqId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasSeqId = true;
				result.seqId_ = value;
				return this;
			}

			// Token: 0x0600079A RID: 1946 RVA: 0x00012465 File Offset: 0x00010665
			public Builder ClearSeqId()
			{
				PrepareBuilder();
				result.HasSeqId = false;
				result.seqId_ = "";
				return this;
			}

            // Token: 0x17000317 RID: 791
            // (get) Token: 0x0600079B RID: 1947 RVA: 0x0001248B File Offset: 0x0001068B
            public bool HasMessage => result.HasMessage;

            // Token: 0x17000318 RID: 792
            // (get) Token: 0x0600079C RID: 1948 RVA: 0x00012498 File Offset: 0x00010698
            // (set) Token: 0x0600079D RID: 1949 RVA: 0x000124A5 File Offset: 0x000106A5
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

			// Token: 0x0600079E RID: 1950 RVA: 0x000124AF File Offset: 0x000106AF
			public Builder SetMessage(OSMessage value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasMessage = true;
				result.message_ = value;
				return this;
			}

			// Token: 0x0600079F RID: 1951 RVA: 0x000124DC File Offset: 0x000106DC
			public Builder SetMessage(OSMessage.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.HasMessage = true;
				result.message_ = builderForValue.Build();
				return this;
			}

			// Token: 0x060007A0 RID: 1952 RVA: 0x00012510 File Offset: 0x00010710
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

			// Token: 0x060007A1 RID: 1953 RVA: 0x0001258F File Offset: 0x0001078F
			public Builder ClearMessage()
			{
				PrepareBuilder();
				result.HasMessage = false;
				result.message_ = null;
				return this;
			}

            // Token: 0x17000319 RID: 793
            // (get) Token: 0x060007A2 RID: 1954 RVA: 0x000125B1 File Offset: 0x000107B1
            public bool HasTarget => result.HasTarget;

            // Token: 0x1700031A RID: 794
            // (get) Token: 0x060007A3 RID: 1955 RVA: 0x000125BE File Offset: 0x000107BE
            // (set) Token: 0x060007A4 RID: 1956 RVA: 0x000125CB File Offset: 0x000107CB
            public Target Target
			{
				get
				{
					return result.Target;
				}
				set
				{
					SetTarget(value);
				}
			}

			// Token: 0x060007A5 RID: 1957 RVA: 0x000125D5 File Offset: 0x000107D5
			public Builder SetTarget(Target value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasTarget = true;
				result.target_ = value;
				return this;
			}

			// Token: 0x060007A6 RID: 1958 RVA: 0x00012602 File Offset: 0x00010802
			public Builder SetTarget(Target.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.HasTarget = true;
				result.target_ = builderForValue.Build();
				return this;
			}

			// Token: 0x060007A7 RID: 1959 RVA: 0x00012634 File Offset: 0x00010834
			public Builder MergeTarget(Target value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				if (result.HasTarget && result.target_ != Target.DefaultInstance)
				{
					result.target_ = Target.CreateBuilder(result.target_).MergeFrom(value).BuildPartial();
				}
				else
				{
					result.target_ = value;
				}
				result.HasTarget = true;
				return this;
			}

			// Token: 0x060007A8 RID: 1960 RVA: 0x000126B3 File Offset: 0x000108B3
			public Builder ClearTarget()
			{
				PrepareBuilder();
				result.HasTarget = false;
				result.target_ = null;
				return this;
			}

			// Token: 0x040003C1 RID: 961
			private bool resultIsReadOnly;

			// Token: 0x040003C2 RID: 962
			private PushOSSingleMessage result;
		}
	}
}
