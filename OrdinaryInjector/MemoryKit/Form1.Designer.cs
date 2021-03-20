namespace MemoryKit
{
	// Token: 0x02000004 RID: 4
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000016 RID: 22 RVA: 0x000026BC File Offset: 0x000008BC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000026F4 File Offset: 0x000008F4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MemoryKit.Form1));
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.comboBox3 = new global::System.Windows.Forms.ComboBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new global::System.Windows.Forms.ColumnHeader();
			this.label1 = new global::System.Windows.Forms.Label();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.button3 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.comboBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new global::System.Drawing.Point(43, 11);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(180, 21);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.Text = "Example.exe";
			this.comboBox1.Visible = false;
			this.comboBox1.SelectedIndexChanged += new global::System.EventHandler(this.comboBox1_SelectedIndexChanged);
			this.comboBox1.TextChanged += new global::System.EventHandler(this.comboBox1_TextChanged);
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new global::System.Drawing.Point(374, 379);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new global::System.Drawing.Size(121, 21);
			this.comboBox3.TabIndex = 5;
			this.comboBox3.Visible = false;
			this.button1.BackColor = global::System.Drawing.Color.SteelBlue;
			this.button1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.button1.FlatAppearance.BorderColor = global::System.Drawing.Color.SteelBlue;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(261, 230);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(169, 35);
			this.button1.TabIndex = 6;
			this.button1.Text = "Inject";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.BackColor = global::System.Drawing.Color.SteelBlue;
			this.button2.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.button2.FlatAppearance.BorderColor = global::System.Drawing.Color.SteelBlue;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Location = new global::System.Drawing.Point(12, 230);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(169, 35);
			this.button2.TabIndex = 7;
			this.button2.Text = "About";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.listView1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader1,
				this.columnHeader2
			});
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(12, 58);
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(418, 163);
			this.listView1.TabIndex = 8;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new global::System.EventHandler(this.listView1_SelectedIndexChanged);
			this.columnHeader1.Text = "Process Name";
			this.columnHeader1.Width = 146;
			this.columnHeader2.Text = "ID";
			this.columnHeader2.Width = 73;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(9, 38);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(107, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Selected Process ID:";
			this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBox1.Location = new global::System.Drawing.Point(43, 12);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(294, 20);
			this.textBox1.TabIndex = 10;
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.button3.BackColor = global::System.Drawing.Color.SteelBlue;
			this.button3.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.button3.FlatAppearance.BorderColor = global::System.Drawing.Color.SteelBlue;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button3.ForeColor = global::System.Drawing.Color.White;
			this.button3.Location = new global::System.Drawing.Point(343, 9);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(87, 24);
			this.button3.TabIndex = 11;
			this.button3.Text = "Add DLL";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.pictureBox1.Location = new global::System.Drawing.Point(12, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(25, 24);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(440, 274);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.listView1);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.comboBox3);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.comboBox1);
			this.ForeColor = global::System.Drawing.SystemColors.ControlText;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "Form1";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ordinary Injector 1.0";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400000D RID: 13
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.ComboBox comboBox3;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.ColumnHeader columnHeader1;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.ColumnHeader columnHeader2;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Button button3;
	}
}
