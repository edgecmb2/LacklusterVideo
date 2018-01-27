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
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void CheckLogin(object sender, EventArgs e)
		{
			// todo: Add credential validation

			if (String.Equals(txtUser.Text, "admin", StringComparison.OrdinalIgnoreCase))
			{
				Globals.superUser = true;
			}

			this.Hide();
			MovieRentals rental = new MovieRentals();
			rental.ShowDialog();
			this.Close();
		}

		private void Cancel(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
