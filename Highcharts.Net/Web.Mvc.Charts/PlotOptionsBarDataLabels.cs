using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsBarDataLabels : BaseObject
	{
		public string Align
		{
			get;
			set;
		}

		private string Align_DefaultValue
		{
			get;
			set;
		}

		public bool? AllowOverlap
		{
			get;
			set;
		}

		private bool? AllowOverlap_DefaultValue
		{
			get;
			set;
		}

		public string BackgroundColor
		{
			get;
			set;
		}

		private string BackgroundColor_DefaultValue
		{
			get;
			set;
		}

		public string BorderColor
		{
			get;
			set;
		}

		private string BorderColor_DefaultValue
		{
			get;
			set;
		}

		public double? BorderRadius
		{
			get;
			set;
		}

		private double? BorderRadius_DefaultValue
		{
			get;
			set;
		}

		public double? BorderWidth
		{
			get;
			set;
		}

		private double? BorderWidth_DefaultValue
		{
			get;
			set;
		}

		public string ClassName
		{
			get;
			set;
		}

		private string ClassName_DefaultValue
		{
			get;
			set;
		}

		public string Color
		{
			get;
			set;
		}

		private string Color_DefaultValue
		{
			get;
			set;
		}

		public bool? Crop
		{
			get;
			set;
		}

		private bool? Crop_DefaultValue
		{
			get;
			set;
		}

		public bool? Defer
		{
			get;
			set;
		}

		private bool? Defer_DefaultValue
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

		public string Format
		{
			get;
			set;
		}

		private string Format_DefaultValue
		{
			get;
			set;
		}

		public string Formatter
		{
			get;
			set;
		}

		private string Formatter_DefaultValue
		{
			get;
			set;
		}

		public bool? Inside
		{
			get;
			set;
		}

		private bool? Inside_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsBarDataLabelsOverflow Overflow
		{
			get;
			set;
		}

		private PlotOptionsBarDataLabelsOverflow Overflow_DefaultValue
		{
			get;
			set;
		}

		public double? Padding
		{
			get;
			set;
		}

		private double? Padding_DefaultValue
		{
			get;
			set;
		}

		public double? Rotation
		{
			get;
			set;
		}

		private double? Rotation_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.Shadow Shadow
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.Shadow Shadow_DefaultValue
		{
			get;
			set;
		}

		public string Shape
		{
			get;
			set;
		}

		private string Shape_DefaultValue
		{
			get;
			set;
		}

		public Hashtable Style
		{
			get;
			set;
		}

		private Hashtable Style_DefaultValue
		{
			get;
			set;
		}

		public bool? UseHTML
		{
			get;
			set;
		}

		private bool? UseHTML_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsBarDataLabelsVerticalAlign VerticalAlign
		{
			get;
			set;
		}

		private PlotOptionsBarDataLabelsVerticalAlign VerticalAlign_DefaultValue
		{
			get;
			set;
		}

		public double? X
		{
			get;
			set;
		}

		private double? X_DefaultValue
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

		public double? ZIndex
		{
			get;
			set;
		}

		private double? ZIndex_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsBarDataLabels()
		{
			string str = "left";
			string str1 = str;
			this.Align_DefaultValue = str;
			this.Align = str1;
			bool? nullable = new bool?(false);
			this.AllowOverlap_DefaultValue = nullable;
			this.AllowOverlap = nullable;
			object obj = null;
			str1 = (string)obj;
			this.BackgroundColor_DefaultValue = (string)obj;
			this.BackgroundColor = str1;
			object obj1 = null;
			str1 = (string)obj1;
			this.BorderColor_DefaultValue = (string)obj1;
			this.BorderColor = str1;
			double? nullable1 = new double?(0);
			this.BorderRadius_DefaultValue = nullable1;
			this.BorderRadius = nullable1;
			nullable1 = new double?(0);
			this.BorderWidth_DefaultValue = nullable1;
			this.BorderWidth = nullable1;
			object obj2 = null;
			str1 = (string)obj2;
			this.ClassName_DefaultValue = (string)obj2;
			this.ClassName = str1;
			object obj3 = null;
			str1 = (string)obj3;
			this.Color_DefaultValue = (string)obj3;
			this.Color = str1;
			nullable = new bool?(true);
			this.Crop_DefaultValue = nullable;
			this.Crop = nullable;
			nullable = new bool?(true);
			this.Defer_DefaultValue = nullable;
			this.Defer = nullable;
			nullable = new bool?(false);
			this.Enabled_DefaultValue = nullable;
			this.Enabled = nullable;
			string str2 = "{y}";
			str1 = str2;
			this.Format_DefaultValue = str2;
			this.Format = str1;
			string str3 = "";
			str1 = str3;
			this.Formatter_DefaultValue = str3;
			this.Formatter = str1;
			nullable = null;
			this.Inside_DefaultValue = nullable;
			this.Inside = nullable;
			int num = 0;
			PlotOptionsBarDataLabelsOverflow plotOptionsBarDataLabelsOverflow = (PlotOptionsBarDataLabelsOverflow)num;
			this.Overflow_DefaultValue = (PlotOptionsBarDataLabelsOverflow)num;
			this.Overflow = plotOptionsBarDataLabelsOverflow;
			nullable1 = new double?((double)5);
			this.Padding_DefaultValue = nullable1;
			this.Padding = nullable1;
			nullable1 = new double?(0);
			this.Rotation_DefaultValue = nullable1;
			this.Rotation = nullable1;
			Highsoft.Web.Mvc.Charts.Shadow shadow = new Highsoft.Web.Mvc.Charts.Shadow()
			{
				Enabled = false
			};
			Highsoft.Web.Mvc.Charts.Shadow shadow1 = shadow;
			this.Shadow_DefaultValue = shadow;
			this.Shadow = shadow1;
			string str4 = "square";
			str1 = str4;
			this.Shape_DefaultValue = str4;
			this.Shape = str1;
			Hashtable hashtables = new Hashtable()
			{
				{ "color", "contrast" },
				{ "fontSize", "11px" },
				{ "fontWeight", "bold" },
				{ "textOutline", "1px 1px contrast" }
			};
			Hashtable hashtables1 = hashtables;
			Hashtable hashtables2 = hashtables1;
			this.Style_DefaultValue = hashtables1;
			this.Style = hashtables2;
			nullable = new bool?(false);
			this.UseHTML_DefaultValue = nullable;
			this.UseHTML = nullable;
			int num1 = 0;
			PlotOptionsBarDataLabelsVerticalAlign plotOptionsBarDataLabelsVerticalAlign = (PlotOptionsBarDataLabelsVerticalAlign)num1;
			this.VerticalAlign_DefaultValue = (PlotOptionsBarDataLabelsVerticalAlign)num1;
			this.VerticalAlign = plotOptionsBarDataLabelsVerticalAlign;
			nullable1 = new double?((double)5);
			this.X_DefaultValue = nullable1;
			this.X = nullable1;
			nullable1 = new double?((double)-6);
			this.Y_DefaultValue = nullable1;
			this.Y = nullable1;
			nullable1 = new double?((double)6);
			this.ZIndex_DefaultValue = nullable1;
			this.ZIndex = nullable1;
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
				hashtables.Add("align", this.Align);
			}
			bool? allowOverlap = this.AllowOverlap;
			bool? allowOverlapDefaultValue = this.AllowOverlap_DefaultValue;
			if ((allowOverlap.GetValueOrDefault() == allowOverlapDefaultValue.GetValueOrDefault() ? allowOverlap.HasValue != allowOverlapDefaultValue.HasValue : true))
			{
				hashtables.Add("allowOverlap", this.AllowOverlap);
			}
			if (this.BackgroundColor != this.BackgroundColor_DefaultValue)
			{
				hashtables.Add("backgroundColor", this.BackgroundColor);
			}
			if (this.BorderColor != this.BorderColor_DefaultValue)
			{
				hashtables.Add("borderColor", this.BorderColor);
			}
			double? borderRadius = this.BorderRadius;
			double? borderRadiusDefaultValue = this.BorderRadius_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault() ? borderRadius.HasValue != borderRadiusDefaultValue.HasValue : true))
			{
				hashtables.Add("borderRadius", this.BorderRadius);
			}
			borderRadiusDefaultValue = this.BorderWidth;
			borderRadius = this.BorderWidth_DefaultValue;
			if ((borderRadiusDefaultValue.GetValueOrDefault() == borderRadius.GetValueOrDefault() ? borderRadiusDefaultValue.HasValue != borderRadius.HasValue : true))
			{
				hashtables.Add("borderWidth", this.BorderWidth);
			}
			if (this.ClassName != this.ClassName_DefaultValue)
			{
				hashtables.Add("className", this.ClassName);
			}
			if (this.Color != this.Color_DefaultValue)
			{
				hashtables.Add("color", this.Color);
			}
			allowOverlapDefaultValue = this.Crop;
			allowOverlap = this.Crop_DefaultValue;
			if ((allowOverlapDefaultValue.GetValueOrDefault() == allowOverlap.GetValueOrDefault() ? allowOverlapDefaultValue.HasValue != allowOverlap.HasValue : true))
			{
				hashtables.Add("crop", this.Crop);
			}
			allowOverlap = this.Defer;
			allowOverlapDefaultValue = this.Defer_DefaultValue;
			if ((allowOverlap.GetValueOrDefault() == allowOverlapDefaultValue.GetValueOrDefault() ? allowOverlap.HasValue != allowOverlapDefaultValue.HasValue : true))
			{
				hashtables.Add("defer", this.Defer);
			}
			allowOverlapDefaultValue = this.Enabled;
			allowOverlap = this.Enabled_DefaultValue;
			if ((allowOverlapDefaultValue.GetValueOrDefault() == allowOverlap.GetValueOrDefault() ? allowOverlapDefaultValue.HasValue != allowOverlap.HasValue : true))
			{
				hashtables.Add("enabled", this.Enabled);
			}
			if (this.Format != this.Format_DefaultValue)
			{
				hashtables.Add("format", this.Format);
			}
			if (this.Formatter != this.Formatter_DefaultValue)
			{
				hashtables.Add("formatter", this.Formatter);
				Highcharts.AddFunction("PlotOptionsBarDataLabelsFormatter.formatter", this.Formatter);
			}
			allowOverlap = this.Inside;
			allowOverlapDefaultValue = this.Inside_DefaultValue;
			if ((allowOverlap.GetValueOrDefault() == allowOverlapDefaultValue.GetValueOrDefault() ? allowOverlap.HasValue != allowOverlapDefaultValue.HasValue : true))
			{
				hashtables.Add("inside", this.Inside);
			}
			if (this.Overflow != this.Overflow_DefaultValue)
			{
				PlotOptionsBarDataLabelsOverflow overflow = this.Overflow;
				hashtables.Add("overflow", Highcharts.FirstCharacterToLower(overflow.ToString()));
			}
			borderRadius = this.Padding;
			borderRadiusDefaultValue = this.Padding_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault() ? borderRadius.HasValue != borderRadiusDefaultValue.HasValue : true))
			{
				hashtables.Add("padding", this.Padding);
			}
			borderRadiusDefaultValue = this.Rotation;
			borderRadius = this.Rotation_DefaultValue;
			if ((borderRadiusDefaultValue.GetValueOrDefault() == borderRadius.GetValueOrDefault() ? borderRadiusDefaultValue.HasValue != borderRadius.HasValue : true))
			{
				hashtables.Add("rotation", this.Rotation);
			}
			if (this.Shadow != this.Shadow_DefaultValue)
			{
				hashtables.Add("shadow", this.Shadow);
			}
			if (this.Shape != this.Shape_DefaultValue)
			{
				hashtables.Add("shape", this.Shape);
			}
			if (this.Style != this.Style_DefaultValue)
			{
				hashtables.Add("style", this.Style);
			}
			allowOverlapDefaultValue = this.UseHTML;
			allowOverlap = this.UseHTML_DefaultValue;
			if ((allowOverlapDefaultValue.GetValueOrDefault() == allowOverlap.GetValueOrDefault() ? allowOverlapDefaultValue.HasValue != allowOverlap.HasValue : true))
			{
				hashtables.Add("useHTML", this.UseHTML);
			}
			if (this.VerticalAlign != this.VerticalAlign_DefaultValue)
			{
				PlotOptionsBarDataLabelsVerticalAlign verticalAlign = this.VerticalAlign;
				hashtables.Add("verticalAlign", Highcharts.FirstCharacterToLower(verticalAlign.ToString()));
			}
			borderRadius = this.X;
			borderRadiusDefaultValue = this.X_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault() ? borderRadius.HasValue != borderRadiusDefaultValue.HasValue : true))
			{
				hashtables.Add("x", this.X);
			}
			borderRadiusDefaultValue = this.Y;
			borderRadius = this.Y_DefaultValue;
			if ((borderRadiusDefaultValue.GetValueOrDefault() == borderRadius.GetValueOrDefault() ? borderRadiusDefaultValue.HasValue != borderRadius.HasValue : true))
			{
				hashtables.Add("y", this.Y);
			}
			borderRadius = this.ZIndex;
			borderRadiusDefaultValue = this.ZIndex_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault() ? borderRadius.HasValue != borderRadiusDefaultValue.HasValue : true))
			{
				hashtables.Add("zIndex", this.ZIndex);
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