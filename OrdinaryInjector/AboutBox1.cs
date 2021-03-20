using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using OrdinaryInjector.Properties;

namespace OrdinaryInjector
{
	// Token: 0x02000006 RID: 6
	internal partial class AboutBox1 : Form
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00002F60 File Offset: 0x00001160
		public AboutBox1()
		{
			this.InitializeComponent();
			this.Text = string.Format("About {0}", this.AssemblyTitle);
			this.labelProductName.Text = this.AssemblyProduct;
			this.labelVersion.Text = string.Format("Version {0}", this.AssemblyVersion);
			this.labelCopyright.Text = this.AssemblyCopyright;
			this.labelCompanyName.Text = this.AssemblyCompany;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002FEC File Offset: 0x000011EC
		public string AssemblyTitle
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
				bool flag = customAttributes.Length != 0;
				if (flag)
				{
					AssemblyTitleAttribute assemblyTitleAttribute = (AssemblyTitleAttribute)customAttributes[0];
					bool flag2 = assemblyTitleAttribute.Title != "";
					if (flag2)
					{
						return assemblyTitleAttribute.Title;
					}
				}
				return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00003058 File Offset: 0x00001258
		public string AssemblyVersion
		{
			get
			{
				return Assembly.GetExecutingAssembly().GetName().Version.ToString();
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00003080 File Offset: 0x00001280
		public string AssemblyDescription
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
				bool flag = customAttributes.Length == 0;
				string result;
				if (flag)
				{
					result = "";
				}
				else
				{
					result = ((AssemblyDescriptionAttribute)customAttributes[0]).Description;
				}
				return result;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000030C8 File Offset: 0x000012C8
		public string AssemblyProduct
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
				bool flag = customAttributes.Length == 0;
				string result;
				if (flag)
				{
					result = "";
				}
				else
				{
					result = ((AssemblyProductAttribute)customAttributes[0]).Product;
				}
				return result;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00003110 File Offset: 0x00001310
		public string AssemblyCopyright
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
				bool flag = customAttributes.Length == 0;
				string result;
				if (flag)
				{
					result = "";
				}
				else
				{
					result = ((AssemblyCopyrightAttribute)customAttributes[0]).Copyright;
				}
				return result;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00003158 File Offset: 0x00001358
		public string AssemblyCompany
		{
			get
			{
				object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
				bool flag = customAttributes.Length == 0;
				string result;
				if (flag)
				{
					result = "";
				}
				else
				{
					result = ((AssemblyCompanyAttribute)customAttributes[0]).Company;
				}
				return result;
			}
		}
	}
}
