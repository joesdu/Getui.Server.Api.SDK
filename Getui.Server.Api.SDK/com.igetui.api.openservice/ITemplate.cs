using System;
using com.gexin.rp.sdk.dto;

namespace com.igetui.api.openservice
{
	// Token: 0x02000037 RID: 55
	public interface ITemplate
	{
		// Token: 0x06000542 RID: 1346
		Transparent getTransparent();

		// Token: 0x06000543 RID: 1347
		string getTransmissionContent();

		// Token: 0x06000544 RID: 1348
		string getPushType();

		// Token: 0x06000545 RID: 1349
		PushInfo getPushInfo();
	}
}
