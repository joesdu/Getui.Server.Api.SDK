using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    // Token: 0x02000016 RID: 22
    [DebuggerNonUserCode]
	public sealed class StopBatchTask : GeneratedMessage<StopBatchTask, StopBatchTask.Builder>
	{
		// Token: 0x060001EE RID: 494 RVA: 0x00004DBE File Offset: 0x00002FBE
		private StopBatchTask()
		{
		}

        // Token: 0x170000CF RID: 207
        // (get) Token: 0x060001EF RID: 495 RVA: 0x00004DF9 File Offset: 0x00002FF9
        public static StopBatchTask DefaultInstance { get; } = new StopBatchTask().MakeReadOnly();

        // Token: 0x170000D0 RID: 208
        // (get) Token: 0x060001F0 RID: 496 RVA: 0x00004E00 File Offset: 0x00003000
        public override StopBatchTask DefaultInstanceForType => DefaultInstance;

        // Token: 0x170000D1 RID: 209
        // (get) Token: 0x060001F1 RID: 497 RVA: 0x00004E07 File Offset: 0x00003007
        protected override StopBatchTask ThisMessage => this;

        // Token: 0x170000D2 RID: 210
        // (get) Token: 0x060001F2 RID: 498 RVA: 0x00004E0A File Offset: 0x0000300A
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_StopBatchTask__Descriptor;

        // Token: 0x170000D3 RID: 211
        // (get) Token: 0x060001F3 RID: 499 RVA: 0x00004E11 File Offset: 0x00003011
        protected override FieldAccessorTable<StopBatchTask, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_StopBatchTask__FieldAccessorTable;

        // Token: 0x170000D4 RID: 212
        // (get) Token: 0x060001F4 RID: 500 RVA: 0x00004E18 File Offset: 0x00003018
        public bool HasTaskId { get; private set; }

        // Token: 0x170000D5 RID: 213
        // (get) Token: 0x060001F5 RID: 501 RVA: 0x00004E20 File Offset: 0x00003020
        public string TaskId => taskId_;

        // Token: 0x170000D6 RID: 214
        // (get) Token: 0x060001F6 RID: 502 RVA: 0x00004E28 File Offset: 0x00003028
        public bool HasAppkey { get; private set; }

        // Token: 0x170000D7 RID: 215
        // (get) Token: 0x060001F7 RID: 503 RVA: 0x00004E30 File Offset: 0x00003030
        public string Appkey => appkey_;

        // Token: 0x170000D8 RID: 216
        // (get) Token: 0x060001F8 RID: 504 RVA: 0x00004E38 File Offset: 0x00003038
        public bool HasAppId { get; private set; }

        // Token: 0x170000D9 RID: 217
        // (get) Token: 0x060001F9 RID: 505 RVA: 0x00004E40 File Offset: 0x00003040
        public string AppId => appId_;

        // Token: 0x170000DA RID: 218
        // (get) Token: 0x060001FA RID: 506 RVA: 0x00004E48 File Offset: 0x00003048
        public bool HasSeqId { get; private set; }

        // Token: 0x170000DB RID: 219
        // (get) Token: 0x060001FB RID: 507 RVA: 0x00004E50 File Offset: 0x00003050
        public string SeqId => seqId_;

        // Token: 0x170000DC RID: 220
        // (get) Token: 0x060001FC RID: 508 RVA: 0x00004E58 File Offset: 0x00003058
        public override bool IsInitialized => HasTaskId && HasAppkey;

        // Token: 0x060001FD RID: 509 RVA: 0x00004E70 File Offset: 0x00003070
        public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] stopBatchTaskFieldNames = _stopBatchTaskFieldNames;
			if (HasTaskId)
			{
				output.WriteString(1, stopBatchTaskFieldNames[3], TaskId);
			}
			if (HasAppkey)
			{
				output.WriteString(2, stopBatchTaskFieldNames[1], Appkey);
			}
			if (HasAppId)
			{
				output.WriteString(3, stopBatchTaskFieldNames[0], AppId);
			}
			if (HasSeqId)
			{
				output.WriteString(4, stopBatchTaskFieldNames[2], SeqId);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00004EF8 File Offset: 0x000030F8
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
				if (HasAppkey)
				{
					num += CodedOutputStream.ComputeStringSize(2, Appkey);
				}
				if (HasAppId)
				{
					num += CodedOutputStream.ComputeStringSize(3, AppId);
				}
				if (HasSeqId)
				{
					num += CodedOutputStream.ComputeStringSize(4, SeqId);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00004F86 File Offset: 0x00003186
		public static StopBatchTask ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00004F98 File Offset: 0x00003198
		public static StopBatchTask ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00004FAB File Offset: 0x000031AB
		public static StopBatchTask ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00004FBD File Offset: 0x000031BD
		public static StopBatchTask ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00004FD0 File Offset: 0x000031D0
		public static StopBatchTask ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00004FE2 File Offset: 0x000031E2
		public static StopBatchTask ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00004FF5 File Offset: 0x000031F5
		public static StopBatchTask ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00005007 File Offset: 0x00003207
		public static StopBatchTask ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000501A File Offset: 0x0000321A
		public static StopBatchTask ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000502C File Offset: 0x0000322C
		public static StopBatchTask ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000503F File Offset: 0x0000323F
		private StopBatchTask MakeReadOnly()
		{
			return this;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00005042 File Offset: 0x00003242
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00005049 File Offset: 0x00003249
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00005051 File Offset: 0x00003251
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00005058 File Offset: 0x00003258
		public static Builder CreateBuilder(StopBatchTask prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00005060 File Offset: 0x00003260
		static StopBatchTask()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x04000124 RID: 292
        private static readonly string[] _stopBatchTaskFieldNames = new string[]
		{
			"appId",
			"appkey",
			"seqId",
			"taskId"
		};

		// Token: 0x04000125 RID: 293
		private static readonly uint[] _stopBatchTaskFieldTags = new uint[]
		{
			26U,
			18U,
			34U,
			10U
		};

		// Token: 0x04000126 RID: 294
		public const int TaskIdFieldNumber = 1;

        // Token: 0x04000128 RID: 296
        private string taskId_ = "";

		// Token: 0x04000129 RID: 297
		public const int AppkeyFieldNumber = 2;

        // Token: 0x0400012B RID: 299
        private string appkey_ = "";

		// Token: 0x0400012C RID: 300
		public const int AppIdFieldNumber = 3;

        // Token: 0x0400012E RID: 302
        private string appId_ = "";

		// Token: 0x0400012F RID: 303
		public const int SeqIdFieldNumber = 4;

        // Token: 0x04000131 RID: 305
        private string seqId_ = "";

		// Token: 0x04000132 RID: 306
		private int memoizedSerializedSize = -1;

		// Token: 0x02000071 RID: 113
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<StopBatchTask, Builder>
		{
            // Token: 0x1700036F RID: 879
            // (get) Token: 0x060008A3 RID: 2211 RVA: 0x00014B22 File Offset: 0x00012D22
            protected override Builder ThisBuilder => this;

            // Token: 0x060008A4 RID: 2212 RVA: 0x00014B25 File Offset: 0x00012D25
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x060008A5 RID: 2213 RVA: 0x00014B3F File Offset: 0x00012D3F
			internal Builder(StopBatchTask cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x060008A6 RID: 2214 RVA: 0x00014B58 File Offset: 0x00012D58
			private StopBatchTask PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					StopBatchTask other = result;
					result = new StopBatchTask();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x17000370 RID: 880
            // (get) Token: 0x060008A7 RID: 2215 RVA: 0x00014B94 File Offset: 0x00012D94
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x17000371 RID: 881
            // (get) Token: 0x060008A8 RID: 2216 RVA: 0x00014BA1 File Offset: 0x00012DA1
            protected override StopBatchTask MessageBeingBuilt => PrepareBuilder();

            // Token: 0x060008A9 RID: 2217 RVA: 0x00014BA9 File Offset: 0x00012DA9
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x060008AA RID: 2218 RVA: 0x00014BBE File Offset: 0x00012DBE
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x17000372 RID: 882
            // (get) Token: 0x060008AB RID: 2219 RVA: 0x00014BE4 File Offset: 0x00012DE4
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x17000373 RID: 883
            // (get) Token: 0x060008AC RID: 2220 RVA: 0x00014BEB File Offset: 0x00012DEB
            public override StopBatchTask DefaultInstanceForType => DefaultInstance;

            // Token: 0x060008AD RID: 2221 RVA: 0x00014BF2 File Offset: 0x00012DF2
            public override StopBatchTask BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x060008AE RID: 2222 RVA: 0x00014C15 File Offset: 0x00012E15
			public override Builder MergeFrom(IMessage other)
			{
				if (other is StopBatchTask)
				{
					return MergeFrom((StopBatchTask)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x060008AF RID: 2223 RVA: 0x00014C38 File Offset: 0x00012E38
			public override Builder MergeFrom(StopBatchTask other)
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
				if (other.HasAppkey)
				{
					Appkey = other.Appkey;
				}
				if (other.HasAppId)
				{
					AppId = other.AppId;
				}
				if (other.HasSeqId)
				{
					SeqId = other.SeqId;
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x060008B0 RID: 2224 RVA: 0x00014CB4 File Offset: 0x00012EB4
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x060008B1 RID: 2225 RVA: 0x00014CC4 File Offset: 0x00012EC4
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_stopBatchTaskFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _stopBatchTaskFieldTags[num2];
                    }
                    if (num <= 10U)
                    {
                        if (num == 0U)
                        {
                            throw InvalidProtocolBufferException.InvalidTag();
                        }
                        if (num == 10U)
                        {
                            result.HasTaskId = input.ReadString(ref result.taskId_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 18U)
                        {
                            result.HasAppkey = input.ReadString(ref result.appkey_);
                            continue;
                        }
                        if (num == 26U)
                        {
                            result.HasAppId = input.ReadString(ref result.appId_);
                            continue;
                        }
                        if (num == 34U)
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

            // Token: 0x17000374 RID: 884
            // (get) Token: 0x060008B2 RID: 2226 RVA: 0x00014E1B File Offset: 0x0001301B
            public bool HasTaskId => result.HasTaskId;

            // Token: 0x17000375 RID: 885
            // (get) Token: 0x060008B3 RID: 2227 RVA: 0x00014E28 File Offset: 0x00013028
            // (set) Token: 0x060008B4 RID: 2228 RVA: 0x00014E35 File Offset: 0x00013035
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

			// Token: 0x060008B5 RID: 2229 RVA: 0x00014E3F File Offset: 0x0001303F
			public Builder SetTaskId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasTaskId = true;
				result.taskId_ = value;
				return this;
			}

			// Token: 0x060008B6 RID: 2230 RVA: 0x00014E6C File Offset: 0x0001306C
			public Builder ClearTaskId()
			{
				PrepareBuilder();
				result.HasTaskId = false;
				result.taskId_ = "";
				return this;
			}

            // Token: 0x17000376 RID: 886
            // (get) Token: 0x060008B7 RID: 2231 RVA: 0x00014E92 File Offset: 0x00013092
            public bool HasAppkey => result.HasAppkey;

            // Token: 0x17000377 RID: 887
            // (get) Token: 0x060008B8 RID: 2232 RVA: 0x00014E9F File Offset: 0x0001309F
            // (set) Token: 0x060008B9 RID: 2233 RVA: 0x00014EAC File Offset: 0x000130AC
            public string Appkey
			{
				get
				{
					return result.Appkey;
				}
				set
				{
					SetAppkey(value);
				}
			}

			// Token: 0x060008BA RID: 2234 RVA: 0x00014EB6 File Offset: 0x000130B6
			public Builder SetAppkey(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasAppkey = true;
				result.appkey_ = value;
				return this;
			}

			// Token: 0x060008BB RID: 2235 RVA: 0x00014EE3 File Offset: 0x000130E3
			public Builder ClearAppkey()
			{
				PrepareBuilder();
				result.HasAppkey = false;
				result.appkey_ = "";
				return this;
			}

            // Token: 0x17000378 RID: 888
            // (get) Token: 0x060008BC RID: 2236 RVA: 0x00014F09 File Offset: 0x00013109
            public bool HasAppId => result.HasAppId;

            // Token: 0x17000379 RID: 889
            // (get) Token: 0x060008BD RID: 2237 RVA: 0x00014F16 File Offset: 0x00013116
            // (set) Token: 0x060008BE RID: 2238 RVA: 0x00014F23 File Offset: 0x00013123
            public string AppId
			{
				get
				{
					return result.AppId;
				}
				set
				{
					SetAppId(value);
				}
			}

			// Token: 0x060008BF RID: 2239 RVA: 0x00014F2D File Offset: 0x0001312D
			public Builder SetAppId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasAppId = true;
				result.appId_ = value;
				return this;
			}

			// Token: 0x060008C0 RID: 2240 RVA: 0x00014F5A File Offset: 0x0001315A
			public Builder ClearAppId()
			{
				PrepareBuilder();
				result.HasAppId = false;
				result.appId_ = "";
				return this;
			}

            // Token: 0x1700037A RID: 890
            // (get) Token: 0x060008C1 RID: 2241 RVA: 0x00014F80 File Offset: 0x00013180
            public bool HasSeqId => result.HasSeqId;

            // Token: 0x1700037B RID: 891
            // (get) Token: 0x060008C2 RID: 2242 RVA: 0x00014F8D File Offset: 0x0001318D
            // (set) Token: 0x060008C3 RID: 2243 RVA: 0x00014F9A File Offset: 0x0001319A
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

			// Token: 0x060008C4 RID: 2244 RVA: 0x00014FA4 File Offset: 0x000131A4
			public Builder SetSeqId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasSeqId = true;
				result.seqId_ = value;
				return this;
			}

			// Token: 0x060008C5 RID: 2245 RVA: 0x00014FD1 File Offset: 0x000131D1
			public Builder ClearSeqId()
			{
				PrepareBuilder();
				result.HasSeqId = false;
				result.seqId_ = "";
				return this;
			}

			// Token: 0x040003D3 RID: 979
			private bool resultIsReadOnly;

			// Token: 0x040003D4 RID: 980
			private StopBatchTask result;
		}
	}
}
