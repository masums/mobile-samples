namespace SQLite.Android.Sample
{
	public class List
	{
		[PrimaryKey, AutoIncrement]
		public int Id
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}
	}
}