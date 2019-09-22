using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsTreemap : BaseObject
	{
		public PlotOptionsTreemapAllowDrillToNode AllowDrillToNode
		{
			get;
			set;
		}

		private PlotOptionsTreemapAllowDrillToNode AllowDrillToNode_DefaultValue
		{
			get;
			set;
		}

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

		public bool? AlternateStartingDirection
		{
			get;
			set;
		}

		private bool? AlternateStartingDirection_DefaultValue
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

		public PlotOptionsTreemapCursor Cursor
		{
			get;
			set;
		}

		private PlotOptionsTreemapCursor Cursor_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsTreemapDataLabels DataLabels
		{
			get;
			set;
		}

		private PlotOptionsTreemapDataLabels DataLabels_DefaultValue
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

		public PlotOptionsTreemapEvents Events
		{
			get;
			set;
		}

		private PlotOptionsTreemapEvents Events_DefaultValue
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

		public bool? IgnoreHiddenPoint
		{
			get;
			set;
		}

		private bool? IgnoreHiddenPoint_DefaultValue
		{
			get;
			set;
		}

		public bool? InteractByLeaf
		{
			get;
			set;
		}

		private bool? InteractByLeaf_DefaultValue
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

		public PlotOptionsTreemapLayoutAlgorithm LayoutAlgorithm
		{
			get;
			set;
		}

		private PlotOptionsTreemapLayoutAlgorithm LayoutAlgorithm_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsTreemapLayoutStartingDirection LayoutStartingDirection
		{
			get;
			set;
		}

		private PlotOptionsTreemapLayoutStartingDirection LayoutStartingDirection_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsTreemapLevelIsConstant LevelIsConstant
		{
			get;
			set;
		}

		private PlotOptionsTreemapLevelIsConstant LevelIsConstant_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsTreemapLevels Levels
		{
			get;
			set;
		}

		private PlotOptionsTreemapLevels Levels_DefaultValue
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

		public double? Opacity
		{
			get;
			set;
		}

		private double? Opacity_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsTreemapPoint Point
		{
			get;
			set;
		}

		private PlotOptionsTreemapPoint Point_DefaultValue
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

		public double? SortIndex
		{
			get;
			set;
		}

		private double? SortIndex_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsTreemapStates States
		{
			get;
			set;
		}

		private PlotOptionsTreemapStates States_DefaultValue
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

		public PlotOptionsTreemapTooltip Tooltip
		{
			get;
			set;
		}

		private PlotOptionsTreemapTooltip Tooltip_DefaultValue
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

		public PlotOptionsTreemapZones Zones
		{
			get;
			set;
		}

		private PlotOptionsTreemapZones Zones_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsTreemap()
		{
			int num = 0;
			PlotOptionsTreemapAllowDrillToNode plotOptionsTreemapAllowDrillToNode = (PlotOptionsTreemapAllowDrillToNode)num;
			this.AllowDrillToNode_DefaultValue = (PlotOptionsTreemapAllowDrillToNode)num;
			this.AllowDrillToNode = plotOptionsTreemapAllowDrillToNode;
			bool? nullable = new bool?(false);
			this.AllowPointSelect_DefaultValue = nullable;
			this.AllowPointSelect = nullable;
			nullable = new bool?(false);
			this.AlternateStartingDirection_DefaultValue = nullable;
			this.AlternateStartingDirection = nullable;
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
			string str = "#e6e6e6";
			string str1 = str;
			this.BorderColor_DefaultValue = str;
			this.BorderColor = str1;
			nullable1 = new double?((double)1);
			this.BorderWidth_DefaultValue = nullable1;
			this.BorderWidth = nullable1;
			string str2 = "";
			str1 = str2;
			this.ClassName_DefaultValue = str2;
			this.ClassName = str1;
			string str3 = "null";
			str1 = str3;
			this.Color_DefaultValue = str3;
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
			nullable1 = new double?((double)300);
			this.CropThreshold_DefaultValue = nullable1;
			this.CropThreshold = nullable1;
			int num1 = 0;
			PlotOptionsTreemapCursor plotOptionsTreemapCursor = (PlotOptionsTreemapCursor)num1;
			this.Cursor_DefaultValue = (PlotOptionsTreemapCursor)num1;
			this.Cursor = plotOptionsTreemapCursor;
			PlotOptionsTreemapDataLabels plotOptionsTreemapDataLabel = new PlotOptionsTreemapDataLabels();
			PlotOptionsTreemapDataLabels plotOptionsTreemapDataLabel1 = plotOptionsTreemapDataLabel;
			this.DataLabels_DefaultValue = plotOptionsTreemapDataLabel;
			this.DataLabels = plotOptionsTreemapDataLabel1;
			string str4 = "undefined";
			str1 = str4;
			this.Description_DefaultValue = str4;
			this.Description = str1;
			nullable = new bool?(true);
			this.EnableMouseTracking_DefaultValue = nullable;
			this.EnableMouseTracking = nullable;
			PlotOptionsTreemapEvents plotOptionsTreemapEvent = new PlotOptionsTreemapEvents();
			PlotOptionsTreemapEvents plotOptionsTreemapEvent1 = plotOptionsTreemapEvent;
			this.Events_DefaultValue = plotOptionsTreemapEvent;
			this.Events = plotOptionsTreemapEvent1;
			nullable = new bool?(false);
			this.GetExtremesFromAll_DefaultValue = nullable;
			this.GetExtremesFromAll = nullable;
			nullable = new bool?(true);
			this.IgnoreHiddenPoint_DefaultValue = nullable;
			this.IgnoreHiddenPoint = nullable;
			nullable = null;
			this.InteractByLeaf_DefaultValue = nullable;
			this.InteractByLeaf = nullable;
			List<string> strs2 = new List<string>();
			strs1 = strs2;
			this.Keys_DefaultValue = strs2;
			this.Keys = strs1;
			int num2 = 0;
			PlotOptionsTreemapLayoutAlgorithm plotOptionsTreemapLayoutAlgorithm = (PlotOptionsTreemapLayoutAlgorithm)num2;
			this.LayoutAlgorithm_DefaultValue = (PlotOptionsTreemapLayoutAlgorithm)num2;
			this.LayoutAlgorithm = plotOptionsTreemapLayoutAlgorithm;
			int num3 = 0;
			PlotOptionsTreemapLayoutStartingDirection plotOptionsTreemapLayoutStartingDirection = (PlotOptionsTreemapLayoutStartingDirection)num3;
			this.LayoutStartingDirection_DefaultValue = (PlotOptionsTreemapLayoutStartingDirection)num3;
			this.LayoutStartingDirection = plotOptionsTreemapLayoutStartingDirection;
			int num4 = 0;
			PlotOptionsTreemapLevelIsConstant plotOptionsTreemapLevelIsConstant = (PlotOptionsTreemapLevelIsConstant)num4;
			this.LevelIsConstant_DefaultValue = (PlotOptionsTreemapLevelIsConstant)num4;
			this.LevelIsConstant = plotOptionsTreemapLevelIsConstant;
			PlotOptionsTreemapLevels plotOptionsTreemapLevel = new PlotOptionsTreemapLevels();
			PlotOptionsTreemapLevels plotOptionsTreemapLevel1 = plotOptionsTreemapLevel;
			this.Levels_DefaultValue = plotOptionsTreemapLevel;
			this.Levels = plotOptionsTreemapLevel1;
			string str5 = "";
			str1 = str5;
			this.LinkedTo_DefaultValue = str5;
			this.LinkedTo = str1;
			nullable1 = null;
			this.MaxPointWidth_DefaultValue = nullable1;
			this.MaxPointWidth = nullable1;
			nullable1 = new double?(0.15);
			this.Opacity_DefaultValue = nullable1;
			this.Opacity = nullable1;
			PlotOptionsTreemapPoint plotOptionsTreemapPoint = new PlotOptionsTreemapPoint();
			PlotOptionsTreemapPoint plotOptionsTreemapPoint1 = plotOptionsTreemapPoint;
			this.Point_DefaultValue = plotOptionsTreemapPoint;
			this.Point = plotOptionsTreemapPoint1;
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
			nullable = new bool?(false);
			this.ShowInLegend_DefaultValue = nullable;
			this.ShowInLegend = nullable;
			nullable1 = null;
			this.SortIndex_DefaultValue = nullable1;
			this.SortIndex = nullable1;
			PlotOptionsTreemapStates plotOptionsTreemapState = new PlotOptionsTreemapStates();
			PlotOptionsTreemapStates plotOptionsTreemapState1 = plotOptionsTreemapState;
			this.States_DefaultValue = plotOptionsTreemapState;
			this.States = plotOptionsTreemapState1;
			nullable = new bool?(true);
			this.StickyTracking_DefaultValue = nullable;
			this.StickyTracking = nullable;
			PlotOptionsTreemapTooltip plotOptionsTreemapTooltip = new PlotOptionsTreemapTooltip();
			PlotOptionsTreemapTooltip plotOptionsTreemapTooltip1 = plotOptionsTreemapTooltip;
			this.Tooltip_DefaultValue = plotOptionsTreemapTooltip;
			this.Tooltip = plotOptionsTreemapTooltip1;
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
			PlotOptionsTreemapZones plotOptionsTreemapZone = new PlotOptionsTreemapZones();
			PlotOptionsTreemapZones plotOptionsTreemapZone1 = plotOptionsTreemapZone;
			this.Zones_DefaultValue = plotOptionsTreemapZone;
			this.Zones = plotOptionsTreemapZone1;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.AllowDrillToNode != this.AllowDrillToNode_DefaultValue)
			{
				PlotOptionsTreemapAllowDrillToNode allowDrillToNode = this.AllowDrillToNode;
				hashtables.Add("allowDrillToNode", Highcharts.FirstCharacterToLower(allowDrillToNode.ToString()));
			}
			bool? allowPointSelect = this.AllowPointSelect;
			bool? allowPointSelectDefaultValue = this.AllowPointSelect_DefaultValue;
			if ((allowPointSelect.GetValueOrDefault() == allowPointSelectDefaultValue.GetValueOrDefault() ? allowPointSelect.HasValue != allowPointSelectDefaultValue.HasValue : true))
			{
				hashtables.Add("allowPointSelect", this.AllowPointSelect);
			}
			allowPointSelectDefaultValue = this.AlternateStartingDirection;
			allowPointSelect = this.AlternateStartingDirection_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault() ? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue : true))
			{
				hashtables.Add("alternateStartingDirection", this.AlternateStartingDirection);
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
			animationLimitDefaultValue = this.BorderWidth;
			animationLimit = this.BorderWidth_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
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
			allowPointSelect = this.ColorByPoint;
			allowPointSelectDefaultValue = this.ColorByPoint_DefaultValue;
			if ((allowPointSelect.GetValueOrDefault() == allowPointSelectDefaultValue.GetValueOrDefault() ? allowPointSelect.HasValue != allowPointSelectDefaultValue.HasValue : true))
			{
				hashtables.Add("colorByPoint", this.ColorByPoint);
			}
			animationLimit = this.ColorIndex;
			animationLimitDefaultValue = this.ColorIndex_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("colorIndex", this.ColorIndex);
			}
			if (this.Colors != this.Colors_DefaultValue)
			{
				hashtables.Add("colors", this.Colors);
			}
			animationLimitDefaultValue = this.CropThreshold;
			animationLimit = this.CropThreshold_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("cropThreshold", this.CropThreshold);
			}
			if (this.Cursor != this.Cursor_DefaultValue)
			{
				PlotOptionsTreemapCursor cursor = this.Cursor;
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
			allowPointSelectDefaultValue = this.IgnoreHiddenPoint;
			allowPointSelect = this.IgnoreHiddenPoint_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault() ? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue : true))
			{
				hashtables.Add("ignoreHiddenPoint", this.IgnoreHiddenPoint);
			}
			allowPointSelect = this.InteractByLeaf;
			allowPointSelectDefaultValue = this.InteractByLeaf_DefaultValue;
			if ((allowPointSelect.GetValueOrDefault() == allowPointSelectDefaultValue.GetValueOrDefault() ? allowPointSelect.HasValue != allowPointSelectDefaultValue.HasValue : true))
			{
				hashtables.Add("interactByLeaf", this.InteractByLeaf);
			}
			if (this.Keys != this.Keys_DefaultValue)
			{
				hashtables.Add("keys", this.Keys);
			}
			if (this.LayoutAlgorithm != this.LayoutAlgorithm_DefaultValue)
			{
				PlotOptionsTreemapLayoutAlgorithm layoutAlgorithm = this.LayoutAlgorithm;
				hashtables.Add("layoutAlgorithm", Highcharts.FirstCharacterToLower(layoutAlgorithm.ToString()));
			}
			if (this.LayoutStartingDirection != this.LayoutStartingDirection_DefaultValue)
			{
				PlotOptionsTreemapLayoutStartingDirection layoutStartingDirection = this.LayoutStartingDirection;
				hashtables.Add("layoutStartingDirection", Highcharts.FirstCharacterToLower(layoutStartingDirection.ToString()));
			}
			if (this.LevelIsConstant != this.LevelIsConstant_DefaultValue)
			{
				PlotOptionsTreemapLevelIsConstant levelIsConstant = this.LevelIsConstant;
				hashtables.Add("levelIsConstant", Highcharts.FirstCharacterToLower(levelIsConstant.ToString()));
			}
			if (this.Levels.IsDirty())
			{
				hashtables.Add("levels", this.Levels.ToHashtable());
			}
			if (this.LinkedTo != this.LinkedTo_DefaultValue)
			{
				hashtables.Add("linkedTo", this.LinkedTo);
			}
			animationLimit = this.MaxPointWidth;
			animationLimitDefaultValue = this.MaxPointWidth_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("maxPointWidth", this.MaxPointWidth);
			}
			animationLimitDefaultValue = this.Opacity;
			animationLimit = this.Opacity_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("opacity", this.Opacity);
			}
			if (this.Point.IsDirty())
			{
				hashtables.Add("point", this.Point.ToHashtable());
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
			animationLimit = this.SortIndex;
			animationLimitDefaultValue = this.SortIndex_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("sortIndex", this.SortIndex);
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