﻿namespace libMVP.Views.Interface
{
	public interface ICategory
	{
		int Id { get; set; }

		int Row { get; set; }
		string CatName { get; set; }

		object DataGridView { get; set; }

		object BtnAdd { get; set; }
		object BtnDelete { get; set; }
		object BtnUpdate { get; set; }
		object BtnDeleteAll { get; set; }
		object BtnNew { get; set; }
	}
}
