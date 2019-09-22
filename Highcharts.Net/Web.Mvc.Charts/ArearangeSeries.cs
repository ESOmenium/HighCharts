using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class ArearangeSeries : Series
	{
		public bool? AllowPointSelect { get; set; }

		private bool? AllowPointSelect_DefaultValue { get; }

		public Animation Animation { get; set; }

		private Animation Animation_DefaultValue { get; set; }

		public double? AnimationLimit { get; set; }

		private double? AnimationLimit_DefaultValue { get; }

		public string ClassName { get; set; }

		private string ClassName_DefaultValue { get; }

		public string Color { get; set; }

		private string Color_DefaultValue { get; }

		public double? ColorIndex { get; set; }

		private double? ColorIndex_DefaultValue { get; }

		public bool? ConnectNulls { get; set; }

		private bool? ConnectNulls_DefaultValue { get; }

		public double? CropThreshold { get; set; }

		private double? CropThreshold_DefaultValue { get; }

		public ArearangeSeriesCursor Cursor { get; set; }

		private ArearangeSeriesCursor Cursor_DefaultValue { get; }

		public ArearangeSeriesDashStyle DashStyle { get; set; }

		private ArearangeSeriesDashStyle DashStyle_DefaultValue { get; }

		public new List<ArearangeSeriesData> Data { get; set; }

		private List<ArearangeSeriesData> Data_DefaultValue { get; set; }

		public ArearangeSeriesDataLabels DataLabels { get; set; }

		private ArearangeSeriesDataLabels DataLabels_DefaultValue { get; set; }

		public string Description { get; set; }

		private string Description_DefaultValue { get; }

		public bool? EnableMouseTracking { get; set; }

		private bool? EnableMouseTracking_DefaultValue { get; }

		public ArearangeSeriesEvents Events { get; set; }

		private ArearangeSeriesEvents Events_DefaultValue { get; set; }

		public object FillColor { get; set; }

		private object FillColor_DefaultValue { get; }

		public double? FillOpacity { get; set; }

		private double? FillOpacity_DefaultValue { get; }

		public bool? GetExtremesFromAll { get; set; }

		private bool? GetExtremesFromAll_DefaultValue { get; }

		public new string Id { get; set; }

		private string Id_DefaultValue { get; }

		public new double? Index { get; set; }

		private double? Index_DefaultValue { get; }

		public List<string> Keys { get; set; }

		private List<string> Keys_DefaultValue { get; }

		public new double? LegendIndex { get; set; }

		private double? LegendIndex_DefaultValue { get; }

		public ArearangeSeriesLinecap Linecap { get; set; }

		private ArearangeSeriesLinecap Linecap_DefaultValue { get; }

		public string LineColor { get; set; }

		private string LineColor_DefaultValue { get; }

		public double? LineWidth { get; set; }

		private double? LineWidth_DefaultValue { get; }

		public string LinkedTo { get; set; }

		private string LinkedTo_DefaultValue { get; }

		public new string Name { get; set; }

		private string Name_DefaultValue { get; }

		public string NegativeColor { get; set; }

		private string NegativeColor_DefaultValue { get; }

		public string NegativeFillColor { get; set; }

		private string NegativeFillColor_DefaultValue { get; }

		public ArearangeSeriesPoint Point { get; set; }

		private ArearangeSeriesPoint Point_DefaultValue { get; set; }

		public double? PointInterval { get; set; }

		private double? PointInterval_DefaultValue { get; }

		public ArearangeSeriesPointIntervalUnit PointIntervalUnit { get; set; }

		private ArearangeSeriesPointIntervalUnit PointIntervalUnit_DefaultValue { get; }

		public PointPlacement PointPlacement { get; set; }

		private PointPlacement PointPlacement_DefaultValue { get; set; }

		public double? PointStart { get; set; }

		private double? PointStart_DefaultValue { get; }

		public bool? Selected { get; set; }

		private bool? Selected_DefaultValue { get; }

		public Shadow Shadow { get; set; }

		private Shadow Shadow_DefaultValue { get; }

		public bool? ShowCheckbox { get; set; }

		private bool? ShowCheckbox_DefaultValue { get; }

		public bool? ShowInLegend { get; set; }

		private bool? ShowInLegend_DefaultValue { get; }

		public ArearangeSeriesStates States { get; set; }

		private ArearangeSeriesStates States_DefaultValue { get; set; }

		public ArearangeSeriesStep Step { get; set; }

		private ArearangeSeriesStep Step_DefaultValue { get; }

		public bool? StickyTracking { get; set; }

		private bool? StickyTracking_DefaultValue { get; }

		public ArearangeSeriesTooltip Tooltip { get; set; }

		private ArearangeSeriesTooltip Tooltip_DefaultValue { get; set; }

		public bool? TrackByArea { get; set; }

		private bool? TrackByArea_DefaultValue { get; }

		public double? TurboThreshold { get; set; }

		private double? TurboThreshold_DefaultValue { get; }

		public new ArearangeSeriesType Type { get; set; }

		private ArearangeSeriesType Type_DefaultValue { get; }

		public bool? Visible { get; set; }

		private bool? Visible_DefaultValue { get; }

		public new string XAxis { get; set; }

		private string XAxis_DefaultValue { get; }

		public new string YAxis { get; set; }

		private string YAxis_DefaultValue { get; }

		public new double? ZIndex { get; set; }

		private double? ZIndex_DefaultValue { get; }

		public string ZoneAxis { get; set; }

		private string ZoneAxis_DefaultValue { get; }

		public ArearangeSeriesZones Zones { get; set; }

		private ArearangeSeriesZones Zones_DefaultValue { get; set; }

		public ArearangeSeries()
		{
			bool? nullable = false;
			AllowPointSelect_DefaultValue = nullable;
			AllowPointSelect = nullable;
			Animation animation = new Animation
			{
				Enabled = true
			};
			Animation animation1 = animation;
			Animation_DefaultValue = animation;
			Animation = animation1;
			double? nullable1 = null;
			AnimationLimit_DefaultValue = nullable1;
			AnimationLimit = nullable1;
			string str = "";
			string str1 = str;
			ClassName_DefaultValue = str;
			ClassName = str1;
			object obj = null;
			str1 = (string) obj;
			Color_DefaultValue = (string) obj;
			Color = str1;
			nullable1 = null;
			ColorIndex_DefaultValue = nullable1;
			ColorIndex = nullable1;
			nullable = false;
			ConnectNulls_DefaultValue = nullable;
			ConnectNulls = nullable;
			nullable1 = 300;
			CropThreshold_DefaultValue = nullable1;
			CropThreshold = nullable1;
			int num = 0;
			ArearangeSeriesCursor arearangeSeriesCursor = (ArearangeSeriesCursor) num;
			Cursor_DefaultValue = (ArearangeSeriesCursor) num;
			Cursor = arearangeSeriesCursor;
			int num1 = 0;
			ArearangeSeriesDashStyle arearangeSeriesDashStyle = (ArearangeSeriesDashStyle) num1;
			DashStyle_DefaultValue = (ArearangeSeriesDashStyle) num1;
			DashStyle = arearangeSeriesDashStyle;
			List<ArearangeSeriesData> arearangeSeriesDatas = new List<ArearangeSeriesData>();
			List<ArearangeSeriesData> arearangeSeriesDatas1 = arearangeSeriesDatas;
			Data_DefaultValue = arearangeSeriesDatas;
			Data = arearangeSeriesDatas1;
			ArearangeSeriesDataLabels arearangeSeriesDataLabel = new ArearangeSeriesDataLabels();
			ArearangeSeriesDataLabels arearangeSeriesDataLabel1 = arearangeSeriesDataLabel;
			DataLabels_DefaultValue = arearangeSeriesDataLabel;
			DataLabels = arearangeSeriesDataLabel1;
			string str2 = "undefined";
			str1 = str2;
			Description_DefaultValue = str2;
			Description = str1;
			nullable = true;
			EnableMouseTracking_DefaultValue = nullable;
			EnableMouseTracking = nullable;
			ArearangeSeriesEvents arearangeSeriesEvent = new ArearangeSeriesEvents();
			ArearangeSeriesEvents arearangeSeriesEvent1 = arearangeSeriesEvent;
			Events_DefaultValue = arearangeSeriesEvent;
			Events = arearangeSeriesEvent1;
			object obj1 = null;
			object obj2 = obj1;
			FillColor_DefaultValue = obj1;
			FillColor = obj2;
			nullable1 = 0.75;
			FillOpacity_DefaultValue = nullable1;
			FillOpacity = nullable1;
			nullable = false;
			GetExtremesFromAll_DefaultValue = nullable;
			GetExtremesFromAll = nullable;
			string str3 = "";
			str1 = str3;
			Id_DefaultValue = str3;
			Id = str1;
			nullable1 = null;
			Index_DefaultValue = nullable1;
			Index = nullable1;
			List<string> strs = new List<string>();
			List<string> strs1 = strs;
			Keys_DefaultValue = strs;
			Keys = strs1;
			nullable1 = null;
			LegendIndex_DefaultValue = nullable1;
			LegendIndex = nullable1;
			object obj3 = null;
			str1 = (string) obj3;
			LineColor_DefaultValue = (string) obj3;
			LineColor = str1;
			nullable1 = 1;
			LineWidth_DefaultValue = nullable1;
			LineWidth = nullable1;
			int num2 = 0;
			ArearangeSeriesLinecap arearangeSeriesLinecap = (ArearangeSeriesLinecap) num2;
			Linecap_DefaultValue = (ArearangeSeriesLinecap) num2;
			Linecap = arearangeSeriesLinecap;
			string str4 = "";
			str1 = str4;
			LinkedTo_DefaultValue = str4;
			LinkedTo = str1;
			object obj4 = null;
			str1 = (string) obj4;
			Name_DefaultValue = (string) obj4;
			Name = str1;
			string str5 = "null";
			str1 = str5;
			NegativeColor_DefaultValue = str5;
			NegativeColor = str1;
			object obj5 = null;
			str1 = (string) obj5;
			NegativeFillColor_DefaultValue = (string) obj5;
			NegativeFillColor = str1;
			ArearangeSeriesPoint arearangeSeriesPoint = new ArearangeSeriesPoint();
			ArearangeSeriesPoint arearangeSeriesPoint1 = arearangeSeriesPoint;
			Point_DefaultValue = arearangeSeriesPoint;
			Point = arearangeSeriesPoint1;
			nullable1 = 1;
			PointInterval_DefaultValue = nullable1;
			PointInterval = nullable1;
			int num3 = 0;
			ArearangeSeriesPointIntervalUnit arearangeSeriesPointIntervalUnit = (ArearangeSeriesPointIntervalUnit) num3;
			PointIntervalUnit_DefaultValue = (ArearangeSeriesPointIntervalUnit) num3;
			PointIntervalUnit = arearangeSeriesPointIntervalUnit;
			PointPlacement pointPlacement = new PointPlacement();
			PointPlacement pointPlacement1 = pointPlacement;
			PointPlacement_DefaultValue = pointPlacement;
			PointPlacement = pointPlacement1;
			nullable1 = 0;
			PointStart_DefaultValue = nullable1;
			PointStart = nullable1;
			nullable = false;
			Selected_DefaultValue = nullable;
			Selected = nullable;
			Shadow shadow = new Shadow
			{
				Enabled = false
			};
			Shadow shadow1 = shadow;
			Shadow_DefaultValue = shadow;
			Shadow = shadow1;
			nullable = false;
			ShowCheckbox_DefaultValue = nullable;
			ShowCheckbox = nullable;
			nullable = true;
			ShowInLegend_DefaultValue = nullable;
			ShowInLegend = nullable;
			ArearangeSeriesStates arearangeSeriesState = new ArearangeSeriesStates();
			ArearangeSeriesStates arearangeSeriesState1 = arearangeSeriesState;
			States_DefaultValue = arearangeSeriesState;
			States = arearangeSeriesState1;
			int num4 = 0;
			ArearangeSeriesStep arearangeSeriesStep = (ArearangeSeriesStep) num4;
			Step_DefaultValue = (ArearangeSeriesStep) num4;
			Step = arearangeSeriesStep;
			nullable = true;
			StickyTracking_DefaultValue = nullable;
			StickyTracking = nullable;
			ArearangeSeriesTooltip arearangeSeriesTooltip = new ArearangeSeriesTooltip();
			ArearangeSeriesTooltip arearangeSeriesTooltip1 = arearangeSeriesTooltip;
			Tooltip_DefaultValue = arearangeSeriesTooltip;
			Tooltip = arearangeSeriesTooltip1;
			nullable = true;
			TrackByArea_DefaultValue = nullable;
			TrackByArea = nullable;
			nullable1 = 1000;
			TurboThreshold_DefaultValue = nullable1;
			TurboThreshold = nullable1;
			int num5 = 0;
			ArearangeSeriesType arearangeSeriesType = (ArearangeSeriesType) num5;
			Type_DefaultValue = (ArearangeSeriesType) num5;
			Type = arearangeSeriesType;
			nullable = true;
			Visible_DefaultValue = nullable;
			Visible = nullable;
			string str6 = "0";
			str1 = str6;
			XAxis_DefaultValue = str6;
			XAxis = str1;
			string str7 = "0";
			str1 = str7;
			YAxis_DefaultValue = str7;
			YAxis = str1;
			nullable1 = null;
			ZIndex_DefaultValue = nullable1;
			ZIndex = nullable1;
			string str8 = "y";
			str1 = str8;
			ZoneAxis_DefaultValue = str8;
			ZoneAxis = str1;
			ArearangeSeriesZones arearangeSeriesZone = new ArearangeSeriesZones();
			ArearangeSeriesZones arearangeSeriesZone1 = arearangeSeriesZone;
			Zones_DefaultValue = arearangeSeriesZone;
			Zones = arearangeSeriesZone1;
		}

		internal override bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			bool? allowPointSelect = AllowPointSelect;
			bool? allowPointSelectDefaultValue = AllowPointSelect_DefaultValue;
			if ((allowPointSelect.GetValueOrDefault() == allowPointSelectDefaultValue.GetValueOrDefault()
				? allowPointSelect.HasValue != allowPointSelectDefaultValue.HasValue
				: true))
			{
				hashtables.Add("allowPointSelect", AllowPointSelect);
			}
			if (Animation.IsDirty())
			{
				hashtables.Add("animation", Animation.ToJSON());
			}
			double? animationLimit = AnimationLimit;
			double? animationLimitDefaultValue = AnimationLimit_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault()
				? animationLimit.HasValue != animationLimitDefaultValue.HasValue
				: true))
			{
				hashtables.Add("animationLimit", AnimationLimit);
			}
			if (ClassName != ClassName_DefaultValue)
			{
				hashtables.Add("className", ClassName);
			}
			if (Color != Color_DefaultValue)
			{
				hashtables.Add("color", Color);
			}
			animationLimitDefaultValue = ColorIndex;
			animationLimit = ColorIndex_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault()
				? animationLimitDefaultValue.HasValue != animationLimit.HasValue
				: true))
			{
				hashtables.Add("colorIndex", ColorIndex);
			}
			allowPointSelectDefaultValue = ConnectNulls;
			allowPointSelect = ConnectNulls_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault()
				? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue
				: true))
			{
				hashtables.Add("connectNulls", ConnectNulls);
			}
			animationLimit = CropThreshold;
			animationLimitDefaultValue = CropThreshold_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault()
				? animationLimit.HasValue != animationLimitDefaultValue.HasValue
				: true))
			{
				hashtables.Add("cropThreshold", CropThreshold);
			}
			if (Cursor != Cursor_DefaultValue)
			{
				ArearangeSeriesCursor cursor = Cursor;
				hashtables.Add("cursor", Highcharts.FirstCharacterToLower(cursor.ToString()));
			}
			if (DashStyle != DashStyle_DefaultValue)
			{
				ArearangeSeriesDashStyle dashStyle = DashStyle;
				hashtables.Add("dashStyle", Highcharts.FirstCharacterToLower(dashStyle.ToString()));
			}
			if (Data.Any())
			{
				hashtables.Add("data", HashifyList(Data));
			}
			if (DataLabels.IsDirty())
			{
				hashtables.Add("dataLabels", DataLabels.ToHashtable());
			}
			if (Description != Description_DefaultValue)
			{
				hashtables.Add("description", Description);
			}
			allowPointSelect = EnableMouseTracking;
			allowPointSelectDefaultValue = EnableMouseTracking_DefaultValue;
			if ((allowPointSelect.GetValueOrDefault() == allowPointSelectDefaultValue.GetValueOrDefault()
				? allowPointSelect.HasValue != allowPointSelectDefaultValue.HasValue
				: true))
			{
				hashtables.Add("enableMouseTracking", EnableMouseTracking);
			}
			if (Events.IsDirty())
			{
				hashtables.Add("events", Events.ToHashtable());
			}
			if (FillColor != FillColor_DefaultValue)
			{
				hashtables.Add("fillColor", FillColor);
			}
			animationLimitDefaultValue = FillOpacity;
			animationLimit = FillOpacity_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault()
				? animationLimitDefaultValue.HasValue != animationLimit.HasValue
				: true))
			{
				hashtables.Add("fillOpacity", FillOpacity);
			}
			allowPointSelectDefaultValue = GetExtremesFromAll;
			allowPointSelect = GetExtremesFromAll_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault()
				? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue
				: true))
			{
				hashtables.Add("getExtremesFromAll", GetExtremesFromAll);
			}
			if (Id != Id_DefaultValue)
			{
				hashtables.Add("id", Id);
			}
			animationLimit = Index;
			animationLimitDefaultValue = Index_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault()
				? animationLimit.HasValue != animationLimitDefaultValue.HasValue
				: true))
			{
				hashtables.Add("index", Index);
			}
			if (Keys != Keys_DefaultValue)
			{
				hashtables.Add("keys", Keys);
			}
			animationLimitDefaultValue = LegendIndex;
			animationLimit = LegendIndex_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault()
				? animationLimitDefaultValue.HasValue != animationLimit.HasValue
				: true))
			{
				hashtables.Add("legendIndex", LegendIndex);
			}
			if (LineColor != LineColor_DefaultValue)
			{
				hashtables.Add("lineColor", LineColor);
			}
			animationLimit = LineWidth;
			animationLimitDefaultValue = LineWidth_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault()
				? animationLimit.HasValue != animationLimitDefaultValue.HasValue
				: true))
			{
				hashtables.Add("lineWidth", LineWidth);
			}
			if (Linecap != Linecap_DefaultValue)
			{
				ArearangeSeriesLinecap linecap = Linecap;
				hashtables.Add("linecap", Highcharts.FirstCharacterToLower(linecap.ToString()));
			}
			if (LinkedTo != LinkedTo_DefaultValue)
			{
				hashtables.Add("linkedTo", LinkedTo);
			}
			if (Name != Name_DefaultValue)
			{
				hashtables.Add("name", Name);
			}
			if (NegativeColor != NegativeColor_DefaultValue)
			{
				hashtables.Add("negativeColor", NegativeColor);
			}
			if (NegativeFillColor != NegativeFillColor_DefaultValue)
			{
				hashtables.Add("negativeFillColor", NegativeFillColor);
			}
			if (Point.IsDirty())
			{
				hashtables.Add("point", Point.ToHashtable());
			}
			animationLimitDefaultValue = PointInterval;
			animationLimit = PointInterval_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault()
				? animationLimitDefaultValue.HasValue != animationLimit.HasValue
				: true))
			{
				hashtables.Add("pointInterval", PointInterval);
			}
			if (PointIntervalUnit != PointIntervalUnit_DefaultValue)
			{
				ArearangeSeriesPointIntervalUnit pointIntervalUnit = PointIntervalUnit;
				hashtables.Add("pointIntervalUnit", Highcharts.FirstCharacterToLower(pointIntervalUnit.ToString()));
			}
			if (PointPlacement.IsDirty())
			{
				hashtables.Add("pointPlacement", PointPlacement.ToJSON());
			}
			animationLimit = PointStart;
			animationLimitDefaultValue = PointStart_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault()
				? animationLimit.HasValue != animationLimitDefaultValue.HasValue
				: true))
			{
				hashtables.Add("pointStart", PointStart);
			}
			allowPointSelect = Selected;
			allowPointSelectDefaultValue = Selected_DefaultValue;
			if ((allowPointSelect.GetValueOrDefault() == allowPointSelectDefaultValue.GetValueOrDefault()
				? allowPointSelect.HasValue != allowPointSelectDefaultValue.HasValue
				: true))
			{
				hashtables.Add("selected", Selected);
			}
			if (Shadow != Shadow_DefaultValue)
			{
				hashtables.Add("shadow", Shadow);
			}
			allowPointSelectDefaultValue = ShowCheckbox;
			allowPointSelect = ShowCheckbox_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault()
				? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue
				: true))
			{
				hashtables.Add("showCheckbox", ShowCheckbox);
			}
			allowPointSelect = ShowInLegend;
			allowPointSelectDefaultValue = ShowInLegend_DefaultValue;
			if ((allowPointSelect.GetValueOrDefault() == allowPointSelectDefaultValue.GetValueOrDefault()
				? allowPointSelect.HasValue != allowPointSelectDefaultValue.HasValue
				: true))
			{
				hashtables.Add("showInLegend", ShowInLegend);
			}
			if (States.IsDirty())
			{
				hashtables.Add("states", States.ToHashtable());
			}
			if (Step != Step_DefaultValue)
			{
				ArearangeSeriesStep step = Step;
				hashtables.Add("step", Highcharts.FirstCharacterToLower(step.ToString()));
			}
			allowPointSelectDefaultValue = StickyTracking;
			allowPointSelect = StickyTracking_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault()
				? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue
				: true))
			{
				hashtables.Add("stickyTracking", StickyTracking);
			}
			if (Tooltip.IsDirty())
			{
				hashtables.Add("tooltip", Tooltip.ToHashtable());
			}
			allowPointSelect = TrackByArea;
			allowPointSelectDefaultValue = TrackByArea_DefaultValue;
			if ((allowPointSelect.GetValueOrDefault() == allowPointSelectDefaultValue.GetValueOrDefault()
				? allowPointSelect.HasValue != allowPointSelectDefaultValue.HasValue
				: true))
			{
				hashtables.Add("trackByArea", TrackByArea);
			}
			animationLimitDefaultValue = TurboThreshold;
			animationLimit = TurboThreshold_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault()
				? animationLimitDefaultValue.HasValue != animationLimit.HasValue
				: true))
			{
				hashtables.Add("turboThreshold", TurboThreshold);
			}
			if (Type != Type_DefaultValue)
			{
				ArearangeSeriesType type = Type;
				hashtables.Add("type", Highcharts.FirstCharacterToLower(type.ToString()));
			}
			allowPointSelectDefaultValue = Visible;
			allowPointSelect = Visible_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault()
				? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue
				: true))
			{
				hashtables.Add("visible", Visible);
			}
			if (XAxis != XAxis_DefaultValue)
			{
				hashtables.Add("xAxis", XAxis);
			}
			if (YAxis != YAxis_DefaultValue)
			{
				hashtables.Add("yAxis", YAxis);
			}
			animationLimit = ZIndex;
			animationLimitDefaultValue = ZIndex_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault()
				? animationLimit.HasValue != animationLimitDefaultValue.HasValue
				: true))
			{
				hashtables.Add("zIndex", ZIndex);
			}
			if (ZoneAxis != ZoneAxis_DefaultValue)
			{
				hashtables.Add("zoneAxis", ZoneAxis);
			}
			if (Zones.IsDirty())
			{
				hashtables.Add("zones", Zones.ToHashtable());
			}
			return hashtables;
		}

		internal override string ToJSON()
		{
			string str;
			Hashtable hashtable = ToHashtable();
			JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer
			{
				MaxJsonLength = 2147483647
			};
			str = (hashtable.Count <= 0 ? "" : javaScriptSerializer.Serialize(ToHashtable()));
			return str;
		}
	}
}