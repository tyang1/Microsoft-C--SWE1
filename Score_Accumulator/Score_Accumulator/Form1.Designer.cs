namespace Score_Accumulator
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
			this.txt_Score = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_Total = new System.Windows.Forms.TextBox();
			this.txt_Count = new System.Windows.Forms.TextBox();
			this.txt_Average = new System.Windows.Forms.TextBox();
			this.btn_Add = new System.Windows.Forms.Button();
			this.btn_Display = new System.Windows.Forms.Button();
			this.btn_Clear = new System.Windows.Forms.Button();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txt_Score
			// 
			this.txt_Score.Location = new System.Drawing.Point(68, 33);
			this.txt_Score.Name = "txt_Score";
			this.txt_Score.Size = new System.Drawing.Size(100, 20);
			this.txt_Score.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Score:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(0, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Score Total:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(-1, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Score Count:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Average:";
			// 
			// txt_Total
			// 
			this.txt_Total.Location = new System.Drawing.Point(68, 60);
			this.txt_Total.Name = "txt_Total";
			this.txt_Total.ReadOnly = true;
			this.txt_Total.Size = new System.Drawing.Size(100, 20);
			this.txt_Total.TabIndex = 5;
			this.txt_Total.TabStop = false;
			// 
			// txt_Count
			// 
			this.txt_Count.Location = new System.Drawing.Point(68, 94);
			this.txt_Count.Name = "txt_Count";
			this.txt_Count.ReadOnly = true;
			this.txt_Count.Size = new System.Drawing.Size(100, 20);
			this.txt_Count.TabIndex = 6;
			this.txt_Count.TabStop = false;
			// 
			// txt_Average
			// 
			this.txt_Average.Location = new System.Drawing.Point(68, 122);
			this.txt_Average.Name = "txt_Average";
			this.txt_Average.ReadOnly = true;
			this.txt_Average.Size = new System.Drawing.Size(100, 20);
			this.txt_Average.TabIndex = 7;
			this.txt_Average.TabStop = false;
			// 
			// btn_Add
			// 
			this.btn_Add.Location = new System.Drawing.Point(188, 30);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(75, 23);
			this.btn_Add.TabIndex = 1;
			this.btn_Add.Text = "Add";
			this.btn_Add.UseVisualStyleBackColor = true;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			// 
			// btn_Display
			// 
			this.btn_Display.Location = new System.Drawing.Point(68, 173);
			this.btn_Display.Name = "btn_Display";
			this.btn_Display.Size = new System.Drawing.Size(100, 23);
			this.btn_Display.TabIndex = 2;
			this.btn_Display.Text = "Display scores";
			this.btn_Display.UseVisualStyleBackColor = true;
			this.btn_Display.Click += new System.EventHandler(this.btn_Display_Click);
			// 
			// btn_Clear
			// 
			this.btn_Clear.Location = new System.Drawing.Point(188, 173);
			this.btn_Clear.Name = "btn_Clear";
			this.btn_Clear.Size = new System.Drawing.Size(75, 23);
			this.btn_Clear.TabIndex = 3;
			this.btn_Clear.Text = "Clear scores";
			this.btn_Clear.UseVisualStyleBackColor = true;
			this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
			// 
			// btn_Exit
			// 
			this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_Exit.Location = new System.Drawing.Point(188, 217);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(75, 23);
			this.btn_Exit.TabIndex = 4;
			this.btn_Exit.Text = "Exit";
			this.btn_Exit.UseVisualStyleBackColor = true;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// Form1
			// 
			this.AcceptButton = this.btn_Add;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btn_Exit;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.btn_Clear);
			this.Controls.Add(this.btn_Display);
			this.Controls.Add(this.btn_Add);
			this.Controls.Add(this.txt_Average);
			this.Controls.Add(this.txt_Count);
			this.Controls.Add(this.txt_Total);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_Score);
			this.Name = "Form1";
			this.Text = "Score Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_Score;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_Total;
		private System.Windows.Forms.TextBox txt_Count;
		private System.Windows.Forms.TextBox txt_Average;
		private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.Button btn_Display;
		private System.Windows.Forms.Button btn_Clear;
		private System.Windows.Forms.Button btn_Exit;
	}
}

