using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MovieRentals
{
	public partial class MovieRentals : Form
	{
		public MovieRentals()
		{
			InitializeComponent();

			if (Globals.superUser)
			{
				btnUpdateUser.Visible = true;
				this.BackColor = System.Drawing.Color.DeepSkyBlue;
			}
		}

		private void CheckOut(object sender, EventArgs e)
		{
			CheckOut checkOut = new CheckOut();
			checkOut.ShowDialog();
		}

		private void CheckIn(object sender, EventArgs e)
		{
			CheckIn checkIn = new CheckIn();
			checkIn.ShowDialog();
		}

		private void BatchCheckIn(object sender, EventArgs e)
		{
			BatchCheckIn batch = new BatchCheckIn();
			batch.ShowDialog();
		}

		private void RunReport(object sender, EventArgs e)
		{
			Reports report = new Reports();
			report.ShowDialog();
		}

		private void UpdateCustomer(object sender, EventArgs e)
		{
			AddRemoveCustomer customer = new AddRemoveCustomer();
			customer.ShowDialog();
		}

		private void UpdateMovie(object sender, EventArgs e)
		{
			AddRemoveMovie movie = new AddRemoveMovie();
			movie.ShowDialog();
		}

		private void UpdateUser(object sender, EventArgs e)
		{
			AddRemoveUser user = new AddRemoveUser();
			user.ShowDialog();
		}
	}
}
