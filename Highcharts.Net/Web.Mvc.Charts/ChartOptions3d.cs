using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class ChartOptions3d : BaseObject
	{
		public double? Alpha
		{
			get;
			set;
		}

		private double? Alpha_DefaultValue
		{
			get;
			set;
		}

		public double? Beta
		{
			get;
			set;
		}

		private double? Beta_DefaultValue
		{
			get;
			set;
		}

		public double? Depth
		{
			get;
			set;
		}

		private double? Depth_DefaultValue
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

		public bool? FitToPlot
		{
			get;
			set;
		}

		private bool? FitToPlot_DefaultValue
		{
			get;
			set;
		}

		public ChartOptions3dFrame Frame
		{
			get;
			set;
		}

		private ChartOptions3dFrame Frame_DefaultValue
		{
			get;
			set;
		}

		public double? ViewDistance
		{
			get;
			set;
		}

		private double? ViewDistance_DefaultValue
		{
			get;
			set;
		}

		public ChartOptions3d()
		{
			double? nullable = new double?(0);
			this.Alpha_DefaultValue = nullable;
			this.Alpha = nullable;
			nullable = new double?(0);
			this.Beta_DefaultValue = nullable;
			this.Beta = nullable;
			nullable = new double?((double)100);
			this.Depth_DefaultValue = nullable;
			this.Depth = nullable;
			bool? nullable1 = new bool?(false);
			this.Enabled_DefaultValue = nullable1;
			this.Enabled = nullable1;
			nullable1 = new bool?(true);
			this.FitToPlot_DefaultValue = nullable1;
			this.FitToPlot = nullable1;
			ChartOptions3dFrame chartOptions3dFrame = new ChartOptions3dFrame();
			ChartOptions3dFrame chartOptions3dFrame1 = chartOptions3dFrame;
			this.Frame_DefaultValue = chartOptions3dFrame;
			this.Frame = chartOptions3dFrame1;
			nullable = new double?((double)100);
			this.ViewDistance_DefaultValue = nullable;
			this.ViewDistance = nullable;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			double? alpha = this.Alpha;
			double? alphaDefaultValue = this.Alpha_DefaultValue;
			if ((alpha.GetValueOrDefault() == alphaDefaultValue.GetValueOrDefault() ? alpha.HasValue != alphaDefaultValue.HasValue : true))
			{
				hashtables.Add("alpha", this.Alpha);
			}
			alphaDefaultValue = this.Beta;
			alpha = this.Beta_DefaultValue;
			if ((alphaDefaultValue.GetValueOrDefault() == alpha.GetValueOrDefault() ? alphaDefaultValue.HasValue != alpha.HasValue : true))
			{
				hashtables.Add("beta", this.Beta);
			}
			alpha = this.Depth;
			alphaDefaultValue = this.Depth_DefaultValue;
			if ((alpha.GetValueOrDefault() == alphaDefaultValue.GetValueOrDefault() ? alpha.HasValue != alphaDefaultValue.HasValue : true))
			{
				hashtables.Add("depth", this.Depth);
			}
			bool? enabled = this.Enabled;
			bool? enabledDefaultValue = this.Enabled_DefaultValue;
			if ((enabled.GetValueOrDefault() == enabledDefaultValue.GetValueOrDefault() ? enabled.HasValue != enabledDefaultValue.HasValue : true))
			{
				hashtables.Add("enabled", this.Enabled);
			}
			enabledDefaultValue = this.FitToPlot;
			enabled = this.FitToPlot_DefaultValue;
			if ((enabledDefaultValue.GetValueOrDefault() == enabled.GetValueOrDefault() ? enabledDefaultValue.HasValue != enabled.HasValue : true))
			{
				hashtables.Add("fitToPlot", this.FitToPlot);
			}
			if (this.Frame.IsDirty())
			{
				hashtables.Add("frame", this.Frame.ToHashtable());
			}
			alphaDefaultValue = this.ViewDistance;
			alpha = this.ViewDistance_DefaultValue;
			if ((alphaDefaultValue.GetValueOrDefault() == alpha.GetValueOrDefault() ? alphaDefaultValue.HasValue != alpha.HasValue : true))
			{
				hashtables.Add("viewDistance", this.ViewDistance);
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