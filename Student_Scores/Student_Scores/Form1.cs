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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private StudentList students = new StudentList();
		private void Form1_Load(object sender, EventArgs e)
		{
			students.Changed += new StudentList.ChangeHandler(HandleChange);
			FillStudentListBox();
			lstStudents.Enabled = true;
			if (lstStudents.SelectedIndex != -1)
			{
				Student s;
				s = students[lstStudents.SelectedIndex];
				txtAverage.Text = s.Average.ToString();
				txtTotal.Text = s.Total_score.ToString();
				txtCount.Text = s.Score_count.ToString();
			}

		}
		private void FillStudentListBox()
		{
			Student s;
			lstStudents.Items.Clear();
			for (int i = 0; i < students.Count ; i++)
			{
				s = students[i];
				lstStudents.Items.Add(s.GetDisplayText("\t"));
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			NewStudent newForm = new NewStudent();
			Student student = newForm.GetNewStudent();
			if (student != null)
			{
				students += student;
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int i = lstStudents.SelectedIndex;
			if (i != -1)
			{
				Student student = students[i];
				string message = "Are you sure you want to delete."
					+ student.Name + "?";
				DialogResult button = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo);
				if (button == DialogResult.Yes)
				{
					students -= student;
				}
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void HandleChange(StudentList students)
		{
			FillStudentListBox();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			ScoreUpdate scoreupdateFrm = new ScoreUpdate(Students);
			scoreupdateFrm.ShowDialog();
		}
	}
}
