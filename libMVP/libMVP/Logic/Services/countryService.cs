namespace libMVP.Logic.Services
{
	using System.Data;
	using System.Data.SqlClient;

	static class countryService
	{
		//insert country
		public static bool countryinsert(int id, string name)
		{
			return DBHelper.excuteData("countryinsert", () => countryParmeterInsert(id, name, DBHelper.sqlCommand));
		}

		private static void countryParmeterInsert(int id, string name, SqlCommand command)
		{
			command.Parameters.Add("@id", SqlDbType.Int).Value = id;
			command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
		}

		//update country
		public static bool countryUpdate(int id, string name)
		{
			return DBHelper.excuteData("countryupdate", () => countryParmeterUpdate(id, name, DBHelper.sqlCommand));
		}

		private static void countryParmeterUpdate(int id, string name, SqlCommand command)
		{
			command.Parameters.Add("@id", SqlDbType.Int).Value = id;
			command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
		}

		//delete country
		public static bool countryDelete(int id)
		{
			return DBHelper.excuteData("countrydelete", () => countryParmeterDelete(id, DBHelper.sqlCommand));
		}

		private static void countryParmeterDelete(int id, SqlCommand command)
		{
			command.Parameters.Add("@id", SqlDbType.Int).Value = id;
		}

		// delete all data
		public static bool countryDeleteAll()
		{
			return DBHelper.excuteData("countrydeleteAll", () => { });
		}

		//private static void countryParmeterDeleteAll()
		//{

		//}

		//select all data from data base or return table
		public static DataTable countryGetAll()
		{
			return DBHelper.getData("countryGetAll", () => { });
		}

		public static DataTable countryGetLastRow()
		{
			return DBHelper.getData("countryGetLastRow", () => { });
		}
		//get max id in table
		public static DataTable countryMaxID()
		{
			return DBHelper.getData("countryMaxID", () => { });
		}
	}
}
