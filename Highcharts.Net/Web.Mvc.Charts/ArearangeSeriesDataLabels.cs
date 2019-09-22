using System.Collections;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class ArearangeSeriesDataLabels : BaseObject
	{
		public ArearangeSeriesDataLabelsAlign Align { get; set; }

		private ArearangeSeriesDataLabelsAlign Align_DefaultValue { get; }

		public bool? AllowOverlap { get; set; }

		private bool? AllowOverlap_DefaultValue { get; }

		public string BackgroundColor { get; set; }

		private string BackgroundColor_DefaultValue { get; }

		public string BorderColor { get; set; }

		private string BorderColor_DefaultValue { get; }

		public double? BorderRadius { get; set; }

		private double? BorderRadius_DefaultValue { get; }

		public double? BorderWidth { get; set; }

		private double? BorderWidth_DefaultValue { get; }

		public string ClassName { get; set; }

		private string ClassName_DefaultValue { get; }

		public string Color { get; set; }

		private string Color_DefaultValue { get; }

		public bool? Crop { get; set; }

		private bool? Crop_DefaultValue { get; }

		public bool? Defer { get; set; }

		private bool? Defer_DefaultValue { get; }

		public bool? Enabled { get; set; }

		private bool? Enabled_DefaultValue { get; }

		public string Format { get; set; }

		private string Format_DefaultValue { get; }

		public string Formatter { get; set; }

		private string Formatter_DefaultValue { get; }

		public bool? Inside { get; set; }

		private bool? Inside_DefaultValue { get; }

		public ArearangeSeriesDataLabelsOverflow Overflow { get; set; }

		private ArearangeSeriesDataLabelsOverflow Overflow_DefaultValue { get; }

		public double? Padding { get; set; }

		private double? Padding_DefaultValue { get; }

		public double? Rotation { get; set; }

		private double? Rotation_DefaultValue { get; }

		public Shadow Shadow { get; set; }

		private Shadow Shadow_DefaultValue { get; }

		public string Shape { get; set; }

		private string Shape_DefaultValue { get; }

		public Hashtable Style { get; set; }

		private Hashtable Style_DefaultValue { get; }

		public bool? UseHTML { get; set; }

		private bool? UseHTML_DefaultValue { get; }

		public ArearangeSeriesDataLabelsVerticalAlign VerticalAlign { get; set; }

		private ArearangeSeriesDataLabelsVerticalAlign VerticalAlign_DefaultValue { get; }

		public double? XHigh { get; set; }

		private double? XHigh_DefaultValue { get; }

		public double? XLow { get; set; }

		private double? XLow_DefaultValue { get; }

		public double? YHigh { get; set; }

		private double? YHigh_DefaultValue { get; }

		public double? YLow { get; set; }

		private double? YLow_DefaultValue { get; }

		public double? ZIndex { get; set; }

		private double? ZIndex_DefaultValue { get; }

		public ArearangeSeriesDataLabels()
		{
			int num = 1;
			ArearangeSeriesDataLabelsAlign arearangeSeriesDataLabelsAlign = (ArearangeSeriesDataLabelsAlign) num;
			Align_DefaultValue = (ArearangeSeriesDataLabelsAlign) num;
			Align = arearangeSeriesDataLabelsAlign;
			bool? nullable = false;
			AllowOverlap_DefaultValue = nullable;
			AllowOverlap = nullable;
			object obj = null;
			string str = (string) obj;
			BackgroundColor_DefaultValue = (string) obj;
			BackgroundColor = str;
			object obj1 = null;
			str = (string) obj1;
			BorderColor_DefaultValue = (string) obj1;
			BorderColor = str;
			double? nullable1 = 0;
			BorderRadius_DefaultValue = nullable1;
			BorderRadius = nullable1;
			nullable1 = 0;
			BorderWidth_DefaultValue = nullable1;
			BorderWidth = nullable1;
			object obj2 = null;
			str = (string) obj2;
			ClassName_DefaultValue = (string) obj2;
			ClassName = str;
			object obj3 = null;
			str = (string) obj3;
			Color_DefaultValue = (string) obj3;
			Color = str;
			nullable = true;
			Crop_DefaultValue = nullable;
			Crop = nullable;
			nullable = true;
			Defer_DefaultValue = nullable;
			Defer = nullable;
			nullable = false;
			Enabled_DefaultValue = nullable;
			Enabled = nullable;
			string str1 = "{y}";
			str = str1;
			Format_DefaultValue = str1;
			Format = str;
			string str2 = "";
			str = str2;
			Formatter_DefaultValue = str2;
			Formatter = str;
			nullable = null;
			Inside_DefaultValue = nullable;
			Inside = nullable;
			int num1 = 0;
			ArearangeSeriesDataLabelsOverflow arearangeSeriesDataLabelsOverflow = (ArearangeSeriesDataLabelsOverflow) num1;
			Overflow_DefaultValue = (ArearangeSeriesDataLabelsOverflow) num1;
			Overflow = arearangeSeriesDataLabelsOverflow;
			nullable1 = 5;
			Padding_DefaultValue = nullable1;
			Padding = nullable1;
			nullable1 = 0;
			Rotation_DefaultValue = nullable1;
			Rotation = nullable1;
			Shadow shadow = new Shadow
			{
				Enabled = false
			};
			Shadow shadow1 = shadow;
			Shadow_DefaultValue = shadow;
			Shadow = shadow1;
			string str3 = "square";
			str = str3;
			Shape_DefaultValue = str3;
			Shape = str;
			Hashtable hashtables = new Hashtable
			{
				{"color", "contrast"},
				{"fontSize", "11px"},
				{"fontWeight", "bold"},
				{"textOutline", "1px 1px contrast"}
			};
			Hashtable hashtables1 = hashtables;
			Hashtable hashtables2 = hashtables1;
			Style_DefaultValue = hashtables1;
			Style = hashtables2;
			nullable = false;
			UseHTML_DefaultValue = nullable;
			UseHTML = nullable;
			int num2 = 0;
			ArearangeSeriesDataLabelsVerticalAlign arearangeSeriesDataLabelsVerticalAlign =
				(ArearangeSeriesDataLabelsVerticalAlign) num2;
			VerticalAlign_DefaultValue = (ArearangeSeriesDataLabelsVerticalAlign) num2;
			VerticalAlign = arearangeSeriesDataLabelsVerticalAlign;
			nullable1 = 0;
			XHigh_DefaultValue = nullable1;
			XHigh = nullable1;
			nullable1 = 0;
			XLow_DefaultValue = nullable1;
			XLow = nullable1;
			nullable1 = -6;
			YHigh_DefaultValue = nullable1;
			YHigh = nullable1;
			nullable1 = 16;
			YLow_DefaultValue = nullable1;
			YLow = nullable1;
			nullable1 = 6;
			ZIndex_DefaultValue = nullable1;
			ZIndex = nullable1;
		}

		internal override bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (Align != Align_DefaultValue)
			{
				ArearangeSeriesDataLabelsAlign align = Align;
				hashtables.Add("align", Highcharts.FirstCharacterToLower(align.ToString()));
			}
			bool? allowOverlap = AllowOverlap;
			bool? allowOverlapDefaultValue = AllowOverlap_DefaultValue;
			if ((allowOverlap.GetValueOrDefault() == allowOverlapDefaultValue.GetValueOrDefault()
				? allowOverlap.HasValue != allowOverlapDefaultValue.HasValue
				: true))
			{
				hashtables.Add("allowOverlap", AllowOverlap);
			}
			if (BackgroundColor != BackgroundColor_DefaultValue)
			{
				hashtables.Add("backgroundColor", BackgroundColor);
			}
			if (BorderColor != BorderColor_DefaultValue)
			{
				hashtables.Add("borderColor", BorderColor);
			}
			double? borderRadius = BorderRadius;
			double? borderRadiusDefaultValue = BorderRadius_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault()
				? borderRadius.HasValue != borderRadiusDefaultValue.HasValue
				: true))
			{
				hashtables.Add("borderRadius", BorderRadius);
			}
			borderRadiusDefaultValue = BorderWidth;
			borderRadius = BorderWidth_DefaultValue;
			if ((borderRadiusDefaultValue.GetValueOrDefault() == borderRadius.GetValueOrDefault()
				? borderRadiusDefaultValue.HasValue != borderRadius.HasValue
				: true))
			{
				hashtables.Add("borderWidth", BorderWidth);
			}
			if (ClassName != ClassName_DefaultValue)
			{
				hashtables.Add("className", ClassName);
			}
			if (Color != Color_DefaultValue)
			{
				hashtables.Add("color", Color);
			}
			allowOverlapDefaultValue = Crop;
			allowOverlap = Crop_DefaultValue;
			if ((allowOverlapDefaultValue.GetValueOrDefault() == allowOverlap.GetValueOrDefault()
				? allowOverlapDefaultValue.HasValue != allowOverlap.HasValue
				: true))
			{
				hashtables.Add("crop", Crop);
			}
			allowOverlap = Defer;
			allowOverlapDefaultValue = Defer_DefaultValue;
			if ((allowOverlap.GetValueOrDefault() == allowOverlapDefaultValue.GetValueOrDefault()
				? allowOverlap.HasValue != allowOverlapDefaultValue.HasValue
				: true))
			{
				hashtables.Add("defer", Defer);
			}
			allowOverlapDefaultValue = Enabled;
			allowOverlap = Enabled_DefaultValue;
			if ((allowOverlapDefaultValue.GetValueOrDefault() == allowOverlap.GetValueOrDefault()
				? allowOverlapDefaultValue.HasValue != allowOverlap.HasValue
				: true))
			{
				hashtables.Add("enabled", Enabled);
			}
			if (Format != Format_DefaultValue)
			{
				hashtables.Add("format", Format);
			}
			if (Formatter != Formatter_DefaultValue)
			{
				hashtables.Add("formatter", Formatter);
				Highcharts.AddFunction("ArearangeSeriesDataLabelsFormatter.formatter", Formatter);
			}
			allowOverlap = Inside;
			allowOverlapDefaultValue = Inside_DefaultValue;
			if ((allowOverlap.GetValueOrDefault() == allowOverlapDefaultValue.GetValueOrDefault()
				? allowOverlap.HasValue != allowOverlapDefaultValue.HasValue
				: true))
			{
				hashtables.Add("inside", Inside);
			}
			if (Overflow != Overflow_DefaultValue)
			{
				ArearangeSeriesDataLabelsOverflow overflow = Overflow;
				hashtables.Add("overflow", Highcharts.FirstCharacterToLower(overflow.ToString()));
			}
			borderRadius = Padding;
			borderRadiusDefaultValue = Padding_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault()
				? borderRadius.HasValue != borderRadiusDefaultValue.HasValue
				: true))
			{
				hashtables.Add("padding", Padding);
			}
			borderRadiusDefaultValue = Rotation;
			borderRadius = Rotation_DefaultValue;
			if ((borderRadiusDefaultValue.GetValueOrDefault() == borderRadius.GetValueOrDefault()
				? borderRadiusDefaultValue.HasValue != borderRadius.HasValue
				: true))
			{
				hashtables.Add("rotation", Rotation);
			}
			if (Shadow != Shadow_DefaultValue)
			{
				hashtables.Add("shadow", Shadow);
			}
			if (Shape != Shape_DefaultValue)
			{
				hashtables.Add("shape", Shape);
			}
			if (Style != Style_DefaultValue)
			{
				hashtables.Add("style", Style);
			}
			allowOverlapDefaultValue = UseHTML;
			allowOverlap = UseHTML_DefaultValue;
			if ((allowOverlapDefaultValue.GetValueOrDefault() == allowOverlap.GetValueOrDefault()
				? allowOverlapDefaultValue.HasValue != allowOverlap.HasValue
				: true))
			{
				hashtables.Add("useHTML", UseHTML);
			}
			if (VerticalAlign != VerticalAlign_DefaultValue)
			{
				ArearangeSeriesDataLabelsVerticalAlign verticalAlign = VerticalAlign;
				hashtables.Add("verticalAlign", Highcharts.FirstCharacterToLower(verticalAlign.ToString()));
			}
			borderRadius = XHigh;
			borderRadiusDefaultValue = XHigh_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault()
				? borderRadius.HasValue != borderRadiusDefaultValue.HasValue
				: true))
			{
				hashtables.Add("xHigh", XHigh);
			}
			borderRadiusDefaultValue = XLow;
			borderRadius = XLow_DefaultValue;
			if ((borderRadiusDefaultValue.GetValueOrDefault() == borderRadius.GetValueOrDefault()
				? borderRadiusDefaultValue.HasValue != borderRadius.HasValue
				: true))
			{
				hashtables.Add("xLow", XLow);
			}
			borderRadius = YHigh;
			borderRadiusDefaultValue = YHigh_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault()
				? borderRadius.HasValue != borderRadiusDefaultValue.HasValue
				: true))
			{
				hashtables.Add("yHigh", YHigh);
			}
			borderRadiusDefaultValue = YLow;
			borderRadius = YLow_DefaultValue;
			if ((borderRadiusDefaultValue.GetValueOrDefault() == borderRadius.GetValueOrDefault()
				? borderRadiusDefaultValue.HasValue != borderRadius.HasValue
				: true))
			{
				hashtables.Add("yLow", YLow);
			}
			borderRadius = ZIndex;
			borderRadiusDefaultValue = ZIndex_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault()
				? borderRadius.HasValue != borderRadiusDefaultValue.HasValue
				: true))
			{
				hashtables.Add("zIndex", ZIndex);
			}
			return hashtables;
		}

		internal override string ToJSON()
		{
			string str;
			Hashtable hashtable = ToHashtable();
			JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer
			{
				MaxJsonLength = 2147483647
			};
			str = (hashtable.Count <= 0 ? "" : javaScriptSerializer.Serialize(ToHashtable()));
			return str;
		}
	}
}