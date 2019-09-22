using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class TreemapSeriesStatesHover : BaseObject
	{
		public Highsoft.Web.Mvc.Charts.Animation Animation
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.Animation Animation_DefaultValue
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

		public double? Brightness
		{
			get;
			set;
		}

		private double? Brightness_DefaultValue
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

		public double? Opacity
		{
			get;
			set;
		}

		private double? Opacity_DefaultValue
		{
			get;
			set;
		}

		public TreemapSeriesStatesHover()
		{
			Highsoft.Web.Mvc.Charts.Animation animation = new Highsoft.Web.Mvc.Charts.Animation()
			{
				Enabled = true
			};
			Highsoft.Web.Mvc.Charts.Animation animation1 = animation;
			this.Animation_DefaultValue = animation;
			this.Animation = animation1;
			string str = "";
			string str1 = str;
			this.BorderColor_DefaultValue = str;
			this.BorderColor = str1;
			double? nullable = new double?(0.1);
			this.Brightness_DefaultValue = nullable;
			this.Brightness = nullable;
			string str2 = "undefined";
			str1 = str2;
			this.Color_DefaultValue = str2;
			this.Color = str1;
			bool? nullable1 = new bool?(true);
			this.Enabled_DefaultValue = nullable1;
			this.Enabled = nullable1;
			nullable = new double?(0.75);
			this.Opacity_DefaultValue = nullable;
			this.Opacity = nullable;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.Animation.IsDirty())
			{
				hashtables.Add("animation", this.Animation.ToJSON());
			}
			if (this.BorderColor != this.BorderColor_DefaultValue)
			{
				hashtables.Add("borderColor", this.BorderColor);
			}
			double? brightness = this.Brightness;
			double? brightnessDefaultValue = this.Brightness_DefaultValue;
			if ((brightness.GetValueOrDefault() == brightnessDefaultValue.GetValueOrDefault() ? brightness.HasValue != brightnessDefaultValue.HasValue : true))
			{
				hashtables.Add("brightness", this.Brightness);
			}
			if (this.Color != this.Color_DefaultValue)
			{
				hashtables.Add("color", this.Color);
			}
			bool? enabled = this.Enabled;
			bool? enabledDefaultValue = this.Enabled_DefaultValue;
			if ((enabled.GetValueOrDefault() == enabledDefaultValue.GetValueOrDefault() ? enabled.HasValue != enabledDefaultValue.HasValue : true))
			{
				hashtables.Add("enabled", this.Enabled);
			}
			brightnessDefaultValue = this.Opacity;
			brightness = this.Opacity_DefaultValue;
			if ((brightnessDefaultValue.GetValueOrDefault() == brightness.GetValueOrDefault() ? brightnessDefaultValue.HasValue != brightness.HasValue : true))
			{
				hashtables.Add("opacity", this.Opacity);
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