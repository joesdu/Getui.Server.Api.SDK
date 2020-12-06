using System;
using System.Collections.Generic;
using com.igetui.api.openservice.igetui;

namespace com.igetui.api.openservice
{
	// Token: 0x02000032 RID: 50
	public interface IListProvider
	{
		// Token: 0x0600053B RID: 1339
		List<Target> getClientList(int page);
	}
}
