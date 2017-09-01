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
	public partial class ScoreUpdate : Form
	{
		List<Student> students;
		public ScoreUpdate(List<Student> students)
		{
			InitializeComponent();
			this.students = students;
		}

		private void ScoreUpdate_Load(object sender, EventArgs e)
		{

		}

		private void btnExistingAdd_Click(object sender, EventArgs e)
		{

		}

		private void btnExistingUpdate_Click(object sender, EventArgs e)
		{
	
		}

		private void btnExistingRemove_Click(object sender, EventArgs e)
		{

		}

		private void btnExistingClear_Click(object sender, EventArgs e)
		{

		}

		private void btnExistingOk_Click(object sender, EventArgs e)
		{

		}

		private void btnExistingCancel_Click(object sender, EventArgs e)
		{

		}
	}
}
