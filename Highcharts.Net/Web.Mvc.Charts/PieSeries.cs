using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PieSeries : Series
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

		public string[] Center
		{
			get;
			set;
		}

		private string[] Center_DefaultValue
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

		public PieSeriesCursor Cursor
		{
			get;
			set;
		}

		private PieSeriesCursor Cursor_DefaultValue
		{
			get;
			set;
		}

		public new List<PieSeriesData> Data
		{
			get;
			set;
		}

		private List<PieSeriesData> Data_DefaultValue
		{
			get;
			set;
		}

		public PieSeriesDataLabels DataLabels
		{
			get;
			set;
		}

		private PieSeriesDataLabels DataLabels_DefaultValue
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

		public double? EndAngle
		{
			get;
			set;
		}

		private double? EndAngle_DefaultValue
		{
			get;
			set;
		}

		public PieSeriesEvents Events
		{
			get;
			set;
		}

		private PieSeriesEvents Events_DefaultValue
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

		public string InnerSize
		{
			get;
			set;
		}

		private string InnerSize_DefaultValue
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

		public double? MinSize
		{
			get;
			set;
		}

		private double? MinSize_DefaultValue
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

		public PieSeriesPoint Point
		{
			get;
			set;
		}

		private PieSeriesPoint Point_DefaultValue
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

		public string Size
		{
			get;
			set;
		}

		private string Size_DefaultValue
		{
			get;
			set;
		}

		public double? SlicedOffset
		{
			get;
			set;
		}

		private double? SlicedOffset_DefaultValue
		{
			get;
			set;
		}

		public double? StartAngle
		{
			get;
			set;
		}

		private double? StartAngle_DefaultValue
		{
			get;
			set;
		}

		public PieSeriesStates States
		{
			get;
			set;
		}

		private PieSeriesStates States_DefaultValue
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

		public PieSeriesTooltip Tooltip
		{
			get;
			set;
		}

		private PieSeriesTooltip Tooltip_DefaultValue
		{
			get;
			set;
		}

		public new PieSeriesType Type
		{
			get;
			set;
		}

		private PieSeriesType Type_DefaultValue
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

		public PieSeriesZones Zones
		{
			get;
			set;
		}

		private PieSeriesZones Zones_DefaultValue
		{
			get;
			set;
		}

		public PieSeries()
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
			nullable1 = new double?((double)1);
			this.BorderWidth_DefaultValue = nullable1;
			this.BorderWidth = nullable1;
			string[] strArrays = new string[2];
			string[] strArrays1 = strArrays;
			this.Center_DefaultValue = strArrays;
			this.Center = strArrays1;
			string str2 = "";
			str1 = str2;
			this.ClassName_DefaultValue = str2;
			this.ClassName = str1;
			nullable1 = null;
			this.ColorIndex_DefaultValue = nullable1;
			this.ColorIndex = nullable1;
			List<string> strs = new List<string>();
			List<string> strs1 = strs;
			this.Colors_DefaultValue = strs;
			this.Colors = strs1;
			int num = 0;
			PieSeriesCursor pieSeriesCursor = (PieSeriesCursor)num;
			this.Cursor_DefaultValue = (PieSeriesCursor)num;
			this.Cursor = pieSeriesCursor;
			List<PieSeriesData> pieSeriesDatas = new List<PieSeriesData>();
			List<PieSeriesData> pieSeriesDatas1 = pieSeriesDatas;
			this.Data_DefaultValue = pieSeriesDatas;
			this.Data = pieSeriesDatas1;
			PieSeriesDataLabels pieSeriesDataLabel = new PieSeriesDataLabels();
			PieSeriesDataLabels pieSeriesDataLabel1 = pieSeriesDataLabel;
			this.DataLabels_DefaultValue = pieSeriesDataLabel;
			this.DataLabels = pieSeriesDataLabel1;
			nullable1 = new double?(0);
			this.Depth_DefaultValue = nullable1;
			this.Depth = nullable1;
			string str3 = "undefined";
			str1 = str3;
			this.Description_DefaultValue = str3;
			this.Description = str1;
			nullable = new bool?(true);
			this.EnableMouseTracking_DefaultValue = nullable;
			this.EnableMouseTracking = nullable;
			nullable1 = null;
			this.EndAngle_DefaultValue = nullable1;
			this.EndAngle = nullable1;
			PieSeriesEvents pieSeriesEvent = new PieSeriesEvents();
			PieSeriesEvents pieSeriesEvent1 = pieSeriesEvent;
			this.Events_DefaultValue = pieSeriesEvent;
			this.Events = pieSeriesEvent1;
			nullable = new bool?(false);
			this.GetExtremesFromAll_DefaultValue = nullable;
			this.GetExtremesFromAll = nullable;
			string str4 = "";
			str1 = str4;
			this.Id_DefaultValue = str4;
			this.Id = str1;
			nullable = new bool?(true);
			this.IgnoreHiddenPoint_DefaultValue = nullable;
			this.IgnoreHiddenPoint = nullable;
			nullable1 = null;
			this.Index_DefaultValue = nullable1;
			this.Index = nullable1;
			string str5 = "0";
			str1 = str5;
			this.InnerSize_DefaultValue = str5;
			this.InnerSize = str1;
			List<string> strs2 = new List<string>();
			strs1 = strs2;
			this.Keys_DefaultValue = strs2;
			this.Keys = strs1;
			nullable1 = null;
			this.LegendIndex_DefaultValue = nullable1;
			this.LegendIndex = nullable1;
			string str6 = "";
			str1 = str6;
			this.LinkedTo_DefaultValue = str6;
			this.LinkedTo = str1;
			nullable1 = new double?((double)80);
			this.MinSize_DefaultValue = nullable1;
			this.MinSize = nullable1;
			object obj = null;
			str1 = (string)obj;
			this.Name_DefaultValue = (string)obj;
			this.Name = str1;
			PieSeriesPoint pieSeriesPoint = new PieSeriesPoint();
			PieSeriesPoint pieSeriesPoint1 = pieSeriesPoint;
			this.Point_DefaultValue = pieSeriesPoint;
			this.Point = pieSeriesPoint1;
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
			this.ShowInLegend_DefaultValue = nullable;
			this.ShowInLegend = nullable;
			string str7 = " ";
			str1 = str7;
			this.Size_DefaultValue = str7;
			this.Size = str1;
			nullable1 = new double?((double)10);
			this.SlicedOffset_DefaultValue = nullable1;
			this.SlicedOffset = nullable1;
			nullable1 = new double?(0);
			this.StartAngle_DefaultValue = nullable1;
			this.StartAngle = nullable1;
			PieSeriesStates pieSeriesState = new PieSeriesStates();
			PieSeriesStates pieSeriesState1 = pieSeriesState;
			this.States_DefaultValue = pieSeriesState;
			this.States = pieSeriesState1;
			nullable = new bool?(false);
			this.StickyTracking_DefaultValue = nullable;
			this.StickyTracking = nullable;
			PieSeriesTooltip pieSeriesTooltip = new PieSeriesTooltip();
			PieSeriesTooltip pieSeriesTooltip1 = pieSeriesTooltip;
			this.Tooltip_DefaultValue = pieSeriesTooltip;
			this.Tooltip = pieSeriesTooltip1;
			int num1 = 0;
			PieSeriesType pieSeriesType = (PieSeriesType)num1;
			this.Type_DefaultValue = (PieSeriesType)num1;
			this.Type = pieSeriesType;
			nullable = new bool?(true);
			this.Visible_DefaultValue = nullable;
			this.Visible = nullable;
			nullable1 = null;
			this.ZIndex_DefaultValue = nullable1;
			this.ZIndex = nullable1;
			string str8 = "y";
			str1 = str8;
			this.ZoneAxis_DefaultValue = str8;
			this.ZoneAxis = str1;
			PieSeriesZones pieSeriesZone = new PieSeriesZones();
			PieSeriesZones pieSeriesZone1 = pieSeriesZone;
			this.Zones_DefaultValue = pieSeriesZone;
			this.Zones = pieSeriesZone1;
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
			animationLimitDefaultValue = this.BorderWidth;
			animationLimit = this.BorderWidth_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("borderWidth", this.BorderWidth);
			}
			if (this.Center != this.Center_DefaultValue)
			{
				hashtables.Add("center", this.Center);
			}
			if (this.ClassName != this.ClassName_DefaultValue)
			{
				hashtables.Add("className", this.ClassName);
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
			if (this.Cursor != this.Cursor_DefaultValue)
			{
				PieSeriesCursor cursor = this.Cursor;
				hashtables.Add("cursor", Highcharts.FirstCharacterToLower(cursor.ToString()));
			}
			if (this.Data.Any<PieSeriesData>())
			{
				hashtables.Add("data", base.HashifyList(this.Data));
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
			allowPointSelectDefaultValue = this.EnableMouseTracking;
			allowPointSelect = this.EnableMouseTracking_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault() ? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue : true))
			{
				hashtables.Add("enableMouseTracking", this.EnableMouseTracking);
			}
			animationLimit = this.EndAngle;
			animationLimitDefaultValue = this.EndAngle_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("endAngle", this.EndAngle);
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
			animationLimitDefaultValue = this.Index;
			animationLimit = this.Index_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("index", this.Index);
			}
			if (this.InnerSize != this.InnerSize_DefaultValue)
			{
				hashtables.Add("innerSize", this.InnerSize);
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
			if (this.LinkedTo != this.LinkedTo_DefaultValue)
			{
				hashtables.Add("linkedTo", this.LinkedTo);
			}
			animationLimitDefaultValue = this.MinSize;
			animationLimit = this.MinSize_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("minSize", this.MinSize);
			}
			if (this.Name != this.Name_DefaultValue)
			{
				hashtables.Add("name", this.Name);
			}
			if (this.Point.IsDirty())
			{
				hashtables.Add("point", this.Point.ToHashtable());
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
			allowPointSelectDefaultValue = this.ShowInLegend;
			allowPointSelect = this.ShowInLegend_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault() ? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue : true))
			{
				hashtables.Add("showInLegend", this.ShowInLegend);
			}
			if (this.Size != this.Size_DefaultValue)
			{
				hashtables.Add("size", this.Size);
			}
			animationLimit = this.SlicedOffset;
			animationLimitDefaultValue = this.SlicedOffset_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("slicedOffset", this.SlicedOffset);
			}
			animationLimitDefaultValue = this.StartAngle;
			animationLimit = this.StartAngle_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("startAngle", this.StartAngle);
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
			if (this.Type != this.Type_DefaultValue)
			{
				PieSeriesType type = this.Type;
				hashtables.Add("type", Highcharts.FirstCharacterToLower(type.ToString()));
			}
			allowPointSelectDefaultValue = this.Visible;
			allowPointSelect = this.Visible_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault() ? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue : true))
			{
				hashtables.Add("visible", this.Visible);
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