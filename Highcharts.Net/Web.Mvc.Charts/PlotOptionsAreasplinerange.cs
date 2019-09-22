using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsAreasplinerange : BaseObject
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

		public bool? ConnectNulls
		{
			get;
			set;
		}

		private bool? ConnectNulls_DefaultValue
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

		public PlotOptionsAreasplinerangeCursor Cursor
		{
			get;
			set;
		}

		private PlotOptionsAreasplinerangeCursor Cursor_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsAreasplinerangeDashStyle DashStyle
		{
			get;
			set;
		}

		private PlotOptionsAreasplinerangeDashStyle DashStyle_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsAreasplinerangeDataLabels DataLabels
		{
			get;
			set;
		}

		private PlotOptionsAreasplinerangeDataLabels DataLabels_DefaultValue
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

		public PlotOptionsAreasplinerangeEvents Events
		{
			get;
			set;
		}

		private PlotOptionsAreasplinerangeEvents Events_DefaultValue
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

		public double? FillOpacity
		{
			get;
			set;
		}

		private double? FillOpacity_DefaultValue
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

		public PlotOptionsAreasplinerangeLinecap Linecap
		{
			get;
			set;
		}

		private PlotOptionsAreasplinerangeLinecap Linecap_DefaultValue
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

		public string NegativeFillColor
		{
			get;
			set;
		}

		private string NegativeFillColor_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsAreasplinerangePoint Point
		{
			get;
			set;
		}

		private PlotOptionsAreasplinerangePoint Point_DefaultValue
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

		public PlotOptionsAreasplinerangePointIntervalUnit PointIntervalUnit
		{
			get;
			set;
		}

		private PlotOptionsAreasplinerangePointIntervalUnit PointIntervalUnit_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.PointPlacement PointPlacement
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.PointPlacement PointPlacement_DefaultValue
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

		public PlotOptionsAreasplinerangeStates States
		{
			get;
			set;
		}

		private PlotOptionsAreasplinerangeStates States_DefaultValue
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

		public PlotOptionsAreasplinerangeTooltip Tooltip
		{
			get;
			set;
		}

		private PlotOptionsAreasplinerangeTooltip Tooltip_DefaultValue
		{
			get;
			set;
		}

		public bool? TrackByArea
		{
			get;
			set;
		}

		private bool? TrackByArea_DefaultValue
		{
			get;
			set;
		}

		public double? TurboThreshold
		{
			get;
			set;
		}

		private double? TurboThreshold_DefaultValue
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

		public PlotOptionsAreasplinerangeZones Zones
		{
			get;
			set;
		}

		private PlotOptionsAreasplinerangeZones Zones_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsAreasplinerange()
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
			nullable = new bool?(false);
			this.ConnectNulls_DefaultValue = nullable;
			this.ConnectNulls = nullable;
			nullable1 = new double?((double)300);
			this.CropThreshold_DefaultValue = nullable1;
			this.CropThreshold = nullable1;
			int num = 0;
			PlotOptionsAreasplinerangeCursor plotOptionsAreasplinerangeCursor = (PlotOptionsAreasplinerangeCursor)num;
			this.Cursor_DefaultValue = (PlotOptionsAreasplinerangeCursor)num;
			this.Cursor = plotOptionsAreasplinerangeCursor;
			int num1 = 0;
			PlotOptionsAreasplinerangeDashStyle plotOptionsAreasplinerangeDashStyle = (PlotOptionsAreasplinerangeDashStyle)num1;
			this.DashStyle_DefaultValue = (PlotOptionsAreasplinerangeDashStyle)num1;
			this.DashStyle = plotOptionsAreasplinerangeDashStyle;
			PlotOptionsAreasplinerangeDataLabels plotOptionsAreasplinerangeDataLabel = new PlotOptionsAreasplinerangeDataLabels();
			PlotOptionsAreasplinerangeDataLabels plotOptionsAreasplinerangeDataLabel1 = plotOptionsAreasplinerangeDataLabel;
			this.DataLabels_DefaultValue = plotOptionsAreasplinerangeDataLabel;
			this.DataLabels = plotOptionsAreasplinerangeDataLabel1;
			string str2 = "undefined";
			str1 = str2;
			this.Description_DefaultValue = str2;
			this.Description = str1;
			nullable = new bool?(true);
			this.EnableMouseTracking_DefaultValue = nullable;
			this.EnableMouseTracking = nullable;
			PlotOptionsAreasplinerangeEvents plotOptionsAreasplinerangeEvent = new PlotOptionsAreasplinerangeEvents();
			PlotOptionsAreasplinerangeEvents plotOptionsAreasplinerangeEvent1 = plotOptionsAreasplinerangeEvent;
			this.Events_DefaultValue = plotOptionsAreasplinerangeEvent;
			this.Events = plotOptionsAreasplinerangeEvent1;
			object obj1 = null;
			object obj2 = obj1;
			this.FillColor_DefaultValue = obj1;
			this.FillColor = obj2;
			nullable1 = new double?(0.75);
			this.FillOpacity_DefaultValue = nullable1;
			this.FillOpacity = nullable1;
			nullable = new bool?(false);
			this.GetExtremesFromAll_DefaultValue = nullable;
			this.GetExtremesFromAll = nullable;
			List<string> strs = new List<string>();
			List<string> strs1 = strs;
			this.Keys_DefaultValue = strs;
			this.Keys = strs1;
			object obj3 = null;
			str1 = (string)obj3;
			this.LineColor_DefaultValue = (string)obj3;
			this.LineColor = str1;
			nullable1 = new double?((double)1);
			this.LineWidth_DefaultValue = nullable1;
			this.LineWidth = nullable1;
			int num2 = 0;
			PlotOptionsAreasplinerangeLinecap plotOptionsAreasplinerangeLinecap = (PlotOptionsAreasplinerangeLinecap)num2;
			this.Linecap_DefaultValue = (PlotOptionsAreasplinerangeLinecap)num2;
			this.Linecap = plotOptionsAreasplinerangeLinecap;
			string str3 = "";
			str1 = str3;
			this.LinkedTo_DefaultValue = str3;
			this.LinkedTo = str1;
			string str4 = "null";
			str1 = str4;
			this.NegativeColor_DefaultValue = str4;
			this.NegativeColor = str1;
			object obj4 = null;
			str1 = (string)obj4;
			this.NegativeFillColor_DefaultValue = (string)obj4;
			this.NegativeFillColor = str1;
			PlotOptionsAreasplinerangePoint plotOptionsAreasplinerangePoint = new PlotOptionsAreasplinerangePoint();
			PlotOptionsAreasplinerangePoint plotOptionsAreasplinerangePoint1 = plotOptionsAreasplinerangePoint;
			this.Point_DefaultValue = plotOptionsAreasplinerangePoint;
			this.Point = plotOptionsAreasplinerangePoint1;
			nullable1 = new double?((double)1);
			this.PointInterval_DefaultValue = nullable1;
			this.PointInterval = nullable1;
			int num3 = 0;
			PlotOptionsAreasplinerangePointIntervalUnit plotOptionsAreasplinerangePointIntervalUnit = (PlotOptionsAreasplinerangePointIntervalUnit)num3;
			this.PointIntervalUnit_DefaultValue = (PlotOptionsAreasplinerangePointIntervalUnit)num3;
			this.PointIntervalUnit = plotOptionsAreasplinerangePointIntervalUnit;
			Highsoft.Web.Mvc.Charts.PointPlacement pointPlacement = new Highsoft.Web.Mvc.Charts.PointPlacement();
			Highsoft.Web.Mvc.Charts.PointPlacement pointPlacement1 = pointPlacement;
			this.PointPlacement_DefaultValue = pointPlacement;
			this.PointPlacement = pointPlacement1;
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
			PlotOptionsAreasplinerangeStates plotOptionsAreasplinerangeState = new PlotOptionsAreasplinerangeStates();
			PlotOptionsAreasplinerangeStates plotOptionsAreasplinerangeState1 = plotOptionsAreasplinerangeState;
			this.States_DefaultValue = plotOptionsAreasplinerangeState;
			this.States = plotOptionsAreasplinerangeState1;
			nullable = new bool?(true);
			this.StickyTracking_DefaultValue = nullable;
			this.StickyTracking = nullable;
			PlotOptionsAreasplinerangeTooltip plotOptionsAreasplinerangeTooltip = new PlotOptionsAreasplinerangeTooltip();
			PlotOptionsAreasplinerangeTooltip plotOptionsAreasplinerangeTooltip1 = plotOptionsAreasplinerangeTooltip;
			this.Tooltip_DefaultValue = plotOptionsAreasplinerangeTooltip;
			this.Tooltip = plotOptionsAreasplinerangeTooltip1;
			nullable = new bool?(true);
			this.TrackByArea_DefaultValue = nullable;
			this.TrackByArea = nullable;
			nullable1 = new double?((double)1000);
			this.TurboThreshold_DefaultValue = nullable1;
			this.TurboThreshold = nullable1;
			nullable = new bool?(true);
			this.Visible_DefaultValue = nullable;
			this.Visible = nullable;
			string str5 = "y";
			str1 = str5;
			this.ZoneAxis_DefaultValue = str5;
			this.ZoneAxis = str1;
			PlotOptionsAreasplinerangeZones plotOptionsAreasplinerangeZone = new PlotOptionsAreasplinerangeZones();
			PlotOptionsAreasplinerangeZones plotOptionsAreasplinerangeZone1 = plotOptionsAreasplinerangeZone;
			this.Zones_DefaultValue = plotOptionsAreasplinerangeZone;
			this.Zones = plotOptionsAreasplinerangeZone1;
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
			allowPointSelectDefaultValue = this.ConnectNulls;
			allowPointSelect = this.ConnectNulls_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault() ? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue : true))
			{
				hashtables.Add("connectNulls", this.ConnectNulls);
			}
			animationLimit = this.CropThreshold;
			animationLimitDefaultValue = this.CropThreshold_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("cropThreshold", this.CropThreshold);
			}
			if (this.Cursor != this.Cursor_DefaultValue)
			{
				PlotOptionsAreasplinerangeCursor cursor = this.Cursor;
				hashtables.Add("cursor", Highcharts.FirstCharacterToLower(cursor.ToString()));
			}
			if (this.DashStyle != this.DashStyle_DefaultValue)
			{
				PlotOptionsAreasplinerangeDashStyle dashStyle = this.DashStyle;
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
			if (this.FillColor != this.FillColor_DefaultValue)
			{
				hashtables.Add("fillColor", this.FillColor);
			}
			animationLimitDefaultValue = this.FillOpacity;
			animationLimit = this.FillOpacity_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("fillOpacity", this.FillOpacity);
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
			if (this.LineColor != this.LineColor_DefaultValue)
			{
				hashtables.Add("lineColor", this.LineColor);
			}
			animationLimit = this.LineWidth;
			animationLimitDefaultValue = this.LineWidth_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("lineWidth", this.LineWidth);
			}
			if (this.Linecap != this.Linecap_DefaultValue)
			{
				PlotOptionsAreasplinerangeLinecap linecap = this.Linecap;
				hashtables.Add("linecap", Highcharts.FirstCharacterToLower(linecap.ToString()));
			}
			if (this.LinkedTo != this.LinkedTo_DefaultValue)
			{
				hashtables.Add("linkedTo", this.LinkedTo);
			}
			if (this.NegativeColor != this.NegativeColor_DefaultValue)
			{
				hashtables.Add("negativeColor", this.NegativeColor);
			}
			if (this.NegativeFillColor != this.NegativeFillColor_DefaultValue)
			{
				hashtables.Add("negativeFillColor", this.NegativeFillColor);
			}
			if (this.Point.IsDirty())
			{
				hashtables.Add("point", this.Point.ToHashtable());
			}
			animationLimitDefaultValue = this.PointInterval;
			animationLimit = this.PointInterval_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("pointInterval", this.PointInterval);
			}
			if (this.PointIntervalUnit != this.PointIntervalUnit_DefaultValue)
			{
				PlotOptionsAreasplinerangePointIntervalUnit pointIntervalUnit = this.PointIntervalUnit;
				hashtables.Add("pointIntervalUnit", Highcharts.FirstCharacterToLower(pointIntervalUnit.ToString()));
			}
			if (this.PointPlacement.IsDirty())
			{
				hashtables.Add("pointPlacement", this.PointPlacement.ToJSON());
			}
			animationLimit = this.PointStart;
			animationLimitDefaultValue = this.PointStart_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
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
			if (this.Tooltip.IsDirty())
			{
				hashtables.Add("tooltip", this.Tooltip.ToHashtable());
			}
			allowPointSelect = this.TrackByArea;
			allowPointSelectDefaultValue = this.TrackByArea_DefaultValue;
			if ((allowPointSelect.GetValueOrDefault() == allowPointSelectDefaultValue.GetValueOrDefault() ? allowPointSelect.HasValue != allowPointSelectDefaultValue.HasValue : true))
			{
				hashtables.Add("trackByArea", this.TrackByArea);
			}
			animationLimitDefaultValue = this.TurboThreshold;
			animationLimit = this.TurboThreshold_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("turboThreshold", this.TurboThreshold);
			}
			allowPointSelectDefaultValue = this.Visible;
			allowPointSelect = this.Visible_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault() ? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue : true))
			{
				hashtables.Add("visible", this.Visible);
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