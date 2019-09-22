using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class ArearangeSeriesStatesHover : BaseObject
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

		public ArearangeSeriesStatesHoverHalo Halo
		{
			get;
			set;
		}

		private ArearangeSeriesStatesHoverHalo Halo_DefaultValue
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

		public ArearangeSeriesStatesHover()
		{
			Highsoft.Web.Mvc.Charts.Animation animation = new Highsoft.Web.Mvc.Charts.Animation()
			{
				Enabled = true
			};
			Highsoft.Web.Mvc.Charts.Animation animation1 = animation;
			this.Animation_DefaultValue = animation;
			this.Animation = animation1;
			bool? nullable = new bool?(true);
			this.Enabled_DefaultValue = nullable;
			this.Enabled = nullable;
			ArearangeSeriesStatesHoverHalo arearangeSeriesStatesHoverHalo = new ArearangeSeriesStatesHoverHalo();
			ArearangeSeriesStatesHoverHalo arearangeSeriesStatesHoverHalo1 = arearangeSeriesStatesHoverHalo;
			this.Halo_DefaultValue = arearangeSeriesStatesHoverHalo;
			this.Halo = arearangeSeriesStatesHoverHalo1;
			double? nullable1 = new double?((double)2);
			this.LineWidth_DefaultValue = nullable1;
			this.LineWidth = nullable1;
			nullable1 = new double?((double)1);
			this.LineWidthPlus_DefaultValue = nullable1;
			this.LineWidthPlus = nullable1;
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
			bool? enabled = this.Enabled;
			bool? enabledDefaultValue = this.Enabled_DefaultValue;
			if ((enabled.GetValueOrDefault() == enabledDefaultValue.GetValueOrDefault() ? enabled.HasValue != enabledDefaultValue.HasValue : true))
			{
				hashtables.Add("enabled", this.Enabled);
			}
			if (this.Halo.IsDirty())
			{
				hashtables.Add("halo", this.Halo.ToHashtable());
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