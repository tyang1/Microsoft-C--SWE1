using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
	private void label1_Click(object sender, EventArgs e)
	{

	}
	private void label2_Click(object sender, EventArgs e)
	{

	}


	private void button1_Click(object sender, EventArgs e)
	{
		double numberin = Convert.ToDouble(number.Text);
		double answer = 1;

			for (int i = 0; i < 21; i++)
			{
				answer = answer * i;
			}

			
		
		

	}

	}
	}


