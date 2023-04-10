namespace libMVP.Views.Forms
{
	partial class frm_authors
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_authors));
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbxcountry = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnNext = new DevExpress.XtraEditors.SimpleButton();
			this.btnPrevios = new DevExpress.XtraEditors.SimpleButton();
			this.btnFirst = new DevExpress.XtraEditors.SimpleButton();
			this.btnLast = new DevExpress.XtraEditors.SimpleButton();
			this.btnSave = new DevExpress.XtraEditors.SimpleButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnDeleteAll = new DevExpress.XtraEditors.SimpleButton();
			this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
			this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
			this.btnNew = new DevExpress.XtraEditors.SimpleButton();
			this.dvg = new System.Windows.Forms.DataGridView();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dvg)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(497, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 19);
			this.label3.TabIndex = 4;
			this.label3.Text = "دولة المؤلف : ";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbxcountry);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.txtID);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(591, 100);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "بيانات المؤلفين";
			// 
			// cbxcountry
			// 
			this.cbxcountry.FormattingEnabled = true;
			this.cbxcountry.Location = new System.Drawing.Point(315, 67);
			this.cbxcountry.Name = "cbxcountry";
			this.cbxcountry.Size = new System.Drawing.Size(158, 27);
			this.cbxcountry.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(213, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 19);
			this.label2.TabIndex = 4;
			this.label2.Text = "اسم المؤلف :";
			// 
			// txtID
			// 
			this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtID.Location = new System.Drawing.Point(315, 25);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(184, 26);
			this.txtID.TabIndex = 2;
			this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtName
			// 
			this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(23, 25);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(184, 26);
			this.txtName.TabIndex = 3;
			this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(505, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 19);
			this.label1.TabIndex = 5;
			this.label1.Text = "رقم المؤلف :";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnNext);
			this.groupBox2.Controls.Add(this.btnPrevios);
			this.groupBox2.Controls.Add(this.btnFirst);
			this.groupBox2.Controls.Add(this.btnLast);
			this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(199, 118);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(240, 59);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "اسهم التنقال";
			// 
			// btnNext
			// 
			this.btnNext.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.ImageOptions.Image")));
			this.btnNext.Location = new System.Drawing.Point(122, 25);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(44, 23);
			this.btnNext.TabIndex = 2;
			// 
			// btnPrevios
			// 
			this.btnPrevios.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevios.ImageOptions.Image")));
			this.btnPrevios.Location = new System.Drawing.Point(55, 25);
			this.btnPrevios.Name = "btnPrevios";
			this.btnPrevios.Size = new System.Drawing.Size(43, 23);
			this.btnPrevios.TabIndex = 3;
			// 
			// btnFirst
			// 
			this.btnFirst.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.ImageOptions.Image")));
			this.btnFirst.Location = new System.Drawing.Point(6, 25);
			this.btnFirst.Name = "btnFirst";
			this.btnFirst.Size = new System.Drawing.Size(43, 23);
			this.btnFirst.TabIndex = 0;
			// 
			// btnLast
			// 
			this.btnLast.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.ImageOptions.Image")));
			this.btnLast.Location = new System.Drawing.Point(172, 25);
			this.btnLast.Name = "btnLast";
			this.btnLast.Size = new System.Drawing.Size(44, 23);
			this.btnLast.TabIndex = 0;
			// 
			// btnSave
			// 
			this.btnSave.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Appearance.Options.UseFont = true;
			this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
			this.btnSave.Location = new System.Drawing.Point(268, 25);
			this.btnSave.LookAndFeel.UseWindowsXPTheme = true;
			this.btnSave.Name = "btnSave";
			this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnSave.Size = new System.Drawing.Size(98, 44);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "حفظ";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnDeleteAll);
			this.groupBox3.Controls.Add(this.btnAdd);
			this.groupBox3.Controls.Add(this.btnDelete);
			this.groupBox3.Controls.Add(this.btnNew);
			this.groupBox3.Controls.Add(this.btnSave);
			this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(12, 211);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(591, 75);
			this.groupBox3.TabIndex = 12;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "العمليات المتاحة";
			// 
			// btnDeleteAll
			// 
			this.btnDeleteAll.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteAll.Appearance.Options.UseFont = true;
			this.btnDeleteAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAll.ImageOptions.Image")));
			this.btnDeleteAll.Location = new System.Drawing.Point(60, 25);
			this.btnDeleteAll.LookAndFeel.UseWindowsXPTheme = true;
			this.btnDeleteAll.Name = "btnDeleteAll";
			this.btnDeleteAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnDeleteAll.Size = new System.Drawing.Size(98, 44);
			this.btnDeleteAll.TabIndex = 3;
			this.btnDeleteAll.Text = "مسح الكل";
			// 
			// btnAdd
			// 
			this.btnAdd.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Appearance.Options.UseFont = true;
			this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
			this.btnAdd.Location = new System.Drawing.Point(372, 25);
			this.btnAdd.LookAndFeel.UseWindowsXPTheme = true;
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnAdd.Size = new System.Drawing.Size(98, 44);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "اضافة";
			// 
			// btnDelete
			// 
			this.btnDelete.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Appearance.Options.UseFont = true;
			this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
			this.btnDelete.Location = new System.Drawing.Point(164, 25);
			this.btnDelete.LookAndFeel.UseWindowsXPTheme = true;
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnDelete.Size = new System.Drawing.Size(98, 44);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "مسح";
			// 
			// btnNew
			// 
			this.btnNew.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNew.Appearance.Options.UseFont = true;
			this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
			this.btnNew.Location = new System.Drawing.Point(476, 25);
			this.btnNew.LookAndFeel.UseWindowsXPTheme = true;
			this.btnNew.Name = "btnNew";
			this.btnNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnNew.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
			this.btnNew.Size = new System.Drawing.Size(97, 44);
			this.btnNew.TabIndex = 4;
			this.btnNew.Text = "جديد";
			// 
			// dvg
			// 
			this.dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dvg.Location = new System.Drawing.Point(609, 12);
			this.dvg.Name = "dvg";
			this.dvg.Size = new System.Drawing.Size(425, 274);
			this.dvg.TabIndex = 13;
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(23, 65);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(184, 26);
			this.textBox1.TabIndex = 3;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(219, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 19);
			this.label4.TabIndex = 4;
			this.label4.Text = "تاريخ الميلاد :";
			// 
			// frm_authors
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1046, 301);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.dvg);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.Name = "frm_authors";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "بيانات المؤلفين";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dvg)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cbxcountry;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private DevExpress.XtraEditors.SimpleButton btnNext;
		private DevExpress.XtraEditors.SimpleButton btnPrevios;
		private DevExpress.XtraEditors.SimpleButton btnFirst;
		private DevExpress.XtraEditors.SimpleButton btnLast;
		private DevExpress.XtraEditors.SimpleButton btnSave;
		private System.Windows.Forms.GroupBox groupBox3;
		private DevExpress.XtraEditors.SimpleButton btnDeleteAll;
		private DevExpress.XtraEditors.SimpleButton btnAdd;
		private DevExpress.XtraEditors.SimpleButton btnDelete;
		private DevExpress.XtraEditors.SimpleButton btnNew;
		private System.Windows.Forms.DataGridView dvg;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
	}
}