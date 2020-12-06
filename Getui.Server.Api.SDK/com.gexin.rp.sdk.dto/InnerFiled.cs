using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    // Token: 0x02000021 RID: 33
    [DebuggerNonUserCode]
	public sealed class InnerFiled : GeneratedMessage<InnerFiled, InnerFiled.Builder>
	{
		// Token: 0x060003E6 RID: 998 RVA: 0x0000883E File Offset: 0x00006A3E
		private InnerFiled()
		{
		}

        // Token: 0x170001FA RID: 506
        // (get) Token: 0x060003E7 RID: 999 RVA: 0x00008863 File Offset: 0x00006A63
        public static InnerFiled DefaultInstance { get; } = new InnerFiled().MakeReadOnly();

        // Token: 0x170001FB RID: 507
        // (get) Token: 0x060003E8 RID: 1000 RVA: 0x0000886A File Offset: 0x00006A6A
        public override InnerFiled DefaultInstanceForType => DefaultInstance;

        // Token: 0x170001FC RID: 508
        // (get) Token: 0x060003E9 RID: 1001 RVA: 0x00008871 File Offset: 0x00006A71
        protected override InnerFiled ThisMessage => this;

        // Token: 0x170001FD RID: 509
        // (get) Token: 0x060003EA RID: 1002 RVA: 0x00008874 File Offset: 0x00006A74
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_InnerFiled__Descriptor;

        // Token: 0x170001FE RID: 510
        // (get) Token: 0x060003EB RID: 1003 RVA: 0x0000887B File Offset: 0x00006A7B
        protected override FieldAccessorTable<InnerFiled, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_InnerFiled__FieldAccessorTable;

        // Token: 0x170001FF RID: 511
        // (get) Token: 0x060003EC RID: 1004 RVA: 0x00008882 File Offset: 0x00006A82
        public bool HasKey { get; private set; }

        // Token: 0x17000200 RID: 512
        // (get) Token: 0x060003ED RID: 1005 RVA: 0x0000888A File Offset: 0x00006A8A
        public string Key => key_;

        // Token: 0x17000201 RID: 513
        // (get) Token: 0x060003EE RID: 1006 RVA: 0x00008892 File Offset: 0x00006A92
        public bool HasVal { get; private set; }

        // Token: 0x17000202 RID: 514
        // (get) Token: 0x060003EF RID: 1007 RVA: 0x0000889A File Offset: 0x00006A9A
        public string Val => val_;

        // Token: 0x17000203 RID: 515
        // (get) Token: 0x060003F0 RID: 1008 RVA: 0x000088A2 File Offset: 0x00006AA2
        public bool HasType { get; private set; }

        // Token: 0x17000204 RID: 516
        // (get) Token: 0x060003F1 RID: 1009 RVA: 0x000088AA File Offset: 0x00006AAA
        public Types.Type Type => type_;

        // Token: 0x17000205 RID: 517
        // (get) Token: 0x060003F2 RID: 1010 RVA: 0x000088B2 File Offset: 0x00006AB2
        public override bool IsInitialized => HasKey && HasVal && HasType;

        // Token: 0x060003F3 RID: 1011 RVA: 0x000088D4 File Offset: 0x00006AD4
        public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] innerFiledFieldNames = _innerFiledFieldNames;
			if (HasKey)
			{
				output.WriteString(1, innerFiledFieldNames[0], Key);
			}
			if (HasVal)
			{
				output.WriteString(2, innerFiledFieldNames[2], Val);
			}
			if (HasType)
			{
				output.WriteEnum(3, innerFiledFieldNames[1], (int)Type, Type);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00008950 File Offset: 0x00006B50
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
				if (HasKey)
				{
					num += CodedOutputStream.ComputeStringSize(1, Key);
				}
				if (HasVal)
				{
					num += CodedOutputStream.ComputeStringSize(2, Val);
				}
				if (HasType)
				{
					num += CodedOutputStream.ComputeEnumSize(3, (int)Type);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000089C7 File Offset: 0x00006BC7
		public static InnerFiled ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000089D9 File Offset: 0x00006BD9
		public static InnerFiled ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x000089EC File Offset: 0x00006BEC
		public static InnerFiled ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x000089FE File Offset: 0x00006BFE
		public static InnerFiled ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00008A11 File Offset: 0x00006C11
		public static InnerFiled ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00008A23 File Offset: 0x00006C23
		public static InnerFiled ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00008A36 File Offset: 0x00006C36
		public static InnerFiled ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00008A48 File Offset: 0x00006C48
		public static InnerFiled ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00008A5B File Offset: 0x00006C5B
		public static InnerFiled ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00008A6D File Offset: 0x00006C6D
		public static InnerFiled ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00008A80 File Offset: 0x00006C80
		private InnerFiled MakeReadOnly()
		{
			return this;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00008A83 File Offset: 0x00006C83
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00008A8A File Offset: 0x00006C8A
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00008A92 File Offset: 0x00006C92
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00008A99 File Offset: 0x00006C99
		public static Builder CreateBuilder(InnerFiled prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00008AA4 File Offset: 0x00006CA4
		static InnerFiled()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x04000296 RID: 662
        private static readonly string[] _innerFiledFieldNames = new string[]
		{
			"key",
			"type",
			"val"
		};

		// Token: 0x04000297 RID: 663
		private static readonly uint[] _innerFiledFieldTags = new uint[]
		{
			10U,
			24U,
			18U
		};

		// Token: 0x04000298 RID: 664
		public const int KeyFieldNumber = 1;

        // Token: 0x0400029A RID: 666
        private string key_ = "";

		// Token: 0x0400029B RID: 667
		public const int ValFieldNumber = 2;

        // Token: 0x0400029D RID: 669
        private string val_ = "";

		// Token: 0x0400029E RID: 670
		public const int TypeFieldNumber = 3;

        // Token: 0x040002A0 RID: 672
        private Types.Type type_;

		// Token: 0x040002A1 RID: 673
		private int memoizedSerializedSize = -1;

		// Token: 0x0200007F RID: 127
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02000098 RID: 152
			public enum Type
			{
				// Token: 0x04000439 RID: 1081
				str,
				// Token: 0x0400043A RID: 1082
				int32,
				// Token: 0x0400043B RID: 1083
				int64,
				// Token: 0x0400043C RID: 1084
				floa,
				// Token: 0x0400043D RID: 1085
				doub,
				// Token: 0x0400043E RID: 1086
				boole
			}
		}

		// Token: 0x02000080 RID: 128
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<InnerFiled, Builder>
		{
            // Token: 0x17000484 RID: 1156
            // (get) Token: 0x06000B95 RID: 2965 RVA: 0x0001B7E8 File Offset: 0x000199E8
            protected override Builder ThisBuilder => this;

            // Token: 0x06000B96 RID: 2966 RVA: 0x0001B7EB File Offset: 0x000199EB
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x06000B97 RID: 2967 RVA: 0x0001B805 File Offset: 0x00019A05
			internal Builder(InnerFiled cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x06000B98 RID: 2968 RVA: 0x0001B81C File Offset: 0x00019A1C
			private InnerFiled PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					InnerFiled other = result;
					result = new InnerFiled();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x17000485 RID: 1157
            // (get) Token: 0x06000B99 RID: 2969 RVA: 0x0001B858 File Offset: 0x00019A58
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x17000486 RID: 1158
            // (get) Token: 0x06000B9A RID: 2970 RVA: 0x0001B865 File Offset: 0x00019A65
            protected override InnerFiled MessageBeingBuilt => PrepareBuilder();

            // Token: 0x06000B9B RID: 2971 RVA: 0x0001B86D File Offset: 0x00019A6D
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x06000B9C RID: 2972 RVA: 0x0001B882 File Offset: 0x00019A82
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x17000487 RID: 1159
            // (get) Token: 0x06000B9D RID: 2973 RVA: 0x0001B8A8 File Offset: 0x00019AA8
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x17000488 RID: 1160
            // (get) Token: 0x06000B9E RID: 2974 RVA: 0x0001B8AF File Offset: 0x00019AAF
            public override InnerFiled DefaultInstanceForType => DefaultInstance;

            // Token: 0x06000B9F RID: 2975 RVA: 0x0001B8B6 File Offset: 0x00019AB6
            public override InnerFiled BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x06000BA0 RID: 2976 RVA: 0x0001B8D9 File Offset: 0x00019AD9
			public override Builder MergeFrom(IMessage other)
			{
				if (other is InnerFiled)
				{
					return MergeFrom((InnerFiled)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x06000BA1 RID: 2977 RVA: 0x0001B8FC File Offset: 0x00019AFC
			public override Builder MergeFrom(InnerFiled other)
			{
				if (other == DefaultInstance)
				{
					return this;
				}
				PrepareBuilder();
				if (other.HasKey)
				{
					Key = other.Key;
				}
				if (other.HasVal)
				{
					Val = other.Val;
				}
				if (other.HasType)
				{
					Type = other.Type;
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x06000BA2 RID: 2978 RVA: 0x0001B964 File Offset: 0x00019B64
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x06000BA3 RID: 2979 RVA: 0x0001B974 File Offset: 0x00019B74
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_innerFiledFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _innerFiledFieldTags[num2];
                    }
                    if (num <= 10U)
                    {
                        if (num == 0U)
                        {
                            throw InvalidProtocolBufferException.InvalidTag();
                        }
                        if (num == 10U)
                        {
                            result.HasKey = input.ReadString(ref result.key_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 18U)
                        {
                            result.HasVal = input.ReadString(ref result.val_);
                            continue;
                        }
                        if (num == 24U)
                        {
                            if (input.ReadEnum(ref result.type_, out object obj))
                            {
                                result.HasType = true;
                                continue;
                            }
                            if (obj is int)
                            {
                                if (builder == null)
                                {
                                    builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                                }
                                builder.MergeVarintField(3, (ulong)((long)((int)obj)));
                                continue;
                            }
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

            // Token: 0x17000489 RID: 1161
            // (get) Token: 0x06000BA4 RID: 2980 RVA: 0x0001BAD4 File Offset: 0x00019CD4
            public bool HasKey => result.HasKey;

            // Token: 0x1700048A RID: 1162
            // (get) Token: 0x06000BA5 RID: 2981 RVA: 0x0001BAE1 File Offset: 0x00019CE1
            // (set) Token: 0x06000BA6 RID: 2982 RVA: 0x0001BAEE File Offset: 0x00019CEE
            public string Key
			{
				get
				{
					return result.Key;
				}
				set
				{
					SetKey(value);
				}
			}

			// Token: 0x06000BA7 RID: 2983 RVA: 0x0001BAF8 File Offset: 0x00019CF8
			public Builder SetKey(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasKey = true;
				result.key_ = value;
				return this;
			}

			// Token: 0x06000BA8 RID: 2984 RVA: 0x0001BB25 File Offset: 0x00019D25
			public Builder ClearKey()
			{
				PrepareBuilder();
				result.HasKey = false;
				result.key_ = "";
				return this;
			}

            // Token: 0x1700048B RID: 1163
            // (get) Token: 0x06000BA9 RID: 2985 RVA: 0x0001BB4B File Offset: 0x00019D4B
            public bool HasVal => result.HasVal;

            // Token: 0x1700048C RID: 1164
            // (get) Token: 0x06000BAA RID: 2986 RVA: 0x0001BB58 File Offset: 0x00019D58
            // (set) Token: 0x06000BAB RID: 2987 RVA: 0x0001BB65 File Offset: 0x00019D65
            public string Val
			{
				get
				{
					return result.Val;
				}
				set
				{
					SetVal(value);
				}
			}

			// Token: 0x06000BAC RID: 2988 RVA: 0x0001BB6F File Offset: 0x00019D6F
			public Builder SetVal(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasVal = true;
				result.val_ = value;
				return this;
			}

			// Token: 0x06000BAD RID: 2989 RVA: 0x0001BB9C File Offset: 0x00019D9C
			public Builder ClearVal()
			{
				PrepareBuilder();
				result.HasVal = false;
				result.val_ = "";
				return this;
			}

            // Token: 0x1700048D RID: 1165
            // (get) Token: 0x06000BAE RID: 2990 RVA: 0x0001BBC2 File Offset: 0x00019DC2
            public bool HasType => result.HasType;

            // Token: 0x1700048E RID: 1166
            // (get) Token: 0x06000BAF RID: 2991 RVA: 0x0001BBCF File Offset: 0x00019DCF
            // (set) Token: 0x06000BB0 RID: 2992 RVA: 0x0001BBDC File Offset: 0x00019DDC
            public Types.Type Type
			{
				get
				{
					return result.Type;
				}
				set
				{
					SetType(value);
				}
			}

			// Token: 0x06000BB1 RID: 2993 RVA: 0x0001BBE6 File Offset: 0x00019DE6
			public Builder SetType(Types.Type value)
			{
				PrepareBuilder();
				result.HasType = true;
				result.type_ = value;
				return this;
			}

			// Token: 0x06000BB2 RID: 2994 RVA: 0x0001BC08 File Offset: 0x00019E08
			public Builder ClearType()
			{
				PrepareBuilder();
				result.HasType = false;
				result.type_ = Types.Type.str;
				return this;
			}

			// Token: 0x040003E9 RID: 1001
			private bool resultIsReadOnly;

			// Token: 0x040003EA RID: 1002
			private InnerFiled result;
		}
	}
}
