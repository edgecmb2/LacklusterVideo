namespace MovieRentals
{
	partial class AddRemoveMovie
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRemoveMovie));
			this.txtMovieFilter = new System.Windows.Forms.TextBox();
			this.gridMovie = new System.Windows.Forms.DataGridView();
			this.CopyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MovieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblMovie = new System.Windows.Forms.Label();
			this.txtMovie = new System.Windows.Forms.TextBox();
			this.lblCopy = new System.Windows.Forms.Label();
			this.txtCopy = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridMovie)).BeginInit();
			this.SuspendLayout();
			// 
			// txtMovieFilter
			// 
			this.txtMovieFilter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMovieFilter.Location = new System.Drawing.Point(12, 12);
			this.txtMovieFilter.Name = "txtMovieFilter";
			this.txtMovieFilter.Size = new System.Drawing.Size(400, 26);
			this.txtMovieFilter.TabIndex = 5;
			// 
			// gridMovie
			// 
			this.gridMovie.AllowUserToAddRows = false;
			this.gridMovie.AllowUserToDeleteRows = false;
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
            this.CopyId,
            this.MovieName});
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
			this.gridMovie.Size = new System.Drawing.Size(400, 150);
			this.gridMovie.TabIndex = 4;
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
			// lblMovie
			// 
			this.lblMovie.AutoSize = true;
			this.lblMovie.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMovie.Location = new System.Drawing.Point(12, 203);
			this.lblMovie.Name = "lblMovie";
			this.lblMovie.Size = new System.Drawing.Size(92, 19);
			this.lblMovie.TabIndex = 7;
			this.lblMovie.Text = "Movie Name:";
			// 
			// txtMovie
			// 
			this.txtMovie.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMovie.Location = new System.Drawing.Point(110, 200);
			this.txtMovie.Name = "txtMovie";
			this.txtMovie.Size = new System.Drawing.Size(200, 26);
			this.txtMovie.TabIndex = 6;
			// 
			// lblCopy
			// 
			this.lblCopy.AutoSize = true;
			this.lblCopy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCopy.Location = new System.Drawing.Point(12, 235);
			this.lblCopy.Name = "lblCopy";
			this.lblCopy.Size = new System.Drawing.Size(63, 19);
			this.lblCopy.TabIndex = 9;
			this.lblCopy.Text = "Copy ID";
			this.lblCopy.UseWaitCursor = true;
			// 
			// txtCopy
			// 
			this.txtCopy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCopy.Location = new System.Drawing.Point(110, 232);
			this.txtCopy.Name = "txtCopy";
			this.txtCopy.ReadOnly = true;
			this.txtCopy.Size = new System.Drawing.Size(200, 26);
			this.txtCopy.TabIndex = 8;
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(242, 264);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(82, 29);
			this.btnSave.TabIndex = 18;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// btnNew
			// 
			this.btnNew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNew.Location = new System.Drawing.Point(154, 264);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(82, 29);
			this.btnNew.TabIndex = 17;
			this.btnNew.Text = "New";
			this.btnNew.UseVisualStyleBackColor = true;
			// 
			// btnRemove
			// 
			this.btnRemove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemove.Location = new System.Drawing.Point(330, 264);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(82, 29);
			this.btnRemove.TabIndex = 16;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			// 
			// AddRemoveMovie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(424, 305);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.lblCopy);
			this.Controls.Add(this.txtCopy);
			this.Controls.Add(this.lblMovie);
			this.Controls.Add(this.txtMovie);
			this.Controls.Add(this.txtMovieFilter);
			this.Controls.Add(this.gridMovie);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AddRemoveMovie";
			this.Text = "AddRemoveMovie";
			((System.ComponentModel.ISupportInitialize)(this.gridMovie)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtMovieFilter;
		private System.Windows.Forms.DataGridView gridMovie;
		private System.Windows.Forms.DataGridViewTextBoxColumn CopyId;
		private System.Windows.Forms.DataGridViewTextBoxColumn MovieName;
		private System.Windows.Forms.Label lblMovie;
		private System.Windows.Forms.TextBox txtMovie;
		private System.Windows.Forms.Label lblCopy;
		private System.Windows.Forms.TextBox txtCopy;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Button btnRemove;
	}
}