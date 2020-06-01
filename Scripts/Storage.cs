namespace Kogane
{
	/// <summary>
	/// ストレージの空き容量を返すクラス
	/// </summary>
	public static class Storage
	{
		//================================================================================
		// 変数(static readonly)
		//================================================================================
		private static readonly IStorage ms_storage =
#if !UNITY_EDITOR && UNITY_ANDROID
			new AndroidStorage();
#elif !UNITY_EDITOR && UNITY_IOS
			new iOSStorage();
#else
			new DefaultStorage();
#endif
		
		//================================================================================
		// 関数(static)
		//================================================================================
		/// <summary>
		/// 空き容量を返します
		/// </summary>
		public static long GetFreeSpace()
		{
			return ms_storage.GetFreeSpace();
		}
	}
}