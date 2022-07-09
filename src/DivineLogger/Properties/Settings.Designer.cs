using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace DivineLogger.Properties
{
	// Token: 0x02000005 RID: 5
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002BE4 File Offset: 0x00000DE4
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000011 RID: 17
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
