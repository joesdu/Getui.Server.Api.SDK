using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    // Token: 0x0200000E RID: 14
    [DebuggerNonUserCode]
	public sealed class PushMMPSingleMessage : GeneratedMessage<PushMMPSingleMessage, PushMMPSingleMessage.Builder>
	{
		// Token: 0x060000F7 RID: 247 RVA: 0x000036CB File Offset: 0x000018CB
		private PushMMPSingleMessage()
		{
		}

        // Token: 0x1700006B RID: 107
        // (get) Token: 0x060000F8 RID: 248 RVA: 0x000036F0 File Offset: 0x000018F0
        public static PushMMPSingleMessage DefaultInstance { get; } = new PushMMPSingleMessage().MakeReadOnly();

        // Token: 0x1700006C RID: 108
        // (get) Token: 0x060000F9 RID: 249 RVA: 0x000036F7 File Offset: 0x000018F7
        public override PushMMPSingleMessage DefaultInstanceForType => DefaultInstance;

        // Token: 0x1700006D RID: 109
        // (get) Token: 0x060000FA RID: 250 RVA: 0x000036FE File Offset: 0x000018FE
        protected override PushMMPSingleMessage ThisMessage => this;

        // Token: 0x1700006E RID: 110
        // (get) Token: 0x060000FB RID: 251 RVA: 0x00003701 File Offset: 0x00001901
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_PushMMPSingleMessage__Descriptor;

        // Token: 0x1700006F RID: 111
        // (get) Token: 0x060000FC RID: 252 RVA: 0x00003708 File Offset: 0x00001908
        protected override FieldAccessorTable<PushMMPSingleMessage, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_PushMMPSingleMessage__FieldAccessorTable;

        // Token: 0x17000070 RID: 112
        // (get) Token: 0x060000FD RID: 253 RVA: 0x0000370F File Offset: 0x0000190F
        public bool HasSeqId { get; private set; }

        // Token: 0x17000071 RID: 113
        // (get) Token: 0x060000FE RID: 254 RVA: 0x00003717 File Offset: 0x00001917
        public string SeqId => seqId_;

        // Token: 0x17000072 RID: 114
        // (get) Token: 0x060000FF RID: 255 RVA: 0x0000371F File Offset: 0x0000191F
        public bool HasMessage { get; private set; }

        // Token: 0x17000073 RID: 115
        // (get) Token: 0x06000100 RID: 256 RVA: 0x00003727 File Offset: 0x00001927
        public MMPMessage Message => message_ ?? MMPMessage.DefaultInstance;

        // Token: 0x17000074 RID: 116
        // (get) Token: 0x06000101 RID: 257 RVA: 0x00003738 File Offset: 0x00001938
        public bool HasTarget { get; private set; }

        // Token: 0x17000075 RID: 117
        // (get) Token: 0x06000102 RID: 258 RVA: 0x00003740 File Offset: 0x00001940
        public Target Target => target_ ?? Target.DefaultInstance;

        // Token: 0x17000076 RID: 118
        // (get) Token: 0x06000103 RID: 259 RVA: 0x00003751 File Offset: 0x00001951
        public bool HasRequestId { get; private set; }

        // Token: 0x17000077 RID: 119
        // (get) Token: 0x06000104 RID: 260 RVA: 0x00003759 File Offset: 0x00001959
        public string RequestId => requestId_;

        // Token: 0x17000078 RID: 120
        // (get) Token: 0x06000105 RID: 261 RVA: 0x00003761 File Offset: 0x00001961
        public override bool IsInitialized => HasSeqId && HasMessage && HasTarget && Message.IsInitialized && Target.IsInitialized;

        // Token: 0x06000106 RID: 262 RVA: 0x000037A0 File Offset: 0x000019A0
        public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] pushMMPSingleMessageFieldNames = _pushMMPSingleMessageFieldNames;
			if (HasSeqId)
			{
				output.WriteString(1, pushMMPSingleMessageFieldNames[2], SeqId);
			}
			if (HasMessage)
			{
				output.WriteMessage(2, pushMMPSingleMessageFieldNames[0], Message);
			}
			if (HasTarget)
			{
				output.WriteMessage(3, pushMMPSingleMessageFieldNames[3], Target);
			}
			if (HasRequestId)
			{
				output.WriteString(4, pushMMPSingleMessageFieldNames[1], RequestId);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00003828 File Offset: 0x00001A28
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
				if (HasRequestId)
				{
					num += CodedOutputStream.ComputeStringSize(4, RequestId);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000038B6 File Offset: 0x00001AB6
		public static PushMMPSingleMessage ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000038C8 File Offset: 0x00001AC8
		public static PushMMPSingleMessage ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000038DB File Offset: 0x00001ADB
		public static PushMMPSingleMessage ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000038ED File Offset: 0x00001AED
		public static PushMMPSingleMessage ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00003900 File Offset: 0x00001B00
		public static PushMMPSingleMessage ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00003912 File Offset: 0x00001B12
		public static PushMMPSingleMessage ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00003925 File Offset: 0x00001B25
		public static PushMMPSingleMessage ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00003937 File Offset: 0x00001B37
		public static PushMMPSingleMessage ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000394A File Offset: 0x00001B4A
		public static PushMMPSingleMessage ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000395C File Offset: 0x00001B5C
		public static PushMMPSingleMessage ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000396F File Offset: 0x00001B6F
		private PushMMPSingleMessage MakeReadOnly()
		{
			return this;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00003972 File Offset: 0x00001B72
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00003979 File Offset: 0x00001B79
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00003981 File Offset: 0x00001B81
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00003988 File Offset: 0x00001B88
		public static Builder CreateBuilder(PushMMPSingleMessage prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00003990 File Offset: 0x00001B90
		static PushMMPSingleMessage()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x040000C5 RID: 197
        private static readonly string[] _pushMMPSingleMessageFieldNames = new string[]
		{
			"message",
			"requestId",
			"seqId",
			"target"
		};

		// Token: 0x040000C6 RID: 198
		private static readonly uint[] _pushMMPSingleMessageFieldTags = new uint[]
		{
			18U,
			34U,
			10U,
			26U
		};

		// Token: 0x040000C7 RID: 199
		public const int SeqIdFieldNumber = 1;

        // Token: 0x040000C9 RID: 201
        private string seqId_ = "";

		// Token: 0x040000CA RID: 202
		public const int MessageFieldNumber = 2;

        // Token: 0x040000CC RID: 204
        private MMPMessage message_;

		// Token: 0x040000CD RID: 205
		public const int TargetFieldNumber = 3;

        // Token: 0x040000CF RID: 207
        private Target target_;

		// Token: 0x040000D0 RID: 208
		public const int RequestIdFieldNumber = 4;

        // Token: 0x040000D2 RID: 210
        private string requestId_ = "";

		// Token: 0x040000D3 RID: 211
		private int memoizedSerializedSize = -1;

		// Token: 0x02000069 RID: 105
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<PushMMPSingleMessage, Builder>
		{
            // Token: 0x1700031B RID: 795
            // (get) Token: 0x060007A9 RID: 1961 RVA: 0x000126D5 File Offset: 0x000108D5
            protected override Builder ThisBuilder => this;

            // Token: 0x060007AA RID: 1962 RVA: 0x000126D8 File Offset: 0x000108D8
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x060007AB RID: 1963 RVA: 0x000126F2 File Offset: 0x000108F2
			internal Builder(PushMMPSingleMessage cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x060007AC RID: 1964 RVA: 0x00012708 File Offset: 0x00010908
			private PushMMPSingleMessage PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					PushMMPSingleMessage other = result;
					result = new PushMMPSingleMessage();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x1700031C RID: 796
            // (get) Token: 0x060007AD RID: 1965 RVA: 0x00012744 File Offset: 0x00010944
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x1700031D RID: 797
            // (get) Token: 0x060007AE RID: 1966 RVA: 0x00012751 File Offset: 0x00010951
            protected override PushMMPSingleMessage MessageBeingBuilt => PrepareBuilder();

            // Token: 0x060007AF RID: 1967 RVA: 0x00012759 File Offset: 0x00010959
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x060007B0 RID: 1968 RVA: 0x0001276E File Offset: 0x0001096E
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x1700031E RID: 798
            // (get) Token: 0x060007B1 RID: 1969 RVA: 0x00012794 File Offset: 0x00010994
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x1700031F RID: 799
            // (get) Token: 0x060007B2 RID: 1970 RVA: 0x0001279B File Offset: 0x0001099B
            public override PushMMPSingleMessage DefaultInstanceForType => DefaultInstance;

            // Token: 0x060007B3 RID: 1971 RVA: 0x000127A2 File Offset: 0x000109A2
            public override PushMMPSingleMessage BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x060007B4 RID: 1972 RVA: 0x000127C5 File Offset: 0x000109C5
			public override Builder MergeFrom(IMessage other)
			{
				if (other is PushMMPSingleMessage)
				{
					return MergeFrom((PushMMPSingleMessage)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x060007B5 RID: 1973 RVA: 0x000127E8 File Offset: 0x000109E8
			public override Builder MergeFrom(PushMMPSingleMessage other)
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
				if (other.HasRequestId)
				{
					RequestId = other.RequestId;
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x060007B6 RID: 1974 RVA: 0x00012866 File Offset: 0x00010A66
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x060007B7 RID: 1975 RVA: 0x00012874 File Offset: 0x00010A74
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_pushMMPSingleMessageFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _pushMMPSingleMessageFieldTags[num2];
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
                            MMPMessage.Builder builder2 = MMPMessage.CreateBuilder();
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
                        if (num == 34U)
                        {
                            result.HasRequestId = input.ReadString(ref result.requestId_);
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

            // Token: 0x17000320 RID: 800
            // (get) Token: 0x060007B8 RID: 1976 RVA: 0x00012A09 File Offset: 0x00010C09
            public bool HasSeqId => result.HasSeqId;

            // Token: 0x17000321 RID: 801
            // (get) Token: 0x060007B9 RID: 1977 RVA: 0x00012A16 File Offset: 0x00010C16
            // (set) Token: 0x060007BA RID: 1978 RVA: 0x00012A23 File Offset: 0x00010C23
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

			// Token: 0x060007BB RID: 1979 RVA: 0x00012A2D File Offset: 0x00010C2D
			public Builder SetSeqId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasSeqId = true;
				result.seqId_ = value;
				return this;
			}

			// Token: 0x060007BC RID: 1980 RVA: 0x00012A5A File Offset: 0x00010C5A
			public Builder ClearSeqId()
			{
				PrepareBuilder();
				result.HasSeqId = false;
				result.seqId_ = "";
				return this;
			}

            // Token: 0x17000322 RID: 802
            // (get) Token: 0x060007BD RID: 1981 RVA: 0x00012A80 File Offset: 0x00010C80
            public bool HasMessage => result.HasMessage;

            // Token: 0x17000323 RID: 803
            // (get) Token: 0x060007BE RID: 1982 RVA: 0x00012A8D File Offset: 0x00010C8D
            // (set) Token: 0x060007BF RID: 1983 RVA: 0x00012A9A File Offset: 0x00010C9A
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

			// Token: 0x060007C0 RID: 1984 RVA: 0x00012AA4 File Offset: 0x00010CA4
			public Builder SetMessage(MMPMessage value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasMessage = true;
				result.message_ = value;
				return this;
			}

			// Token: 0x060007C1 RID: 1985 RVA: 0x00012AD1 File Offset: 0x00010CD1
			public Builder SetMessage(MMPMessage.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.HasMessage = true;
				result.message_ = builderForValue.Build();
				return this;
			}

			// Token: 0x060007C2 RID: 1986 RVA: 0x00012B04 File Offset: 0x00010D04
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

			// Token: 0x060007C3 RID: 1987 RVA: 0x00012B83 File Offset: 0x00010D83
			public Builder ClearMessage()
			{
				PrepareBuilder();
				result.HasMessage = false;
				result.message_ = null;
				return this;
			}

            // Token: 0x17000324 RID: 804
            // (get) Token: 0x060007C4 RID: 1988 RVA: 0x00012BA5 File Offset: 0x00010DA5
            public bool HasTarget => result.HasTarget;

            // Token: 0x17000325 RID: 805
            // (get) Token: 0x060007C5 RID: 1989 RVA: 0x00012BB2 File Offset: 0x00010DB2
            // (set) Token: 0x060007C6 RID: 1990 RVA: 0x00012BBF File Offset: 0x00010DBF
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

			// Token: 0x060007C7 RID: 1991 RVA: 0x00012BC9 File Offset: 0x00010DC9
			public Builder SetTarget(Target value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasTarget = true;
				result.target_ = value;
				return this;
			}

			// Token: 0x060007C8 RID: 1992 RVA: 0x00012BF6 File Offset: 0x00010DF6
			public Builder SetTarget(Target.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.HasTarget = true;
				result.target_ = builderForValue.Build();
				return this;
			}

			// Token: 0x060007C9 RID: 1993 RVA: 0x00012C28 File Offset: 0x00010E28
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

			// Token: 0x060007CA RID: 1994 RVA: 0x00012CA7 File Offset: 0x00010EA7
			public Builder ClearTarget()
			{
				PrepareBuilder();
				result.HasTarget = false;
				result.target_ = null;
				return this;
			}

            // Token: 0x17000326 RID: 806
            // (get) Token: 0x060007CB RID: 1995 RVA: 0x00012CC9 File Offset: 0x00010EC9
            public bool HasRequestId => result.HasRequestId;

            // Token: 0x17000327 RID: 807
            // (get) Token: 0x060007CC RID: 1996 RVA: 0x00012CD6 File Offset: 0x00010ED6
            // (set) Token: 0x060007CD RID: 1997 RVA: 0x00012CE3 File Offset: 0x00010EE3
            public string RequestId
			{
				get
				{
					return result.RequestId;
				}
				set
				{
					SetRequestId(value);
				}
			}

			// Token: 0x060007CE RID: 1998 RVA: 0x00012CED File Offset: 0x00010EED
			public Builder SetRequestId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasRequestId = true;
				result.requestId_ = value;
				return this;
			}

			// Token: 0x060007CF RID: 1999 RVA: 0x00012D1A File Offset: 0x00010F1A
			public Builder ClearRequestId()
			{
				PrepareBuilder();
				result.HasRequestId = false;
				result.requestId_ = "";
				return this;
			}

			// Token: 0x040003C3 RID: 963
			private bool resultIsReadOnly;

			// Token: 0x040003C4 RID: 964
			private PushMMPSingleMessage result;
		}
	}
}
