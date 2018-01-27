namespace MovieRentals
{
	partial class AddRemoveCustomer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRemoveCustomer));
			this.gridCustomer = new System.Windows.Forms.DataGridView();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtCustFilter = new System.Windows.Forms.TextBox();
			this.txtFirst = new System.Windows.Forms.TextBox();
			this.lblFirst = new System.Windows.Forms.Label();
			this.lblMiddle = new System.Windows.Forms.Label();
			this.txtMiddle = new System.Windows.Forms.TextBox();
			this.lblLast = new System.Windows.Forms.Label();
			this.txtLast = new System.Windows.Forms.TextBox();
			this.lblPhone = new System.Windows.Forms.Label();
			this.txtPhone = new System.Windows.Forms.MaskedTextBox();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).BeginInit();
			this.SuspendLayout();
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
			this.gridCustomer.TabIndex = 3;
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
			// txtCustFilter
			// 
			this.txtCustFilter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCustFilter.Location = new System.Drawing.Point(12, 12);
			this.txtCustFilter.Name = "txtCustFilter";
			this.txtCustFilter.Size = new System.Drawing.Size(900, 26);
			this.txtCustFilter.TabIndex = 2;
			// 
			// txtFirst
			// 
			this.txtFirst.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFirst.Location = new System.Drawing.Point(98, 200);
			this.txtFirst.Name = "txtFirst";
			this.txtFirst.Size = new System.Drawing.Size(200, 26);
			this.txtFirst.TabIndex = 4;
			// 
			// lblFirst
			// 
			this.lblFirst.AutoSize = true;
			this.lblFirst.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFirst.Location = new System.Drawing.Point(12, 203);
			this.lblFirst.Name = "lblFirst";
			this.lblFirst.Size = new System.Drawing.Size(80, 19);
			this.lblFirst.TabIndex = 5;
			this.lblFirst.Text = "First Name:";
			// 
			// lblMiddle
			// 
			this.lblMiddle.AutoSize = true;
			this.lblMiddle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMiddle.Location = new System.Drawing.Point(304, 203);
			this.lblMiddle.Name = "lblMiddle";
			this.lblMiddle.Size = new System.Drawing.Size(96, 19);
			this.lblMiddle.TabIndex = 7;
			this.lblMiddle.Text = "Middle Name:";
			// 
			// txtMiddle
			// 
			this.txtMiddle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMiddle.Location = new System.Drawing.Point(406, 200);
			this.txtMiddle.Name = "txtMiddle";
			this.txtMiddle.Size = new System.Drawing.Size(150, 26);
			this.txtMiddle.TabIndex = 6;
			// 
			// lblLast
			// 
			this.lblLast.AutoSize = true;
			this.lblLast.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLast.Location = new System.Drawing.Point(12, 235);
			this.lblLast.Name = "lblLast";
			this.lblLast.Size = new System.Drawing.Size(79, 19);
			this.lblLast.TabIndex = 9;
			this.lblLast.Text = "Last Name:";
			// 
			// txtLast
			// 
			this.txtLast.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLast.Location = new System.Drawing.Point(98, 232);
			this.txtLast.Name = "txtLast";
			this.txtLast.Size = new System.Drawing.Size(200, 26);
			this.txtLast.TabIndex = 8;
			// 
			// lblPhone
			// 
			this.lblPhone.AutoSize = true;
			this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPhone.Location = new System.Drawing.Point(304, 235);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size(50, 19);
			this.lblPhone.TabIndex = 11;
			this.lblPhone.Text = "Phone:";
			// 
			// txtPhone
			// 
			this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPhone.Location = new System.Drawing.Point(406, 232);
			this.txtPhone.Mask = "(999) 000-0000";
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(150, 26);
			this.txtPhone.TabIndex = 12;
			this.txtPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// btnRemove
			// 
			this.btnRemove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemove.Location = new System.Drawing.Point(830, 264);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(82, 29);
			this.btnRemove.TabIndex = 13;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			// 
			// btnNew
			// 
			this.btnNew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNew.Location = new System.Drawing.Point(654, 264);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(82, 29);
			this.btnNew.TabIndex = 14;
			this.btnNew.Text = "New";
			this.btnNew.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(742, 264);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(82, 29);
			this.btnSave.TabIndex = 15;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// AddRemoveCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(924, 305);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.lblPhone);
			this.Controls.Add(this.lblLast);
			this.Controls.Add(this.txtLast);
			this.Controls.Add(this.lblMiddle);
			this.Controls.Add(this.txtMiddle);
			this.Controls.Add(this.lblFirst);
			this.Controls.Add(this.txtFirst);
			this.Controls.Add(this.gridCustomer);
			this.Controls.Add(this.txtCustFilter);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AddRemoveCustomer";
			this.Text = "Add/Remove Customer";
			((System.ComponentModel.ISupportInitialize)(this.gridCustomer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView gridCustomer;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
		private System.Windows.Forms.TextBox txtCustFilter;
		private System.Windows.Forms.TextBox txtFirst;
		private System.Windows.Forms.Label lblFirst;
		private System.Windows.Forms.Label lblMiddle;
		private System.Windows.Forms.TextBox txtMiddle;
		private System.Windows.Forms.Label lblLast;
		private System.Windows.Forms.TextBox txtLast;
		private System.Windows.Forms.Label lblPhone;
		private System.Windows.Forms.MaskedTextBox txtPhone;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Button btnSave;
	}
}