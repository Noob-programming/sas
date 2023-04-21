using System;
using System.Windows.Forms;

namespace libMVP.Views.Forms
{
	using libMVP.Logic.Presenter;
	using libMVP.Views.Interface;

	public partial class frm_category : Form, ICategory
	{
		private readonly categoryPresenter categoryPresenter;
		public frm_category()
		{
			InitializeComponent();
			categoryPresenter = new categoryPresenter(this);

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

		public object DataGridView
		{
			get => dvg.DataSource;
			set => dvg.DataSource = value;
		}

		public object BtnAdd
		{
			get => btnAdd.Enabled;
			set => btnAdd.Enabled = Convert.ToBoolean(value);
		}

		public object BtnDelete
		{
			get => btnDelete.Enabled;
			set => btnDelete.Enabled = Convert.ToBoolean(value);
		}

		public object BtnUpdate
		{
			get => btnSave.Enabled;
			set => btnSave.Enabled = Convert.ToBoolean(value);
		}

		public object BtnDeleteAll
		{
			get => btnDeleteAll.Enabled;
			set => btnDeleteAll.Enabled = Convert.ToBoolean(value);
		}

		public object BtnNew
		{
			get => btnNew.Enabled;
			set => btnNew.Enabled = Convert.ToBoolean(value);
		}

		private int row = 0;
		int ICategory.Row { get => row; set => row = value; }

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtName.Text))
			{
				MessageBox.Show(@"placse enter category");
				return;
			}
			bool a = categoryPresenter.Catinsert();
			MessageBox.Show(a ? "Add complete" : "error insert");
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtName.Text))
			{
				MessageBox.Show(@"placse enter category");
				return;
			}
			bool a = categoryPresenter.CatUpdate();
			MessageBox.Show(a ? "update complete" : "error update");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			bool a = categoryPresenter.CatDelete();
			MessageBox.Show(a ? "Delete complete" : "error Delete");
		}

		private void btnDeleteAll_Click(object sender, EventArgs e)
		{
			bool a = categoryPresenter.CatDeleteAll();
			MessageBox.Show(a ? "Delete All complete" : "error Delete");
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			categoryPresenter.Clear();
			categoryPresenter.AutoNumber();
		}

		private void frm_category_Load(object sender, EventArgs e)
		{
			categoryPresenter.CategoryGetAll();
			categoryPresenter.AutoNumber();
		}

		private void btnPrevios_Click(object sender, EventArgs e)
		{
			try
			{
				int counter = Convert.ToInt32(categoryPresenter.GetLastRow().Rows[0][0]) - 1;
				if (row != 0) row--;
				else row = counter;
				categoryPresenter.GetRow(row);
			}
			catch (Exception exception)
			{
				MessageBox.Show($@"{exception}");
			}
		}

		private void btnFirst_Click(object sender, EventArgs e)
		{
			row = 0;
			categoryPresenter.GetRow(row);
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			try
			{
				int counter = Convert.ToInt32(categoryPresenter.GetLastRow().Rows[0][0]) - 1;

				if (counter != row) row++;
				else row = 0;

				categoryPresenter.GetRow(row);
			}
			catch (Exception exception)
			{
				MessageBox.Show($@"{exception}");
			}
		}

		private void btnLast_Click(object sender, EventArgs e)
		{
			try
			{
				int lastRow = Convert.ToInt32(categoryPresenter.GetLastRow().Rows[0][0]) - 1;
				row = lastRow;
				categoryPresenter.GetRow(row);
			}
			catch (Exception exception)
			{
				MessageBox.Show($@"{exception}");
			}
		}
	}
}
