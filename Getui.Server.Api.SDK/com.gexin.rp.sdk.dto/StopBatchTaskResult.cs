using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    // Token: 0x02000017 RID: 23
    [DebuggerNonUserCode]
	public sealed class StopBatchTaskResult : GeneratedMessage<StopBatchTaskResult, StopBatchTaskResult.Builder>
	{
		// Token: 0x0600020F RID: 527 RVA: 0x000050C3 File Offset: 0x000032C3
		private StopBatchTaskResult()
		{
		}

        // Token: 0x170000DE RID: 222
        // (get) Token: 0x06000210 RID: 528 RVA: 0x000050E8 File Offset: 0x000032E8
        public static StopBatchTaskResult DefaultInstance { get; } = new StopBatchTaskResult().MakeReadOnly();

        // Token: 0x170000DF RID: 223
        // (get) Token: 0x06000211 RID: 529 RVA: 0x000050EF File Offset: 0x000032EF
        public override StopBatchTaskResult DefaultInstanceForType => DefaultInstance;

        // Token: 0x170000E0 RID: 224
        // (get) Token: 0x06000212 RID: 530 RVA: 0x000050F6 File Offset: 0x000032F6
        protected override StopBatchTaskResult ThisMessage => this;

        // Token: 0x170000E1 RID: 225
        // (get) Token: 0x06000213 RID: 531 RVA: 0x000050F9 File Offset: 0x000032F9
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_StopBatchTaskResult__Descriptor;

        // Token: 0x170000E2 RID: 226
        // (get) Token: 0x06000214 RID: 532 RVA: 0x00005100 File Offset: 0x00003300
        protected override FieldAccessorTable<StopBatchTaskResult, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_StopBatchTaskResult__FieldAccessorTable;

        // Token: 0x170000E3 RID: 227
        // (get) Token: 0x06000215 RID: 533 RVA: 0x00005107 File Offset: 0x00003307
        public bool HasResult { get; private set; }

        // Token: 0x170000E4 RID: 228
        // (get) Token: 0x06000216 RID: 534 RVA: 0x0000510F File Offset: 0x0000330F
        public bool Result => result_;

        // Token: 0x170000E5 RID: 229
        // (get) Token: 0x06000217 RID: 535 RVA: 0x00005117 File Offset: 0x00003317
        public bool HasInfo { get; private set; }

        // Token: 0x170000E6 RID: 230
        // (get) Token: 0x06000218 RID: 536 RVA: 0x0000511F File Offset: 0x0000331F
        public string Info => info_;

        // Token: 0x170000E7 RID: 231
        // (get) Token: 0x06000219 RID: 537 RVA: 0x00005127 File Offset: 0x00003327
        public bool HasSeqId { get; private set; }

        // Token: 0x170000E8 RID: 232
        // (get) Token: 0x0600021A RID: 538 RVA: 0x0000512F File Offset: 0x0000332F
        public string SeqId => seqId_;

        // Token: 0x170000E9 RID: 233
        // (get) Token: 0x0600021B RID: 539 RVA: 0x00005137 File Offset: 0x00003337
        public override bool IsInitialized => HasResult;

        // Token: 0x0600021C RID: 540 RVA: 0x00005144 File Offset: 0x00003344
        public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] stopBatchTaskResultFieldNames = _stopBatchTaskResultFieldNames;
			if (HasResult)
			{
				output.WriteBool(1, stopBatchTaskResultFieldNames[1], Result);
			}
			if (HasInfo)
			{
				output.WriteString(2, stopBatchTaskResultFieldNames[0], Info);
			}
			if (HasSeqId)
			{
				output.WriteString(3, stopBatchTaskResultFieldNames[2], SeqId);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600021D RID: 541 RVA: 0x000051B4 File Offset: 0x000033B4
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
				if (HasResult)
				{
					num += CodedOutputStream.ComputeBoolSize(1, Result);
				}
				if (HasInfo)
				{
					num += CodedOutputStream.ComputeStringSize(2, Info);
				}
				if (HasSeqId)
				{
					num += CodedOutputStream.ComputeStringSize(3, SeqId);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000522B File Offset: 0x0000342B
		public static StopBatchTaskResult ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000523D File Offset: 0x0000343D
		public static StopBatchTaskResult ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00005250 File Offset: 0x00003450
		public static StopBatchTaskResult ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00005262 File Offset: 0x00003462
		public static StopBatchTaskResult ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00005275 File Offset: 0x00003475
		public static StopBatchTaskResult ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00005287 File Offset: 0x00003487
		public static StopBatchTaskResult ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000529A File Offset: 0x0000349A
		public static StopBatchTaskResult ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000052AC File Offset: 0x000034AC
		public static StopBatchTaskResult ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000226 RID: 550 RVA: 0x000052BF File Offset: 0x000034BF
		public static StopBatchTaskResult ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x06000227 RID: 551 RVA: 0x000052D1 File Offset: 0x000034D1
		public static StopBatchTaskResult ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000052E4 File Offset: 0x000034E4
		private StopBatchTaskResult MakeReadOnly()
		{
			return this;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000052E7 File Offset: 0x000034E7
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000052EE File Offset: 0x000034EE
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000052F6 File Offset: 0x000034F6
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000052FD File Offset: 0x000034FD
		public static Builder CreateBuilder(StopBatchTaskResult prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00005308 File Offset: 0x00003508
		static StopBatchTaskResult()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x04000134 RID: 308
        private static readonly string[] _stopBatchTaskResultFieldNames = new string[]
		{
			"info",
			"result",
			"seqId"
		};

		// Token: 0x04000135 RID: 309
		private static readonly uint[] _stopBatchTaskResultFieldTags = new uint[]
		{
			18U,
			8U,
			26U
		};

		// Token: 0x04000136 RID: 310
		public const int ResultFieldNumber = 1;

        // Token: 0x04000138 RID: 312
        private bool result_;

		// Token: 0x04000139 RID: 313
		public const int InfoFieldNumber = 2;

        // Token: 0x0400013B RID: 315
        private string info_ = "";

		// Token: 0x0400013C RID: 316
		public const int SeqIdFieldNumber = 3;

        // Token: 0x0400013E RID: 318
        private string seqId_ = "";

		// Token: 0x0400013F RID: 319
		private int memoizedSerializedSize = -1;

		// Token: 0x02000072 RID: 114
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<StopBatchTaskResult, Builder>
		{
            // Token: 0x1700037C RID: 892
            // (get) Token: 0x060008C6 RID: 2246 RVA: 0x00014FF7 File Offset: 0x000131F7
            protected override Builder ThisBuilder => this;

            // Token: 0x060008C7 RID: 2247 RVA: 0x00014FFA File Offset: 0x000131FA
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x060008C8 RID: 2248 RVA: 0x00015014 File Offset: 0x00013214
			internal Builder(StopBatchTaskResult cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x060008C9 RID: 2249 RVA: 0x0001502C File Offset: 0x0001322C
			private StopBatchTaskResult PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					StopBatchTaskResult other = result;
					result = new StopBatchTaskResult();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x1700037D RID: 893
            // (get) Token: 0x060008CA RID: 2250 RVA: 0x00015068 File Offset: 0x00013268
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x1700037E RID: 894
            // (get) Token: 0x060008CB RID: 2251 RVA: 0x00015075 File Offset: 0x00013275
            protected override StopBatchTaskResult MessageBeingBuilt => PrepareBuilder();

            // Token: 0x060008CC RID: 2252 RVA: 0x0001507D File Offset: 0x0001327D
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x060008CD RID: 2253 RVA: 0x00015092 File Offset: 0x00013292
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x1700037F RID: 895
            // (get) Token: 0x060008CE RID: 2254 RVA: 0x000150B8 File Offset: 0x000132B8
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x17000380 RID: 896
            // (get) Token: 0x060008CF RID: 2255 RVA: 0x000150BF File Offset: 0x000132BF
            public override StopBatchTaskResult DefaultInstanceForType => DefaultInstance;

            // Token: 0x060008D0 RID: 2256 RVA: 0x000150C6 File Offset: 0x000132C6
            public override StopBatchTaskResult BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x060008D1 RID: 2257 RVA: 0x000150E9 File Offset: 0x000132E9
			public override Builder MergeFrom(IMessage other)
			{
				if (other is StopBatchTaskResult)
				{
					return MergeFrom((StopBatchTaskResult)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x060008D2 RID: 2258 RVA: 0x0001510C File Offset: 0x0001330C
			public override Builder MergeFrom(StopBatchTaskResult other)
			{
				if (other == DefaultInstance)
				{
					return this;
				}
				PrepareBuilder();
				if (other.HasResult)
				{
					Result = other.Result;
				}
				if (other.HasInfo)
				{
					Info = other.Info;
				}
				if (other.HasSeqId)
				{
					SeqId = other.SeqId;
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x060008D3 RID: 2259 RVA: 0x00015174 File Offset: 0x00013374
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x060008D4 RID: 2260 RVA: 0x00015184 File Offset: 0x00013384
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_stopBatchTaskResultFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _stopBatchTaskResultFieldTags[num2];
                    }
                    if (num <= 8U)
                    {
                        if (num == 0U)
                        {
                            throw InvalidProtocolBufferException.InvalidTag();
                        }
                        if (num == 8U)
                        {
                            result.HasResult = input.ReadBool(ref result.result_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 18U)
                        {
                            result.HasInfo = input.ReadString(ref result.info_);
                            continue;
                        }
                        if (num == 26U)
                        {
                            result.HasSeqId = input.ReadString(ref result.seqId_);
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

            // Token: 0x17000381 RID: 897
            // (get) Token: 0x060008D5 RID: 2261 RVA: 0x000152B0 File Offset: 0x000134B0
            public bool HasResult => result.HasResult;

            // Token: 0x17000382 RID: 898
            // (get) Token: 0x060008D6 RID: 2262 RVA: 0x000152BD File Offset: 0x000134BD
            // (set) Token: 0x060008D7 RID: 2263 RVA: 0x000152CA File Offset: 0x000134CA
            public bool Result
			{
				get
				{
					return result.Result;
				}
				set
				{
					SetResult(value);
				}
			}

			// Token: 0x060008D8 RID: 2264 RVA: 0x000152D4 File Offset: 0x000134D4
			public Builder SetResult(bool value)
			{
				PrepareBuilder();
				result.HasResult = true;
				result.result_ = value;
				return this;
			}

			// Token: 0x060008D9 RID: 2265 RVA: 0x000152F6 File Offset: 0x000134F6
			public Builder ClearResult()
			{
				PrepareBuilder();
				result.HasResult = false;
				result.result_ = false;
				return this;
			}

            // Token: 0x17000383 RID: 899
            // (get) Token: 0x060008DA RID: 2266 RVA: 0x00015318 File Offset: 0x00013518
            public bool HasInfo => result.HasInfo;

            // Token: 0x17000384 RID: 900
            // (get) Token: 0x060008DB RID: 2267 RVA: 0x00015325 File Offset: 0x00013525
            // (set) Token: 0x060008DC RID: 2268 RVA: 0x00015332 File Offset: 0x00013532
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

			// Token: 0x060008DD RID: 2269 RVA: 0x0001533C File Offset: 0x0001353C
			public Builder SetInfo(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasInfo = true;
				result.info_ = value;
				return this;
			}

			// Token: 0x060008DE RID: 2270 RVA: 0x00015369 File Offset: 0x00013569
			public Builder ClearInfo()
			{
				PrepareBuilder();
				result.HasInfo = false;
				result.info_ = "";
				return this;
			}

            // Token: 0x17000385 RID: 901
            // (get) Token: 0x060008DF RID: 2271 RVA: 0x0001538F File Offset: 0x0001358F
            public bool HasSeqId => result.HasSeqId;

            // Token: 0x17000386 RID: 902
            // (get) Token: 0x060008E0 RID: 2272 RVA: 0x0001539C File Offset: 0x0001359C
            // (set) Token: 0x060008E1 RID: 2273 RVA: 0x000153A9 File Offset: 0x000135A9
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

			// Token: 0x060008E2 RID: 2274 RVA: 0x000153B3 File Offset: 0x000135B3
			public Builder SetSeqId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasSeqId = true;
				result.seqId_ = value;
				return this;
			}

			// Token: 0x060008E3 RID: 2275 RVA: 0x000153E0 File Offset: 0x000135E0
			public Builder ClearSeqId()
			{
				PrepareBuilder();
				result.HasSeqId = false;
				result.seqId_ = "";
				return this;
			}

			// Token: 0x040003D5 RID: 981
			private bool resultIsReadOnly;

			// Token: 0x040003D6 RID: 982
			private StopBatchTaskResult result;
		}
	}
}
