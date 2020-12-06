using System;
using System.Collections.Generic;
using com.gexin.rp.sdk.dto;
using com.igetui.api.openservice.igetui;
using Newtonsoft.Json;

namespace com.igetui.api.openservice
{
	// Token: 0x02000027 RID: 39
	public class BatchImpl : IBatch
	{
		// Token: 0x060004A3 RID: 1187 RVA: 0x00009928 File Offset: 0x00007B28
		public BatchImpl(string appKey, IGtPush push)
		{
			batchId = Guid.NewGuid().ToString();
			APPKEY = appKey;
			this.push = push;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0000996D File Offset: 0x00007B6D
		public void setApiUrl(string url)
		{
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0000996F File Offset: 0x00007B6F
		public string getBatchId()
		{
			return batchId;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00009978 File Offset: 0x00007B78
		public string add(SingleMessage message, igetui.Target target)
		{
			if (seqId >= 5000)
			{
				throw new Exception("Can not add over 5000 message once! Please call submit() first.");
			}
			string data = createPostParams(message, target);
			SingleBatchItem item = SingleBatchItem.CreateBuilder().SetSeqId(seqId).SetData(data).Build();
			innerMsgList.Add(item);
			seqId++;
			return string.Concat(seqId) ?? "";
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x000099F8 File Offset: 0x00007BF8
		public string createPostParams(SingleMessage message, igetui.Target target)
		{
			return JsonConvert.SerializeObject(new Dictionary<string, object>
			{
				{
					"action",
					"pushMessageToSingleAction"
				},
				{
					"appkey",
					APPKEY
				},
				{
					"clientData",
					Convert.ToBase64String(message.Data.getTransparent().ToByteArray())
				},
				{
					"transmissionContent",
					message.Data.getTransmissionContent()
				},
				{
					"isOffline",
					message.IsOffline
				},
				{
					"offlineExpireTime",
					message.OfflineExpireTime
				},
				{
					"appId",
					target.appId
				},
				{
					"clientId",
					target.clientId
				},
				{
					"type",
					2
				},
				{
					"pushType",
					message.Data.getPushType()
				},
				{
					"version",
					"3.0.0.0"
				}
			});
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00009AEC File Offset: 0x00007CEC
		public string submit()
		{
			string value = Guid.NewGuid().ToString();
			seqId = 0;
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add("requestId", value);
			dictionary.Add("appkey", APPKEY);
			dictionary.Add("action", "pushMessageToSingleBatchAction");
			dictionary.Add("serialize", "pb");
			dictionary.Add("async", GtConfig.isPushSingleBatchAsync());
			SingleBatchRequest singleBatchRequest = SingleBatchRequest.CreateBuilder().SetBatchId(batchId).AddRangeBatchItem(innerMsgList).Build();
			dictionary.Add("singleDatas", Convert.ToBase64String(singleBatchRequest.ToByteArray()));
			lastPostData = dictionary;
			innerMsgList.Clear();
			return push.httpPostJSON(push.host, dictionary, true);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00009BCD File Offset: 0x00007DCD
		public string retry()
		{
			if (lastPostData != null)
			{
				return push.httpPostJSON(push.host, lastPostData, true);
			}
			return null;
		}

		// Token: 0x040002E5 RID: 741
		private string batchId;

		// Token: 0x040002E6 RID: 742
		private List<SingleBatchItem> innerMsgList = new List<SingleBatchItem>();

		// Token: 0x040002E7 RID: 743
		private int seqId;

		// Token: 0x040002E8 RID: 744
		private string APPKEY;

		// Token: 0x040002E9 RID: 745
		private IGtPush push;

		// Token: 0x040002EA RID: 746
		private Dictionary<string, object> lastPostData;
	}
}
