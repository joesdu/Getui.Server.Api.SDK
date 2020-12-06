using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    // Token: 0x02000013 RID: 19
    [DebuggerNonUserCode]
	public sealed class SingleBatchItem : GeneratedMessage<SingleBatchItem, SingleBatchItem.Builder>
	{
		// Token: 0x06000194 RID: 404 RVA: 0x000045BA File Offset: 0x000027BA
		private SingleBatchItem()
		{
		}

        // Token: 0x170000AC RID: 172
        // (get) Token: 0x06000195 RID: 405 RVA: 0x000045D4 File Offset: 0x000027D4
        public static SingleBatchItem DefaultInstance { get; } = new SingleBatchItem().MakeReadOnly();

        // Token: 0x170000AD RID: 173
        // (get) Token: 0x06000196 RID: 406 RVA: 0x000045DB File Offset: 0x000027DB
        public override SingleBatchItem DefaultInstanceForType => DefaultInstance;

        // Token: 0x170000AE RID: 174
        // (get) Token: 0x06000197 RID: 407 RVA: 0x000045E2 File Offset: 0x000027E2
        protected override SingleBatchItem ThisMessage => this;

        // Token: 0x170000AF RID: 175
        // (get) Token: 0x06000198 RID: 408 RVA: 0x000045E5 File Offset: 0x000027E5
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_SingleBatchItem__Descriptor;

        // Token: 0x170000B0 RID: 176
        // (get) Token: 0x06000199 RID: 409 RVA: 0x000045EC File Offset: 0x000027EC
        protected override FieldAccessorTable<SingleBatchItem, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_SingleBatchItem__FieldAccessorTable;

        // Token: 0x170000B1 RID: 177
        // (get) Token: 0x0600019A RID: 410 RVA: 0x000045F3 File Offset: 0x000027F3
        public bool HasSeqId { get; private set; }

        // Token: 0x170000B2 RID: 178
        // (get) Token: 0x0600019B RID: 411 RVA: 0x000045FB File Offset: 0x000027FB
        public int SeqId => seqId_;

        // Token: 0x170000B3 RID: 179
        // (get) Token: 0x0600019C RID: 412 RVA: 0x00004603 File Offset: 0x00002803
        public bool HasData { get; private set; }

        // Token: 0x170000B4 RID: 180
        // (get) Token: 0x0600019D RID: 413 RVA: 0x0000460B File Offset: 0x0000280B
        public string Data => data_;

        // Token: 0x170000B5 RID: 181
        // (get) Token: 0x0600019E RID: 414 RVA: 0x00004613 File Offset: 0x00002813
        public override bool IsInitialized => HasSeqId && HasData;

        // Token: 0x0600019F RID: 415 RVA: 0x0000462C File Offset: 0x0000282C
        public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] singleBatchItemFieldNames = _singleBatchItemFieldNames;
			if (HasSeqId)
			{
				output.WriteInt32(1, singleBatchItemFieldNames[1], SeqId);
			}
			if (HasData)
			{
				output.WriteString(2, singleBatchItemFieldNames[0], Data);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00004684 File Offset: 0x00002884
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
					num += CodedOutputStream.ComputeInt32Size(1, SeqId);
				}
				if (HasData)
				{
					num += CodedOutputStream.ComputeStringSize(2, Data);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000046E4 File Offset: 0x000028E4
		public static SingleBatchItem ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000046F6 File Offset: 0x000028F6
		public static SingleBatchItem ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00004709 File Offset: 0x00002909
		public static SingleBatchItem ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000471B File Offset: 0x0000291B
		public static SingleBatchItem ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000472E File Offset: 0x0000292E
		public static SingleBatchItem ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00004740 File Offset: 0x00002940
		public static SingleBatchItem ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00004753 File Offset: 0x00002953
		public static SingleBatchItem ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00004765 File Offset: 0x00002965
		public static SingleBatchItem ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00004778 File Offset: 0x00002978
		public static SingleBatchItem ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000478A File Offset: 0x0000298A
		public static SingleBatchItem ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000479D File Offset: 0x0000299D
		private SingleBatchItem MakeReadOnly()
		{
			return this;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000047A0 File Offset: 0x000029A0
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000047A7 File Offset: 0x000029A7
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000047AF File Offset: 0x000029AF
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000047B6 File Offset: 0x000029B6
		public static Builder CreateBuilder(SingleBatchItem prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000047C0 File Offset: 0x000029C0
		static SingleBatchItem()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x04000104 RID: 260
        private static readonly string[] _singleBatchItemFieldNames = new string[]
		{
			"data",
			"seqId"
		};

		// Token: 0x04000105 RID: 261
		private static readonly uint[] _singleBatchItemFieldTags = new uint[]
		{
			18U,
			8U
		};

		// Token: 0x04000106 RID: 262
		public const int SeqIdFieldNumber = 1;

        // Token: 0x04000108 RID: 264
        private int seqId_;

		// Token: 0x04000109 RID: 265
		public const int DataFieldNumber = 2;

        // Token: 0x0400010B RID: 267
        private string data_ = "";

		// Token: 0x0400010C RID: 268
		private int memoizedSerializedSize = -1;

		// Token: 0x0200006E RID: 110
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<SingleBatchItem, Builder>
		{
            // Token: 0x17000352 RID: 850
            // (get) Token: 0x0600084F RID: 2127 RVA: 0x00013FA5 File Offset: 0x000121A5
            protected override Builder ThisBuilder => this;

            // Token: 0x06000850 RID: 2128 RVA: 0x00013FA8 File Offset: 0x000121A8
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x06000851 RID: 2129 RVA: 0x00013FC2 File Offset: 0x000121C2
			internal Builder(SingleBatchItem cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x06000852 RID: 2130 RVA: 0x00013FD8 File Offset: 0x000121D8
			private SingleBatchItem PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					SingleBatchItem other = result;
					result = new SingleBatchItem();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x17000353 RID: 851
            // (get) Token: 0x06000853 RID: 2131 RVA: 0x00014014 File Offset: 0x00012214
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x17000354 RID: 852
            // (get) Token: 0x06000854 RID: 2132 RVA: 0x00014021 File Offset: 0x00012221
            protected override SingleBatchItem MessageBeingBuilt => PrepareBuilder();

            // Token: 0x06000855 RID: 2133 RVA: 0x00014029 File Offset: 0x00012229
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x06000856 RID: 2134 RVA: 0x0001403E File Offset: 0x0001223E
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x17000355 RID: 853
            // (get) Token: 0x06000857 RID: 2135 RVA: 0x00014064 File Offset: 0x00012264
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x17000356 RID: 854
            // (get) Token: 0x06000858 RID: 2136 RVA: 0x0001406B File Offset: 0x0001226B
            public override SingleBatchItem DefaultInstanceForType => DefaultInstance;

            // Token: 0x06000859 RID: 2137 RVA: 0x00014072 File Offset: 0x00012272
            public override SingleBatchItem BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x0600085A RID: 2138 RVA: 0x00014095 File Offset: 0x00012295
			public override Builder MergeFrom(IMessage other)
			{
				if (other is SingleBatchItem)
				{
					return MergeFrom((SingleBatchItem)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x0600085B RID: 2139 RVA: 0x000140B8 File Offset: 0x000122B8
			public override Builder MergeFrom(SingleBatchItem other)
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
				if (other.HasData)
				{
					Data = other.Data;
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x0600085C RID: 2140 RVA: 0x0001410C File Offset: 0x0001230C
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x0600085D RID: 2141 RVA: 0x0001411C File Offset: 0x0001231C
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_singleBatchItemFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _singleBatchItemFieldTags[num2];
                    }
                    if (num == 0U)
                    {
                        throw InvalidProtocolBufferException.InvalidTag();
                    }
                    if (num != 8U)
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
                            result.HasData = input.ReadString(ref result.data_);
                        }
                    }
                    else
                    {
                        result.HasSeqId = input.ReadInt32(ref result.seqId_);
                    }
                }
                if (builder != null)
				{
					UnknownFields = builder.Build();
				}
				return this;
			}

            // Token: 0x17000357 RID: 855
            // (get) Token: 0x0600085E RID: 2142 RVA: 0x0001421F File Offset: 0x0001241F
            public bool HasSeqId => result.HasSeqId;

            // Token: 0x17000358 RID: 856
            // (get) Token: 0x0600085F RID: 2143 RVA: 0x0001422C File Offset: 0x0001242C
            // (set) Token: 0x06000860 RID: 2144 RVA: 0x00014239 File Offset: 0x00012439
            public int SeqId
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

			// Token: 0x06000861 RID: 2145 RVA: 0x00014243 File Offset: 0x00012443
			public Builder SetSeqId(int value)
			{
				PrepareBuilder();
				result.HasSeqId = true;
				result.seqId_ = value;
				return this;
			}

			// Token: 0x06000862 RID: 2146 RVA: 0x00014265 File Offset: 0x00012465
			public Builder ClearSeqId()
			{
				PrepareBuilder();
				result.HasSeqId = false;
				result.seqId_ = 0;
				return this;
			}

            // Token: 0x17000359 RID: 857
            // (get) Token: 0x06000863 RID: 2147 RVA: 0x00014287 File Offset: 0x00012487
            public bool HasData => result.HasData;

            // Token: 0x1700035A RID: 858
            // (get) Token: 0x06000864 RID: 2148 RVA: 0x00014294 File Offset: 0x00012494
            // (set) Token: 0x06000865 RID: 2149 RVA: 0x000142A1 File Offset: 0x000124A1
            public string Data
			{
				get
				{
					return result.Data;
				}
				set
				{
					SetData(value);
				}
			}

			// Token: 0x06000866 RID: 2150 RVA: 0x000142AB File Offset: 0x000124AB
			public Builder SetData(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasData = true;
				result.data_ = value;
				return this;
			}

			// Token: 0x06000867 RID: 2151 RVA: 0x000142D8 File Offset: 0x000124D8
			public Builder ClearData()
			{
				PrepareBuilder();
				result.HasData = false;
				result.data_ = "";
				return this;
			}

			// Token: 0x040003CD RID: 973
			private bool resultIsReadOnly;

			// Token: 0x040003CE RID: 974
			private SingleBatchItem result;
		}
	}
}
