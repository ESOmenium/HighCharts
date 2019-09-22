using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PyramidSeriesDataLabels : BaseObject
	{
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

		public string ConnectorColor
		{
			get;
			set;
		}

		private string ConnectorColor_DefaultValue
		{
			get;
			set;
		}

		public double? ConnectorPadding
		{
			get;
			set;
		}

		private double? ConnectorPadding_DefaultValue
		{
			get;
			set;
		}

		public double? ConnectorWidth
		{
			get;
			set;
		}

		private double? ConnectorWidth_DefaultValue
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

		public double? Distance
		{
			get;
			set;
		}

		private double? Distance_DefaultValue
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

		public PyramidSeriesDataLabelsOverflow Overflow
		{
			get;
			set;
		}

		private PyramidSeriesDataLabelsOverflow Overflow_DefaultValue
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

		public bool? SoftConnector
		{
			get;
			set;
		}

		private bool? SoftConnector_DefaultValue
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

		public PyramidSeriesDataLabelsVerticalAlign VerticalAlign
		{
			get;
			set;
		}

		private PyramidSeriesDataLabelsVerticalAlign VerticalAlign_DefaultValue
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

		public PyramidSeriesDataLabels()
		{
			object obj = null;
			string str = (string)obj;
			this.BackgroundColor_DefaultValue = (string)obj;
			this.BackgroundColor = str;
			object obj1 = null;
			str = (string)obj1;
			this.BorderColor_DefaultValue = (string)obj1;
			this.BorderColor = str;
			double? nullable = new double?(0);
			this.BorderRadius_DefaultValue = nullable;
			this.BorderRadius = nullable;
			nullable = new double?(0);
			this.BorderWidth_DefaultValue = nullable;
			this.BorderWidth = nullable;
			object obj2 = null;
			str = (string)obj2;
			this.ClassName_DefaultValue = (string)obj2;
			this.ClassName = str;
			object obj3 = null;
			str = (string)obj3;
			this.Color_DefaultValue = (string)obj3;
			this.Color = str;
			string str1 = "{point.color}";
			str = str1;
			this.ConnectorColor_DefaultValue = str1;
			this.ConnectorColor = str;
			nullable = new double?((double)5);
			this.ConnectorPadding_DefaultValue = nullable;
			this.ConnectorPadding = nullable;
			nullable = new double?((double)1);
			this.ConnectorWidth_DefaultValue = nullable;
			this.ConnectorWidth = nullable;
			bool? nullable1 = new bool?(true);
			this.Crop_DefaultValue = nullable1;
			this.Crop = nullable1;
			nullable1 = new bool?(true);
			this.Defer_DefaultValue = nullable1;
			this.Defer = nullable1;
			nullable = new double?((double)30);
			this.Distance_DefaultValue = nullable;
			this.Distance = nullable;
			nullable1 = new bool?(true);
			this.Enabled_DefaultValue = nullable1;
			this.Enabled = nullable1;
			string str2 = "{y}";
			str = str2;
			this.Format_DefaultValue = str2;
			this.Format = str;
			string str3 = "";
			str = str3;
			this.Formatter_DefaultValue = str3;
			this.Formatter = str;
			nullable1 = null;
			this.Inside_DefaultValue = nullable1;
			this.Inside = nullable1;
			int num = 0;
			PyramidSeriesDataLabelsOverflow pyramidSeriesDataLabelsOverflow = (PyramidSeriesDataLabelsOverflow)num;
			this.Overflow_DefaultValue = (PyramidSeriesDataLabelsOverflow)num;
			this.Overflow = pyramidSeriesDataLabelsOverflow;
			nullable = new double?((double)5);
			this.Padding_DefaultValue = nullable;
			this.Padding = nullable;
			nullable = new double?(0);
			this.Rotation_DefaultValue = nullable;
			this.Rotation = nullable;
			Highsoft.Web.Mvc.Charts.Shadow shadow = new Highsoft.Web.Mvc.Charts.Shadow()
			{
				Enabled = false
			};
			Highsoft.Web.Mvc.Charts.Shadow shadow1 = shadow;
			this.Shadow_DefaultValue = shadow;
			this.Shadow = shadow1;
			string str4 = "square";
			str = str4;
			this.Shape_DefaultValue = str4;
			this.Shape = str;
			nullable1 = new bool?(true);
			this.SoftConnector_DefaultValue = nullable1;
			this.SoftConnector = nullable1;
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
			nullable1 = new bool?(false);
			this.UseHTML_DefaultValue = nullable1;
			this.UseHTML = nullable1;
			int num1 = 0;
			PyramidSeriesDataLabelsVerticalAlign pyramidSeriesDataLabelsVerticalAlign = (PyramidSeriesDataLabelsVerticalAlign)num1;
			this.VerticalAlign_DefaultValue = (PyramidSeriesDataLabelsVerticalAlign)num1;
			this.VerticalAlign = pyramidSeriesDataLabelsVerticalAlign;
			nullable = new double?(0);
			this.X_DefaultValue = nullable;
			this.X = nullable;
			nullable = new double?((double)-6);
			this.Y_DefaultValue = nullable;
			this.Y = nullable;
			nullable = new double?((double)6);
			this.ZIndex_DefaultValue = nullable;
			this.ZIndex = nullable;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
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
			if (this.ConnectorColor != this.ConnectorColor_DefaultValue)
			{
				hashtables.Add("connectorColor", this.ConnectorColor);
			}
			borderRadius = this.ConnectorPadding;
			borderRadiusDefaultValue = this.ConnectorPadding_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault() ? borderRadius.HasValue != borderRadiusDefaultValue.HasValue : true))
			{
				hashtables.Add("connectorPadding", this.ConnectorPadding);
			}
			borderRadiusDefaultValue = this.ConnectorWidth;
			borderRadius = this.ConnectorWidth_DefaultValue;
			if ((borderRadiusDefaultValue.GetValueOrDefault() == borderRadius.GetValueOrDefault() ? borderRadiusDefaultValue.HasValue != borderRadius.HasValue : true))
			{
				hashtables.Add("connectorWidth", this.ConnectorWidth);
			}
			bool? crop = this.Crop;
			bool? cropDefaultValue = this.Crop_DefaultValue;
			if ((crop.GetValueOrDefault() == cropDefaultValue.GetValueOrDefault() ? crop.HasValue != cropDefaultValue.HasValue : true))
			{
				hashtables.Add("crop", this.Crop);
			}
			cropDefaultValue = this.Defer;
			crop = this.Defer_DefaultValue;
			if ((cropDefaultValue.GetValueOrDefault() == crop.GetValueOrDefault() ? cropDefaultValue.HasValue != crop.HasValue : true))
			{
				hashtables.Add("defer", this.Defer);
			}
			borderRadius = this.Distance;
			borderRadiusDefaultValue = this.Distance_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault() ? borderRadius.HasValue != borderRadiusDefaultValue.HasValue : true))
			{
				hashtables.Add("distance", this.Distance);
			}
			crop = this.Enabled;
			cropDefaultValue = this.Enabled_DefaultValue;
			if ((crop.GetValueOrDefault() == cropDefaultValue.GetValueOrDefault() ? crop.HasValue != cropDefaultValue.HasValue : true))
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
				Highcharts.AddFunction("PyramidSeriesDataLabelsFormatter.formatter", this.Formatter);
			}
			cropDefaultValue = this.Inside;
			crop = this.Inside_DefaultValue;
			if ((cropDefaultValue.GetValueOrDefault() == crop.GetValueOrDefault() ? cropDefaultValue.HasValue != crop.HasValue : true))
			{
				hashtables.Add("inside", this.Inside);
			}
			if (this.Overflow != this.Overflow_DefaultValue)
			{
				PyramidSeriesDataLabelsOverflow overflow = this.Overflow;
				hashtables.Add("overflow", Highcharts.FirstCharacterToLower(overflow.ToString()));
			}
			borderRadiusDefaultValue = this.Padding;
			borderRadius = this.Padding_DefaultValue;
			if ((borderRadiusDefaultValue.GetValueOrDefault() == borderRadius.GetValueOrDefault() ? borderRadiusDefaultValue.HasValue != borderRadius.HasValue : true))
			{
				hashtables.Add("padding", this.Padding);
			}
			borderRadius = this.Rotation;
			borderRadiusDefaultValue = this.Rotation_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault() ? borderRadius.HasValue != borderRadiusDefaultValue.HasValue : true))
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
			crop = this.SoftConnector;
			cropDefaultValue = this.SoftConnector_DefaultValue;
			if ((crop.GetValueOrDefault() == cropDefaultValue.GetValueOrDefault() ? crop.HasValue != cropDefaultValue.HasValue : true))
			{
				hashtables.Add("softConnector", this.SoftConnector);
			}
			if (this.Style != this.Style_DefaultValue)
			{
				hashtables.Add("style", this.Style);
			}
			cropDefaultValue = this.UseHTML;
			crop = this.UseHTML_DefaultValue;
			if ((cropDefaultValue.GetValueOrDefault() == crop.GetValueOrDefault() ? cropDefaultValue.HasValue != crop.HasValue : true))
			{
				hashtables.Add("useHTML", this.UseHTML);
			}
			if (this.VerticalAlign != this.VerticalAlign_DefaultValue)
			{
				PyramidSeriesDataLabelsVerticalAlign verticalAlign = this.VerticalAlign;
				hashtables.Add("verticalAlign", Highcharts.FirstCharacterToLower(verticalAlign.ToString()));
			}
			borderRadiusDefaultValue = this.X;
			borderRadius = this.X_DefaultValue;
			if ((borderRadiusDefaultValue.GetValueOrDefault() == borderRadius.GetValueOrDefault() ? borderRadiusDefaultValue.HasValue != borderRadius.HasValue : true))
			{
				hashtables.Add("x", this.X);
			}
			borderRadius = this.Y;
			borderRadiusDefaultValue = this.Y_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault() ? borderRadius.HasValue != borderRadiusDefaultValue.HasValue : true))
			{
				hashtables.Add("y", this.Y);
			}
			borderRadiusDefaultValue = this.ZIndex;
			borderRadius = this.ZIndex_DefaultValue;
			if ((borderRadiusDefaultValue.GetValueOrDefault() == borderRadius.GetValueOrDefault() ? borderRadiusDefaultValue.HasValue != borderRadius.HasValue : true))
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