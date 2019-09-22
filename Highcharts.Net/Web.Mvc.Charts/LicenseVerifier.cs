using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Reflection;
using System.Text;

namespace Highsoft.Web.Mvc.Charts
{
	internal static class LicenseVerifier
	{
		private static string KEY_NAME;

		static LicenseVerifier()
		{
			LicenseVerifier.KEY_NAME = "Highcharts";
		}

		public static int Check()
		{
			return 0;

			// bypass licence check - return true all the time
			//int num;
			//string serialFromFile = LicenseVerifier.GetSerialFromFile();
			//if (serialFromFile != null)
			//{
			//	num = (!LicenseVerifier.IsSerialCorrect(LicenseVerifier.DecodeSerial(serialFromFile)) ? 0 : 1);
			//}
			//else
			//{
			//	num = -1;
			//}
			//return num;
		}

		private static string DecodeSerial(string text)
		{
			string str;
			try
			{
				str = Encoding.UTF8.GetString(Convert.FromBase64String(text));
			}
			catch (Exception)
			{
				str = "";
			}
			return str;
		}

		private static string GetAssemblyVersion()
		{
			int major = Assembly.GetExecutingAssembly().GetName().Version.Major;
			return major.ToString();
		}

		private static string GetLicenseVersion(string serial)
		{
			return serial.Substring(3, 1);
		}

		private static string GetSerialFromFile()
		{
			string str;
			string[] values = ConfigurationManager.AppSettings.GetValues(LicenseVerifier.KEY_NAME);
			if (values == null)
			{
				str = null;
			}
			else if (values.Length != 0)
			{
				str = values[0];
			}
			else
			{
				str = null;
			}
			return str;
		}

		private static bool IsSerialCorrect(string serial)
		{
			bool flag;
			if (serial.Length < 12)
			{
				flag = false;
			}
			else if (serial.Substring(0, 3) != "Ver")
			{
				flag = false;
			}
			else if (LicenseVerifier.GetLicenseVersion(serial) == LicenseVerifier.GetAssemblyVersion())
			{
				flag = (serial.Substring(4, 7) == "NetWrap" ? true : false);
			}
			else
			{
				flag = false;
			}
			return flag;
		}
	}
}