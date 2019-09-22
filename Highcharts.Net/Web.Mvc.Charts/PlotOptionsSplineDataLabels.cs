using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsSplineDataLabels : BaseObject
	{
		public PlotOptionsSplineDataLabelsAlign Align
		{
			get;
			set;
		}

		private PlotOptionsSplineDataLabelsAlign Align_DefaultValue
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

		public PlotOptionsSplineDataLabelsOverflow Overflow
		{
			get;
			set;
		}

		private PlotOptionsSplineDataLabelsOverflow Overflow_DefaultValue
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

		public PlotOptionsSplineDataLabelsVerticalAlign VerticalAlign
		{
			get;
			set;
		}

		private PlotOptionsSplineDataLabelsVerticalAlign VerticalAlign_DefaultValue
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

		public PlotOptionsSplineDataLabels()
		{
			int num = 1;
			PlotOptionsSplineDataLabelsAlign plotOptionsSplineDataLabelsAlign = (PlotOptionsSplineDataLabelsAlign)num;
			this.Align_DefaultValue = (PlotOptionsSplineDataLabelsAlign)num;
			this.Align = plotOptionsSplineDataLabelsAlign;
			bool? nullable = new bool?(false);
			this.AllowOverlap_DefaultValue = nullable;
			this.AllowOverlap = nullable;
			object obj = null;
			string str = (string)obj;
			this.BackgroundColor_DefaultValue = (string)obj;
			this.BackgroundColor = str;
			object obj1 = null;
			str = (string)obj1;
			this.BorderColor_DefaultValue = (string)obj1;
			this.BorderColor = str;
			double? nullable1 = new double?(0);
			this.BorderRadius_DefaultValue = nullable1;
			this.BorderRadius = nullable1;
			nullable1 = new double?(0);
			this.BorderWidth_DefaultValue = nullable1;
			this.BorderWidth = nullable1;
			object obj2 = null;
			str = (string)obj2;
			this.ClassName_DefaultValue = (string)obj2;
			this.ClassName = str;
			object obj3 = null;
			str = (string)obj3;
			this.Color_DefaultValue = (string)obj3;
			this.Color = str;
			nullable = new bool?(true);
			this.Crop_DefaultValue = nullable;
			this.Crop = nullable;
			nullable = new bool?(true);
			this.Defer_DefaultValue = nullable;
			this.Defer = nullable;
			nullable = new bool?(false);
			this.Enabled_DefaultValue = nullable;
			this.Enabled = nullable;
			string str1 = "{y}";
			str = str1;
			this.Format_DefaultValue = str1;
			this.Format = str;
			string str2 = "";
			str = str2;
			this.Formatter_DefaultValue = str2;
			this.Formatter = str;
			nullable = null;
			this.Inside_DefaultValue = nullable;
			this.Inside = nullable;
			int num1 = 0;
			PlotOptionsSplineDataLabelsOverflow plotOptionsSplineDataLabelsOverflow = (PlotOptionsSplineDataLabelsOverflow)num1;
			this.Overflow_DefaultValue = (PlotOptionsSplineDataLabelsOverflow)num1;
			this.Overflow = plotOptionsSplineDataLabelsOverflow;
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
			string str3 = "square";
			str = str3;
			this.Shape_DefaultValue = str3;
			this.Shape = str;
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
			int num2 = 0;
			PlotOptionsSplineDataLabelsVerticalAlign plotOptionsSplineDataLabelsVerticalAlign = (PlotOptionsSplineDataLabelsVerticalAlign)num2;
			this.VerticalAlign_DefaultValue = (PlotOptionsSplineDataLabelsVerticalAlign)num2;
			this.VerticalAlign = plotOptionsSplineDataLabelsVerticalAlign;
			nullable1 = new double?(0);
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
				PlotOptionsSplineDataLabelsAlign align = this.Align;
				hashtables.Add("align", Highcharts.FirstCharacterToLower(align.ToString()));
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
				Highcharts.AddFunction("PlotOptionsSplineDataLabelsFormatter.formatter", this.Formatter);
			}
			allowOverlap = this.Inside;
			allowOverlapDefaultValue = this.Inside_DefaultValue;
			if ((allowOverlap.GetValueOrDefault() == allowOverlapDefaultValue.GetValueOrDefault() ? allowOverlap.HasValue != allowOverlapDefaultValue.HasValue : true))
			{
				hashtables.Add("inside", this.Inside);
			}
			if (this.Overflow != this.Overflow_DefaultValue)
			{
				PlotOptionsSplineDataLabelsOverflow overflow = this.Overflow;
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
				PlotOptionsSplineDataLabelsVerticalAlign verticalAlign = this.VerticalAlign;
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