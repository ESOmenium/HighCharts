using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class TreemapSeries : Series
	{
		public TreemapSeriesAllowDrillToNode AllowDrillToNode
		{
			get;
			set;
		}

		private TreemapSeriesAllowDrillToNode AllowDrillToNode_DefaultValue
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

		public TreemapSeriesCursor Cursor
		{
			get;
			set;
		}

		private TreemapSeriesCursor Cursor_DefaultValue
		{
			get;
			set;
		}

		public new List<TreemapSeriesData> Data
		{
			get;
			set;
		}

		private List<TreemapSeriesData> Data_DefaultValue
		{
			get;
			set;
		}

		public TreemapSeriesDataLabels DataLabels
		{
			get;
			set;
		}

		private TreemapSeriesDataLabels DataLabels_DefaultValue
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

		public TreemapSeriesEvents Events
		{
			get;
			set;
		}

		private TreemapSeriesEvents Events_DefaultValue
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

		public TreemapSeriesLayoutAlgorithm LayoutAlgorithm
		{
			get;
			set;
		}

		private TreemapSeriesLayoutAlgorithm LayoutAlgorithm_DefaultValue
		{
			get;
			set;
		}

		public TreemapSeriesLayoutStartingDirection LayoutStartingDirection
		{
			get;
			set;
		}

		private TreemapSeriesLayoutStartingDirection LayoutStartingDirection_DefaultValue
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

		public TreemapSeriesLevelIsConstant LevelIsConstant
		{
			get;
			set;
		}

		private TreemapSeriesLevelIsConstant LevelIsConstant_DefaultValue
		{
			get;
			set;
		}

		public List<TreemapSeriesLevels> Levels
		{
			get;
			set;
		}

		private List<TreemapSeriesLevels> Levels_DefaultValue
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

		public TreemapSeriesPoint Point
		{
			get;
			set;
		}

		private TreemapSeriesPoint Point_DefaultValue
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

		public TreemapSeriesStates States
		{
			get;
			set;
		}

		private TreemapSeriesStates States_DefaultValue
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

		public TreemapSeriesTooltip Tooltip
		{
			get;
			set;
		}

		private TreemapSeriesTooltip Tooltip_DefaultValue
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

		public new TreemapSeriesType Type
		{
			get;
			set;
		}

		private TreemapSeriesType Type_DefaultValue
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

		public TreemapSeriesZones Zones
		{
			get;
			set;
		}

		private TreemapSeriesZones Zones_DefaultValue
		{
			get;
			set;
		}

		public TreemapSeries()
		{
			int num = 0;
			TreemapSeriesAllowDrillToNode treemapSeriesAllowDrillToNode = (TreemapSeriesAllowDrillToNode)num;
			this.AllowDrillToNode_DefaultValue = (TreemapSeriesAllowDrillToNode)num;
			this.AllowDrillToNode = treemapSeriesAllowDrillToNode;
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
			TreemapSeriesCursor treemapSeriesCursor = (TreemapSeriesCursor)num1;
			this.Cursor_DefaultValue = (TreemapSeriesCursor)num1;
			this.Cursor = treemapSeriesCursor;
			List<TreemapSeriesData> treemapSeriesDatas = new List<TreemapSeriesData>();
			List<TreemapSeriesData> treemapSeriesDatas1 = treemapSeriesDatas;
			this.Data_DefaultValue = treemapSeriesDatas;
			this.Data = treemapSeriesDatas1;
			TreemapSeriesDataLabels treemapSeriesDataLabel = new TreemapSeriesDataLabels();
			TreemapSeriesDataLabels treemapSeriesDataLabel1 = treemapSeriesDataLabel;
			this.DataLabels_DefaultValue = treemapSeriesDataLabel;
			this.DataLabels = treemapSeriesDataLabel1;
			string str4 = "undefined";
			str1 = str4;
			this.Description_DefaultValue = str4;
			this.Description = str1;
			nullable = new bool?(true);
			this.EnableMouseTracking_DefaultValue = nullable;
			this.EnableMouseTracking = nullable;
			TreemapSeriesEvents treemapSeriesEvent = new TreemapSeriesEvents();
			TreemapSeriesEvents treemapSeriesEvent1 = treemapSeriesEvent;
			this.Events_DefaultValue = treemapSeriesEvent;
			this.Events = treemapSeriesEvent1;
			nullable = new bool?(false);
			this.GetExtremesFromAll_DefaultValue = nullable;
			this.GetExtremesFromAll = nullable;
			string str5 = "";
			str1 = str5;
			this.Id_DefaultValue = str5;
			this.Id = str1;
			nullable = new bool?(true);
			this.IgnoreHiddenPoint_DefaultValue = nullable;
			this.IgnoreHiddenPoint = nullable;
			nullable1 = null;
			this.Index_DefaultValue = nullable1;
			this.Index = nullable1;
			nullable = null;
			this.InteractByLeaf_DefaultValue = nullable;
			this.InteractByLeaf = nullable;
			List<string> strs2 = new List<string>();
			strs1 = strs2;
			this.Keys_DefaultValue = strs2;
			this.Keys = strs1;
			int num2 = 0;
			TreemapSeriesLayoutAlgorithm treemapSeriesLayoutAlgorithm = (TreemapSeriesLayoutAlgorithm)num2;
			this.LayoutAlgorithm_DefaultValue = (TreemapSeriesLayoutAlgorithm)num2;
			this.LayoutAlgorithm = treemapSeriesLayoutAlgorithm;
			int num3 = 0;
			TreemapSeriesLayoutStartingDirection treemapSeriesLayoutStartingDirection = (TreemapSeriesLayoutStartingDirection)num3;
			this.LayoutStartingDirection_DefaultValue = (TreemapSeriesLayoutStartingDirection)num3;
			this.LayoutStartingDirection = treemapSeriesLayoutStartingDirection;
			nullable1 = null;
			this.LegendIndex_DefaultValue = nullable1;
			this.LegendIndex = nullable1;
			int num4 = 0;
			TreemapSeriesLevelIsConstant treemapSeriesLevelIsConstant = (TreemapSeriesLevelIsConstant)num4;
			this.LevelIsConstant_DefaultValue = (TreemapSeriesLevelIsConstant)num4;
			this.LevelIsConstant = treemapSeriesLevelIsConstant;
			List<TreemapSeriesLevels> treemapSeriesLevels = new List<TreemapSeriesLevels>();
			List<TreemapSeriesLevels> treemapSeriesLevels1 = treemapSeriesLevels;
			this.Levels_DefaultValue = treemapSeriesLevels;
			this.Levels = treemapSeriesLevels1;
			string str6 = "";
			str1 = str6;
			this.LinkedTo_DefaultValue = str6;
			this.LinkedTo = str1;
			nullable1 = null;
			this.MaxPointWidth_DefaultValue = nullable1;
			this.MaxPointWidth = nullable1;
			object obj = null;
			str1 = (string)obj;
			this.Name_DefaultValue = (string)obj;
			this.Name = str1;
			nullable1 = new double?(0.15);
			this.Opacity_DefaultValue = nullable1;
			this.Opacity = nullable1;
			TreemapSeriesPoint treemapSeriesPoint = new TreemapSeriesPoint();
			TreemapSeriesPoint treemapSeriesPoint1 = treemapSeriesPoint;
			this.Point_DefaultValue = treemapSeriesPoint;
			this.Point = treemapSeriesPoint1;
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
			TreemapSeriesStates treemapSeriesState = new TreemapSeriesStates();
			TreemapSeriesStates treemapSeriesState1 = treemapSeriesState;
			this.States_DefaultValue = treemapSeriesState;
			this.States = treemapSeriesState1;
			nullable = new bool?(true);
			this.StickyTracking_DefaultValue = nullable;
			this.StickyTracking = nullable;
			TreemapSeriesTooltip treemapSeriesTooltip = new TreemapSeriesTooltip();
			TreemapSeriesTooltip treemapSeriesTooltip1 = treemapSeriesTooltip;
			this.Tooltip_DefaultValue = treemapSeriesTooltip;
			this.Tooltip = treemapSeriesTooltip1;
			nullable1 = new double?((double)1000);
			this.TurboThreshold_DefaultValue = nullable1;
			this.TurboThreshold = nullable1;
			int num5 = 0;
			TreemapSeriesType treemapSeriesType = (TreemapSeriesType)num5;
			this.Type_DefaultValue = (TreemapSeriesType)num5;
			this.Type = treemapSeriesType;
			nullable = new bool?(true);
			this.Visible_DefaultValue = nullable;
			this.Visible = nullable;
			string str7 = "0";
			str1 = str7;
			this.XAxis_DefaultValue = str7;
			this.XAxis = str1;
			string str8 = "0";
			str1 = str8;
			this.YAxis_DefaultValue = str8;
			this.YAxis = str1;
			nullable1 = null;
			this.ZIndex_DefaultValue = nullable1;
			this.ZIndex = nullable1;
			string str9 = "y";
			str1 = str9;
			this.ZoneAxis_DefaultValue = str9;
			this.ZoneAxis = str1;
			TreemapSeriesZones treemapSeriesZone = new TreemapSeriesZones();
			TreemapSeriesZones treemapSeriesZone1 = treemapSeriesZone;
			this.Zones_DefaultValue = treemapSeriesZone;
			this.Zones = treemapSeriesZone1;
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
				TreemapSeriesAllowDrillToNode allowDrillToNode = this.AllowDrillToNode;
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
				TreemapSeriesCursor cursor = this.Cursor;
				hashtables.Add("cursor", Highcharts.FirstCharacterToLower(cursor.ToString()));
			}
			if (this.Data.Any<TreemapSeriesData>())
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
			allowPointSelectDefaultValue = this.IgnoreHiddenPoint;
			allowPointSelect = this.IgnoreHiddenPoint_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault() ? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue : true))
			{
				hashtables.Add("ignoreHiddenPoint", this.IgnoreHiddenPoint);
			}
			animationLimit = this.Index;
			animationLimitDefaultValue = this.Index_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("index", this.Index);
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
				TreemapSeriesLayoutAlgorithm layoutAlgorithm = this.LayoutAlgorithm;
				hashtables.Add("layoutAlgorithm", Highcharts.FirstCharacterToLower(layoutAlgorithm.ToString()));
			}
			if (this.LayoutStartingDirection != this.LayoutStartingDirection_DefaultValue)
			{
				TreemapSeriesLayoutStartingDirection layoutStartingDirection = this.LayoutStartingDirection;
				hashtables.Add("layoutStartingDirection", Highcharts.FirstCharacterToLower(layoutStartingDirection.ToString()));
			}
			animationLimitDefaultValue = this.LegendIndex;
			animationLimit = this.LegendIndex_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("legendIndex", this.LegendIndex);
			}
			if (this.LevelIsConstant != this.LevelIsConstant_DefaultValue)
			{
				TreemapSeriesLevelIsConstant levelIsConstant = this.LevelIsConstant;
				hashtables.Add("levelIsConstant", Highcharts.FirstCharacterToLower(levelIsConstant.ToString()));
			}
			if (this.Levels != this.Levels_DefaultValue)
			{
				hashtables.Add("levels", base.HashifyList(this.Levels));
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
			if (this.Name != this.Name_DefaultValue)
			{
				hashtables.Add("name", this.Name);
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
			if (this.Type != this.Type_DefaultValue)
			{
				TreemapSeriesType type = this.Type;
				hashtables.Add("type", Highcharts.FirstCharacterToLower(type.ToString()));
			}
			allowPointSelectDefaultValue = this.Visible;
			allowPointSelect = this.Visible_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault() ? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue : true))
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