using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    // Token: 0x02000007 RID: 7
    [DebuggerNonUserCode]
	public sealed class GtAuth : GeneratedMessage<GtAuth, GtAuth.Builder>
	{
		// Token: 0x06000011 RID: 17 RVA: 0x000020E1 File Offset: 0x000002E1
		private GtAuth()
		{
		}

        // Token: 0x17000006 RID: 6
        // (get) Token: 0x06000012 RID: 18 RVA: 0x00002111 File Offset: 0x00000311
        public static GtAuth DefaultInstance { get; } = new GtAuth().MakeReadOnly();

        // Token: 0x17000007 RID: 7
        // (get) Token: 0x06000013 RID: 19 RVA: 0x00002118 File Offset: 0x00000318
        public override GtAuth DefaultInstanceForType => DefaultInstance;

        // Token: 0x17000008 RID: 8
        // (get) Token: 0x06000014 RID: 20 RVA: 0x0000211F File Offset: 0x0000031F
        protected override GtAuth ThisMessage => this;

        // Token: 0x17000009 RID: 9
        // (get) Token: 0x06000015 RID: 21 RVA: 0x00002122 File Offset: 0x00000322
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_GtAuth__Descriptor;

        // Token: 0x1700000A RID: 10
        // (get) Token: 0x06000016 RID: 22 RVA: 0x00002129 File Offset: 0x00000329
        protected override FieldAccessorTable<GtAuth, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_GtAuth__FieldAccessorTable;

        // Token: 0x1700000B RID: 11
        // (get) Token: 0x06000017 RID: 23 RVA: 0x00002130 File Offset: 0x00000330
        public bool HasSign { get; private set; }

        // Token: 0x1700000C RID: 12
        // (get) Token: 0x06000018 RID: 24 RVA: 0x00002138 File Offset: 0x00000338
        public string Sign => sign_;

        // Token: 0x1700000D RID: 13
        // (get) Token: 0x06000019 RID: 25 RVA: 0x00002140 File Offset: 0x00000340
        public bool HasAppkey { get; private set; }

        // Token: 0x1700000E RID: 14
        // (get) Token: 0x0600001A RID: 26 RVA: 0x00002148 File Offset: 0x00000348
        public string Appkey => appkey_;

        // Token: 0x1700000F RID: 15
        // (get) Token: 0x0600001B RID: 27 RVA: 0x00002150 File Offset: 0x00000350
        public bool HasTimestamp { get; private set; }

        // Token: 0x17000010 RID: 16
        // (get) Token: 0x0600001C RID: 28 RVA: 0x00002158 File Offset: 0x00000358
        public long Timestamp => timestamp_;

        // Token: 0x17000011 RID: 17
        // (get) Token: 0x0600001D RID: 29 RVA: 0x00002160 File Offset: 0x00000360
        public bool HasSeqId { get; private set; }

        // Token: 0x17000012 RID: 18
        // (get) Token: 0x0600001E RID: 30 RVA: 0x00002168 File Offset: 0x00000368
        public string SeqId => seqId_;

        // Token: 0x17000013 RID: 19
        // (get) Token: 0x0600001F RID: 31 RVA: 0x00002170 File Offset: 0x00000370
        public override bool IsInitialized => HasSign && HasAppkey && HasTimestamp;

        // Token: 0x06000020 RID: 32 RVA: 0x00002194 File Offset: 0x00000394
        public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] gtAuthFieldNames = _gtAuthFieldNames;
			if (HasSign)
			{
				output.WriteString(1, gtAuthFieldNames[2], Sign);
			}
			if (HasAppkey)
			{
				output.WriteString(2, gtAuthFieldNames[0], Appkey);
			}
			if (HasTimestamp)
			{
				output.WriteInt64(3, gtAuthFieldNames[3], Timestamp);
			}
			if (HasSeqId)
			{
				output.WriteString(4, gtAuthFieldNames[1], SeqId);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000021 RID: 33 RVA: 0x0000221C File Offset: 0x0000041C
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
				if (HasSign)
				{
					num += CodedOutputStream.ComputeStringSize(1, Sign);
				}
				if (HasAppkey)
				{
					num += CodedOutputStream.ComputeStringSize(2, Appkey);
				}
				if (HasTimestamp)
				{
					num += CodedOutputStream.ComputeInt64Size(3, Timestamp);
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

		// Token: 0x06000022 RID: 34 RVA: 0x000022AA File Offset: 0x000004AA
		public static GtAuth ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000022BC File Offset: 0x000004BC
		public static GtAuth ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000022CF File Offset: 0x000004CF
		public static GtAuth ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000022E1 File Offset: 0x000004E1
		public static GtAuth ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000022F4 File Offset: 0x000004F4
		public static GtAuth ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002306 File Offset: 0x00000506
		public static GtAuth ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002319 File Offset: 0x00000519
		public static GtAuth ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000232B File Offset: 0x0000052B
		public static GtAuth ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000233E File Offset: 0x0000053E
		public static GtAuth ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002350 File Offset: 0x00000550
		public static GtAuth ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002363 File Offset: 0x00000563
		private GtAuth MakeReadOnly()
		{
			return this;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002366 File Offset: 0x00000566
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000236D File Offset: 0x0000056D
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002375 File Offset: 0x00000575
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000237C File Offset: 0x0000057C
		public static Builder CreateBuilder(GtAuth prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002384 File Offset: 0x00000584
		static GtAuth()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x0400005E RID: 94
        private static readonly string[] _gtAuthFieldNames = new string[]
		{
			"appkey",
			"seqId",
			"sign",
			"timestamp"
		};

		// Token: 0x0400005F RID: 95
		private static readonly uint[] _gtAuthFieldTags = new uint[]
		{
			18U,
			34U,
			10U,
			24U
		};

		// Token: 0x04000060 RID: 96
		public const int SignFieldNumber = 1;

        // Token: 0x04000062 RID: 98
        private string sign_ = "";

		// Token: 0x04000063 RID: 99
		public const int AppkeyFieldNumber = 2;

        // Token: 0x04000065 RID: 101
        private string appkey_ = "";

		// Token: 0x04000066 RID: 102
		public const int TimestampFieldNumber = 3;

        // Token: 0x04000068 RID: 104
        private long timestamp_;

		// Token: 0x04000069 RID: 105
		public const int SeqIdFieldNumber = 4;

        // Token: 0x0400006B RID: 107
        private string seqId_ = "";

		// Token: 0x0400006C RID: 108
		private int memoizedSerializedSize = -1;

		// Token: 0x0200005F RID: 95
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<GtAuth, Builder>
		{
            // Token: 0x170002C4 RID: 708
            // (get) Token: 0x060006B2 RID: 1714 RVA: 0x000103D6 File Offset: 0x0000E5D6
            protected override Builder ThisBuilder => this;

            // Token: 0x060006B3 RID: 1715 RVA: 0x000103D9 File Offset: 0x0000E5D9
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x060006B4 RID: 1716 RVA: 0x000103F3 File Offset: 0x0000E5F3
			internal Builder(GtAuth cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x060006B5 RID: 1717 RVA: 0x0001040C File Offset: 0x0000E60C
			private GtAuth PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					GtAuth other = result;
					result = new GtAuth();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x170002C5 RID: 709
            // (get) Token: 0x060006B6 RID: 1718 RVA: 0x00010448 File Offset: 0x0000E648
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x170002C6 RID: 710
            // (get) Token: 0x060006B7 RID: 1719 RVA: 0x00010455 File Offset: 0x0000E655
            protected override GtAuth MessageBeingBuilt => PrepareBuilder();

            // Token: 0x060006B8 RID: 1720 RVA: 0x0001045D File Offset: 0x0000E65D
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x060006B9 RID: 1721 RVA: 0x00010472 File Offset: 0x0000E672
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x170002C7 RID: 711
            // (get) Token: 0x060006BA RID: 1722 RVA: 0x00010498 File Offset: 0x0000E698
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x170002C8 RID: 712
            // (get) Token: 0x060006BB RID: 1723 RVA: 0x0001049F File Offset: 0x0000E69F
            public override GtAuth DefaultInstanceForType => DefaultInstance;

            // Token: 0x060006BC RID: 1724 RVA: 0x000104A6 File Offset: 0x0000E6A6
            public override GtAuth BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x060006BD RID: 1725 RVA: 0x000104C9 File Offset: 0x0000E6C9
			public override Builder MergeFrom(IMessage other)
			{
				if (other is GtAuth)
				{
					return MergeFrom((GtAuth)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x060006BE RID: 1726 RVA: 0x000104EC File Offset: 0x0000E6EC
			public override Builder MergeFrom(GtAuth other)
			{
				if (other == DefaultInstance)
				{
					return this;
				}
				PrepareBuilder();
				if (other.HasSign)
				{
					Sign = other.Sign;
				}
				if (other.HasAppkey)
				{
					Appkey = other.Appkey;
				}
				if (other.HasTimestamp)
				{
					Timestamp = other.Timestamp;
				}
				if (other.HasSeqId)
				{
					SeqId = other.SeqId;
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x060006BF RID: 1727 RVA: 0x00010568 File Offset: 0x0000E768
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x060006C0 RID: 1728 RVA: 0x00010578 File Offset: 0x0000E778
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_gtAuthFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _gtAuthFieldTags[num2];
                    }
                    if (num <= 10U)
                    {
                        if (num == 0U)
                        {
                            throw InvalidProtocolBufferException.InvalidTag();
                        }
                        if (num == 10U)
                        {
                            result.HasSign = input.ReadString(ref result.sign_);
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
                        if (num == 24U)
                        {
                            result.HasTimestamp = input.ReadInt64(ref result.timestamp_);
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

            // Token: 0x170002C9 RID: 713
            // (get) Token: 0x060006C1 RID: 1729 RVA: 0x000106CF File Offset: 0x0000E8CF
            public bool HasSign => result.HasSign;

            // Token: 0x170002CA RID: 714
            // (get) Token: 0x060006C2 RID: 1730 RVA: 0x000106DC File Offset: 0x0000E8DC
            // (set) Token: 0x060006C3 RID: 1731 RVA: 0x000106E9 File Offset: 0x0000E8E9
            public string Sign
			{
				get
				{
					return result.Sign;
				}
				set
				{
					SetSign(value);
				}
			}

			// Token: 0x060006C4 RID: 1732 RVA: 0x000106F3 File Offset: 0x0000E8F3
			public Builder SetSign(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasSign = true;
				result.sign_ = value;
				return this;
			}

			// Token: 0x060006C5 RID: 1733 RVA: 0x00010720 File Offset: 0x0000E920
			public Builder ClearSign()
			{
				PrepareBuilder();
				result.HasSign = false;
				result.sign_ = "";
				return this;
			}

            // Token: 0x170002CB RID: 715
            // (get) Token: 0x060006C6 RID: 1734 RVA: 0x00010746 File Offset: 0x0000E946
            public bool HasAppkey => result.HasAppkey;

            // Token: 0x170002CC RID: 716
            // (get) Token: 0x060006C7 RID: 1735 RVA: 0x00010753 File Offset: 0x0000E953
            // (set) Token: 0x060006C8 RID: 1736 RVA: 0x00010760 File Offset: 0x0000E960
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

			// Token: 0x060006C9 RID: 1737 RVA: 0x0001076A File Offset: 0x0000E96A
			public Builder SetAppkey(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasAppkey = true;
				result.appkey_ = value;
				return this;
			}

			// Token: 0x060006CA RID: 1738 RVA: 0x00010797 File Offset: 0x0000E997
			public Builder ClearAppkey()
			{
				PrepareBuilder();
				result.HasAppkey = false;
				result.appkey_ = "";
				return this;
			}

            // Token: 0x170002CD RID: 717
            // (get) Token: 0x060006CB RID: 1739 RVA: 0x000107BD File Offset: 0x0000E9BD
            public bool HasTimestamp => result.HasTimestamp;

            // Token: 0x170002CE RID: 718
            // (get) Token: 0x060006CC RID: 1740 RVA: 0x000107CA File Offset: 0x0000E9CA
            // (set) Token: 0x060006CD RID: 1741 RVA: 0x000107D7 File Offset: 0x0000E9D7
            public long Timestamp
			{
				get
				{
					return result.Timestamp;
				}
				set
				{
					SetTimestamp(value);
				}
			}

			// Token: 0x060006CE RID: 1742 RVA: 0x000107E1 File Offset: 0x0000E9E1
			public Builder SetTimestamp(long value)
			{
				PrepareBuilder();
				result.HasTimestamp = true;
				result.timestamp_ = value;
				return this;
			}

			// Token: 0x060006CF RID: 1743 RVA: 0x00010803 File Offset: 0x0000EA03
			public Builder ClearTimestamp()
			{
				PrepareBuilder();
				result.HasTimestamp = false;
				result.timestamp_ = 0L;
				return this;
			}

            // Token: 0x170002CF RID: 719
            // (get) Token: 0x060006D0 RID: 1744 RVA: 0x00010826 File Offset: 0x0000EA26
            public bool HasSeqId => result.HasSeqId;

            // Token: 0x170002D0 RID: 720
            // (get) Token: 0x060006D1 RID: 1745 RVA: 0x00010833 File Offset: 0x0000EA33
            // (set) Token: 0x060006D2 RID: 1746 RVA: 0x00010840 File Offset: 0x0000EA40
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

			// Token: 0x060006D3 RID: 1747 RVA: 0x0001084A File Offset: 0x0000EA4A
			public Builder SetSeqId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasSeqId = true;
				result.seqId_ = value;
				return this;
			}

			// Token: 0x060006D4 RID: 1748 RVA: 0x00010877 File Offset: 0x0000EA77
			public Builder ClearSeqId()
			{
				PrepareBuilder();
				result.HasSeqId = false;
				result.seqId_ = "";
				return this;
			}

			// Token: 0x040003B5 RID: 949
			private bool resultIsReadOnly;

			// Token: 0x040003B6 RID: 950
			private GtAuth result;
		}
	}
}
