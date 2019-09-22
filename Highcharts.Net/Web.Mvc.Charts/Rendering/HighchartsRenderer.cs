using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts.Rendering
{
	public class HighchartsRenderer
	{
		private readonly Highcharts _chart;

		public HighchartsRenderer(Highcharts chart)
		{
			_chart = chart;
		}

		public string GetJsonOptions()
		{
			return GetJsonResponse(LicenseVerifier.Check());
		}

		private string GetJsonResponse(int licenseType)
		{
			return GetStartupOptions();

			// bypass serial key check.
			//string startupOptions;
			//string str = "";
			//if ((licenseType == -1 ? false : licenseType != 0) || !(DateTime.Now > CompiledOn.CompilationDate.AddDays(30)))
			//{
			//	startupOptions = GetStartupOptions();
			//}
			//else
			//{
			//	str = string.Concat(str,
			//		"Message:\"This is a trial version of Highcharts for ASP.NET MVC which has expired. Please contact sales@highsoft.com with any questions.\"");
			//	startupOptions = string.Concat("{", str, "}");
			//}
			//return startupOptions;
		}

		private string GetResponse(int licenseType)
		{

			return GetStartupJavascript();

			// bypass serial key check.
			//string str;
			//string str1 = "";
			//if (licenseType == 0)
			//{
			//	str1 = "<div style=\"background:yellow\">Incorrect serial key. I'm working in trial mode now.</div>";
			//}
			//if ((licenseType == -1 ? false : licenseType != 0) || !(DateTime.Now > CompiledOn.CompilationDate.AddDays(30)))
			//{
			//	str = string.Concat(str1, GetStartupJavascript());
			//}
			//else
			//{
			//	str1 = string.Concat(str1,
			//		"This is a trial version of Highcharts for ASP.NET MVC which has expired.<br> Please contact sales@highsoft.com with any questions.");
			//	str = str1;
			//}
			//return str;
		}

		private string GetStartupJavascript()
		{
			StringBuilder stringBuilder = new StringBuilder();
			_chart.Chart.RenderTo = _chart.ID;
			string d = _chart.ID;
			string str = _chart.Chart.Height;
			double? width = _chart.Chart.Width;
			stringBuilder.AppendFormat("<div id='{0}' style='height:{1};min-width:{2};clear:both;margin: 0 auto;'></div>", d, str,
				width);
			stringBuilder.Append("<script type='text/javascript'>");
			stringBuilder.Append(
				$"if (document.addEventListener) {{document.addEventListener(\"DOMContentLoaded\", function() {{createChart{_chart.ID}();}});}} else if (document.attachEvent) {{document.attachEvent(\"onreadystatechange\", function(){{if (document.readyState === \"complete\"){{document.detachEvent(\"onreadystatechange\", arguments.callee);createChart{_chart.ID}();}}}});}}");
			stringBuilder.Append($"function createChart{_chart.ID}() {{");
			stringBuilder.Append($"var ChartOptions = {GetStartupOptions()};");
			stringBuilder.Append($"new Highcharts.chart(\"{_chart.ID}\",ChartOptions);");
			stringBuilder.Append("}");
			stringBuilder.Append("</script>");
			return stringBuilder.ToString();
		}

		private string GetStartupOptions()
		{
			StringBuilder stringBuilder = new StringBuilder();
			RenderChartSettings(stringBuilder);
			return stringBuilder.ToString();
		}

		private void RenderChartSettings(StringBuilder s)
		{
			Hashtable hashtable = _chart.ToHashtable();
			List<Hashtable> hashtables = new List<Hashtable>();
			List<Hashtable> hashtables1 = new List<Hashtable>();
			if (_chart.Series != null)
			{
				hashtables = SeriesToHashtables(_chart.Series);
			}
			if (_chart.Drilldown.Series != null)
			{
				hashtables1 = SeriesToHashtables(_chart.Drilldown.Series);
			}
			if (hashtables.Count > 0)
			{
				hashtable["series"] = hashtables;
			}
			if (hashtables1.Count > 0)
			{
				(hashtable["drilldown"] as Hashtable)["series"] = hashtables1;
			}
			JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer
			{
				MaxJsonLength = 2147483647
			};
			string str = javaScriptSerializer.Serialize(hashtable);
			Hashtable hashtables2 = Highcharts.functions;
			foreach (string key in hashtables2.Keys)
			{
				string item = (string) hashtables2[key];
				string str1 = key.Split('.')[1];
				string str2 = $"\"{str1}\":\"{item}\"";
				string str3 = $"\"{str1}\":{item}";
				str = str.Replace(str2, str3);
			}
			s.Append(str);
		}

		public string RenderHtml()
		{
			return GetResponse(LicenseVerifier.Check());
		}

		private List<Hashtable> SeriesToHashtables(List<Series> listOfSeries)
		{
			List<Hashtable> hashtables = new List<Hashtable>();
			foreach (Series series in listOfSeries)
			{
				List<object> objs = new List<object>();
				Hashtable hashtable = new Hashtable();
				if (series is LineSeries)
				{
					LineSeries lineSeries = series as LineSeries;
					lineSeries.Data.ForEach((LineSeriesData data) => objs.Add(data.ToHashtable()));
					lineSeries.Type = LineSeriesType.Line;
					hashtable = lineSeries.ToHashtable();
				}
				if (series is SplineSeries)
				{
					SplineSeries splineSeries = series as SplineSeries;
					splineSeries.Data.ForEach((SplineSeriesData data) => objs.Add(data.ToHashtable()));
					splineSeries.Type = SplineSeriesType.Spline;
					hashtable = splineSeries.ToHashtable();
				}
				if (series is AreaSeries)
				{
					AreaSeries areaSeries = series as AreaSeries;
					areaSeries.Data.ForEach((AreaSeriesData data) => objs.Add(data.ToHashtable()));
					areaSeries.Type = AreaSeriesType.Area;
					hashtable = areaSeries.ToHashtable();
				}
				if (series is AreasplineSeries)
				{
					AreasplineSeries areasplineSeries = series as AreasplineSeries;
					areasplineSeries.Data.ForEach((AreasplineSeriesData data) => objs.Add(data.ToHashtable()));
					areasplineSeries.Type = AreasplineSeriesType.Areaspline;
					hashtable = areasplineSeries.ToHashtable();
				}
				if (series is ArearangeSeries)
				{
					ArearangeSeries arearangeSeries = series as ArearangeSeries;
					arearangeSeries.Data.ForEach((ArearangeSeriesData data) => objs.Add(data.ToHashtable()));
					arearangeSeries.Type = ArearangeSeriesType.Arearange;
					hashtable = arearangeSeries.ToHashtable();
				}
				if (series is ColumnrangeSeries)
				{
					ColumnrangeSeries columnrangeSeries = series as ColumnrangeSeries;
					columnrangeSeries.Data.ForEach((ColumnrangeSeriesData data) => objs.Add(data.ToHashtable()));
					columnrangeSeries.Type = ColumnrangeSeriesType.Columnrange;
					hashtable = columnrangeSeries.ToHashtable();
				}
				if (series is BarSeries)
				{
					BarSeries barSeries = series as BarSeries;
					barSeries.Data.ForEach((BarSeriesData data) => objs.Add(data.ToHashtable()));
					barSeries.Type = BarSeriesType.Bar;
					hashtable = barSeries.ToHashtable();
				}
				if (series is ColumnSeries)
				{
					ColumnSeries columnSeries = series as ColumnSeries;
					columnSeries.Data.ForEach((ColumnSeriesData data) => objs.Add(data.ToHashtable()));
					columnSeries.Type = ColumnSeriesType.Column;
					hashtable = columnSeries.ToHashtable();
				}
				if (series is PieSeries)
				{
					PieSeries pieSeries = series as PieSeries;
					pieSeries.Data.ForEach((PieSeriesData data) => objs.Add(data.ToHashtable()));
					pieSeries.Type = PieSeriesType.Pie;
					hashtable = pieSeries.ToHashtable();
				}
				if (series is ScatterSeries)
				{
					ScatterSeries scatterSeries = series as ScatterSeries;
					scatterSeries.Data.ForEach((ScatterSeriesData data) => objs.Add(data.ToHashtable()));
					scatterSeries.Type = ScatterSeriesType.Scatter;
					hashtable = scatterSeries.ToHashtable();
				}
				if (series is BubbleSeries)
				{
					BubbleSeries bubbleSeries = series as BubbleSeries;
					bubbleSeries.Data.ForEach((BubbleSeriesData data) => objs.Add(data.ToHashtable()));
					bubbleSeries.Type = BubbleSeriesType.Bubble;
					hashtable = bubbleSeries.ToHashtable();
				}
				if (series is GaugeSeries)
				{
					GaugeSeries gaugeSeries = series as GaugeSeries;
					gaugeSeries.Data.ForEach((GaugeSeriesData data) => objs.Add(data.ToHashtable()));
					gaugeSeries.Type = GaugeSeriesType.Gauge;
					hashtable = gaugeSeries.ToHashtable();
				}
				if (series is SolidgaugeSeries)
				{
					SolidgaugeSeries solidgaugeSeries = series as SolidgaugeSeries;
					solidgaugeSeries.Data.ForEach((SolidgaugeSeriesData data) => objs.Add(data.ToHashtable()));
					solidgaugeSeries.Type = SolidgaugeSeriesType.Solidgauge;
					hashtable = solidgaugeSeries.ToHashtable();
				}
				if (series is HeatmapSeries)
				{
					HeatmapSeries heatmapSeries = series as HeatmapSeries;
					heatmapSeries.Data.ForEach((HeatmapSeriesData data) => objs.Add(data.ToHashtable()));
					heatmapSeries.Type = HeatmapSeriesType.Heatmap;
					hashtable = heatmapSeries.ToHashtable();
				}
				if (series is BoxplotSeries)
				{
					BoxplotSeries boxplotSeries = series as BoxplotSeries;
					boxplotSeries.Data.ForEach((BoxplotSeriesData data) => objs.Add(data.ToHashtable()));
					boxplotSeries.Type = BoxplotSeriesType.Boxplot;
					hashtable = boxplotSeries.ToHashtable();
				}
				if (series is ErrorbarSeries)
				{
					ErrorbarSeries errorbarSeries = series as ErrorbarSeries;
					errorbarSeries.Data.ForEach((ErrorbarSeriesData data) => objs.Add(data.ToHashtable()));
					errorbarSeries.Type = ErrorbarSeriesType.Errorbar;
					hashtable = errorbarSeries.ToHashtable();
				}
				if (series is FunnelSeries)
				{
					FunnelSeries funnelSeries = series as FunnelSeries;
					funnelSeries.Data.ForEach((FunnelSeriesData data) => objs.Add(data.ToHashtable()));
					funnelSeries.Type = FunnelSeriesType.Funnel;
					hashtable = funnelSeries.ToHashtable();
				}
				if (series is PyramidSeries)
				{
					PyramidSeries pyramidSeries = series as PyramidSeries;
					pyramidSeries.Data.ForEach((PyramidSeriesData data) => objs.Add(data.ToHashtable()));
					pyramidSeries.Type = PyramidSeriesType.Pyramid;
					hashtable = pyramidSeries.ToHashtable();
				}
				if (series is WaterfallSeries)
				{
					WaterfallSeries waterfallSeries = series as WaterfallSeries;
					waterfallSeries.Data.ForEach((WaterfallSeriesData data) => objs.Add(data.ToHashtable()));
					waterfallSeries.Type = WaterfallSeriesType.Waterfall;
					hashtable = waterfallSeries.ToHashtable();
				}
				if (series is PolygonSeries)
				{
					PolygonSeries polygonSeries = series as PolygonSeries;
					polygonSeries.Data.ForEach((PolygonSeriesData data) => objs.Add(data.ToHashtable()));
					polygonSeries.Type = PolygonSeriesType.Polygon;
					hashtable = polygonSeries.ToHashtable();
				}
				if (series is TreemapSeries)
				{
					TreemapSeries treemapSeries = series as TreemapSeries;
					treemapSeries.Data.ForEach((TreemapSeriesData data) => objs.Add(data.ToHashtable()));
					treemapSeries.Type = TreemapSeriesType.Treemap;
					hashtable = treemapSeries.ToHashtable();
				}
				hashtables.Add(hashtable);
			}
			return hashtables;
		}
	}
}