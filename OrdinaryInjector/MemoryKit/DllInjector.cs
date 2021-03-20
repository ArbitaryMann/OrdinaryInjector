using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MemoryKit
{
	// Token: 0x02000003 RID: 3
	public sealed class DllInjector
	{
		// Token: 0x06000001 RID: 1
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

		// Token: 0x06000002 RID: 2
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int CloseHandle(IntPtr hObject);

		// Token: 0x06000003 RID: 3
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

		// Token: 0x06000004 RID: 4
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr GetModuleHandle(string lpModuleName);

		// Token: 0x06000005 RID: 5
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect);

		// Token: 0x06000006 RID: 6
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, int lpNumberOfBytesWritten);

		// Token: 0x06000007 RID: 7
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttribute, IntPtr dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		public static DllInjector GetInstance
		{
			get
			{
				bool flag = DllInjector._instance == null;
				if (flag)
				{
					DllInjector._instance = new DllInjector();
				}
				return DllInjector._instance;
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000207F File Offset: 0x0000027F
		private DllInjector()
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000208C File Offset: 0x0000028C
		public DllInjectionResult Inject(string sProcName, string sDllPath)
		{
			bool flag = !File.Exists(sDllPath);
			DllInjectionResult result;
			if (flag)
			{
				result = DllInjectionResult.DllNotFound;
			}
			else
			{
				uint num = 0U;
				Process[] processes = Process.GetProcesses();
				for (int i = 0; i < processes.Length; i++)
				{
					bool flag2 = processes[i].ProcessName == sProcName;
					if (flag2)
					{
						num = (uint)processes[i].Id;
						break;
					}
				}
				bool flag3 = num == 0U;
				if (flag3)
				{
					MessageBox.Show("FINDING PROCESS FAILED!", "OrdinaryInjector v1.0", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					result = DllInjectionResult.GameProcessNotFound;
				}
				else
				{
					bool flag4 = !this.bInject(num, sDllPath);
					if (flag4)
					{
						MessageBox.Show("INJECTION FAILED!", "OrdinaryInjector v1.0", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						result = DllInjectionResult.InjectionFailed;
					}
					else
					{
						MessageBox.Show("INJECTION WAS SUCCESSFULL!", "OrdinaryInjector v1.0", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						result = DllInjectionResult.Success;
					}
				}
			}
			return result;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002158 File Offset: 0x00000358
		private bool bInject(uint pToBeInjected, string sDllPath)
		{
			IntPtr intPtr = DllInjector.OpenProcess(1082U, 1, pToBeInjected);
			bool flag = intPtr == DllInjector.INTPTR_ZERO;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				IntPtr procAddress = DllInjector.GetProcAddress(DllInjector.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
				bool flag2 = procAddress == DllInjector.INTPTR_ZERO;
				if (flag2)
				{
					result = false;
				}
				else
				{
					IntPtr intPtr2 = DllInjector.VirtualAllocEx(intPtr, (IntPtr)null, (IntPtr)sDllPath.Length, 12288U, 64U);
					bool flag3 = intPtr2 == DllInjector.INTPTR_ZERO;
					if (flag3)
					{
						result = false;
					}
					else
					{
						byte[] bytes = Encoding.ASCII.GetBytes(sDllPath);
						bool flag4 = DllInjector.WriteProcessMemory(intPtr, intPtr2, bytes, (uint)bytes.Length, 0) == 0;
						if (flag4)
						{
							result = false;
						}
						else
						{
							bool flag5 = DllInjector.CreateRemoteThread(intPtr, (IntPtr)null, DllInjector.INTPTR_ZERO, procAddress, intPtr2, 0U, (IntPtr)null) == DllInjector.INTPTR_ZERO;
							if (flag5)
							{
								result = false;
							}
							else
							{
								DllInjector.CloseHandle(intPtr);
								result = true;
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr INTPTR_ZERO = (IntPtr)0;

		// Token: 0x04000007 RID: 7
		private static DllInjector _instance;
	}
}
