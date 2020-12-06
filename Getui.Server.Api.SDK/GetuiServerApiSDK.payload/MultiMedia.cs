namespace GetuiServerApiSDK.payload
{
    public class MultiMedia
	{
        public string rid { get; set; }
        public string url { get; set; }

        public int onlywifi { get; private set; }

        public void setIsOnlyWifi(bool value)
		{
			onlywifi = (value ? 1 : 0);
		}
        public MediaType type { get; set; }

        public enum MediaType
		{
			pic = 1,
			audio,
			video
		}
	}
}
