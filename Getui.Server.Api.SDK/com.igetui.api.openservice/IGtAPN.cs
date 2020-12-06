using System;
using System.Collections.Generic;
using com.igetui.api.openservice.igetui;

namespace com.igetui.api.openservice
{
	// Token: 0x0200002D RID: 45
	internal interface IGtAPN
	{
		// Token: 0x060004C5 RID: 1221
		string pushAPNMessageToSingle(string appId, string deviceToken, SingleMessage message);

		// Token: 0x060004C6 RID: 1222
		string pushAPNMessageToList(string appId, string contentId, List<string> deviceTokenList);

		// Token: 0x060004C7 RID: 1223
		string getAPNContentId(string appId, ListMessage message);
	}
}
