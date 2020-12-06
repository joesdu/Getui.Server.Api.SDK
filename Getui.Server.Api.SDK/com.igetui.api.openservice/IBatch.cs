using System;
using com.igetui.api.openservice.igetui;

namespace com.igetui.api.openservice
{
	// Token: 0x0200002C RID: 44
	public interface IBatch
	{
		// Token: 0x060004C1 RID: 1217
		void setApiUrl(string apiUrl);

		// Token: 0x060004C2 RID: 1218
		string add(SingleMessage message, Target target);

		// Token: 0x060004C3 RID: 1219
		string submit();

		// Token: 0x060004C4 RID: 1220
		string retry();
	}
}
