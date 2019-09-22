using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class LegendNavigation : BaseObject
	{
		public string ActiveColor
		{
			get;
			set;
		}

		private string ActiveColor_DefaultValue
		{
			get;
			set;
		}

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

		public double? ArrowSize
		{
			get;
			set;
		}

		private double? ArrowSize_DefaultValue
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

		public string InactiveColor
		{
			get;
			set;
		}

		private string InactiveColor_DefaultValue
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

		public LegendNavigation()
		{
			string str = "#003399";
			string str1 = str;
			this.ActiveColor_DefaultValue = str;
			this.ActiveColor = str1;
			Highsoft.Web.Mvc.Charts.Animation animation = new Highsoft.Web.Mvc.Charts.Animation()
			{
				Enabled = true
			};
			Highsoft.Web.Mvc.Charts.Animation animation1 = animation;
			this.Animation_DefaultValue = animation;
			this.Animation = animation1;
			double? nullable = new double?((double)12);
			this.ArrowSize_DefaultValue = nullable;
			this.ArrowSize = nullable;
			bool? nullable1 = new bool?(true);
			this.Enabled_DefaultValue = nullable1;
			this.Enabled = nullable1;
			string str2 = "#cccccc";
			str1 = str2;
			this.InactiveColor_DefaultValue = str2;
			this.InactiveColor = str1;
			Hashtable hashtables = new Hashtable();
			Hashtable hashtables1 = hashtables;
			this.Style_DefaultValue = hashtables;
			this.Style = hashtables1;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.ActiveColor != this.ActiveColor_DefaultValue)
			{
				hashtables.Add("activeColor", this.ActiveColor);
			}
			if (this.Animation.IsDirty())
			{
				hashtables.Add("animation", this.Animation.ToJSON());
			}
			double? arrowSize = this.ArrowSize;
			double? arrowSizeDefaultValue = this.ArrowSize_DefaultValue;
			if ((arrowSize.GetValueOrDefault() == arrowSizeDefaultValue.GetValueOrDefault() ? arrowSize.HasValue != arrowSizeDefaultValue.HasValue : true))
			{
				hashtables.Add("arrowSize", this.ArrowSize);
			}
			bool? enabled = this.Enabled;
			bool? enabledDefaultValue = this.Enabled_DefaultValue;
			if ((enabled.GetValueOrDefault() == enabledDefaultValue.GetValueOrDefault() ? enabled.HasValue != enabledDefaultValue.HasValue : true))
			{
				hashtables.Add("enabled", this.Enabled);
			}
			if (this.InactiveColor != this.InactiveColor_DefaultValue)
			{
				hashtables.Add("inactiveColor", this.InactiveColor);
			}
			if (this.Style != this.Style_DefaultValue)
			{
				hashtables.Add("style", this.Style);
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