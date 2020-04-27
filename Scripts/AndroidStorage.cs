#if !UNITY_EDITOR && UNITY_ANDROID

using UnityEngine;

namespace UniStorage
{
	/// <summary>
	/// Android のストレージの空き容量を返すクラス
	/// </summary>
	public sealed class AndroidStorage : IStorage
	{
		//================================================================================
		// 関数
		//================================================================================
		/// <summary>
		/// 空き容量を返します
		/// </summary>
		public long GetFreeSpace()
		{
			using ( var statFs = new AndroidJavaObject( "android.os.StatFs", Application.temporaryCachePath ) )
			{
				var availableBlocksLong = statFs.Call<long>( "getAvailableBlocksLong" );
				var blockSizeLong       = statFs.Call<long>( "getBlockSizeLong" );
				var freeSpace           = availableBlocksLong * blockSizeLong;

				return freeSpace;
			}
		}
	}
}

#endif