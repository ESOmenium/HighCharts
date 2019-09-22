using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class XAxis : BaseObject
	{
		public bool? AllowDecimals
		{
			get;
			set;
		}

		private bool? AllowDecimals_DefaultValue
		{
			get;
			set;
		}

		public string AlternateGridColor
		{
			get;
			set;
		}

		private string AlternateGridColor_DefaultValue
		{
			get;
			set;
		}

		public XAxisBreaks Breaks
		{
			get;
			set;
		}

		private XAxisBreaks Breaks_DefaultValue
		{
			get;
			set;
		}

		public List<string> Categories
		{
			get;
			set;
		}

		private List<string> Categories_DefaultValue
		{
			get;
			set;
		}

		public double? Ceiling
		{
			get;
			set;
		}

		private double? Ceiling_DefaultValue
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

		public XAxisCrosshair Crosshair
		{
			get;
			set;
		}

		private XAxisCrosshair Crosshair_DefaultValue
		{
			get;
			set;
		}

		public Hashtable DateTimeLabelFormats
		{
			get;
			set;
		}

		private Hashtable DateTimeLabelFormats_DefaultValue
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

		public bool? EndOnTick
		{
			get;
			set;
		}

		private bool? EndOnTick_DefaultValue
		{
			get;
			set;
		}

		public XAxisEvents Events
		{
			get;
			set;
		}

		private XAxisEvents Events_DefaultValue
		{
			get;
			set;
		}

		public double? Floor
		{
			get;
			set;
		}

		private double? Floor_DefaultValue
		{
			get;
			set;
		}

		public string GridLineColor
		{
			get;
			set;
		}

		private string GridLineColor_DefaultValue
		{
			get;
			set;
		}

		public XAxisGridLineDashStyle GridLineDashStyle
		{
			get;
			set;
		}

		private XAxisGridLineDashStyle GridLineDashStyle_DefaultValue
		{
			get;
			set;
		}

		public double? GridLineWidth
		{
			get;
			set;
		}

		private double? GridLineWidth_DefaultValue
		{
			get;
			set;
		}

		public double? GridZIndex
		{
			get;
			set;
		}

		private double? GridZIndex_DefaultValue
		{
			get;
			set;
		}

		public string Id
		{
			get;
			set;
		}

		private string Id_DefaultValue
		{
			get;
			set;
		}

		public XAxisLabels Labels
		{
			get;
			set;
		}

		private XAxisLabels Labels_DefaultValue
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

		public double? LinkedTo
		{
			get;
			set;
		}

		private double? LinkedTo_DefaultValue
		{
			get;
			set;
		}

		public double? Max
		{
			get;
			set;
		}

		private double? Max_DefaultValue
		{
			get;
			set;
		}

		public double? MaxPadding
		{
			get;
			set;
		}

		private double? MaxPadding_DefaultValue
		{
			get;
			set;
		}

		public double? Min
		{
			get;
			set;
		}

		private double? Min_DefaultValue
		{
			get;
			set;
		}

		public string MinorGridLineColor
		{
			get;
			set;
		}

		private string MinorGridLineColor_DefaultValue
		{
			get;
			set;
		}

		public XAxisMinorGridLineDashStyle MinorGridLineDashStyle
		{
			get;
			set;
		}

		private XAxisMinorGridLineDashStyle MinorGridLineDashStyle_DefaultValue
		{
			get;
			set;
		}

		public double? MinorGridLineWidth
		{
			get;
			set;
		}

		private double? MinorGridLineWidth_DefaultValue
		{
			get;
			set;
		}

		public string MinorTickColor
		{
			get;
			set;
		}

		private string MinorTickColor_DefaultValue
		{
			get;
			set;
		}

		public string MinorTickInterval
		{
			get;
			set;
		}

		private string MinorTickInterval_DefaultValue
		{
			get;
			set;
		}

		public double? MinorTickLength
		{
			get;
			set;
		}

		private double? MinorTickLength_DefaultValue
		{
			get;
			set;
		}

		public XAxisMinorTickPosition MinorTickPosition
		{
			get;
			set;
		}

		private XAxisMinorTickPosition MinorTickPosition_DefaultValue
		{
			get;
			set;
		}

		public double? MinorTickWidth
		{
			get;
			set;
		}

		private double? MinorTickWidth_DefaultValue
		{
			get;
			set;
		}

		public double? MinPadding
		{
			get;
			set;
		}

		private double? MinPadding_DefaultValue
		{
			get;
			set;
		}

		public double? MinRange
		{
			get;
			set;
		}

		private double? MinRange_DefaultValue
		{
			get;
			set;
		}

		public double? MinTickInterval
		{
			get;
			set;
		}

		private double? MinTickInterval_DefaultValue
		{
			get;
			set;
		}

		public bool? NameToX
		{
			get;
			set;
		}

		private bool? NameToX_DefaultValue
		{
			get;
			set;
		}

		public double? Offset
		{
			get;
			set;
		}

		private double? Offset_DefaultValue
		{
			get;
			set;
		}

		public bool? Opposite
		{
			get;
			set;
		}

		private bool? Opposite_DefaultValue
		{
			get;
			set;
		}

		public List<XAxisPlotBands> PlotBands
		{
			get;
			set;
		}

		private List<XAxisPlotBands> PlotBands_DefaultValue
		{
			get;
			set;
		}

		public List<XAxisPlotLines> PlotLines
		{
			get;
			set;
		}

		private List<XAxisPlotLines> PlotLines_DefaultValue
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

		public bool? ShowEmpty
		{
			get;
			set;
		}

		private bool? ShowEmpty_DefaultValue
		{
			get;
			set;
		}

		public bool? ShowFirstLabel
		{
			get;
			set;
		}

		private bool? ShowFirstLabel_DefaultValue
		{
			get;
			set;
		}

		public bool? ShowLastLabel
		{
			get;
			set;
		}

		private bool? ShowLastLabel_DefaultValue
		{
			get;
			set;
		}

		public double? SoftMax
		{
			get;
			set;
		}

		private double? SoftMax_DefaultValue
		{
			get;
			set;
		}

		public double? SoftMin
		{
			get;
			set;
		}

		private double? SoftMin_DefaultValue
		{
			get;
			set;
		}

		public double? StartOfWeek
		{
			get;
			set;
		}

		private double? StartOfWeek_DefaultValue
		{
			get;
			set;
		}

		public bool? StartOnTick
		{
			get;
			set;
		}

		private bool? StartOnTick_DefaultValue
		{
			get;
			set;
		}

		public double? TickAmount
		{
			get;
			set;
		}

		private double? TickAmount_DefaultValue
		{
			get;
			set;
		}

		public string TickColor
		{
			get;
			set;
		}

		private string TickColor_DefaultValue
		{
			get;
			set;
		}

		public double? TickInterval
		{
			get;
			set;
		}

		private double? TickInterval_DefaultValue
		{
			get;
			set;
		}

		public double? TickLength
		{
			get;
			set;
		}

		private double? TickLength_DefaultValue
		{
			get;
			set;
		}

		public XAxisTickmarkPlacement TickmarkPlacement
		{
			get;
			set;
		}

		private XAxisTickmarkPlacement TickmarkPlacement_DefaultValue
		{
			get;
			set;
		}

		public double? TickPixelInterval
		{
			get;
			set;
		}

		private double? TickPixelInterval_DefaultValue
		{
			get;
			set;
		}

		public XAxisTickPosition TickPosition
		{
			get;
			set;
		}

		private XAxisTickPosition TickPosition_DefaultValue
		{
			get;
			set;
		}

		public string TickPositioner
		{
			get;
			set;
		}

		private string TickPositioner_DefaultValue
		{
			get;
			set;
		}

		public List<double> TickPositions
		{
			get;
			set;
		}

		private List<double> TickPositions_DefaultValue
		{
			get;
			set;
		}

		public double? TickWidth
		{
			get;
			set;
		}

		private double? TickWidth_DefaultValue
		{
			get;
			set;
		}

		public XAxisTitle Title
		{
			get;
			set;
		}

		private XAxisTitle Title_DefaultValue
		{
			get;
			set;
		}

		public XAxisType Type
		{
			get;
			set;
		}

		private XAxisType Type_DefaultValue
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

		public XAxis()
		{
			bool? nullable = new bool?(true);
			this.AllowDecimals_DefaultValue = nullable;
			this.AllowDecimals = nullable;
			object obj = null;
			string str = (string)obj;
			this.AlternateGridColor_DefaultValue = (string)obj;
			this.AlternateGridColor = str;
			XAxisBreaks xAxisBreak = new XAxisBreaks();
			XAxisBreaks xAxisBreak1 = xAxisBreak;
			this.Breaks_DefaultValue = xAxisBreak;
			this.Breaks = xAxisBreak1;
			object obj1 = null;
			List<string> strs = (List<string>)obj1;
			this.Categories_DefaultValue = (List<string>)obj1;
			this.Categories = strs;
			double? nullable1 = null;
			this.Ceiling_DefaultValue = nullable1;
			this.Ceiling = nullable1;
			string str1 = "";
			str = str1;
			this.ClassName_DefaultValue = str1;
			this.ClassName = str;
			XAxisCrosshair xAxisCrosshair = new XAxisCrosshair();
			XAxisCrosshair xAxisCrosshair1 = xAxisCrosshair;
			this.Crosshair_DefaultValue = xAxisCrosshair;
			this.Crosshair = xAxisCrosshair1;
			Hashtable hashtables = new Hashtable();
			Hashtable hashtables1 = hashtables;
			this.DateTimeLabelFormats_DefaultValue = hashtables;
			this.DateTimeLabelFormats = hashtables1;
			string str2 = "undefined";
			str = str2;
			this.Description_DefaultValue = str2;
			this.Description = str;
			nullable = new bool?(false);
			this.EndOnTick_DefaultValue = nullable;
			this.EndOnTick = nullable;
			XAxisEvents xAxisEvent = new XAxisEvents();
			XAxisEvents xAxisEvent1 = xAxisEvent;
			this.Events_DefaultValue = xAxisEvent;
			this.Events = xAxisEvent1;
			nullable1 = null;
			this.Floor_DefaultValue = nullable1;
			this.Floor = nullable1;
			string str3 = "#e6e6e6";
			str = str3;
			this.GridLineColor_DefaultValue = str3;
			this.GridLineColor = str;
			int num = 0;
			XAxisGridLineDashStyle xAxisGridLineDashStyle = (XAxisGridLineDashStyle)num;
			this.GridLineDashStyle_DefaultValue = (XAxisGridLineDashStyle)num;
			this.GridLineDashStyle = xAxisGridLineDashStyle;
			nullable1 = new double?(0);
			this.GridLineWidth_DefaultValue = nullable1;
			this.GridLineWidth = nullable1;
			nullable1 = new double?((double)1);
			this.GridZIndex_DefaultValue = nullable1;
			this.GridZIndex = nullable1;
			object obj2 = null;
			str = (string)obj2;
			this.Id_DefaultValue = (string)obj2;
			this.Id = str;
			XAxisLabels xAxisLabel = new XAxisLabels();
			XAxisLabels xAxisLabel1 = xAxisLabel;
			this.Labels_DefaultValue = xAxisLabel;
			this.Labels = xAxisLabel1;
			string str4 = "#ccd6eb";
			str = str4;
			this.LineColor_DefaultValue = str4;
			this.LineColor = str;
			nullable1 = new double?((double)1);
			this.LineWidth_DefaultValue = nullable1;
			this.LineWidth = nullable1;
			nullable1 = null;
			this.LinkedTo_DefaultValue = nullable1;
			this.LinkedTo = nullable1;
			nullable1 = null;
			this.Max_DefaultValue = nullable1;
			this.Max = nullable1;
			nullable1 = new double?(0.01);
			this.MaxPadding_DefaultValue = nullable1;
			this.MaxPadding = nullable1;
			nullable1 = null;
			this.Min_DefaultValue = nullable1;
			this.Min = nullable1;
			nullable1 = new double?(0.01);
			this.MinPadding_DefaultValue = nullable1;
			this.MinPadding = nullable1;
			nullable1 = null;
			this.MinRange_DefaultValue = nullable1;
			this.MinRange = nullable1;
			nullable1 = null;
			this.MinTickInterval_DefaultValue = nullable1;
			this.MinTickInterval = nullable1;
			string str5 = "#f2f2f2";
			str = str5;
			this.MinorGridLineColor_DefaultValue = str5;
			this.MinorGridLineColor = str;
			int num1 = 0;
			XAxisMinorGridLineDashStyle xAxisMinorGridLineDashStyle = (XAxisMinorGridLineDashStyle)num1;
			this.MinorGridLineDashStyle_DefaultValue = (XAxisMinorGridLineDashStyle)num1;
			this.MinorGridLineDashStyle = xAxisMinorGridLineDashStyle;
			nullable1 = new double?((double)1);
			this.MinorGridLineWidth_DefaultValue = nullable1;
			this.MinorGridLineWidth = nullable1;
			string str6 = "#999999";
			str = str6;
			this.MinorTickColor_DefaultValue = str6;
			this.MinorTickColor = str;
			object obj3 = null;
			str = (string)obj3;
			this.MinorTickInterval_DefaultValue = (string)obj3;
			this.MinorTickInterval = str;
			nullable1 = new double?((double)2);
			this.MinorTickLength_DefaultValue = nullable1;
			this.MinorTickLength = nullable1;
			int num2 = 1;
			XAxisMinorTickPosition xAxisMinorTickPosition = (XAxisMinorTickPosition)num2;
			this.MinorTickPosition_DefaultValue = (XAxisMinorTickPosition)num2;
			this.MinorTickPosition = xAxisMinorTickPosition;
			nullable1 = new double?(0);
			this.MinorTickWidth_DefaultValue = nullable1;
			this.MinorTickWidth = nullable1;
			nullable = new bool?(true);
			this.NameToX_DefaultValue = nullable;
			this.NameToX = nullable;
			nullable1 = new double?(0);
			this.Offset_DefaultValue = nullable1;
			this.Offset = nullable1;
			nullable = new bool?(false);
			this.Opposite_DefaultValue = nullable;
			this.Opposite = nullable;
			List<XAxisPlotBands> xAxisPlotBands = new List<XAxisPlotBands>();
			List<XAxisPlotBands> xAxisPlotBands1 = xAxisPlotBands;
			this.PlotBands_DefaultValue = xAxisPlotBands;
			this.PlotBands = xAxisPlotBands1;
			List<XAxisPlotLines> xAxisPlotLines = new List<XAxisPlotLines>();
			List<XAxisPlotLines> xAxisPlotLines1 = xAxisPlotLines;
			this.PlotLines_DefaultValue = xAxisPlotLines;
			this.PlotLines = xAxisPlotLines1;
			nullable = new bool?(false);
			this.Reversed_DefaultValue = nullable;
			this.Reversed = nullable;
			nullable = new bool?(true);
			this.ShowEmpty_DefaultValue = nullable;
			this.ShowEmpty = nullable;
			nullable = new bool?(true);
			this.ShowFirstLabel_DefaultValue = nullable;
			this.ShowFirstLabel = nullable;
			nullable = new bool?(true);
			this.ShowLastLabel_DefaultValue = nullable;
			this.ShowLastLabel = nullable;
			nullable1 = null;
			this.SoftMax_DefaultValue = nullable1;
			this.SoftMax = nullable1;
			nullable1 = null;
			this.SoftMin_DefaultValue = nullable1;
			this.SoftMin = nullable1;
			nullable1 = new double?((double)1);
			this.StartOfWeek_DefaultValue = nullable1;
			this.StartOfWeek = nullable1;
			nullable = new bool?(false);
			this.StartOnTick_DefaultValue = nullable;
			this.StartOnTick = nullable;
			nullable1 = null;
			this.TickAmount_DefaultValue = nullable1;
			this.TickAmount = nullable1;
			string str7 = "#ccd6eb";
			str = str7;
			this.TickColor_DefaultValue = str7;
			this.TickColor = str;
			nullable1 = null;
			this.TickInterval_DefaultValue = nullable1;
			this.TickInterval = nullable1;
			nullable1 = new double?((double)10);
			this.TickLength_DefaultValue = nullable1;
			this.TickLength = nullable1;
			nullable1 = null;
			this.TickPixelInterval_DefaultValue = nullable1;
			this.TickPixelInterval = nullable1;
			int num3 = 1;
			XAxisTickPosition xAxisTickPosition = (XAxisTickPosition)num3;
			this.TickPosition_DefaultValue = (XAxisTickPosition)num3;
			this.TickPosition = xAxisTickPosition;
			string str8 = "";
			str = str8;
			this.TickPositioner_DefaultValue = str8;
			this.TickPositioner = str;
			object obj4 = null;
			List<double> nums = (List<double>)obj4;
			this.TickPositions_DefaultValue = (List<double>)obj4;
			this.TickPositions = nums;
			nullable1 = new double?((double)1);
			this.TickWidth_DefaultValue = nullable1;
			this.TickWidth = nullable1;
			int num4 = 0;
			XAxisTickmarkPlacement xAxisTickmarkPlacement = (XAxisTickmarkPlacement)num4;
			this.TickmarkPlacement_DefaultValue = (XAxisTickmarkPlacement)num4;
			this.TickmarkPlacement = xAxisTickmarkPlacement;
			XAxisTitle xAxisTitle = new XAxisTitle();
			XAxisTitle xAxisTitle1 = xAxisTitle;
			this.Title_DefaultValue = xAxisTitle;
			this.Title = xAxisTitle1;
			int num5 = 0;
			XAxisType xAxisType = (XAxisType)num5;
			this.Type_DefaultValue = (XAxisType)num5;
			this.Type = xAxisType;
			nullable = new bool?(true);
			this.Visible_DefaultValue = nullable;
			this.Visible = nullable;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			bool? allowDecimals = this.AllowDecimals;
			bool? allowDecimalsDefaultValue = this.AllowDecimals_DefaultValue;
			if ((allowDecimals.GetValueOrDefault() == allowDecimalsDefaultValue.GetValueOrDefault() ? allowDecimals.HasValue != allowDecimalsDefaultValue.HasValue : true))
			{
				hashtables.Add("allowDecimals", this.AllowDecimals);
			}
			if (this.AlternateGridColor != this.AlternateGridColor_DefaultValue)
			{
				hashtables.Add("alternateGridColor", this.AlternateGridColor);
			}
			if (this.Breaks.IsDirty())
			{
				hashtables.Add("breaks", this.Breaks.ToHashtable());
			}
			if (this.Categories != this.Categories_DefaultValue)
			{
				hashtables.Add("categories", this.Categories);
			}
			double? ceiling = this.Ceiling;
			double? ceilingDefaultValue = this.Ceiling_DefaultValue;
			if ((ceiling.GetValueOrDefault() == ceilingDefaultValue.GetValueOrDefault() ? ceiling.HasValue != ceilingDefaultValue.HasValue : true))
			{
				hashtables.Add("ceiling", this.Ceiling);
			}
			if (this.ClassName != this.ClassName_DefaultValue)
			{
				hashtables.Add("className", this.ClassName);
			}
			if (this.Crosshair.IsDirty())
			{
				hashtables.Add("crosshair", this.Crosshair.ToHashtable());
			}
			if (this.DateTimeLabelFormats != this.DateTimeLabelFormats_DefaultValue)
			{
				hashtables.Add("dateTimeLabelFormats", this.DateTimeLabelFormats);
			}
			if (this.Description != this.Description_DefaultValue)
			{
				hashtables.Add("description", this.Description);
			}
			allowDecimalsDefaultValue = this.EndOnTick;
			allowDecimals = this.EndOnTick_DefaultValue;
			if ((allowDecimalsDefaultValue.GetValueOrDefault() == allowDecimals.GetValueOrDefault() ? allowDecimalsDefaultValue.HasValue != allowDecimals.HasValue : true))
			{
				hashtables.Add("endOnTick", this.EndOnTick);
			}
			if (this.Events.IsDirty())
			{
				hashtables.Add("events", this.Events.ToHashtable());
			}
			ceilingDefaultValue = this.Floor;
			ceiling = this.Floor_DefaultValue;
			if ((ceilingDefaultValue.GetValueOrDefault() == ceiling.GetValueOrDefault() ? ceilingDefaultValue.HasValue != ceiling.HasValue : true))
			{
				hashtables.Add("floor", this.Floor);
			}
			if (this.GridLineColor != this.GridLineColor_DefaultValue)
			{
				hashtables.Add("gridLineColor", this.GridLineColor);
			}
			if (this.GridLineDashStyle != this.GridLineDashStyle_DefaultValue)
			{
				XAxisGridLineDashStyle gridLineDashStyle = this.GridLineDashStyle;
				hashtables.Add("gridLineDashStyle", Highcharts.FirstCharacterToLower(gridLineDashStyle.ToString()));
			}
			ceiling = this.GridLineWidth;
			ceilingDefaultValue = this.GridLineWidth_DefaultValue;
			if ((ceiling.GetValueOrDefault() == ceilingDefaultValue.GetValueOrDefault() ? ceiling.HasValue != ceilingDefaultValue.HasValue : true))
			{
				hashtables.Add("gridLineWidth", this.GridLineWidth);
			}
			ceilingDefaultValue = this.GridZIndex;
			ceiling = this.GridZIndex_DefaultValue;
			if ((ceilingDefaultValue.GetValueOrDefault() == ceiling.GetValueOrDefault() ? ceilingDefaultValue.HasValue != ceiling.HasValue : true))
			{
				hashtables.Add("gridZIndex", this.GridZIndex);
			}
			if (this.Id != this.Id_DefaultValue)
			{
				hashtables.Add("id", this.Id);
			}
			if (this.Labels.IsDirty())
			{
				hashtables.Add("labels", this.Labels.ToHashtable());
			}
			if (this.LineColor != this.LineColor_DefaultValue)
			{
				hashtables.Add("lineColor", this.LineColor);
			}
			ceiling = this.LineWidth;
			ceilingDefaultValue = this.LineWidth_DefaultValue;
			if ((ceiling.GetValueOrDefault() == ceilingDefaultValue.GetValueOrDefault() ? ceiling.HasValue != ceilingDefaultValue.HasValue : true))
			{
				hashtables.Add("lineWidth", this.LineWidth);
			}
			ceilingDefaultValue = this.LinkedTo;
			ceiling = this.LinkedTo_DefaultValue;
			if ((ceilingDefaultValue.GetValueOrDefault() == ceiling.GetValueOrDefault() ? ceilingDefaultValue.HasValue != ceiling.HasValue : true))
			{
				hashtables.Add("linkedTo", this.LinkedTo);
			}
			ceiling = this.Max;
			ceilingDefaultValue = this.Max_DefaultValue;
			if ((ceiling.GetValueOrDefault() == ceilingDefaultValue.GetValueOrDefault() ? ceiling.HasValue != ceilingDefaultValue.HasValue : true))
			{
				hashtables.Add("max", this.Max);
			}
			ceilingDefaultValue = this.MaxPadding;
			ceiling = this.MaxPadding_DefaultValue;
			if ((ceilingDefaultValue.GetValueOrDefault() == ceiling.GetValueOrDefault() ? ceilingDefaultValue.HasValue != ceiling.HasValue : true))
			{
				hashtables.Add("maxPadding", this.MaxPadding);
			}
			ceiling = this.Min;
			ceilingDefaultValue = this.Min_DefaultValue;
			if ((ceiling.GetValueOrDefault() == ceilingDefaultValue.GetValueOrDefault() ? ceiling.HasValue != ceilingDefaultValue.HasValue : true))
			{
				hashtables.Add("min", this.Min);
			}
			ceilingDefaultValue = this.MinPadding;
			ceiling = this.MinPadding_DefaultValue;
			if ((ceilingDefaultValue.GetValueOrDefault() == ceiling.GetValueOrDefault() ? ceilingDefaultValue.HasValue != ceiling.HasValue : true))
			{
				hashtables.Add("minPadding", this.MinPadding);
			}
			ceiling = this.MinRange;
			ceilingDefaultValue = this.MinRange_DefaultValue;
			if ((ceiling.GetValueOrDefault() == ceilingDefaultValue.GetValueOrDefault() ? ceiling.HasValue != ceilingDefaultValue.HasValue : true))
			{
				hashtables.Add("minRange", this.MinRange);
			}
			ceilingDefaultValue = this.MinTickInterval;
			ceiling = this.MinTickInterval_DefaultValue;
			if ((ceilingDefaultValue.GetValueOrDefault() == ceiling.GetValueOrDefault() ? ceilingDefaultValue.HasValue != ceiling.HasValue : true))
			{
				hashtables.Add("minTickInterval", this.MinTickInterval);
			}
			if (this.MinorGridLineColor != this.MinorGridLineColor_DefaultValue)
			{
				hashtables.Add("minorGridLineColor", this.MinorGridLineColor);
			}
			if (this.MinorGridLineDashStyle != this.MinorGridLineDashStyle_DefaultValue)
			{
				XAxisMinorGridLineDashStyle minorGridLineDashStyle = this.MinorGridLineDashStyle;
				hashtables.Add("minorGridLineDashStyle", Highcharts.FirstCharacterToLower(minorGridLineDashStyle.ToString()));
			}
			ceiling = this.MinorGridLineWidth;
			ceilingDefaultValue = this.MinorGridLineWidth_DefaultValue;
			if ((ceiling.GetValueOrDefault() == ceilingDefaultValue.GetValueOrDefault() ? ceiling.HasValue != ceilingDefaultValue.HasValue : true))
			{
				hashtables.Add("minorGridLineWidth", this.MinorGridLineWidth);
			}
			if (this.MinorTickColor != this.MinorTickColor_DefaultValue)
			{
				hashtables.Add("minorTickColor", this.MinorTickColor);
			}
			if (this.MinorTickInterval != this.MinorTickInterval_DefaultValue)
			{
				hashtables.Add("minorTickInterval", this.MinorTickInterval);
			}
			ceilingDefaultValue = this.MinorTickLength;
			ceiling = this.MinorTickLength_DefaultValue;
			if ((ceilingDefaultValue.GetValueOrDefault() == ceiling.GetValueOrDefault() ? ceilingDefaultValue.HasValue != ceiling.HasValue : true))
			{
				hashtables.Add("minorTickLength", this.MinorTickLength);
			}
			if (this.MinorTickPosition != this.MinorTickPosition_DefaultValue)
			{
				XAxisMinorTickPosition minorTickPosition = this.MinorTickPosition;
				hashtables.Add("minorTickPosition", Highcharts.FirstCharacterToLower(minorTickPosition.ToString()));
			}
			ceiling = this.MinorTickWidth;
			ceilingDefaultValue = this.MinorTickWidth_DefaultValue;
			if ((ceiling.GetValueOrDefault() == ceilingDefaultValue.GetValueOrDefault() ? ceiling.HasValue != ceilingDefaultValue.HasValue : true))
			{
				hashtables.Add("minorTickWidth", this.MinorTickWidth);
			}
			allowDecimals = this.NameToX;
			allowDecimalsDefaultValue = this.NameToX_DefaultValue;
			if ((allowDecimals.GetValueOrDefault() == allowDecimalsDefaultValue.GetValueOrDefault() ? allowDecimals.HasValue != allowDecimalsDefaultValue.HasValue : true))
			{
				hashtables.Add("nameToX", this.NameToX);
			}
			ceilingDefaultValue = this.Offset;
			ceiling = this.Offset_DefaultValue;
			if ((ceilingDefaultValue.GetValueOrDefault() == ceiling.GetValueOrDefault() ? ceilingDefaultValue.HasValue != ceiling.HasValue : true))
			{
				hashtables.Add("offset", this.Offset);
			}
			allowDecimalsDefaultValue = this.Opposite;
			allowDecimals = this.Opposite_DefaultValue;
			if ((allowDecimalsDefaultValue.GetValueOrDefault() == allowDecimals.GetValueOrDefault() ? allowDecimalsDefaultValue.HasValue != allowDecimals.HasValue : true))
			{
				hashtables.Add("opposite", this.Opposite);
			}
			if (this.PlotBands != this.PlotBands_DefaultValue)
			{
				hashtables.Add("plotBands", base.HashifyList(this.PlotBands));
			}
			if (this.PlotLines != this.PlotLines_DefaultValue)
			{
				hashtables.Add("plotLines", base.HashifyList(this.PlotLines));
			}
			allowDecimals = this.Reversed;
			allowDecimalsDefaultValue = this.Reversed_DefaultValue;
			if ((allowDecimals.GetValueOrDefault() == allowDecimalsDefaultValue.GetValueOrDefault() ? allowDecimals.HasValue != allowDecimalsDefaultValue.HasValue : true))
			{
				hashtables.Add("reversed", this.Reversed);
			}
			allowDecimalsDefaultValue = this.ShowEmpty;
			allowDecimals = this.ShowEmpty_DefaultValue;
			if ((allowDecimalsDefaultValue.GetValueOrDefault() == allowDecimals.GetValueOrDefault() ? allowDecimalsDefaultValue.HasValue != allowDecimals.HasValue : true))
			{
				hashtables.Add("showEmpty", this.ShowEmpty);
			}
			allowDecimals = this.ShowFirstLabel;
			allowDecimalsDefaultValue = this.ShowFirstLabel_DefaultValue;
			if ((allowDecimals.GetValueOrDefault() == allowDecimalsDefaultValue.GetValueOrDefault() ? allowDecimals.HasValue != allowDecimalsDefaultValue.HasValue : true))
			{
				hashtables.Add("showFirstLabel", this.ShowFirstLabel);
			}
			allowDecimalsDefaultValue = this.ShowLastLabel;
			allowDecimals = this.ShowLastLabel_DefaultValue;
			if ((allowDecimalsDefaultValue.GetValueOrDefault() == allowDecimals.GetValueOrDefault() ? allowDecimalsDefaultValue.HasValue != allowDecimals.HasValue : true))
			{
				hashtables.Add("showLastLabel", this.ShowLastLabel);
			}
			ceiling = this.SoftMax;
			ceilingDefaultValue = this.SoftMax_DefaultValue;
			if ((ceiling.GetValueOrDefault() == ceilingDefaultValue.GetValueOrDefault() ? ceiling.HasValue != ceilingDefaultValue.HasValue : true))
			{
				hashtables.Add("softMax", this.SoftMax);
			}
			ceilingDefaultValue = this.SoftMin;
			ceiling = this.SoftMin_DefaultValue;
			if ((ceilingDefaultValue.GetValueOrDefault() == ceiling.GetValueOrDefault() ? ceilingDefaultValue.HasValue != ceiling.HasValue : true))
			{
				hashtables.Add("softMin", this.SoftMin);
			}
			ceiling = this.StartOfWeek;
			ceilingDefaultValue = this.StartOfWeek_DefaultValue;
			if ((ceiling.GetValueOrDefault() == ceilingDefaultValue.GetValueOrDefault() ? ceiling.HasValue != ceilingDefaultValue.HasValue : true))
			{
				hashtables.Add("startOfWeek", this.StartOfWeek);
			}
			allowDecimals = this.StartOnTick;
			allowDecimalsDefaultValue = this.StartOnTick_DefaultValue;
			if ((allowDecimals.GetValueOrDefault() == allowDecimalsDefaultValue.GetValueOrDefault() ? allowDecimals.HasValue != allowDecimalsDefaultValue.HasValue : true))
			{
				hashtables.Add("startOnTick", this.StartOnTick);
			}
			ceilingDefaultValue = this.TickAmount;
			ceiling = this.TickAmount_DefaultValue;
			if ((ceilingDefaultValue.GetValueOrDefault() == ceiling.GetValueOrDefault() ? ceilingDefaultValue.HasValue != ceiling.HasValue : true))
			{
				hashtables.Add("tickAmount", this.TickAmount);
			}
			if (this.TickColor != this.TickColor_DefaultValue)
			{
				hashtables.Add("tickColor", this.TickColor);
			}
			ceiling = this.TickInterval;
			ceilingDefaultValue = this.TickInterval_DefaultValue;
			if ((ceiling.GetValueOrDefault() == ceilingDefaultValue.GetValueOrDefault() ? ceiling.HasValue != ceilingDefaultValue.HasValue : true))
			{
				hashtables.Add("tickInterval", this.TickInterval);
			}
			ceilingDefaultValue = this.TickLength;
			ceiling = this.TickLength_DefaultValue;
			if ((ceilingDefaultValue.GetValueOrDefault() == ceiling.GetValueOrDefault() ? ceilingDefaultValue.HasValue != ceiling.HasValue : true))
			{
				hashtables.Add("tickLength", this.TickLength);
			}
			ceiling = this.TickPixelInterval;
			ceilingDefaultValue = this.TickPixelInterval_DefaultValue;
			if ((ceiling.GetValueOrDefault() == ceilingDefaultValue.GetValueOrDefault() ? ceiling.HasValue != ceilingDefaultValue.HasValue : true))
			{
				hashtables.Add("tickPixelInterval", this.TickPixelInterval);
			}
			if (this.TickPosition != this.TickPosition_DefaultValue)
			{
				XAxisTickPosition tickPosition = this.TickPosition;
				hashtables.Add("tickPosition", Highcharts.FirstCharacterToLower(tickPosition.ToString()));
			}
			if (this.TickPositioner != this.TickPositioner_DefaultValue)
			{
				hashtables.Add("tickPositioner", this.TickPositioner);
				Highcharts.AddFunction("XAxisTickPositioner.tickPositioner", this.TickPositioner);
			}
			if (this.TickPositions != this.TickPositions_DefaultValue)
			{
				hashtables.Add("tickPositions", this.TickPositions);
			}
			ceilingDefaultValue = this.TickWidth;
			ceiling = this.TickWidth_DefaultValue;
			if ((ceilingDefaultValue.GetValueOrDefault() == ceiling.GetValueOrDefault() ? ceilingDefaultValue.HasValue != ceiling.HasValue : true))
			{
				hashtables.Add("tickWidth", this.TickWidth);
			}
			if (this.TickmarkPlacement != this.TickmarkPlacement_DefaultValue)
			{
				XAxisTickmarkPlacement tickmarkPlacement = this.TickmarkPlacement;
				hashtables.Add("tickmarkPlacement", Highcharts.FirstCharacterToLower(tickmarkPlacement.ToString()));
			}
			if (this.Title.IsDirty())
			{
				hashtables.Add("title", this.Title.ToHashtable());
			}
			if (this.Type != this.Type_DefaultValue)
			{
				XAxisType type = this.Type;
				hashtables.Add("type", Highcharts.FirstCharacterToLower(type.ToString()));
			}
			allowDecimalsDefaultValue = this.Visible;
			allowDecimals = this.Visible_DefaultValue;
			if ((allowDecimalsDefaultValue.GetValueOrDefault() == allowDecimals.GetValueOrDefault() ? allowDecimalsDefaultValue.HasValue != allowDecimals.HasValue : true))
			{
				hashtables.Add("visible", this.Visible);
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