using System.Web;
using System.Web.Mvc;
using Highsoft.Web.Mvc.Charts.Rendering;

namespace Highsoft.Web.Mvc.Charts
{
	public static class HtmlHelperExtensions
	{
		public static HtmlString Highcharts(Highcharts chart, string id)
		{
			HighchartsRenderer highchartsRenderer = new HighchartsRenderer(chart);
			chart.ID = id;
			chart.Chart.RenderTo = id;
			return new HtmlString(highchartsRenderer.RenderHtml());
		}

		public static HighsoftNamespace Highsoft(this HtmlHelper helper)
		{
			return new HighsoftNamespace();
		}
	}
}