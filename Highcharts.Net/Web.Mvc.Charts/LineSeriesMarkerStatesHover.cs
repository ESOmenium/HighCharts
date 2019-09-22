using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class LineSeriesMarkerStatesHover : BaseObject
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

		public double? LineWidthPlus
		{
			get;
			set;
		}

		private double? LineWidthPlus_DefaultValue
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

		public double? RadiusPlus
		{
			get;
			set;
		}

		private double? RadiusPlus_DefaultValue
		{
			get;
			set;
		}

		public LineSeriesMarkerStatesHover()
		{
			bool? nullable = new bool?(true);
			this.Enabled_DefaultValue = nullable;
			this.Enabled = nullable;
			object obj = null;
			object obj1 = obj;
			this.FillColor_DefaultValue = obj;
			this.FillColor = obj1;
			string str = "#ffffff";
			string str1 = str;
			this.LineColor_DefaultValue = str;
			this.LineColor = str1;
			double? nullable1 = new double?(0);
			this.LineWidth_DefaultValue = nullable1;
			this.LineWidth = nullable1;
			nullable1 = new double?((double)1);
			this.LineWidthPlus_DefaultValue = nullable1;
			this.LineWidthPlus = nullable1;
			nullable1 = null;
			this.Radius_DefaultValue = nullable1;
			this.Radius = nullable1;
			nullable1 = new double?((double)2);
			this.RadiusPlus_DefaultValue = nullable1;
			this.RadiusPlus = nullable1;
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
			if (this.LineColor != this.LineColor_DefaultValue)
			{
				hashtables.Add("lineColor", this.LineColor);
			}
			double? lineWidth = this.LineWidth;
			double? lineWidthDefaultValue = this.LineWidth_DefaultValue;
			if ((lineWidth.GetValueOrDefault() == lineWidthDefaultValue.GetValueOrDefault() ? lineWidth.HasValue != lineWidthDefaultValue.HasValue : true))
			{
				hashtables.Add("lineWidth", this.LineWidth);
			}
			lineWidthDefaultValue = this.LineWidthPlus;
			lineWidth = this.LineWidthPlus_DefaultValue;
			if ((lineWidthDefaultValue.GetValueOrDefault() == lineWidth.GetValueOrDefault() ? lineWidthDefaultValue.HasValue != lineWidth.HasValue : true))
			{
				hashtables.Add("lineWidthPlus", this.LineWidthPlus);
			}
			lineWidth = this.Radius;
			lineWidthDefaultValue = this.Radius_DefaultValue;
			if ((lineWidth.GetValueOrDefault() == lineWidthDefaultValue.GetValueOrDefault() ? lineWidth.HasValue != lineWidthDefaultValue.HasValue : true))
			{
				hashtables.Add("radius", this.Radius);
			}
			lineWidthDefaultValue = this.RadiusPlus;
			lineWidth = this.RadiusPlus_DefaultValue;
			if ((lineWidthDefaultValue.GetValueOrDefault() == lineWidth.GetValueOrDefault() ? lineWidthDefaultValue.HasValue != lineWidth.HasValue : true))
			{
				hashtables.Add("radiusPlus", this.RadiusPlus);
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