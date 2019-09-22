using Highsoft.Web.Mvc.Charts.Rendering;
using System;
using System.ComponentModel;
using System.Web;

namespace Highsoft.Web.Mvc.Charts
{
	public class HighsoftNamespace
	{
		public HighsoftNamespace()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		private new bool Equals(object value)
		{
			return this.Equals(value);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		private new int GetHashCode()
		{
			return this.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		private new Type GetType()
		{
			return this.GetType();
		}

		public HtmlString Highcharts(Highcharts chart, string id)
		{
			HighchartsRenderer highchartsRenderer = new HighchartsRenderer(chart);
			chart.ID = id;
			chart.Chart.RenderTo = id;
			return new HtmlString(highchartsRenderer.RenderHtml());
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		private new string ToString()
		{
			return this.ToString();
		}
	}
}