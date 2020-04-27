namespace UniStorage
{
	/// <summary>
	/// ストレージの空き容量を返すデフォルトのクラス
	/// </summary>
	public sealed class DefaultStorage : IStorage
	{
		//================================================================================
		// 関数
		//================================================================================
		/// <summary>
		/// 空き容量を返します
		/// </summary>
		public long GetFreeSpace()
		{
			return -1;
		}
	}
}