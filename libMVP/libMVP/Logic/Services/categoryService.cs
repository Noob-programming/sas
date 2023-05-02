using System.Data;
using System.Data.SqlClient;

namespace libMVP.Logic.Services
{


	static class categoryService
	{
		//insert data in category storge poseger
		public static bool categoryinsert(int id, string name)
		{
			return DBHelper.excuteData("categoryInsert", () => categoryParmeterInsert(id, name, DBHelper.sqlCommand));
		}

		private static void categoryParmeterInsert(int id, string name, SqlCommand command)
		{
			command.Parameters.Add("@id", SqlDbType.Int).Value = id;
			command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
		}

		//delete
		public static bool categoryDelete(int id)
		{
			return DBHelper.excuteData("categoryDelete", () => categoryParmeterDelete(id, DBHelper.sqlCommand));
		}

		private static void categoryParmeterDelete(int id, SqlCommand command)
		{
			command.Parameters.Add("@id", SqlDbType.Int).Value = id;
		}

		//update
		public static bool categoryUpdate(int id, string name)
		{
			return DBHelper.excuteData("categoryUpdate", () => categoryParmeterUpdate(id, name, DBHelper.sqlCommand));
		}

		private static void categoryParmeterUpdate(int id, string name, SqlCommand command)
		{
			command.Parameters.Add("@id", SqlDbType.Int).Value = id;
			command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
		}


		public static bool categoryDeleteِAll()
		{
			// ReSharper disable once ConvertClosureToMethodGroup
			return DBHelper.excuteData("categoryDeleteAll", () => { });
		}


		public static DataTable categoryGetAll()
		{
			return DBHelper.getData("categoryGetAll", () => { });
		}

		//get last row in table
		public static DataTable categoryGetLastRow()
		{
			return DBHelper.getData("categoryGetLastRow", () => { });
		}

		//get max id in table
		public static DataTable categoryMaxID()
		{
			return DBHelper.getData("categoryMaxID", () => { });
		}

	}
}
