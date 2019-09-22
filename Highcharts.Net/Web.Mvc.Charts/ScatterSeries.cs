using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class ScatterSeries : Series
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

		public ScatterSeriesCursor Cursor
		{
			get;
			set;
		}

		private ScatterSeriesCursor Cursor_DefaultValue
		{
			get;
			set;
		}

		public ScatterSeriesDashStyle DashStyle
		{
			get;
			set;
		}

		private ScatterSeriesDashStyle DashStyle_DefaultValue
		{
			get;
			set;
		}

		public new List<ScatterSeriesData> Data
		{
			get;
			set;
		}

		private List<ScatterSeriesData> Data_DefaultValue
		{
			get;
			set;
		}

		public ScatterSeriesDataLabels DataLabels
		{
			get;
			set;
		}

		private ScatterSeriesDataLabels DataLabels_DefaultValue
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

		public ScatterSeriesEvents Events
		{
			get;
			set;
		}

		private ScatterSeriesEvents Events_DefaultValue
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

		public ScatterSeriesMarker Marker
		{
			get;
			set;
		}

		private ScatterSeriesMarker Marker_DefaultValue
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

		public ScatterSeriesPoint Point
		{
			get;
			set;
		}

		private ScatterSeriesPoint Point_DefaultValue
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

		public ScatterSeriesPointIntervalUnit PointIntervalUnit
		{
			get;
			set;
		}

		private ScatterSeriesPointIntervalUnit PointIntervalUnit_DefaultValue
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

		public ScatterSeriesStates States
		{
			get;
			set;
		}

		private ScatterSeriesStates States_DefaultValue
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

		public new ScatterSeriesType Type
		{
			get;
			set;
		}

		private ScatterSeriesType Type_DefaultValue
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

		public ScatterSeriesZones Zones
		{
			get;
			set;
		}

		private ScatterSeriesZones Zones_DefaultValue
		{
			get;
			set;
		}

		public ScatterSeries()
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
			ScatterSeriesCursor scatterSeriesCursor = (ScatterSeriesCursor)num;
			this.Cursor_DefaultValue = (ScatterSeriesCursor)num;
			this.Cursor = scatterSeriesCursor;
			int num1 = 0;
			ScatterSeriesDashStyle scatterSeriesDashStyle = (ScatterSeriesDashStyle)num1;
			this.DashStyle_DefaultValue = (ScatterSeriesDashStyle)num1;
			this.DashStyle = scatterSeriesDashStyle;
			List<ScatterSeriesData> scatterSeriesDatas = new List<ScatterSeriesData>();
			List<ScatterSeriesData> scatterSeriesDatas1 = scatterSeriesDatas;
			this.Data_DefaultValue = scatterSeriesDatas;
			this.Data = scatterSeriesDatas1;
			ScatterSeriesDataLabels scatterSeriesDataLabel = new ScatterSeriesDataLabels();
			ScatterSeriesDataLabels scatterSeriesDataLabel1 = scatterSeriesDataLabel;
			this.DataLabels_DefaultValue = scatterSeriesDataLabel;
			this.DataLabels = scatterSeriesDataLabel1;
			string str2 = "undefined";
			str1 = str2;
			this.Description_DefaultValue = str2;
			this.Description = str1;
			nullable = new bool?(true);
			this.EnableMouseTracking_DefaultValue = nullable;
			this.EnableMouseTracking = nullable;
			ScatterSeriesEvents scatterSeriesEvent = new ScatterSeriesEvents();
			ScatterSeriesEvents scatterSeriesEvent1 = scatterSeriesEvent;
			this.Events_DefaultValue = scatterSeriesEvent;
			this.Events = scatterSeriesEvent1;
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
			nullable1 = new double?(0);
			this.LineWidth_DefaultValue = nullable1;
			this.LineWidth = nullable1;
			string str4 = "";
			str1 = str4;
			this.LinkedTo_DefaultValue = str4;
			this.LinkedTo = str1;
			ScatterSeriesMarker scatterSeriesMarker = new ScatterSeriesMarker();
			ScatterSeriesMarker scatterSeriesMarker1 = scatterSeriesMarker;
			this.Marker_DefaultValue = scatterSeriesMarker;
			this.Marker = scatterSeriesMarker1;
			object obj1 = null;
			str1 = (string)obj1;
			this.Name_DefaultValue = (string)obj1;
			this.Name = str1;
			string str5 = "null";
			str1 = str5;
			this.NegativeColor_DefaultValue = str5;
			this.NegativeColor = str1;
			ScatterSeriesPoint scatterSeriesPoint = new ScatterSeriesPoint();
			ScatterSeriesPoint scatterSeriesPoint1 = scatterSeriesPoint;
			this.Point_DefaultValue = scatterSeriesPoint;
			this.Point = scatterSeriesPoint1;
			nullable1 = new double?((double)1);
			this.PointInterval_DefaultValue = nullable1;
			this.PointInterval = nullable1;
			int num2 = 0;
			ScatterSeriesPointIntervalUnit scatterSeriesPointIntervalUnit = (ScatterSeriesPointIntervalUnit)num2;
			this.PointIntervalUnit_DefaultValue = (ScatterSeriesPointIntervalUnit)num2;
			this.PointIntervalUnit = scatterSeriesPointIntervalUnit;
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
			ScatterSeriesStates scatterSeriesState = new ScatterSeriesStates();
			ScatterSeriesStates scatterSeriesState1 = scatterSeriesState;
			this.States_DefaultValue = scatterSeriesState;
			this.States = scatterSeriesState1;
			nullable = new bool?(false);
			this.StickyTracking_DefaultValue = nullable;
			this.StickyTracking = nullable;
			nullable1 = new double?(0);
			this.Threshold_DefaultValue = nullable1;
			this.Threshold = nullable1;
			nullable1 = new double?((double)1000);
			this.TurboThreshold_DefaultValue = nullable1;
			this.TurboThreshold = nullable1;
			int num3 = 0;
			ScatterSeriesType scatterSeriesType = (ScatterSeriesType)num3;
			this.Type_DefaultValue = (ScatterSeriesType)num3;
			this.Type = scatterSeriesType;
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
			ScatterSeriesZones scatterSeriesZone = new ScatterSeriesZones();
			ScatterSeriesZones scatterSeriesZone1 = scatterSeriesZone;
			this.Zones_DefaultValue = scatterSeriesZone;
			this.Zones = scatterSeriesZone1;
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
				ScatterSeriesCursor cursor = this.Cursor;
				hashtables.Add("cursor", Highcharts.FirstCharacterToLower(cursor.ToString()));
			}
			if (this.DashStyle != this.DashStyle_DefaultValue)
			{
				ScatterSeriesDashStyle dashStyle = this.DashStyle;
				hashtables.Add("dashStyle", Highcharts.FirstCharacterToLower(dashStyle.ToString()));
			}
			if (this.Data.Any<ScatterSeriesData>())
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
				ScatterSeriesPointIntervalUnit pointIntervalUnit = this.PointIntervalUnit;
				hashtables.Add("pointIntervalUnit", Highcharts.FirstCharacterToLower(pointIntervalUnit.ToString()));
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
			animationLimitDefaultValue = this.TurboThreshold;
			animationLimit = this.TurboThreshold_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("turboThreshold", this.TurboThreshold);
			}
			if (this.Type != this.Type_DefaultValue)
			{
				ScatterSeriesType type = this.Type;
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