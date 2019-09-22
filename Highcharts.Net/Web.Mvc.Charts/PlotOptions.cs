using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptions : BaseObject
	{
		public PlotOptionsArea Area
		{
			get;
			set;
		}

		private PlotOptionsArea Area_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsArearange Arearange
		{
			get;
			set;
		}

		private PlotOptionsArearange Arearange_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsAreaspline Areaspline
		{
			get;
			set;
		}

		private PlotOptionsAreaspline Areaspline_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsAreasplinerange Areasplinerange
		{
			get;
			set;
		}

		private PlotOptionsAreasplinerange Areasplinerange_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsBar Bar
		{
			get;
			set;
		}

		private PlotOptionsBar Bar_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsBoxplot Boxplot
		{
			get;
			set;
		}

		private PlotOptionsBoxplot Boxplot_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsBubble Bubble
		{
			get;
			set;
		}

		private PlotOptionsBubble Bubble_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsColumn Column
		{
			get;
			set;
		}

		private PlotOptionsColumn Column_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsColumnrange Columnrange
		{
			get;
			set;
		}

		private PlotOptionsColumnrange Columnrange_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsErrorbar Errorbar
		{
			get;
			set;
		}

		private PlotOptionsErrorbar Errorbar_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsFunnel Funnel
		{
			get;
			set;
		}

		private PlotOptionsFunnel Funnel_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsGauge Gauge
		{
			get;
			set;
		}

		private PlotOptionsGauge Gauge_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsHeatmap Heatmap
		{
			get;
			set;
		}

		private PlotOptionsHeatmap Heatmap_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsLine Line
		{
			get;
			set;
		}

		private PlotOptionsLine Line_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsPie Pie
		{
			get;
			set;
		}

		private PlotOptionsPie Pie_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsPolygon Polygon
		{
			get;
			set;
		}

		private PlotOptionsPolygon Polygon_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsPyramid Pyramid
		{
			get;
			set;
		}

		private PlotOptionsPyramid Pyramid_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsScatter Scatter
		{
			get;
			set;
		}

		private PlotOptionsScatter Scatter_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsSeries Series
		{
			get;
			set;
		}

		private PlotOptionsSeries Series_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsSolidgauge Solidgauge
		{
			get;
			set;
		}

		private PlotOptionsSolidgauge Solidgauge_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsSpline Spline
		{
			get;
			set;
		}

		private PlotOptionsSpline Spline_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsTreemap Treemap
		{
			get;
			set;
		}

		private PlotOptionsTreemap Treemap_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsWaterfall Waterfall
		{
			get;
			set;
		}

		private PlotOptionsWaterfall Waterfall_DefaultValue
		{
			get;
			set;
		}

		public PlotOptions()
		{
			PlotOptionsArea plotOptionsArea = new PlotOptionsArea();
			PlotOptionsArea plotOptionsArea1 = plotOptionsArea;
			this.Area_DefaultValue = plotOptionsArea;
			this.Area = plotOptionsArea1;
			PlotOptionsArearange plotOptionsArearange = new PlotOptionsArearange();
			PlotOptionsArearange plotOptionsArearange1 = plotOptionsArearange;
			this.Arearange_DefaultValue = plotOptionsArearange;
			this.Arearange = plotOptionsArearange1;
			PlotOptionsAreaspline plotOptionsAreaspline = new PlotOptionsAreaspline();
			PlotOptionsAreaspline plotOptionsAreaspline1 = plotOptionsAreaspline;
			this.Areaspline_DefaultValue = plotOptionsAreaspline;
			this.Areaspline = plotOptionsAreaspline1;
			PlotOptionsAreasplinerange plotOptionsAreasplinerange = new PlotOptionsAreasplinerange();
			PlotOptionsAreasplinerange plotOptionsAreasplinerange1 = plotOptionsAreasplinerange;
			this.Areasplinerange_DefaultValue = plotOptionsAreasplinerange;
			this.Areasplinerange = plotOptionsAreasplinerange1;
			PlotOptionsBar plotOptionsBar = new PlotOptionsBar();
			PlotOptionsBar plotOptionsBar1 = plotOptionsBar;
			this.Bar_DefaultValue = plotOptionsBar;
			this.Bar = plotOptionsBar1;
			PlotOptionsBoxplot plotOptionsBoxplot = new PlotOptionsBoxplot();
			PlotOptionsBoxplot plotOptionsBoxplot1 = plotOptionsBoxplot;
			this.Boxplot_DefaultValue = plotOptionsBoxplot;
			this.Boxplot = plotOptionsBoxplot1;
			PlotOptionsBubble plotOptionsBubble = new PlotOptionsBubble();
			PlotOptionsBubble plotOptionsBubble1 = plotOptionsBubble;
			this.Bubble_DefaultValue = plotOptionsBubble;
			this.Bubble = plotOptionsBubble1;
			PlotOptionsColumn plotOptionsColumn = new PlotOptionsColumn();
			PlotOptionsColumn plotOptionsColumn1 = plotOptionsColumn;
			this.Column_DefaultValue = plotOptionsColumn;
			this.Column = plotOptionsColumn1;
			PlotOptionsColumnrange plotOptionsColumnrange = new PlotOptionsColumnrange();
			PlotOptionsColumnrange plotOptionsColumnrange1 = plotOptionsColumnrange;
			this.Columnrange_DefaultValue = plotOptionsColumnrange;
			this.Columnrange = plotOptionsColumnrange1;
			PlotOptionsErrorbar plotOptionsErrorbar = new PlotOptionsErrorbar();
			PlotOptionsErrorbar plotOptionsErrorbar1 = plotOptionsErrorbar;
			this.Errorbar_DefaultValue = plotOptionsErrorbar;
			this.Errorbar = plotOptionsErrorbar1;
			PlotOptionsFunnel plotOptionsFunnel = new PlotOptionsFunnel();
			PlotOptionsFunnel plotOptionsFunnel1 = plotOptionsFunnel;
			this.Funnel_DefaultValue = plotOptionsFunnel;
			this.Funnel = plotOptionsFunnel1;
			PlotOptionsGauge plotOptionsGauge = new PlotOptionsGauge();
			PlotOptionsGauge plotOptionsGauge1 = plotOptionsGauge;
			this.Gauge_DefaultValue = plotOptionsGauge;
			this.Gauge = plotOptionsGauge1;
			PlotOptionsHeatmap plotOptionsHeatmap = new PlotOptionsHeatmap();
			PlotOptionsHeatmap plotOptionsHeatmap1 = plotOptionsHeatmap;
			this.Heatmap_DefaultValue = plotOptionsHeatmap;
			this.Heatmap = plotOptionsHeatmap1;
			PlotOptionsLine plotOptionsLine = new PlotOptionsLine();
			PlotOptionsLine plotOptionsLine1 = plotOptionsLine;
			this.Line_DefaultValue = plotOptionsLine;
			this.Line = plotOptionsLine1;
			PlotOptionsPie plotOptionsPie = new PlotOptionsPie();
			PlotOptionsPie plotOptionsPie1 = plotOptionsPie;
			this.Pie_DefaultValue = plotOptionsPie;
			this.Pie = plotOptionsPie1;
			PlotOptionsPolygon plotOptionsPolygon = new PlotOptionsPolygon();
			PlotOptionsPolygon plotOptionsPolygon1 = plotOptionsPolygon;
			this.Polygon_DefaultValue = plotOptionsPolygon;
			this.Polygon = plotOptionsPolygon1;
			PlotOptionsPyramid plotOptionsPyramid = new PlotOptionsPyramid();
			PlotOptionsPyramid plotOptionsPyramid1 = plotOptionsPyramid;
			this.Pyramid_DefaultValue = plotOptionsPyramid;
			this.Pyramid = plotOptionsPyramid1;
			PlotOptionsScatter plotOptionsScatter = new PlotOptionsScatter();
			PlotOptionsScatter plotOptionsScatter1 = plotOptionsScatter;
			this.Scatter_DefaultValue = plotOptionsScatter;
			this.Scatter = plotOptionsScatter1;
			PlotOptionsSeries plotOptionsSeries = new PlotOptionsSeries();
			PlotOptionsSeries plotOptionsSeries1 = plotOptionsSeries;
			this.Series_DefaultValue = plotOptionsSeries;
			this.Series = plotOptionsSeries1;
			PlotOptionsSolidgauge plotOptionsSolidgauge = new PlotOptionsSolidgauge();
			PlotOptionsSolidgauge plotOptionsSolidgauge1 = plotOptionsSolidgauge;
			this.Solidgauge_DefaultValue = plotOptionsSolidgauge;
			this.Solidgauge = plotOptionsSolidgauge1;
			PlotOptionsSpline plotOptionsSpline = new PlotOptionsSpline();
			PlotOptionsSpline plotOptionsSpline1 = plotOptionsSpline;
			this.Spline_DefaultValue = plotOptionsSpline;
			this.Spline = plotOptionsSpline1;
			PlotOptionsTreemap plotOptionsTreemap = new PlotOptionsTreemap();
			PlotOptionsTreemap plotOptionsTreemap1 = plotOptionsTreemap;
			this.Treemap_DefaultValue = plotOptionsTreemap;
			this.Treemap = plotOptionsTreemap1;
			PlotOptionsWaterfall plotOptionsWaterfall = new PlotOptionsWaterfall();
			PlotOptionsWaterfall plotOptionsWaterfall1 = plotOptionsWaterfall;
			this.Waterfall_DefaultValue = plotOptionsWaterfall;
			this.Waterfall = plotOptionsWaterfall1;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.Area.IsDirty())
			{
				hashtables.Add("area", this.Area.ToHashtable());
			}
			if (this.Arearange.IsDirty())
			{
				hashtables.Add("arearange", this.Arearange.ToHashtable());
			}
			if (this.Areaspline.IsDirty())
			{
				hashtables.Add("areaspline", this.Areaspline.ToHashtable());
			}
			if (this.Areasplinerange.IsDirty())
			{
				hashtables.Add("areasplinerange", this.Areasplinerange.ToHashtable());
			}
			if (this.Bar.IsDirty())
			{
				hashtables.Add("bar", this.Bar.ToHashtable());
			}
			if (this.Boxplot.IsDirty())
			{
				hashtables.Add("boxplot", this.Boxplot.ToHashtable());
			}
			if (this.Bubble.IsDirty())
			{
				hashtables.Add("bubble", this.Bubble.ToHashtable());
			}
			if (this.Column.IsDirty())
			{
				hashtables.Add("column", this.Column.ToHashtable());
			}
			if (this.Columnrange.IsDirty())
			{
				hashtables.Add("columnrange", this.Columnrange.ToHashtable());
			}
			if (this.Errorbar.IsDirty())
			{
				hashtables.Add("errorbar", this.Errorbar.ToHashtable());
			}
			if (this.Funnel.IsDirty())
			{
				hashtables.Add("funnel", this.Funnel.ToHashtable());
			}
			if (this.Gauge.IsDirty())
			{
				hashtables.Add("gauge", this.Gauge.ToHashtable());
			}
			if (this.Heatmap.IsDirty())
			{
				hashtables.Add("heatmap", this.Heatmap.ToHashtable());
			}
			if (this.Line.IsDirty())
			{
				hashtables.Add("line", this.Line.ToHashtable());
			}
			if (this.Pie.IsDirty())
			{
				hashtables.Add("pie", this.Pie.ToHashtable());
			}
			if (this.Polygon.IsDirty())
			{
				hashtables.Add("polygon", this.Polygon.ToHashtable());
			}
			if (this.Pyramid.IsDirty())
			{
				hashtables.Add("pyramid", this.Pyramid.ToHashtable());
			}
			if (this.Scatter.IsDirty())
			{
				hashtables.Add("scatter", this.Scatter.ToHashtable());
			}
			if (this.Series.IsDirty())
			{
				hashtables.Add("series", this.Series.ToHashtable());
			}
			if (this.Solidgauge.IsDirty())
			{
				hashtables.Add("solidgauge", this.Solidgauge.ToHashtable());
			}
			if (this.Spline.IsDirty())
			{
				hashtables.Add("spline", this.Spline.ToHashtable());
			}
			if (this.Treemap.IsDirty())
			{
				hashtables.Add("treemap", this.Treemap.ToHashtable());
			}
			if (this.Waterfall.IsDirty())
			{
				hashtables.Add("waterfall", this.Waterfall.ToHashtable());
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