using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Scores
{
	public class Student
	{
		private List<decimal> score_list;
		private decimal total_score = 0;
		private int score_count = 0;
		private decimal average = 0;
		private string name;
		private decimal score;
		public Student() { }
		public Student(string name, decimal score)
		{
			this.Name = name;
			this.Score = score;
			this.Score_list = score_list;
			this.Total_score = total_score;
			this.Score_count = score_count;
			this.Average = average;
		}
		public List<decimal> Score_list
		{
			get
			{
				return score_list;
			}
			set
			{
				score_list = value;
			}
		}
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}
		public decimal Score { get; set; }
		public decimal Total_score
		{
			get
			{
				for (int i = 0; i < score_list.Count; i++)
				{ total_score += score_list[i]; }
				return total_score;
			}
			set
			{
				total_score = value;
			}
		}
		public int Score_count
		{
			get
			{
				return score_list.Count;
			}
			set
			{
				score_count = value;
			}
		}
		public decimal Average
		{
			get
			{
				return total_score / score_count;
			}
			set
			{
				average = value;
			}
		}
		public string GetDisplayText(string sep)
		{
			return Name + sep + string.Join("|", Score_list);
		}


	}

}
