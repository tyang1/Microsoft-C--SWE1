using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace robot
{
	public partial class Form1 : Form
	{
		Robot rnew = new Robot();
		public Form1()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			label1.Text = rnew.ToString();
			panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			rnew.location = label1.Location;
			panel1.Controls.Add(label1);
			label2.Text = rnew.GetFormattedLocation();
		}
		private void btnNorth_Click(object sender, EventArgs e)
		{
			rnew.direction = Direction.North;
			label1.Text = rnew.ToString();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnSouth_Click(object sender, EventArgs e)
		{
			rnew.direction = Direction.South;
			label1.Text = rnew.ToString();
		}

		private void btnWest_Click(object sender, EventArgs e)
		{
			rnew.direction = Direction.West;
			label1.Text = rnew.ToString();
		}

		private void btnEast_Click(object sender, EventArgs e)
		{
			rnew.direction = Direction.East;
			label1.Text = rnew.ToString();
		}
		private void btnGoTen_Click(object sender, EventArgs e)
		{
			rnew.move(10);
			label1.Location = rnew.location;
			label2.Text = rnew.GetFormattedLocation();
			if (rnew.location.X < 182 && rnew.location.X > -18 && rnew.location.Y < 143 && rnew.location.Y > -57)
			{
				panel1.Focus();
			}
			else
			{
				MessageBox.Show("You have reached maximum steps in direction" + rnew.direction);
			}
		}

		private void btnGoOne_Click(object sender, EventArgs e)
		{
			rnew.move(1);
			label1.Location = rnew.location;
			label2.Text = rnew.GetFormattedLocation();
			if (rnew.location.X < 182 && rnew.location.X > -18 && rnew.location.X < 182 && rnew.location.X > -18 && rnew.location.Y < 143 && rnew.location.Y > -57)
			{
				panel1.Focus();
			}
			else
			{
				MessageBox.Show("You have reached maximum steps in direction" + rnew.direction);
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
