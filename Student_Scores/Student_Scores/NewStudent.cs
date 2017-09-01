using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Scores
{
	public partial class NewStudent : Form
	{
		public NewStudent()
		{
			InitializeComponent();
		}
		private Student student = null;
		private void NewStudent_Load(object sender, EventArgs e)
		{
			
		}
		List<Decimal> score_new = new List<decimal>();
		public Student GetNewStudent()
		{
			this.ShowDialog();
			return student;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			score_new.Add(Convert.ToDecimal(txtNewScore.Text));
			txtNewScores.Text = string.Join(" ", score_new);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			txtNewScore.Clear();
			txtNewStudent.Clear();
			txtNewScores.Clear();
			score_new.Clear();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			student = new Student(txtNewStudent.Text, Convert.ToDecimal(txtNewScore.Text));
			student.Score_list = score_new;
			student.Score_count += 1;
			student.Total_score += Convert.ToDecimal(txtNewScore.Text);
			this.Close();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
