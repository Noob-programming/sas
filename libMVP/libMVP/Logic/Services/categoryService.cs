using System.Data;
using System.Data.SqlClient;

namespace libMVP.Logic.Services
{


	static class categoryService
	{
		//insert data in category storge poseger
		public static bool categoryinsert(int id, string name)
		{
			return DBHelper.excuteData("categoryinsert", () => categoryParmeterInsert(id, name, DBHelper.sqlCommand));
		}

		private static void categoryParmeterInsert(int id, string name, SqlCommand command)
		{
			command.Parameters.Add("@id", SqlDbType.Int).Value = id;
			command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
		}

		//delete
		public static bool categoryDelete(int id)
		{
			return DBHelper.excuteData("categorydelete", () => categoryParmeterDelete(id, DBHelper.sqlCommand));
		}

		private static void categoryParmeterDelete(int id, SqlCommand command)
		{
			command.Parameters.Add("@id", SqlDbType.Int).Value = id;
		}

		//update
		public static bool categoryUpdate(int id, string name)
		{
			return DBHelper.excuteData("categoryupdate", () => categoryParmeterUpdate(id, name, DBHelper.sqlCommand));
		}

		private static void categoryParmeterUpdate(int id, string name, SqlCommand command)
		{
			command.Parameters.Add("@id", SqlDbType.Int).Value = id;
			command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
		}

	}
}
