using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class AreasplinerangeSeries : Series
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

		public AreasplinerangeSeriesCursor Cursor
		{
			get;
			set;
		}

		private AreasplinerangeSeriesCursor Cursor_DefaultValue
		{
			get;
			set;
		}

		public AreasplinerangeSeriesDashStyle DashStyle
		{
			get;
			set;
		}

		private AreasplinerangeSeriesDashStyle DashStyle_DefaultValue
		{
			get;
			set;
		}

		public new List<AreasplinerangeSeriesData> Data
		{
			get;
			set;
		}

		private List<AreasplinerangeSeriesData> Data_DefaultValue
		{
			get;
			set;
		}

		public AreasplinerangeSeriesDataLabels DataLabels
		{
			get;
			set;
		}

		private AreasplinerangeSeriesDataLabels DataLabels_DefaultValue
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

		public AreasplinerangeSeriesEvents Events
		{
			get;
			set;
		}

		private AreasplinerangeSeriesEvents Events_DefaultValue
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

		public AreasplinerangeSeriesLinecap Linecap
		{
			get;
			set;
		}

		private AreasplinerangeSeriesLinecap Linecap_DefaultValue
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

		public AreasplinerangeSeriesPoint Point
		{
			get;
			set;
		}

		private AreasplinerangeSeriesPoint Point_DefaultValue
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

		public AreasplinerangeSeriesPointIntervalUnit PointIntervalUnit
		{
			get;
			set;
		}

		private AreasplinerangeSeriesPointIntervalUnit PointIntervalUnit_DefaultValue
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

		public AreasplinerangeSeriesStates States
		{
			get;
			set;
		}

		private AreasplinerangeSeriesStates States_DefaultValue
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

		public AreasplinerangeSeriesTooltip Tooltip
		{
			get;
			set;
		}

		private AreasplinerangeSeriesTooltip Tooltip_DefaultValue
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

		public new AreasplinerangeSeriesType Type
		{
			get;
			set;
		}

		private AreasplinerangeSeriesType Type_DefaultValue
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

		public AreasplinerangeSeriesZones Zones
		{
			get;
			set;
		}

		private AreasplinerangeSeriesZones Zones_DefaultValue
		{
			get;
			set;
		}

		public AreasplinerangeSeries()
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
			AreasplinerangeSeriesCursor areasplinerangeSeriesCursor = (AreasplinerangeSeriesCursor)num;
			this.Cursor_DefaultValue = (AreasplinerangeSeriesCursor)num;
			this.Cursor = areasplinerangeSeriesCursor;
			int num1 = 0;
			AreasplinerangeSeriesDashStyle areasplinerangeSeriesDashStyle = (AreasplinerangeSeriesDashStyle)num1;
			this.DashStyle_DefaultValue = (AreasplinerangeSeriesDashStyle)num1;
			this.DashStyle = areasplinerangeSeriesDashStyle;
			List<AreasplinerangeSeriesData> areasplinerangeSeriesDatas = new List<AreasplinerangeSeriesData>();
			List<AreasplinerangeSeriesData> areasplinerangeSeriesDatas1 = areasplinerangeSeriesDatas;
			this.Data_DefaultValue = areasplinerangeSeriesDatas;
			this.Data = areasplinerangeSeriesDatas1;
			AreasplinerangeSeriesDataLabels areasplinerangeSeriesDataLabel = new AreasplinerangeSeriesDataLabels();
			AreasplinerangeSeriesDataLabels areasplinerangeSeriesDataLabel1 = areasplinerangeSeriesDataLabel;
			this.DataLabels_DefaultValue = areasplinerangeSeriesDataLabel;
			this.DataLabels = areasplinerangeSeriesDataLabel1;
			string str2 = "undefined";
			str1 = str2;
			this.Description_DefaultValue = str2;
			this.Description = str1;
			nullable = new bool?(true);
			this.EnableMouseTracking_DefaultValue = nullable;
			this.EnableMouseTracking = nullable;
			AreasplinerangeSeriesEvents areasplinerangeSeriesEvent = new AreasplinerangeSeriesEvents();
			AreasplinerangeSeriesEvents areasplinerangeSeriesEvent1 = areasplinerangeSeriesEvent;
			this.Events_DefaultValue = areasplinerangeSeriesEvent;
			this.Events = areasplinerangeSeriesEvent1;
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
			object obj3 = null;
			str1 = (string)obj3;
			this.LineColor_DefaultValue = (string)obj3;
			this.LineColor = str1;
			nullable1 = new double?((double)1);
			this.LineWidth_DefaultValue = nullable1;
			this.LineWidth = nullable1;
			int num2 = 0;
			AreasplinerangeSeriesLinecap areasplinerangeSeriesLinecap = (AreasplinerangeSeriesLinecap)num2;
			this.Linecap_DefaultValue = (AreasplinerangeSeriesLinecap)num2;
			this.Linecap = areasplinerangeSeriesLinecap;
			string str4 = "";
			str1 = str4;
			this.LinkedTo_DefaultValue = str4;
			this.LinkedTo = str1;
			object obj4 = null;
			str1 = (string)obj4;
			this.Name_DefaultValue = (string)obj4;
			this.Name = str1;
			string str5 = "null";
			str1 = str5;
			this.NegativeColor_DefaultValue = str5;
			this.NegativeColor = str1;
			object obj5 = null;
			str1 = (string)obj5;
			this.NegativeFillColor_DefaultValue = (string)obj5;
			this.NegativeFillColor = str1;
			AreasplinerangeSeriesPoint areasplinerangeSeriesPoint = new AreasplinerangeSeriesPoint();
			AreasplinerangeSeriesPoint areasplinerangeSeriesPoint1 = areasplinerangeSeriesPoint;
			this.Point_DefaultValue = areasplinerangeSeriesPoint;
			this.Point = areasplinerangeSeriesPoint1;
			nullable1 = new double?((double)1);
			this.PointInterval_DefaultValue = nullable1;
			this.PointInterval = nullable1;
			int num3 = 0;
			AreasplinerangeSeriesPointIntervalUnit areasplinerangeSeriesPointIntervalUnit = (AreasplinerangeSeriesPointIntervalUnit)num3;
			this.PointIntervalUnit_DefaultValue = (AreasplinerangeSeriesPointIntervalUnit)num3;
			this.PointIntervalUnit = areasplinerangeSeriesPointIntervalUnit;
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
			AreasplinerangeSeriesStates areasplinerangeSeriesState = new AreasplinerangeSeriesStates();
			AreasplinerangeSeriesStates areasplinerangeSeriesState1 = areasplinerangeSeriesState;
			this.States_DefaultValue = areasplinerangeSeriesState;
			this.States = areasplinerangeSeriesState1;
			nullable = new bool?(true);
			this.StickyTracking_DefaultValue = nullable;
			this.StickyTracking = nullable;
			AreasplinerangeSeriesTooltip areasplinerangeSeriesTooltip = new AreasplinerangeSeriesTooltip();
			AreasplinerangeSeriesTooltip areasplinerangeSeriesTooltip1 = areasplinerangeSeriesTooltip;
			this.Tooltip_DefaultValue = areasplinerangeSeriesTooltip;
			this.Tooltip = areasplinerangeSeriesTooltip1;
			nullable = new bool?(true);
			this.TrackByArea_DefaultValue = nullable;
			this.TrackByArea = nullable;
			nullable1 = new double?((double)1000);
			this.TurboThreshold_DefaultValue = nullable1;
			this.TurboThreshold = nullable1;
			int num4 = 0;
			AreasplinerangeSeriesType areasplinerangeSeriesType = (AreasplinerangeSeriesType)num4;
			this.Type_DefaultValue = (AreasplinerangeSeriesType)num4;
			this.Type = areasplinerangeSeriesType;
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
			AreasplinerangeSeriesZones areasplinerangeSeriesZone = new AreasplinerangeSeriesZones();
			AreasplinerangeSeriesZones areasplinerangeSeriesZone1 = areasplinerangeSeriesZone;
			this.Zones_DefaultValue = areasplinerangeSeriesZone;
			this.Zones = areasplinerangeSeriesZone1;
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
				AreasplinerangeSeriesCursor cursor = this.Cursor;
				hashtables.Add("cursor", Highcharts.FirstCharacterToLower(cursor.ToString()));
			}
			if (this.DashStyle != this.DashStyle_DefaultValue)
			{
				AreasplinerangeSeriesDashStyle dashStyle = this.DashStyle;
				hashtables.Add("dashStyle", Highcharts.FirstCharacterToLower(dashStyle.ToString()));
			}
			if (this.Data.Any<AreasplinerangeSeriesData>())
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
			if (this.Id != this.Id_DefaultValue)
			{
				hashtables.Add("id", this.Id);
			}
			animationLimit = this.Index;
			animationLimitDefaultValue = this.Index_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("index", this.Index);
			}
			if (this.Keys != this.Keys_DefaultValue)
			{
				hashtables.Add("keys", this.Keys);
			}
			animationLimitDefaultValue = this.LegendIndex;
			animationLimit = this.LegendIndex_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("legendIndex", this.LegendIndex);
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
				AreasplinerangeSeriesLinecap linecap = this.Linecap;
				hashtables.Add("linecap", Highcharts.FirstCharacterToLower(linecap.ToString()));
			}
			if (this.LinkedTo != this.LinkedTo_DefaultValue)
			{
				hashtables.Add("linkedTo", this.LinkedTo);
			}
			if (this.Name != this.Name_DefaultValue)
			{
				hashtables.Add("name", this.Name);
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
				AreasplinerangeSeriesPointIntervalUnit pointIntervalUnit = this.PointIntervalUnit;
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
			if (this.Type != this.Type_DefaultValue)
			{
				AreasplinerangeSeriesType type = this.Type;
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