﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MovieRentals
{
	public partial class CheckIn : Form
	{
		public CheckIn()
		{
			InitializeComponent();

			this.MaximizeBox = false;

			if (Globals.superUser)
			{
				this.BackColor = System.Drawing.Color.DeepSkyBlue;
			}
		}
	}
}