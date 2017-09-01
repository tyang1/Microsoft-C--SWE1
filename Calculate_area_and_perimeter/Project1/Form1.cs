using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			decimal len = Convert.ToDecimal(lenInput.Text);
			decimal wid = Convert.ToDecimal(widInput.Text);
			int area = (int)(wid * len);
			int perimeter = (int)((2 * wid) + (2 * len));

			txtArea.Text = area.ToString("f0");
			txtPerimeter.Text = perimeter.ToString("f0");

			lenInput.Focus();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
