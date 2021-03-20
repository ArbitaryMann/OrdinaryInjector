using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using OrdinaryInjector;

namespace MemoryKit
{
	// Token: 0x02000004 RID: 4
	public partial class Form1 : Form
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002268 File Offset: 0x00000468
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000022C0 File Offset: 0x000004C0
		private void Form1_Load(object sender, EventArgs e)
		{
			foreach (Process process in Process.GetProcesses())
			{
				try
				{
					Icon icon = Icon.ExtractAssociatedIcon(process.MainModule.FileName);
					this.pictureBox1.Image = icon.ToBitmap();
					this.PID = process.Id;
					string[] array = new string[]
					{
						process.ProcessName,
						process.Id.ToString()
					};
					this.comboBox1.Items.Add(process.Id + " - " + process.ProcessName);
					string[] array2 = new string[4];
					array2[0] = process.ProcessName;
					array2[1] = process.Id.ToString();
					ListViewItem value = new ListViewItem(array2);
					this.listView1.Items.Add(value);
					this.comboBox3.Items.Add(process.MainModule.FileName);
					DirectoryInfo directoryInfo = new DirectoryInfo(Application.StartupPath);
					FileInfo[] files = directoryInfo.GetFiles("*.dll");
					string str = "";
					foreach (FileInfo fileInfo in files)
					{
						str += fileInfo.Name;
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002444 File Offset: 0x00000644
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002448 File Offset: 0x00000648
		private void comboBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				string text = this.comboBox1.Text;
				int count = this.comboBox1.Text.Length - 5 - 4;
				string input = text.Remove(5, count).Replace(".", null);
				string input2 = text.Replace("-", "").Replace(" ", "");
				string text2 = Regex.Replace(input, "[^0-9.]", "");
				string text3 = Regex.Replace(input2, "[0-9.]", "");
				this.comboBox3.SelectedIndex++;
				this.processName = text3;
				Debug.WriteLine(this.processName);
				Icon icon = Icon.ExtractAssociatedIcon(this.comboBox3.Text);
				this.pictureBox1.Image = icon.ToBitmap();
			}
			catch
			{
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002538 File Offset: 0x00000738
		private void button1_Click(object sender, EventArgs e)
		{
			DllInjector.GetInstance.Inject(this.pname, this.dll);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002554 File Offset: 0x00000754
		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.pname = this.listView1.SelectedItems[0].Text.Replace("{", "").Replace("}", "");
				this.label1.Text = "Selected Process ID: " + Process.GetProcessesByName(this.listView1.SelectedItems[0].Text.Replace("{", "").Replace("}", ""))[0].Id;
				this.processaa = Process.GetProcessesByName(this.listView1.SelectedItems[0].Text.Replace("{", "").Replace("}", ""))[0].Id.ToString();
			}
			catch
			{
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002660 File Offset: 0x00000860
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002664 File Offset: 0x00000864
		private void button3_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.ShowDialog();
			this.dll = openFileDialog.FileName;
			this.textBox1.Text = this.dll;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000026A0 File Offset: 0x000008A0
		private void button2_Click(object sender, EventArgs e)
		{
			AboutBox1 aboutBox = new AboutBox1();
			aboutBox.ShowDialog();
		}

		// Token: 0x04000008 RID: 8
		private int PID = 0;

		// Token: 0x04000009 RID: 9
		private string processName = "";

		// Token: 0x0400000A RID: 10
		private string processaa = "";

		// Token: 0x0400000B RID: 11
		private string pname = "";

		// Token: 0x0400000C RID: 12
		private string dll = "";
	}
}
