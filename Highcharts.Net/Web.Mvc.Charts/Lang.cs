using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class Lang : BaseObject
	{
		public string ContextButtonTitle
		{
			get;
			set;
		}

		private string ContextButtonTitle_DefaultValue
		{
			get;
			set;
		}

		public string DecimalPoint
		{
			get;
			set;
		}

		private string DecimalPoint_DefaultValue
		{
			get;
			set;
		}

		public string DownloadJPEG
		{
			get;
			set;
		}

		private string DownloadJPEG_DefaultValue
		{
			get;
			set;
		}

		public string DownloadPDF
		{
			get;
			set;
		}

		private string DownloadPDF_DefaultValue
		{
			get;
			set;
		}

		public string DownloadPNG
		{
			get;
			set;
		}

		private string DownloadPNG_DefaultValue
		{
			get;
			set;
		}

		public string DownloadSVG
		{
			get;
			set;
		}

		private string DownloadSVG_DefaultValue
		{
			get;
			set;
		}

		public string DrillUpText
		{
			get;
			set;
		}

		private string DrillUpText_DefaultValue
		{
			get;
			set;
		}

		public string InvalidDate
		{
			get;
			set;
		}

		private string InvalidDate_DefaultValue
		{
			get;
			set;
		}

		public string Loading
		{
			get;
			set;
		}

		private string Loading_DefaultValue
		{
			get;
			set;
		}

		public List<string> Months
		{
			get;
			set;
		}

		private List<string> Months_DefaultValue
		{
			get;
			set;
		}

		public string NoData
		{
			get;
			set;
		}

		private string NoData_DefaultValue
		{
			get;
			set;
		}

		public double? NumericSymbolMagnitude
		{
			get;
			set;
		}

		private double? NumericSymbolMagnitude_DefaultValue
		{
			get;
			set;
		}

		public List<string> NumericSymbols
		{
			get;
			set;
		}

		private List<string> NumericSymbols_DefaultValue
		{
			get;
			set;
		}

		public string PrintChart
		{
			get;
			set;
		}

		private string PrintChart_DefaultValue
		{
			get;
			set;
		}

		public string ResetZoom
		{
			get;
			set;
		}

		private string ResetZoom_DefaultValue
		{
			get;
			set;
		}

		public string ResetZoomTitle
		{
			get;
			set;
		}

		private string ResetZoomTitle_DefaultValue
		{
			get;
			set;
		}

		public List<string> ShortMonths
		{
			get;
			set;
		}

		private List<string> ShortMonths_DefaultValue
		{
			get;
			set;
		}

		public List<string> ShortWeekdays
		{
			get;
			set;
		}

		private List<string> ShortWeekdays_DefaultValue
		{
			get;
			set;
		}

		public string ThousandsSep
		{
			get;
			set;
		}

		private string ThousandsSep_DefaultValue
		{
			get;
			set;
		}

		public List<string> Weekdays
		{
			get;
			set;
		}

		private List<string> Weekdays_DefaultValue
		{
			get;
			set;
		}

		public Lang()
		{
			string str = "Chart context menu";
			string str1 = str;
			this.ContextButtonTitle_DefaultValue = str;
			this.ContextButtonTitle = str1;
			string str2 = ".";
			str1 = str2;
			this.DecimalPoint_DefaultValue = str2;
			this.DecimalPoint = str1;
			string str3 = "Download JPEG image";
			str1 = str3;
			this.DownloadJPEG_DefaultValue = str3;
			this.DownloadJPEG = str1;
			string str4 = "Download PDF document";
			str1 = str4;
			this.DownloadPDF_DefaultValue = str4;
			this.DownloadPDF = str1;
			string str5 = "Download PNG image";
			str1 = str5;
			this.DownloadPNG_DefaultValue = str5;
			this.DownloadPNG = str1;
			string str6 = "Download SVG vector image";
			str1 = str6;
			this.DownloadSVG_DefaultValue = str6;
			this.DownloadSVG = str1;
			string str7 = "Back to {series.name}";
			str1 = str7;
			this.DrillUpText_DefaultValue = str7;
			this.DrillUpText = str1;
			string str8 = "";
			str1 = str8;
			this.InvalidDate_DefaultValue = str8;
			this.InvalidDate = str1;
			string str9 = "Loading...";
			str1 = str9;
			this.Loading_DefaultValue = str9;
			this.Loading = str1;
			List<string> strs = new List<string>()
			{
				"January",
				"February",
				"March",
				"April",
				"May",
				"June",
				"July",
				"August",
				"September",
				"October",
				"November",
				"December"
			};
			List<string> strs1 = strs;
			List<string> strs2 = strs1;
			this.Months_DefaultValue = strs1;
			this.Months = strs2;
			string str10 = "No data to display";
			str1 = str10;
			this.NoData_DefaultValue = str10;
			this.NoData = str1;
			double? nullable = new double?((double)1000);
			this.NumericSymbolMagnitude_DefaultValue = nullable;
			this.NumericSymbolMagnitude = nullable;
			strs = new List<string>()
			{
				"k",
				"M",
				"G",
				"T",
				"P",
				"E"
			};
			List<string> strs3 = strs;
			strs2 = strs3;
			this.NumericSymbols_DefaultValue = strs3;
			this.NumericSymbols = strs2;
			string str11 = "Print chart";
			str1 = str11;
			this.PrintChart_DefaultValue = str11;
			this.PrintChart = str1;
			string str12 = "Reset zoom";
			str1 = str12;
			this.ResetZoom_DefaultValue = str12;
			this.ResetZoom = str1;
			string str13 = "Reset zoom level 1:1";
			str1 = str13;
			this.ResetZoomTitle_DefaultValue = str13;
			this.ResetZoomTitle = str1;
			strs = new List<string>()
			{
				"Jan",
				"Feb",
				"Mar",
				"Apr",
				"May",
				"Jun",
				"Jul",
				"Aug",
				"Sep",
				"Oct",
				"Nov",
				"Dec"
			};
			List<string> strs4 = strs;
			strs2 = strs4;
			this.ShortMonths_DefaultValue = strs4;
			this.ShortMonths = strs2;
			object obj = null;
			strs2 = (List<string>)obj;
			this.ShortWeekdays_DefaultValue = (List<string>)obj;
			this.ShortWeekdays = strs2;
			string str14 = " ";
			str1 = str14;
			this.ThousandsSep_DefaultValue = str14;
			this.ThousandsSep = str1;
			strs = new List<string>()
			{
				"Sunday",
				"Monday",
				"Tuesday",
				"Wednesday",
				"Thursday",
				"Friday",
				"Saturday"
			};
			List<string> strs5 = strs;
			strs2 = strs5;
			this.Weekdays_DefaultValue = strs5;
			this.Weekdays = strs2;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.ContextButtonTitle != this.ContextButtonTitle_DefaultValue)
			{
				hashtables.Add("contextButtonTitle", this.ContextButtonTitle);
			}
			if (this.DecimalPoint != this.DecimalPoint_DefaultValue)
			{
				hashtables.Add("decimalPoint", this.DecimalPoint);
			}
			if (this.DownloadJPEG != this.DownloadJPEG_DefaultValue)
			{
				hashtables.Add("downloadJPEG", this.DownloadJPEG);
			}
			if (this.DownloadPDF != this.DownloadPDF_DefaultValue)
			{
				hashtables.Add("downloadPDF", this.DownloadPDF);
			}
			if (this.DownloadPNG != this.DownloadPNG_DefaultValue)
			{
				hashtables.Add("downloadPNG", this.DownloadPNG);
			}
			if (this.DownloadSVG != this.DownloadSVG_DefaultValue)
			{
				hashtables.Add("downloadSVG", this.DownloadSVG);
			}
			if (this.DrillUpText != this.DrillUpText_DefaultValue)
			{
				hashtables.Add("drillUpText", this.DrillUpText);
			}
			if (this.InvalidDate != this.InvalidDate_DefaultValue)
			{
				hashtables.Add("invalidDate", this.InvalidDate);
			}
			if (this.Loading != this.Loading_DefaultValue)
			{
				hashtables.Add("loading", this.Loading);
			}
			if (this.Months != this.Months_DefaultValue)
			{
				hashtables.Add("months", this.Months);
			}
			if (this.NoData != this.NoData_DefaultValue)
			{
				hashtables.Add("noData", this.NoData);
			}
			double? numericSymbolMagnitude = this.NumericSymbolMagnitude;
			double? numericSymbolMagnitudeDefaultValue = this.NumericSymbolMagnitude_DefaultValue;
			if ((numericSymbolMagnitude.GetValueOrDefault() == numericSymbolMagnitudeDefaultValue.GetValueOrDefault() ? numericSymbolMagnitude.HasValue != numericSymbolMagnitudeDefaultValue.HasValue : true))
			{
				hashtables.Add("numericSymbolMagnitude", this.NumericSymbolMagnitude);
			}
			if (this.NumericSymbols != this.NumericSymbols_DefaultValue)
			{
				hashtables.Add("numericSymbols", this.NumericSymbols);
			}
			if (this.PrintChart != this.PrintChart_DefaultValue)
			{
				hashtables.Add("printChart", this.PrintChart);
			}
			if (this.ResetZoom != this.ResetZoom_DefaultValue)
			{
				hashtables.Add("resetZoom", this.ResetZoom);
			}
			if (this.ResetZoomTitle != this.ResetZoomTitle_DefaultValue)
			{
				hashtables.Add("resetZoomTitle", this.ResetZoomTitle);
			}
			if (this.ShortMonths != this.ShortMonths_DefaultValue)
			{
				hashtables.Add("shortMonths", this.ShortMonths);
			}
			if (this.ShortWeekdays != this.ShortWeekdays_DefaultValue)
			{
				hashtables.Add("shortWeekdays", this.ShortWeekdays);
			}
			if (this.ThousandsSep != this.ThousandsSep_DefaultValue)
			{
				hashtables.Add("thousandsSep", this.ThousandsSep);
			}
			if (this.Weekdays != this.Weekdays_DefaultValue)
			{
				hashtables.Add("weekdays", this.Weekdays);
			}
			return hashtables;
		}

		internal override string ToJSON()
		{
			string str;
			Hashtable hashtable = this.ToHashtable();
			JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer()
			{
				MaxJsonLength = 2147483647
			};
			str = (hashtable.Count <= 0 ? "" : javaScriptSerializer.Serialize(this.ToHashtable()));
			return str;
		}
	}
}