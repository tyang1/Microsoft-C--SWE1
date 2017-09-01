using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Score_Accumulator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int sum = 0;
		List<int> scores = new List<int>();
		private void btn_Add_Click(object sender, EventArgs e)
		{

			try
			{
				if (IsValidData())
				{
					sum = 0;
					int score = Convert.ToInt32(txt_Score.Text);
					scores.Add(score);
					foreach (int s in scores)
						sum += s;
					int average = sum / scores.Count;
					txt_Total.Text = sum.ToString("n0");
					txt_Count.Text = scores.Count.ToString("n0");
					txt_Average.Text = average.ToString("n0");
					txt_Score.Focus();
					txt_Score.Text = "";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
			}

		}
		public bool IsValidData()
		{
			return
				IsPresent(txt_Score, "Score") &&
				IsWithinRange(txt_Score, "Score", 0, 100);
		}
		public bool IsPresent(TextBox txt_Score, string name)
		{
			if (txt_Score.Text == "")
			{
				MessageBox.Show(name + "is a required name", "Entry Error");
				txt_Score.Focus();
				return false;
			}
			return true;
		}
		public bool IsWithinRange(TextBox txt_Score, string name, int min, int max)
		{
			int number = Convert.ToInt32(txt_Score.Text);
			if (number < min || number > max)
			{
				MessageBox.Show(name + "must be between"+ min + "and" + max + ".", "Entry Error");
				txt_Score.Focus();
				return false;
			}
			return true;
		}


		private void btn_Display_Click(object sender, EventArgs e)
		{
			scores.Sort();
			string scoreString = "";
			foreach (int s in scores)
				scoreString += s.ToString() + "\n";
			MessageBox.Show(scoreString, "Sorted Scores");
		}

		private void btn_Clear_Click(object sender, EventArgs e)
		{
			txt_Score.Text = "";
			txt_Count.Text = "";
			txt_Average.Text = "";
			txt_Total.Text = "";
			scores = new List<int>();
			sum = 0;
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
