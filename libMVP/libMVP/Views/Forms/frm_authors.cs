using System;
using System.Windows.Forms;

namespace libMVP.Views.Forms
{
	using libMVP.Logic.Presenter;
	using libMVP.Views.Interface;

	public partial class frm_authors : Form, IAoutors
	{
		public frm_authors()
		{
			InitializeComponent();
			authorsPresenter = new AuthorsPresenter(this);
		}

		private AuthorsPresenter authorsPresenter;

		public int ROW { get => row; set => row = value; }

		public int ID
		{
			get => Convert.ToInt32(txtID.Text);
			set => txtID.Text = value.ToString();
		}


		public string AuthorsName { get => txtName.Text; set => txtName.Text = value; }

		public string AuthorsDate { get => AouthorDate.Text; set => AouthorDate.Text = value; }

		public string AuthorsDispalyMember { get => cbxcountry.DisplayMember; set => cbxcountry.DisplayMember = value; }

		public string AuthorsValueMember { get => cbxcountry.ValueMember; set => cbxcountry.ValueMember = value; }

		public int CountryID { get => Convert.ToInt32(cbxcountry.SelectedValue); set => cbxcountry.SelectedValue = value; }

		public object DataGridView { get => dvg.DataSource; set => dvg.DataSource = value; }

		public object cbxCountry { get => cbxcountry.DataSource; set => cbxcountry.DataSource = value; }

		public object BtnAdd { get => btnAdd.Enabled; set => btnAdd.Enabled = Convert.ToBoolean(value); }

		public object BtnDelete { get => btnDelete.Enabled; set => btnDelete.Enabled = Convert.ToBoolean(value); }

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

		public int SelectedIndex
		{
			get => cbxcountry.SelectedIndex;
			set => cbxcountry.SelectedIndex = value;
		}

		public int SelectedValue
		{
			get => Convert.ToInt32(cbxcountry.SelectedValue);
			set => cbxcountry.SelectedValue = value;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtName.Text))
			{
				MessageBox.Show(@"placse enter Authors");
				return;
			}
			bool a = authorsPresenter.AuthoresInsert();
			MessageBox.Show(a ? "Add complete" : "error insert");
			if (!a) return;
			authorsPresenter.AutoNumber();
		}

		private void frm_authors_Load(object sender, EventArgs e)
		{
			authorsPresenter.FillCbx();
			authorsPresenter.AutoNumber();
			
		}

		private int row = 0;
		private void btnFirst_Click(object sender, EventArgs e)
		{
			row = 0;
			authorsPresenter.GetRow(row);

		}

		private void btnPrevios_Click(object sender, EventArgs e)
		{
			try
			{
				int counter = Convert.ToInt32(authorsPresenter.GetLastRow().Rows[0][0]) - 1;
				if (row != 0) row--;
				else row = counter;
				authorsPresenter.GetRow(row);
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
				int counter = Convert.ToInt32(authorsPresenter.GetLastRow().Rows[0][0]) - 1;

				if (counter != row) row++;
				else row = 0;

				authorsPresenter.GetRow(row);
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
				int lastRow = Convert.ToInt32(authorsPresenter.GetLastRow().Rows[0][0]) - 1;
				row = lastRow;
				authorsPresenter.GetRow(row);
			}
			catch (Exception exception)
			{
				MessageBox.Show($@"{exception}");
			}
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			frm_authors_Load(null, null);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtName.Text))
			{
				MessageBox.Show(@"placse enter Authors");
				return;
			}
			bool a = authorsPresenter.AuthoresUpdate();
			MessageBox.Show(a ? "update complete" : "error update");
			authorsPresenter.AutoNumber();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			bool a = authorsPresenter.AuthorDelete();
			MessageBox.Show(a ? "Delete complete" : "error Delete");
			authorsPresenter.AutoNumber();
		}

		private void btnDeleteAll_Click(object sender, EventArgs e)
		{
			bool a = authorsPresenter.AuthorDeleteAll();
			MessageBox.Show(a ? "Delete All complete" : "error Delete");
			this.authorsPresenter.AutoNumber();
		}
	}
}
