using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    // Token: 0x02000023 RID: 35
    [DebuggerNonUserCode]
	public sealed class Button : GeneratedMessage<Button, Button.Builder>
	{
		// Token: 0x06000424 RID: 1060 RVA: 0x00008DA3 File Offset: 0x00006FA3
		private Button()
		{
		}

        // Token: 0x17000214 RID: 532
        // (get) Token: 0x06000425 RID: 1061 RVA: 0x00008DBD File Offset: 0x00006FBD
        public static Button DefaultInstance { get; } = new Button().MakeReadOnly();

        // Token: 0x17000215 RID: 533
        // (get) Token: 0x06000426 RID: 1062 RVA: 0x00008DC4 File Offset: 0x00006FC4
        public override Button DefaultInstanceForType => DefaultInstance;

        // Token: 0x17000216 RID: 534
        // (get) Token: 0x06000427 RID: 1063 RVA: 0x00008DCB File Offset: 0x00006FCB
        protected override Button ThisMessage => this;

        // Token: 0x17000217 RID: 535
        // (get) Token: 0x06000428 RID: 1064 RVA: 0x00008DCE File Offset: 0x00006FCE
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_Button__Descriptor;

        // Token: 0x17000218 RID: 536
        // (get) Token: 0x06000429 RID: 1065 RVA: 0x00008DD5 File Offset: 0x00006FD5
        protected override FieldAccessorTable<Button, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_Button__FieldAccessorTable;

        // Token: 0x17000219 RID: 537
        // (get) Token: 0x0600042A RID: 1066 RVA: 0x00008DDC File Offset: 0x00006FDC
        public bool HasText { get; private set; }

        // Token: 0x1700021A RID: 538
        // (get) Token: 0x0600042B RID: 1067 RVA: 0x00008DE4 File Offset: 0x00006FE4
        public string Text => text_;

        // Token: 0x1700021B RID: 539
        // (get) Token: 0x0600042C RID: 1068 RVA: 0x00008DEC File Offset: 0x00006FEC
        public bool HasNext { get; private set; }

        // Token: 0x1700021C RID: 540
        // (get) Token: 0x0600042D RID: 1069 RVA: 0x00008DF4 File Offset: 0x00006FF4
        public int Next => next_;

        // Token: 0x1700021D RID: 541
        // (get) Token: 0x0600042E RID: 1070 RVA: 0x00008DFC File Offset: 0x00006FFC
        public override bool IsInitialized => true;

        // Token: 0x0600042F RID: 1071 RVA: 0x00008E00 File Offset: 0x00007000
        public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] buttonFieldNames = _buttonFieldNames;
			if (HasText)
			{
				output.WriteString(1, buttonFieldNames[1], Text);
			}
			if (HasNext)
			{
				output.WriteInt32(2, buttonFieldNames[0], Next);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x00008E58 File Offset: 0x00007058
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
				if (HasText)
				{
					num += CodedOutputStream.ComputeStringSize(1, Text);
				}
				if (HasNext)
				{
					num += CodedOutputStream.ComputeInt32Size(2, Next);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00008EB8 File Offset: 0x000070B8
		public static Button ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00008ECA File Offset: 0x000070CA
		public static Button ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00008EDD File Offset: 0x000070DD
		public static Button ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00008EEF File Offset: 0x000070EF
		public static Button ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00008F02 File Offset: 0x00007102
		public static Button ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00008F14 File Offset: 0x00007114
		public static Button ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00008F27 File Offset: 0x00007127
		public static Button ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00008F39 File Offset: 0x00007139
		public static Button ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00008F4C File Offset: 0x0000714C
		public static Button ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00008F5E File Offset: 0x0000715E
		public static Button ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00008F71 File Offset: 0x00007171
		private Button MakeReadOnly()
		{
			return this;
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00008F74 File Offset: 0x00007174
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00008F7B File Offset: 0x0000717B
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00008F83 File Offset: 0x00007183
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00008F8A File Offset: 0x0000718A
		public static Builder CreateBuilder(Button prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00008F94 File Offset: 0x00007194
		static Button()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x040002B0 RID: 688
        private static readonly string[] _buttonFieldNames = new string[]
		{
			"next",
			"text"
		};

		// Token: 0x040002B1 RID: 689
		private static readonly uint[] _buttonFieldTags = new uint[]
		{
			16U,
			10U
		};

		// Token: 0x040002B2 RID: 690
		public const int TextFieldNumber = 1;

        // Token: 0x040002B4 RID: 692
        private string text_ = "";

		// Token: 0x040002B5 RID: 693
		public const int NextFieldNumber = 2;

        // Token: 0x040002B7 RID: 695
        private int next_;

		// Token: 0x040002B8 RID: 696
		private int memoizedSerializedSize = -1;

		// Token: 0x02000082 RID: 130
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<Button, Builder>
		{
            // Token: 0x1700049A RID: 1178
            // (get) Token: 0x06000BD1 RID: 3025 RVA: 0x0001C04B File Offset: 0x0001A24B
            protected override Builder ThisBuilder => this;

            // Token: 0x06000BD2 RID: 3026 RVA: 0x0001C04E File Offset: 0x0001A24E
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x06000BD3 RID: 3027 RVA: 0x0001C068 File Offset: 0x0001A268
			internal Builder(Button cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x06000BD4 RID: 3028 RVA: 0x0001C080 File Offset: 0x0001A280
			private Button PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					Button other = result;
					result = new Button();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x1700049B RID: 1179
            // (get) Token: 0x06000BD5 RID: 3029 RVA: 0x0001C0BC File Offset: 0x0001A2BC
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x1700049C RID: 1180
            // (get) Token: 0x06000BD6 RID: 3030 RVA: 0x0001C0C9 File Offset: 0x0001A2C9
            protected override Button MessageBeingBuilt => PrepareBuilder();

            // Token: 0x06000BD7 RID: 3031 RVA: 0x0001C0D1 File Offset: 0x0001A2D1
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x06000BD8 RID: 3032 RVA: 0x0001C0E6 File Offset: 0x0001A2E6
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x1700049D RID: 1181
            // (get) Token: 0x06000BD9 RID: 3033 RVA: 0x0001C10C File Offset: 0x0001A30C
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x1700049E RID: 1182
            // (get) Token: 0x06000BDA RID: 3034 RVA: 0x0001C113 File Offset: 0x0001A313
            public override Button DefaultInstanceForType => DefaultInstance;

            // Token: 0x06000BDB RID: 3035 RVA: 0x0001C11A File Offset: 0x0001A31A
            public override Button BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x06000BDC RID: 3036 RVA: 0x0001C13D File Offset: 0x0001A33D
			public override Builder MergeFrom(IMessage other)
			{
				if (other is Button)
				{
					return MergeFrom((Button)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x06000BDD RID: 3037 RVA: 0x0001C160 File Offset: 0x0001A360
			public override Builder MergeFrom(Button other)
			{
				if (other == DefaultInstance)
				{
					return this;
				}
				PrepareBuilder();
				if (other.HasText)
				{
					Text = other.Text;
				}
				if (other.HasNext)
				{
					Next = other.Next;
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x06000BDE RID: 3038 RVA: 0x0001C1B4 File Offset: 0x0001A3B4
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x06000BDF RID: 3039 RVA: 0x0001C1C4 File Offset: 0x0001A3C4
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_buttonFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _buttonFieldTags[num2];
                    }
                    if (num == 0U)
                    {
                        throw InvalidProtocolBufferException.InvalidTag();
                    }
                    if (num != 10U)
                    {
                        if (num != 16U)
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
                            result.HasNext = input.ReadInt32(ref result.next_);
                        }
                    }
                    else
                    {
                        result.HasText = input.ReadString(ref result.text_);
                    }
                }
                if (builder != null)
				{
					UnknownFields = builder.Build();
				}
				return this;
			}

            // Token: 0x1700049F RID: 1183
            // (get) Token: 0x06000BE0 RID: 3040 RVA: 0x0001C2C8 File Offset: 0x0001A4C8
            public bool HasText => result.HasText;

            // Token: 0x170004A0 RID: 1184
            // (get) Token: 0x06000BE1 RID: 3041 RVA: 0x0001C2D5 File Offset: 0x0001A4D5
            // (set) Token: 0x06000BE2 RID: 3042 RVA: 0x0001C2E2 File Offset: 0x0001A4E2
            public string Text
			{
				get
				{
					return result.Text;
				}
				set
				{
					SetText(value);
				}
			}

			// Token: 0x06000BE3 RID: 3043 RVA: 0x0001C2EC File Offset: 0x0001A4EC
			public Builder SetText(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasText = true;
				result.text_ = value;
				return this;
			}

			// Token: 0x06000BE4 RID: 3044 RVA: 0x0001C319 File Offset: 0x0001A519
			public Builder ClearText()
			{
                PrepareBuilder();
				result.HasText = false;
				result.text_ = "";
				return this;
			}

            // Token: 0x170004A1 RID: 1185
            // (get) Token: 0x06000BE5 RID: 3045 RVA: 0x0001C33F File Offset: 0x0001A53F
            public bool HasNext => result.HasNext;

            // Token: 0x170004A2 RID: 1186
            // (get) Token: 0x06000BE6 RID: 3046 RVA: 0x0001C34C File Offset: 0x0001A54C
            // (set) Token: 0x06000BE7 RID: 3047 RVA: 0x0001C359 File Offset: 0x0001A559
            public int Next
            {
                get => result.Next;
                set => SetNext(value);
            }

            // Token: 0x06000BE8 RID: 3048 RVA: 0x0001C363 File Offset: 0x0001A563
            public Builder SetNext(int value)
			{
				PrepareBuilder();
				result.HasNext = true;
				result.next_ = value;
				return this;
			}

			// Token: 0x06000BE9 RID: 3049 RVA: 0x0001C385 File Offset: 0x0001A585
			public Builder ClearNext()
			{
				PrepareBuilder();
				result.HasNext = false;
				result.next_ = 0;
				return this;
			}

			// Token: 0x040003ED RID: 1005
			private bool resultIsReadOnly;

			// Token: 0x040003EE RID: 1006
			private Button result;
		}
	}
}
