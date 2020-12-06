using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    // Token: 0x02000015 RID: 21
    [DebuggerNonUserCode]
	public sealed class EndBatchTask : GeneratedMessage<EndBatchTask, EndBatchTask.Builder>
	{
		// Token: 0x060001D1 RID: 465 RVA: 0x00004B67 File Offset: 0x00002D67
		private EndBatchTask()
		{
		}

        // Token: 0x170000C4 RID: 196
        // (get) Token: 0x060001D2 RID: 466 RVA: 0x00004B8C File Offset: 0x00002D8C
        public static EndBatchTask DefaultInstance { get; } = new EndBatchTask().MakeReadOnly();

        // Token: 0x170000C5 RID: 197
        // (get) Token: 0x060001D3 RID: 467 RVA: 0x00004B93 File Offset: 0x00002D93
        public override EndBatchTask DefaultInstanceForType => DefaultInstance;

        // Token: 0x170000C6 RID: 198
        // (get) Token: 0x060001D4 RID: 468 RVA: 0x00004B9A File Offset: 0x00002D9A
        protected override EndBatchTask ThisMessage => this;

        // Token: 0x170000C7 RID: 199
        // (get) Token: 0x060001D5 RID: 469 RVA: 0x00004B9D File Offset: 0x00002D9D
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_EndBatchTask__Descriptor;

        // Token: 0x170000C8 RID: 200
        // (get) Token: 0x060001D6 RID: 470 RVA: 0x00004BA4 File Offset: 0x00002DA4
        protected override FieldAccessorTable<EndBatchTask, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_EndBatchTask__FieldAccessorTable;

        // Token: 0x170000C9 RID: 201
        // (get) Token: 0x060001D7 RID: 471 RVA: 0x00004BAB File Offset: 0x00002DAB
        public bool HasTaskId { get; private set; }

        // Token: 0x170000CA RID: 202
        // (get) Token: 0x060001D8 RID: 472 RVA: 0x00004BB3 File Offset: 0x00002DB3
        public string TaskId => taskId_;

        // Token: 0x170000CB RID: 203
        // (get) Token: 0x060001D9 RID: 473 RVA: 0x00004BBB File Offset: 0x00002DBB
        public bool HasSeqId { get; private set; }

        // Token: 0x170000CC RID: 204
        // (get) Token: 0x060001DA RID: 474 RVA: 0x00004BC3 File Offset: 0x00002DC3
        public string SeqId => seqId_;

        // Token: 0x170000CD RID: 205
        // (get) Token: 0x060001DB RID: 475 RVA: 0x00004BCB File Offset: 0x00002DCB
        public override bool IsInitialized => HasTaskId;

        // Token: 0x060001DC RID: 476 RVA: 0x00004BD8 File Offset: 0x00002DD8
        public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] endBatchTaskFieldNames = _endBatchTaskFieldNames;
			if (HasTaskId)
			{
				output.WriteString(1, endBatchTaskFieldNames[1], TaskId);
			}
			if (HasSeqId)
			{
				output.WriteString(2, endBatchTaskFieldNames[0], SeqId);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00004C30 File Offset: 0x00002E30
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
				if (HasTaskId)
				{
					num += CodedOutputStream.ComputeStringSize(1, TaskId);
				}
				if (HasSeqId)
				{
					num += CodedOutputStream.ComputeStringSize(2, SeqId);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00004C90 File Offset: 0x00002E90
		public static EndBatchTask ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00004CA2 File Offset: 0x00002EA2
		public static EndBatchTask ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00004CB5 File Offset: 0x00002EB5
		public static EndBatchTask ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00004CC7 File Offset: 0x00002EC7
		public static EndBatchTask ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00004CDA File Offset: 0x00002EDA
		public static EndBatchTask ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00004CEC File Offset: 0x00002EEC
		public static EndBatchTask ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00004CFF File Offset: 0x00002EFF
		public static EndBatchTask ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00004D11 File Offset: 0x00002F11
		public static EndBatchTask ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00004D24 File Offset: 0x00002F24
		public static EndBatchTask ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00004D36 File Offset: 0x00002F36
		public static EndBatchTask ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00004D49 File Offset: 0x00002F49
		private EndBatchTask MakeReadOnly()
		{
			return this;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00004D4C File Offset: 0x00002F4C
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00004D53 File Offset: 0x00002F53
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00004D5B File Offset: 0x00002F5B
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00004D62 File Offset: 0x00002F62
		public static Builder CreateBuilder(EndBatchTask prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00004D6C File Offset: 0x00002F6C
		static EndBatchTask()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x0400011A RID: 282
        private static readonly string[] _endBatchTaskFieldNames = new string[]
		{
			"seqId",
			"taskId"
		};

		// Token: 0x0400011B RID: 283
		private static readonly uint[] _endBatchTaskFieldTags = new uint[]
		{
			18U,
			10U
		};

		// Token: 0x0400011C RID: 284
		public const int TaskIdFieldNumber = 1;

        // Token: 0x0400011E RID: 286
        private string taskId_ = "";

		// Token: 0x0400011F RID: 287
		public const int SeqIdFieldNumber = 2;

        // Token: 0x04000121 RID: 289
        private string seqId_ = "";

		// Token: 0x04000122 RID: 290
		private int memoizedSerializedSize = -1;

		// Token: 0x02000070 RID: 112
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<EndBatchTask, Builder>
		{
            // Token: 0x17000366 RID: 870
            // (get) Token: 0x0600088A RID: 2186 RVA: 0x000147B6 File Offset: 0x000129B6
            protected override Builder ThisBuilder => this;

            // Token: 0x0600088B RID: 2187 RVA: 0x000147B9 File Offset: 0x000129B9
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x0600088C RID: 2188 RVA: 0x000147D3 File Offset: 0x000129D3
			internal Builder(EndBatchTask cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x0600088D RID: 2189 RVA: 0x000147EC File Offset: 0x000129EC
			private EndBatchTask PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					EndBatchTask other = result;
					result = new EndBatchTask();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x17000367 RID: 871
            // (get) Token: 0x0600088E RID: 2190 RVA: 0x00014828 File Offset: 0x00012A28
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x17000368 RID: 872
            // (get) Token: 0x0600088F RID: 2191 RVA: 0x00014835 File Offset: 0x00012A35
            protected override EndBatchTask MessageBeingBuilt => PrepareBuilder();

            // Token: 0x06000890 RID: 2192 RVA: 0x0001483D File Offset: 0x00012A3D
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x06000891 RID: 2193 RVA: 0x00014852 File Offset: 0x00012A52
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x17000369 RID: 873
            // (get) Token: 0x06000892 RID: 2194 RVA: 0x00014878 File Offset: 0x00012A78
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x1700036A RID: 874
            // (get) Token: 0x06000893 RID: 2195 RVA: 0x0001487F File Offset: 0x00012A7F
            public override EndBatchTask DefaultInstanceForType => DefaultInstance;

            // Token: 0x06000894 RID: 2196 RVA: 0x00014886 File Offset: 0x00012A86
            public override EndBatchTask BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x06000895 RID: 2197 RVA: 0x000148A9 File Offset: 0x00012AA9
			public override Builder MergeFrom(IMessage other)
			{
				if (other is EndBatchTask)
				{
					return MergeFrom((EndBatchTask)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x06000896 RID: 2198 RVA: 0x000148CC File Offset: 0x00012ACC
			public override Builder MergeFrom(EndBatchTask other)
			{
				if (other == DefaultInstance)
				{
					return this;
				}
				PrepareBuilder();
				if (other.HasTaskId)
				{
					TaskId = other.TaskId;
				}
				if (other.HasSeqId)
				{
					SeqId = other.SeqId;
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x06000897 RID: 2199 RVA: 0x00014920 File Offset: 0x00012B20
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x06000898 RID: 2200 RVA: 0x00014930 File Offset: 0x00012B30
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_endBatchTaskFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _endBatchTaskFieldTags[num2];
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
                            result.HasSeqId = input.ReadString(ref result.seqId_);
                        }
                    }
                    else
                    {
                        result.HasTaskId = input.ReadString(ref result.taskId_);
                    }
                }
                if (builder != null)
				{
					UnknownFields = builder.Build();
				}
				return this;
			}

            // Token: 0x1700036B RID: 875
            // (get) Token: 0x06000899 RID: 2201 RVA: 0x00014A34 File Offset: 0x00012C34
            public bool HasTaskId => result.HasTaskId;

            // Token: 0x1700036C RID: 876
            // (get) Token: 0x0600089A RID: 2202 RVA: 0x00014A41 File Offset: 0x00012C41
            // (set) Token: 0x0600089B RID: 2203 RVA: 0x00014A4E File Offset: 0x00012C4E
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

			// Token: 0x0600089C RID: 2204 RVA: 0x00014A58 File Offset: 0x00012C58
			public Builder SetTaskId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasTaskId = true;
				result.taskId_ = value;
				return this;
			}

			// Token: 0x0600089D RID: 2205 RVA: 0x00014A85 File Offset: 0x00012C85
			public Builder ClearTaskId()
			{
				PrepareBuilder();
				result.HasTaskId = false;
				result.taskId_ = "";
				return this;
			}

            // Token: 0x1700036D RID: 877
            // (get) Token: 0x0600089E RID: 2206 RVA: 0x00014AAB File Offset: 0x00012CAB
            public bool HasSeqId => result.HasSeqId;

            // Token: 0x1700036E RID: 878
            // (get) Token: 0x0600089F RID: 2207 RVA: 0x00014AB8 File Offset: 0x00012CB8
            // (set) Token: 0x060008A0 RID: 2208 RVA: 0x00014AC5 File Offset: 0x00012CC5
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

			// Token: 0x060008A1 RID: 2209 RVA: 0x00014ACF File Offset: 0x00012CCF
			public Builder SetSeqId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasSeqId = true;
				result.seqId_ = value;
				return this;
			}

			// Token: 0x060008A2 RID: 2210 RVA: 0x00014AFC File Offset: 0x00012CFC
			public Builder ClearSeqId()
			{
				PrepareBuilder();
				result.HasSeqId = false;
				result.seqId_ = "";
				return this;
			}

			// Token: 0x040003D1 RID: 977
			private bool resultIsReadOnly;

			// Token: 0x040003D2 RID: 978
			private EndBatchTask result;
		}
	}
}
