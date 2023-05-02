namespace libMVP.Views.Interface
{
	interface IAoutors
	{
		int ROW { get; set; }
		int ID { get; set; }
		string AuthorsName { get; set; }
		string AuthorsDate { get; set; }
		string AuthorsDispalyMember { get; set; }
		string AuthorsValueMember { get; set; }
		int CountryID { get; set; }
		object DataGridView { get; set; }
		object cbxCountry { get; set; }
		object BtnAdd { get; set; }
		object BtnDelete { get; set; }
		object BtnUpdate { get; set; }
		object BtnDeleteAll { get; set; }
		object BtnNew { get; set; }
		int SelectedIndex { get; set; }
		int SelectedValue{ get; set; }
	}
}
