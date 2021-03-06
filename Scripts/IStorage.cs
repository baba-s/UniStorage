﻿namespace Kogane
{
	/// <summary>
	/// ストレージの空き容量を返すインターフェイス
	/// </summary>
	internal interface IStorage
	{
		//================================================================================
		// 関数
		//================================================================================
		/// <summary>
		/// 空き容量を返します
		/// </summary>
		long GetFreeSpace();
	}
}