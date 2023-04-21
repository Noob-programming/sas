using System;
using System.Windows.Forms;

namespace libMVP.Views.Forms
{

	using libMVP.Logic.Presenter;
	using libMVP.Views.Interface;

	public partial class frm_country : Form, ICountry
	{
		private readonly countryPresenter countryPresenter;

		public frm_country()
		{
			InitializeComponent();
			countryPresenter = new countryPresenter(this);
		}

		private int row = 0;

		public int Id
		{
			get => Convert.ToInt32(txtID.Text);
			set => txtID.Text = value.ToString();
		}

		public string CountryName
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

		int ICountry.row
		{
			get => row;
			set => row = value;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtName.Text))
			{
				MessageBox.Show(@"places enter name of country");
				return;
			}

			bool a = countryPresenter.Countryinsert();
			MessageBox.Show(a ? "insert complete" : "error insert");

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtName.Text))
			{
				MessageBox.Show(@"places enter name of country");
				return;
			}

			bool a = countryPresenter.Countryupdate();
			MessageBox.Show(a ? "Update complete" : "error Update");

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			bool a = countryPresenter.Countrydelete();
			MessageBox.Show(a ? "Delete complete" : "error Delete");
		}

		private void btnDeleteAll_Click(object sender, EventArgs e)
		{
			bool a = countryPresenter.CountryDeleteAll();
			MessageBox.Show(a ? "Delete All complete" : "error Delete");
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			countryPresenter.Clear();
			countryPresenter.AutoNumber();
		}

		private void frm_country_Load(object sender, EventArgs e)
		{
			countryPresenter.CountryGetAll();
			countryPresenter.AutoNumber();
		}

		private void btnFirst_Click(object sender, EventArgs e)
		{
			row = 0;
			countryPresenter.GetRow(row);
		}

		private void btnPrevios_Click(object sender, EventArgs e)
		{
			try
			{
				int counter = Convert.ToInt32(countryPresenter.GetLastRow().Rows[0][0]) - 1;
				if (row != 0) row--;
				else row = counter;
				countryPresenter.GetRow(row);
			}
			catch (Exception exception)
			{
				MessageBox.Show($@"{exception}");
			}


		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			try
			{
				int counter = Convert.ToInt32(countryPresenter.GetLastRow().Rows[0][0]) - 1;

				if (counter != row) row++;
				else row = 0;

				countryPresenter.GetRow(row);
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
				int lastRow = Convert.ToInt32(countryPresenter.GetLastRow().Rows[0][0]) - 1;
				row = lastRow;
				countryPresenter.GetRow(row);
			}
			catch (Exception exception)
			{
				MessageBox.Show($@"{exception}");
			}

		}
	}
}
