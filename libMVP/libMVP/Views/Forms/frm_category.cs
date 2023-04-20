using System;
using System.Windows.Forms;

namespace libMVP.Views.Forms
{
	using libMVP.Logic.Presenter;
	using libMVP.Views.Interface;

	public partial class frm_category : Form, ICategory
	{
		private categoryPresenter carPresenter;
		public frm_category()
		{
			InitializeComponent();
			carPresenter = new categoryPresenter(this);

		}

		public int Id
		{
			get => Convert.ToInt32(txtID.Text);
			set => txtID.Text = value.ToString();
		}
		public string CatName
		{
			get => txtName.Text;
			set => txtName.Text = value;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			bool a = carPresenter.catinsert();
			MessageBox.Show(a ? "Add complete" : "error insert");
		}
	}
}
