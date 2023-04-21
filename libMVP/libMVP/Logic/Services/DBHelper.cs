using System.Data.SqlClient;
namespace libMVP.Logic.Services
{
	using System;
	using System.Data;
	using System.Windows.Forms;

	public static class DBHelper
	{
		public static SqlCommand sqlCommand;



		private static SqlConnection getConnitionString()
		{
			var builder = new SqlConnectionStringBuilder();
			builder.DataSource = Properties.Settings.Default.ServerName;
			builder.InitialCatalog = Properties.Settings.Default.DBName;
			builder.IntegratedSecurity = Properties.Settings.Default.SecurityInfo;
			builder.UserID = Properties.Settings.Default.UserName;
			builder.Password = Properties.Settings.Default.PassWord;

			return new SqlConnection(builder.ConnectionString);
		}


		public static bool excuteData(string SPname, Action method)
		{

			using (var sqlConnection = getConnitionString())
			{
				try
				{
					sqlCommand = new SqlCommand(SPname, sqlConnection);
					sqlCommand.CommandType = CommandType.StoredProcedure;

					// to execute method have parameter
					method.Invoke();

					sqlConnection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
					return true;
				}
				catch (Exception e)
				{
					sqlConnection.Close();
					MessageBox.Show($@"{e}");
				}
				finally
				{
					sqlConnection.Close();
				}
			}

			return false;
		}

		//get data from database to DGV
		public static DataTable getData(string SPname, Action method)
		{
			var tbl = new DataTable();
			using (var sqlConnection = getConnitionString())
			{
				SqlDataAdapter dl = null;
				try
				{
					sqlCommand = new SqlCommand(SPname, sqlConnection);
					sqlCommand.CommandType = CommandType.StoredProcedure;

					// to execute method have parameter
					method.Invoke();

					sqlConnection.Open();

					dl = new SqlDataAdapter(sqlCommand);
					dl.Fill(tbl);
					dl.Dispose();

					sqlConnection.Close();

				}
				catch (Exception e)
				{
					dl?.Dispose();
					sqlConnection.Close();
					MessageBox.Show($@"{e}");
				}
				finally
				{
					dl?.Dispose();

					sqlConnection.Close();
				}
			}

			return tbl;
		}
	}
}
