#if !UNITY_EDITOR && UNITY_IOS

using System.Runtime.InteropServices;

namespace UniStorage
{
	/// <summary>
	/// iOS のストレージの空き容量を返すクラス
	/// </summary>
	public sealed class iOSStorage : IStorage
	{
		//================================================================================
		// 関数(extern)
		//================================================================================
		[DllImport( "__Internal" )]
		private static extern long _GetFreeSpace();

		//================================================================================
		// 関数
		//================================================================================
		/// <summary>
		/// 空き容量を返します
		/// </summary>
		public long GetFreeSpace()
		{
			return _GetFreeSpace();
		}
	}
}

#endif