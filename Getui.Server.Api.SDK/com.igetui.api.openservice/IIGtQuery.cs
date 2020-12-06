using System;
using System.Collections.Generic;
using com.igetui.api.openservice.igetui;

namespace com.igetui.api.openservice
{
	// Token: 0x02000031 RID: 49
	public interface IIGtQuery
	{
		// Token: 0x06000532 RID: 1330
		string getClientIdStatus(string appId, string clientId);

		// Token: 0x06000533 RID: 1331
		string getPushResult(string contentId);

		// Token: 0x06000534 RID: 1332
		string getUserTags(string appId, string clientId);

		// Token: 0x06000535 RID: 1333
		string getPushResultByGroupName(string appId, string groupName);

		// Token: 0x06000536 RID: 1334
		string getLast24HoursOnlineUserStatistics(string appId);

		// Token: 0x06000537 RID: 1335
		string getPersonaTags(string appId);

		// Token: 0x06000538 RID: 1336
		string queryUserCount(string appId, AppConditions conditions);

		// Token: 0x06000539 RID: 1337
		string setBadgeForCID(string badge, string appid, List<string> cidList);

		// Token: 0x0600053A RID: 1338
		string setBadgeForDeviceToken(string badge, string appid, List<string> deviceTokenList);
	}
}
