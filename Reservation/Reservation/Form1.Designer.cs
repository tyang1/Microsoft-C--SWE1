namespace Reservation
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_Arrival = new System.Windows.Forms.TextBox();
			this.txt_Departure = new System.Windows.Forms.TextBox();
			this.txt_NumberNights = new System.Windows.Forms.TextBox();
			this.txt_UnitPrice = new System.Windows.Forms.TextBox();
			this.txt_TotalPrice = new System.Windows.Forms.TextBox();
			this.btn_Calculate = new System.Windows.Forms.Button();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Arrival date:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Departure date:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(5, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Number of nights:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Price per night:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(35, 148);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Total price:";
			// 
			// txt_Arrival
			// 
			this.txt_Arrival.Location = new System.Drawing.Point(142, 20);
			this.txt_Arrival.Name = "txt_Arrival";
			this.txt_Arrival.Size = new System.Drawing.Size(100, 20);
			this.txt_Arrival.TabIndex = 5;
			// 
			// txt_Departure
			// 
			this.txt_Departure.Location = new System.Drawing.Point(142, 52);
			this.txt_Departure.Name = "txt_Departure";
			this.txt_Departure.Size = new System.Drawing.Size(100, 20);
			this.txt_Departure.TabIndex = 6;
			// 
			// txt_NumberNights
			// 
			this.txt_NumberNights.Location = new System.Drawing.Point(142, 84);
			this.txt_NumberNights.Name = "txt_NumberNights";
			this.txt_NumberNights.ReadOnly = true;
			this.txt_NumberNights.Size = new System.Drawing.Size(100, 20);
			this.txt_NumberNights.TabIndex = 7;
			this.txt_NumberNights.TabStop = false;
			// 
			// txt_UnitPrice
			// 
			this.txt_UnitPrice.Location = new System.Drawing.Point(142, 116);
			this.txt_UnitPrice.Name = "txt_UnitPrice";
			this.txt_UnitPrice.ReadOnly = true;
			this.txt_UnitPrice.Size = new System.Drawing.Size(100, 20);
			this.txt_UnitPrice.TabIndex = 8;
			this.txt_UnitPrice.TabStop = false;
			// 
			// txt_TotalPrice
			// 
			this.txt_TotalPrice.Location = new System.Drawing.Point(142, 148);
			this.txt_TotalPrice.Name = "txt_TotalPrice";
			this.txt_TotalPrice.ReadOnly = true;
			this.txt_TotalPrice.Size = new System.Drawing.Size(100, 20);
			this.txt_TotalPrice.TabIndex = 9;
			// 
			// btn_Calculate
			// 
			this.btn_Calculate.Location = new System.Drawing.Point(38, 212);
			this.btn_Calculate.Name = "btn_Calculate";
			this.btn_Calculate.Size = new System.Drawing.Size(75, 23);
			this.btn_Calculate.TabIndex = 10;
			this.btn_Calculate.Text = "&Calculate";
			this.btn_Calculate.UseVisualStyleBackColor = true;
			this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
			// 
			// btn_Exit
			// 
			this.btn_Exit.Location = new System.Drawing.Point(152, 212);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(75, 23);
			this.btn_Exit.TabIndex = 11;
			this.btn_Exit.Text = "E&xit";
			this.btn_Exit.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.btn_Calculate);
			this.Controls.Add(this.txt_TotalPrice);
			this.Controls.Add(this.txt_UnitPrice);
			this.Controls.Add(this.txt_NumberNights);
			this.Controls.Add(this.txt_Departure);
			this.Controls.Add(this.txt_Arrival);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Reservation";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_Arrival;
		private System.Windows.Forms.TextBox txt_Departure;
		private System.Windows.Forms.TextBox txt_NumberNights;
		private System.Windows.Forms.TextBox txt_UnitPrice;
		private System.Windows.Forms.TextBox txt_TotalPrice;
		private System.Windows.Forms.Button btn_Calculate;
		private System.Windows.Forms.Button btn_Exit;
	}
}

