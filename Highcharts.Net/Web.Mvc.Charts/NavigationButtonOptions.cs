using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class NavigationButtonOptions : BaseObject
	{
		public NavigationButtonOptionsAlign Align
		{
			get;
			set;
		}

		private NavigationButtonOptionsAlign Align_DefaultValue
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

		public double? Height
		{
			get;
			set;
		}

		private double? Height_DefaultValue
		{
			get;
			set;
		}

		public string SymbolFill
		{
			get;
			set;
		}

		private string SymbolFill_DefaultValue
		{
			get;
			set;
		}

		public double? SymbolSize
		{
			get;
			set;
		}

		private double? SymbolSize_DefaultValue
		{
			get;
			set;
		}

		public string SymbolStroke
		{
			get;
			set;
		}

		private string SymbolStroke_DefaultValue
		{
			get;
			set;
		}

		public double? SymbolStrokeWidth
		{
			get;
			set;
		}

		private double? SymbolStrokeWidth_DefaultValue
		{
			get;
			set;
		}

		public double? SymbolX
		{
			get;
			set;
		}

		private double? SymbolX_DefaultValue
		{
			get;
			set;
		}

		public double? SymbolY
		{
			get;
			set;
		}

		private double? SymbolY_DefaultValue
		{
			get;
			set;
		}

		public string Text
		{
			get;
			set;
		}

		private string Text_DefaultValue
		{
			get;
			set;
		}

		public object Theme
		{
			get;
			set;
		}

		private object Theme_DefaultValue
		{
			get;
			set;
		}

		public NavigationButtonOptionsVerticalAlign VerticalAlign
		{
			get;
			set;
		}

		private NavigationButtonOptionsVerticalAlign VerticalAlign_DefaultValue
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

		public double? Y
		{
			get;
			set;
		}

		private double? Y_DefaultValue
		{
			get;
			set;
		}

		public NavigationButtonOptions()
		{
			int num = 2;
			NavigationButtonOptionsAlign navigationButtonOptionsAlign = (NavigationButtonOptionsAlign)num;
			this.Align_DefaultValue = (NavigationButtonOptionsAlign)num;
			this.Align = navigationButtonOptionsAlign;
			bool? nullable = new bool?(true);
			this.Enabled_DefaultValue = nullable;
			this.Enabled = nullable;
			double? nullable1 = new double?((double)20);
			this.Height_DefaultValue = nullable1;
			this.Height = nullable1;
			string str = "#666666";
			string str1 = str;
			this.SymbolFill_DefaultValue = str;
			this.SymbolFill = str1;
			nullable1 = new double?((double)14);
			this.SymbolSize_DefaultValue = nullable1;
			this.SymbolSize = nullable1;
			string str2 = "#666666";
			str1 = str2;
			this.SymbolStroke_DefaultValue = str2;
			this.SymbolStroke = str1;
			nullable1 = new double?((double)1);
			this.SymbolStrokeWidth_DefaultValue = nullable1;
			this.SymbolStrokeWidth = nullable1;
			nullable1 = new double?(12.5);
			this.SymbolX_DefaultValue = nullable1;
			this.SymbolX = nullable1;
			nullable1 = new double?(10.5);
			this.SymbolY_DefaultValue = nullable1;
			this.SymbolY = nullable1;
			string str3 = "null";
			str1 = str3;
			this.Text_DefaultValue = str3;
			this.Text = str1;
			string str4 = "";
			object obj = str4;
			this.Theme_DefaultValue = str4;
			this.Theme = obj;
			int num1 = 0;
			NavigationButtonOptionsVerticalAlign navigationButtonOptionsVerticalAlign = (NavigationButtonOptionsVerticalAlign)num1;
			this.VerticalAlign_DefaultValue = (NavigationButtonOptionsVerticalAlign)num1;
			this.VerticalAlign = navigationButtonOptionsVerticalAlign;
			nullable1 = new double?((double)24);
			this.Width_DefaultValue = nullable1;
			this.Width = nullable1;
			nullable1 = new double?(0);
			this.Y_DefaultValue = nullable1;
			this.Y = nullable1;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.Align != this.Align_DefaultValue)
			{
				NavigationButtonOptionsAlign align = this.Align;
				hashtables.Add("align", Highcharts.FirstCharacterToLower(align.ToString()));
			}
			bool? enabled = this.Enabled;
			bool? enabledDefaultValue = this.Enabled_DefaultValue;
			if ((enabled.GetValueOrDefault() == enabledDefaultValue.GetValueOrDefault() ? enabled.HasValue != enabledDefaultValue.HasValue : true))
			{
				hashtables.Add("enabled", this.Enabled);
			}
			double? height = this.Height;
			double? heightDefaultValue = this.Height_DefaultValue;
			if ((height.GetValueOrDefault() == heightDefaultValue.GetValueOrDefault() ? height.HasValue != heightDefaultValue.HasValue : true))
			{
				hashtables.Add("height", this.Height);
			}
			if (this.SymbolFill != this.SymbolFill_DefaultValue)
			{
				hashtables.Add("symbolFill", this.SymbolFill);
			}
			heightDefaultValue = this.SymbolSize;
			height = this.SymbolSize_DefaultValue;
			if ((heightDefaultValue.GetValueOrDefault() == height.GetValueOrDefault() ? heightDefaultValue.HasValue != height.HasValue : true))
			{
				hashtables.Add("symbolSize", this.SymbolSize);
			}
			if (this.SymbolStroke != this.SymbolStroke_DefaultValue)
			{
				hashtables.Add("symbolStroke", this.SymbolStroke);
			}
			height = this.SymbolStrokeWidth;
			heightDefaultValue = this.SymbolStrokeWidth_DefaultValue;
			if ((height.GetValueOrDefault() == heightDefaultValue.GetValueOrDefault() ? height.HasValue != heightDefaultValue.HasValue : true))
			{
				hashtables.Add("symbolStrokeWidth", this.SymbolStrokeWidth);
			}
			heightDefaultValue = this.SymbolX;
			height = this.SymbolX_DefaultValue;
			if ((heightDefaultValue.GetValueOrDefault() == height.GetValueOrDefault() ? heightDefaultValue.HasValue != height.HasValue : true))
			{
				hashtables.Add("symbolX", this.SymbolX);
			}
			height = this.SymbolY;
			heightDefaultValue = this.SymbolY_DefaultValue;
			if ((height.GetValueOrDefault() == heightDefaultValue.GetValueOrDefault() ? height.HasValue != heightDefaultValue.HasValue : true))
			{
				hashtables.Add("symbolY", this.SymbolY);
			}
			if (this.Text != this.Text_DefaultValue)
			{
				hashtables.Add("text", this.Text);
			}
			if (this.Theme != this.Theme_DefaultValue)
			{
				hashtables.Add("theme", this.Theme);
			}
			if (this.VerticalAlign != this.VerticalAlign_DefaultValue)
			{
				NavigationButtonOptionsVerticalAlign verticalAlign = this.VerticalAlign;
				hashtables.Add("verticalAlign", Highcharts.FirstCharacterToLower(verticalAlign.ToString()));
			}
			heightDefaultValue = this.Width;
			height = this.Width_DefaultValue;
			if ((heightDefaultValue.GetValueOrDefault() == height.GetValueOrDefault() ? heightDefaultValue.HasValue != height.HasValue : true))
			{
				hashtables.Add("width", this.Width);
			}
			height = this.Y;
			heightDefaultValue = this.Y_DefaultValue;
			if ((height.GetValueOrDefault() == heightDefaultValue.GetValueOrDefault() ? height.HasValue != heightDefaultValue.HasValue : true))
			{
				hashtables.Add("y", this.Y);
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