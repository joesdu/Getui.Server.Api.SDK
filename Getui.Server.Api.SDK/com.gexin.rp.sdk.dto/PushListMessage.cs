using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    // Token: 0x02000014 RID: 20
    [DebuggerNonUserCode]
	public sealed class PushListMessage : GeneratedMessage<PushListMessage, PushListMessage.Builder>
	{
		// Token: 0x060001B1 RID: 433 RVA: 0x00004811 File Offset: 0x00002A11
		private PushListMessage()
		{
		}

        // Token: 0x170000B7 RID: 183
        // (get) Token: 0x060001B2 RID: 434 RVA: 0x00004841 File Offset: 0x00002A41
        public static PushListMessage DefaultInstance { get; } = new PushListMessage().MakeReadOnly();

        // Token: 0x170000B8 RID: 184
        // (get) Token: 0x060001B3 RID: 435 RVA: 0x00004848 File Offset: 0x00002A48
        public override PushListMessage DefaultInstanceForType => DefaultInstance;

        // Token: 0x170000B9 RID: 185
        // (get) Token: 0x060001B4 RID: 436 RVA: 0x0000484F File Offset: 0x00002A4F
        protected override PushListMessage ThisMessage => this;

        // Token: 0x170000BA RID: 186
        // (get) Token: 0x060001B5 RID: 437 RVA: 0x00004852 File Offset: 0x00002A52
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_PushListMessage__Descriptor;

        // Token: 0x170000BB RID: 187
        // (get) Token: 0x060001B6 RID: 438 RVA: 0x00004859 File Offset: 0x00002A59
        protected override FieldAccessorTable<PushListMessage, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_PushListMessage__FieldAccessorTable;

        // Token: 0x170000BC RID: 188
        // (get) Token: 0x060001B7 RID: 439 RVA: 0x00004860 File Offset: 0x00002A60
        public bool HasSeqId { get; private set; }

        // Token: 0x170000BD RID: 189
        // (get) Token: 0x060001B8 RID: 440 RVA: 0x00004868 File Offset: 0x00002A68
        public string SeqId => seqId_;

        // Token: 0x170000BE RID: 190
        // (get) Token: 0x060001B9 RID: 441 RVA: 0x00004870 File Offset: 0x00002A70
        public bool HasTaskId { get; private set; }

        // Token: 0x170000BF RID: 191
        // (get) Token: 0x060001BA RID: 442 RVA: 0x00004878 File Offset: 0x00002A78
        public string TaskId => taskId_;

        // Token: 0x170000C0 RID: 192
        // (get) Token: 0x060001BB RID: 443 RVA: 0x00004880 File Offset: 0x00002A80
        public IList<Target> TargetsList => targets_;

        // Token: 0x170000C1 RID: 193
        // (get) Token: 0x060001BC RID: 444 RVA: 0x00004888 File Offset: 0x00002A88
        public int TargetsCount => targets_.Count;

        // Token: 0x060001BD RID: 445 RVA: 0x00004895 File Offset: 0x00002A95
        public Target GetTargets(int index)
		{
			return targets_[index];
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060001BE RID: 446 RVA: 0x000048A4 File Offset: 0x00002AA4
		public override bool IsInitialized
		{
			get
			{
				if (!HasSeqId)
				{
					return false;
				}
				if (!HasTaskId)
				{
					return false;
				}
				using (IEnumerator<Target> enumerator = TargetsList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (!enumerator.Current.IsInitialized)
						{
							return false;
						}
					}
				}
				return true;
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000490C File Offset: 0x00002B0C
		public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] pushListMessageFieldNames = _pushListMessageFieldNames;
			if (HasSeqId)
			{
				output.WriteString(1, pushListMessageFieldNames[0], SeqId);
			}
			if (HasTaskId)
			{
				output.WriteString(2, pushListMessageFieldNames[2], TaskId);
			}
			if (targets_.Count > 0)
			{
				output.WriteMessageArray(3, pushListMessageFieldNames[1], targets_);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00004980 File Offset: 0x00002B80
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
				if (HasTaskId)
				{
					num += CodedOutputStream.ComputeStringSize(2, TaskId);
				}
				foreach (Target value in TargetsList)
				{
					num += CodedOutputStream.ComputeMessageSize(3, value);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00004A24 File Offset: 0x00002C24
		public static PushListMessage ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00004A36 File Offset: 0x00002C36
		public static PushListMessage ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00004A49 File Offset: 0x00002C49
		public static PushListMessage ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00004A5B File Offset: 0x00002C5B
		public static PushListMessage ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00004A6E File Offset: 0x00002C6E
		public static PushListMessage ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00004A80 File Offset: 0x00002C80
		public static PushListMessage ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00004A93 File Offset: 0x00002C93
		public static PushListMessage ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00004AA5 File Offset: 0x00002CA5
		public static PushListMessage ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00004AB8 File Offset: 0x00002CB8
		public static PushListMessage ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00004ACA File Offset: 0x00002CCA
		public static PushListMessage ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00004ADD File Offset: 0x00002CDD
		private PushListMessage MakeReadOnly()
		{
			targets_.MakeReadOnly();
			return this;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00004AEB File Offset: 0x00002CEB
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00004AF2 File Offset: 0x00002CF2
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00004AFA File Offset: 0x00002CFA
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00004B01 File Offset: 0x00002D01
		public static Builder CreateBuilder(PushListMessage prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00004B0C File Offset: 0x00002D0C
		static PushListMessage()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x0400010E RID: 270
        private static readonly string[] _pushListMessageFieldNames = new string[]
		{
			"seqId",
			"targets",
			"taskId"
		};

		// Token: 0x0400010F RID: 271
		private static readonly uint[] _pushListMessageFieldTags = new uint[]
		{
			10U,
			26U,
			18U
		};

		// Token: 0x04000110 RID: 272
		public const int SeqIdFieldNumber = 1;

        // Token: 0x04000112 RID: 274
        private string seqId_ = "";

		// Token: 0x04000113 RID: 275
		public const int TaskIdFieldNumber = 2;

        // Token: 0x04000115 RID: 277
        private string taskId_ = "";

		// Token: 0x04000116 RID: 278
		public const int TargetsFieldNumber = 3;

		// Token: 0x04000117 RID: 279
		private PopsicleList<Target> targets_ = new PopsicleList<Target>();

		// Token: 0x04000118 RID: 280
		private int memoizedSerializedSize = -1;

		// Token: 0x0200006F RID: 111
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<PushListMessage, Builder>
		{
            // Token: 0x1700035B RID: 859
            // (get) Token: 0x06000868 RID: 2152 RVA: 0x000142FE File Offset: 0x000124FE
            protected override Builder ThisBuilder => this;

            // Token: 0x06000869 RID: 2153 RVA: 0x00014301 File Offset: 0x00012501
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x0600086A RID: 2154 RVA: 0x0001431B File Offset: 0x0001251B
			internal Builder(PushListMessage cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x0600086B RID: 2155 RVA: 0x00014334 File Offset: 0x00012534
			private PushListMessage PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					PushListMessage other = result;
					result = new PushListMessage();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x1700035C RID: 860
            // (get) Token: 0x0600086C RID: 2156 RVA: 0x00014370 File Offset: 0x00012570
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x1700035D RID: 861
            // (get) Token: 0x0600086D RID: 2157 RVA: 0x0001437D File Offset: 0x0001257D
            protected override PushListMessage MessageBeingBuilt => PrepareBuilder();

            // Token: 0x0600086E RID: 2158 RVA: 0x00014385 File Offset: 0x00012585
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x0600086F RID: 2159 RVA: 0x0001439A File Offset: 0x0001259A
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x1700035E RID: 862
            // (get) Token: 0x06000870 RID: 2160 RVA: 0x000143C0 File Offset: 0x000125C0
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x1700035F RID: 863
            // (get) Token: 0x06000871 RID: 2161 RVA: 0x000143C7 File Offset: 0x000125C7
            public override PushListMessage DefaultInstanceForType => DefaultInstance;

            // Token: 0x06000872 RID: 2162 RVA: 0x000143CE File Offset: 0x000125CE
            public override PushListMessage BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x06000873 RID: 2163 RVA: 0x000143F1 File Offset: 0x000125F1
			public override Builder MergeFrom(IMessage other)
			{
				if (other is PushListMessage)
				{
					return MergeFrom((PushListMessage)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x06000874 RID: 2164 RVA: 0x00014414 File Offset: 0x00012614
			public override Builder MergeFrom(PushListMessage other)
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
				if (other.HasTaskId)
				{
					TaskId = other.TaskId;
				}
				if (other.targets_.Count != 0)
				{
					result.targets_.Add(other.targets_);
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x06000875 RID: 2165 RVA: 0x0001448B File Offset: 0x0001268B
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x06000876 RID: 2166 RVA: 0x0001449C File Offset: 0x0001269C
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_pushListMessageFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _pushListMessageFieldTags[num2];
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
                            result.HasTaskId = input.ReadString(ref result.taskId_);
                            continue;
                        }
                        if (num == 26U)
                        {
                            input.ReadMessageArray(num, text, result.targets_, Target.DefaultInstance, extensionRegistry);
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

            // Token: 0x17000360 RID: 864
            // (get) Token: 0x06000877 RID: 2167 RVA: 0x000145C7 File Offset: 0x000127C7
            public bool HasSeqId => result.HasSeqId;

            // Token: 0x17000361 RID: 865
            // (get) Token: 0x06000878 RID: 2168 RVA: 0x000145D4 File Offset: 0x000127D4
            // (set) Token: 0x06000879 RID: 2169 RVA: 0x000145E1 File Offset: 0x000127E1
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

			// Token: 0x0600087A RID: 2170 RVA: 0x000145EB File Offset: 0x000127EB
			public Builder SetSeqId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasSeqId = true;
				result.seqId_ = value;
				return this;
			}

			// Token: 0x0600087B RID: 2171 RVA: 0x00014618 File Offset: 0x00012818
			public Builder ClearSeqId()
			{
				PrepareBuilder();
				result.HasSeqId = false;
				result.seqId_ = "";
				return this;
			}

            // Token: 0x17000362 RID: 866
            // (get) Token: 0x0600087C RID: 2172 RVA: 0x0001463E File Offset: 0x0001283E
            public bool HasTaskId => result.HasTaskId;

            // Token: 0x17000363 RID: 867
            // (get) Token: 0x0600087D RID: 2173 RVA: 0x0001464B File Offset: 0x0001284B
            // (set) Token: 0x0600087E RID: 2174 RVA: 0x00014658 File Offset: 0x00012858
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

			// Token: 0x0600087F RID: 2175 RVA: 0x00014662 File Offset: 0x00012862
			public Builder SetTaskId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasTaskId = true;
				result.taskId_ = value;
				return this;
			}

			// Token: 0x06000880 RID: 2176 RVA: 0x0001468F File Offset: 0x0001288F
			public Builder ClearTaskId()
			{
				PrepareBuilder();
				result.HasTaskId = false;
				result.taskId_ = "";
				return this;
			}

            // Token: 0x17000364 RID: 868
            // (get) Token: 0x06000881 RID: 2177 RVA: 0x000146B5 File Offset: 0x000128B5
            public IPopsicleList<Target> TargetsList => PrepareBuilder().targets_;

            // Token: 0x17000365 RID: 869
            // (get) Token: 0x06000882 RID: 2178 RVA: 0x000146C2 File Offset: 0x000128C2
            public int TargetsCount => result.TargetsCount;

            // Token: 0x06000883 RID: 2179 RVA: 0x000146CF File Offset: 0x000128CF
            public Target GetTargets(int index)
			{
				return result.GetTargets(index);
			}

			// Token: 0x06000884 RID: 2180 RVA: 0x000146DD File Offset: 0x000128DD
			public Builder SetTargets(int index, Target value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.targets_[index] = value;
				return this;
			}

			// Token: 0x06000885 RID: 2181 RVA: 0x00014704 File Offset: 0x00012904
			public Builder SetTargets(int index, Target.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.targets_[index] = builderForValue.Build();
				return this;
			}

			// Token: 0x06000886 RID: 2182 RVA: 0x00014730 File Offset: 0x00012930
			public Builder AddTargets(Target value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.targets_.Add(value);
				return this;
			}

			// Token: 0x06000887 RID: 2183 RVA: 0x00014756 File Offset: 0x00012956
			public Builder AddTargets(Target.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.targets_.Add(builderForValue.Build());
				return this;
			}

			// Token: 0x06000888 RID: 2184 RVA: 0x00014781 File Offset: 0x00012981
			public Builder AddRangeTargets(IEnumerable<Target> values)
			{
				PrepareBuilder();
				result.targets_.Add(values);
				return this;
			}

			// Token: 0x06000889 RID: 2185 RVA: 0x0001479C File Offset: 0x0001299C
			public Builder ClearTargets()
			{
				PrepareBuilder();
				result.targets_.Clear();
				return this;
			}

			// Token: 0x040003CF RID: 975
			private bool resultIsReadOnly;

			// Token: 0x040003D0 RID: 976
			private PushListMessage result;
		}
	}
}
