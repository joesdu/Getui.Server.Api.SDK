using System;
using System.Collections.Generic;

namespace com.igetui.api.openservice
{
	// Token: 0x02000035 RID: 53
	public interface IPushResult
	{
		// Token: 0x0600053D RID: 1341
		EPushResult getResultCode();

		// Token: 0x0600053E RID: 1342
		string getTaskId();

		// Token: 0x0600053F RID: 1343
		string getMessageId();

		// Token: 0x06000540 RID: 1344
		Dictionary<string, object> getResponse();
	}
}
