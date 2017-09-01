using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace robot
{
	public enum Direction : int
	{
		West = 231,
		North = 233,
		East = 232,
		South = 234
	}

	class Robot
	{
		public Direction direction;
		public Robot()
		{
			this.location = new Point();
			direction = Direction.North;
		}
		public Point location { get; set; }
		public void move(int unit)
		{
			Point change = new Point();
			switch (direction)
			{
				case Direction.North:
					change.X = this.location.X;
					change.Y = this.location.Y - unit;
					break;
				case Direction.South:
					change.X = this.location.X;
					change.Y = this.location.Y + unit;
					break;
				case Direction.West:
					change.X = this.location.X - unit;
					change.Y = this.location.Y;
					break;
				case Direction.East:
					change.X = this.location.X + unit;
					change.Y = this.location.Y;
					break;
			}
			this.location = change;
		}
		public void Draw(Panel p)
		{
			Point newpoint = new Point(this.location.X + p.Width / 2, this.location.Y + p.Height / 2);
			p.Controls[0].Location = newpoint;
		}
		public override string ToString()
		{
			return ((char)direction).ToString();
		}
		public string GetFormattedLocation()
		{
			string locationString = "{X=" + Convert.ToString(this.location.X - (int)82) + ",Y=" + Convert.ToString(this.location.Y - (int)43) + "}";
			return locationString;
		}
	}
}
