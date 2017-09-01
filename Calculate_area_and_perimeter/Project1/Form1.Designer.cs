namespace Project1
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lenInput = new System.Windows.Forms.TextBox();
			this.widInput = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtArea = new System.Windows.Forms.TextBox();
			this.txtPerimeter = new System.Windows.Forms.TextBox();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Length:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Width:";
			// 
			// lenInput
			// 
			this.lenInput.Location = new System.Drawing.Point(77, 22);
			this.lenInput.Name = "lenInput";
			this.lenInput.Size = new System.Drawing.Size(100, 20);
			this.lenInput.TabIndex = 1;
			// 
			// widInput
			// 
			this.widInput.Location = new System.Drawing.Point(77, 55);
			this.widInput.Name = "widInput";
			this.widInput.Size = new System.Drawing.Size(100, 20);
			this.widInput.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Area:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 124);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Perimeter";
			// 
			// txtArea
			// 
			this.txtArea.BackColor = System.Drawing.SystemColors.ControlLight;
			this.txtArea.Location = new System.Drawing.Point(77, 88);
			this.txtArea.Name = "txtArea";
			this.txtArea.ReadOnly = true;
			this.txtArea.Size = new System.Drawing.Size(100, 20);
			this.txtArea.TabIndex = 6;
			this.txtArea.TabStop = false;
			// 
			// txtPerimeter
			// 
			this.txtPerimeter.BackColor = System.Drawing.SystemColors.ControlLight;
			this.txtPerimeter.Location = new System.Drawing.Point(77, 121);
			this.txtPerimeter.Name = "txtPerimeter";
			this.txtPerimeter.ReadOnly = true;
			this.txtPerimeter.Size = new System.Drawing.Size(100, 20);
			this.txtPerimeter.TabIndex = 7;
			this.txtPerimeter.TabStop = false;
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(16, 184);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate.TabIndex = 3;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.UseVisualStyleBackColor = false;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(101, 184);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// Form1
			// 
			this.AcceptButton = this.btnCalculate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(237, 221);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.txtPerimeter);
			this.Controls.Add(this.txtArea);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.widInput);
			this.Controls.Add(this.lenInput);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Area And Perimeter";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox lenInput;
		private System.Windows.Forms.TextBox widInput;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtArea;
		private System.Windows.Forms.TextBox txtPerimeter;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Button btnExit;
	}
}

