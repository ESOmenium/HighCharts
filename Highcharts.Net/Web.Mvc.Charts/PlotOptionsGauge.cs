using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsGauge : BaseObject
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

		public PlotOptionsGaugeCursor Cursor
		{
			get;
			set;
		}

		private PlotOptionsGaugeCursor Cursor_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsGaugeDataLabels DataLabels
		{
			get;
			set;
		}

		private PlotOptionsGaugeDataLabels DataLabels_DefaultValue
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

		public PlotOptionsGaugeDial Dial
		{
			get;
			set;
		}

		private PlotOptionsGaugeDial Dial_DefaultValue
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

		public PlotOptionsGaugeEvents Events
		{
			get;
			set;
		}

		private PlotOptionsGaugeEvents Events_DefaultValue
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

		public string LinkedTo
		{
			get;
			set;
		}

		private string LinkedTo_DefaultValue
		{
			get;
			set;
		}

		public string NegativeColor
		{
			get;
			set;
		}

		private string NegativeColor_DefaultValue
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

		public PlotOptionsGaugePivot Pivot
		{
			get;
			set;
		}

		private PlotOptionsGaugePivot Pivot_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsGaugePoint Point
		{
			get;
			set;
		}

		private PlotOptionsGaugePoint Point_DefaultValue
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

		public PlotOptionsGaugeTooltip Tooltip
		{
			get;
			set;
		}

		private PlotOptionsGaugeTooltip Tooltip_DefaultValue
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

		public PlotOptionsGauge()
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
			object obj = null;
			str1 = (string)obj;
			this.Color_DefaultValue = (string)obj;
			this.Color = str1;
			nullable = null;
			this.ColorIndex_DefaultValue = nullable;
			this.ColorIndex = nullable;
			int num = 0;
			PlotOptionsGaugeCursor plotOptionsGaugeCursor = (PlotOptionsGaugeCursor)num;
			this.Cursor_DefaultValue = (PlotOptionsGaugeCursor)num;
			this.Cursor = plotOptionsGaugeCursor;
			PlotOptionsGaugeDataLabels plotOptionsGaugeDataLabel = new PlotOptionsGaugeDataLabels();
			PlotOptionsGaugeDataLabels plotOptionsGaugeDataLabel1 = plotOptionsGaugeDataLabel;
			this.DataLabels_DefaultValue = plotOptionsGaugeDataLabel;
			this.DataLabels = plotOptionsGaugeDataLabel1;
			string str2 = "undefined";
			str1 = str2;
			this.Description_DefaultValue = str2;
			this.Description = str1;
			PlotOptionsGaugeDial plotOptionsGaugeDial = new PlotOptionsGaugeDial();
			PlotOptionsGaugeDial plotOptionsGaugeDial1 = plotOptionsGaugeDial;
			this.Dial_DefaultValue = plotOptionsGaugeDial;
			this.Dial = plotOptionsGaugeDial1;
			bool? nullable1 = new bool?(true);
			this.EnableMouseTracking_DefaultValue = nullable1;
			this.EnableMouseTracking = nullable1;
			PlotOptionsGaugeEvents plotOptionsGaugeEvent = new PlotOptionsGaugeEvents();
			PlotOptionsGaugeEvents plotOptionsGaugeEvent1 = plotOptionsGaugeEvent;
			this.Events_DefaultValue = plotOptionsGaugeEvent;
			this.Events = plotOptionsGaugeEvent1;
			nullable1 = new bool?(false);
			this.GetExtremesFromAll_DefaultValue = nullable1;
			this.GetExtremesFromAll = nullable1;
			List<string> strs = new List<string>();
			List<string> strs1 = strs;
			this.Keys_DefaultValue = strs;
			this.Keys = strs1;
			string str3 = "";
			str1 = str3;
			this.LinkedTo_DefaultValue = str3;
			this.LinkedTo = str1;
			string str4 = "null";
			str1 = str4;
			this.NegativeColor_DefaultValue = str4;
			this.NegativeColor = str1;
			nullable = new double?(0);
			this.Overshoot_DefaultValue = nullable;
			this.Overshoot = nullable;
			PlotOptionsGaugePivot plotOptionsGaugePivot = new PlotOptionsGaugePivot();
			PlotOptionsGaugePivot plotOptionsGaugePivot1 = plotOptionsGaugePivot;
			this.Pivot_DefaultValue = plotOptionsGaugePivot;
			this.Pivot = plotOptionsGaugePivot1;
			PlotOptionsGaugePoint plotOptionsGaugePoint = new PlotOptionsGaugePoint();
			PlotOptionsGaugePoint plotOptionsGaugePoint1 = plotOptionsGaugePoint;
			this.Point_DefaultValue = plotOptionsGaugePoint;
			this.Point = plotOptionsGaugePoint1;
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
			nullable = new double?(0);
			this.Threshold_DefaultValue = nullable;
			this.Threshold = nullable;
			PlotOptionsGaugeTooltip plotOptionsGaugeTooltip = new PlotOptionsGaugeTooltip();
			PlotOptionsGaugeTooltip plotOptionsGaugeTooltip1 = plotOptionsGaugeTooltip;
			this.Tooltip_DefaultValue = plotOptionsGaugeTooltip;
			this.Tooltip = plotOptionsGaugeTooltip1;
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
			if (this.Color != this.Color_DefaultValue)
			{
				hashtables.Add("color", this.Color);
			}
			animationLimitDefaultValue = this.ColorIndex;
			animationLimit = this.ColorIndex_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("colorIndex", this.ColorIndex);
			}
			if (this.Cursor != this.Cursor_DefaultValue)
			{
				PlotOptionsGaugeCursor cursor = this.Cursor;
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
			if (this.Dial.IsDirty())
			{
				hashtables.Add("dial", this.Dial.ToHashtable());
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
			if (this.LinkedTo != this.LinkedTo_DefaultValue)
			{
				hashtables.Add("linkedTo", this.LinkedTo);
			}
			if (this.NegativeColor != this.NegativeColor_DefaultValue)
			{
				hashtables.Add("negativeColor", this.NegativeColor);
			}
			animationLimit = this.Overshoot;
			animationLimitDefaultValue = this.Overshoot_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("overshoot", this.Overshoot);
			}
			if (this.Pivot.IsDirty())
			{
				hashtables.Add("pivot", this.Pivot.ToHashtable());
			}
			if (this.Point.IsDirty())
			{
				hashtables.Add("point", this.Point.ToHashtable());
			}
			enableMouseTracking = this.Selected;
			enableMouseTrackingDefaultValue = this.Selected_DefaultValue;
			if ((enableMouseTracking.GetValueOrDefault() == enableMouseTrackingDefaultValue.GetValueOrDefault() ? enableMouseTracking.HasValue != enableMouseTrackingDefaultValue.HasValue : true))
			{
				hashtables.Add("selected", this.Selected);
			}
			enableMouseTrackingDefaultValue = this.ShowCheckbox;
			enableMouseTracking = this.ShowCheckbox_DefaultValue;
			if ((enableMouseTrackingDefaultValue.GetValueOrDefault() == enableMouseTracking.GetValueOrDefault() ? enableMouseTrackingDefaultValue.HasValue != enableMouseTracking.HasValue : true))
			{
				hashtables.Add("showCheckbox", this.ShowCheckbox);
			}
			enableMouseTracking = this.ShowInLegend;
			enableMouseTrackingDefaultValue = this.ShowInLegend_DefaultValue;
			if ((enableMouseTracking.GetValueOrDefault() == enableMouseTrackingDefaultValue.GetValueOrDefault() ? enableMouseTracking.HasValue != enableMouseTrackingDefaultValue.HasValue : true))
			{
				hashtables.Add("showInLegend", this.ShowInLegend);
			}
			enableMouseTrackingDefaultValue = this.StickyTracking;
			enableMouseTracking = this.StickyTracking_DefaultValue;
			if ((enableMouseTrackingDefaultValue.GetValueOrDefault() == enableMouseTracking.GetValueOrDefault() ? enableMouseTrackingDefaultValue.HasValue != enableMouseTracking.HasValue : true))
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
			enableMouseTracking = this.Visible;
			enableMouseTrackingDefaultValue = this.Visible_DefaultValue;
			if ((enableMouseTracking.GetValueOrDefault() == enableMouseTrackingDefaultValue.GetValueOrDefault() ? enableMouseTracking.HasValue != enableMouseTrackingDefaultValue.HasValue : true))
			{
				hashtables.Add("visible", this.Visible);
			}
			enableMouseTrackingDefaultValue = this.Wrap;
			enableMouseTracking = this.Wrap_DefaultValue;
			if ((enableMouseTrackingDefaultValue.GetValueOrDefault() == enableMouseTracking.GetValueOrDefault() ? enableMouseTrackingDefaultValue.HasValue != enableMouseTracking.HasValue : true))
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