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
    // Token: 0x0200001D RID: 29
    [DebuggerNonUserCode]
	public sealed class Transparent : GeneratedMessage<Transparent, Transparent.Builder>
	{
		// Token: 0x060002E4 RID: 740 RVA: 0x000065A8 File Offset: 0x000047A8
		private Transparent()
		{
		}

        // Token: 0x17000144 RID: 324
        // (get) Token: 0x060002E5 RID: 741 RVA: 0x00006625 File Offset: 0x00004825
        public static Transparent DefaultInstance { get; } = new Transparent().MakeReadOnly();

        // Token: 0x17000145 RID: 325
        // (get) Token: 0x060002E6 RID: 742 RVA: 0x0000662C File Offset: 0x0000482C
        public override Transparent DefaultInstanceForType => DefaultInstance;

        // Token: 0x17000146 RID: 326
        // (get) Token: 0x060002E7 RID: 743 RVA: 0x00006633 File Offset: 0x00004833
        protected override Transparent ThisMessage => this;

        // Token: 0x17000147 RID: 327
        // (get) Token: 0x060002E8 RID: 744 RVA: 0x00006636 File Offset: 0x00004836
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_Transparent__Descriptor;

        // Token: 0x17000148 RID: 328
        // (get) Token: 0x060002E9 RID: 745 RVA: 0x0000663D File Offset: 0x0000483D
        protected override FieldAccessorTable<Transparent, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_Transparent__FieldAccessorTable;

        // Token: 0x17000149 RID: 329
        // (get) Token: 0x060002EA RID: 746 RVA: 0x00006644 File Offset: 0x00004844
        public bool HasId { get; private set; }

        // Token: 0x1700014A RID: 330
        // (get) Token: 0x060002EB RID: 747 RVA: 0x0000664C File Offset: 0x0000484C
        public string Id => id_;

        // Token: 0x1700014B RID: 331
        // (get) Token: 0x060002EC RID: 748 RVA: 0x00006654 File Offset: 0x00004854
        public bool HasAction { get; private set; }

        // Token: 0x1700014C RID: 332
        // (get) Token: 0x060002ED RID: 749 RVA: 0x0000665C File Offset: 0x0000485C
        public string Action => action_;

        // Token: 0x1700014D RID: 333
        // (get) Token: 0x060002EE RID: 750 RVA: 0x00006664 File Offset: 0x00004864
        public bool HasTaskId { get; private set; }

        // Token: 0x1700014E RID: 334
        // (get) Token: 0x060002EF RID: 751 RVA: 0x0000666C File Offset: 0x0000486C
        public string TaskId => taskId_;

        // Token: 0x1700014F RID: 335
        // (get) Token: 0x060002F0 RID: 752 RVA: 0x00006674 File Offset: 0x00004874
        public bool HasAppKey { get; private set; }

        // Token: 0x17000150 RID: 336
        // (get) Token: 0x060002F1 RID: 753 RVA: 0x0000667C File Offset: 0x0000487C
        public string AppKey => appKey_;

        // Token: 0x17000151 RID: 337
        // (get) Token: 0x060002F2 RID: 754 RVA: 0x00006684 File Offset: 0x00004884
        public bool HasAppId { get; private set; }

        // Token: 0x17000152 RID: 338
        // (get) Token: 0x060002F3 RID: 755 RVA: 0x0000668C File Offset: 0x0000488C
        public string AppId => appId_;

        // Token: 0x17000153 RID: 339
        // (get) Token: 0x060002F4 RID: 756 RVA: 0x00006694 File Offset: 0x00004894
        public bool HasMessageId { get; private set; }

        // Token: 0x17000154 RID: 340
        // (get) Token: 0x060002F5 RID: 757 RVA: 0x0000669C File Offset: 0x0000489C
        public string MessageId => messageId_;

        // Token: 0x17000155 RID: 341
        // (get) Token: 0x060002F6 RID: 758 RVA: 0x000066A4 File Offset: 0x000048A4
        public bool HasPushInfo { get; private set; }

        // Token: 0x17000156 RID: 342
        // (get) Token: 0x060002F7 RID: 759 RVA: 0x000066AC File Offset: 0x000048AC
        public PushInfo PushInfo => pushInfo_ ?? PushInfo.DefaultInstance;

        // Token: 0x17000157 RID: 343
        // (get) Token: 0x060002F8 RID: 760 RVA: 0x000066BD File Offset: 0x000048BD
        public IList<ActionChain> ActionChainList => actionChain_;

        // Token: 0x17000158 RID: 344
        // (get) Token: 0x060002F9 RID: 761 RVA: 0x000066C5 File Offset: 0x000048C5
        public int ActionChainCount => actionChain_.Count;

        // Token: 0x060002FA RID: 762 RVA: 0x000066D2 File Offset: 0x000048D2
        public ActionChain GetActionChain(int index)
		{
			return actionChain_[index];
		}

        // Token: 0x17000159 RID: 345
        // (get) Token: 0x060002FB RID: 763 RVA: 0x000066E0 File Offset: 0x000048E0
        public IList<string> ConditionList => Lists.AsReadOnly(condition_);

        // Token: 0x1700015A RID: 346
        // (get) Token: 0x060002FC RID: 764 RVA: 0x000066ED File Offset: 0x000048ED
        public int ConditionCount => condition_.Count;

        // Token: 0x060002FD RID: 765 RVA: 0x000066FA File Offset: 0x000048FA
        public string GetCondition(int index)
		{
			return condition_[index];
		}

        // Token: 0x1700015B RID: 347
        // (get) Token: 0x060002FE RID: 766 RVA: 0x00006708 File Offset: 0x00004908
        public bool HasTemplateId { get; private set; }

        // Token: 0x1700015C RID: 348
        // (get) Token: 0x060002FF RID: 767 RVA: 0x00006710 File Offset: 0x00004910
        public int TemplateId => templateId_;

        // Token: 0x1700015D RID: 349
        // (get) Token: 0x06000300 RID: 768 RVA: 0x00006718 File Offset: 0x00004918
        public bool HasTaskGroupId { get; private set; }

        // Token: 0x1700015E RID: 350
        // (get) Token: 0x06000301 RID: 769 RVA: 0x00006720 File Offset: 0x00004920
        public string TaskGroupId => taskGroupId_;

        // Token: 0x1700015F RID: 351
        // (get) Token: 0x06000302 RID: 770 RVA: 0x00006728 File Offset: 0x00004928
        public bool HasSmsInfo { get; private set; }

        // Token: 0x17000160 RID: 352
        // (get) Token: 0x06000303 RID: 771 RVA: 0x00006730 File Offset: 0x00004930
        public SmsInfo SmsInfo => smsInfo_ ?? SmsInfo.DefaultInstance;

        // Token: 0x17000161 RID: 353
        // (get) Token: 0x06000304 RID: 772 RVA: 0x00006744 File Offset: 0x00004944
        public override bool IsInitialized
		{
			get
			{
				if (!HasId || !HasAction || !HasTaskId || !HasAppKey || !HasAppId || !HasMessageId || HasPushInfo && !PushInfo.IsInitialized)
				{
					return false;
				}

                using (IEnumerator<ActionChain> enumerator = ActionChainList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (!enumerator.Current.IsInitialized)
						{
							return false;
						}
					}
				}
				return !HasSmsInfo || SmsInfo.IsInitialized;
			}
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00006804 File Offset: 0x00004A04
		public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] transparentFieldNames = _transparentFieldNames;
			if (HasId)
			{
				output.WriteString(1, transparentFieldNames[5], Id);
			}
			if (HasAction)
			{
				output.WriteString(2, transparentFieldNames[0], Action);
			}
			if (HasTaskId)
			{
				output.WriteString(3, transparentFieldNames[10], TaskId);
			}
			if (HasAppKey)
			{
				output.WriteString(4, transparentFieldNames[3], AppKey);
			}
			if (HasAppId)
			{
				output.WriteString(5, transparentFieldNames[2], AppId);
			}
			if (HasMessageId)
			{
				output.WriteString(6, transparentFieldNames[6], MessageId);
			}
			if (HasPushInfo)
			{
				output.WriteMessage(7, transparentFieldNames[7], PushInfo);
			}
			if (actionChain_.Count > 0)
			{
				output.WriteMessageArray(8, transparentFieldNames[1], actionChain_);
			}
			if (condition_.Count > 0)
			{
				output.WriteStringArray(9, transparentFieldNames[4], condition_);
			}
			if (HasTemplateId)
			{
				output.WriteInt32(10, transparentFieldNames[11], TemplateId);
			}
			if (HasTaskGroupId)
			{
				output.WriteString(11, transparentFieldNames[9], TaskGroupId);
			}
			if (HasSmsInfo)
			{
				output.WriteMessage(12, transparentFieldNames[8], SmsInfo);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000306 RID: 774 RVA: 0x00006960 File Offset: 0x00004B60
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
				if (HasId)
				{
					num += CodedOutputStream.ComputeStringSize(1, Id);
				}
				if (HasAction)
				{
					num += CodedOutputStream.ComputeStringSize(2, Action);
				}
				if (HasTaskId)
				{
					num += CodedOutputStream.ComputeStringSize(3, TaskId);
				}
				if (HasAppKey)
				{
					num += CodedOutputStream.ComputeStringSize(4, AppKey);
				}
				if (HasAppId)
				{
					num += CodedOutputStream.ComputeStringSize(5, AppId);
				}
				if (HasMessageId)
				{
					num += CodedOutputStream.ComputeStringSize(6, MessageId);
				}
				if (HasPushInfo)
				{
					num += CodedOutputStream.ComputeMessageSize(7, PushInfo);
				}
				foreach (ActionChain value in ActionChainList)
				{
					num += CodedOutputStream.ComputeMessageSize(8, value);
				}
				int num2 = 0;
				foreach (string value2 in ConditionList)
				{
					num2 += CodedOutputStream.ComputeStringSizeNoTag(value2);
				}
				num += num2;
				num += condition_.Count;
				if (HasTemplateId)
				{
					num += CodedOutputStream.ComputeInt32Size(10, TemplateId);
				}
				if (HasTaskGroupId)
				{
					num += CodedOutputStream.ComputeStringSize(11, TaskGroupId);
				}
				if (HasSmsInfo)
				{
					num += CodedOutputStream.ComputeMessageSize(12, SmsInfo);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

        // Token: 0x06000307 RID: 775 RVA: 0x00006B18 File Offset: 0x00004D18
        public static Transparent ParseFrom(ByteString data) => CreateBuilder().MergeFrom(data).BuildParsed();

        // Token: 0x06000308 RID: 776 RVA: 0x00006B2A File Offset: 0x00004D2A
        public static Transparent ParseFrom(ByteString data, ExtensionRegistry extensionRegistry) => CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();

        // Token: 0x06000309 RID: 777 RVA: 0x00006B3D File Offset: 0x00004D3D
        public static Transparent ParseFrom(byte[] data) => CreateBuilder().MergeFrom(data).BuildParsed();

        // Token: 0x0600030A RID: 778 RVA: 0x00006B4F File Offset: 0x00004D4F
        public static Transparent ParseFrom(byte[] data, ExtensionRegistry extensionRegistry) => CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();

        // Token: 0x0600030B RID: 779 RVA: 0x00006B62 File Offset: 0x00004D62
        public static Transparent ParseFrom(Stream input) => CreateBuilder().MergeFrom(input).BuildParsed();

        // Token: 0x0600030C RID: 780 RVA: 0x00006B74 File Offset: 0x00004D74
        public static Transparent ParseFrom(Stream input, ExtensionRegistry extensionRegistry) => CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();

        // Token: 0x0600030D RID: 781 RVA: 0x00006B87 File Offset: 0x00004D87
        public static Transparent ParseDelimitedFrom(Stream input) => CreateBuilder().MergeDelimitedFrom(input).BuildParsed();

        // Token: 0x0600030E RID: 782 RVA: 0x00006B99 File Offset: 0x00004D99
        public static Transparent ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry) => CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();

        // Token: 0x0600030F RID: 783 RVA: 0x00006BAC File Offset: 0x00004DAC
        public static Transparent ParseFrom(ICodedInputStream input) => CreateBuilder().MergeFrom(input).BuildParsed();

        // Token: 0x06000310 RID: 784 RVA: 0x00006BBE File Offset: 0x00004DBE
        public static Transparent ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry) => CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();

        // Token: 0x06000311 RID: 785 RVA: 0x00006BD1 File Offset: 0x00004DD1
        private Transparent MakeReadOnly()
		{
			actionChain_.MakeReadOnly();
			condition_.MakeReadOnly();
			return this;
		}

        // Token: 0x06000312 RID: 786 RVA: 0x00006BEA File Offset: 0x00004DEA
        public static Builder CreateBuilder() => new Builder();

        // Token: 0x06000313 RID: 787 RVA: 0x00006BF1 File Offset: 0x00004DF1
        public override Builder ToBuilder() => CreateBuilder(this);

        // Token: 0x06000314 RID: 788 RVA: 0x00006BF9 File Offset: 0x00004DF9
        public override Builder CreateBuilderForType() => new Builder();

        // Token: 0x06000315 RID: 789 RVA: 0x00006C00 File Offset: 0x00004E00
        public static Builder CreateBuilder(Transparent prototype) => new Builder(prototype);

        // Token: 0x06000316 RID: 790 RVA: 0x00006C08 File Offset: 0x00004E08
        static Transparent()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x040001A3 RID: 419
        private static readonly string[] _transparentFieldNames = new string[]
		{
			"action",
			"actionChain",
			"appId",
			"appKey",
			"condition",
			"id",
			"messageId",
			"pushInfo",
			"smsInfo",
			"taskGroupId",
			"taskId",
			"templateId"
		};

		// Token: 0x040001A4 RID: 420
		private static readonly uint[] _transparentFieldTags = new uint[]
		{
			18U,
			66U,
			42U,
			34U,
			74U,
			10U,
			50U,
			58U,
			98U,
			90U,
			26U,
			80U
		};

		// Token: 0x040001A5 RID: 421
		public const int IdFieldNumber = 1;

        // Token: 0x040001A7 RID: 423
        private string id_ = "";

		// Token: 0x040001A8 RID: 424
		public const int ActionFieldNumber = 2;

        // Token: 0x040001AA RID: 426
        private string action_ = "";

		// Token: 0x040001AB RID: 427
		public const int TaskIdFieldNumber = 3;

        // Token: 0x040001AD RID: 429
        private string taskId_ = "";

		// Token: 0x040001AE RID: 430
		public const int AppKeyFieldNumber = 4;

        // Token: 0x040001B0 RID: 432
        private string appKey_ = "";

		// Token: 0x040001B1 RID: 433
		public const int AppIdFieldNumber = 5;

        // Token: 0x040001B3 RID: 435
        private string appId_ = "";

		// Token: 0x040001B4 RID: 436
		public const int MessageIdFieldNumber = 6;

        // Token: 0x040001B6 RID: 438
        private string messageId_ = "";

		// Token: 0x040001B7 RID: 439
		public const int PushInfoFieldNumber = 7;

        // Token: 0x040001B9 RID: 441
        private PushInfo pushInfo_;

		// Token: 0x040001BA RID: 442
		public const int ActionChainFieldNumber = 8;

		// Token: 0x040001BB RID: 443
		private PopsicleList<ActionChain> actionChain_ = new PopsicleList<ActionChain>();

		// Token: 0x040001BC RID: 444
		public const int ConditionFieldNumber = 9;

		// Token: 0x040001BD RID: 445
		private PopsicleList<string> condition_ = new PopsicleList<string>();

		// Token: 0x040001BE RID: 446
		public const int TemplateIdFieldNumber = 10;

        // Token: 0x040001C0 RID: 448
        private int templateId_;

		// Token: 0x040001C1 RID: 449
		public const int TaskGroupIdFieldNumber = 11;

        // Token: 0x040001C3 RID: 451
        private string taskGroupId_ = "";

		// Token: 0x040001C4 RID: 452
		public const int SmsInfoFieldNumber = 12;

        // Token: 0x040001C6 RID: 454
        private SmsInfo smsInfo_;

		// Token: 0x040001C7 RID: 455
		private int memoizedSerializedSize = -1;

		// Token: 0x02000079 RID: 121
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<Transparent, Builder>
		{
            // Token: 0x170003D6 RID: 982
            // (get) Token: 0x060009C2 RID: 2498 RVA: 0x000173CC File Offset: 0x000155CC
            protected override Builder ThisBuilder => this;

            // Token: 0x060009C3 RID: 2499 RVA: 0x000173CF File Offset: 0x000155CF
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x060009C4 RID: 2500 RVA: 0x000173E9 File Offset: 0x000155E9
			internal Builder(Transparent cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x060009C5 RID: 2501 RVA: 0x00017400 File Offset: 0x00015600
			private Transparent PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					Transparent other = result;
					result = new Transparent();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x170003D7 RID: 983
            // (get) Token: 0x060009C6 RID: 2502 RVA: 0x0001743C File Offset: 0x0001563C
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x170003D8 RID: 984
            // (get) Token: 0x060009C7 RID: 2503 RVA: 0x00017449 File Offset: 0x00015649
            protected override Transparent MessageBeingBuilt => PrepareBuilder();

            // Token: 0x060009C8 RID: 2504 RVA: 0x00017451 File Offset: 0x00015651
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x060009C9 RID: 2505 RVA: 0x00017466 File Offset: 0x00015666
			public override Builder Clone()
            {
                return resultIsReadOnly ? new Builder(result) : new Builder().MergeFrom(result);
            }

            // Token: 0x170003D9 RID: 985
            // (get) Token: 0x060009CA RID: 2506 RVA: 0x0001748C File Offset: 0x0001568C
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x170003DA RID: 986
            // (get) Token: 0x060009CB RID: 2507 RVA: 0x00017493 File Offset: 0x00015693
            public override Transparent DefaultInstanceForType => DefaultInstance;

            // Token: 0x060009CC RID: 2508 RVA: 0x0001749A File Offset: 0x0001569A
            public override Transparent BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x060009CD RID: 2509 RVA: 0x000174BD File Offset: 0x000156BD
			public override Builder MergeFrom(IMessage other)
			{
				if (other is Transparent)
				{
					return MergeFrom((Transparent)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x060009CE RID: 2510 RVA: 0x000174E0 File Offset: 0x000156E0
			public override Builder MergeFrom(Transparent other)
			{
				if (other == DefaultInstance)
				{
					return this;
				}
				PrepareBuilder();
				if (other.HasId)
				{
					Id = other.Id;
				}
				if (other.HasAction)
				{
					Action = other.Action;
				}
				if (other.HasTaskId)
				{
					TaskId = other.TaskId;
				}
				if (other.HasAppKey)
				{
					AppKey = other.AppKey;
				}
				if (other.HasAppId)
				{
					AppId = other.AppId;
				}
				if (other.HasMessageId)
				{
					MessageId = other.MessageId;
				}
				if (other.HasPushInfo)
				{
					MergePushInfo(other.PushInfo);
				}
				if (other.actionChain_.Count != 0)
				{
					result.actionChain_.Add(other.actionChain_);
				}
				if (other.condition_.Count != 0)
				{
					result.condition_.Add(other.condition_);
				}
				if (other.HasTemplateId)
				{
					TemplateId = other.TemplateId;
				}
				if (other.HasTaskGroupId)
				{
					TaskGroupId = other.TaskGroupId;
				}
				if (other.HasSmsInfo)
				{
					MergeSmsInfo(other.SmsInfo);
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x060009CF RID: 2511 RVA: 0x0001761C File Offset: 0x0001581C
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x060009D0 RID: 2512 RVA: 0x0001762C File Offset: 0x0001582C
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_transparentFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _transparentFieldTags[num2];
                    }
                    if (num <= 42U)
                    {
                        if (num <= 18U)
                        {
                            if (num == 0U)
                            {
                                throw InvalidProtocolBufferException.InvalidTag();
                            }
                            if (num == 10U)
                            {
                                result.HasId = input.ReadString(ref result.id_);
                                continue;
                            }
                            if (num == 18U)
                            {
                                result.HasAction = input.ReadString(ref result.action_);
                                continue;
                            }
                        }
                        else
                        {
                            if (num == 26U)
                            {
                                result.HasTaskId = input.ReadString(ref result.taskId_);
                                continue;
                            }
                            if (num == 34U)
                            {
                                result.HasAppKey = input.ReadString(ref result.appKey_);
                                continue;
                            }
                            if (num == 42U)
                            {
                                result.HasAppId = input.ReadString(ref result.appId_);
                                continue;
                            }
                        }
                    }
                    else if (num <= 66U)
                    {
                        if (num == 50U)
                        {
                            result.HasMessageId = input.ReadString(ref result.messageId_);
                            continue;
                        }
                        if (num == 58U)
                        {
                            PushInfo.Builder builder2 = PushInfo.CreateBuilder();
                            if (result.HasPushInfo)
                            {
                                builder2.MergeFrom(PushInfo);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            PushInfo = builder2.BuildPartial();
                            continue;
                        }
                        if (num == 66U)
                        {
                            input.ReadMessageArray(num, text, result.actionChain_, ActionChain.DefaultInstance, extensionRegistry);
                            continue;
                        }
                    }
                    else if (num <= 80U)
                    {
                        if (num == 74U)
                        {
                            input.ReadStringArray(num, text, result.condition_);
                            continue;
                        }
                        if (num == 80U)
                        {
                            result.HasTemplateId = input.ReadInt32(ref result.templateId_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 90U)
                        {
                            result.HasTaskGroupId = input.ReadString(ref result.taskGroupId_);
                            continue;
                        }
                        if (num == 98U)
                        {
                            SmsInfo.Builder builder3 = SmsInfo.CreateBuilder();
                            if (result.HasSmsInfo)
                            {
                                builder3.MergeFrom(SmsInfo);
                            }
                            input.ReadMessage(builder3, extensionRegistry);
                            SmsInfo = builder3.BuildPartial();
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

            // Token: 0x170003DB RID: 987
            // (get) Token: 0x060009D1 RID: 2513 RVA: 0x00017915 File Offset: 0x00015B15
            public bool HasId => result.HasId;

            // Token: 0x170003DC RID: 988
            // (get) Token: 0x060009D2 RID: 2514 RVA: 0x00017922 File Offset: 0x00015B22
            // (set) Token: 0x060009D3 RID: 2515 RVA: 0x0001792F File Offset: 0x00015B2F
            public string Id
			{
				get
				{
					return result.Id;
				}
				set
				{
					SetId(value);
				}
			}

			// Token: 0x060009D4 RID: 2516 RVA: 0x00017939 File Offset: 0x00015B39
			public Builder SetId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasId = true;
				result.id_ = value;
				return this;
			}

			// Token: 0x060009D5 RID: 2517 RVA: 0x00017966 File Offset: 0x00015B66
			public Builder ClearId()
			{
				PrepareBuilder();
				result.HasId = false;
				result.id_ = "";
				return this;
			}

            // Token: 0x170003DD RID: 989
            // (get) Token: 0x060009D6 RID: 2518 RVA: 0x0001798C File Offset: 0x00015B8C
            public bool HasAction => result.HasAction;

            // Token: 0x170003DE RID: 990
            // (get) Token: 0x060009D7 RID: 2519 RVA: 0x00017999 File Offset: 0x00015B99
            // (set) Token: 0x060009D8 RID: 2520 RVA: 0x000179A6 File Offset: 0x00015BA6
            public string Action
			{
				get
				{
					return result.Action;
				}
				set
				{
					SetAction(value);
				}
			}

			// Token: 0x060009D9 RID: 2521 RVA: 0x000179B0 File Offset: 0x00015BB0
			public Builder SetAction(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasAction = true;
				result.action_ = value;
				return this;
			}

			// Token: 0x060009DA RID: 2522 RVA: 0x000179DD File Offset: 0x00015BDD
			public Builder ClearAction()
			{
				PrepareBuilder();
				result.HasAction = false;
				result.action_ = "";
				return this;
			}

            // Token: 0x170003DF RID: 991
            // (get) Token: 0x060009DB RID: 2523 RVA: 0x00017A03 File Offset: 0x00015C03
            public bool HasTaskId => result.HasTaskId;

            // Token: 0x170003E0 RID: 992
            // (get) Token: 0x060009DC RID: 2524 RVA: 0x00017A10 File Offset: 0x00015C10
            // (set) Token: 0x060009DD RID: 2525 RVA: 0x00017A1D File Offset: 0x00015C1D
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

			// Token: 0x060009DE RID: 2526 RVA: 0x00017A27 File Offset: 0x00015C27
			public Builder SetTaskId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasTaskId = true;
				result.taskId_ = value;
				return this;
			}

			// Token: 0x060009DF RID: 2527 RVA: 0x00017A54 File Offset: 0x00015C54
			public Builder ClearTaskId()
			{
				PrepareBuilder();
				result.HasTaskId = false;
				result.taskId_ = "";
				return this;
			}

            // Token: 0x170003E1 RID: 993
            // (get) Token: 0x060009E0 RID: 2528 RVA: 0x00017A7A File Offset: 0x00015C7A
            public bool HasAppKey => result.HasAppKey;

            // Token: 0x170003E2 RID: 994
            // (get) Token: 0x060009E1 RID: 2529 RVA: 0x00017A87 File Offset: 0x00015C87
            // (set) Token: 0x060009E2 RID: 2530 RVA: 0x00017A94 File Offset: 0x00015C94
            public string AppKey
			{
				get
				{
					return result.AppKey;
				}
				set
				{
					SetAppKey(value);
				}
			}

			// Token: 0x060009E3 RID: 2531 RVA: 0x00017A9E File Offset: 0x00015C9E
			public Builder SetAppKey(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasAppKey = true;
				result.appKey_ = value;
				return this;
			}

			// Token: 0x060009E4 RID: 2532 RVA: 0x00017ACB File Offset: 0x00015CCB
			public Builder ClearAppKey()
			{
				PrepareBuilder();
				result.HasAppKey = false;
				result.appKey_ = "";
				return this;
			}

            // Token: 0x170003E3 RID: 995
            // (get) Token: 0x060009E5 RID: 2533 RVA: 0x00017AF1 File Offset: 0x00015CF1
            public bool HasAppId => result.HasAppId;

            // Token: 0x170003E4 RID: 996
            // (get) Token: 0x060009E6 RID: 2534 RVA: 0x00017AFE File Offset: 0x00015CFE
            // (set) Token: 0x060009E7 RID: 2535 RVA: 0x00017B0B File Offset: 0x00015D0B
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

			// Token: 0x060009E8 RID: 2536 RVA: 0x00017B15 File Offset: 0x00015D15
			public Builder SetAppId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasAppId = true;
				result.appId_ = value;
				return this;
			}

			// Token: 0x060009E9 RID: 2537 RVA: 0x00017B42 File Offset: 0x00015D42
			public Builder ClearAppId()
			{
				PrepareBuilder();
				result.HasAppId = false;
				result.appId_ = "";
				return this;
			}

            // Token: 0x170003E5 RID: 997
            // (get) Token: 0x060009EA RID: 2538 RVA: 0x00017B68 File Offset: 0x00015D68
            public bool HasMessageId => result.HasMessageId;

            // Token: 0x170003E6 RID: 998
            // (get) Token: 0x060009EB RID: 2539 RVA: 0x00017B75 File Offset: 0x00015D75
            // (set) Token: 0x060009EC RID: 2540 RVA: 0x00017B82 File Offset: 0x00015D82
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

			// Token: 0x060009ED RID: 2541 RVA: 0x00017B8C File Offset: 0x00015D8C
			public Builder SetMessageId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasMessageId = true;
				result.messageId_ = value;
				return this;
			}

			// Token: 0x060009EE RID: 2542 RVA: 0x00017BB9 File Offset: 0x00015DB9
			public Builder ClearMessageId()
			{
				PrepareBuilder();
				result.HasMessageId = false;
				result.messageId_ = "";
				return this;
			}

            // Token: 0x170003E7 RID: 999
            // (get) Token: 0x060009EF RID: 2543 RVA: 0x00017BDF File Offset: 0x00015DDF
            public bool HasPushInfo => result.HasPushInfo;

            // Token: 0x170003E8 RID: 1000
            // (get) Token: 0x060009F0 RID: 2544 RVA: 0x00017BEC File Offset: 0x00015DEC
            // (set) Token: 0x060009F1 RID: 2545 RVA: 0x00017BF9 File Offset: 0x00015DF9
            public PushInfo PushInfo
			{
				get
				{
					return result.PushInfo;
				}
				set
				{
					SetPushInfo(value);
				}
			}

			// Token: 0x060009F2 RID: 2546 RVA: 0x00017C03 File Offset: 0x00015E03
			public Builder SetPushInfo(PushInfo value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasPushInfo = true;
				result.pushInfo_ = value;
				return this;
			}

			// Token: 0x060009F3 RID: 2547 RVA: 0x00017C30 File Offset: 0x00015E30
			public Builder SetPushInfo(PushInfo.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.HasPushInfo = true;
				result.pushInfo_ = builderForValue.Build();
				return this;
			}

			// Token: 0x060009F4 RID: 2548 RVA: 0x00017C64 File Offset: 0x00015E64
			public Builder MergePushInfo(PushInfo value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				if (result.HasPushInfo && result.pushInfo_ != PushInfo.DefaultInstance)
				{
					result.pushInfo_ = PushInfo.CreateBuilder(result.pushInfo_).MergeFrom(value).BuildPartial();
				}
				else
				{
					result.pushInfo_ = value;
				}
				result.HasPushInfo = true;
				return this;
			}

			// Token: 0x060009F5 RID: 2549 RVA: 0x00017CE3 File Offset: 0x00015EE3
			public Builder ClearPushInfo()
			{
				PrepareBuilder();
				result.HasPushInfo = false;
				result.pushInfo_ = null;
				return this;
			}

            // Token: 0x170003E9 RID: 1001
            // (get) Token: 0x060009F6 RID: 2550 RVA: 0x00017D05 File Offset: 0x00015F05
            public IPopsicleList<ActionChain> ActionChainList => PrepareBuilder().actionChain_;

            // Token: 0x170003EA RID: 1002
            // (get) Token: 0x060009F7 RID: 2551 RVA: 0x00017D12 File Offset: 0x00015F12
            public int ActionChainCount => result.ActionChainCount;

            // Token: 0x060009F8 RID: 2552 RVA: 0x00017D1F File Offset: 0x00015F1F
            public ActionChain GetActionChain(int index)
			{
				return result.GetActionChain(index);
			}

			// Token: 0x060009F9 RID: 2553 RVA: 0x00017D2D File Offset: 0x00015F2D
			public Builder SetActionChain(int index, ActionChain value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.actionChain_[index] = value;
				return this;
			}

			// Token: 0x060009FA RID: 2554 RVA: 0x00017D54 File Offset: 0x00015F54
			public Builder SetActionChain(int index, ActionChain.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.actionChain_[index] = builderForValue.Build();
				return this;
			}

			// Token: 0x060009FB RID: 2555 RVA: 0x00017D80 File Offset: 0x00015F80
			public Builder AddActionChain(ActionChain value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.actionChain_.Add(value);
				return this;
			}

			// Token: 0x060009FC RID: 2556 RVA: 0x00017DA6 File Offset: 0x00015FA6
			public Builder AddActionChain(ActionChain.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.actionChain_.Add(builderForValue.Build());
				return this;
			}

			// Token: 0x060009FD RID: 2557 RVA: 0x00017DD1 File Offset: 0x00015FD1
			public Builder AddRangeActionChain(IEnumerable<ActionChain> values)
			{
				PrepareBuilder();
				result.actionChain_.Add(values);
				return this;
			}

			// Token: 0x060009FE RID: 2558 RVA: 0x00017DEC File Offset: 0x00015FEC
			public Builder ClearActionChain()
			{
				PrepareBuilder();
				result.actionChain_.Clear();
				return this;
			}

            // Token: 0x170003EB RID: 1003
            // (get) Token: 0x060009FF RID: 2559 RVA: 0x00017E06 File Offset: 0x00016006
            public IPopsicleList<string> ConditionList => PrepareBuilder().condition_;

            // Token: 0x170003EC RID: 1004
            // (get) Token: 0x06000A00 RID: 2560 RVA: 0x00017E13 File Offset: 0x00016013
            public int ConditionCount => result.ConditionCount;

            // Token: 0x06000A01 RID: 2561 RVA: 0x00017E20 File Offset: 0x00016020
            public string GetCondition(int index)
			{
				return result.GetCondition(index);
			}

			// Token: 0x06000A02 RID: 2562 RVA: 0x00017E2E File Offset: 0x0001602E
			public Builder SetCondition(int index, string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.condition_[index] = value;
				return this;
			}

			// Token: 0x06000A03 RID: 2563 RVA: 0x00017E55 File Offset: 0x00016055
			public Builder AddCondition(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.condition_.Add(value);
				return this;
			}

			// Token: 0x06000A04 RID: 2564 RVA: 0x00017E7B File Offset: 0x0001607B
			public Builder AddRangeCondition(IEnumerable<string> values)
			{
				PrepareBuilder();
				result.condition_.Add(values);
				return this;
			}

			// Token: 0x06000A05 RID: 2565 RVA: 0x00017E96 File Offset: 0x00016096
			public Builder ClearCondition()
			{
				PrepareBuilder();
				result.condition_.Clear();
				return this;
			}

            // Token: 0x170003ED RID: 1005
            // (get) Token: 0x06000A06 RID: 2566 RVA: 0x00017EB0 File Offset: 0x000160B0
            public bool HasTemplateId => result.HasTemplateId;

            // Token: 0x170003EE RID: 1006
            // (get) Token: 0x06000A07 RID: 2567 RVA: 0x00017EBD File Offset: 0x000160BD
            // (set) Token: 0x06000A08 RID: 2568 RVA: 0x00017ECA File Offset: 0x000160CA
            public int TemplateId
			{
				get
				{
					return result.TemplateId;
				}
				set
				{
					SetTemplateId(value);
				}
			}

			// Token: 0x06000A09 RID: 2569 RVA: 0x00017ED4 File Offset: 0x000160D4
			public Builder SetTemplateId(int value)
			{
				PrepareBuilder();
				result.HasTemplateId = true;
				result.templateId_ = value;
				return this;
			}

			// Token: 0x06000A0A RID: 2570 RVA: 0x00017EF6 File Offset: 0x000160F6
			public Builder ClearTemplateId()
			{
				PrepareBuilder();
				result.HasTemplateId = false;
				result.templateId_ = 0;
				return this;
			}

            // Token: 0x170003EF RID: 1007
            // (get) Token: 0x06000A0B RID: 2571 RVA: 0x00017F18 File Offset: 0x00016118
            public bool HasTaskGroupId => result.HasTaskGroupId;

            // Token: 0x170003F0 RID: 1008
            // (get) Token: 0x06000A0C RID: 2572 RVA: 0x00017F25 File Offset: 0x00016125
            // (set) Token: 0x06000A0D RID: 2573 RVA: 0x00017F32 File Offset: 0x00016132
            public string TaskGroupId
			{
				get
				{
					return result.TaskGroupId;
				}
				set
				{
					SetTaskGroupId(value);
				}
			}

			// Token: 0x06000A0E RID: 2574 RVA: 0x00017F3C File Offset: 0x0001613C
			public Builder SetTaskGroupId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasTaskGroupId = true;
				result.taskGroupId_ = value;
				return this;
			}

			// Token: 0x06000A0F RID: 2575 RVA: 0x00017F69 File Offset: 0x00016169
			public Builder ClearTaskGroupId()
			{
				PrepareBuilder();
				result.HasTaskGroupId = false;
				result.taskGroupId_ = "";
				return this;
			}

            // Token: 0x170003F1 RID: 1009
            // (get) Token: 0x06000A10 RID: 2576 RVA: 0x00017F8F File Offset: 0x0001618F
            public bool HasSmsInfo => result.HasSmsInfo;

            // Token: 0x170003F2 RID: 1010
            // (get) Token: 0x06000A11 RID: 2577 RVA: 0x00017F9C File Offset: 0x0001619C
            // (set) Token: 0x06000A12 RID: 2578 RVA: 0x00017FA9 File Offset: 0x000161A9
            public SmsInfo SmsInfo
			{
				get
				{
					return result.SmsInfo;
				}
				set
				{
					SetSmsInfo(value);
				}
			}

			// Token: 0x06000A13 RID: 2579 RVA: 0x00017FB3 File Offset: 0x000161B3
			public Builder SetSmsInfo(SmsInfo value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasSmsInfo = true;
				result.smsInfo_ = value;
				return this;
			}

			// Token: 0x06000A14 RID: 2580 RVA: 0x00017FE0 File Offset: 0x000161E0
			public Builder SetSmsInfo(SmsInfo.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.HasSmsInfo = true;
				result.smsInfo_ = builderForValue.Build();
				return this;
			}

			// Token: 0x06000A15 RID: 2581 RVA: 0x00018014 File Offset: 0x00016214
			public Builder MergeSmsInfo(SmsInfo value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				if (result.HasSmsInfo && result.smsInfo_ != SmsInfo.DefaultInstance)
				{
					result.smsInfo_ = SmsInfo.CreateBuilder(result.smsInfo_).MergeFrom(value).BuildPartial();
				}
				else
				{
					result.smsInfo_ = value;
				}
				result.HasSmsInfo = true;
				return this;
			}

			// Token: 0x06000A16 RID: 2582 RVA: 0x00018093 File Offset: 0x00016293
			public Builder ClearSmsInfo()
			{
				PrepareBuilder();
				result.HasSmsInfo = false;
				result.smsInfo_ = null;
				return this;
			}

			// Token: 0x040003E1 RID: 993
			private bool resultIsReadOnly;

			// Token: 0x040003E2 RID: 994
			private Transparent result;
		}
	}
}
