using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class Exporting : BaseObject
	{
		public bool? AllowHTML
		{
			get;
			set;
		}

		private bool? AllowHTML_DefaultValue
		{
			get;
			set;
		}

		public ExportingButtons Buttons
		{
			get;
			set;
		}

		private ExportingButtons Buttons_DefaultValue
		{
			get;
			set;
		}

		public object ChartOptions
		{
			get;
			set;
		}

		private object ChartOptions_DefaultValue
		{
			get;
			set;
		}

		public bool? Enabled
		{
			get;
			set;
		}

		private bool? Enabled_DefaultValue
		{
			get;
			set;
		}

		public string Error
		{
			get;
			set;
		}

		private string Error_DefaultValue
		{
			get;
			set;
		}

		public bool? FallbackToExportServer
		{
			get;
			set;
		}

		private bool? FallbackToExportServer_DefaultValue
		{
			get;
			set;
		}

		public string Filename
		{
			get;
			set;
		}

		private string Filename_DefaultValue
		{
			get;
			set;
		}

		public object FormAttributes
		{
			get;
			set;
		}

		private object FormAttributes_DefaultValue
		{
			get;
			set;
		}

		public string LibURL
		{
			get;
			set;
		}

		private string LibURL_DefaultValue
		{
			get;
			set;
		}

		public double? PrintMaxWidth
		{
			get;
			set;
		}

		private double? PrintMaxWidth_DefaultValue
		{
			get;
			set;
		}

		public double? Scale
		{
			get;
			set;
		}

		private double? Scale_DefaultValue
		{
			get;
			set;
		}

		public double? SourceHeight
		{
			get;
			set;
		}

		private double? SourceHeight_DefaultValue
		{
			get;
			set;
		}

		public double? SourceWidth
		{
			get;
			set;
		}

		private double? SourceWidth_DefaultValue
		{
			get;
			set;
		}

		public ExportingType Type
		{
			get;
			set;
		}

		private ExportingType Type_DefaultValue
		{
			get;
			set;
		}

		public string Url
		{
			get;
			set;
		}

		private string Url_DefaultValue
		{
			get;
			set;
		}

		public double? Width
		{
			get;
			set;
		}

		private double? Width_DefaultValue
		{
			get;
			set;
		}

		public Exporting()
		{
			bool? nullable = new bool?(false);
			this.AllowHTML_DefaultValue = nullable;
			this.AllowHTML = nullable;
			ExportingButtons exportingButton = new ExportingButtons();
			ExportingButtons exportingButton1 = exportingButton;
			this.Buttons_DefaultValue = exportingButton;
			this.Buttons = exportingButton1;
			object obj = null;
			object obj1 = obj;
			this.ChartOptions_DefaultValue = obj;
			this.ChartOptions = obj1;
			nullable = new bool?(true);
			this.Enabled_DefaultValue = nullable;
			this.Enabled = nullable;
			string str = "";
			string str1 = str;
			this.Error_DefaultValue = str;
			this.Error = str1;
			nullable = new bool?(true);
			this.FallbackToExportServer_DefaultValue = nullable;
			this.FallbackToExportServer = nullable;
			string str2 = "chart";
			str1 = str2;
			this.Filename_DefaultValue = str2;
			this.Filename = str1;
			string str3 = "";
			obj1 = str3;
			this.FormAttributes_DefaultValue = str3;
			this.FormAttributes = obj1;
			string str4 = "https://code.highcharts.com/{version}/lib";
			str1 = str4;
			this.LibURL_DefaultValue = str4;
			this.LibURL = str1;
			double? nullable1 = new double?((double)780);
			this.PrintMaxWidth_DefaultValue = nullable1;
			this.PrintMaxWidth = nullable1;
			nullable1 = new double?((double)2);
			this.Scale_DefaultValue = nullable1;
			this.Scale = nullable1;
			nullable1 = null;
			this.SourceHeight_DefaultValue = nullable1;
			this.SourceHeight = nullable1;
			nullable1 = null;
			this.SourceWidth_DefaultValue = nullable1;
			this.SourceWidth = nullable1;
			int num = 0;
			ExportingType exportingType = (ExportingType)num;
			this.Type_DefaultValue = (ExportingType)num;
			this.Type = exportingType;
			string str5 = "https://export.highcharts.com";
			str1 = str5;
			this.Url_DefaultValue = str5;
			this.Url = str1;
			nullable1 = null;
			this.Width_DefaultValue = nullable1;
			this.Width = nullable1;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			bool? allowHTML = this.AllowHTML;
			bool? allowHTMLDefaultValue = this.AllowHTML_DefaultValue;
			if ((allowHTML.GetValueOrDefault() == allowHTMLDefaultValue.GetValueOrDefault() ? allowHTML.HasValue != allowHTMLDefaultValue.HasValue : true))
			{
				hashtables.Add("allowHTML", this.AllowHTML);
			}
			if (this.Buttons.IsDirty())
			{
				hashtables.Add("buttons", this.Buttons.ToHashtable());
			}
			if (this.ChartOptions != this.ChartOptions_DefaultValue)
			{
				hashtables.Add("chartOptions", this.ChartOptions);
			}
			allowHTMLDefaultValue = this.Enabled;
			allowHTML = this.Enabled_DefaultValue;
			if ((allowHTMLDefaultValue.GetValueOrDefault() == allowHTML.GetValueOrDefault() ? allowHTMLDefaultValue.HasValue != allowHTML.HasValue : true))
			{
				hashtables.Add("enabled", this.Enabled);
			}
			if (this.Error != this.Error_DefaultValue)
			{
				hashtables.Add("error", this.Error);
				Highcharts.AddFunction("ExportingError.error", this.Error);
			}
			allowHTML = this.FallbackToExportServer;
			allowHTMLDefaultValue = this.FallbackToExportServer_DefaultValue;
			if ((allowHTML.GetValueOrDefault() == allowHTMLDefaultValue.GetValueOrDefault() ? allowHTML.HasValue != allowHTMLDefaultValue.HasValue : true))
			{
				hashtables.Add("fallbackToExportServer", this.FallbackToExportServer);
			}
			if (this.Filename != this.Filename_DefaultValue)
			{
				hashtables.Add("filename", this.Filename);
			}
			if (this.FormAttributes != this.FormAttributes_DefaultValue)
			{
				hashtables.Add("formAttributes", this.FormAttributes);
			}
			if (this.LibURL != this.LibURL_DefaultValue)
			{
				hashtables.Add("libURL", this.LibURL);
			}
			double? printMaxWidth = this.PrintMaxWidth;
			double? printMaxWidthDefaultValue = this.PrintMaxWidth_DefaultValue;
			if ((printMaxWidth.GetValueOrDefault() == printMaxWidthDefaultValue.GetValueOrDefault() ? printMaxWidth.HasValue != printMaxWidthDefaultValue.HasValue : true))
			{
				hashtables.Add("printMaxWidth", this.PrintMaxWidth);
			}
			printMaxWidthDefaultValue = this.Scale;
			printMaxWidth = this.Scale_DefaultValue;
			if ((printMaxWidthDefaultValue.GetValueOrDefault() == printMaxWidth.GetValueOrDefault() ? printMaxWidthDefaultValue.HasValue != printMaxWidth.HasValue : true))
			{
				hashtables.Add("scale", this.Scale);
			}
			printMaxWidth = this.SourceHeight;
			printMaxWidthDefaultValue = this.SourceHeight_DefaultValue;
			if ((printMaxWidth.GetValueOrDefault() == printMaxWidthDefaultValue.GetValueOrDefault() ? printMaxWidth.HasValue != printMaxWidthDefaultValue.HasValue : true))
			{
				hashtables.Add("sourceHeight", this.SourceHeight);
			}
			printMaxWidthDefaultValue = this.SourceWidth;
			printMaxWidth = this.SourceWidth_DefaultValue;
			if ((printMaxWidthDefaultValue.GetValueOrDefault() == printMaxWidth.GetValueOrDefault() ? printMaxWidthDefaultValue.HasValue != printMaxWidth.HasValue : true))
			{
				hashtables.Add("sourceWidth", this.SourceWidth);
			}
			if (this.Type != this.Type_DefaultValue)
			{
				ExportingType type = this.Type;
				hashtables.Add("type", Highcharts.FirstCharacterToLower(type.ToString()));
			}
			if (this.Url != this.Url_DefaultValue)
			{
				hashtables.Add("url", this.Url);
			}
			printMaxWidth = this.Width;
			printMaxWidthDefaultValue = this.Width_DefaultValue;
			if ((printMaxWidth.GetValueOrDefault() == printMaxWidthDefaultValue.GetValueOrDefault() ? printMaxWidth.HasValue != printMaxWidthDefaultValue.HasValue : true))
			{
				hashtables.Add("width", this.Width);
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