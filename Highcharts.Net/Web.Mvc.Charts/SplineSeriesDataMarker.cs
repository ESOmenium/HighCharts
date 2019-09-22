using System.Collections;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class SplineSeriesDataMarker : BaseObject
	{
		public bool? Enabled { get; set; }

		private bool? Enabled_DefaultValue { get; }

		public object FillColor { get; set; }

		private object FillColor_DefaultValue { get; }

		public double? Height { get; set; }

		private double? Height_DefaultValue { get; }

		public string LineColor { get; set; }

		private string LineColor_DefaultValue { get; }

		public double? LineWidth { get; set; }

		private double? LineWidth_DefaultValue { get; }

		public double? Radius { get; set; }

		private double? Radius_DefaultValue { get; }

		public SplineSeriesDataMarkerStates States { get; set; }

		private SplineSeriesDataMarkerStates States_DefaultValue { get; set; }

		public string Symbol { get; set; }

		private string Symbol_DefaultValue { get; }

		public double? Width { get; set; }

		private double? Width_DefaultValue { get; }

		public SplineSeriesDataMarker()
		{
			bool? nullable = null;
			Enabled_DefaultValue = nullable;
			Enabled = nullable;
			object obj = null;
			object obj1 = obj;
			FillColor_DefaultValue = obj;
			FillColor = obj1;
			double? nullable1 = null;
			Height_DefaultValue = nullable1;
			Height = nullable1;
			string str = "#ffffff";
			string str1 = str;
			LineColor_DefaultValue = str;
			LineColor = str1;
			nullable1 = 0;
			LineWidth_DefaultValue = nullable1;
			LineWidth = nullable1;
			nullable1 = 4;
			Radius_DefaultValue = nullable1;
			Radius = nullable1;
			SplineSeriesDataMarkerStates splineSeriesDataMarkerState = new SplineSeriesDataMarkerStates();
			SplineSeriesDataMarkerStates splineSeriesDataMarkerState1 = splineSeriesDataMarkerState;
			States_DefaultValue = splineSeriesDataMarkerState;
			States = splineSeriesDataMarkerState1;
			object obj2 = null;
			str1 = (string) obj2;
			Symbol_DefaultValue = (string) obj2;
			Symbol = str1;
			nullable1 = null;
			Width_DefaultValue = nullable1;
			Width = nullable1;
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
			double? height = Height;
			double? heightDefaultValue = Height_DefaultValue;
			if ((height.GetValueOrDefault() == heightDefaultValue.GetValueOrDefault()
				? height.HasValue != heightDefaultValue.HasValue
				: true))
			{
				hashtables.Add("height", Height);
			}
			if (LineColor != LineColor_DefaultValue)
			{
				hashtables.Add("lineColor", LineColor);
			}
			heightDefaultValue = LineWidth;
			height = LineWidth_DefaultValue;
			if ((heightDefaultValue.GetValueOrDefault() == height.GetValueOrDefault()
				? heightDefaultValue.HasValue != height.HasValue
				: true))
			{
				hashtables.Add("lineWidth", LineWidth);
			}
			height = Radius;
			heightDefaultValue = Radius_DefaultValue;
			if ((height.GetValueOrDefault() == heightDefaultValue.GetValueOrDefault()
				? height.HasValue != heightDefaultValue.HasValue
				: true))
			{
				hashtables.Add("radius", Radius);
			}
			if (States.IsDirty())
			{
				hashtables.Add("states", States.ToHashtable());
			}
			if (Symbol != Symbol_DefaultValue)
			{
				hashtables.Add("symbol", Symbol);
			}
			heightDefaultValue = Width;
			height = Width_DefaultValue;
			if ((heightDefaultValue.GetValueOrDefault() == height.GetValueOrDefault()
				? heightDefaultValue.HasValue != height.HasValue
				: true))
			{
				hashtables.Add("width", Width);
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