namespace libMVP.Logic.Presenter
{
	using libMVP.Logic.Services;
	using libMVP.Model;
	using libMVP.Views.Interface;
	using System;
	using System.Data;

	class countryPresenter
	{
		private ICountry iCountry;

		private CountryModel CountryModel = new CountryModel();

		public countryPresenter(ICountry iCategory)
		{
			iCountry = iCategory;
		}


		void ConectBetweenModelInterface()
		{
			CountryModel.Id = iCountry.Id;
			CountryModel.CountryName = iCountry.CountryName;
		}

		public bool Countryinsert()
		{
			ConectBetweenModelInterface();
			bool a = countryService.countryinsert(CountryModel.Id, CountryModel.CountryName);
			CountryGetAll();
			AutoNumber();
			return a;
		}

		public bool Countryupdate()
		{
			ConectBetweenModelInterface();
			bool a = countryService.countryUpdate(CountryModel.Id, CountryModel.CountryName);
			CountryGetAll();
			AutoNumber();
			return a;
		}

		public bool Countrydelete()
		{
			ConectBetweenModelInterface();
			bool a = countryService.countryDelete(CountryModel.Id);
			CountryGetAll();
			AutoNumber();
			return a;
		}

		public bool CountryDeleteAll()
		{
			ConectBetweenModelInterface();
			bool a = countryService.countryDeleteAll();
			CountryGetAll();
			AutoNumber();
			return a;
		}

		public void Clear()
		{

			iCountry.Id = 0;
			iCountry.CountryName = string.Empty;

		}

		public void CountryGetAll()
		{
			iCountry.DataGridView = countryService.countryGetAll();
			Clear();
		}

		public void AutoNumber()
		{
			string ch = countryService.countryMaxID().Rows[0][0].ToString();
			if (!string.IsNullOrEmpty(ch))
			{
				iCountry.Id = Convert.ToInt32(countryService.countryMaxID().Rows[0][0]) + 1;
				iCountry.CountryName = "";
				iCountry.BtnUpdate = false;
				iCountry.BtnDelete = false;
				iCountry.BtnDeleteAll = false;
				iCountry.BtnAdd = true;
			}
			else
			{
				iCountry.Id = 1;
			}
		}

		public void GetRow(int row)
		{
			DataTable tbl = new DataTable();
			tbl = countryService.countryGetAll();
			iCountry.Id = Convert.ToInt32(tbl.Rows[row][0]);
			iCountry.CountryName = tbl.Rows[row][1].ToString();
			iCountry.BtnUpdate = true;
			iCountry.BtnDelete = true;
			iCountry.BtnDeleteAll = true;
			iCountry.BtnAdd = false;
		}

		public DataTable GetLastRow()
		{
			DataTable table = new DataTable();
			table = countryService.countryGetLastRow();
			return table;
		}
	}
}
