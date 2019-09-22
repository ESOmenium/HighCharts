using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class LineSeries : Series
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

		public bool? ConnectEnds
		{
			get;
			set;
		}

		private bool? ConnectEnds_DefaultValue
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

		public LineSeriesCursor Cursor
		{
			get;
			set;
		}

		private LineSeriesCursor Cursor_DefaultValue
		{
			get;
			set;
		}

		public LineSeriesDashStyle DashStyle
		{
			get;
			set;
		}

		private LineSeriesDashStyle DashStyle_DefaultValue
		{
			get;
			set;
		}

		public new List<LineSeriesData> Data
		{
			get;
			set;
		}

		private List<LineSeriesData> Data_DefaultValue
		{
			get;
			set;
		}

		public LineSeriesDataLabels DataLabels
		{
			get;
			set;
		}

		private LineSeriesDataLabels DataLabels_DefaultValue
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

		public LineSeriesEvents Events
		{
			get;
			set;
		}

		private LineSeriesEvents Events_DefaultValue
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

		public new string Id
		{
			get;
			set;
		}

		private string Id_DefaultValue
		{
			get;
			set;
		}

		public new double? Index
		{
			get;
			set;
		}

		private double? Index_DefaultValue
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

		public new double? LegendIndex
		{
			get;
			set;
		}

		private double? LegendIndex_DefaultValue
		{
			get;
			set;
		}

		public LineSeriesLinecap Linecap
		{
			get;
			set;
		}

		private LineSeriesLinecap Linecap_DefaultValue
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

		public LineSeriesMarker Marker
		{
			get;
			set;
		}

		private LineSeriesMarker Marker_DefaultValue
		{
			get;
			set;
		}

		public new string Name
		{
			get;
			set;
		}

		private string Name_DefaultValue
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

		public LineSeriesPoint Point
		{
			get;
			set;
		}

		private LineSeriesPoint Point_DefaultValue
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

		public LineSeriesPointIntervalUnit PointIntervalUnit
		{
			get;
			set;
		}

		private LineSeriesPointIntervalUnit PointIntervalUnit_DefaultValue
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

		public new string Stack
		{
			get;
			set;
		}

		private string Stack_DefaultValue
		{
			get;
			set;
		}

		public LineSeriesStacking Stacking
		{
			get;
			set;
		}

		private LineSeriesStacking Stacking_DefaultValue
		{
			get;
			set;
		}

		public LineSeriesStates States
		{
			get;
			set;
		}

		private LineSeriesStates States_DefaultValue
		{
			get;
			set;
		}

		public LineSeriesStep Step
		{
			get;
			set;
		}

		private LineSeriesStep Step_DefaultValue
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

		public LineSeriesTooltip Tooltip
		{
			get;
			set;
		}

		private LineSeriesTooltip Tooltip_DefaultValue
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

		public new LineSeriesType Type
		{
			get;
			set;
		}

		private LineSeriesType Type_DefaultValue
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

		public new string XAxis
		{
			get;
			set;
		}

		private string XAxis_DefaultValue
		{
			get;
			set;
		}

		public new string YAxis
		{
			get;
			set;
		}

		private string YAxis_DefaultValue
		{
			get;
			set;
		}

		public new double? ZIndex
		{
			get;
			set;
		}

		private double? ZIndex_DefaultValue
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

		public LineSeriesZones Zones
		{
			get;
			set;
		}

		private LineSeriesZones Zones_DefaultValue
		{
			get;
			set;
		}

		public LineSeries()
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
			nullable = new bool?(true);
			this.ConnectEnds_DefaultValue = nullable;
			this.ConnectEnds = nullable;
			nullable = new bool?(false);
			this.ConnectNulls_DefaultValue = nullable;
			this.ConnectNulls = nullable;
			nullable1 = new double?((double)300);
			this.CropThreshold_DefaultValue = nullable1;
			this.CropThreshold = nullable1;
			int num = 0;
			LineSeriesCursor lineSeriesCursor = (LineSeriesCursor)num;
			this.Cursor_DefaultValue = (LineSeriesCursor)num;
			this.Cursor = lineSeriesCursor;
			int num1 = 0;
			LineSeriesDashStyle lineSeriesDashStyle = (LineSeriesDashStyle)num1;
			this.DashStyle_DefaultValue = (LineSeriesDashStyle)num1;
			this.DashStyle = lineSeriesDashStyle;
			List<LineSeriesData> lineSeriesDatas = new List<LineSeriesData>();
			List<LineSeriesData> lineSeriesDatas1 = lineSeriesDatas;
			this.Data_DefaultValue = lineSeriesDatas;
			this.Data = lineSeriesDatas1;
			LineSeriesDataLabels lineSeriesDataLabel = new LineSeriesDataLabels();
			LineSeriesDataLabels lineSeriesDataLabel1 = lineSeriesDataLabel;
			this.DataLabels_DefaultValue = lineSeriesDataLabel;
			this.DataLabels = lineSeriesDataLabel1;
			string str2 = "undefined";
			str1 = str2;
			this.Description_DefaultValue = str2;
			this.Description = str1;
			nullable = new bool?(true);
			this.EnableMouseTracking_DefaultValue = nullable;
			this.EnableMouseTracking = nullable;
			LineSeriesEvents lineSeriesEvent = new LineSeriesEvents();
			LineSeriesEvents lineSeriesEvent1 = lineSeriesEvent;
			this.Events_DefaultValue = lineSeriesEvent;
			this.Events = lineSeriesEvent1;
			nullable = new bool?(false);
			this.GetExtremesFromAll_DefaultValue = nullable;
			this.GetExtremesFromAll = nullable;
			string str3 = "";
			str1 = str3;
			this.Id_DefaultValue = str3;
			this.Id = str1;
			nullable1 = null;
			this.Index_DefaultValue = nullable1;
			this.Index = nullable1;
			List<string> strs = new List<string>();
			List<string> strs1 = strs;
			this.Keys_DefaultValue = strs;
			this.Keys = strs1;
			nullable1 = null;
			this.LegendIndex_DefaultValue = nullable1;
			this.LegendIndex = nullable1;
			nullable1 = new double?((double)2);
			this.LineWidth_DefaultValue = nullable1;
			this.LineWidth = nullable1;
			int num2 = 0;
			LineSeriesLinecap lineSeriesLinecap = (LineSeriesLinecap)num2;
			this.Linecap_DefaultValue = (LineSeriesLinecap)num2;
			this.Linecap = lineSeriesLinecap;
			string str4 = "";
			str1 = str4;
			this.LinkedTo_DefaultValue = str4;
			this.LinkedTo = str1;
			LineSeriesMarker lineSeriesMarker = new LineSeriesMarker();
			LineSeriesMarker lineSeriesMarker1 = lineSeriesMarker;
			this.Marker_DefaultValue = lineSeriesMarker;
			this.Marker = lineSeriesMarker1;
			object obj1 = null;
			str1 = (string)obj1;
			this.Name_DefaultValue = (string)obj1;
			this.Name = str1;
			string str5 = "null";
			str1 = str5;
			this.NegativeColor_DefaultValue = str5;
			this.NegativeColor = str1;
			LineSeriesPoint lineSeriesPoint = new LineSeriesPoint();
			LineSeriesPoint lineSeriesPoint1 = lineSeriesPoint;
			this.Point_DefaultValue = lineSeriesPoint;
			this.Point = lineSeriesPoint1;
			nullable1 = new double?((double)1);
			this.PointInterval_DefaultValue = nullable1;
			this.PointInterval = nullable1;
			int num3 = 0;
			LineSeriesPointIntervalUnit lineSeriesPointIntervalUnit = (LineSeriesPointIntervalUnit)num3;
			this.PointIntervalUnit_DefaultValue = (LineSeriesPointIntervalUnit)num3;
			this.PointIntervalUnit = lineSeriesPointIntervalUnit;
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
			nullable = new bool?(true);
			this.SoftThreshold_DefaultValue = nullable;
			this.SoftThreshold = nullable;
			object obj2 = null;
			str1 = (string)obj2;
			this.Stack_DefaultValue = (string)obj2;
			this.Stack = str1;
			int num4 = 0;
			LineSeriesStacking lineSeriesStacking = (LineSeriesStacking)num4;
			this.Stacking_DefaultValue = (LineSeriesStacking)num4;
			this.Stacking = lineSeriesStacking;
			LineSeriesStates lineSeriesState = new LineSeriesStates();
			LineSeriesStates lineSeriesState1 = lineSeriesState;
			this.States_DefaultValue = lineSeriesState;
			this.States = lineSeriesState1;
			int num5 = 0;
			LineSeriesStep lineSeriesStep = (LineSeriesStep)num5;
			this.Step_DefaultValue = (LineSeriesStep)num5;
			this.Step = lineSeriesStep;
			nullable = new bool?(true);
			this.StickyTracking_DefaultValue = nullable;
			this.StickyTracking = nullable;
			nullable1 = new double?(0);
			this.Threshold_DefaultValue = nullable1;
			this.Threshold = nullable1;
			LineSeriesTooltip lineSeriesTooltip = new LineSeriesTooltip();
			LineSeriesTooltip lineSeriesTooltip1 = lineSeriesTooltip;
			this.Tooltip_DefaultValue = lineSeriesTooltip;
			this.Tooltip = lineSeriesTooltip1;
			nullable1 = new double?((double)1000);
			this.TurboThreshold_DefaultValue = nullable1;
			this.TurboThreshold = nullable1;
			int num6 = 0;
			LineSeriesType lineSeriesType = (LineSeriesType)num6;
			this.Type_DefaultValue = (LineSeriesType)num6;
			this.Type = lineSeriesType;
			nullable = new bool?(true);
			this.Visible_DefaultValue = nullable;
			this.Visible = nullable;
			string str6 = "0";
			str1 = str6;
			this.XAxis_DefaultValue = str6;
			this.XAxis = str1;
			string str7 = "0";
			str1 = str7;
			this.YAxis_DefaultValue = str7;
			this.YAxis = str1;
			nullable1 = null;
			this.ZIndex_DefaultValue = nullable1;
			this.ZIndex = nullable1;
			string str8 = "y";
			str1 = str8;
			this.ZoneAxis_DefaultValue = str8;
			this.ZoneAxis = str1;
			LineSeriesZones lineSeriesZone = new LineSeriesZones();
			LineSeriesZones lineSeriesZone1 = lineSeriesZone;
			this.Zones_DefaultValue = lineSeriesZone;
			this.Zones = lineSeriesZone1;
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
			allowPointSelectDefaultValue = this.ConnectEnds;
			allowPointSelect = this.ConnectEnds_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault() ? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue : true))
			{
				hashtables.Add("connectEnds", this.ConnectEnds);
			}
			allowPointSelect = this.ConnectNulls;
			allowPointSelectDefaultValue = this.ConnectNulls_DefaultValue;
			if ((allowPointSelect.GetValueOrDefault() == allowPointSelectDefaultValue.GetValueOrDefault() ? allowPointSelect.HasValue != allowPointSelectDefaultValue.HasValue : true))
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
				LineSeriesCursor cursor = this.Cursor;
				hashtables.Add("cursor", Highcharts.FirstCharacterToLower(cursor.ToString()));
			}
			if (this.DashStyle != this.DashStyle_DefaultValue)
			{
				LineSeriesDashStyle dashStyle = this.DashStyle;
				hashtables.Add("dashStyle", Highcharts.FirstCharacterToLower(dashStyle.ToString()));
			}
			if (this.Data.Any<LineSeriesData>())
			{
				hashtables.Add("data", base.HashifyList(this.Data));
			}
			if (this.DataLabels.IsDirty())
			{
				hashtables.Add("dataLabels", this.DataLabels.ToHashtable());
			}
			if (this.Description != this.Description_DefaultValue)
			{
				hashtables.Add("description", this.Description);
			}
			allowPointSelectDefaultValue = this.EnableMouseTracking;
			allowPointSelect = this.EnableMouseTracking_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault() ? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue : true))
			{
				hashtables.Add("enableMouseTracking", this.EnableMouseTracking);
			}
			if (this.Events.IsDirty())
			{
				hashtables.Add("events", this.Events.ToHashtable());
			}
			allowPointSelect = this.GetExtremesFromAll;
			allowPointSelectDefaultValue = this.GetExtremesFromAll_DefaultValue;
			if ((allowPointSelect.GetValueOrDefault() == allowPointSelectDefaultValue.GetValueOrDefault() ? allowPointSelect.HasValue != allowPointSelectDefaultValue.HasValue : true))
			{
				hashtables.Add("getExtremesFromAll", this.GetExtremesFromAll);
			}
			if (this.Id != this.Id_DefaultValue)
			{
				hashtables.Add("id", this.Id);
			}
			animationLimitDefaultValue = this.Index;
			animationLimit = this.Index_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("index", this.Index);
			}
			if (this.Keys != this.Keys_DefaultValue)
			{
				hashtables.Add("keys", this.Keys);
			}
			animationLimit = this.LegendIndex;
			animationLimitDefaultValue = this.LegendIndex_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("legendIndex", this.LegendIndex);
			}
			animationLimitDefaultValue = this.LineWidth;
			animationLimit = this.LineWidth_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("lineWidth", this.LineWidth);
			}
			if (this.Linecap != this.Linecap_DefaultValue)
			{
				LineSeriesLinecap linecap = this.Linecap;
				hashtables.Add("linecap", Highcharts.FirstCharacterToLower(linecap.ToString()));
			}
			if (this.LinkedTo != this.LinkedTo_DefaultValue)
			{
				hashtables.Add("linkedTo", this.LinkedTo);
			}
			if (this.Marker.IsDirty())
			{
				hashtables.Add("marker", this.Marker.ToHashtable());
			}
			if (this.Name != this.Name_DefaultValue)
			{
				hashtables.Add("name", this.Name);
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
				LineSeriesPointIntervalUnit pointIntervalUnit = this.PointIntervalUnit;
				hashtables.Add("pointIntervalUnit", Highcharts.FirstCharacterToLower(pointIntervalUnit.ToString()));
			}
			if (this.PointPlacement.IsDirty())
			{
				hashtables.Add("pointPlacement", this.PointPlacement.ToJSON());
			}
			animationLimitDefaultValue = this.PointStart;
			animationLimit = this.PointStart_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("pointStart", this.PointStart);
			}
			allowPointSelectDefaultValue = this.Selected;
			allowPointSelect = this.Selected_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault() ? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue : true))
			{
				hashtables.Add("selected", this.Selected);
			}
			if (this.Shadow != this.Shadow_DefaultValue)
			{
				hashtables.Add("shadow", this.Shadow);
			}
			allowPointSelect = this.ShowCheckbox;
			allowPointSelectDefaultValue = this.ShowCheckbox_DefaultValue;
			if ((allowPointSelect.GetValueOrDefault() == allowPointSelectDefaultValue.GetValueOrDefault() ? allowPointSelect.HasValue != allowPointSelectDefaultValue.HasValue : true))
			{
				hashtables.Add("showCheckbox", this.ShowCheckbox);
			}
			allowPointSelectDefaultValue = this.ShowInLegend;
			allowPointSelect = this.ShowInLegend_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault() ? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue : true))
			{
				hashtables.Add("showInLegend", this.ShowInLegend);
			}
			allowPointSelect = this.SoftThreshold;
			allowPointSelectDefaultValue = this.SoftThreshold_DefaultValue;
			if ((allowPointSelect.GetValueOrDefault() == allowPointSelectDefaultValue.GetValueOrDefault() ? allowPointSelect.HasValue != allowPointSelectDefaultValue.HasValue : true))
			{
				hashtables.Add("softThreshold", this.SoftThreshold);
			}
			if (this.Stack != this.Stack_DefaultValue)
			{
				hashtables.Add("stack", this.Stack);
			}
			if (this.Stacking != this.Stacking_DefaultValue)
			{
				LineSeriesStacking stacking = this.Stacking;
				hashtables.Add("stacking", Highcharts.FirstCharacterToLower(stacking.ToString()));
			}
			if (this.States.IsDirty())
			{
				hashtables.Add("states", this.States.ToHashtable());
			}
			if (this.Step != this.Step_DefaultValue)
			{
				LineSeriesStep step = this.Step;
				hashtables.Add("step", Highcharts.FirstCharacterToLower(step.ToString()));
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
			animationLimitDefaultValue = this.TurboThreshold;
			animationLimit = this.TurboThreshold_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("turboThreshold", this.TurboThreshold);
			}
			if (this.Type != this.Type_DefaultValue)
			{
				LineSeriesType type = this.Type;
				hashtables.Add("type", Highcharts.FirstCharacterToLower(type.ToString()));
			}
			allowPointSelect = this.Visible;
			allowPointSelectDefaultValue = this.Visible_DefaultValue;
			if ((allowPointSelect.GetValueOrDefault() == allowPointSelectDefaultValue.GetValueOrDefault() ? allowPointSelect.HasValue != allowPointSelectDefaultValue.HasValue : true))
			{
				hashtables.Add("visible", this.Visible);
			}
			if (this.XAxis != this.XAxis_DefaultValue)
			{
				hashtables.Add("xAxis", this.XAxis);
			}
			if (this.YAxis != this.YAxis_DefaultValue)
			{
				hashtables.Add("yAxis", this.YAxis);
			}
			animationLimit = this.ZIndex;
			animationLimitDefaultValue = this.ZIndex_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("zIndex", this.ZIndex);
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