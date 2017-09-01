using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Scores
{
	class StudentList
	{
		private List<Student> students;
		public delegate void ChangeHandler(StudentList students);
		public event ChangeHandler Changed;
		public StudentList()
		{
			students = new List<Student>();
		}
		public int Count => students.Count;
		public Student this[int i]
		{
			get
			{
				if (i < 0)
				{
					throw new ArgumentOutOfRangeException(i.ToString());
				}
				else if (i >= students.Count)
				{
					throw new ArgumentOutOfRangeException(i.ToString());
				}
				return students[i];
			}
			set
			{
				students[i] = value;
				Changed(this);
			}
		}
		public Student this[string name]
		{
			get
			{
				foreach (Student s in students)
				{
					if (s.Name == name)
						return s;
				}
				return null;
			}
		}
		public void Add(Student student)
		{
			students.Add(student);
			Changed(this);
		}
		public void Add(string name, decimal score)
		{
			Student s = new Student(name, score);
			students.Add(s);
			Changed(this);
		}
		public void Remove(Student student)
		{
			students.Remove(student);
			Changed(this);
		}
		public static StudentList operator +(StudentList s1, Student s)
		{
			s1.Add(s);
			return s1;
		}
		public static StudentList operator -(StudentList s1, Student s)
		{
			s1.Remove(s);
			return s1;
		}

	}
}

