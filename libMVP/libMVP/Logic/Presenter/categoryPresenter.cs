namespace libMVP.Logic.Presenter
{
	using libMVP.Logic.Services;
	using libMVP.Model;
	using libMVP.Views.Interface;
	using System;
	using System.Data;
	using static System.String;

	class categoryPresenter
	{
		private ICategory iCategory;

		private CategoryModel categoryModel = new CategoryModel();

		public categoryPresenter(ICategory iCategory)
		{
			this.iCategory = iCategory;
		}


		void conectBetweenModelInterface()
		{
			categoryModel.Id = iCategory.Id;
			categoryModel.CatName = iCategory.CatName;
		}


		public bool Catinsert()
		{
			conectBetweenModelInterface();
			bool a = categoryService.categoryinsert(categoryModel.Id, categoryModel.CatName);
			CategoryGetAll();
			AutoNumber();
			return a;
		}

		public bool CatUpdate()
		{
			conectBetweenModelInterface();
			bool a = categoryService.categoryUpdate(categoryModel.Id, categoryModel.CatName);
			CategoryGetAll();
			AutoNumber();
			return a;
		}

		public bool CatDelete()
		{
			conectBetweenModelInterface();
			bool a = categoryService.categoryDelete(categoryModel.Id);
			CategoryGetAll();
			AutoNumber();
			return a;
		}

		public bool CatDeleteAll()
		{
			conectBetweenModelInterface();
			bool a = categoryService.categoryDeleteِAll();
			CategoryGetAll();
			AutoNumber();
			return a;
		}
		public void Clear()
		{

			iCategory.Id = 0;
			iCategory.CatName = Empty;
		}

		public void CategoryGetAll()
		{
			iCategory.DataGridView = categoryService.categoryGetAll();
			Clear();
		}


		public void AutoNumber()
		{
			string ch = categoryService.categoryMaxID().Rows[0][0].ToString();
			if (!string.IsNullOrEmpty(ch))
			{
				iCategory.Id = Convert.ToInt32(categoryService.categoryMaxID().Rows[0][0]) + 1;
				iCategory.CatName = "";
				iCategory.BtnUpdate = false;
				iCategory.BtnDelete = false;
				iCategory.BtnDeleteAll = false;
				iCategory.BtnAdd = true;
			}
			else
			{
				iCategory.Id = 1;
			}
		}

		public void GetRow(int row)
		{
			DataTable tbl = new DataTable();
			tbl = categoryService.categoryGetAll();
			iCategory.Id = Convert.ToInt32(tbl.Rows[row][0]);
			iCategory.CatName = tbl.Rows[row][1].ToString();
			iCategory.BtnUpdate = true;
			iCategory.BtnDelete = true;
			iCategory.BtnDeleteAll = true;
			iCategory.BtnAdd = false;
		}

		public DataTable GetLastRow()
		{
			DataTable table = new DataTable();
			table = categoryService.categoryGetLastRow();
			return table;
		}
	}
}
