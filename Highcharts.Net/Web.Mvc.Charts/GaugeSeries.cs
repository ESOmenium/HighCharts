using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class GaugeSeries : Series
	{
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

		public GaugeSeriesCursor Cursor
		{
			get;
			set;
		}

		private GaugeSeriesCursor Cursor_DefaultValue
		{
			get;
			set;
		}

		public new List<GaugeSeriesData> Data
		{
			get;
			set;
		}

		private List<GaugeSeriesData> Data_DefaultValue
		{
			get;
			set;
		}

		public GaugeSeriesDataLabels DataLabels
		{
			get;
			set;
		}

		private GaugeSeriesDataLabels DataLabels_DefaultValue
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

		public GaugeSeriesDial Dial
		{
			get;
			set;
		}

		private GaugeSeriesDial Dial_DefaultValue
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

		public GaugeSeriesEvents Events
		{
			get;
			set;
		}

		private GaugeSeriesEvents Events_DefaultValue
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

		public double? Overshoot
		{
			get;
			set;
		}

		private double? Overshoot_DefaultValue
		{
			get;
			set;
		}

		public GaugeSeriesPivot Pivot
		{
			get;
			set;
		}

		private GaugeSeriesPivot Pivot_DefaultValue
		{
			get;
			set;
		}

		public GaugeSeriesPoint Point
		{
			get;
			set;
		}

		private GaugeSeriesPoint Point_DefaultValue
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

		public GaugeSeriesTooltip Tooltip
		{
			get;
			set;
		}

		private GaugeSeriesTooltip Tooltip_DefaultValue
		{
			get;
			set;
		}

		public new GaugeSeriesType Type
		{
			get;
			set;
		}

		private GaugeSeriesType Type_DefaultValue
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

		public bool? Wrap
		{
			get;
			set;
		}

		private bool? Wrap_DefaultValue
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

		public GaugeSeries()
		{
			Highsoft.Web.Mvc.Charts.Animation animation = new Highsoft.Web.Mvc.Charts.Animation()
			{
				Enabled = true
			};
			Highsoft.Web.Mvc.Charts.Animation animation1 = animation;
			this.Animation_DefaultValue = animation;
			this.Animation = animation1;
			double? nullable = null;
			this.AnimationLimit_DefaultValue = nullable;
			this.AnimationLimit = nullable;
			string str = "";
			string str1 = str;
			this.ClassName_DefaultValue = str;
			this.ClassName = str1;
			object obj = null;
			str1 = (string)obj;
			this.Color_DefaultValue = (string)obj;
			this.Color = str1;
			nullable = null;
			this.ColorIndex_DefaultValue = nullable;
			this.ColorIndex = nullable;
			int num = 0;
			GaugeSeriesCursor gaugeSeriesCursor = (GaugeSeriesCursor)num;
			this.Cursor_DefaultValue = (GaugeSeriesCursor)num;
			this.Cursor = gaugeSeriesCursor;
			List<GaugeSeriesData> gaugeSeriesDatas = new List<GaugeSeriesData>();
			List<GaugeSeriesData> gaugeSeriesDatas1 = gaugeSeriesDatas;
			this.Data_DefaultValue = gaugeSeriesDatas;
			this.Data = gaugeSeriesDatas1;
			GaugeSeriesDataLabels gaugeSeriesDataLabel = new GaugeSeriesDataLabels();
			GaugeSeriesDataLabels gaugeSeriesDataLabel1 = gaugeSeriesDataLabel;
			this.DataLabels_DefaultValue = gaugeSeriesDataLabel;
			this.DataLabels = gaugeSeriesDataLabel1;
			string str2 = "undefined";
			str1 = str2;
			this.Description_DefaultValue = str2;
			this.Description = str1;
			GaugeSeriesDial gaugeSeriesDial = new GaugeSeriesDial();
			GaugeSeriesDial gaugeSeriesDial1 = gaugeSeriesDial;
			this.Dial_DefaultValue = gaugeSeriesDial;
			this.Dial = gaugeSeriesDial1;
			bool? nullable1 = new bool?(true);
			this.EnableMouseTracking_DefaultValue = nullable1;
			this.EnableMouseTracking = nullable1;
			GaugeSeriesEvents gaugeSeriesEvent = new GaugeSeriesEvents();
			GaugeSeriesEvents gaugeSeriesEvent1 = gaugeSeriesEvent;
			this.Events_DefaultValue = gaugeSeriesEvent;
			this.Events = gaugeSeriesEvent1;
			nullable1 = new bool?(false);
			this.GetExtremesFromAll_DefaultValue = nullable1;
			this.GetExtremesFromAll = nullable1;
			string str3 = "";
			str1 = str3;
			this.Id_DefaultValue = str3;
			this.Id = str1;
			nullable = null;
			this.Index_DefaultValue = nullable;
			this.Index = nullable;
			List<string> strs = new List<string>();
			List<string> strs1 = strs;
			this.Keys_DefaultValue = strs;
			this.Keys = strs1;
			nullable = null;
			this.LegendIndex_DefaultValue = nullable;
			this.LegendIndex = nullable;
			string str4 = "";
			str1 = str4;
			this.LinkedTo_DefaultValue = str4;
			this.LinkedTo = str1;
			object obj1 = null;
			str1 = (string)obj1;
			this.Name_DefaultValue = (string)obj1;
			this.Name = str1;
			string str5 = "null";
			str1 = str5;
			this.NegativeColor_DefaultValue = str5;
			this.NegativeColor = str1;
			nullable = new double?(0);
			this.Overshoot_DefaultValue = nullable;
			this.Overshoot = nullable;
			GaugeSeriesPivot gaugeSeriesPivot = new GaugeSeriesPivot();
			GaugeSeriesPivot gaugeSeriesPivot1 = gaugeSeriesPivot;
			this.Pivot_DefaultValue = gaugeSeriesPivot;
			this.Pivot = gaugeSeriesPivot1;
			GaugeSeriesPoint gaugeSeriesPoint = new GaugeSeriesPoint();
			GaugeSeriesPoint gaugeSeriesPoint1 = gaugeSeriesPoint;
			this.Point_DefaultValue = gaugeSeriesPoint;
			this.Point = gaugeSeriesPoint1;
			nullable1 = new bool?(false);
			this.Selected_DefaultValue = nullable1;
			this.Selected = nullable1;
			nullable1 = new bool?(false);
			this.ShowCheckbox_DefaultValue = nullable1;
			this.ShowCheckbox = nullable1;
			nullable1 = null;
			this.ShowInLegend_DefaultValue = nullable1;
			this.ShowInLegend = nullable1;
			nullable1 = new bool?(true);
			this.StickyTracking_DefaultValue = nullable1;
			this.StickyTracking = nullable1;
			nullable = new double?(0);
			this.Threshold_DefaultValue = nullable;
			this.Threshold = nullable;
			GaugeSeriesTooltip gaugeSeriesTooltip = new GaugeSeriesTooltip();
			GaugeSeriesTooltip gaugeSeriesTooltip1 = gaugeSeriesTooltip;
			this.Tooltip_DefaultValue = gaugeSeriesTooltip;
			this.Tooltip = gaugeSeriesTooltip1;
			int num1 = 0;
			GaugeSeriesType gaugeSeriesType = (GaugeSeriesType)num1;
			this.Type_DefaultValue = (GaugeSeriesType)num1;
			this.Type = gaugeSeriesType;
			nullable1 = new bool?(true);
			this.Visible_DefaultValue = nullable1;
			this.Visible = nullable1;
			nullable1 = new bool?(true);
			this.Wrap_DefaultValue = nullable1;
			this.Wrap = nullable1;
			string str6 = "0";
			str1 = str6;
			this.XAxis_DefaultValue = str6;
			this.XAxis = str1;
			string str7 = "0";
			str1 = str7;
			this.YAxis_DefaultValue = str7;
			this.YAxis = str1;
			nullable = null;
			this.ZIndex_DefaultValue = nullable;
			this.ZIndex = nullable;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
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
			if (this.Cursor != this.Cursor_DefaultValue)
			{
				GaugeSeriesCursor cursor = this.Cursor;
				hashtables.Add("cursor", Highcharts.FirstCharacterToLower(cursor.ToString()));
			}
			if (this.Data.Any<GaugeSeriesData>())
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
			if (this.Dial.IsDirty())
			{
				hashtables.Add("dial", this.Dial.ToHashtable());
			}
			bool? enableMouseTracking = this.EnableMouseTracking;
			bool? enableMouseTrackingDefaultValue = this.EnableMouseTracking_DefaultValue;
			if ((enableMouseTracking.GetValueOrDefault() == enableMouseTrackingDefaultValue.GetValueOrDefault() ? enableMouseTracking.HasValue != enableMouseTrackingDefaultValue.HasValue : true))
			{
				hashtables.Add("enableMouseTracking", this.EnableMouseTracking);
			}
			if (this.Events.IsDirty())
			{
				hashtables.Add("events", this.Events.ToHashtable());
			}
			enableMouseTrackingDefaultValue = this.GetExtremesFromAll;
			enableMouseTracking = this.GetExtremesFromAll_DefaultValue;
			if ((enableMouseTrackingDefaultValue.GetValueOrDefault() == enableMouseTracking.GetValueOrDefault() ? enableMouseTrackingDefaultValue.HasValue != enableMouseTracking.HasValue : true))
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
			animationLimit = this.Overshoot;
			animationLimitDefaultValue = this.Overshoot_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("overshoot", this.Overshoot);
			}
			if (this.Pivot.IsDirty())
			{
				hashtables.Add("pivot", this.Pivot.ToHashtable());
			}
			if (this.Point.IsDirty())
			{
				hashtables.Add("point", this.Point.ToHashtable());
			}
			enableMouseTracking = this.Selected;
			enableMouseTrackingDefaultValue = this.Selected_DefaultValue;
			if ((enableMouseTracking.GetValueOrDefault() == enableMouseTrackingDefaultValue.GetValueOrDefault() ? enableMouseTracking.HasValue != enableMouseTrackingDefaultValue.HasValue : true))
			{
				hashtables.Add("selected", this.Selected);
			}
			enableMouseTrackingDefaultValue = this.ShowCheckbox;
			enableMouseTracking = this.ShowCheckbox_DefaultValue;
			if ((enableMouseTrackingDefaultValue.GetValueOrDefault() == enableMouseTracking.GetValueOrDefault() ? enableMouseTrackingDefaultValue.HasValue != enableMouseTracking.HasValue : true))
			{
				hashtables.Add("showCheckbox", this.ShowCheckbox);
			}
			enableMouseTracking = this.ShowInLegend;
			enableMouseTrackingDefaultValue = this.ShowInLegend_DefaultValue;
			if ((enableMouseTracking.GetValueOrDefault() == enableMouseTrackingDefaultValue.GetValueOrDefault() ? enableMouseTracking.HasValue != enableMouseTrackingDefaultValue.HasValue : true))
			{
				hashtables.Add("showInLegend", this.ShowInLegend);
			}
			enableMouseTrackingDefaultValue = this.StickyTracking;
			enableMouseTracking = this.StickyTracking_DefaultValue;
			if ((enableMouseTrackingDefaultValue.GetValueOrDefault() == enableMouseTracking.GetValueOrDefault() ? enableMouseTrackingDefaultValue.HasValue != enableMouseTracking.HasValue : true))
			{
				hashtables.Add("stickyTracking", this.StickyTracking);
			}
			animationLimitDefaultValue = this.Threshold;
			animationLimit = this.Threshold_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("threshold", this.Threshold);
			}
			if (this.Tooltip.IsDirty())
			{
				hashtables.Add("tooltip", this.Tooltip.ToHashtable());
			}
			if (this.Type != this.Type_DefaultValue)
			{
				GaugeSeriesType type = this.Type;
				hashtables.Add("type", Highcharts.FirstCharacterToLower(type.ToString()));
			}
			enableMouseTracking = this.Visible;
			enableMouseTrackingDefaultValue = this.Visible_DefaultValue;
			if ((enableMouseTracking.GetValueOrDefault() == enableMouseTrackingDefaultValue.GetValueOrDefault() ? enableMouseTracking.HasValue != enableMouseTrackingDefaultValue.HasValue : true))
			{
				hashtables.Add("visible", this.Visible);
			}
			enableMouseTrackingDefaultValue = this.Wrap;
			enableMouseTracking = this.Wrap_DefaultValue;
			if ((enableMouseTrackingDefaultValue.GetValueOrDefault() == enableMouseTracking.GetValueOrDefault() ? enableMouseTrackingDefaultValue.HasValue != enableMouseTracking.HasValue : true))
			{
				hashtables.Add("wrap", this.Wrap);
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