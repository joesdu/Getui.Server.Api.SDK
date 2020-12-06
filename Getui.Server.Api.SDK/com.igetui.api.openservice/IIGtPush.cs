using System;
using System.Collections.Generic;
using com.igetui.api.openservice.igetui;

namespace com.igetui.api.openservice
{
	// Token: 0x02000030 RID: 48
	public interface IIGtPush
	{
		// Token: 0x0600051B RID: 1307
		bool connect();

		// Token: 0x0600051C RID: 1308
		void close();

		// Token: 0x0600051D RID: 1309
		string pushMessageToSingle(SingleMessage message, Target target);

		// Token: 0x0600051E RID: 1310
		void pushMessageToList(ListMessage message, IListProvider listProvider, IPushEventListener listener);

		// Token: 0x0600051F RID: 1311
		string getContentId(ListMessage message);

		// Token: 0x06000520 RID: 1312
		bool cancelContentId(string contentId);

		// Token: 0x06000521 RID: 1313
		bool stop(string contentId);

		// Token: 0x06000522 RID: 1314
		string pushMessageToList(string contentId, List<Target> targetList);

		// Token: 0x06000523 RID: 1315
		string addCidListToBlk(string appId, List<string> cidList);

		// Token: 0x06000524 RID: 1316
		string restoreCidListFromBlk(string appId, List<string> cidList);

		// Token: 0x06000525 RID: 1317
		string pushMessageToApp(AppMessage message);

		// Token: 0x06000526 RID: 1318
		string pushTagMessage(TagMessage message);

		// Token: 0x06000527 RID: 1319
		string pushTagMessage(TagMessage message, string requestId);

		// Token: 0x06000528 RID: 1320
		IBatch getBatch();

		// Token: 0x06000529 RID: 1321
		string getUserCountByTags(string appId, List<string> tahlist);

		// Token: 0x0600052A RID: 1322
		string getPushResultByTaskidList(List<string> taskIdList);

		// Token: 0x0600052B RID: 1323
		string getPushActionResultByTaskids(List<string> taskIdList, List<string> actionIdList);

		// Token: 0x0600052C RID: 1324
		string getScheduleTask(string taskId, string appId);

		// Token: 0x0600052D RID: 1325
		string delScheduleTask(string taskId, string appId);

		// Token: 0x0600052E RID: 1326
		string unbindCidPn(string appId, List<string> cid);

		// Token: 0x0600052F RID: 1327
		string bindCidPn(string appId, Dictionary<string, string> cidAndPn);

		// Token: 0x06000530 RID: 1328
		string queryCidPn(string appId, List<string> cid);

		// Token: 0x06000531 RID: 1329
		string stopSendSms(string appId, string taskId);
	}
}
