using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace OrdinaryInjector.Properties
{
	// Token: 0x02000007 RID: 7
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000022 RID: 34 RVA: 0x000038A8 File Offset: 0x00001AA8
		internal Resources()
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000038B4 File Offset: 0x00001AB4
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("OrdinaryInjector.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000038FC File Offset: 0x00001AFC
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00003913 File Offset: 0x00001B13
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000026 RID: 38 RVA: 0x0000391C File Offset: 0x00001B1C
		internal static Bitmap MemoryKit
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("MemoryKit", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x04000021 RID: 33
		private static ResourceManager resourceMan;

		// Token: 0x04000022 RID: 34
		private static CultureInfo resourceCulture;
	}
}
