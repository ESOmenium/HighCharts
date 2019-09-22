using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class Highcharts : BaseObject
	{
		internal static Hashtable functions;

		public Highsoft.Web.Mvc.Charts.Accessibility Accessibility
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.Accessibility Accessibility_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.ArearangeSeries ArearangeSeries
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.ArearangeSeries ArearangeSeries_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.AreaSeries AreaSeries
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.AreaSeries AreaSeries_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.AreasplinerangeSeries AreasplinerangeSeries
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.AreasplinerangeSeries AreasplinerangeSeries_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.AreasplineSeries AreasplineSeries
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.AreasplineSeries AreasplineSeries_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.BarSeries BarSeries
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.BarSeries BarSeries_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.BoxplotSeries BoxplotSeries
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.BoxplotSeries BoxplotSeries_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.BubbleSeries BubbleSeries
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.BubbleSeries BubbleSeries_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.Chart Chart
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.Chart Chart_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.ColorAxis ColorAxis
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.ColorAxis ColorAxis_DefaultValue
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

		public Highsoft.Web.Mvc.Charts.ColumnrangeSeries ColumnrangeSeries
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.ColumnrangeSeries ColumnrangeSeries_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.ColumnSeries ColumnSeries
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.ColumnSeries ColumnSeries_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.Credits Credits
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.Credits Credits_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.Data Data
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.Data Data_DefaultValue
		{
			get;
			set;
		}

		public object Defs
		{
			get;
			set;
		}

		private object Defs_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.Drilldown Drilldown
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.Drilldown Drilldown_DefaultValue
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

		public Highsoft.Web.Mvc.Charts.ErrorbarSeries ErrorbarSeries
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.ErrorbarSeries ErrorbarSeries_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.Exporting Exporting
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.Exporting Exporting_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.FunnelSeries FunnelSeries
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.FunnelSeries FunnelSeries_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.GaugeSeries GaugeSeries
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.GaugeSeries GaugeSeries_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.Global Global
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.Global Global_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.HeatmapSeries HeatmapSeries
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.HeatmapSeries HeatmapSeries_DefaultValue
		{
			get;
			set;
		}

		public string ID
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.Labels Labels
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.Labels Labels_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.Lang Lang
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.Lang Lang_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.Legend Legend
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.Legend Legend_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.LineSeries LineSeries
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.LineSeries LineSeries_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.Loading Loading
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.Loading Loading_DefaultValue
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

		public Highsoft.Web.Mvc.Charts.Navigation Navigation
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.Navigation Navigation_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.NoData NoData
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.NoData NoData_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.Pane Pane
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.Pane Pane_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.PieSeries PieSeries
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.PieSeries PieSeries_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.PlotOptions PlotOptions
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.PlotOptions PlotOptions_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.PolygonSeries PolygonSeries
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.PolygonSeries PolygonSeries_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.PyramidSeries PyramidSeries
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.PyramidSeries PyramidSeries_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.Responsive Responsive
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.Responsive Responsive_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.ScatterSeries ScatterSeries
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.ScatterSeries ScatterSeries_DefaultValue
		{
			get;
			set;
		}

		public List<Highsoft.Web.Mvc.Charts.Series> Series
		{
			get;
			set;
		}

		private List<Highsoft.Web.Mvc.Charts.Series> Series_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.SolidgaugeSeries SolidgaugeSeries
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.SolidgaugeSeries SolidgaugeSeries_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.SplineSeries SplineSeries
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.SplineSeries SplineSeries_DefaultValue
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

		public Highsoft.Web.Mvc.Charts.Subtitle Subtitle
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.Subtitle Subtitle_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.Title Title
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.Title Title_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.Tooltip Tooltip
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.Tooltip Tooltip_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.TreemapSeries TreemapSeries
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.TreemapSeries TreemapSeries_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.WaterfallSeries WaterfallSeries
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.WaterfallSeries WaterfallSeries_DefaultValue
		{
			get;
			set;
		}

		public List<Highsoft.Web.Mvc.Charts.XAxis> XAxis
		{
			get;
			set;
		}

		private List<Highsoft.Web.Mvc.Charts.XAxis> XAxis_DefaultValue
		{
			get;
			set;
		}

		public List<Highsoft.Web.Mvc.Charts.YAxis> YAxis
		{
			get;
			set;
		}

		private List<Highsoft.Web.Mvc.Charts.YAxis> YAxis_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.ZAxis ZAxis
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.ZAxis ZAxis_DefaultValue
		{
			get;
			set;
		}

		static Highcharts()
		{
			Highcharts.functions = new Hashtable();
		}

		public Highcharts()
		{
			Highsoft.Web.Mvc.Charts.Accessibility accessibility = new Highsoft.Web.Mvc.Charts.Accessibility();
			Highsoft.Web.Mvc.Charts.Accessibility accessibility1 = accessibility;
			this.Accessibility_DefaultValue = accessibility;
			this.Accessibility = accessibility1;
			Highsoft.Web.Mvc.Charts.Chart chart = new Highsoft.Web.Mvc.Charts.Chart();
			Highsoft.Web.Mvc.Charts.Chart chart1 = chart;
			this.Chart_DefaultValue = chart;
			this.Chart = chart1;
			List<string> strs = new List<string>();
			List<string> strs1 = strs;
			this.Colors_DefaultValue = strs;
			this.Colors = strs1;
			Highsoft.Web.Mvc.Charts.Credits credit = new Highsoft.Web.Mvc.Charts.Credits();
			Highsoft.Web.Mvc.Charts.Credits credit1 = credit;
			this.Credits_DefaultValue = credit;
			this.Credits = credit1;
			Highsoft.Web.Mvc.Charts.Data datum = new Highsoft.Web.Mvc.Charts.Data();
			Highsoft.Web.Mvc.Charts.Data datum1 = datum;
			this.Data_DefaultValue = datum;
			this.Data = datum1;
			object obj = null;
			object obj1 = obj;
			this.Defs_DefaultValue = obj;
			this.Defs = obj1;
			Highsoft.Web.Mvc.Charts.Drilldown drilldown = new Highsoft.Web.Mvc.Charts.Drilldown();
			Highsoft.Web.Mvc.Charts.Drilldown drilldown1 = drilldown;
			this.Drilldown_DefaultValue = drilldown;
			this.Drilldown = drilldown1;
			Highsoft.Web.Mvc.Charts.Exporting exporting = new Highsoft.Web.Mvc.Charts.Exporting();
			Highsoft.Web.Mvc.Charts.Exporting exporting1 = exporting;
			this.Exporting_DefaultValue = exporting;
			this.Exporting = exporting1;
			Highsoft.Web.Mvc.Charts.Global global = new Highsoft.Web.Mvc.Charts.Global();
			Highsoft.Web.Mvc.Charts.Global global1 = global;
			this.Global_DefaultValue = global;
			this.Global = global1;
			Highsoft.Web.Mvc.Charts.Labels label = new Highsoft.Web.Mvc.Charts.Labels();
			Highsoft.Web.Mvc.Charts.Labels label1 = label;
			this.Labels_DefaultValue = label;
			this.Labels = label1;
			Highsoft.Web.Mvc.Charts.Lang lang = new Highsoft.Web.Mvc.Charts.Lang();
			Highsoft.Web.Mvc.Charts.Lang lang1 = lang;
			this.Lang_DefaultValue = lang;
			this.Lang = lang1;
			Highsoft.Web.Mvc.Charts.Legend legend = new Highsoft.Web.Mvc.Charts.Legend();
			Highsoft.Web.Mvc.Charts.Legend legend1 = legend;
			this.Legend_DefaultValue = legend;
			this.Legend = legend1;
			Highsoft.Web.Mvc.Charts.Loading loading = new Highsoft.Web.Mvc.Charts.Loading();
			Highsoft.Web.Mvc.Charts.Loading loading1 = loading;
			this.Loading_DefaultValue = loading;
			this.Loading = loading1;
			Highsoft.Web.Mvc.Charts.Navigation navigation = new Highsoft.Web.Mvc.Charts.Navigation();
			Highsoft.Web.Mvc.Charts.Navigation navigation1 = navigation;
			this.Navigation_DefaultValue = navigation;
			this.Navigation = navigation1;
			Highsoft.Web.Mvc.Charts.NoData noDatum = new Highsoft.Web.Mvc.Charts.NoData();
			Highsoft.Web.Mvc.Charts.NoData noDatum1 = noDatum;
			this.NoData_DefaultValue = noDatum;
			this.NoData = noDatum1;
			Highsoft.Web.Mvc.Charts.Pane pane = new Highsoft.Web.Mvc.Charts.Pane();
			Highsoft.Web.Mvc.Charts.Pane pane1 = pane;
			this.Pane_DefaultValue = pane;
			this.Pane = pane1;
			Highsoft.Web.Mvc.Charts.PlotOptions plotOption = new Highsoft.Web.Mvc.Charts.PlotOptions();
			Highsoft.Web.Mvc.Charts.PlotOptions plotOption1 = plotOption;
			this.PlotOptions_DefaultValue = plotOption;
			this.PlotOptions = plotOption1;
			Highsoft.Web.Mvc.Charts.Responsive responsive = new Highsoft.Web.Mvc.Charts.Responsive();
			Highsoft.Web.Mvc.Charts.Responsive responsive1 = responsive;
			this.Responsive_DefaultValue = responsive;
			this.Responsive = responsive1;
			List<Highsoft.Web.Mvc.Charts.Series> series = new List<Highsoft.Web.Mvc.Charts.Series>();
			List<Highsoft.Web.Mvc.Charts.Series> series1 = series;
			this.Series_DefaultValue = series;
			this.Series = series1;
			Highsoft.Web.Mvc.Charts.AreaSeries areaSeries = new Highsoft.Web.Mvc.Charts.AreaSeries();
			Highsoft.Web.Mvc.Charts.AreaSeries areaSeries1 = areaSeries;
			this.AreaSeries_DefaultValue = areaSeries;
			this.AreaSeries = areaSeries1;
			Highsoft.Web.Mvc.Charts.ArearangeSeries arearangeSeries = new Highsoft.Web.Mvc.Charts.ArearangeSeries();
			Highsoft.Web.Mvc.Charts.ArearangeSeries arearangeSeries1 = arearangeSeries;
			this.ArearangeSeries_DefaultValue = arearangeSeries;
			this.ArearangeSeries = arearangeSeries1;
			Highsoft.Web.Mvc.Charts.AreasplineSeries areasplineSeries = new Highsoft.Web.Mvc.Charts.AreasplineSeries();
			Highsoft.Web.Mvc.Charts.AreasplineSeries areasplineSeries1 = areasplineSeries;
			this.AreasplineSeries_DefaultValue = areasplineSeries;
			this.AreasplineSeries = areasplineSeries1;
			Highsoft.Web.Mvc.Charts.AreasplinerangeSeries areasplinerangeSeries = new Highsoft.Web.Mvc.Charts.AreasplinerangeSeries();
			Highsoft.Web.Mvc.Charts.AreasplinerangeSeries areasplinerangeSeries1 = areasplinerangeSeries;
			this.AreasplinerangeSeries_DefaultValue = areasplinerangeSeries;
			this.AreasplinerangeSeries = areasplinerangeSeries1;
			Highsoft.Web.Mvc.Charts.BarSeries barSeries = new Highsoft.Web.Mvc.Charts.BarSeries();
			Highsoft.Web.Mvc.Charts.BarSeries barSeries1 = barSeries;
			this.BarSeries_DefaultValue = barSeries;
			this.BarSeries = barSeries1;
			Highsoft.Web.Mvc.Charts.BoxplotSeries boxplotSeries = new Highsoft.Web.Mvc.Charts.BoxplotSeries();
			Highsoft.Web.Mvc.Charts.BoxplotSeries boxplotSeries1 = boxplotSeries;
			this.BoxplotSeries_DefaultValue = boxplotSeries;
			this.BoxplotSeries = boxplotSeries1;
			Highsoft.Web.Mvc.Charts.BubbleSeries bubbleSeries = new Highsoft.Web.Mvc.Charts.BubbleSeries();
			Highsoft.Web.Mvc.Charts.BubbleSeries bubbleSeries1 = bubbleSeries;
			this.BubbleSeries_DefaultValue = bubbleSeries;
			this.BubbleSeries = bubbleSeries1;
			Highsoft.Web.Mvc.Charts.ColumnSeries columnSeries = new Highsoft.Web.Mvc.Charts.ColumnSeries();
			Highsoft.Web.Mvc.Charts.ColumnSeries columnSeries1 = columnSeries;
			this.ColumnSeries_DefaultValue = columnSeries;
			this.ColumnSeries = columnSeries1;
			Highsoft.Web.Mvc.Charts.ColumnrangeSeries columnrangeSeries = new Highsoft.Web.Mvc.Charts.ColumnrangeSeries();
			Highsoft.Web.Mvc.Charts.ColumnrangeSeries columnrangeSeries1 = columnrangeSeries;
			this.ColumnrangeSeries_DefaultValue = columnrangeSeries;
			this.ColumnrangeSeries = columnrangeSeries1;
			Highsoft.Web.Mvc.Charts.ErrorbarSeries errorbarSeries = new Highsoft.Web.Mvc.Charts.ErrorbarSeries();
			Highsoft.Web.Mvc.Charts.ErrorbarSeries errorbarSeries1 = errorbarSeries;
			this.ErrorbarSeries_DefaultValue = errorbarSeries;
			this.ErrorbarSeries = errorbarSeries1;
			Highsoft.Web.Mvc.Charts.FunnelSeries funnelSeries = new Highsoft.Web.Mvc.Charts.FunnelSeries();
			Highsoft.Web.Mvc.Charts.FunnelSeries funnelSeries1 = funnelSeries;
			this.FunnelSeries_DefaultValue = funnelSeries;
			this.FunnelSeries = funnelSeries1;
			Highsoft.Web.Mvc.Charts.GaugeSeries gaugeSeries = new Highsoft.Web.Mvc.Charts.GaugeSeries();
			Highsoft.Web.Mvc.Charts.GaugeSeries gaugeSeries1 = gaugeSeries;
			this.GaugeSeries_DefaultValue = gaugeSeries;
			this.GaugeSeries = gaugeSeries1;
			Highsoft.Web.Mvc.Charts.HeatmapSeries heatmapSeries = new Highsoft.Web.Mvc.Charts.HeatmapSeries();
			Highsoft.Web.Mvc.Charts.HeatmapSeries heatmapSeries1 = heatmapSeries;
			this.HeatmapSeries_DefaultValue = heatmapSeries;
			this.HeatmapSeries = heatmapSeries1;
			Highsoft.Web.Mvc.Charts.LineSeries lineSeries = new Highsoft.Web.Mvc.Charts.LineSeries();
			Highsoft.Web.Mvc.Charts.LineSeries lineSeries1 = lineSeries;
			this.LineSeries_DefaultValue = lineSeries;
			this.LineSeries = lineSeries1;
			Highsoft.Web.Mvc.Charts.PieSeries pieSeries = new Highsoft.Web.Mvc.Charts.PieSeries();
			Highsoft.Web.Mvc.Charts.PieSeries pieSeries1 = pieSeries;
			this.PieSeries_DefaultValue = pieSeries;
			this.PieSeries = pieSeries1;
			Highsoft.Web.Mvc.Charts.PolygonSeries polygonSeries = new Highsoft.Web.Mvc.Charts.PolygonSeries();
			Highsoft.Web.Mvc.Charts.PolygonSeries polygonSeries1 = polygonSeries;
			this.PolygonSeries_DefaultValue = polygonSeries;
			this.PolygonSeries = polygonSeries1;
			Highsoft.Web.Mvc.Charts.PyramidSeries pyramidSeries = new Highsoft.Web.Mvc.Charts.PyramidSeries();
			Highsoft.Web.Mvc.Charts.PyramidSeries pyramidSeries1 = pyramidSeries;
			this.PyramidSeries_DefaultValue = pyramidSeries;
			this.PyramidSeries = pyramidSeries1;
			Highsoft.Web.Mvc.Charts.ScatterSeries scatterSeries = new Highsoft.Web.Mvc.Charts.ScatterSeries();
			Highsoft.Web.Mvc.Charts.ScatterSeries scatterSeries1 = scatterSeries;
			this.ScatterSeries_DefaultValue = scatterSeries;
			this.ScatterSeries = scatterSeries1;
			Highsoft.Web.Mvc.Charts.SolidgaugeSeries solidgaugeSeries = new Highsoft.Web.Mvc.Charts.SolidgaugeSeries();
			Highsoft.Web.Mvc.Charts.SolidgaugeSeries solidgaugeSeries1 = solidgaugeSeries;
			this.SolidgaugeSeries_DefaultValue = solidgaugeSeries;
			this.SolidgaugeSeries = solidgaugeSeries1;
			Highsoft.Web.Mvc.Charts.SplineSeries splineSeries = new Highsoft.Web.Mvc.Charts.SplineSeries();
			Highsoft.Web.Mvc.Charts.SplineSeries splineSeries1 = splineSeries;
			this.SplineSeries_DefaultValue = splineSeries;
			this.SplineSeries = splineSeries1;
			Highsoft.Web.Mvc.Charts.TreemapSeries treemapSeries = new Highsoft.Web.Mvc.Charts.TreemapSeries();
			Highsoft.Web.Mvc.Charts.TreemapSeries treemapSeries1 = treemapSeries;
			this.TreemapSeries_DefaultValue = treemapSeries;
			this.TreemapSeries = treemapSeries1;
			Highsoft.Web.Mvc.Charts.WaterfallSeries waterfallSeries = new Highsoft.Web.Mvc.Charts.WaterfallSeries();
			Highsoft.Web.Mvc.Charts.WaterfallSeries waterfallSeries1 = waterfallSeries;
			this.WaterfallSeries_DefaultValue = waterfallSeries;
			this.WaterfallSeries = waterfallSeries1;
			Highsoft.Web.Mvc.Charts.Subtitle subtitle = new Highsoft.Web.Mvc.Charts.Subtitle();
			Highsoft.Web.Mvc.Charts.Subtitle subtitle1 = subtitle;
			this.Subtitle_DefaultValue = subtitle;
			this.Subtitle = subtitle1;
			Highsoft.Web.Mvc.Charts.Title title = new Highsoft.Web.Mvc.Charts.Title();
			Highsoft.Web.Mvc.Charts.Title title1 = title;
			this.Title_DefaultValue = title;
			this.Title = title1;
			Highsoft.Web.Mvc.Charts.Tooltip tooltip = new Highsoft.Web.Mvc.Charts.Tooltip();
			Highsoft.Web.Mvc.Charts.Tooltip tooltip1 = tooltip;
			this.Tooltip_DefaultValue = tooltip;
			this.Tooltip = tooltip1;
			List<Highsoft.Web.Mvc.Charts.XAxis> xAxes = new List<Highsoft.Web.Mvc.Charts.XAxis>();
			List<Highsoft.Web.Mvc.Charts.XAxis> xAxes1 = xAxes;
			this.XAxis_DefaultValue = xAxes;
			this.XAxis = xAxes1;
			List<Highsoft.Web.Mvc.Charts.YAxis> yAxes = new List<Highsoft.Web.Mvc.Charts.YAxis>();
			List<Highsoft.Web.Mvc.Charts.YAxis> yAxes1 = yAxes;
			this.YAxis_DefaultValue = yAxes;
			this.YAxis = yAxes1;
			Highsoft.Web.Mvc.Charts.ZAxis zAxi = new Highsoft.Web.Mvc.Charts.ZAxis();
			Highsoft.Web.Mvc.Charts.ZAxis zAxi1 = zAxi;
			this.ZAxis_DefaultValue = zAxi;
			this.ZAxis = zAxi1;
			Highsoft.Web.Mvc.Charts.ColorAxis colorAxi = new Highsoft.Web.Mvc.Charts.ColorAxis();
			Highsoft.Web.Mvc.Charts.ColorAxis colorAxi1 = colorAxi;
			this.ColorAxis_DefaultValue = colorAxi;
			this.ColorAxis = colorAxi1;
			object obj2 = null;
			List<Stop> stops = (List<Stop>)obj2;
			this.Stops_DefaultValue = (List<Stop>)obj2;
			this.Stops = stops;
			double? nullable = null;
			this.Min_DefaultValue = nullable;
			this.Min = nullable;
			nullable = null;
			this.Max_DefaultValue = nullable;
			this.Max = nullable;
			bool? nullable1 = new bool?(false);
			this.StartOnTick_DefaultValue = nullable1;
			this.StartOnTick = nullable1;
			nullable1 = new bool?(false);
			this.EndOnTick_DefaultValue = nullable1;
			this.EndOnTick = nullable1;
			object obj3 = null;
			string str = (string)obj3;
			this.MinColor_DefaultValue = (string)obj3;
			this.MinColor = str;
			object obj4 = null;
			str = (string)obj4;
			this.MaxColor_DefaultValue = (string)obj4;
			this.MaxColor = str;
		}

		internal static void AddFunction(string eventName, string functionName)
		{
			Highcharts.functions[eventName] = functionName;
		}

		public static string FirstCharacterToLower(string str)
		{
			string str1;
			if ((string.IsNullOrEmpty(str) ? false : !char.IsLower(str, 0)))
			{
				char lowerInvariant = char.ToLowerInvariant(str[0]);
				str1 = string.Concat(lowerInvariant.ToString(), str.Substring(1));
			}
			else
			{
				str1 = str;
			}
			return str1;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.Accessibility.IsDirty())
			{
				hashtables.Add("accessibility", this.Accessibility.ToHashtable());
			}
			if (this.Chart.IsDirty())
			{
				hashtables.Add("chart", this.Chart.ToHashtable());
			}
			if (this.Colors != this.Colors_DefaultValue)
			{
				hashtables.Add("colors", this.Colors);
			}
			if (this.Credits.IsDirty())
			{
				hashtables.Add("credits", this.Credits.ToHashtable());
			}
			if (this.Data.IsDirty())
			{
				hashtables.Add("Data_DefaultValue", this.Data.ToHashtable());
			}
			if (this.Defs != this.Defs_DefaultValue)
			{
				hashtables.Add("defs", this.Defs);
			}
			if (this.Drilldown.IsDirty())
			{
				hashtables.Add("drilldown", this.Drilldown.ToHashtable());
			}
			if (this.Exporting.IsDirty())
			{
				hashtables.Add("exporting", this.Exporting.ToHashtable());
			}
			if (this.Global.IsDirty())
			{
				hashtables.Add("global", this.Global.ToHashtable());
			}
			if (this.Labels.IsDirty())
			{
				hashtables.Add("labels", this.Labels.ToHashtable());
			}
			if (this.Lang.IsDirty())
			{
				hashtables.Add("lang", this.Lang.ToHashtable());
			}
			if (this.Legend.IsDirty())
			{
				hashtables.Add("legend", this.Legend.ToHashtable());
			}
			if (this.Loading.IsDirty())
			{
				hashtables.Add("loading", this.Loading.ToHashtable());
			}
			if (this.Navigation.IsDirty())
			{
				hashtables.Add("navigation", this.Navigation.ToHashtable());
			}
			if (this.NoData.IsDirty())
			{
				hashtables.Add("noData", this.NoData.ToHashtable());
			}
			if (this.Pane.IsDirty())
			{
				hashtables.Add("pane", this.Pane.ToHashtable());
			}
			if (this.PlotOptions.IsDirty())
			{
				hashtables.Add("plotOptions", this.PlotOptions.ToHashtable());
			}
			if (this.Responsive.IsDirty())
			{
				hashtables.Add("responsive", this.Responsive.ToHashtable());
			}
			if (this.Series != this.Series_DefaultValue)
			{
				hashtables.Add("series", this.Series);
			}
			if (this.AreaSeries.IsDirty())
			{
				hashtables.Add("areaSeries", this.AreaSeries.ToHashtable());
			}
			if (this.ArearangeSeries.IsDirty())
			{
				hashtables.Add("arearangeSeries", this.ArearangeSeries.ToHashtable());
			}
			if (this.AreasplineSeries.IsDirty())
			{
				hashtables.Add("areasplineSeries", this.AreasplineSeries.ToHashtable());
			}
			if (this.AreasplinerangeSeries.IsDirty())
			{
				hashtables.Add("areasplinerangeSeries", this.AreasplinerangeSeries.ToHashtable());
			}
			if (this.BarSeries.IsDirty())
			{
				hashtables.Add("barSeries", this.BarSeries.ToHashtable());
			}
			if (this.BoxplotSeries.IsDirty())
			{
				hashtables.Add("boxplotSeries", this.BoxplotSeries.ToHashtable());
			}
			if (this.BubbleSeries.IsDirty())
			{
				hashtables.Add("bubbleSeries", this.BubbleSeries.ToHashtable());
			}
			if (this.ColumnSeries.IsDirty())
			{
				hashtables.Add("columnSeries", this.ColumnSeries.ToHashtable());
			}
			if (this.ColumnrangeSeries.IsDirty())
			{
				hashtables.Add("columnrangeSeries", this.ColumnrangeSeries.ToHashtable());
			}
			if (this.ErrorbarSeries.IsDirty())
			{
				hashtables.Add("errorbarSeries", this.ErrorbarSeries.ToHashtable());
			}
			if (this.FunnelSeries.IsDirty())
			{
				hashtables.Add("funnelSeries", this.FunnelSeries.ToHashtable());
			}
			if (this.GaugeSeries.IsDirty())
			{
				hashtables.Add("gaugeSeries", this.GaugeSeries.ToHashtable());
			}
			if (this.HeatmapSeries.IsDirty())
			{
				hashtables.Add("heatmapSeries", this.HeatmapSeries.ToHashtable());
			}
			if (this.LineSeries.IsDirty())
			{
				hashtables.Add("lineSeries", this.LineSeries.ToHashtable());
			}
			if (this.PieSeries.IsDirty())
			{
				hashtables.Add("pieSeries", this.PieSeries.ToHashtable());
			}
			if (this.PolygonSeries.IsDirty())
			{
				hashtables.Add("polygonSeries", this.PolygonSeries.ToHashtable());
			}
			if (this.PyramidSeries.IsDirty())
			{
				hashtables.Add("pyramidSeries", this.PyramidSeries.ToHashtable());
			}
			if (this.ScatterSeries.IsDirty())
			{
				hashtables.Add("scatterSeries", this.ScatterSeries.ToHashtable());
			}
			if (this.SolidgaugeSeries.IsDirty())
			{
				hashtables.Add("solidgaugeSeries", this.SolidgaugeSeries.ToHashtable());
			}
			if (this.SplineSeries.IsDirty())
			{
				hashtables.Add("splineSeries", this.SplineSeries.ToHashtable());
			}
			if (this.TreemapSeries.IsDirty())
			{
				hashtables.Add("treemapSeries", this.TreemapSeries.ToHashtable());
			}
			if (this.WaterfallSeries.IsDirty())
			{
				hashtables.Add("waterfallSeries", this.WaterfallSeries.ToHashtable());
			}
			if (this.Subtitle.IsDirty())
			{
				hashtables.Add("subtitle", this.Subtitle.ToHashtable());
			}
			if (this.Title.IsDirty())
			{
				hashtables.Add("title", this.Title.ToHashtable());
			}
			if (this.Tooltip.IsDirty())
			{
				hashtables.Add("tooltip", this.Tooltip.ToHashtable());
			}
			if (this.XAxis != this.XAxis_DefaultValue)
			{
				hashtables.Add("xAxis", base.HashifyList(this.XAxis));
			}
			if (this.YAxis != this.YAxis_DefaultValue)
			{
				hashtables.Add("yAxis", base.HashifyList(this.YAxis));
			}
			if (this.ZAxis.IsDirty())
			{
				hashtables.Add("zAxis", this.ZAxis.ToHashtable());
			}
			if (this.ColorAxis.IsDirty())
			{
				hashtables.Add("colorAxis", this.ColorAxis.ToHashtable());
			}
			if (this.Stops != this.Stops_DefaultValue)
			{
				hashtables.Add("stops", base.HashifyList(this.Stops));
			}
			double? min = this.Min;
			double? minDefaultValue = this.Min_DefaultValue;
			if ((min.GetValueOrDefault() == minDefaultValue.GetValueOrDefault() ? min.HasValue != minDefaultValue.HasValue : true))
			{
				hashtables.Add("min", this.Min);
			}
			minDefaultValue = this.Max;
			min = this.Max_DefaultValue;
			if ((minDefaultValue.GetValueOrDefault() == min.GetValueOrDefault() ? minDefaultValue.HasValue != min.HasValue : true))
			{
				hashtables.Add("max", this.Max);
			}
			bool? startOnTick = this.StartOnTick;
			bool? startOnTickDefaultValue = this.StartOnTick_DefaultValue;
			if ((startOnTick.GetValueOrDefault() == startOnTickDefaultValue.GetValueOrDefault() ? startOnTick.HasValue != startOnTickDefaultValue.HasValue : true))
			{
				hashtables.Add("startOnTick", this.StartOnTick);
			}
			startOnTickDefaultValue = this.EndOnTick;
			startOnTick = this.EndOnTick_DefaultValue;
			if ((startOnTickDefaultValue.GetValueOrDefault() == startOnTick.GetValueOrDefault() ? startOnTickDefaultValue.HasValue != startOnTick.HasValue : true))
			{
				hashtables.Add("endOnTick", this.EndOnTick);
			}
			if (this.MinColor != this.MinColor_DefaultValue)
			{
				hashtables.Add("minColor", this.MinColor);
			}
			if (this.MaxColor != this.MaxColor_DefaultValue)
			{
				hashtables.Add("maxColor", this.MaxColor);
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