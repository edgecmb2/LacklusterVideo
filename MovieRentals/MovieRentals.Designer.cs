namespace MovieRentals
{
	partial class MovieRentals
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieRentals));
			this.btnCheckOut = new System.Windows.Forms.Button();
			this.btnCheckIn = new System.Windows.Forms.Button();
			this.btnReports = new System.Windows.Forms.Button();
			this.btnUpdateUser = new System.Windows.Forms.Button();
			this.btnUpdateMovie = new System.Windows.Forms.Button();
			this.btnUpdateCustomer = new System.Windows.Forms.Button();
			this.btnBatchCheckIn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCheckOut
			// 
			this.btnCheckOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCheckOut.Location = new System.Drawing.Point(12, 12);
			this.btnCheckOut.Name = "btnCheckOut";
			this.btnCheckOut.Size = new System.Drawing.Size(163, 29);
			this.btnCheckOut.TabIndex = 11;
			this.btnCheckOut.Text = "Check Out Movie";
			this.btnCheckOut.UseVisualStyleBackColor = true;
			this.btnCheckOut.Click += new System.EventHandler(this.CheckOut);
			// 
			// btnCheckIn
			// 
			this.btnCheckIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCheckIn.Location = new System.Drawing.Point(12, 47);
			this.btnCheckIn.Name = "btnCheckIn";
			this.btnCheckIn.Size = new System.Drawing.Size(163, 29);
			this.btnCheckIn.TabIndex = 12;
			this.btnCheckIn.Text = "Check In Movie";
			this.btnCheckIn.UseVisualStyleBackColor = true;
			this.btnCheckIn.Click += new System.EventHandler(this.CheckIn);
			// 
			// btnReports
			// 
			this.btnReports.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReports.Location = new System.Drawing.Point(181, 12);
			this.btnReports.Name = "btnReports";
			this.btnReports.Size = new System.Drawing.Size(163, 29);
			this.btnReports.TabIndex = 13;
			this.btnReports.Text = "Run Reports";
			this.btnReports.UseVisualStyleBackColor = true;
			this.btnReports.Click += new System.EventHandler(this.RunReport);
			// 
			// btnUpdateUser
			// 
			this.btnUpdateUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdateUser.Location = new System.Drawing.Point(181, 117);
			this.btnUpdateUser.Name = "btnUpdateUser";
			this.btnUpdateUser.Size = new System.Drawing.Size(163, 29);
			this.btnUpdateUser.TabIndex = 16;
			this.btnUpdateUser.Text = "Add/Remove User";
			this.btnUpdateUser.UseVisualStyleBackColor = true;
			this.btnUpdateUser.Visible = false;
			this.btnUpdateUser.Click += new System.EventHandler(this.UpdateUser);
			// 
			// btnUpdateMovie
			// 
			this.btnUpdateMovie.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdateMovie.Location = new System.Drawing.Point(181, 82);
			this.btnUpdateMovie.Name = "btnUpdateMovie";
			this.btnUpdateMovie.Size = new System.Drawing.Size(163, 29);
			this.btnUpdateMovie.TabIndex = 15;
			this.btnUpdateMovie.Text = "Add/Remove Movie";
			this.btnUpdateMovie.UseVisualStyleBackColor = true;
			this.btnUpdateMovie.Click += new System.EventHandler(this.UpdateMovie);
			// 
			// btnUpdateCustomer
			// 
			this.btnUpdateCustomer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdateCustomer.Location = new System.Drawing.Point(181, 47);
			this.btnUpdateCustomer.Name = "btnUpdateCustomer";
			this.btnUpdateCustomer.Size = new System.Drawing.Size(163, 29);
			this.btnUpdateCustomer.TabIndex = 14;
			this.btnUpdateCustomer.Text = "Add/Remove Customer";
			this.btnUpdateCustomer.UseVisualStyleBackColor = true;
			this.btnUpdateCustomer.Click += new System.EventHandler(this.UpdateCustomer);
			// 
			// btnBatchCheckIn
			// 
			this.btnBatchCheckIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBatchCheckIn.Location = new System.Drawing.Point(12, 82);
			this.btnBatchCheckIn.Name = "btnBatchCheckIn";
			this.btnBatchCheckIn.Size = new System.Drawing.Size(163, 29);
			this.btnBatchCheckIn.TabIndex = 17;
			this.btnBatchCheckIn.Text = "Batch Check In Movie";
			this.btnBatchCheckIn.UseVisualStyleBackColor = true;
			this.btnBatchCheckIn.Click += new System.EventHandler(this.BatchCheckIn);
			// 
			// MovieRentals
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(356, 158);
			this.Controls.Add(this.btnBatchCheckIn);
			this.Controls.Add(this.btnUpdateUser);
			this.Controls.Add(this.btnUpdateMovie);
			this.Controls.Add(this.btnUpdateCustomer);
			this.Controls.Add(this.btnReports);
			this.Controls.Add(this.btnCheckIn);
			this.Controls.Add(this.btnCheckOut);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MovieRentals";
			this.Text = "Lackluster Video";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCheckOut;
		private System.Windows.Forms.Button btnCheckIn;
		private System.Windows.Forms.Button btnReports;
		private System.Windows.Forms.Button btnUpdateUser;
		private System.Windows.Forms.Button btnUpdateMovie;
		private System.Windows.Forms.Button btnUpdateCustomer;
		private System.Windows.Forms.Button btnBatchCheckIn;
	}
}

