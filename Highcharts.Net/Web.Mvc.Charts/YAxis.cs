using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class YAxis : BaseObject
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

		public double? Angle
		{
			get;
			set;
		}

		private double? Angle_DefaultValue
		{
			get;
			set;
		}

		public YAxisBreaks Breaks
		{
			get;
			set;
		}

		private YAxisBreaks Breaks_DefaultValue
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

		public YAxisCrosshair Crosshair
		{
			get;
			set;
		}

		private YAxisCrosshair Crosshair_DefaultValue
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

		public YAxisEvents Events
		{
			get;
			set;
		}

		private YAxisEvents Events_DefaultValue
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

		public YAxisGridLineDashStyle GridLineDashStyle
		{
			get;
			set;
		}

		private YAxisGridLineDashStyle GridLineDashStyle_DefaultValue
		{
			get;
			set;
		}

		public YAxisGridLineInterpolation GridLineInterpolation
		{
			get;
			set;
		}

		private YAxisGridLineInterpolation GridLineInterpolation_DefaultValue
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

		public YAxisLabels Labels
		{
			get;
			set;
		}

		private YAxisLabels Labels_DefaultValue
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

		public string MaxColor
		{
			get;
			set;
		}

		private string MaxColor_DefaultValue
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

		public string MinColor
		{
			get;
			set;
		}

		private string MinColor_DefaultValue
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

		public YAxisMinorGridLineDashStyle MinorGridLineDashStyle
		{
			get;
			set;
		}

		private YAxisMinorGridLineDashStyle MinorGridLineDashStyle_DefaultValue
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

		public YAxisMinorTickPosition MinorTickPosition
		{
			get;
			set;
		}

		private YAxisMinorTickPosition MinorTickPosition_DefaultValue
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

		public List<YAxisPlotBands> PlotBands
		{
			get;
			set;
		}

		private List<YAxisPlotBands> PlotBands_DefaultValue
		{
			get;
			set;
		}

		public List<YAxisPlotLines> PlotLines
		{
			get;
			set;
		}

		private List<YAxisPlotLines> PlotLines_DefaultValue
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

		public bool? ReversedStacks
		{
			get;
			set;
		}

		private bool? ReversedStacks_DefaultValue
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

		public YAxisStackLabels StackLabels
		{
			get;
			set;
		}

		private YAxisStackLabels StackLabels_DefaultValue
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

		public List<Stop> Stops
		{
			get;
			set;
		}

		private List<Stop> Stops_DefaultValue
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

		public YAxisTickmarkPlacement TickmarkPlacement
		{
			get;
			set;
		}

		private YAxisTickmarkPlacement TickmarkPlacement_DefaultValue
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

		public YAxisTickPosition TickPosition
		{
			get;
			set;
		}

		private YAxisTickPosition TickPosition_DefaultValue
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

		public YAxisTitle Title
		{
			get;
			set;
		}

		private YAxisTitle Title_DefaultValue
		{
			get;
			set;
		}

		public YAxisType Type
		{
			get;
			set;
		}

		private YAxisType Type_DefaultValue
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

		public YAxis()
		{
			bool? nullable = new bool?(true);
			this.AllowDecimals_DefaultValue = nullable;
			this.AllowDecimals = nullable;
			object obj = null;
			string str = (string)obj;
			this.AlternateGridColor_DefaultValue = (string)obj;
			this.AlternateGridColor = str;
			double? nullable1 = new double?(0);
			this.Angle_DefaultValue = nullable1;
			this.Angle = nullable1;
			YAxisBreaks yAxisBreak = new YAxisBreaks();
			YAxisBreaks yAxisBreak1 = yAxisBreak;
			this.Breaks_DefaultValue = yAxisBreak;
			this.Breaks = yAxisBreak1;
			object obj1 = null;
			List<string> strs = (List<string>)obj1;
			this.Categories_DefaultValue = (List<string>)obj1;
			this.Categories = strs;
			nullable1 = null;
			this.Ceiling_DefaultValue = nullable1;
			this.Ceiling = nullable1;
			string str1 = "";
			str = str1;
			this.ClassName_DefaultValue = str1;
			this.ClassName = str;
			YAxisCrosshair yAxisCrosshair = new YAxisCrosshair();
			YAxisCrosshair yAxisCrosshair1 = yAxisCrosshair;
			this.Crosshair_DefaultValue = yAxisCrosshair;
			this.Crosshair = yAxisCrosshair1;
			Hashtable hashtables = new Hashtable();
			Hashtable hashtables1 = hashtables;
			this.DateTimeLabelFormats_DefaultValue = hashtables;
			this.DateTimeLabelFormats = hashtables1;
			string str2 = "undefined";
			str = str2;
			this.Description_DefaultValue = str2;
			this.Description = str;
			nullable = new bool?(true);
			this.EndOnTick_DefaultValue = nullable;
			this.EndOnTick = nullable;
			YAxisEvents yAxisEvent = new YAxisEvents();
			YAxisEvents yAxisEvent1 = yAxisEvent;
			this.Events_DefaultValue = yAxisEvent;
			this.Events = yAxisEvent1;
			nullable1 = null;
			this.Floor_DefaultValue = nullable1;
			this.Floor = nullable1;
			string str3 = "#e6e6e6";
			str = str3;
			this.GridLineColor_DefaultValue = str3;
			this.GridLineColor = str;
			int num = 0;
			YAxisGridLineDashStyle yAxisGridLineDashStyle = (YAxisGridLineDashStyle)num;
			this.GridLineDashStyle_DefaultValue = (YAxisGridLineDashStyle)num;
			this.GridLineDashStyle = yAxisGridLineDashStyle;
			int num1 = 0;
			YAxisGridLineInterpolation yAxisGridLineInterpolation = (YAxisGridLineInterpolation)num1;
			this.GridLineInterpolation_DefaultValue = (YAxisGridLineInterpolation)num1;
			this.GridLineInterpolation = yAxisGridLineInterpolation;
			nullable1 = new double?((double)1);
			this.GridLineWidth_DefaultValue = nullable1;
			this.GridLineWidth = nullable1;
			nullable1 = new double?((double)1);
			this.GridZIndex_DefaultValue = nullable1;
			this.GridZIndex = nullable1;
			object obj2 = null;
			str = (string)obj2;
			this.Id_DefaultValue = (string)obj2;
			this.Id = str;
			YAxisLabels yAxisLabel = new YAxisLabels();
			YAxisLabels yAxisLabel1 = yAxisLabel;
			this.Labels_DefaultValue = yAxisLabel;
			this.Labels = yAxisLabel1;
			string str4 = "#ccd6eb";
			str = str4;
			this.LineColor_DefaultValue = str4;
			this.LineColor = str;
			nullable1 = new double?(0);
			this.LineWidth_DefaultValue = nullable1;
			this.LineWidth = nullable1;
			nullable1 = null;
			this.LinkedTo_DefaultValue = nullable1;
			this.LinkedTo = nullable1;
			nullable1 = null;
			this.Max_DefaultValue = nullable1;
			this.Max = nullable1;
			string str5 = "#003399";
			str = str5;
			this.MaxColor_DefaultValue = str5;
			this.MaxColor = str;
			nullable1 = new double?(0.05);
			this.MaxPadding_DefaultValue = nullable1;
			this.MaxPadding = nullable1;
			nullable1 = null;
			this.Min_DefaultValue = nullable1;
			this.Min = nullable1;
			string str6 = "#e6ebf5";
			str = str6;
			this.MinColor_DefaultValue = str6;
			this.MinColor = str;
			nullable1 = new double?(0.05);
			this.MinPadding_DefaultValue = nullable1;
			this.MinPadding = nullable1;
			nullable1 = null;
			this.MinRange_DefaultValue = nullable1;
			this.MinRange = nullable1;
			nullable1 = null;
			this.MinTickInterval_DefaultValue = nullable1;
			this.MinTickInterval = nullable1;
			string str7 = "#f2f2f2";
			str = str7;
			this.MinorGridLineColor_DefaultValue = str7;
			this.MinorGridLineColor = str;
			int num2 = 0;
			YAxisMinorGridLineDashStyle yAxisMinorGridLineDashStyle = (YAxisMinorGridLineDashStyle)num2;
			this.MinorGridLineDashStyle_DefaultValue = (YAxisMinorGridLineDashStyle)num2;
			this.MinorGridLineDashStyle = yAxisMinorGridLineDashStyle;
			nullable1 = new double?((double)1);
			this.MinorGridLineWidth_DefaultValue = nullable1;
			this.MinorGridLineWidth = nullable1;
			string str8 = "#999999";
			str = str8;
			this.MinorTickColor_DefaultValue = str8;
			this.MinorTickColor = str;
			object obj3 = null;
			str = (string)obj3;
			this.MinorTickInterval_DefaultValue = (string)obj3;
			this.MinorTickInterval = str;
			nullable1 = new double?((double)2);
			this.MinorTickLength_DefaultValue = nullable1;
			this.MinorTickLength = nullable1;
			int num3 = 1;
			YAxisMinorTickPosition yAxisMinorTickPosition = (YAxisMinorTickPosition)num3;
			this.MinorTickPosition_DefaultValue = (YAxisMinorTickPosition)num3;
			this.MinorTickPosition = yAxisMinorTickPosition;
			nullable1 = new double?(0);
			this.MinorTickWidth_DefaultValue = nullable1;
			this.MinorTickWidth = nullable1;
			nullable1 = new double?(0);
			this.Offset_DefaultValue = nullable1;
			this.Offset = nullable1;
			nullable = new bool?(false);
			this.Opposite_DefaultValue = nullable;
			this.Opposite = nullable;
			List<YAxisPlotBands> yAxisPlotBands = new List<YAxisPlotBands>();
			List<YAxisPlotBands> yAxisPlotBands1 = yAxisPlotBands;
			this.PlotBands_DefaultValue = yAxisPlotBands;
			this.PlotBands = yAxisPlotBands1;
			List<YAxisPlotLines> yAxisPlotLines = new List<YAxisPlotLines>();
			List<YAxisPlotLines> yAxisPlotLines1 = yAxisPlotLines;
			this.PlotLines_DefaultValue = yAxisPlotLines;
			this.PlotLines = yAxisPlotLines1;
			nullable = new bool?(false);
			this.Reversed_DefaultValue = nullable;
			this.Reversed = nullable;
			nullable = new bool?(true);
			this.ReversedStacks_DefaultValue = nullable;
			this.ReversedStacks = nullable;
			nullable = new bool?(true);
			this.ShowEmpty_DefaultValue = nullable;
			this.ShowEmpty = nullable;
			nullable = new bool?(true);
			this.ShowFirstLabel_DefaultValue = nullable;
			this.ShowFirstLabel = nullable;
			nullable = null;
			this.ShowLastLabel_DefaultValue = nullable;
			this.ShowLastLabel = nullable;
			nullable1 = null;
			this.SoftMax_DefaultValue = nullable1;
			this.SoftMax = nullable1;
			nullable1 = null;
			this.SoftMin_DefaultValue = nullable1;
			this.SoftMin = nullable1;
			YAxisStackLabels yAxisStackLabel = new YAxisStackLabels();
			YAxisStackLabels yAxisStackLabel1 = yAxisStackLabel;
			this.StackLabels_DefaultValue = yAxisStackLabel;
			this.StackLabels = yAxisStackLabel1;
			nullable1 = new double?((double)1);
			this.StartOfWeek_DefaultValue = nullable1;
			this.StartOfWeek = nullable1;
			nullable = new bool?(true);
			this.StartOnTick_DefaultValue = nullable;
			this.StartOnTick = nullable;
			object obj4 = null;
			List<Stop> stops = (List<Stop>)obj4;
			this.Stops_DefaultValue = (List<Stop>)obj4;
			this.Stops = stops;
			nullable1 = null;
			this.TickAmount_DefaultValue = nullable1;
			this.TickAmount = nullable1;
			string str9 = "#ccd6eb";
			str = str9;
			this.TickColor_DefaultValue = str9;
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
			int num4 = 1;
			YAxisTickPosition yAxisTickPosition = (YAxisTickPosition)num4;
			this.TickPosition_DefaultValue = (YAxisTickPosition)num4;
			this.TickPosition = yAxisTickPosition;
			string str10 = "";
			str = str10;
			this.TickPositioner_DefaultValue = str10;
			this.TickPositioner = str;
			object obj5 = null;
			List<double> nums = (List<double>)obj5;
			this.TickPositions_DefaultValue = (List<double>)obj5;
			this.TickPositions = nums;
			nullable1 = new double?(0);
			this.TickWidth_DefaultValue = nullable1;
			this.TickWidth = nullable1;
			int num5 = 0;
			YAxisTickmarkPlacement yAxisTickmarkPlacement = (YAxisTickmarkPlacement)num5;
			this.TickmarkPlacement_DefaultValue = (YAxisTickmarkPlacement)num5;
			this.TickmarkPlacement = yAxisTickmarkPlacement;
			YAxisTitle yAxisTitle = new YAxisTitle();
			YAxisTitle yAxisTitle1 = yAxisTitle;
			this.Title_DefaultValue = yAxisTitle;
			this.Title = yAxisTitle1;
			int num6 = 0;
			YAxisType yAxisType = (YAxisType)num6;
			this.Type_DefaultValue = (YAxisType)num6;
			this.Type = yAxisType;
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
			double? angle = this.Angle;
			double? angleDefaultValue = this.Angle_DefaultValue;
			if ((angle.GetValueOrDefault() == angleDefaultValue.GetValueOrDefault() ? angle.HasValue != angleDefaultValue.HasValue : true))
			{
				hashtables.Add("angle", this.Angle);
			}
			if (this.Breaks.IsDirty())
			{
				hashtables.Add("breaks", this.Breaks.ToHashtable());
			}
			if (this.Categories != this.Categories_DefaultValue)
			{
				hashtables.Add("categories", this.Categories);
			}
			angleDefaultValue = this.Ceiling;
			angle = this.Ceiling_DefaultValue;
			if ((angleDefaultValue.GetValueOrDefault() == angle.GetValueOrDefault() ? angleDefaultValue.HasValue != angle.HasValue : true))
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
			angle = this.Floor;
			angleDefaultValue = this.Floor_DefaultValue;
			if ((angle.GetValueOrDefault() == angleDefaultValue.GetValueOrDefault() ? angle.HasValue != angleDefaultValue.HasValue : true))
			{
				hashtables.Add("floor", this.Floor);
			}
			if (this.GridLineColor != this.GridLineColor_DefaultValue)
			{
				hashtables.Add("gridLineColor", this.GridLineColor);
			}
			if (this.GridLineDashStyle != this.GridLineDashStyle_DefaultValue)
			{
				YAxisGridLineDashStyle gridLineDashStyle = this.GridLineDashStyle;
				hashtables.Add("gridLineDashStyle", Highcharts.FirstCharacterToLower(gridLineDashStyle.ToString()));
			}
			if (this.GridLineInterpolation != this.GridLineInterpolation_DefaultValue)
			{
				YAxisGridLineInterpolation gridLineInterpolation = this.GridLineInterpolation;
				hashtables.Add("gridLineInterpolation", Highcharts.FirstCharacterToLower(gridLineInterpolation.ToString()));
			}
			angleDefaultValue = this.GridLineWidth;
			angle = this.GridLineWidth_DefaultValue;
			if ((angleDefaultValue.GetValueOrDefault() == angle.GetValueOrDefault() ? angleDefaultValue.HasValue != angle.HasValue : true))
			{
				hashtables.Add("gridLineWidth", this.GridLineWidth);
			}
			angle = this.GridZIndex;
			angleDefaultValue = this.GridZIndex_DefaultValue;
			if ((angle.GetValueOrDefault() == angleDefaultValue.GetValueOrDefault() ? angle.HasValue != angleDefaultValue.HasValue : true))
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
			angleDefaultValue = this.LineWidth;
			angle = this.LineWidth_DefaultValue;
			if ((angleDefaultValue.GetValueOrDefault() == angle.GetValueOrDefault() ? angleDefaultValue.HasValue != angle.HasValue : true))
			{
				hashtables.Add("lineWidth", this.LineWidth);
			}
			angle = this.LinkedTo;
			angleDefaultValue = this.LinkedTo_DefaultValue;
			if ((angle.GetValueOrDefault() == angleDefaultValue.GetValueOrDefault() ? angle.HasValue != angleDefaultValue.HasValue : true))
			{
				hashtables.Add("linkedTo", this.LinkedTo);
			}
			angleDefaultValue = this.Max;
			angle = this.Max_DefaultValue;
			if ((angleDefaultValue.GetValueOrDefault() == angle.GetValueOrDefault() ? angleDefaultValue.HasValue != angle.HasValue : true))
			{
				hashtables.Add("max", this.Max);
			}
			if (this.MaxColor != this.MaxColor_DefaultValue)
			{
				hashtables.Add("maxColor", this.MaxColor);
			}
			angle = this.MaxPadding;
			angleDefaultValue = this.MaxPadding_DefaultValue;
			if ((angle.GetValueOrDefault() == angleDefaultValue.GetValueOrDefault() ? angle.HasValue != angleDefaultValue.HasValue : true))
			{
				hashtables.Add("maxPadding", this.MaxPadding);
			}
			angleDefaultValue = this.Min;
			angle = this.Min_DefaultValue;
			if ((angleDefaultValue.GetValueOrDefault() == angle.GetValueOrDefault() ? angleDefaultValue.HasValue != angle.HasValue : true))
			{
				hashtables.Add("min", this.Min);
			}
			if (this.MinColor != this.MinColor_DefaultValue)
			{
				hashtables.Add("minColor", this.MinColor);
			}
			angle = this.MinPadding;
			angleDefaultValue = this.MinPadding_DefaultValue;
			if ((angle.GetValueOrDefault() == angleDefaultValue.GetValueOrDefault() ? angle.HasValue != angleDefaultValue.HasValue : true))
			{
				hashtables.Add("minPadding", this.MinPadding);
			}
			angleDefaultValue = this.MinRange;
			angle = this.MinRange_DefaultValue;
			if ((angleDefaultValue.GetValueOrDefault() == angle.GetValueOrDefault() ? angleDefaultValue.HasValue != angle.HasValue : true))
			{
				hashtables.Add("minRange", this.MinRange);
			}
			angle = this.MinTickInterval;
			angleDefaultValue = this.MinTickInterval_DefaultValue;
			if ((angle.GetValueOrDefault() == angleDefaultValue.GetValueOrDefault() ? angle.HasValue != angleDefaultValue.HasValue : true))
			{
				hashtables.Add("minTickInterval", this.MinTickInterval);
			}
			if (this.MinorGridLineColor != this.MinorGridLineColor_DefaultValue)
			{
				hashtables.Add("minorGridLineColor", this.MinorGridLineColor);
			}
			if (this.MinorGridLineDashStyle != this.MinorGridLineDashStyle_DefaultValue)
			{
				YAxisMinorGridLineDashStyle minorGridLineDashStyle = this.MinorGridLineDashStyle;
				hashtables.Add("minorGridLineDashStyle", Highcharts.FirstCharacterToLower(minorGridLineDashStyle.ToString()));
			}
			angleDefaultValue = this.MinorGridLineWidth;
			angle = this.MinorGridLineWidth_DefaultValue;
			if ((angleDefaultValue.GetValueOrDefault() == angle.GetValueOrDefault() ? angleDefaultValue.HasValue != angle.HasValue : true))
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
			angle = this.MinorTickLength;
			angleDefaultValue = this.MinorTickLength_DefaultValue;
			if ((angle.GetValueOrDefault() == angleDefaultValue.GetValueOrDefault() ? angle.HasValue != angleDefaultValue.HasValue : true))
			{
				hashtables.Add("minorTickLength", this.MinorTickLength);
			}
			if (this.MinorTickPosition != this.MinorTickPosition_DefaultValue)
			{
				YAxisMinorTickPosition minorTickPosition = this.MinorTickPosition;
				hashtables.Add("minorTickPosition", Highcharts.FirstCharacterToLower(minorTickPosition.ToString()));
			}
			angleDefaultValue = this.MinorTickWidth;
			angle = this.MinorTickWidth_DefaultValue;
			if ((angleDefaultValue.GetValueOrDefault() == angle.GetValueOrDefault() ? angleDefaultValue.HasValue != angle.HasValue : true))
			{
				hashtables.Add("minorTickWidth", this.MinorTickWidth);
			}
			angle = this.Offset;
			angleDefaultValue = this.Offset_DefaultValue;
			if ((angle.GetValueOrDefault() == angleDefaultValue.GetValueOrDefault() ? angle.HasValue != angleDefaultValue.HasValue : true))
			{
				hashtables.Add("offset", this.Offset);
			}
			allowDecimals = this.Opposite;
			allowDecimalsDefaultValue = this.Opposite_DefaultValue;
			if ((allowDecimals.GetValueOrDefault() == allowDecimalsDefaultValue.GetValueOrDefault() ? allowDecimals.HasValue != allowDecimalsDefaultValue.HasValue : true))
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
			allowDecimalsDefaultValue = this.Reversed;
			allowDecimals = this.Reversed_DefaultValue;
			if ((allowDecimalsDefaultValue.GetValueOrDefault() == allowDecimals.GetValueOrDefault() ? allowDecimalsDefaultValue.HasValue != allowDecimals.HasValue : true))
			{
				hashtables.Add("reversed", this.Reversed);
			}
			allowDecimals = this.ReversedStacks;
			allowDecimalsDefaultValue = this.ReversedStacks_DefaultValue;
			if ((allowDecimals.GetValueOrDefault() == allowDecimalsDefaultValue.GetValueOrDefault() ? allowDecimals.HasValue != allowDecimalsDefaultValue.HasValue : true))
			{
				hashtables.Add("reversedStacks", this.ReversedStacks);
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
			angleDefaultValue = this.SoftMax;
			angle = this.SoftMax_DefaultValue;
			if ((angleDefaultValue.GetValueOrDefault() == angle.GetValueOrDefault() ? angleDefaultValue.HasValue != angle.HasValue : true))
			{
				hashtables.Add("softMax", this.SoftMax);
			}
			angle = this.SoftMin;
			angleDefaultValue = this.SoftMin_DefaultValue;
			if ((angle.GetValueOrDefault() == angleDefaultValue.GetValueOrDefault() ? angle.HasValue != angleDefaultValue.HasValue : true))
			{
				hashtables.Add("softMin", this.SoftMin);
			}
			if (this.StackLabels.IsDirty())
			{
				hashtables.Add("stackLabels", this.StackLabels.ToHashtable());
			}
			angleDefaultValue = this.StartOfWeek;
			angle = this.StartOfWeek_DefaultValue;
			if ((angleDefaultValue.GetValueOrDefault() == angle.GetValueOrDefault() ? angleDefaultValue.HasValue != angle.HasValue : true))
			{
				hashtables.Add("startOfWeek", this.StartOfWeek);
			}
			allowDecimals = this.StartOnTick;
			allowDecimalsDefaultValue = this.StartOnTick_DefaultValue;
			if ((allowDecimals.GetValueOrDefault() == allowDecimalsDefaultValue.GetValueOrDefault() ? allowDecimals.HasValue != allowDecimalsDefaultValue.HasValue : true))
			{
				hashtables.Add("startOnTick", this.StartOnTick);
			}
			if (this.Stops != this.Stops_DefaultValue)
			{
				hashtables.Add("stops", base.HashifyList(this.Stops));
			}
			angle = this.TickAmount;
			angleDefaultValue = this.TickAmount_DefaultValue;
			if ((angle.GetValueOrDefault() == angleDefaultValue.GetValueOrDefault() ? angle.HasValue != angleDefaultValue.HasValue : true))
			{
				hashtables.Add("tickAmount", this.TickAmount);
			}
			if (this.TickColor != this.TickColor_DefaultValue)
			{
				hashtables.Add("tickColor", this.TickColor);
			}
			angleDefaultValue = this.TickInterval;
			angle = this.TickInterval_DefaultValue;
			if ((angleDefaultValue.GetValueOrDefault() == angle.GetValueOrDefault() ? angleDefaultValue.HasValue != angle.HasValue : true))
			{
				hashtables.Add("tickInterval", this.TickInterval);
			}
			angle = this.TickLength;
			angleDefaultValue = this.TickLength_DefaultValue;
			if ((angle.GetValueOrDefault() == angleDefaultValue.GetValueOrDefault() ? angle.HasValue != angleDefaultValue.HasValue : true))
			{
				hashtables.Add("tickLength", this.TickLength);
			}
			angleDefaultValue = this.TickPixelInterval;
			angle = this.TickPixelInterval_DefaultValue;
			if ((angleDefaultValue.GetValueOrDefault() == angle.GetValueOrDefault() ? angleDefaultValue.HasValue != angle.HasValue : true))
			{
				hashtables.Add("tickPixelInterval", this.TickPixelInterval);
			}
			if (this.TickPosition != this.TickPosition_DefaultValue)
			{
				YAxisTickPosition tickPosition = this.TickPosition;
				hashtables.Add("tickPosition", Highcharts.FirstCharacterToLower(tickPosition.ToString()));
			}
			if (this.TickPositioner != this.TickPositioner_DefaultValue)
			{
				hashtables.Add("tickPositioner", this.TickPositioner);
				Highcharts.AddFunction("YAxisTickPositioner.tickPositioner", this.TickPositioner);
			}
			if (this.TickPositions != this.TickPositions_DefaultValue)
			{
				hashtables.Add("tickPositions", this.TickPositions);
			}
			angle = this.TickWidth;
			angleDefaultValue = this.TickWidth_DefaultValue;
			if ((angle.GetValueOrDefault() == angleDefaultValue.GetValueOrDefault() ? angle.HasValue != angleDefaultValue.HasValue : true))
			{
				hashtables.Add("tickWidth", this.TickWidth);
			}
			if (this.TickmarkPlacement != this.TickmarkPlacement_DefaultValue)
			{
				YAxisTickmarkPlacement tickmarkPlacement = this.TickmarkPlacement;
				hashtables.Add("tickmarkPlacement", Highcharts.FirstCharacterToLower(tickmarkPlacement.ToString()));
			}
			if (this.Title.IsDirty())
			{
				hashtables.Add("title", this.Title.ToHashtable());
			}
			if (this.Type != this.Type_DefaultValue)
			{
				YAxisType type = this.Type;
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