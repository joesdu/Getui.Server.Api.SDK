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
    // Token: 0x02000008 RID: 8
    [DebuggerNonUserCode]
	public sealed class GtAuthResult : GeneratedMessage<GtAuthResult, GtAuthResult.Builder>
	{
		// Token: 0x06000032 RID: 50 RVA: 0x000023E7 File Offset: 0x000005E7
		private GtAuthResult()
		{
		}

        // Token: 0x17000015 RID: 21
        // (get) Token: 0x06000033 RID: 51 RVA: 0x00002422 File Offset: 0x00000622
        public static GtAuthResult DefaultInstance { get; } = new GtAuthResult().MakeReadOnly();

        // Token: 0x17000016 RID: 22
        // (get) Token: 0x06000034 RID: 52 RVA: 0x00002429 File Offset: 0x00000629
        public override GtAuthResult DefaultInstanceForType => DefaultInstance;

        // Token: 0x17000017 RID: 23
        // (get) Token: 0x06000035 RID: 53 RVA: 0x00002430 File Offset: 0x00000630
        protected override GtAuthResult ThisMessage => this;

        // Token: 0x17000018 RID: 24
        // (get) Token: 0x06000036 RID: 54 RVA: 0x00002433 File Offset: 0x00000633
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_GtAuthResult__Descriptor;

        // Token: 0x17000019 RID: 25
        // (get) Token: 0x06000037 RID: 55 RVA: 0x0000243A File Offset: 0x0000063A
        protected override FieldAccessorTable<GtAuthResult, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_GtAuthResult__FieldAccessorTable;

        // Token: 0x1700001A RID: 26
        // (get) Token: 0x06000038 RID: 56 RVA: 0x00002441 File Offset: 0x00000641
        public bool HasCode { get; private set; }

        // Token: 0x1700001B RID: 27
        // (get) Token: 0x06000039 RID: 57 RVA: 0x00002449 File Offset: 0x00000649
        public int Code => code_;

        // Token: 0x1700001C RID: 28
        // (get) Token: 0x0600003A RID: 58 RVA: 0x00002451 File Offset: 0x00000651
        public bool HasRedirectAddress { get; private set; }

        // Token: 0x1700001D RID: 29
        // (get) Token: 0x0600003B RID: 59 RVA: 0x00002459 File Offset: 0x00000659
        public string RedirectAddress => redirectAddress_;

        // Token: 0x1700001E RID: 30
        // (get) Token: 0x0600003C RID: 60 RVA: 0x00002461 File Offset: 0x00000661
        public bool HasSeqId { get; private set; }

        // Token: 0x1700001F RID: 31
        // (get) Token: 0x0600003D RID: 61 RVA: 0x00002469 File Offset: 0x00000669
        public string SeqId => seqId_;

        // Token: 0x17000020 RID: 32
        // (get) Token: 0x0600003E RID: 62 RVA: 0x00002471 File Offset: 0x00000671
        public bool HasInfo { get; private set; }

        // Token: 0x17000021 RID: 33
        // (get) Token: 0x0600003F RID: 63 RVA: 0x00002479 File Offset: 0x00000679
        public string Info => info_;

        // Token: 0x17000022 RID: 34
        // (get) Token: 0x06000040 RID: 64 RVA: 0x00002481 File Offset: 0x00000681
        public IList<string> AppidList => Lists.AsReadOnly(appid_);

        // Token: 0x17000023 RID: 35
        // (get) Token: 0x06000041 RID: 65 RVA: 0x0000248E File Offset: 0x0000068E
        public int AppidCount => appid_.Count;

        // Token: 0x06000042 RID: 66 RVA: 0x0000249B File Offset: 0x0000069B
        public string GetAppid(int index)
		{
			return appid_[index];
		}

        // Token: 0x17000024 RID: 36
        // (get) Token: 0x06000043 RID: 67 RVA: 0x000024A9 File Offset: 0x000006A9
        public override bool IsInitialized => HasCode;

        // Token: 0x06000044 RID: 68 RVA: 0x000024B8 File Offset: 0x000006B8
        public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] gtAuthResultFieldNames = _gtAuthResultFieldNames;
			if (HasCode)
			{
				output.WriteInt32(1, gtAuthResultFieldNames[1], Code);
			}
			if (HasRedirectAddress)
			{
				output.WriteString(2, gtAuthResultFieldNames[3], RedirectAddress);
			}
			if (HasSeqId)
			{
				output.WriteString(3, gtAuthResultFieldNames[4], SeqId);
			}
			if (HasInfo)
			{
				output.WriteString(4, gtAuthResultFieldNames[2], Info);
			}
			if (appid_.Count > 0)
			{
				output.WriteStringArray(5, gtAuthResultFieldNames[0], appid_);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000045 RID: 69 RVA: 0x0000255C File Offset: 0x0000075C
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
				if (HasCode)
				{
					num += CodedOutputStream.ComputeInt32Size(1, Code);
				}
				if (HasRedirectAddress)
				{
					num += CodedOutputStream.ComputeStringSize(2, RedirectAddress);
				}
				if (HasSeqId)
				{
					num += CodedOutputStream.ComputeStringSize(3, SeqId);
				}
				if (HasInfo)
				{
					num += CodedOutputStream.ComputeStringSize(4, Info);
				}
				int num2 = 0;
				foreach (string value in AppidList)
				{
					num2 += CodedOutputStream.ComputeStringSizeNoTag(value);
				}
				num += num2;
				num += appid_.Count;
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002640 File Offset: 0x00000840
		public static GtAuthResult ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002652 File Offset: 0x00000852
		public static GtAuthResult ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002665 File Offset: 0x00000865
		public static GtAuthResult ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002677 File Offset: 0x00000877
		public static GtAuthResult ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000268A File Offset: 0x0000088A
		public static GtAuthResult ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000269C File Offset: 0x0000089C
		public static GtAuthResult ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000026AF File Offset: 0x000008AF
		public static GtAuthResult ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000026C1 File Offset: 0x000008C1
		public static GtAuthResult ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000026D4 File Offset: 0x000008D4
		public static GtAuthResult ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000026E6 File Offset: 0x000008E6
		public static GtAuthResult ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000026F9 File Offset: 0x000008F9
		private GtAuthResult MakeReadOnly()
		{
			appid_.MakeReadOnly();
			return this;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002707 File Offset: 0x00000907
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000270E File Offset: 0x0000090E
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002716 File Offset: 0x00000916
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000271D File Offset: 0x0000091D
		public static Builder CreateBuilder(GtAuthResult prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002728 File Offset: 0x00000928
		static GtAuthResult()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x0400006E RID: 110
        private static readonly string[] _gtAuthResultFieldNames = new string[]
		{
			"appid",
			"code",
			"info",
			"redirectAddress",
			"seqId"
		};

		// Token: 0x0400006F RID: 111
		private static readonly uint[] _gtAuthResultFieldTags = new uint[]
		{
			42U,
			8U,
			34U,
			18U,
			26U
		};

		// Token: 0x04000070 RID: 112
		public const int CodeFieldNumber = 1;

        // Token: 0x04000072 RID: 114
        private int code_;

		// Token: 0x04000073 RID: 115
		public const int RedirectAddressFieldNumber = 2;

        // Token: 0x04000075 RID: 117
        private string redirectAddress_ = "";

		// Token: 0x04000076 RID: 118
		public const int SeqIdFieldNumber = 3;

        // Token: 0x04000078 RID: 120
        private string seqId_ = "";

		// Token: 0x04000079 RID: 121
		public const int InfoFieldNumber = 4;

        // Token: 0x0400007B RID: 123
        private string info_ = "";

		// Token: 0x0400007C RID: 124
		public const int AppidFieldNumber = 5;

		// Token: 0x0400007D RID: 125
		private PopsicleList<string> appid_ = new PopsicleList<string>();

		// Token: 0x0400007E RID: 126
		private int memoizedSerializedSize = -1;

		// Token: 0x02000060 RID: 96
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02000092 RID: 146
			public enum GtAuthResultCode
			{
				// Token: 0x04000405 RID: 1029
				successed,
				// Token: 0x04000406 RID: 1030
				failed_noSign,
				// Token: 0x04000407 RID: 1031
				failed_noAppkey,
				// Token: 0x04000408 RID: 1032
				failed_noTimestamp,
				// Token: 0x04000409 RID: 1033
				failed_AuthIllegal,
				// Token: 0x0400040A RID: 1034
				redirect
			}
		}

		// Token: 0x02000061 RID: 97
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<GtAuthResult, Builder>
		{
            // Token: 0x170002D1 RID: 721
            // (get) Token: 0x060006D5 RID: 1749 RVA: 0x0001089D File Offset: 0x0000EA9D
            protected override Builder ThisBuilder => this;

            // Token: 0x060006D6 RID: 1750 RVA: 0x000108A0 File Offset: 0x0000EAA0
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x060006D7 RID: 1751 RVA: 0x000108BA File Offset: 0x0000EABA
			internal Builder(GtAuthResult cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x060006D8 RID: 1752 RVA: 0x000108D0 File Offset: 0x0000EAD0
			private GtAuthResult PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					GtAuthResult other = result;
					result = new GtAuthResult();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x170002D2 RID: 722
            // (get) Token: 0x060006D9 RID: 1753 RVA: 0x0001090C File Offset: 0x0000EB0C
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x170002D3 RID: 723
            // (get) Token: 0x060006DA RID: 1754 RVA: 0x00010919 File Offset: 0x0000EB19
            protected override GtAuthResult MessageBeingBuilt => PrepareBuilder();

            // Token: 0x060006DB RID: 1755 RVA: 0x00010921 File Offset: 0x0000EB21
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x060006DC RID: 1756 RVA: 0x00010936 File Offset: 0x0000EB36
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x170002D4 RID: 724
            // (get) Token: 0x060006DD RID: 1757 RVA: 0x0001095C File Offset: 0x0000EB5C
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x170002D5 RID: 725
            // (get) Token: 0x060006DE RID: 1758 RVA: 0x00010963 File Offset: 0x0000EB63
            public override GtAuthResult DefaultInstanceForType => DefaultInstance;

            // Token: 0x060006DF RID: 1759 RVA: 0x0001096A File Offset: 0x0000EB6A
            public override GtAuthResult BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x060006E0 RID: 1760 RVA: 0x0001098D File Offset: 0x0000EB8D
			public override Builder MergeFrom(IMessage other)
			{
				if (other is GtAuthResult)
				{
					return MergeFrom((GtAuthResult)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x060006E1 RID: 1761 RVA: 0x000109B0 File Offset: 0x0000EBB0
			public override Builder MergeFrom(GtAuthResult other)
			{
				if (other == DefaultInstance)
				{
					return this;
				}
				PrepareBuilder();
				if (other.HasCode)
				{
					Code = other.Code;
				}
				if (other.HasRedirectAddress)
				{
					RedirectAddress = other.RedirectAddress;
				}
				if (other.HasSeqId)
				{
					SeqId = other.SeqId;
				}
				if (other.HasInfo)
				{
					Info = other.Info;
				}
				if (other.appid_.Count != 0)
				{
					result.appid_.Add(other.appid_);
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x060006E2 RID: 1762 RVA: 0x00010A4F File Offset: 0x0000EC4F
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x060006E3 RID: 1763 RVA: 0x00010A60 File Offset: 0x0000EC60
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_gtAuthResultFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _gtAuthResultFieldTags[num2];
                    }
                    if (num <= 18U)
                    {
                        if (num == 0U)
                        {
                            throw InvalidProtocolBufferException.InvalidTag();
                        }
                        if (num == 8U)
                        {
                            result.HasCode = input.ReadInt32(ref result.code_);
                            continue;
                        }
                        if (num == 18U)
                        {
                            result.HasRedirectAddress = input.ReadString(ref result.redirectAddress_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 26U)
                        {
                            result.HasSeqId = input.ReadString(ref result.seqId_);
                            continue;
                        }
                        if (num == 34U)
                        {
                            result.HasInfo = input.ReadString(ref result.info_);
                            continue;
                        }
                        if (num == 42U)
                        {
                            input.ReadStringArray(num, text, result.appid_);
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

            // Token: 0x170002D6 RID: 726
            // (get) Token: 0x060006E4 RID: 1764 RVA: 0x00010BD6 File Offset: 0x0000EDD6
            public bool HasCode => result.HasCode;

            // Token: 0x170002D7 RID: 727
            // (get) Token: 0x060006E5 RID: 1765 RVA: 0x00010BE3 File Offset: 0x0000EDE3
            // (set) Token: 0x060006E6 RID: 1766 RVA: 0x00010BF0 File Offset: 0x0000EDF0
            public int Code
			{
				get
				{
					return result.Code;
				}
				set
				{
					SetCode(value);
				}
			}

			// Token: 0x060006E7 RID: 1767 RVA: 0x00010BFA File Offset: 0x0000EDFA
			public Builder SetCode(int value)
			{
				PrepareBuilder();
				result.HasCode = true;
				result.code_ = value;
				return this;
			}

			// Token: 0x060006E8 RID: 1768 RVA: 0x00010C1C File Offset: 0x0000EE1C
			public Builder ClearCode()
			{
				PrepareBuilder();
				result.HasCode = false;
				result.code_ = 0;
				return this;
			}

            // Token: 0x170002D8 RID: 728
            // (get) Token: 0x060006E9 RID: 1769 RVA: 0x00010C3E File Offset: 0x0000EE3E
            public bool HasRedirectAddress => result.HasRedirectAddress;

            // Token: 0x170002D9 RID: 729
            // (get) Token: 0x060006EA RID: 1770 RVA: 0x00010C4B File Offset: 0x0000EE4B
            // (set) Token: 0x060006EB RID: 1771 RVA: 0x00010C58 File Offset: 0x0000EE58
            public string RedirectAddress
			{
				get
				{
					return result.RedirectAddress;
				}
				set
				{
					SetRedirectAddress(value);
				}
			}

			// Token: 0x060006EC RID: 1772 RVA: 0x00010C62 File Offset: 0x0000EE62
			public Builder SetRedirectAddress(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasRedirectAddress = true;
				result.redirectAddress_ = value;
				return this;
			}

			// Token: 0x060006ED RID: 1773 RVA: 0x00010C8F File Offset: 0x0000EE8F
			public Builder ClearRedirectAddress()
			{
				PrepareBuilder();
				result.HasRedirectAddress = false;
				result.redirectAddress_ = "";
				return this;
			}

            // Token: 0x170002DA RID: 730
            // (get) Token: 0x060006EE RID: 1774 RVA: 0x00010CB5 File Offset: 0x0000EEB5
            public bool HasSeqId => result.HasSeqId;

            // Token: 0x170002DB RID: 731
            // (get) Token: 0x060006EF RID: 1775 RVA: 0x00010CC2 File Offset: 0x0000EEC2
            // (set) Token: 0x060006F0 RID: 1776 RVA: 0x00010CCF File Offset: 0x0000EECF
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

			// Token: 0x060006F1 RID: 1777 RVA: 0x00010CD9 File Offset: 0x0000EED9
			public Builder SetSeqId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasSeqId = true;
				result.seqId_ = value;
				return this;
			}

			// Token: 0x060006F2 RID: 1778 RVA: 0x00010D06 File Offset: 0x0000EF06
			public Builder ClearSeqId()
			{
				PrepareBuilder();
				result.HasSeqId = false;
				result.seqId_ = "";
				return this;
			}

            // Token: 0x170002DC RID: 732
            // (get) Token: 0x060006F3 RID: 1779 RVA: 0x00010D2C File Offset: 0x0000EF2C
            public bool HasInfo => result.HasInfo;

            // Token: 0x170002DD RID: 733
            // (get) Token: 0x060006F4 RID: 1780 RVA: 0x00010D39 File Offset: 0x0000EF39
            // (set) Token: 0x060006F5 RID: 1781 RVA: 0x00010D46 File Offset: 0x0000EF46
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

			// Token: 0x060006F6 RID: 1782 RVA: 0x00010D50 File Offset: 0x0000EF50
			public Builder SetInfo(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasInfo = true;
				result.info_ = value;
				return this;
			}

			// Token: 0x060006F7 RID: 1783 RVA: 0x00010D7D File Offset: 0x0000EF7D
			public Builder ClearInfo()
			{
				PrepareBuilder();
				result.HasInfo = false;
				result.info_ = "";
				return this;
			}

            // Token: 0x170002DE RID: 734
            // (get) Token: 0x060006F8 RID: 1784 RVA: 0x00010DA3 File Offset: 0x0000EFA3
            public IPopsicleList<string> AppidList => PrepareBuilder().appid_;

            // Token: 0x170002DF RID: 735
            // (get) Token: 0x060006F9 RID: 1785 RVA: 0x00010DB0 File Offset: 0x0000EFB0
            public int AppidCount => result.AppidCount;

            // Token: 0x060006FA RID: 1786 RVA: 0x00010DBD File Offset: 0x0000EFBD
            public string GetAppid(int index)
			{
				return result.GetAppid(index);
			}

			// Token: 0x060006FB RID: 1787 RVA: 0x00010DCB File Offset: 0x0000EFCB
			public Builder SetAppid(int index, string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.appid_[index] = value;
				return this;
			}

			// Token: 0x060006FC RID: 1788 RVA: 0x00010DF2 File Offset: 0x0000EFF2
			public Builder AddAppid(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.appid_.Add(value);
				return this;
			}

			// Token: 0x060006FD RID: 1789 RVA: 0x00010E18 File Offset: 0x0000F018
			public Builder AddRangeAppid(IEnumerable<string> values)
			{
				PrepareBuilder();
				result.appid_.Add(values);
				return this;
			}

			// Token: 0x060006FE RID: 1790 RVA: 0x00010E33 File Offset: 0x0000F033
			public Builder ClearAppid()
			{
				PrepareBuilder();
				result.appid_.Clear();
				return this;
			}

			// Token: 0x040003B7 RID: 951
			private bool resultIsReadOnly;

			// Token: 0x040003B8 RID: 952
			private GtAuthResult result;
		}
	}
}
