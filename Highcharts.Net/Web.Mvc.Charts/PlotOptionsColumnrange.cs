using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsColumnrange : BaseObject
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

		public double? BorderRadius
		{
			get;
			set;
		}

		private double? BorderRadius_DefaultValue
		{
			get;
			set;
		}

		public double? BorderWidth
		{
			get;
			set;
		}

		private double? BorderWidth_DefaultValue
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

		public PlotOptionsColumnrangeCursor Cursor
		{
			get;
			set;
		}

		private PlotOptionsColumnrangeCursor Cursor_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsColumnrangeDataLabels DataLabels
		{
			get;
			set;
		}

		private PlotOptionsColumnrangeDataLabels DataLabels_DefaultValue
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

		public PlotOptionsColumnrangeEvents Events
		{
			get;
			set;
		}

		private PlotOptionsColumnrangeEvents Events_DefaultValue
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

		public double? MinPointLength
		{
			get;
			set;
		}

		private double? MinPointLength_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsColumnrangePoint Point
		{
			get;
			set;
		}

		private PlotOptionsColumnrangePoint Point_DefaultValue
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

		public PlotOptionsColumnrangePointIntervalUnit PointIntervalUnit
		{
			get;
			set;
		}

		private PlotOptionsColumnrangePointIntervalUnit PointIntervalUnit_DefaultValue
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

		public PlotOptionsColumnrangeStates States
		{
			get;
			set;
		}

		private PlotOptionsColumnrangeStates States_DefaultValue
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

		public PlotOptionsColumnrangeTooltip Tooltip
		{
			get;
			set;
		}

		private PlotOptionsColumnrangeTooltip Tooltip_DefaultValue
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

		public PlotOptionsColumnrangeZones Zones
		{
			get;
			set;
		}

		private PlotOptionsColumnrangeZones Zones_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsColumnrange()
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
			string str = "#ffffff";
			string str1 = str;
			this.BorderColor_DefaultValue = str;
			this.BorderColor = str1;
			nullable1 = new double?(0);
			this.BorderRadius_DefaultValue = nullable1;
			this.BorderRadius = nullable1;
			nullable1 = new double?((double)1);
			this.BorderWidth_DefaultValue = nullable1;
			this.BorderWidth = nullable1;
			string str2 = "";
			str1 = str2;
			this.ClassName_DefaultValue = str2;
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
			nullable1 = new double?((double)50);
			this.CropThreshold_DefaultValue = nullable1;
			this.CropThreshold = nullable1;
			int num = 0;
			PlotOptionsColumnrangeCursor plotOptionsColumnrangeCursor = (PlotOptionsColumnrangeCursor)num;
			this.Cursor_DefaultValue = (PlotOptionsColumnrangeCursor)num;
			this.Cursor = plotOptionsColumnrangeCursor;
			PlotOptionsColumnrangeDataLabels plotOptionsColumnrangeDataLabel = new PlotOptionsColumnrangeDataLabels();
			PlotOptionsColumnrangeDataLabels plotOptionsColumnrangeDataLabel1 = plotOptionsColumnrangeDataLabel;
			this.DataLabels_DefaultValue = plotOptionsColumnrangeDataLabel;
			this.DataLabels = plotOptionsColumnrangeDataLabel1;
			nullable1 = new double?((double)25);
			this.Depth_DefaultValue = nullable1;
			this.Depth = nullable1;
			string str3 = "undefined";
			str1 = str3;
			this.Description_DefaultValue = str3;
			this.Description = str1;
			string str4 = "";
			str1 = str4;
			this.EdgeColor_DefaultValue = str4;
			this.EdgeColor = str1;
			nullable1 = new double?((double)1);
			this.EdgeWidth_DefaultValue = nullable1;
			this.EdgeWidth = nullable1;
			nullable = new bool?(true);
			this.EnableMouseTracking_DefaultValue = nullable;
			this.EnableMouseTracking = nullable;
			PlotOptionsColumnrangeEvents plotOptionsColumnrangeEvent = new PlotOptionsColumnrangeEvents();
			PlotOptionsColumnrangeEvents plotOptionsColumnrangeEvent1 = plotOptionsColumnrangeEvent;
			this.Events_DefaultValue = plotOptionsColumnrangeEvent;
			this.Events = plotOptionsColumnrangeEvent1;
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
			string str5 = "";
			str1 = str5;
			this.LinkedTo_DefaultValue = str5;
			this.LinkedTo = str1;
			nullable1 = null;
			this.MaxPointWidth_DefaultValue = nullable1;
			this.MaxPointWidth = nullable1;
			nullable1 = new double?(0);
			this.MinPointLength_DefaultValue = nullable1;
			this.MinPointLength = nullable1;
			PlotOptionsColumnrangePoint plotOptionsColumnrangePoint = new PlotOptionsColumnrangePoint();
			PlotOptionsColumnrangePoint plotOptionsColumnrangePoint1 = plotOptionsColumnrangePoint;
			this.Point_DefaultValue = plotOptionsColumnrangePoint;
			this.Point = plotOptionsColumnrangePoint1;
			nullable1 = new double?((double)1);
			this.PointInterval_DefaultValue = nullable1;
			this.PointInterval = nullable1;
			int num1 = 0;
			PlotOptionsColumnrangePointIntervalUnit plotOptionsColumnrangePointIntervalUnit = (PlotOptionsColumnrangePointIntervalUnit)num1;
			this.PointIntervalUnit_DefaultValue = (PlotOptionsColumnrangePointIntervalUnit)num1;
			this.PointIntervalUnit = plotOptionsColumnrangePointIntervalUnit;
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
			PlotOptionsColumnrangeStates plotOptionsColumnrangeState = new PlotOptionsColumnrangeStates();
			PlotOptionsColumnrangeStates plotOptionsColumnrangeState1 = plotOptionsColumnrangeState;
			this.States_DefaultValue = plotOptionsColumnrangeState;
			this.States = plotOptionsColumnrangeState1;
			nullable = new bool?(true);
			this.StickyTracking_DefaultValue = nullable;
			this.StickyTracking = nullable;
			PlotOptionsColumnrangeTooltip plotOptionsColumnrangeTooltip = new PlotOptionsColumnrangeTooltip();
			PlotOptionsColumnrangeTooltip plotOptionsColumnrangeTooltip1 = plotOptionsColumnrangeTooltip;
			this.Tooltip_DefaultValue = plotOptionsColumnrangeTooltip;
			this.Tooltip = plotOptionsColumnrangeTooltip1;
			nullable1 = new double?((double)1000);
			this.TurboThreshold_DefaultValue = nullable1;
			this.TurboThreshold = nullable1;
			nullable = new bool?(true);
			this.Visible_DefaultValue = nullable;
			this.Visible = nullable;
			string str6 = "y";
			str1 = str6;
			this.ZoneAxis_DefaultValue = str6;
			this.ZoneAxis = str1;
			PlotOptionsColumnrangeZones plotOptionsColumnrangeZone = new PlotOptionsColumnrangeZones();
			PlotOptionsColumnrangeZones plotOptionsColumnrangeZone1 = plotOptionsColumnrangeZone;
			this.Zones_DefaultValue = plotOptionsColumnrangeZone;
			this.Zones = plotOptionsColumnrangeZone1;
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
			if (this.BorderColor != this.BorderColor_DefaultValue)
			{
				hashtables.Add("borderColor", this.BorderColor);
			}
			animationLimitDefaultValue = this.BorderRadius;
			animationLimit = this.BorderRadius_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("borderRadius", this.BorderRadius);
			}
			animationLimit = this.BorderWidth;
			animationLimitDefaultValue = this.BorderWidth_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("borderWidth", this.BorderWidth);
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
			animationLimit = this.CropThreshold;
			animationLimitDefaultValue = this.CropThreshold_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("cropThreshold", this.CropThreshold);
			}
			if (this.Cursor != this.Cursor_DefaultValue)
			{
				PlotOptionsColumnrangeCursor cursor = this.Cursor;
				hashtables.Add("cursor", Highcharts.FirstCharacterToLower(cursor.ToString()));
			}
			if (this.DataLabels.IsDirty())
			{
				hashtables.Add("dataLabels", this.DataLabels.ToHashtable());
			}
			animationLimitDefaultValue = this.Depth;
			animationLimit = this.Depth_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
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
			animationLimit = this.EdgeWidth;
			animationLimitDefaultValue = this.EdgeWidth_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
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
			allowPointSelectDefaultValue = this.GetExtremesFromAll;
			allowPointSelect = this.GetExtremesFromAll_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault() ? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue : true))
			{
				hashtables.Add("getExtremesFromAll", this.GetExtremesFromAll);
			}
			animationLimitDefaultValue = this.GroupPadding;
			animationLimit = this.GroupPadding_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("groupPadding", this.GroupPadding);
			}
			animationLimit = this.GroupZPadding;
			animationLimitDefaultValue = this.GroupZPadding_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
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
			animationLimit = this.MinPointLength;
			animationLimitDefaultValue = this.MinPointLength_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("minPointLength", this.MinPointLength);
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
				PlotOptionsColumnrangePointIntervalUnit pointIntervalUnit = this.PointIntervalUnit;
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
			if (this.States.IsDirty())
			{
				hashtables.Add("states", this.States.ToHashtable());
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
			animationLimit = this.TurboThreshold;
			animationLimitDefaultValue = this.TurboThreshold_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
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