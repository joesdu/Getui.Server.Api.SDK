using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    // Token: 0x0200000C RID: 12
    [DebuggerNonUserCode]
	public sealed class PushResult : GeneratedMessage<PushResult, PushResult.Builder>
	{
		// Token: 0x060000AF RID: 175 RVA: 0x00002F78 File Offset: 0x00001178
		private PushResult()
		{
		}

        // Token: 0x17000047 RID: 71
        // (get) Token: 0x060000B0 RID: 176 RVA: 0x00002FDF File Offset: 0x000011DF
        public static PushResult DefaultInstance { get; } = new PushResult().MakeReadOnly();

        // Token: 0x17000048 RID: 72
        // (get) Token: 0x060000B1 RID: 177 RVA: 0x00002FE6 File Offset: 0x000011E6
        public override PushResult DefaultInstanceForType => DefaultInstance;

        // Token: 0x17000049 RID: 73
        // (get) Token: 0x060000B2 RID: 178 RVA: 0x00002FED File Offset: 0x000011ED
        protected override PushResult ThisMessage => this;

        // Token: 0x1700004A RID: 74
        // (get) Token: 0x060000B3 RID: 179 RVA: 0x00002FF0 File Offset: 0x000011F0
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_PushResult__Descriptor;

        // Token: 0x1700004B RID: 75
        // (get) Token: 0x060000B4 RID: 180 RVA: 0x00002FF7 File Offset: 0x000011F7
        protected override FieldAccessorTable<PushResult, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_PushResult__FieldAccessorTable;

        // Token: 0x1700004C RID: 76
        // (get) Token: 0x060000B5 RID: 181 RVA: 0x00002FFE File Offset: 0x000011FE
        public bool HasResult { get; private set; }

        // Token: 0x1700004D RID: 77
        // (get) Token: 0x060000B6 RID: 182 RVA: 0x00003006 File Offset: 0x00001206
        public Types.EPushResult Result => result_;

        // Token: 0x1700004E RID: 78
        // (get) Token: 0x060000B7 RID: 183 RVA: 0x0000300E File Offset: 0x0000120E
        public bool HasTaskId { get; private set; }

        // Token: 0x1700004F RID: 79
        // (get) Token: 0x060000B8 RID: 184 RVA: 0x00003016 File Offset: 0x00001216
        public string TaskId => taskId_;

        // Token: 0x17000050 RID: 80
        // (get) Token: 0x060000B9 RID: 185 RVA: 0x0000301E File Offset: 0x0000121E
        public bool HasMessageId { get; private set; }

        // Token: 0x17000051 RID: 81
        // (get) Token: 0x060000BA RID: 186 RVA: 0x00003026 File Offset: 0x00001226
        public string MessageId => messageId_;

        // Token: 0x17000052 RID: 82
        // (get) Token: 0x060000BB RID: 187 RVA: 0x0000302E File Offset: 0x0000122E
        public bool HasSeqId { get; private set; }

        // Token: 0x17000053 RID: 83
        // (get) Token: 0x060000BC RID: 188 RVA: 0x00003036 File Offset: 0x00001236
        public string SeqId => seqId_;

        // Token: 0x17000054 RID: 84
        // (get) Token: 0x060000BD RID: 189 RVA: 0x0000303E File Offset: 0x0000123E
        public bool HasTarget { get; private set; }

        // Token: 0x17000055 RID: 85
        // (get) Token: 0x060000BE RID: 190 RVA: 0x00003046 File Offset: 0x00001246
        public string Target => target_;

        // Token: 0x17000056 RID: 86
        // (get) Token: 0x060000BF RID: 191 RVA: 0x0000304E File Offset: 0x0000124E
        public bool HasInfo { get; private set; }

        // Token: 0x17000057 RID: 87
        // (get) Token: 0x060000C0 RID: 192 RVA: 0x00003056 File Offset: 0x00001256
        public string Info => info_;

        // Token: 0x17000058 RID: 88
        // (get) Token: 0x060000C1 RID: 193 RVA: 0x0000305E File Offset: 0x0000125E
        public bool HasTraceId { get; private set; }

        // Token: 0x17000059 RID: 89
        // (get) Token: 0x060000C2 RID: 194 RVA: 0x00003066 File Offset: 0x00001266
        public string TraceId => traceId_;

        // Token: 0x1700005A RID: 90
        // (get) Token: 0x060000C3 RID: 195 RVA: 0x0000306E File Offset: 0x0000126E
        public bool HasBatchId { get; private set; }

        // Token: 0x1700005B RID: 91
        // (get) Token: 0x060000C4 RID: 196 RVA: 0x00003076 File Offset: 0x00001276
        public string BatchId => batchId_;

        // Token: 0x1700005C RID: 92
        // (get) Token: 0x060000C5 RID: 197 RVA: 0x0000307E File Offset: 0x0000127E
        public override bool IsInitialized => HasResult && HasTaskId && HasMessageId && HasSeqId && HasTarget;

        // Token: 0x060000C6 RID: 198 RVA: 0x000030B4 File Offset: 0x000012B4
        public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] pushResultFieldNames = _pushResultFieldNames;
			if (HasResult)
			{
				output.WriteEnum(1, pushResultFieldNames[3], (int)Result, Result);
			}
			if (HasTaskId)
			{
				output.WriteString(2, pushResultFieldNames[6], TaskId);
			}
			if (HasMessageId)
			{
				output.WriteString(3, pushResultFieldNames[2], MessageId);
			}
			if (HasSeqId)
			{
				output.WriteString(4, pushResultFieldNames[4], SeqId);
			}
			if (HasTarget)
			{
				output.WriteString(5, pushResultFieldNames[5], Target);
			}
			if (HasInfo)
			{
				output.WriteString(6, pushResultFieldNames[1], Info);
			}
			if (HasTraceId)
			{
				output.WriteString(7, pushResultFieldNames[7], TraceId);
			}
			if (HasBatchId)
			{
				output.WriteString(8, pushResultFieldNames[0], BatchId);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x000031A8 File Offset: 0x000013A8
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
					num += CodedOutputStream.ComputeEnumSize(1, (int)Result);
				}
				if (HasTaskId)
				{
					num += CodedOutputStream.ComputeStringSize(2, TaskId);
				}
				if (HasMessageId)
				{
					num += CodedOutputStream.ComputeStringSize(3, MessageId);
				}
				if (HasSeqId)
				{
					num += CodedOutputStream.ComputeStringSize(4, SeqId);
				}
				if (HasTarget)
				{
					num += CodedOutputStream.ComputeStringSize(5, Target);
				}
				if (HasInfo)
				{
					num += CodedOutputStream.ComputeStringSize(6, Info);
				}
				if (HasTraceId)
				{
					num += CodedOutputStream.ComputeStringSize(7, TraceId);
				}
				if (HasBatchId)
				{
					num += CodedOutputStream.ComputeStringSize(8, BatchId);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00003292 File Offset: 0x00001492
		public static PushResult ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000032A4 File Offset: 0x000014A4
		public static PushResult ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000032B7 File Offset: 0x000014B7
		public static PushResult ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000032C9 File Offset: 0x000014C9
		public static PushResult ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000032DC File Offset: 0x000014DC
		public static PushResult ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000032EE File Offset: 0x000014EE
		public static PushResult ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00003301 File Offset: 0x00001501
		public static PushResult ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00003313 File Offset: 0x00001513
		public static PushResult ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00003326 File Offset: 0x00001526
		public static PushResult ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00003338 File Offset: 0x00001538
		public static PushResult ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000334B File Offset: 0x0000154B
		private PushResult MakeReadOnly()
		{
			return this;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000334E File Offset: 0x0000154E
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00003355 File Offset: 0x00001555
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000335D File Offset: 0x0000155D
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00003364 File Offset: 0x00001564
		public static Builder CreateBuilder(PushResult prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000336C File Offset: 0x0000156C
		static PushResult()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x0400009C RID: 156
        private static readonly string[] _pushResultFieldNames = new string[]
		{
			"batchId",
			"info",
			"messageId",
			"result",
			"seqId",
			"target",
			"taskId",
			"traceId"
		};

		// Token: 0x0400009D RID: 157
		private static readonly uint[] _pushResultFieldTags = new uint[]
		{
			66U,
			50U,
			26U,
			8U,
			34U,
			42U,
			18U,
			58U
		};

		// Token: 0x0400009E RID: 158
		public const int ResultFieldNumber = 1;

        // Token: 0x040000A0 RID: 160
        private Types.EPushResult result_;

		// Token: 0x040000A1 RID: 161
		public const int TaskIdFieldNumber = 2;

        // Token: 0x040000A3 RID: 163
        private string taskId_ = "";

		// Token: 0x040000A4 RID: 164
		public const int MessageIdFieldNumber = 3;

        // Token: 0x040000A6 RID: 166
        private string messageId_ = "";

		// Token: 0x040000A7 RID: 167
		public const int SeqIdFieldNumber = 4;

        // Token: 0x040000A9 RID: 169
        private string seqId_ = "";

		// Token: 0x040000AA RID: 170
		public const int TargetFieldNumber = 5;

        // Token: 0x040000AC RID: 172
        private string target_ = "";

		// Token: 0x040000AD RID: 173
		public const int InfoFieldNumber = 6;

        // Token: 0x040000AF RID: 175
        private string info_ = "";

		// Token: 0x040000B0 RID: 176
		public const int TraceIdFieldNumber = 7;

        // Token: 0x040000B2 RID: 178
        private string traceId_ = "";

		// Token: 0x040000B3 RID: 179
		public const int BatchIdFieldNumber = 8;

        // Token: 0x040000B5 RID: 181
        private string batchId_ = "";

		// Token: 0x040000B6 RID: 182
		private int memoizedSerializedSize = -1;

		// Token: 0x02000066 RID: 102
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02000094 RID: 148
			public enum EPushResult
			{
				// Token: 0x04000410 RID: 1040
				successed_online,
				// Token: 0x04000411 RID: 1041
				successed_offline,
				// Token: 0x04000412 RID: 1042
				successed_ignore,
				// Token: 0x04000413 RID: 1043
				failed,
				// Token: 0x04000414 RID: 1044
				busy,
				// Token: 0x04000415 RID: 1045
				success_startBatch,
				// Token: 0x04000416 RID: 1046
				success_endBatch,
				// Token: 0x04000417 RID: 1047
				successed_async
			}
		}

		// Token: 0x02000067 RID: 103
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<PushResult, Builder>
		{
            // Token: 0x170002FB RID: 763
            // (get) Token: 0x06000750 RID: 1872 RVA: 0x00011940 File Offset: 0x0000FB40
            protected override Builder ThisBuilder => this;

            // Token: 0x06000751 RID: 1873 RVA: 0x00011943 File Offset: 0x0000FB43
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x06000752 RID: 1874 RVA: 0x0001195D File Offset: 0x0000FB5D
			internal Builder(PushResult cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x06000753 RID: 1875 RVA: 0x00011974 File Offset: 0x0000FB74
			private PushResult PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					PushResult other = result;
					result = new PushResult();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x170002FC RID: 764
            // (get) Token: 0x06000754 RID: 1876 RVA: 0x000119B0 File Offset: 0x0000FBB0
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x170002FD RID: 765
            // (get) Token: 0x06000755 RID: 1877 RVA: 0x000119BD File Offset: 0x0000FBBD
            protected override PushResult MessageBeingBuilt => PrepareBuilder();

            // Token: 0x06000756 RID: 1878 RVA: 0x000119C5 File Offset: 0x0000FBC5
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x06000757 RID: 1879 RVA: 0x000119DA File Offset: 0x0000FBDA
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x170002FE RID: 766
            // (get) Token: 0x06000758 RID: 1880 RVA: 0x00011A00 File Offset: 0x0000FC00
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x170002FF RID: 767
            // (get) Token: 0x06000759 RID: 1881 RVA: 0x00011A07 File Offset: 0x0000FC07
            public override PushResult DefaultInstanceForType => DefaultInstance;

            // Token: 0x0600075A RID: 1882 RVA: 0x00011A0E File Offset: 0x0000FC0E
            public override PushResult BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x0600075B RID: 1883 RVA: 0x00011A31 File Offset: 0x0000FC31
			public override Builder MergeFrom(IMessage other)
			{
				if (other is PushResult)
				{
					return MergeFrom((PushResult)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x0600075C RID: 1884 RVA: 0x00011A54 File Offset: 0x0000FC54
			public override Builder MergeFrom(PushResult other)
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
				if (other.HasTaskId)
				{
					TaskId = other.TaskId;
				}
				if (other.HasMessageId)
				{
					MessageId = other.MessageId;
				}
				if (other.HasSeqId)
				{
					SeqId = other.SeqId;
				}
				if (other.HasTarget)
				{
					Target = other.Target;
				}
				if (other.HasInfo)
				{
					Info = other.Info;
				}
				if (other.HasTraceId)
				{
					TraceId = other.TraceId;
				}
				if (other.HasBatchId)
				{
					BatchId = other.BatchId;
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x0600075D RID: 1885 RVA: 0x00011B20 File Offset: 0x0000FD20
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x0600075E RID: 1886 RVA: 0x00011B30 File Offset: 0x0000FD30
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_pushResultFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _pushResultFieldTags[num2];
                    }
                    if (num <= 26U)
                    {
                        if (num <= 8U)
                        {
                            if (num == 0U)
                            {
                                throw InvalidProtocolBufferException.InvalidTag();
                            }
                            if (num == 8U)
                            {
                                if (input.ReadEnum(ref result.result_, out object obj))
                                {
                                    result.HasResult = true;
                                    continue;
                                }
                                if (obj is int)
                                {
                                    if (builder == null)
                                    {
                                        builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                                    }
                                    builder.MergeVarintField(1, (ulong)((long)((int)obj)));
                                    continue;
                                }
                                continue;
                            }
                        }
                        else
                        {
                            if (num == 18U)
                            {
                                result.HasTaskId = input.ReadString(ref result.taskId_);
                                continue;
                            }
                            if (num == 26U)
                            {
                                result.HasMessageId = input.ReadString(ref result.messageId_);
                                continue;
                            }
                        }
                    }
                    else if (num <= 42U)
                    {
                        if (num == 34U)
                        {
                            result.HasSeqId = input.ReadString(ref result.seqId_);
                            continue;
                        }
                        if (num == 42U)
                        {
                            result.HasTarget = input.ReadString(ref result.target_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 50U)
                        {
                            result.HasInfo = input.ReadString(ref result.info_);
                            continue;
                        }
                        if (num == 58U)
                        {
                            result.HasTraceId = input.ReadString(ref result.traceId_);
                            continue;
                        }
                        if (num == 66U)
                        {
                            result.HasBatchId = input.ReadString(ref result.batchId_);
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

            // Token: 0x17000300 RID: 768
            // (get) Token: 0x0600075F RID: 1887 RVA: 0x00011D72 File Offset: 0x0000FF72
            public bool HasResult => result.HasResult;

            // Token: 0x17000301 RID: 769
            // (get) Token: 0x06000760 RID: 1888 RVA: 0x00011D7F File Offset: 0x0000FF7F
            // (set) Token: 0x06000761 RID: 1889 RVA: 0x00011D8C File Offset: 0x0000FF8C
            public Types.EPushResult Result
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

			// Token: 0x06000762 RID: 1890 RVA: 0x00011D96 File Offset: 0x0000FF96
			public Builder SetResult(Types.EPushResult value)
			{
				PrepareBuilder();
				result.HasResult = true;
				result.result_ = value;
				return this;
			}

			// Token: 0x06000763 RID: 1891 RVA: 0x00011DB8 File Offset: 0x0000FFB8
			public Builder ClearResult()
			{
				PrepareBuilder();
				result.HasResult = false;
				result.result_ = Types.EPushResult.successed_online;
				return this;
			}

            // Token: 0x17000302 RID: 770
            // (get) Token: 0x06000764 RID: 1892 RVA: 0x00011DDA File Offset: 0x0000FFDA
            public bool HasTaskId => result.HasTaskId;

            // Token: 0x17000303 RID: 771
            // (get) Token: 0x06000765 RID: 1893 RVA: 0x00011DE7 File Offset: 0x0000FFE7
            // (set) Token: 0x06000766 RID: 1894 RVA: 0x00011DF4 File Offset: 0x0000FFF4
            public string TaskId
			{
				get
				{
					return result.TaskId;
				}
				set
				{
					SetTaskId(value);
				}
			}

			// Token: 0x06000767 RID: 1895 RVA: 0x00011DFE File Offset: 0x0000FFFE
			public Builder SetTaskId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasTaskId = true;
				result.taskId_ = value;
				return this;
			}

			// Token: 0x06000768 RID: 1896 RVA: 0x00011E2B File Offset: 0x0001002B
			public Builder ClearTaskId()
			{
				PrepareBuilder();
				result.HasTaskId = false;
				result.taskId_ = "";
				return this;
			}

            // Token: 0x17000304 RID: 772
            // (get) Token: 0x06000769 RID: 1897 RVA: 0x00011E51 File Offset: 0x00010051
            public bool HasMessageId => result.HasMessageId;

            // Token: 0x17000305 RID: 773
            // (get) Token: 0x0600076A RID: 1898 RVA: 0x00011E5E File Offset: 0x0001005E
            // (set) Token: 0x0600076B RID: 1899 RVA: 0x00011E6B File Offset: 0x0001006B
            public string MessageId
			{
				get
				{
					return result.MessageId;
				}
				set
				{
					SetMessageId(value);
				}
			}

			// Token: 0x0600076C RID: 1900 RVA: 0x00011E75 File Offset: 0x00010075
			public Builder SetMessageId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasMessageId = true;
				result.messageId_ = value;
				return this;
			}

			// Token: 0x0600076D RID: 1901 RVA: 0x00011EA2 File Offset: 0x000100A2
			public Builder ClearMessageId()
			{
				PrepareBuilder();
				result.HasMessageId = false;
				result.messageId_ = "";
				return this;
			}

            // Token: 0x17000306 RID: 774
            // (get) Token: 0x0600076E RID: 1902 RVA: 0x00011EC8 File Offset: 0x000100C8
            public bool HasSeqId => result.HasSeqId;

            // Token: 0x17000307 RID: 775
            // (get) Token: 0x0600076F RID: 1903 RVA: 0x00011ED5 File Offset: 0x000100D5
            // (set) Token: 0x06000770 RID: 1904 RVA: 0x00011EE2 File Offset: 0x000100E2
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

			// Token: 0x06000771 RID: 1905 RVA: 0x00011EEC File Offset: 0x000100EC
			public Builder SetSeqId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasSeqId = true;
				result.seqId_ = value;
				return this;
			}

			// Token: 0x06000772 RID: 1906 RVA: 0x00011F19 File Offset: 0x00010119
			public Builder ClearSeqId()
			{
				PrepareBuilder();
				result.HasSeqId = false;
				result.seqId_ = "";
				return this;
			}

            // Token: 0x17000308 RID: 776
            // (get) Token: 0x06000773 RID: 1907 RVA: 0x00011F3F File Offset: 0x0001013F
            public bool HasTarget => result.HasTarget;

            // Token: 0x17000309 RID: 777
            // (get) Token: 0x06000774 RID: 1908 RVA: 0x00011F4C File Offset: 0x0001014C
            // (set) Token: 0x06000775 RID: 1909 RVA: 0x00011F59 File Offset: 0x00010159
            public string Target
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

			// Token: 0x06000776 RID: 1910 RVA: 0x00011F63 File Offset: 0x00010163
			public Builder SetTarget(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasTarget = true;
				result.target_ = value;
				return this;
			}

			// Token: 0x06000777 RID: 1911 RVA: 0x00011F90 File Offset: 0x00010190
			public Builder ClearTarget()
			{
				PrepareBuilder();
				result.HasTarget = false;
				result.target_ = "";
				return this;
			}

            // Token: 0x1700030A RID: 778
            // (get) Token: 0x06000778 RID: 1912 RVA: 0x00011FB6 File Offset: 0x000101B6
            public bool HasInfo => result.HasInfo;

            // Token: 0x1700030B RID: 779
            // (get) Token: 0x06000779 RID: 1913 RVA: 0x00011FC3 File Offset: 0x000101C3
            // (set) Token: 0x0600077A RID: 1914 RVA: 0x00011FD0 File Offset: 0x000101D0
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

			// Token: 0x0600077B RID: 1915 RVA: 0x00011FDA File Offset: 0x000101DA
			public Builder SetInfo(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasInfo = true;
				result.info_ = value;
				return this;
			}

			// Token: 0x0600077C RID: 1916 RVA: 0x00012007 File Offset: 0x00010207
			public Builder ClearInfo()
			{
				PrepareBuilder();
				result.HasInfo = false;
				result.info_ = "";
				return this;
			}

            // Token: 0x1700030C RID: 780
            // (get) Token: 0x0600077D RID: 1917 RVA: 0x0001202D File Offset: 0x0001022D
            public bool HasTraceId => result.HasTraceId;

            // Token: 0x1700030D RID: 781
            // (get) Token: 0x0600077E RID: 1918 RVA: 0x0001203A File Offset: 0x0001023A
            // (set) Token: 0x0600077F RID: 1919 RVA: 0x00012047 File Offset: 0x00010247
            public string TraceId
			{
				get
				{
					return result.TraceId;
				}
				set
				{
					SetTraceId(value);
				}
			}

			// Token: 0x06000780 RID: 1920 RVA: 0x00012051 File Offset: 0x00010251
			public Builder SetTraceId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasTraceId = true;
				result.traceId_ = value;
				return this;
			}

			// Token: 0x06000781 RID: 1921 RVA: 0x0001207E File Offset: 0x0001027E
			public Builder ClearTraceId()
			{
				PrepareBuilder();
				result.HasTraceId = false;
				result.traceId_ = "";
				return this;
			}

            // Token: 0x1700030E RID: 782
            // (get) Token: 0x06000782 RID: 1922 RVA: 0x000120A4 File Offset: 0x000102A4
            public bool HasBatchId => result.HasBatchId;

            // Token: 0x1700030F RID: 783
            // (get) Token: 0x06000783 RID: 1923 RVA: 0x000120B1 File Offset: 0x000102B1
            // (set) Token: 0x06000784 RID: 1924 RVA: 0x000120BE File Offset: 0x000102BE
            public string BatchId
			{
				get
				{
					return result.BatchId;
				}
				set
				{
					SetBatchId(value);
				}
			}

			// Token: 0x06000785 RID: 1925 RVA: 0x000120C8 File Offset: 0x000102C8
			public Builder SetBatchId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasBatchId = true;
				result.batchId_ = value;
				return this;
			}

			// Token: 0x06000786 RID: 1926 RVA: 0x000120F5 File Offset: 0x000102F5
			public Builder ClearBatchId()
			{
				PrepareBuilder();
				result.HasBatchId = false;
				result.batchId_ = "";
				return this;
			}

			// Token: 0x040003BF RID: 959
			private bool resultIsReadOnly;

			// Token: 0x040003C0 RID: 960
			private PushResult result;
		}
	}
}
