using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsBoxplot : BaseObject
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

		public bool? ColorByPoint
		{
			get;
			set;
		}

		private bool? ColorByPoint_DefaultValue
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

		public List<string> Colors
		{
			get;
			set;
		}

		private List<string> Colors_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsBoxplotCursor Cursor
		{
			get;
			set;
		}

		private PlotOptionsBoxplotCursor Cursor_DefaultValue
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

		public string EdgeColor
		{
			get;
			set;
		}

		private string EdgeColor_DefaultValue
		{
			get;
			set;
		}

		public double? EdgeWidth
		{
			get;
			set;
		}

		private double? EdgeWidth_DefaultValue
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

		public PlotOptionsBoxplotEvents Events
		{
			get;
			set;
		}

		private PlotOptionsBoxplotEvents Events_DefaultValue
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

		public bool? Grouping
		{
			get;
			set;
		}

		private bool? Grouping_DefaultValue
		{
			get;
			set;
		}

		public double? GroupPadding
		{
			get;
			set;
		}

		private double? GroupPadding_DefaultValue
		{
			get;
			set;
		}

		public double? GroupZPadding
		{
			get;
			set;
		}

		private double? GroupZPadding_DefaultValue
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

		public double? MaxPointWidth
		{
			get;
			set;
		}

		private double? MaxPointWidth_DefaultValue
		{
			get;
			set;
		}

		public string MedianColor
		{
			get;
			set;
		}

		private string MedianColor_DefaultValue
		{
			get;
			set;
		}

		public double? MedianWidth
		{
			get;
			set;
		}

		private double? MedianWidth_DefaultValue
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

		public PlotOptionsBoxplotPoint Point
		{
			get;
			set;
		}

		private PlotOptionsBoxplotPoint Point_DefaultValue
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

		public PlotOptionsBoxplotPointIntervalUnit PointIntervalUnit
		{
			get;
			set;
		}

		private PlotOptionsBoxplotPointIntervalUnit PointIntervalUnit_DefaultValue
		{
			get;
			set;
		}

		public double? PointPadding
		{
			get;
			set;
		}

		private double? PointPadding_DefaultValue
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

		public double? PointRange
		{
			get;
			set;
		}

		private double? PointRange_DefaultValue
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

		public double? PointWidth
		{
			get;
			set;
		}

		private double? PointWidth_DefaultValue
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

		public PlotOptionsBoxplotStates States
		{
			get;
			set;
		}

		private PlotOptionsBoxplotStates States_DefaultValue
		{
			get;
			set;
		}

		public string StemColor
		{
			get;
			set;
		}

		private string StemColor_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsBoxplotStemDashStyle StemDashStyle
		{
			get;
			set;
		}

		private PlotOptionsBoxplotStemDashStyle StemDashStyle_DefaultValue
		{
			get;
			set;
		}

		public double? StemWidth
		{
			get;
			set;
		}

		private double? StemWidth_DefaultValue
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

		public PlotOptionsBoxplotTooltip Tooltip
		{
			get;
			set;
		}

		private PlotOptionsBoxplotTooltip Tooltip_DefaultValue
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

		public string WhiskerColor
		{
			get;
			set;
		}

		private string WhiskerColor_DefaultValue
		{
			get;
			set;
		}

		public string WhiskerLength
		{
			get;
			set;
		}

		private string WhiskerLength_DefaultValue
		{
			get;
			set;
		}

		public double? WhiskerWidth
		{
			get;
			set;
		}

		private double? WhiskerWidth_DefaultValue
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

		public PlotOptionsBoxplotZones Zones
		{
			get;
			set;
		}

		private PlotOptionsBoxplotZones Zones_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsBoxplot()
		{
			bool? nullable = new bool?(false);
			this.AllowPointSelect_DefaultValue = nullable;
			this.AllowPointSelect = nullable;
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
			nullable = new bool?(false);
			this.ColorByPoint_DefaultValue = nullable;
			this.ColorByPoint = nullable;
			nullable1 = null;
			this.ColorIndex_DefaultValue = nullable1;
			this.ColorIndex = nullable1;
			List<string> strs = new List<string>();
			List<string> strs1 = strs;
			this.Colors_DefaultValue = strs;
			this.Colors = strs1;
			int num = 0;
			PlotOptionsBoxplotCursor plotOptionsBoxplotCursor = (PlotOptionsBoxplotCursor)num;
			this.Cursor_DefaultValue = (PlotOptionsBoxplotCursor)num;
			this.Cursor = plotOptionsBoxplotCursor;
			nullable1 = new double?((double)25);
			this.Depth_DefaultValue = nullable1;
			this.Depth = nullable1;
			string str2 = "undefined";
			str1 = str2;
			this.Description_DefaultValue = str2;
			this.Description = str1;
			string str3 = "";
			str1 = str3;
			this.EdgeColor_DefaultValue = str3;
			this.EdgeColor = str1;
			nullable1 = new double?((double)1);
			this.EdgeWidth_DefaultValue = nullable1;
			this.EdgeWidth = nullable1;
			nullable = new bool?(true);
			this.EnableMouseTracking_DefaultValue = nullable;
			this.EnableMouseTracking = nullable;
			PlotOptionsBoxplotEvents plotOptionsBoxplotEvent = new PlotOptionsBoxplotEvents();
			PlotOptionsBoxplotEvents plotOptionsBoxplotEvent1 = plotOptionsBoxplotEvent;
			this.Events_DefaultValue = plotOptionsBoxplotEvent;
			this.Events = plotOptionsBoxplotEvent1;
			object obj1 = null;
			object obj2 = obj1;
			this.FillColor_DefaultValue = obj1;
			this.FillColor = obj2;
			nullable = new bool?(false);
			this.GetExtremesFromAll_DefaultValue = nullable;
			this.GetExtremesFromAll = nullable;
			nullable1 = new double?(0.2);
			this.GroupPadding_DefaultValue = nullable1;
			this.GroupPadding = nullable1;
			nullable1 = new double?((double)1);
			this.GroupZPadding_DefaultValue = nullable1;
			this.GroupZPadding = nullable1;
			nullable = new bool?(true);
			this.Grouping_DefaultValue = nullable;
			this.Grouping = nullable;
			List<string> strs2 = new List<string>();
			strs1 = strs2;
			this.Keys_DefaultValue = strs2;
			this.Keys = strs1;
			nullable1 = new double?((double)1);
			this.LineWidth_DefaultValue = nullable1;
			this.LineWidth = nullable1;
			string str4 = "";
			str1 = str4;
			this.LinkedTo_DefaultValue = str4;
			this.LinkedTo = str1;
			nullable1 = null;
			this.MaxPointWidth_DefaultValue = nullable1;
			this.MaxPointWidth = nullable1;
			string str5 = "null";
			str1 = str5;
			this.MedianColor_DefaultValue = str5;
			this.MedianColor = str1;
			nullable1 = new double?((double)2);
			this.MedianWidth_DefaultValue = nullable1;
			this.MedianWidth = nullable1;
			string str6 = "null";
			str1 = str6;
			this.NegativeColor_DefaultValue = str6;
			this.NegativeColor = str1;
			PlotOptionsBoxplotPoint plotOptionsBoxplotPoint = new PlotOptionsBoxplotPoint();
			PlotOptionsBoxplotPoint plotOptionsBoxplotPoint1 = plotOptionsBoxplotPoint;
			this.Point_DefaultValue = plotOptionsBoxplotPoint;
			this.Point = plotOptionsBoxplotPoint1;
			nullable1 = new double?((double)1);
			this.PointInterval_DefaultValue = nullable1;
			this.PointInterval = nullable1;
			int num1 = 0;
			PlotOptionsBoxplotPointIntervalUnit plotOptionsBoxplotPointIntervalUnit = (PlotOptionsBoxplotPointIntervalUnit)num1;
			this.PointIntervalUnit_DefaultValue = (PlotOptionsBoxplotPointIntervalUnit)num1;
			this.PointIntervalUnit = plotOptionsBoxplotPointIntervalUnit;
			nullable1 = new double?(0.1);
			this.PointPadding_DefaultValue = nullable1;
			this.PointPadding = nullable1;
			Highsoft.Web.Mvc.Charts.PointPlacement pointPlacement = new Highsoft.Web.Mvc.Charts.PointPlacement();
			Highsoft.Web.Mvc.Charts.PointPlacement pointPlacement1 = pointPlacement;
			this.PointPlacement_DefaultValue = pointPlacement;
			this.PointPlacement = pointPlacement1;
			nullable1 = null;
			this.PointRange_DefaultValue = nullable1;
			this.PointRange = nullable1;
			nullable1 = new double?(0);
			this.PointStart_DefaultValue = nullable1;
			this.PointStart = nullable1;
			nullable1 = null;
			this.PointWidth_DefaultValue = nullable1;
			this.PointWidth = nullable1;
			nullable = new bool?(false);
			this.Selected_DefaultValue = nullable;
			this.Selected = nullable;
			nullable = new bool?(false);
			this.ShowCheckbox_DefaultValue = nullable;
			this.ShowCheckbox = nullable;
			nullable = new bool?(true);
			this.ShowInLegend_DefaultValue = nullable;
			this.ShowInLegend = nullable;
			PlotOptionsBoxplotStates plotOptionsBoxplotState = new PlotOptionsBoxplotStates();
			PlotOptionsBoxplotStates plotOptionsBoxplotState1 = plotOptionsBoxplotState;
			this.States_DefaultValue = plotOptionsBoxplotState;
			this.States = plotOptionsBoxplotState1;
			string str7 = "null";
			str1 = str7;
			this.StemColor_DefaultValue = str7;
			this.StemColor = str1;
			int num2 = 0;
			PlotOptionsBoxplotStemDashStyle plotOptionsBoxplotStemDashStyle = (PlotOptionsBoxplotStemDashStyle)num2;
			this.StemDashStyle_DefaultValue = (PlotOptionsBoxplotStemDashStyle)num2;
			this.StemDashStyle = plotOptionsBoxplotStemDashStyle;
			nullable1 = null;
			this.StemWidth_DefaultValue = nullable1;
			this.StemWidth = nullable1;
			nullable = new bool?(true);
			this.StickyTracking_DefaultValue = nullable;
			this.StickyTracking = nullable;
			PlotOptionsBoxplotTooltip plotOptionsBoxplotTooltip = new PlotOptionsBoxplotTooltip();
			PlotOptionsBoxplotTooltip plotOptionsBoxplotTooltip1 = plotOptionsBoxplotTooltip;
			this.Tooltip_DefaultValue = plotOptionsBoxplotTooltip;
			this.Tooltip = plotOptionsBoxplotTooltip1;
			nullable1 = new double?((double)1000);
			this.TurboThreshold_DefaultValue = nullable1;
			this.TurboThreshold = nullable1;
			nullable = new bool?(true);
			this.Visible_DefaultValue = nullable;
			this.Visible = nullable;
			string str8 = "null";
			str1 = str8;
			this.WhiskerColor_DefaultValue = str8;
			this.WhiskerColor = str1;
			string str9 = "50%";
			str1 = str9;
			this.WhiskerLength_DefaultValue = str9;
			this.WhiskerLength = str1;
			nullable1 = new double?((double)2);
			this.WhiskerWidth_DefaultValue = nullable1;
			this.WhiskerWidth = nullable1;
			string str10 = "y";
			str1 = str10;
			this.ZoneAxis_DefaultValue = str10;
			this.ZoneAxis = str1;
			PlotOptionsBoxplotZones plotOptionsBoxplotZone = new PlotOptionsBoxplotZones();
			PlotOptionsBoxplotZones plotOptionsBoxplotZone1 = plotOptionsBoxplotZone;
			this.Zones_DefaultValue = plotOptionsBoxplotZone;
			this.Zones = plotOptionsBoxplotZone1;
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
			allowPointSelectDefaultValue = this.ColorByPoint;
			allowPointSelect = this.ColorByPoint_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault() ? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue : true))
			{
				hashtables.Add("colorByPoint", this.ColorByPoint);
			}
			animationLimitDefaultValue = this.ColorIndex;
			animationLimit = this.ColorIndex_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("colorIndex", this.ColorIndex);
			}
			if (this.Colors != this.Colors_DefaultValue)
			{
				hashtables.Add("colors", this.Colors);
			}
			if (this.Cursor != this.Cursor_DefaultValue)
			{
				PlotOptionsBoxplotCursor cursor = this.Cursor;
				hashtables.Add("cursor", Highcharts.FirstCharacterToLower(cursor.ToString()));
			}
			animationLimit = this.Depth;
			animationLimitDefaultValue = this.Depth_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("depth", this.Depth);
			}
			if (this.Description != this.Description_DefaultValue)
			{
				hashtables.Add("description", this.Description);
			}
			if (this.EdgeColor != this.EdgeColor_DefaultValue)
			{
				hashtables.Add("edgeColor", this.EdgeColor);
			}
			animationLimitDefaultValue = this.EdgeWidth;
			animationLimit = this.EdgeWidth_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("edgeWidth", this.EdgeWidth);
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
			allowPointSelectDefaultValue = this.GetExtremesFromAll;
			allowPointSelect = this.GetExtremesFromAll_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault() ? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue : true))
			{
				hashtables.Add("getExtremesFromAll", this.GetExtremesFromAll);
			}
			animationLimit = this.GroupPadding;
			animationLimitDefaultValue = this.GroupPadding_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("groupPadding", this.GroupPadding);
			}
			animationLimitDefaultValue = this.GroupZPadding;
			animationLimit = this.GroupZPadding_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("groupZPadding", this.GroupZPadding);
			}
			allowPointSelect = this.Grouping;
			allowPointSelectDefaultValue = this.Grouping_DefaultValue;
			if ((allowPointSelect.GetValueOrDefault() == allowPointSelectDefaultValue.GetValueOrDefault() ? allowPointSelect.HasValue != allowPointSelectDefaultValue.HasValue : true))
			{
				hashtables.Add("grouping", this.Grouping);
			}
			if (this.Keys != this.Keys_DefaultValue)
			{
				hashtables.Add("keys", this.Keys);
			}
			animationLimit = this.LineWidth;
			animationLimitDefaultValue = this.LineWidth_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("lineWidth", this.LineWidth);
			}
			if (this.LinkedTo != this.LinkedTo_DefaultValue)
			{
				hashtables.Add("linkedTo", this.LinkedTo);
			}
			animationLimitDefaultValue = this.MaxPointWidth;
			animationLimit = this.MaxPointWidth_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("maxPointWidth", this.MaxPointWidth);
			}
			if (this.MedianColor != this.MedianColor_DefaultValue)
			{
				hashtables.Add("medianColor", this.MedianColor);
			}
			animationLimit = this.MedianWidth;
			animationLimitDefaultValue = this.MedianWidth_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("medianWidth", this.MedianWidth);
			}
			if (this.NegativeColor != this.NegativeColor_DefaultValue)
			{
				hashtables.Add("negativeColor", this.NegativeColor);
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
				PlotOptionsBoxplotPointIntervalUnit pointIntervalUnit = this.PointIntervalUnit;
				hashtables.Add("pointIntervalUnit", Highcharts.FirstCharacterToLower(pointIntervalUnit.ToString()));
			}
			animationLimit = this.PointPadding;
			animationLimitDefaultValue = this.PointPadding_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("pointPadding", this.PointPadding);
			}
			if (this.PointPlacement.IsDirty())
			{
				hashtables.Add("pointPlacement", this.PointPlacement.ToJSON());
			}
			animationLimitDefaultValue = this.PointRange;
			animationLimit = this.PointRange_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("pointRange", this.PointRange);
			}
			animationLimit = this.PointStart;
			animationLimitDefaultValue = this.PointStart_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("pointStart", this.PointStart);
			}
			animationLimitDefaultValue = this.PointWidth;
			animationLimit = this.PointWidth_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("pointWidth", this.PointWidth);
			}
			allowPointSelectDefaultValue = this.Selected;
			allowPointSelect = this.Selected_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault() ? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue : true))
			{
				hashtables.Add("selected", this.Selected);
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
			if (this.States.IsDirty())
			{
				hashtables.Add("states", this.States.ToHashtable());
			}
			if (this.StemColor != this.StemColor_DefaultValue)
			{
				hashtables.Add("stemColor", this.StemColor);
			}
			if (this.StemDashStyle != this.StemDashStyle_DefaultValue)
			{
				PlotOptionsBoxplotStemDashStyle stemDashStyle = this.StemDashStyle;
				hashtables.Add("stemDashStyle", Highcharts.FirstCharacterToLower(stemDashStyle.ToString()));
			}
			animationLimit = this.StemWidth;
			animationLimitDefaultValue = this.StemWidth_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("stemWidth", this.StemWidth);
			}
			allowPointSelect = this.StickyTracking;
			allowPointSelectDefaultValue = this.StickyTracking_DefaultValue;
			if ((allowPointSelect.GetValueOrDefault() == allowPointSelectDefaultValue.GetValueOrDefault() ? allowPointSelect.HasValue != allowPointSelectDefaultValue.HasValue : true))
			{
				hashtables.Add("stickyTracking", this.StickyTracking);
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
			allowPointSelectDefaultValue = this.Visible;
			allowPointSelect = this.Visible_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault() ? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue : true))
			{
				hashtables.Add("visible", this.Visible);
			}
			if (this.WhiskerColor != this.WhiskerColor_DefaultValue)
			{
				hashtables.Add("whiskerColor", this.WhiskerColor);
			}
			if (this.WhiskerLength != this.WhiskerLength_DefaultValue)
			{
				hashtables.Add("whiskerLength", this.WhiskerLength);
			}
			animationLimit = this.WhiskerWidth;
			animationLimitDefaultValue = this.WhiskerWidth_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("whiskerWidth", this.WhiskerWidth);
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