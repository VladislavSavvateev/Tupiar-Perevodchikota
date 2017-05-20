namespace Tupiar_Perevodchikota {
	partial class Form1 {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtSource = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtDestination = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rbR2E = new System.Windows.Forms.RadioButton();
			this.rbR2CR = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtSource);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(501, 48);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Исходный текст";
			// 
			// txtSource
			// 
			this.txtSource.Location = new System.Drawing.Point(6, 19);
			this.txtSource.Name = "txtSource";
			this.txtSource.Size = new System.Drawing.Size(489, 20);
			this.txtSource.TabIndex = 0;
			this.txtSource.TextChanged += new System.EventHandler(this.txtSource_TextChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtDestination);
			this.groupBox2.Location = new System.Drawing.Point(12, 66);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(501, 48);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Сконвертированный текст";
			// 
			// txtDestination
			// 
			this.txtDestination.Location = new System.Drawing.Point(6, 19);
			this.txtDestination.Name = "txtDestination";
			this.txtDestination.ReadOnly = true;
			this.txtDestination.Size = new System.Drawing.Size(489, 20);
			this.txtDestination.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(410, 146);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "VladislavSavvateev";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.rbR2E);
			this.groupBox3.Controls.Add(this.rbR2CR);
			this.groupBox3.Location = new System.Drawing.Point(12, 120);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(274, 41);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Тип конвертации";
			// 
			// rbR2E
			// 
			this.rbR2E.AutoSize = true;
			this.rbR2E.Location = new System.Drawing.Point(137, 19);
			this.rbR2E.Name = "rbR2E";
			this.rbR2E.Size = new System.Drawing.Size(133, 17);
			this.rbR2E.TabIndex = 1;
			this.rbR2E.Text = "Русский -> PYCCKNN";
			this.rbR2E.UseVisualStyleBackColor = true;
			this.rbR2E.CheckedChanged += new System.EventHandler(this.rbR2E_CheckedChanged);
			// 
			// rbR2CR
			// 
			this.rbR2CR.AutoSize = true;
			this.rbR2CR.Checked = true;
			this.rbR2CR.Location = new System.Drawing.Point(6, 19);
			this.rbR2CR.Name = "rbR2CR";
			this.rbR2CR.Size = new System.Drawing.Size(125, 17);
			this.rbR2CR.TabIndex = 0;
			this.rbR2CR.TabStop = true;
			this.rbR2CR.Text = "Русский -> Пуццкнн";
			this.rbR2CR.UseVisualStyleBackColor = true;
			this.rbR2CR.CheckedChanged += new System.EventHandler(this.rbR2CR_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(525, 170);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Tupiar Perevodchikota";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtSource;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtDestination;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton rbR2E;
		private System.Windows.Forms.RadioButton rbR2CR;
	}
}

