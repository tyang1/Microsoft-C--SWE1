namespace robot
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnNorth = new System.Windows.Forms.Button();
			this.btnWest = new System.Windows.Forms.Button();
			this.btnEast = new System.Windows.Forms.Button();
			this.btnSouth = new System.Windows.Forms.Button();
			this.btnGoOne = new System.Windows.Forms.Button();
			this.btnGoTen = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(39, 51);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 100);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.label1.Location = new System.Drawing.Point(82, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// btnNorth
			// 
			this.btnNorth.Location = new System.Drawing.Point(43, 9);
			this.btnNorth.Name = "btnNorth";
			this.btnNorth.Size = new System.Drawing.Size(28, 25);
			this.btnNorth.TabIndex = 1;
			this.btnNorth.Text = "N";
			this.btnNorth.UseVisualStyleBackColor = true;
			this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
			// 
			// btnWest
			// 
			this.btnWest.Location = new System.Drawing.Point(3, 35);
			this.btnWest.Name = "btnWest";
			this.btnWest.Size = new System.Drawing.Size(32, 26);
			this.btnWest.TabIndex = 2;
			this.btnWest.Text = "W";
			this.btnWest.UseVisualStyleBackColor = true;
			this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
			// 
			// btnEast
			// 
			this.btnEast.Location = new System.Drawing.Point(76, 38);
			this.btnEast.Name = "btnEast";
			this.btnEast.Size = new System.Drawing.Size(29, 23);
			this.btnEast.TabIndex = 3;
			this.btnEast.Text = "E";
			this.btnEast.UseVisualStyleBackColor = true;
			this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
			// 
			// btnSouth
			// 
			this.btnSouth.Location = new System.Drawing.Point(43, 70);
			this.btnSouth.Name = "btnSouth";
			this.btnSouth.Size = new System.Drawing.Size(28, 24);
			this.btnSouth.TabIndex = 4;
			this.btnSouth.Text = "S";
			this.btnSouth.UseVisualStyleBackColor = true;
			this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
			// 
			// btnGoOne
			// 
			this.btnGoOne.Location = new System.Drawing.Point(13, 193);
			this.btnGoOne.Name = "btnGoOne";
			this.btnGoOne.Size = new System.Drawing.Size(51, 23);
			this.btnGoOne.TabIndex = 5;
			this.btnGoOne.Text = "Go 1";
			this.btnGoOne.UseVisualStyleBackColor = true;
			this.btnGoOne.Click += new System.EventHandler(this.btnGoOne_Click);
			// 
			// btnGoTen
			// 
			this.btnGoTen.Location = new System.Drawing.Point(213, 193);
			this.btnGoTen.Name = "btnGoTen";
			this.btnGoTen.Size = new System.Drawing.Size(49, 23);
			this.btnGoTen.TabIndex = 6;
			this.btnGoTen.Text = "Go 10";
			this.btnGoTen.UseVisualStyleBackColor = true;
			this.btnGoTen.Click += new System.EventHandler(this.btnGoTen_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(197, 227);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnWest);
			this.panel2.Controls.Add(this.btnSouth);
			this.panel2.Controls.Add(this.btnEast);
			this.panel2.Controls.Add(this.btnNorth);
			this.panel2.Location = new System.Drawing.Point(70, 157);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(121, 100);
			this.panel2.TabIndex = 9;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "label2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnGoTen);
			this.Controls.Add(this.btnGoOne);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Robot";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnNorth;
		private System.Windows.Forms.Button btnWest;
		private System.Windows.Forms.Button btnEast;
		private System.Windows.Forms.Button btnSouth;
		private System.Windows.Forms.Button btnGoOne;
		private System.Windows.Forms.Button btnGoTen;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
	}
}

