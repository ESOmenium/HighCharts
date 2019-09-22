using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsFunnel : BaseObject
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

		public PlotOptionsFunnelCursor Cursor
		{
			get;
			set;
		}

		private PlotOptionsFunnelCursor Cursor_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsFunnelDataLabels DataLabels
		{
			get;
			set;
		}

		private PlotOptionsFunnelDataLabels DataLabels_DefaultValue
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

		public PlotOptionsFunnelEvents Events
		{
			get;
			set;
		}

		private PlotOptionsFunnelEvents Events_DefaultValue
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

		public string Height
		{
			get;
			set;
		}

		private string Height_DefaultValue
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

		public string NeckHeight
		{
			get;
			set;
		}

		private string NeckHeight_DefaultValue
		{
			get;
			set;
		}

		public string NeckWidth
		{
			get;
			set;
		}

		private string NeckWidth_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsFunnelPoint Point
		{
			get;
			set;
		}

		private PlotOptionsFunnelPoint Point_DefaultValue
		{
			get;
			set;
		}

		public bool? Reversed
		{
			get;
			set;
		}

		private bool? Reversed_DefaultValue
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

		public PlotOptionsFunnelStates States
		{
			get;
			set;
		}

		private PlotOptionsFunnelStates States_DefaultValue
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

		public PlotOptionsFunnelTooltip Tooltip
		{
			get;
			set;
		}

		private PlotOptionsFunnelTooltip Tooltip_DefaultValue
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

		public string Width
		{
			get;
			set;
		}

		private string Width_DefaultValue
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

		public PlotOptionsFunnelZones Zones
		{
			get;
			set;
		}

		private PlotOptionsFunnelZones Zones_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsFunnel()
		{
			bool? nullable = new bool?(false);
			this.AllowPointSelect_DefaultValue = nullable;
			this.AllowPointSelect = nullable;
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
			PlotOptionsFunnelCursor plotOptionsFunnelCursor = (PlotOptionsFunnelCursor)num;
			this.Cursor_DefaultValue = (PlotOptionsFunnelCursor)num;
			this.Cursor = plotOptionsFunnelCursor;
			PlotOptionsFunnelDataLabels plotOptionsFunnelDataLabel = new PlotOptionsFunnelDataLabels();
			PlotOptionsFunnelDataLabels plotOptionsFunnelDataLabel1 = plotOptionsFunnelDataLabel;
			this.DataLabels_DefaultValue = plotOptionsFunnelDataLabel;
			this.DataLabels = plotOptionsFunnelDataLabel1;
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
			PlotOptionsFunnelEvents plotOptionsFunnelEvent = new PlotOptionsFunnelEvents();
			PlotOptionsFunnelEvents plotOptionsFunnelEvent1 = plotOptionsFunnelEvent;
			this.Events_DefaultValue = plotOptionsFunnelEvent;
			this.Events = plotOptionsFunnelEvent1;
			nullable = new bool?(false);
			this.GetExtremesFromAll_DefaultValue = nullable;
			this.GetExtremesFromAll = nullable;
			object obj = null;
			str1 = (string)obj;
			this.Height_DefaultValue = (string)obj;
			this.Height = str1;
			List<string> strs2 = new List<string>();
			strs1 = strs2;
			this.Keys_DefaultValue = strs2;
			this.Keys = strs1;
			string str4 = "";
			str1 = str4;
			this.LinkedTo_DefaultValue = str4;
			this.LinkedTo = str1;
			nullable1 = new double?((double)80);
			this.MinSize_DefaultValue = nullable1;
			this.MinSize = nullable1;
			string str5 = "25%";
			str1 = str5;
			this.NeckHeight_DefaultValue = str5;
			this.NeckHeight = str1;
			string str6 = "30%";
			str1 = str6;
			this.NeckWidth_DefaultValue = str6;
			this.NeckWidth = str1;
			PlotOptionsFunnelPoint plotOptionsFunnelPoint = new PlotOptionsFunnelPoint();
			PlotOptionsFunnelPoint plotOptionsFunnelPoint1 = plotOptionsFunnelPoint;
			this.Point_DefaultValue = plotOptionsFunnelPoint;
			this.Point = plotOptionsFunnelPoint1;
			nullable = new bool?(false);
			this.Reversed_DefaultValue = nullable;
			this.Reversed = nullable;
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
			nullable1 = new double?((double)10);
			this.SlicedOffset_DefaultValue = nullable1;
			this.SlicedOffset = nullable1;
			PlotOptionsFunnelStates plotOptionsFunnelState = new PlotOptionsFunnelStates();
			PlotOptionsFunnelStates plotOptionsFunnelState1 = plotOptionsFunnelState;
			this.States_DefaultValue = plotOptionsFunnelState;
			this.States = plotOptionsFunnelState1;
			nullable = new bool?(false);
			this.StickyTracking_DefaultValue = nullable;
			this.StickyTracking = nullable;
			PlotOptionsFunnelTooltip plotOptionsFunnelTooltip = new PlotOptionsFunnelTooltip();
			PlotOptionsFunnelTooltip plotOptionsFunnelTooltip1 = plotOptionsFunnelTooltip;
			this.Tooltip_DefaultValue = plotOptionsFunnelTooltip;
			this.Tooltip = plotOptionsFunnelTooltip1;
			nullable = new bool?(true);
			this.Visible_DefaultValue = nullable;
			this.Visible = nullable;
			string str7 = "90%";
			str1 = str7;
			this.Width_DefaultValue = str7;
			this.Width = str1;
			string str8 = "y";
			str1 = str8;
			this.ZoneAxis_DefaultValue = str8;
			this.ZoneAxis = str1;
			PlotOptionsFunnelZones plotOptionsFunnelZone = new PlotOptionsFunnelZones();
			PlotOptionsFunnelZones plotOptionsFunnelZone1 = plotOptionsFunnelZone;
			this.Zones_DefaultValue = plotOptionsFunnelZone;
			this.Zones = plotOptionsFunnelZone1;
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
				PlotOptionsFunnelCursor cursor = this.Cursor;
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
			if (this.Height != this.Height_DefaultValue)
			{
				hashtables.Add("height", this.Height);
			}
			if (this.Keys != this.Keys_DefaultValue)
			{
				hashtables.Add("keys", this.Keys);
			}
			if (this.LinkedTo != this.LinkedTo_DefaultValue)
			{
				hashtables.Add("linkedTo", this.LinkedTo);
			}
			animationLimit = this.MinSize;
			animationLimitDefaultValue = this.MinSize_DefaultValue;
			if ((animationLimit.GetValueOrDefault() == animationLimitDefaultValue.GetValueOrDefault() ? animationLimit.HasValue != animationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("minSize", this.MinSize);
			}
			if (this.NeckHeight != this.NeckHeight_DefaultValue)
			{
				hashtables.Add("neckHeight", this.NeckHeight);
			}
			if (this.NeckWidth != this.NeckWidth_DefaultValue)
			{
				hashtables.Add("neckWidth", this.NeckWidth);
			}
			if (this.Point.IsDirty())
			{
				hashtables.Add("point", this.Point.ToHashtable());
			}
			allowPointSelectDefaultValue = this.Reversed;
			allowPointSelect = this.Reversed_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault() ? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue : true))
			{
				hashtables.Add("reversed", this.Reversed);
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
			animationLimitDefaultValue = this.SlicedOffset;
			animationLimit = this.SlicedOffset_DefaultValue;
			if ((animationLimitDefaultValue.GetValueOrDefault() == animationLimit.GetValueOrDefault() ? animationLimitDefaultValue.HasValue != animationLimit.HasValue : true))
			{
				hashtables.Add("slicedOffset", this.SlicedOffset);
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
			allowPointSelectDefaultValue = this.Visible;
			allowPointSelect = this.Visible_DefaultValue;
			if ((allowPointSelectDefaultValue.GetValueOrDefault() == allowPointSelect.GetValueOrDefault() ? allowPointSelectDefaultValue.HasValue != allowPointSelect.HasValue : true))
			{
				hashtables.Add("visible", this.Visible);
			}
			if (this.Width != this.Width_DefaultValue)
			{
				hashtables.Add("width", this.Width);
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