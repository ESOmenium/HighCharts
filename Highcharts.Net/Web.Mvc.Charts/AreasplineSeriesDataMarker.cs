using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class AreasplineSeriesDataMarker : BaseObject
	{
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

		public object FillColor
		{
			get;
			set;
		}

		private object FillColor_DefaultValue
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

		public string LineColor
		{
			get;
			set;
		}

		private string LineColor_DefaultValue
		{
			get;
			set;
		}

		public double? LineWidth
		{
			get;
			set;
		}

		private double? LineWidth_DefaultValue
		{
			get;
			set;
		}

		public double? Radius
		{
			get;
			set;
		}

		private double? Radius_DefaultValue
		{
			get;
			set;
		}

		public AreasplineSeriesDataMarkerStates States
		{
			get;
			set;
		}

		private AreasplineSeriesDataMarkerStates States_DefaultValue
		{
			get;
			set;
		}

		public string Symbol
		{
			get;
			set;
		}

		private string Symbol_DefaultValue
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

		public AreasplineSeriesDataMarker()
		{
			bool? nullable = null;
			this.Enabled_DefaultValue = nullable;
			this.Enabled = nullable;
			object obj = null;
			object obj1 = obj;
			this.FillColor_DefaultValue = obj;
			this.FillColor = obj1;
			double? nullable1 = null;
			this.Height_DefaultValue = nullable1;
			this.Height = nullable1;
			string str = "#ffffff";
			string str1 = str;
			this.LineColor_DefaultValue = str;
			this.LineColor = str1;
			nullable1 = new double?(0);
			this.LineWidth_DefaultValue = nullable1;
			this.LineWidth = nullable1;
			nullable1 = new double?((double)4);
			this.Radius_DefaultValue = nullable1;
			this.Radius = nullable1;
			AreasplineSeriesDataMarkerStates areasplineSeriesDataMarkerState = new AreasplineSeriesDataMarkerStates();
			AreasplineSeriesDataMarkerStates areasplineSeriesDataMarkerState1 = areasplineSeriesDataMarkerState;
			this.States_DefaultValue = areasplineSeriesDataMarkerState;
			this.States = areasplineSeriesDataMarkerState1;
			object obj2 = null;
			str1 = (string)obj2;
			this.Symbol_DefaultValue = (string)obj2;
			this.Symbol = str1;
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
			bool? enabled = this.Enabled;
			bool? enabledDefaultValue = this.Enabled_DefaultValue;
			if ((enabled.GetValueOrDefault() == enabledDefaultValue.GetValueOrDefault() ? enabled.HasValue != enabledDefaultValue.HasValue : true))
			{
				hashtables.Add("enabled", this.Enabled);
			}
			if (this.FillColor != this.FillColor_DefaultValue)
			{
				hashtables.Add("fillColor", this.FillColor);
			}
			double? height = this.Height;
			double? heightDefaultValue = this.Height_DefaultValue;
			if ((height.GetValueOrDefault() == heightDefaultValue.GetValueOrDefault() ? height.HasValue != heightDefaultValue.HasValue : true))
			{
				hashtables.Add("height", this.Height);
			}
			if (this.LineColor != this.LineColor_DefaultValue)
			{
				hashtables.Add("lineColor", this.LineColor);
			}
			heightDefaultValue = this.LineWidth;
			height = this.LineWidth_DefaultValue;
			if ((heightDefaultValue.GetValueOrDefault() == height.GetValueOrDefault() ? heightDefaultValue.HasValue != height.HasValue : true))
			{
				hashtables.Add("lineWidth", this.LineWidth);
			}
			height = this.Radius;
			heightDefaultValue = this.Radius_DefaultValue;
			if ((height.GetValueOrDefault() == heightDefaultValue.GetValueOrDefault() ? height.HasValue != heightDefaultValue.HasValue : true))
			{
				hashtables.Add("radius", this.Radius);
			}
			if (this.States.IsDirty())
			{
				hashtables.Add("states", this.States.ToHashtable());
			}
			if (this.Symbol != this.Symbol_DefaultValue)
			{
				hashtables.Add("symbol", this.Symbol);
			}
			heightDefaultValue = this.Width;
			height = this.Width_DefaultValue;
			if ((heightDefaultValue.GetValueOrDefault() == height.GetValueOrDefault() ? heightDefaultValue.HasValue != height.HasValue : true))
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