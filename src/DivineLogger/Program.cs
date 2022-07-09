using System;
using System.Windows.Forms;

namespace DivineLogger
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002B74 File Offset: 0x00000D74
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new DLogger());
		}
	}
}
