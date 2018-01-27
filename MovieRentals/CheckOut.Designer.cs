namespace MovieRentals
{
	partial class CheckOut
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOut));
			this.txtCustomerFilter = new System.Windows.Forms.TextBox();
			this.gridCustomer = new System.Windows.Forms.DataGridView();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gridMovieIn = new System.Windows.Forms.DataGridView();
			this.CopyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MovieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtInFilter = new System.Windows.Forms.TextBox();
			this.txtOutFilter = new System.Windows.Forms.TextBox();
			this.gridMovieOut = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnSingleOut = new System.Windows.Forms.Button();
			this.btnSingleIn = new System.Windows.Forms.Button();
			this.btnAllIn = new System.Windows.Forms.Button();
			this.btnAllOut = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridMovieIn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridMovieOut)).BeginInit();
			this.SuspendLayout();
			// 
			// txtCustomerFilter
			// 
			this.txtCustomerFilter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCustomerFilter.Location = new System.Drawing.Point(12, 12);
			this.txtCustomerFilter.Name = "txtCustomerFilter";
			this.txtCustomerFilter.Size = new System.Drawing.Size(900, 26);
			this.txtCustomerFilter.TabIndex = 0;
			// 
			// gridCustomer
			// 
			this.gridCustomer.AllowUserToAddRows = false;
			this.gridCustomer.AllowUserToDeleteRows = false;
			this.gridCustomer.AllowUserToOrderColumns = true;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.gridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.FirstName,
            this.MiddleName,
            this.Phone});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridCustomer.DefaultCellStyle = dataGridViewCellStyle2;
			this.gridCustomer.Location = new System.Drawing.Point(12, 44);
			this.gridCustomer.Name = "gridCustomer";
			this.gridCustomer.ReadOnly = true;
			this.gridCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridCustomer.Size = new System.Drawing.Size(900, 150);
			this.gridCustomer.TabIndex = 1;
			// 
			// LastName
			// 
			this.LastName.HeaderText = "Last Name";
			this.LastName.Name = "LastName";
			this.LastName.ReadOnly = true;
			this.LastName.Width = 250;
			// 
			// FirstName
			// 
			this.FirstName.HeaderText = "First Name";
			this.FirstName.Name = "FirstName";
			this.FirstName.ReadOnly = true;
			this.FirstName.Width = 250;
			// 
			// MiddleName
			// 
			this.MiddleName.HeaderText = "Middle Name";
			this.MiddleName.Name = "MiddleName";
			this.MiddleName.ReadOnly = true;
			this.MiddleName.Width = 150;
			// 
			// Phone
			// 
			this.Phone.HeaderText = "Phone #";
			this.Phone.Name = "Phone";
			this.Phone.ReadOnly = true;
			// 
			// gridMovieIn
			// 
			this.gridMovieIn.AllowUserToAddRows = false;
			this.gridMovieIn.AllowUserToDeleteRows = false;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridMovieIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.gridMovieIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridMovieIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CopyId,
            this.MovieName});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridMovieIn.DefaultCellStyle = dataGridViewCellStyle4;
			this.gridMovieIn.Location = new System.Drawing.Point(12, 245);
			this.gridMovieIn.Name = "gridMovieIn";
			this.gridMovieIn.ReadOnly = true;
			this.gridMovieIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridMovieIn.Size = new System.Drawing.Size(400, 150);
			this.gridMovieIn.TabIndex = 2;
			// 
			// CopyId
			// 
			this.CopyId.HeaderText = "Copy ID";
			this.CopyId.Name = "CopyId";
			this.CopyId.ReadOnly = true;
			// 
			// MovieName
			// 
			this.MovieName.HeaderText = "Movie Name";
			this.MovieName.Name = "MovieName";
			this.MovieName.ReadOnly = true;
			this.MovieName.Width = 257;
			// 
			// txtInFilter
			// 
			this.txtInFilter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtInFilter.Location = new System.Drawing.Point(12, 213);
			this.txtInFilter.Name = "txtInFilter";
			this.txtInFilter.Size = new System.Drawing.Size(400, 26);
			this.txtInFilter.TabIndex = 3;
			// 
			// txtOutFilter
			// 
			this.txtOutFilter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOutFilter.Location = new System.Drawing.Point(512, 213);
			this.txtOutFilter.Name = "txtOutFilter";
			this.txtOutFilter.Size = new System.Drawing.Size(400, 26);
			this.txtOutFilter.TabIndex = 5;
			// 
			// gridMovieOut
			// 
			this.gridMovieOut.AllowUserToAddRows = false;
			this.gridMovieOut.AllowUserToDeleteRows = false;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridMovieOut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.gridMovieOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridMovieOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridMovieOut.DefaultCellStyle = dataGridViewCellStyle6;
			this.gridMovieOut.Location = new System.Drawing.Point(512, 245);
			this.gridMovieOut.Name = "gridMovieOut";
			this.gridMovieOut.ReadOnly = true;
			this.gridMovieOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridMovieOut.Size = new System.Drawing.Size(400, 150);
			this.gridMovieOut.TabIndex = 4;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Copy ID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Movie Name";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 257;
			// 
			// btnSingleOut
			// 
			this.btnSingleOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSingleOut.Location = new System.Drawing.Point(444, 245);
			this.btnSingleOut.Name = "btnSingleOut";
			this.btnSingleOut.Size = new System.Drawing.Size(37, 29);
			this.btnSingleOut.TabIndex = 6;
			this.btnSingleOut.Text = ">";
			this.btnSingleOut.UseVisualStyleBackColor = true;
			// 
			// btnSingleIn
			// 
			this.btnSingleIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSingleIn.Location = new System.Drawing.Point(444, 280);
			this.btnSingleIn.Name = "btnSingleIn";
			this.btnSingleIn.Size = new System.Drawing.Size(37, 29);
			this.btnSingleIn.TabIndex = 7;
			this.btnSingleIn.Text = "<";
			this.btnSingleIn.UseVisualStyleBackColor = true;
			// 
			// btnAllIn
			// 
			this.btnAllIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAllIn.Location = new System.Drawing.Point(444, 366);
			this.btnAllIn.Name = "btnAllIn";
			this.btnAllIn.Size = new System.Drawing.Size(37, 29);
			this.btnAllIn.TabIndex = 9;
			this.btnAllIn.Text = "<<";
			this.btnAllIn.UseVisualStyleBackColor = true;
			// 
			// btnAllOut
			// 
			this.btnAllOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAllOut.Location = new System.Drawing.Point(444, 331);
			this.btnAllOut.Name = "btnAllOut";
			this.btnAllOut.Size = new System.Drawing.Size(37, 29);
			this.btnAllOut.TabIndex = 8;
			this.btnAllOut.Text = ">>";
			this.btnAllOut.UseVisualStyleBackColor = true;
			// 
			// btnOk
			// 
			this.btnOk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOk.Location = new System.Drawing.Point(742, 401);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(82, 29);
			this.btnOk.TabIndex = 10;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(830, 401);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(82, 29);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// CheckOut
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(924, 442);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.btnAllIn);
			this.Controls.Add(this.btnAllOut);
			this.Controls.Add(this.btnSingleIn);
			this.Controls.Add(this.btnSingleOut);
			this.Controls.Add(this.txtOutFilter);
			this.Controls.Add(this.gridMovieOut);
			this.Controls.Add(this.txtInFilter);
			this.Controls.Add(this.gridMovieIn);
			this.Controls.Add(this.gridCustomer);
			this.Controls.Add(this.txtCustomerFilter);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CheckOut";
			this.Text = "Check Out";
			((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridMovieIn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridMovieOut)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtCustomerFilter;
		private System.Windows.Forms.DataGridView gridCustomer;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
		private System.Windows.Forms.DataGridView gridMovieIn;
		private System.Windows.Forms.DataGridViewTextBoxColumn CopyId;
		private System.Windows.Forms.DataGridViewTextBoxColumn MovieName;
		private System.Windows.Forms.TextBox txtInFilter;
		private System.Windows.Forms.TextBox txtOutFilter;
		private System.Windows.Forms.DataGridView gridMovieOut;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.Button btnSingleOut;
		private System.Windows.Forms.Button btnSingleIn;
		private System.Windows.Forms.Button btnAllIn;
		private System.Windows.Forms.Button btnAllOut;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
	}
}