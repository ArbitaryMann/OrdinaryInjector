using System;
using System.Windows.Forms;

namespace MemoryKit
{
	// Token: 0x02000005 RID: 5
	internal static class Program
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002F44 File Offset: 0x00001144
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
