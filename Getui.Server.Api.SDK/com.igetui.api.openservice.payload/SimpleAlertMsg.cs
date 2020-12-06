namespace com.igetui.api.openservice.payload
{
    // Token: 0x02000042 RID: 66
    public class SimpleAlertMsg : AlertMsg
	{
		// Token: 0x0600057A RID: 1402 RVA: 0x0000CBD3 File Offset: 0x0000ADD3
		public SimpleAlertMsg(string alertMsg)
		{
			this.alertMsg = alertMsg;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0000CBE2 File Offset: 0x0000ADE2
		public SimpleAlertMsg()
		{
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0000CBEA File Offset: 0x0000ADEA
		public object getAlertMsg()
		{
			return alertMsg;
		}

		// Token: 0x04000316 RID: 790
		private string alertMsg;
	}
}
