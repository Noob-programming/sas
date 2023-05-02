namespace libMVP.Logic.Presenter
{
	using libMVP.Logic.Services;
	using libMVP.Model;
	using libMVP.Views.Interface;
	using System;
	using System.Data;
	using System.Windows.Forms;

	class AuthorsPresenter
	{
		private IAoutors iAoutors;

		private AuthorsModel authorsModel = new AuthorsModel();

		public AuthorsPresenter(IAoutors iAoutors)
		{
			this.iAoutors = iAoutors;
		}

		void conectBetweenModelInterface()
		{
			authorsModel.ID = iAoutors.ID;
			authorsModel.AuthorsName = iAoutors.AuthorsName;
			authorsModel.AuthorsDate = iAoutors.AuthorsDate;
			authorsModel.CountryID = iAoutors.CountryID;
		}
		//
		public bool AuthoresInsert()
		{
			conectBetweenModelInterface();
			DateTime date = Convert.ToDateTime(authorsModel.AuthorsDate);
			string d2 = date.ToString("dd/MM/yyyy");
			bool a = AuthorsService.AuthorsInsert(authorsModel.ID, authorsModel.AuthorsName,
				d2, authorsModel.CountryID);
			AuthorGetAll();
			AutoNumber();
			return a;

		}
		public void AuthorGetAll()
		{
			iAoutors.DataGridView = AuthorsService.authorGetAll();
			Clear();
		}

		public bool AuthoresUpdate()
		{
			conectBetweenModelInterface();
			DateTime date = Convert.ToDateTime(authorsModel.AuthorsDate);
			string d2 = date.ToString("dd/MM/yyyy");
			bool a = AuthorsService.AuthorsUpdate(authorsModel.ID, authorsModel.AuthorsName,
				d2, authorsModel.CountryID);
			AuthorGetAll();
			AutoNumber();
			return a;
		}
		public void FillCbx()
		{
			iAoutors.cbxCountry = AuthorsService.countryGetAll();
			iAoutors.AuthorsDispalyMember = "اسم الدولة";
			iAoutors.AuthorsValueMember = "رقم الدولة";
		}

		public void AutoNumber()
		{
			string ch = AuthorsService.GetAuthorMaXID().Rows[0][0].ToString();
			if (!string.IsNullOrEmpty(ch))
			{
				iAoutors.ID = Convert.ToInt32(AuthorsService.GetAuthorMaXID().Rows[0][0]) + 1;
				iAoutors.AuthorsName = "";
				iAoutors.AuthorsDate = DateTime.Now.ToShortDateString();
				iAoutors.SelectedIndex = 0;
				iAoutors.BtnUpdate = false;
				iAoutors.BtnDelete = false;
				iAoutors.BtnDeleteAll = false;
				iAoutors.BtnAdd = true;
				iAoutors.DataGridView = AuthorsService.authorGetAll();
			}
			else
			{
				iAoutors.ID = 1;
				iAoutors.BtnUpdate = false;
				iAoutors.BtnDelete = false;
				iAoutors.BtnDeleteAll = false;
				iAoutors.BtnAdd = true;
				iAoutors.SelectedIndex = 0;
				iAoutors.DataGridView = AuthorsService.authorGetAll();

			}
		}

		public void GetRow(int row)
		{
			DataTable tbl = new DataTable();
			tbl = AuthorsService.authorGetAllCountryID();
			iAoutors.ID = Convert.ToInt32(tbl.Rows[row][0]);
			iAoutors.AuthorsName = tbl.Rows[row][1].ToString();
			try
			{
				DateTime date = DateTime.ParseExact(Convert.ToString(tbl.Rows[row][2]), "dd/MM/yyyy", null);
				iAoutors.AuthorsDate = date.ToString();
			}
			catch (Exception e)
			{
				MessageBox.Show($@"{e}");
			}

			iAoutors.SelectedValue = Convert.ToInt32(tbl.Rows[row][3]);
			iAoutors.BtnUpdate = true;
			iAoutors.BtnDelete = true;
			iAoutors.BtnDeleteAll = true;
			iAoutors.BtnAdd = false;
		}

		public DataTable GetLastRow()
		{
			DataTable table = new DataTable();
			table = AuthorsService.authorGetLastRow();
			return table;
		}

		public bool AuthorDelete()
		{
			conectBetweenModelInterface();
			bool a = AuthorsService.AuthorDelete(authorsModel.ID);

			AuthorGetAll();
			AutoNumber();
			return a;

		}
		public void Clear()
		{
			iAoutors.ID = 0;
			iAoutors.AuthorsName = String.Empty;
		}

		public bool AuthorDeleteAll()
		{
			conectBetweenModelInterface();
			bool a = AuthorsService.AuthorDeleteِAll();
			AuthorGetAll();
			AutoNumber();
			return a;
		}
	}
}
