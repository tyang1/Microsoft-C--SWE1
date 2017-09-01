using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			DateTime firstDate = DateTime.Today;
			txt_Arrival.Text = firstDate.ToString().Split(' ')[0];
			DateTime lastDate = firstDate.AddDays(3);
			txt_Departure.Text = lastDate.ToString().Split(' ')[0];
			double price = 115.00;
			int days = 3;
			txt_NumberNights.Text = days.ToString("n0");
			txt_UnitPrice.Text = price.ToString("c");
			txt_TotalPrice.Text = CalculateTotal(days, price).ToString("c");
		}
		private void btn_Calculate_Click(object sender, EventArgs e)
		{
			int EndDay = 0;
			double price = 115.00;
			try
			{

				if (IsValidArrivalDate(txt_Arrival, "Arriving Date"))
				{
					txt_Departure.Focus();
				}
				if (IsValidDepartureDate(txt_Departure, "Departure Date"))
				{
					DateTime lastDate = DateTime.Parse(txt_Departure.Text);
					TimeSpan timeTillEnd = lastDate.Subtract(DateTime.Parse(txt_Arrival.Text));
					EndDay = timeTillEnd.Days;
					txt_NumberNights.Text = EndDay.ToString("n0");
					txt_TotalPrice.Text = CalculateTotal(EndDay, price).ToString("c");
				}
				txt_Arrival.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
			}

			
		}
		private double CalculateTotal(int day, double p)
		{
			double total = day * p;
			return total;
		}


		public bool IsValidArrivalDate(TextBox textbox, string name)
		{
			if (DateTime.Parse(textbox.Text) < DateTime.Now.Date)
			{
				MessageBox.Show(textbox.Text + "the date must be on or after the current date", "Entry Error");
				textbox.Focus();
				return false;
			}
			return true;
		}
		public bool IsValidDepartureDate(TextBox textbox, string name)
		{
			if (DateTime.Parse(textbox.Text) < DateTime.Now.Date && DateTime.Parse(textbox.Text) < DateTime.Parse(txt_Arrival.Text))
			{
				MessageBox.Show(textbox.Text + "the date must be on or after the current date, and after the arrival date", "Entry Error");
				textbox.Focus();
				return false;
			}
			return true;
		}

	}
}
