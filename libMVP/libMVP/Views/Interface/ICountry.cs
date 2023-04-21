namespace libMVP.Views.Interface
{
	public interface ICountry
	{
		int Id { get; set; }
		int row { get; set; }
		string CountryName { get; set; }
		object DataGridView { get; set; }

		object BtnAdd { get; set; }
		object BtnDelete { get; set; }
		object BtnUpdate { get; set; }
		object BtnDeleteAll { get; set; }
		object BtnNew { get; set; }


	}
}
