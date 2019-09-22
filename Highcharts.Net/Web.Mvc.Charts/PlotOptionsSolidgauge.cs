using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsSolidgauge : BaseObject
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

		public double? AnimationLimit
		{
			get;
			set;
		}

		private double? AnimationLimit_DefaultValue
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

		public double? ColorIndex
		{
			get;
			set;
		}

		private double? ColorIndex_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsSolidgaugeCursor Cursor
		{
			get;
			set;
		}

		private PlotOptionsSolidgaugeCursor Cursor_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsSolidgaugeDataLabels DataLabels
		{
			get;
			set;
		}

		private PlotOptionsSolidgaugeDataLabels DataLabels_DefaultValue
		{
			get;
			set;
		}

		public string Description
		{
			get;
			set;
		}

		private string Description_DefaultValue
		{
			get;
			set;
		}

		public bool? EnableMouseTracking
		{
			get;
			set;
		}

		private bool? EnableMouseTracking_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsSolidgaugeEvents Events
		{
			get;
			set;
		}

		private PlotOptionsSolidgaugeEvents Events_DefaultValue
		{
			get;
			set;
		}

		public bool? GetExtremesFromAll
		{
			get;
			set;
		}

		private bool? GetExtremesFromAll_DefaultValue
		{
			get;
			set;
		}

		public List<string> Keys
		{
			get;
			set;
		}

		private List<string> Keys_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsSolidgaugeLinecap Linecap
		{
			get;
			set;
		}

		private PlotOptionsSolidgaugeLinecap Linecap_DefaultValue
		{
			get;
			set;
		}

		public double? Overshoot
		{
			get;
			set;
		}

		private double? Overshoot_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsSolidgaugePoint Point
		{
			get;
			set;
		}

		private PlotOptionsSolidgaugePoint Point_DefaultValue
		{
			get;
			set;
		}

		public bool? Rounded
		{
			get;
			set;
		}

		private bool? Rounded_DefaultValue
		{
			get;
			set;
		}

		public bool? Selected
		{
			get;
			set;
		}

		private bool? Selected_DefaultValue
		{
			get;
			set;
		}

		public bool? ShowCheckbox
		{
			get;
			set;
		}

		private bool? ShowCheckbox_DefaultValue
		{
			get;
			set;
		}

		public bool? ShowInLegend
		{
			get;
			set;
		}

		private bool? ShowInLegend_DefaultValue
		{
			get;
			set;
		}

		public bool? StickyTracking
		{
			get;
			set;
		}

		private bool? StickyTracking_DefaultValue
		{
			get;
			set;
		}

		public double? Threshold
		{
			get;
			set;
		}

		private double? Threshold_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsSolidgaugeTooltip Tooltip
		{
			get;
			set;
		}

		private PlotOptionsSolidgaugeTooltip Tooltip_DefaultValue
		{
			get;
			set;
		}

		public bool? Visible
		{
			get;
			set;
		}

		private bool? Visible_DefaultValue
		{
			get;
			set;
		}

		public bool? Wrap
		{
			get;
			set;
		}

		private bool? Wrap_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsSolidgauge()
		{
			Highsoft.Web.Mvc.Charts.Animation animation = new Highsoft.Web.Mvc.Charts.Animation()
			{
				Enabled = true
			};
			Highsoft.Web.Mvc.Charts.Animation animation1 = animation;
			this.Animation_DefaultValue = animation;
			this.Animation = animation1;
			double? nullable = null;
			this.AnimationLimit_DefaultValue = nullable;
			this.AnimationLimit = nullable;
			string str = "";
			string str1 = str;
			this.ClassName_DefaultValue = str;
			this.ClassName = str1;
			nullable = null;
			this.ColorIndex_DefaultValue = nullable;
			this.ColorIndex = nullable;
			int num = 0;
			PlotOptionsSolidgaugeCursor plotOptionsSolidgaugeCursor = (PlotOptionsSolidgaugeCursor)num;
			this.Cursor_DefaultValue = (PlotOptionsSolidgaugeCursor)num;
			this.Cursor = plotOptionsSolidgaugeCursor;
			PlotOptionsSolidgaugeDataLabels plotOptionsSolidgaugeDataLabel = new PlotOptionsSolidgaugeDataLabels();
			PlotOptionsSolidgaugeDataLabels plotOptionsSolidgaugeDataLabel1 = plotOptionsSolidgaugeDataLabel;
			this.DataLabels_DefaultValue = plotOptionsSolidgaugeDataLabel;
			this.DataLabels = plotOptionsSolidgaugeDataLabel1;
			string str2 = "undefined";
			str1 = str2;
			this.Description_DefaultValue = str2;
			this.Description = str1;
			bool? nullable1 = new bool?(true);
			this.EnableMouseTracking_DefaultValue = nullable1;
			this.EnableMouseTracking = nullable1;
			PlotOptionsSolidgaugeEvents plotOptionsSolidgaugeEvent = new PlotOptionsSolidgaugeEvents();
			PlotOptionsSolidgaugeEvents plotOptionsSolidgaugeEvent1 = plotOptionsSolidgaugeEvent;
			this.Events_DefaultValue = plotOptionsSolidgaugeEvent;
			this.Events = plotOptionsSolidgaugeEvent1;
			nullable1 = new bool?(false);
			this.GetExtremesFromAll_DefaultValue = nullable1;
			this.GetExtremesFromAll = nullable1;
			List<string> strs = new List<string>();
			List<string> strs1 = strs;
			this.Keys_DefaultValue = strs;
			this.Keys = strs1;
			int num1 = 1;
			PlotOptionsSolidgaugeLinecap plotOptionsSolidgaugeLinecap = (PlotOptionsSolidgaugeLinecap)num1;
			this.Linecap_DefaultValue = (PlotOptionsSolidgaugeLinecap)num1;
			this.Linecap = plotOptionsSolidgaugeLinecap;
			nullable = new double?(0);
			this.Overshoot_DefaultValue = nullable;
			this.Overshoot = nullable;
			PlotOptionsSolidgaugePoint plotOptionsSolidgaugePoint = new PlotOptionsSolidgaugePoint();
			PlotOptionsSolidgaugePoint plotOptionsSolidgaugePoint1 = plotOptionsSolidgaugePoint;
			this.Point_DefaultValue = plotOptionsSolidgaugePoint;
			this.Point = plotOptionsSolidgaugePoint1;
			nullable1 = new bool?(false);
			this.Rounded_DefaultValue = nullable1;
			this.Rounded = nullable1;
			nullable1 = new bool?(false);
			this.Selected_DefaultValue = nullable1;
			this.Selected = nullable1;
			nullable1 = new bool?(false);
			this.ShowCheckbox_DefaultValue = nullable1;
			this.ShowCheckbox = nullable1;
			nullable1 = null;
			this.ShowInLegend_DefaultValue = nullable1;
			this.ShowInLegend = nullable1;
			nullable1 = new bool?(true);
			this.StickyTracking_DefaultValue = nullable1;
			this.StickyTracking = nullable1;
			nullable = null;
			this.Threshold_DefaultValue = nullable;
			this.Threshold = nullable;
			PlotOptionsSolidgaugeTooltip plotOptionsSolidgaugeTooltip = new PlotOptionsSolidgaugeTooltip();
			PlotOptionsSolidgaugeTooltip plotOptionsSolidgaugeTooltip1 = plotOptionsSolidgaugeTooltip;
			this.Tooltip_DefaultValue = plotOptionsSolidgaugeTooltip;
			this.Tooltip = plotOptionsSolidgaugeTooltip1;
			nullable1 = new bool?(true);
			this.Visible_DefaultValue = nullable1;
			this.Visible = nullable1;
			nullable1 = new bool?(true);
			this.Wrap_DefaultValue = nullable1;
			this.Wrap = nullable1;
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
			double? animationLimit = this.AnimationLimit;
			double? animationLimitDefaultValue = this.AnimationLimit_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("animationLimit", this.AnimationLimit);
			}
			if (this.ClassName != this.ClassName_DefaultValue)
			{
				hashtables.Add("className", this.ClassName);
			}
			animationLimitDefaultValue = this.ColorIndex;
			animationLimit = this.ColorIndex_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("colorIndex", this.ColorIndex);
			}
			if (this.Cursor != this.Cursor_DefaultValue)
			{
				PlotOptionsSolidgaugeCursor cursor = this.Cursor;
				hashtables.Add("cursor", Highcharts.FirstCharacterToLower(cursor.ToString()));
			}
			if (this.DataLabels.IsDirty())
			{
				hashtables.Add("dataLabels", this.DataLabels.ToHashtable());
			}
			if (this.Description != this.Description_DefaultValue)
			{
				hashtables.Add("description", this.Description);
			}
			bool? enableMouseTracking = this.EnableMouseTracking;
			bool? enableMouseTrackingDefaultValue = this.EnableMouseTracking_DefaultValue;
			if ((enableMouseTracking.GetValueOrDefault() == enableMouseTrackingDefaultValue.GetValueOrDefault() ? enableMouseTracking.HasValue != enableMouseTrackingDefaultValue.HasValue : true))
			{
				hashtables.Add("enableMouseTracking", this.EnableMouseTracking);
			}
			if (this.Events.IsDirty())
			{
				hashtables.Add("events", this.Events.ToHashtable());
			}
			enableMouseTrackingDefaultValue = this.GetExtremesFromAll;
			enableMouseTracking = this.GetExtremesFromAll_DefaultValue;
			if ((enableMouseTrackingDefaultValue.GetValueOrDefault() == enableMouseTracking.GetValueOrDefault() ? enableMouseTrackingDefaultValue.HasValue != enableMouseTracking.HasValue : true))
			{
				hashtables.Add("getExtremesFromAll", this.GetExtremesFromAll);
			}
			if (this.Keys != this.Keys_DefaultValue)
			{
				hashtables.Add("keys", this.Keys);
			}
			if (this.Linecap != this.Linecap_DefaultValue)
			{
				PlotOptionsSolidgaugeLinecap linecap = this.Linecap;
				hashtables.Add("linecap", Highcharts.FirstCharacterToLower(linecap.ToString()));
			}
			animationLimit = this.Overshoot;
			animationLimitDefaultValue = this.Overshoot_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("overshoot", this.Overshoot);
			}
			if (this.Point.IsDirty())
			{
				hashtables.Add("point", this.Point.ToHashtable());
			}
			enableMouseTracking = this.Rounded;
			enableMouseTrackingDefaultValue = this.Rounded_DefaultValue;
			if ((enableMouseTracking.GetValueOrDefault() == enableMouseTrackingDefaultValue.GetValueOrDefault() ? enableMouseTracking.HasValue != enableMouseTrackingDefaultValue.HasValue : true))
			{
				hashtables.Add("rounded", this.Rounded);
			}
			enableMouseTrackingDefaultValue = this.Selected;
			enableMouseTracking = this.Selected_DefaultValue;
			if ((enableMouseTrackingDefaultValue.GetValueOrDefault() == enableMouseTracking.GetValueOrDefault() ? enableMouseTrackingDefaultValue.HasValue != enableMouseTracking.HasValue : true))
			{
				hashtables.Add("selected", this.Selected);
			}
			enableMouseTracking = this.ShowCheckbox;
			enableMouseTrackingDefaultValue = this.ShowCheckbox_DefaultValue;
			if ((enableMouseTracking.GetValueOrDefault() == enableMouseTrackingDefaultValue.GetValueOrDefault() ? enableMouseTracking.HasValue != enableMouseTrackingDefaultValue.HasValue : true))
			{
				hashtables.Add("showCheckbox", this.ShowCheckbox);
			}
			enableMouseTrackingDefaultValue = this.ShowInLegend;
			enableMouseTracking = this.ShowInLegend_DefaultValue;
			if ((enableMouseTrackingDefaultValue.GetValueOrDefault() == enableMouseTracking.GetValueOrDefault() ? enableMouseTrackingDefaultValue.HasValue != enableMouseTracking.HasValue : true))
			{
				hashtables.Add("showInLegend", this.ShowInLegend);
			}
			enableMouseTracking = this.StickyTracking;
			enableMouseTrackingDefaultValue = this.StickyTracking_DefaultValue;
			if ((enableMouseTracking.GetValueOrDefault() == enableMouseTrackingDefaultValue.GetValueOrDefault() ? enableMouseTracking.HasValue != enableMouseTrackingDefaultValue.HasValue : true))
			{
				hashtables.Add("stickyTracking", this.StickyTracking);
			}
			animationLimitDefaultValue = this.Threshold;
			animationLimit = this.Threshold_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("threshold", this.Threshold);
			}
			if (this.Tooltip.IsDirty())
			{
				hashtables.Add("tooltip", this.Tooltip.ToHashtable());
			}
			enableMouseTrackingDefaultValue = this.Visible;
			enableMouseTracking = this.Visible_DefaultValue;
			if ((enableMouseTrackingDefaultValue.GetValueOrDefault() == enableMouseTracking.GetValueOrDefault() ? enableMouseTrackingDefaultValue.HasValue != enableMouseTracking.HasValue : true))
			{
				hashtables.Add("visible", this.Visible);
			}
			enableMouseTracking = this.Wrap;
			enableMouseTrackingDefaultValue = this.Wrap_DefaultValue;
			if ((enableMouseTracking.GetValueOrDefault() == enableMouseTrackingDefaultValue.GetValueOrDefault() ? enableMouseTracking.HasValue != enableMouseTrackingDefaultValue.HasValue : true))
			{
				hashtables.Add("wrap", this.Wrap);
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