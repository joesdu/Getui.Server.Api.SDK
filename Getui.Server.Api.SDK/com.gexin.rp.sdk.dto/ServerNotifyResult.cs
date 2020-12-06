using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    // Token: 0x0200001A RID: 26
    [DebuggerNonUserCode]
	public sealed class ServerNotifyResult : GeneratedMessage<ServerNotifyResult, ServerNotifyResult.Builder>
	{
		// Token: 0x06000275 RID: 629 RVA: 0x00005AF7 File Offset: 0x00003CF7
		private ServerNotifyResult()
		{
		}

        // Token: 0x1700010B RID: 267
        // (get) Token: 0x06000276 RID: 630 RVA: 0x00005B1C File Offset: 0x00003D1C
        public static ServerNotifyResult DefaultInstance { get; } = new ServerNotifyResult().MakeReadOnly();

        // Token: 0x1700010C RID: 268
        // (get) Token: 0x06000277 RID: 631 RVA: 0x00005B23 File Offset: 0x00003D23
        public override ServerNotifyResult DefaultInstanceForType => DefaultInstance;

        // Token: 0x1700010D RID: 269
        // (get) Token: 0x06000278 RID: 632 RVA: 0x00005B2A File Offset: 0x00003D2A
        protected override ServerNotifyResult ThisMessage => this;

        // Token: 0x1700010E RID: 270
        // (get) Token: 0x06000279 RID: 633 RVA: 0x00005B2D File Offset: 0x00003D2D
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_ServerNotifyResult__Descriptor;

        // Token: 0x1700010F RID: 271
        // (get) Token: 0x0600027A RID: 634 RVA: 0x00005B34 File Offset: 0x00003D34
        protected override FieldAccessorTable<ServerNotifyResult, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_ServerNotifyResult__FieldAccessorTable;

        // Token: 0x17000110 RID: 272
        // (get) Token: 0x0600027B RID: 635 RVA: 0x00005B3B File Offset: 0x00003D3B
        public bool HasSeqId { get; private set; }

        // Token: 0x17000111 RID: 273
        // (get) Token: 0x0600027C RID: 636 RVA: 0x00005B43 File Offset: 0x00003D43
        public string SeqId => seqId_;

        // Token: 0x17000112 RID: 274
        // (get) Token: 0x0600027D RID: 637 RVA: 0x00005B4B File Offset: 0x00003D4B
        public bool HasInfo { get; private set; }

        // Token: 0x17000113 RID: 275
        // (get) Token: 0x0600027E RID: 638 RVA: 0x00005B53 File Offset: 0x00003D53
        public string Info => info_;

        // Token: 0x17000114 RID: 276
        // (get) Token: 0x0600027F RID: 639 RVA: 0x00005B5B File Offset: 0x00003D5B
        public override bool IsInitialized => HasSeqId;

        // Token: 0x06000280 RID: 640 RVA: 0x00005B68 File Offset: 0x00003D68
        public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] serverNotifyResultFieldNames = _serverNotifyResultFieldNames;
			if (HasSeqId)
			{
				output.WriteString(1, serverNotifyResultFieldNames[1], SeqId);
			}
			if (HasInfo)
			{
				output.WriteString(2, serverNotifyResultFieldNames[0], Info);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00005BC0 File Offset: 0x00003DC0
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
				if (HasInfo)
				{
					num += CodedOutputStream.ComputeStringSize(2, Info);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00005C20 File Offset: 0x00003E20
		public static ServerNotifyResult ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00005C32 File Offset: 0x00003E32
		public static ServerNotifyResult ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00005C45 File Offset: 0x00003E45
		public static ServerNotifyResult ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00005C57 File Offset: 0x00003E57
		public static ServerNotifyResult ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00005C6A File Offset: 0x00003E6A
		public static ServerNotifyResult ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00005C7C File Offset: 0x00003E7C
		public static ServerNotifyResult ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00005C8F File Offset: 0x00003E8F
		public static ServerNotifyResult ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00005CA1 File Offset: 0x00003EA1
		public static ServerNotifyResult ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00005CB4 File Offset: 0x00003EB4
		public static ServerNotifyResult ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00005CC6 File Offset: 0x00003EC6
		public static ServerNotifyResult ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00005CD9 File Offset: 0x00003ED9
		private ServerNotifyResult MakeReadOnly()
		{
			return this;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00005CDC File Offset: 0x00003EDC
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00005CE3 File Offset: 0x00003EE3
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00005CEB File Offset: 0x00003EEB
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00005CF2 File Offset: 0x00003EF2
		public static Builder CreateBuilder(ServerNotifyResult prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00005CFC File Offset: 0x00003EFC
		static ServerNotifyResult()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x04000161 RID: 353
        private static readonly string[] _serverNotifyResultFieldNames = new string[]
		{
			"info",
			"seqId"
		};

		// Token: 0x04000162 RID: 354
		private static readonly uint[] _serverNotifyResultFieldTags = new uint[]
		{
			18U,
			10U
		};

		// Token: 0x04000163 RID: 355
		public const int SeqIdFieldNumber = 1;

        // Token: 0x04000165 RID: 357
        private string seqId_ = "";

		// Token: 0x04000166 RID: 358
		public const int InfoFieldNumber = 2;

        // Token: 0x04000168 RID: 360
        private string info_ = "";

		// Token: 0x04000169 RID: 361
		private int memoizedSerializedSize = -1;

		// Token: 0x02000076 RID: 118
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<ServerNotifyResult, Builder>
		{
            // Token: 0x170003A3 RID: 931
            // (get) Token: 0x06000937 RID: 2359 RVA: 0x00016002 File Offset: 0x00014202
            protected override Builder ThisBuilder => this;

            // Token: 0x06000938 RID: 2360 RVA: 0x00016005 File Offset: 0x00014205
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x06000939 RID: 2361 RVA: 0x0001601F File Offset: 0x0001421F
			internal Builder(ServerNotifyResult cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x0600093A RID: 2362 RVA: 0x00016038 File Offset: 0x00014238
			private ServerNotifyResult PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					ServerNotifyResult other = result;
					result = new ServerNotifyResult();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x170003A4 RID: 932
            // (get) Token: 0x0600093B RID: 2363 RVA: 0x00016074 File Offset: 0x00014274
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x170003A5 RID: 933
            // (get) Token: 0x0600093C RID: 2364 RVA: 0x00016081 File Offset: 0x00014281
            protected override ServerNotifyResult MessageBeingBuilt => PrepareBuilder();

            // Token: 0x0600093D RID: 2365 RVA: 0x00016089 File Offset: 0x00014289
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x0600093E RID: 2366 RVA: 0x0001609E File Offset: 0x0001429E
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x170003A6 RID: 934
            // (get) Token: 0x0600093F RID: 2367 RVA: 0x000160C4 File Offset: 0x000142C4
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x170003A7 RID: 935
            // (get) Token: 0x06000940 RID: 2368 RVA: 0x000160CB File Offset: 0x000142CB
            public override ServerNotifyResult DefaultInstanceForType => DefaultInstance;

            // Token: 0x06000941 RID: 2369 RVA: 0x000160D2 File Offset: 0x000142D2
            public override ServerNotifyResult BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x06000942 RID: 2370 RVA: 0x000160F5 File Offset: 0x000142F5
			public override Builder MergeFrom(IMessage other)
			{
				if (other is ServerNotifyResult)
				{
					return MergeFrom((ServerNotifyResult)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x06000943 RID: 2371 RVA: 0x00016118 File Offset: 0x00014318
			public override Builder MergeFrom(ServerNotifyResult other)
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
				if (other.HasInfo)
				{
					Info = other.Info;
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x06000944 RID: 2372 RVA: 0x0001616C File Offset: 0x0001436C
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x06000945 RID: 2373 RVA: 0x0001617C File Offset: 0x0001437C
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_serverNotifyResultFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _serverNotifyResultFieldTags[num2];
                    }
                    if (num == 0U)
                    {
                        throw InvalidProtocolBufferException.InvalidTag();
                    }
                    if (num != 10U)
                    {
                        if (num != 18U)
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
                            result.HasInfo = input.ReadString(ref result.info_);
                        }
                    }
                    else
                    {
                        result.HasSeqId = input.ReadString(ref result.seqId_);
                    }
                }
                if (builder != null)
				{
					UnknownFields = builder.Build();
				}
				return this;
			}

            // Token: 0x170003A8 RID: 936
            // (get) Token: 0x06000946 RID: 2374 RVA: 0x00016280 File Offset: 0x00014480
            public bool HasSeqId => result.HasSeqId;

            // Token: 0x170003A9 RID: 937
            // (get) Token: 0x06000947 RID: 2375 RVA: 0x0001628D File Offset: 0x0001448D
            // (set) Token: 0x06000948 RID: 2376 RVA: 0x0001629A File Offset: 0x0001449A
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

			// Token: 0x06000949 RID: 2377 RVA: 0x000162A4 File Offset: 0x000144A4
			public Builder SetSeqId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasSeqId = true;
				result.seqId_ = value;
				return this;
			}

			// Token: 0x0600094A RID: 2378 RVA: 0x000162D1 File Offset: 0x000144D1
			public Builder ClearSeqId()
			{
				PrepareBuilder();
				result.HasSeqId = false;
				result.seqId_ = "";
				return this;
			}

            // Token: 0x170003AA RID: 938
            // (get) Token: 0x0600094B RID: 2379 RVA: 0x000162F7 File Offset: 0x000144F7
            public bool HasInfo => result.HasInfo;

            // Token: 0x170003AB RID: 939
            // (get) Token: 0x0600094C RID: 2380 RVA: 0x00016304 File Offset: 0x00014504
            // (set) Token: 0x0600094D RID: 2381 RVA: 0x00016311 File Offset: 0x00014511
            public string Info
			{
				get
				{
					return result.Info;
				}
				set
				{
					SetInfo(value);
				}
			}

			// Token: 0x0600094E RID: 2382 RVA: 0x0001631B File Offset: 0x0001451B
			public Builder SetInfo(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasInfo = true;
				result.info_ = value;
				return this;
			}

			// Token: 0x0600094F RID: 2383 RVA: 0x00016348 File Offset: 0x00014548
			public Builder ClearInfo()
			{
				PrepareBuilder();
				result.HasInfo = false;
				result.info_ = "";
				return this;
			}

			// Token: 0x040003DB RID: 987
			private bool resultIsReadOnly;

			// Token: 0x040003DC RID: 988
			private ServerNotifyResult result;
		}
	}
}
