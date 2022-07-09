using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace DivineLogger.Properties
{
	// Token: 0x02000004 RID: 4
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002B8B File Offset: 0x00000D8B
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002B93 File Offset: 0x00000D93
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("DivineLogger.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002BBF File Offset: 0x00000DBF
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002BC6 File Offset: 0x00000DC6
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

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002BCE File Offset: 0x00000DCE
		internal static string Class1
		{
			get
			{
				return Resources.ResourceManager.GetString("Class1", Resources.resourceCulture);
			}
		}

		// Token: 0x0400000F RID: 15
		private static ResourceManager resourceMan;

		// Token: 0x04000010 RID: 16
		private static CultureInfo resourceCulture;
	}
}
