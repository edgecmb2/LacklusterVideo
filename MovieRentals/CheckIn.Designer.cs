namespace MovieRentals
{
	partial class CheckIn
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckIn));
			this.gridMovie = new System.Windows.Forms.DataGridView();
			this.MovieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtMovieFilter = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnCheckIn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridMovie)).BeginInit();
			this.SuspendLayout();
			// 
			// gridMovie
			// 
			this.gridMovie.AllowUserToAddRows = false;
			this.gridMovie.AllowUserToDeleteRows = false;
			this.gridMovie.AllowUserToOrderColumns = true;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridMovie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.gridMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridMovie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovieId,
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
			this.gridMovie.DefaultCellStyle = dataGridViewCellStyle2;
			this.gridMovie.Location = new System.Drawing.Point(12, 44);
			this.gridMovie.Name = "gridMovie";
			this.gridMovie.ReadOnly = true;
			this.gridMovie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridMovie.Size = new System.Drawing.Size(900, 150);
			this.gridMovie.TabIndex = 3;
			// 
			// MovieId
			// 
			this.MovieId.HeaderText = "Movie ID";
			this.MovieId.Name = "MovieId";
			this.MovieId.ReadOnly = true;
			this.MovieId.Width = 125;
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
			// txtMovieFilter
			// 
			this.txtMovieFilter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMovieFilter.Location = new System.Drawing.Point(12, 12);
			this.txtMovieFilter.Name = "txtMovieFilter";
			this.txtMovieFilter.Size = new System.Drawing.Size(900, 26);
			this.txtMovieFilter.TabIndex = 2;
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(830, 200);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(82, 29);
			this.btnCancel.TabIndex = 13;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnCheckIn
			// 
			this.btnCheckIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCheckIn.Location = new System.Drawing.Point(742, 200);
			this.btnCheckIn.Name = "btnCheckIn";
			this.btnCheckIn.Size = new System.Drawing.Size(82, 29);
			this.btnCheckIn.TabIndex = 12;
			this.btnCheckIn.Text = "Check In";
			this.btnCheckIn.UseVisualStyleBackColor = true;
			// 
			// CheckIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(924, 241);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnCheckIn);
			this.Controls.Add(this.gridMovie);
			this.Controls.Add(this.txtMovieFilter);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CheckIn";
			this.Text = "Check In";
			((System.ComponentModel.ISupportInitialize)(this.gridMovie)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView gridMovie;
		private System.Windows.Forms.TextBox txtMovieFilter;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnCheckIn;
		private System.Windows.Forms.DataGridViewTextBoxColumn MovieId;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
	}
}