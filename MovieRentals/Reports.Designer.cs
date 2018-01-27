namespace MovieRentals
{
	partial class Reports
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
			this.listReport = new System.Windows.Forms.ComboBox();
			this.btnRun = new System.Windows.Forms.Button();
			this.progress = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// listReport
			// 
			this.listReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.listReport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listReport.FormattingEnabled = true;
			this.listReport.Location = new System.Drawing.Point(12, 12);
			this.listReport.Name = "listReport";
			this.listReport.Size = new System.Drawing.Size(200, 27);
			this.listReport.TabIndex = 0;
			// 
			// btnRun
			// 
			this.btnRun.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRun.Location = new System.Drawing.Point(218, 10);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(82, 29);
			this.btnRun.TabIndex = 15;
			this.btnRun.Text = "Run";
			this.btnRun.UseVisualStyleBackColor = true;
			// 
			// progress
			// 
			this.progress.Location = new System.Drawing.Point(12, 45);
			this.progress.Name = "progress";
			this.progress.Size = new System.Drawing.Size(288, 23);
			this.progress.TabIndex = 16;
			this.progress.Visible = false;
			// 
			// Reports
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(313, 78);
			this.Controls.Add(this.progress);
			this.Controls.Add(this.btnRun);
			this.Controls.Add(this.listReport);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Reports";
			this.Text = "Reports";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox listReport;
		private System.Windows.Forms.Button btnRun;
		private System.Windows.Forms.ProgressBar progress;
	}
}