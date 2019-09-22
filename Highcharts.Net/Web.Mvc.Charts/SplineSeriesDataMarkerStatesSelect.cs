using System.Collections;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class SplineSeriesDataMarkerStatesSelect : BaseObject
	{
		public bool? Enabled { get; set; }

		private bool? Enabled_DefaultValue { get; }

		public object FillColor { get; set; }

		private object FillColor_DefaultValue { get; }

		public string LineColor { get; set; }

		private string LineColor_DefaultValue { get; }

		public double? LineWidth { get; set; }

		private double? LineWidth_DefaultValue { get; }

		public double? Radius { get; set; }

		private double? Radius_DefaultValue { get; }

		public SplineSeriesDataMarkerStatesSelect()
		{
			bool? nullable = true;
			Enabled_DefaultValue = nullable;
			Enabled = nullable;
			object obj = null;
			object obj1 = obj;
			FillColor_DefaultValue = obj;
			FillColor = obj1;
			string str = "#000000";
			string str1 = str;
			LineColor_DefaultValue = str;
			LineColor = str1;
			double? nullable1 = 0;
			LineWidth_DefaultValue = nullable1;
			LineWidth = nullable1;
			nullable1 = null;
			Radius_DefaultValue = nullable1;
			Radius = nullable1;
		}

		internal override bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			bool? enabled = Enabled;
			bool? enabledDefaultValue = Enabled_DefaultValue;
			if ((enabled.GetValueOrDefault() == enabledDefaultValue.GetValueOrDefault()
				? enabled.HasValue != enabledDefaultValue.HasValue
				: true))
			{
				hashtables.Add("enabled", Enabled);
			}
			if (FillColor != FillColor_DefaultValue)
			{
				hashtables.Add("fillColor", FillColor);
			}
			if (LineColor != LineColor_DefaultValue)
			{
				hashtables.Add("lineColor", LineColor);
			}
			double? lineWidth = LineWidth;
			double? lineWidthDefaultValue = LineWidth_DefaultValue;
			if ((lineWidth.GetValueOrDefault() == lineWidthDefaultValue.GetValueOrDefault()
				? lineWidth.HasValue != lineWidthDefaultValue.HasValue
				: true))
			{
				hashtables.Add("lineWidth", LineWidth);
			}
			lineWidthDefaultValue = Radius;
			lineWidth = Radius_DefaultValue;
			if ((lineWidthDefaultValue.GetValueOrDefault() == lineWidth.GetValueOrDefault()
				? lineWidthDefaultValue.HasValue != lineWidth.HasValue
				: true))
			{
				hashtables.Add("radius", Radius);
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