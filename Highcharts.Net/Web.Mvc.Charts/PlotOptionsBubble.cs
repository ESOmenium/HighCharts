using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsBubble : BaseObject
	{
		public bool? AllowPointSelect
		{
			get;
			set;
		}

		private bool? AllowPointSelect_DefaultValue
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

		public double? CropThreshold
		{
			get;
			set;
		}

		private double? CropThreshold_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsBubbleCursor Cursor
		{
			get;
			set;
		}

		private PlotOptionsBubbleCursor Cursor_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsBubbleDashStyle DashStyle
		{
			get;
			set;
		}

		private PlotOptionsBubbleDashStyle DashStyle_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsBubbleDataLabels DataLabels
		{
			get;
			set;
		}

		private PlotOptionsBubbleDataLabels DataLabels_DefaultValue
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

		public bool? DisplayNegative
		{
			get;
			set;
		}

		private bool? DisplayNegative_DefaultValue
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

		public PlotOptionsBubbleEvents Events
		{
			get;
			set;
		}

		private PlotOptionsBubbleEvents Events_DefaultValue
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

		public PlotOptionsBubbleMarker Marker
		{
			get;
			set;
		}

		private PlotOptionsBubbleMarker Marker_DefaultValue
		{
			get;
			set;
		}

		public string MaxSize
		{
			get;
			set;
		}

		private string MaxSize_DefaultValue
		{
			get;
			set;
		}

		public string MinSize
		{
			get;
			set;
		}

		private string MinSize_DefaultValue
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

		public PlotOptionsBubblePoint Point
		{
			get;
			set;
		}

		private PlotOptionsBubblePoint Point_DefaultValue
		{
			get;
			set;
		}

		public double? PointInterval
		{
			get;
			set;
		}

		private double? PointInterval_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsBubblePointIntervalUnit PointIntervalUnit
		{
			get;
			set;
		}

		private PlotOptionsBubblePointIntervalUnit PointIntervalUnit_DefaultValue
		{
			get;
			set;
		}

		public double? PointStart
		{
			get;
			set;
		}

		private double? PointStart_DefaultValue
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

		public Highsoft.Web.Mvc.Charts.Shadow Shadow
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.Shadow Shadow_DefaultValue
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

		public PlotOptionsBubbleSizeBy SizeBy
		{
			get;
			set;
		}

		private PlotOptionsBubbleSizeBy SizeBy_DefaultValue
		{
			get;
			set;
		}

		public bool? SizeByAbsoluteValue
		{
			get;
			set;
		}

		private bool? SizeByAbsoluteValue_DefaultValue
		{
			get;
			set;
		}

		public bool? SoftThreshold
		{
			get;
			set;
		}

		private bool? SoftThreshold_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsBubbleStates States
		{
			get;
			set;
		}

		private PlotOptionsBubbleStates States_DefaultValue
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

		public PlotOptionsBubbleTooltip Tooltip
		{
			get;
			set;
		}

		private PlotOptionsBubbleTooltip Tooltip_DefaultValue
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

		public double? ZMax
		{
			get;
			set;
		}

		private double? ZMax_DefaultValue
		{
			get;
			set;
		}

		public double? ZMin
		{
			get;
			set;
		}

		private double? ZMin_DefaultValue
		{
			get;
			set;
		}

		public string ZoneAxis
		{
			get;
			set;
		}

		private string ZoneAxis_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsBubbleZones Zones
		{
			get;
			set;
		}

		private PlotOptionsBubbleZones Zones_DefaultValue
		{
			get;
			set;
		}

		public double? ZThreshold
		{
			get;
			set;
		}

		private double? ZThreshold_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsBubble()
		{
			bool? nullable = new bool?(false);
			this.AllowPointSelect_DefaultValue = nullable;
			this.AllowPointSelect = nullable;
			Highsoft.Web.Mvc.Charts.Animation animation = new Highsoft.Web.Mvc.Charts.Animation()
			{
				Enabled = true
			};
			Highsoft.Web.Mvc.Charts.Animation animation1 = animation;
			this.Animation_DefaultValue = animation;
			this.Animation = animation1;
			double? nullable1 = null;
			this.AnimationLimit_DefaultValue = nullable1;
			this.AnimationLimit = nullable1;
			string str = "";
			string str1 = str;
			this.ClassName_DefaultValue = str;
			this.ClassName = str1;
			object obj = null;
			str1 = (string)obj;
			this.Color_DefaultValue = (string)obj;
			this.Color = str1;
			nullable1 = null;
			this.ColorIndex_DefaultValue = nullable1;
			this.ColorIndex = nullable1;
			nullable1 = new double?((double)300);
			this.CropThreshold_DefaultValue = nullable1;
			this.CropThreshold = nullable1;
			int num = 0;
			PlotOptionsBubbleCursor plotOptionsBubbleCursor = (PlotOptionsBubbleCursor)num;
			this.Cursor_DefaultValue = (PlotOptionsBubbleCursor)num;
			this.Cursor = plotOptionsBubbleCursor;
			int num1 = 0;
			PlotOptionsBubbleDashStyle plotOptionsBubbleDashStyle = (PlotOptionsBubbleDashStyle)num1;
			this.DashStyle_DefaultValue = (PlotOptionsBubbleDashStyle)num1;
			this.DashStyle = plotOptionsBubbleDashStyle;
			PlotOptionsBubbleDataLabels plotOptionsBubbleDataLabel = new PlotOptionsBubbleDataLabels();
			PlotOptionsBubbleDataLabels plotOptionsBubbleDataLabel1 = plotOptionsBubbleDataLabel;
			this.DataLabels_DefaultValue = plotOptionsBubbleDataLabel;
			this.DataLabels = plotOptionsBubbleDataLabel1;
			string str2 = "undefined";
			str1 = str2;
			this.Description_DefaultValue = str2;
			this.Description = str1;
			nullable = new bool?(true);
			this.DisplayNegative_DefaultValue = nullable;
			this.DisplayNegative = nullable;
			nullable = new bool?(true);
			this.EnableMouseTracking_DefaultValue = nullable;
			this.EnableMouseTracking = nullable;
			PlotOptionsBubbleEvents plotOptionsBubbleEvent = new PlotOptionsBubbleEvents();
			PlotOptionsBubbleEvents plotOptionsBubbleEvent1 = plotOptionsBubbleEvent;
			this.Events_DefaultValue = plotOptionsBubbleEvent;
			this.Events = plotOptionsBubbleEvent1;
			nullable = new bool?(false);
			this.GetExtremesFromAll_DefaultValue = nullable;
			this.GetExtremesFromAll = nullable;
			List<string> strs = new List<string>();
			List<string> strs1 = strs;
			this.Keys_DefaultValue = strs;
			this.Keys = strs1;
			nullable1 = new double?(0);
			this.LineWidth_DefaultValue = nullable1;
			this.LineWidth = nullable1;
			string str3 = "";
			str1 = str3;
			this.LinkedTo_DefaultValue = str3;
			this.LinkedTo = str1;
			PlotOptionsBubbleMarker plotOptionsBubbleMarker = new PlotOptionsBubbleMarker();
			PlotOptionsBubbleMarker plotOptionsBubbleMarker1 = plotOptionsBubbleMarker;
			this.Marker_DefaultValue = plotOptionsBubbleMarker;
			this.Marker = plotOptionsBubbleMarker1;
			string str4 = "20%";
			str1 = str4;
			this.MaxSize_DefaultValue = str4;
			this.MaxSize = str1;
			string str5 = "8";
			str1 = str5;
			this.MinSize_DefaultValue = str5;
			this.MinSize = str1;
			string str6 = "null";
			str1 = str6;
			this.NegativeColor_DefaultValue = str6;
			this.NegativeColor = str1;
			PlotOptionsBubblePoint plotOptionsBubblePoint = new PlotOptionsBubblePoint();
			PlotOptionsBubblePoint plotOptionsBubblePoint1 = plotOptionsBubblePoint;
			this.Point_DefaultValue = plotOptionsBubblePoint;
			this.Point = plotOptionsBubblePoint1;
			nullable1 = new double?((double)1);
			this.PointInterval_DefaultValue = nullable1;
			this.PointInterval = nullable1;
			int num2 = 0;
			PlotOptionsBubblePointIntervalUnit plotOptionsBubblePointIntervalUnit = (PlotOptionsBubblePointIntervalUnit)num2;
			this.PointIntervalUnit_DefaultValue = (PlotOptionsBubblePointIntervalUnit)num2;
			this.PointIntervalUnit = plotOptionsBubblePointIntervalUnit;
			nullable1 = new double?(0);
			this.PointStart_DefaultValue = nullable1;
			this.PointStart = nullable1;
			nullable = new bool?(false);
			this.Selected_DefaultValue = nullable;
			this.Selected = nullable;
			Highsoft.Web.Mvc.Charts.Shadow shadow = new Highsoft.Web.Mvc.Charts.Shadow()
			{
				Enabled = false
			};
			Highsoft.Web.Mvc.Charts.Shadow shadow1 = shadow;
			this.Shadow_DefaultValue = shadow;
			this.Shadow = shadow1;
			nullable = new bool?(false);
			this.ShowCheckbox_DefaultValue = nullable;
			this.ShowCheckbox = nullable;
			nullable = new bool?(true);
			this.ShowInLegend_DefaultValue = nullable;
			this.ShowInLegend = nullable;
			int num3 = 0;
			PlotOptionsBubbleSizeBy plotOptionsBubbleSizeBy = (PlotOptionsBubbleSizeBy)num3;
			this.SizeBy_DefaultValue = (PlotOptionsBubbleSizeBy)num3;
			this.SizeBy = plotOptionsBubbleSizeBy;
			nullable = new bool?(false);
			this.SizeByAbsoluteValue_DefaultValue = nullable;
			this.SizeByAbsoluteValue = nullable;
			nullable = new bool?(false);
			this.SoftThreshold_DefaultValue = nullable;
			this.SoftThreshold = nullable;
			PlotOptionsBubbleStates plotOptionsBubbleState = new PlotOptionsBubbleStates();
			PlotOptionsBubbleStates plotOptionsBubbleState1 = plotOptionsBubbleState;
			this.States_DefaultValue = plotOptionsBubbleState;
			this.States = plotOptionsBubbleState1;
			nullable = new bool?(false);
			this.StickyTracking_DefaultValue = nullable;
			this.StickyTracking = nullable;
			nullable1 = new double?(0);
			this.Threshold_DefaultValue = nullable1;
			this.Threshold = nullable1;
			PlotOptionsBubbleTooltip plotOptionsBubbleTooltip = new PlotOptionsBubbleTooltip();
			PlotOptionsBubbleTooltip plotOptionsBubbleTooltip1 = plotOptionsBubbleTooltip;
			this.Tooltip_DefaultValue = plotOptionsBubbleTooltip;
			this.Tooltip = plotOptionsBubbleTooltip1;
			nullable = new bool?(true);
			this.Visible_DefaultValue = nullable;
			this.Visible = nullable;
			nullable1 = null;
			this.ZMax_DefaultValue = nullable1;
			this.ZMax = nullable1;
			nullable1 = null;
			this.ZMin_DefaultValue = nullable1;
			this.ZMin = nullable1;
			nullable1 = new double?(0);
			this.ZThreshold_DefaultValue = nullable1;
			this.ZThreshold = nullable1;
			string str7 = "y";
			str1 = str7;
			this.ZoneAxis_DefaultValue = str7;
			this.ZoneAxis = str1;
			PlotOptionsBubbleZones plotOptionsBubbleZone = new PlotOptionsBubbleZones();
			PlotOptionsBubbleZones plotOptionsBubbleZone1 = plotOptionsBubbleZone;
			this.Zones_DefaultValue = plotOptionsBubbleZone;
			this.Zones = plotOptionsBubbleZone1;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			bool? allowPointSelect = this.AllowPointSelect;
			bool? allowPointSelectDefaultValue = this.AllowPointSelect_DefaultValue;
			if ((allowPointSelect.GetValueOrDefault() == allowPointSelectDefaultValue.GetValueOrDefault() ? allowPointSelect.HasValue != allowPointSelectDefaultValue.HasValue : true))
			{
				hashtables.Add("allowPointSelect", this.AllowPointSelect);
			}
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
			animationLimit = this.CropThreshold;
			animationLimitDefaultValue = this.CropThreshold_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("cropThreshold", this.CropThreshold);
			}
			if (this.Cursor != this.Cursor_DefaultValue)
			{
				PlotOptionsBubbleCursor cursor = this.Cursor;
				hashtables.Add("cursor", Highcharts.FirstCharacterToLower(cursor.ToString()));
			}
			if (this.DashStyle != this.DashStyle_DefaultValue)
			{
				PlotOptionsBubbleDashStyle dashStyle = this.DashStyle;
				hashtables.Add("dashStyle", Highcharts.FirstCharacterToLower(dashStyle.ToString()));
			}
			if (this.DataLabels.IsDirty())
			{
				hashtables.Add("dataLabels", this.DataLabels.ToHashtable());
			}
			if (this.Description != this.Description_DefaultValue)
			{
				hashtables.Add("description", this.Description);
			}
			allowPointSelectDefaultValue = this.DisplayNegative;
			allowPointSelect = this.DisplayNegative_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault() ? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue : true))
			{
				hashtables.Add("displayNegative", this.DisplayNegative);
			}
			allowPointSelect = this.EnableMouseTracking;
			allowPointSelectDefaultValue = this.EnableMouseTracking_DefaultValue;
			if ((allowPointSelect.GetValueOrDefault() == allowPointSelectDefaultValue.GetValueOrDefault() ? allowPointSelect.HasValue != allowPointSelectDefaultValue.HasValue : true))
			{
				hashtables.Add("enableMouseTracking", this.EnableMouseTracking);
			}
			if (this.Events.IsDirty())
			{
				hashtables.Add("events", this.Events.ToHashtable());
			}
			allowPointSelectDefaultValue = this.GetExtremesFromAll;
			allowPointSelect = this.GetExtremesFromAll_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault() ? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue : true))
			{
				hashtables.Add("getExtremesFromAll", this.GetExtremesFromAll);
			}
			if (this.Keys != this.Keys_DefaultValue)
			{
				hashtables.Add("keys", this.Keys);
			}
			animationLimitDefaultValue = this.LineWidth;
			animationLimit = this.LineWidth_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("lineWidth", this.LineWidth);
			}
			if (this.LinkedTo != this.LinkedTo_DefaultValue)
			{
				hashtables.Add("linkedTo", this.LinkedTo);
			}
			if (this.Marker.IsDirty())
			{
				hashtables.Add("marker", this.Marker.ToHashtable());
			}
			if (this.MaxSize != this.MaxSize_DefaultValue)
			{
				hashtables.Add("maxSize", this.MaxSize);
			}
			if (this.MinSize != this.MinSize_DefaultValue)
			{
				hashtables.Add("minSize", this.MinSize);
			}
			if (this.NegativeColor != this.NegativeColor_DefaultValue)
			{
				hashtables.Add("negativeColor", this.NegativeColor);
			}
			if (this.Point.IsDirty())
			{
				hashtables.Add("point", this.Point.ToHashtable());
			}
			animationLimit = this.PointInterval;
			animationLimitDefaultValue = this.PointInterval_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("pointInterval", this.PointInterval);
			}
			if (this.PointIntervalUnit != this.PointIntervalUnit_DefaultValue)
			{
				PlotOptionsBubblePointIntervalUnit pointIntervalUnit = this.PointIntervalUnit;
				hashtables.Add("pointIntervalUnit", Highcharts.FirstCharacterToLower(pointIntervalUnit.ToString()));
			}
			animationLimitDefaultValue = this.PointStart;
			animationLimit = this.PointStart_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("pointStart", this.PointStart);
			}
			allowPointSelect = this.Selected;
			allowPointSelectDefaultValue = this.Selected_DefaultValue;
			if ((allowPointSelect.GetValueOrDefault() == allowPointSelectDefaultValue.GetValueOrDefault() ? allowPointSelect.HasValue != allowPointSelectDefaultValue.HasValue : true))
			{
				hashtables.Add("selected", this.Selected);
			}
			if (this.Shadow != this.Shadow_DefaultValue)
			{
				hashtables.Add("shadow", this.Shadow);
			}
			allowPointSelectDefaultValue = this.ShowCheckbox;
			allowPointSelect = this.ShowCheckbox_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault() ? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue : true))
			{
				hashtables.Add("showCheckbox", this.ShowCheckbox);
			}
			allowPointSelect = this.ShowInLegend;
			allowPointSelectDefaultValue = this.ShowInLegend_DefaultValue;
			if ((allowPointSelect.GetValueOrDefault() == allowPointSelectDefaultValue.GetValueOrDefault() ? allowPointSelect.HasValue != allowPointSelectDefaultValue.HasValue : true))
			{
				hashtables.Add("showInLegend", this.ShowInLegend);
			}
			if (this.SizeBy != this.SizeBy_DefaultValue)
			{
				PlotOptionsBubbleSizeBy sizeBy = this.SizeBy;
				hashtables.Add("sizeBy", Highcharts.FirstCharacterToLower(sizeBy.ToString()));
			}
			allowPointSelectDefaultValue = this.SizeByAbsoluteValue;
			allowPointSelect = this.SizeByAbsoluteValue_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault() ? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue : true))
			{
				hashtables.Add("sizeByAbsoluteValue", this.SizeByAbsoluteValue);
			}
			allowPointSelect = this.SoftThreshold;
			allowPointSelectDefaultValue = this.SoftThreshold_DefaultValue;
			if ((allowPointSelect.GetValueOrDefault() == allowPointSelectDefaultValue.GetValueOrDefault() ? allowPointSelect.HasValue != allowPointSelectDefaultValue.HasValue : true))
			{
				hashtables.Add("softThreshold", this.SoftThreshold);
			}
			if (this.States.IsDirty())
			{
				hashtables.Add("states", this.States.ToHashtable());
			}
			allowPointSelectDefaultValue = this.StickyTracking;
			allowPointSelect = this.StickyTracking_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault() ? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue : true))
			{
				hashtables.Add("stickyTracking", this.StickyTracking);
			}
			animationLimit = this.Threshold;
			animationLimitDefaultValue = this.Threshold_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("threshold", this.Threshold);
			}
			if (this.Tooltip.IsDirty())
			{
				hashtables.Add("tooltip", this.Tooltip.ToHashtable());
			}
			allowPointSelect = this.Visible;
			allowPointSelectDefaultValue = this.Visible_DefaultValue;
			if ((allowPointSelect.GetValueOrDefault() == allowPointSelectDefaultValue.GetValueOrDefault() ? allowPointSelect.HasValue != allowPointSelectDefaultValue.HasValue : true))
			{
				hashtables.Add("visible", this.Visible);
			}
			animationLimitDefaultValue = this.ZMax;
			animationLimit = this.ZMax_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("zMax", this.ZMax);
			}
			animationLimit = this.ZMin;
			animationLimitDefaultValue = this.ZMin_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("zMin", this.ZMin);
			}
			animationLimitDefaultValue = this.ZThreshold;
			animationLimit = this.ZThreshold_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("zThreshold", this.ZThreshold);
			}
			if (this.ZoneAxis != this.ZoneAxis_DefaultValue)
			{
				hashtables.Add("zoneAxis", this.ZoneAxis);
			}
			if (this.Zones.IsDirty())
			{
				hashtables.Add("zones", this.Zones.ToHashtable());
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