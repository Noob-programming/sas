namespace libMVP.Logic.Services
{
	using System.Data;
	using System.Data.SqlClient;

	class AuthorsService
	{
		// authors table
		public static bool AuthorsInsert(int id, string name, string date, int CID)
		{
			return DBHelper.excuteData("AuthoresInsert", () => AuthorsParmeterInsert(id, name, date, CID, DBHelper.sqlCommand));
		}

		private static void AuthorsParmeterInsert(int id, string name, string date, int CID, SqlCommand command)
		{
			command.Parameters.Add("@id", SqlDbType.Int).Value = id;
			command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
			command.Parameters.Add("@date", SqlDbType.NVarChar).Value = date;
			command.Parameters.Add("@countryID", SqlDbType.Int).Value = CID;
		}

		public static bool AuthorsUpdate(int id, string name, string date, int CID)
		{
			return DBHelper.excuteData("AuthoresUpdate", () => AuthorsParmeterUpdate(id, name, date, CID, DBHelper.sqlCommand));
		}

		private static void AuthorsParmeterUpdate(int id, string name, string date, int CID, SqlCommand command)
		{
			command.Parameters.Add("@id", SqlDbType.Int).Value = id;
			command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
			command.Parameters.Add("@date", SqlDbType.NVarChar).Value = date;
			command.Parameters.Add("@countryID", SqlDbType.Int).Value = CID;
		}

		//select all data from data base or return table to cbx
		public static DataTable countryGetAll()
		{
			return DBHelper.getData("countryGetAll", () => { });
		}
		public static DataTable GetAuthorMaXID()
		{
			return DBHelper.getData("authorMaxID", () => { });
		}

		public static DataTable authorGetAll()
		{
			return DBHelper.getData("authorGetAll", () => { });
		}
		public static DataTable authorGetLastRow()
		{
			return DBHelper.getData("authorGetLastRow", () => { });
		}
		public static DataTable authorGetAllCountryID()
		{
			return DBHelper.getData("authorGetAllCountryID", () => { });
		}

		public static bool AuthorDelete(int id)
		{
			return DBHelper.excuteData("authorDelete", () => AuthorParmeterDelete(id,DBHelper.sqlCommand));
		}

		private static void AuthorParmeterDelete(int id, SqlCommand command)
		{
			command.Parameters.Add("@id", SqlDbType.Int).Value = id;
		}

		public static bool AuthorDeleteِAll()
		{
			return DBHelper.excuteData("authorDeleteAll", () => { });
		}
	}
}
