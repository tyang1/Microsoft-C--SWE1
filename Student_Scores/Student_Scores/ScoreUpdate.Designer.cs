namespace Student_Scores
{
	partial class ScoreUpdate
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lstExistingScores = new System.Windows.Forms.ListBox();
			this.btnExistingAdd = new System.Windows.Forms.Button();
			this.btnExistingUpdate = new System.Windows.Forms.Button();
			this.btnExistingRemove = new System.Windows.Forms.Button();
			this.btnExistingClear = new System.Windows.Forms.Button();
			this.btnExistingOk = new System.Windows.Forms.Button();
			this.btnExistingCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(85, 39);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Scores";
			// 
			// lstExistingScores
			// 
			this.lstExistingScores.FormattingEnabled = true;
			this.lstExistingScores.Location = new System.Drawing.Point(65, 91);
			this.lstExistingScores.Name = "lstExistingScores";
			this.lstExistingScores.Size = new System.Drawing.Size(120, 95);
			this.lstExistingScores.TabIndex = 3;
			// 
			// btnExistingAdd
			// 
			this.btnExistingAdd.Location = new System.Drawing.Point(197, 71);
			this.btnExistingAdd.Name = "btnExistingAdd";
			this.btnExistingAdd.Size = new System.Drawing.Size(75, 23);
			this.btnExistingAdd.TabIndex = 4;
			this.btnExistingAdd.Text = "Add";
			this.btnExistingAdd.UseVisualStyleBackColor = true;
			this.btnExistingAdd.Click += new System.EventHandler(this.btnExistingAdd_Click);
			// 
			// btnExistingUpdate
			// 
			this.btnExistingUpdate.Location = new System.Drawing.Point(197, 100);
			this.btnExistingUpdate.Name = "btnExistingUpdate";
			this.btnExistingUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnExistingUpdate.TabIndex = 5;
			this.btnExistingUpdate.Text = "Update";
			this.btnExistingUpdate.UseVisualStyleBackColor = true;
			this.btnExistingUpdate.Click += new System.EventHandler(this.btnExistingUpdate_Click);
			// 
			// btnExistingRemove
			// 
			this.btnExistingRemove.Location = new System.Drawing.Point(197, 129);
			this.btnExistingRemove.Name = "btnExistingRemove";
			this.btnExistingRemove.Size = new System.Drawing.Size(75, 23);
			this.btnExistingRemove.TabIndex = 6;
			this.btnExistingRemove.Text = "Remove";
			this.btnExistingRemove.UseVisualStyleBackColor = true;
			this.btnExistingRemove.Click += new System.EventHandler(this.btnExistingRemove_Click);
			// 
			// btnExistingClear
			// 
			this.btnExistingClear.Location = new System.Drawing.Point(197, 159);
			this.btnExistingClear.Name = "btnExistingClear";
			this.btnExistingClear.Size = new System.Drawing.Size(75, 23);
			this.btnExistingClear.TabIndex = 7;
			this.btnExistingClear.Text = "Clear Scores";
			this.btnExistingClear.UseVisualStyleBackColor = true;
			this.btnExistingClear.Click += new System.EventHandler(this.btnExistingClear_Click);
			// 
			// btnExistingOk
			// 
			this.btnExistingOk.Location = new System.Drawing.Point(85, 218);
			this.btnExistingOk.Name = "btnExistingOk";
			this.btnExistingOk.Size = new System.Drawing.Size(75, 23);
			this.btnExistingOk.TabIndex = 8;
			this.btnExistingOk.Text = "OK";
			this.btnExistingOk.UseVisualStyleBackColor = true;
			this.btnExistingOk.Click += new System.EventHandler(this.btnExistingOk_Click);
			// 
			// btnExistingCancel
			// 
			this.btnExistingCancel.Location = new System.Drawing.Point(197, 218);
			this.btnExistingCancel.Name = "btnExistingCancel";
			this.btnExistingCancel.Size = new System.Drawing.Size(75, 23);
			this.btnExistingCancel.TabIndex = 9;
			this.btnExistingCancel.Text = "Cancel";
			this.btnExistingCancel.UseVisualStyleBackColor = true;
			this.btnExistingCancel.Click += new System.EventHandler(this.btnExistingCancel_Click);
			// 
			// ScoreUpdate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.btnExistingCancel);
			this.Controls.Add(this.btnExistingOk);
			this.Controls.Add(this.btnExistingClear);
			this.Controls.Add(this.btnExistingRemove);
			this.Controls.Add(this.btnExistingUpdate);
			this.Controls.Add(this.btnExistingAdd);
			this.Controls.Add(this.lstExistingScores);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "ScoreUpdate";
			this.Text = "ScoreUpdate";
			this.Load += new System.EventHandler(this.ScoreUpdate_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox lstExistingScores;
		private System.Windows.Forms.Button btnExistingAdd;
		private System.Windows.Forms.Button btnExistingUpdate;
		private System.Windows.Forms.Button btnExistingRemove;
		private System.Windows.Forms.Button btnExistingClear;
		private System.Windows.Forms.Button btnExistingOk;
		private System.Windows.Forms.Button btnExistingCancel;
	}
}