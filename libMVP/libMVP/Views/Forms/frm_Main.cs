using DevExpress.XtraBars;

namespace libMVP.Views.Forms
{
	public partial class frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		public frm_Main()
		{
			InitializeComponent();
		}

		private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
		{
			var f = new frm_country();
			f.ShowDialog();
		}

		private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
		{
			var f = new frm_category();
			f.ShowDialog();
		}

		private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
		{
			var f = new frm_BookPlace();
			f.ShowDialog();
		}

		private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
		{
			var f = new frm_HomeShare();
			f.ShowDialog();
		}

		private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
		{
			var f = new frm_authors();
			f.ShowDialog();
		}
	}
}