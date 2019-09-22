using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class ChartEvents : BaseObject
	{
		public string AddSeries
		{
			get;
			set;
		}

		private string AddSeries_DefaultValue
		{
			get;
			set;
		}

		public string AfterPrint
		{
			get;
			set;
		}

		private string AfterPrint_DefaultValue
		{
			get;
			set;
		}

		public string BeforePrint
		{
			get;
			set;
		}

		private string BeforePrint_DefaultValue
		{
			get;
			set;
		}

		public string Click
		{
			get;
			set;
		}

		private string Click_DefaultValue
		{
			get;
			set;
		}

		public string Drilldown
		{
			get;
			set;
		}

		private string Drilldown_DefaultValue
		{
			get;
			set;
		}

		public string Drillup
		{
			get;
			set;
		}

		private string Drillup_DefaultValue
		{
			get;
			set;
		}

		public string Drillupall
		{
			get;
			set;
		}

		private string Drillupall_DefaultValue
		{
			get;
			set;
		}

		public string Load
		{
			get;
			set;
		}

		private string Load_DefaultValue
		{
			get;
			set;
		}

		public string Redraw
		{
			get;
			set;
		}

		private string Redraw_DefaultValue
		{
			get;
			set;
		}

		public string Render
		{
			get;
			set;
		}

		private string Render_DefaultValue
		{
			get;
			set;
		}

		public string Selection
		{
			get;
			set;
		}

		private string Selection_DefaultValue
		{
			get;
			set;
		}

		public ChartEvents()
		{
			string str = "";
			string str1 = str;
			this.AddSeries_DefaultValue = str;
			this.AddSeries = str1;
			string str2 = "";
			str1 = str2;
			this.AfterPrint_DefaultValue = str2;
			this.AfterPrint = str1;
			string str3 = "";
			str1 = str3;
			this.BeforePrint_DefaultValue = str3;
			this.BeforePrint = str1;
			string str4 = "";
			str1 = str4;
			this.Click_DefaultValue = str4;
			this.Click = str1;
			string str5 = "";
			str1 = str5;
			this.Drilldown_DefaultValue = str5;
			this.Drilldown = str1;
			string str6 = "";
			str1 = str6;
			this.Drillup_DefaultValue = str6;
			this.Drillup = str1;
			string str7 = "";
			str1 = str7;
			this.Drillupall_DefaultValue = str7;
			this.Drillupall = str1;
			string str8 = "";
			str1 = str8;
			this.Load_DefaultValue = str8;
			this.Load = str1;
			string str9 = "";
			str1 = str9;
			this.Redraw_DefaultValue = str9;
			this.Redraw = str1;
			string str10 = "";
			str1 = str10;
			this.Render_DefaultValue = str10;
			this.Render = str1;
			string str11 = "";
			str1 = str11;
			this.Selection_DefaultValue = str11;
			this.Selection = str1;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.AddSeries != this.AddSeries_DefaultValue)
			{
				hashtables.Add("addSeries", this.AddSeries);
				Highcharts.AddFunction("ChartEventsAddSeries.addSeries", this.AddSeries);
			}
			if (this.AfterPrint != this.AfterPrint_DefaultValue)
			{
				hashtables.Add("afterPrint", this.AfterPrint);
				Highcharts.AddFunction("ChartEventsAfterPrint.afterPrint", this.AfterPrint);
			}
			if (this.BeforePrint != this.BeforePrint_DefaultValue)
			{
				hashtables.Add("beforePrint", this.BeforePrint);
				Highcharts.AddFunction("ChartEventsBeforePrint.beforePrint", this.BeforePrint);
			}
			if (this.Click != this.Click_DefaultValue)
			{
				hashtables.Add("click", this.Click);
				Highcharts.AddFunction("ChartEventsClick.click", this.Click);
			}
			if (this.Drilldown != this.Drilldown_DefaultValue)
			{
				hashtables.Add("drilldown", this.Drilldown);
				Highcharts.AddFunction("ChartEventsDrilldown.drilldown", this.Drilldown);
			}
			if (this.Drillup != this.Drillup_DefaultValue)
			{
				hashtables.Add("drillup", this.Drillup);
				Highcharts.AddFunction("ChartEventsDrillup.drillup", this.Drillup);
			}
			if (this.Drillupall != this.Drillupall_DefaultValue)
			{
				hashtables.Add("drillupall", this.Drillupall);
				Highcharts.AddFunction("ChartEventsDrillupall.drillupall", this.Drillupall);
			}
			if (this.Load != this.Load_DefaultValue)
			{
				hashtables.Add("load", this.Load);
				Highcharts.AddFunction("ChartEventsLoad.load", this.Load);
			}
			if (this.Redraw != this.Redraw_DefaultValue)
			{
				hashtables.Add("redraw", this.Redraw);
				Highcharts.AddFunction("ChartEventsRedraw.redraw", this.Redraw);
			}
			if (this.Render != this.Render_DefaultValue)
			{
				hashtables.Add("render", this.Render);
				Highcharts.AddFunction("ChartEventsRender.render", this.Render);
			}
			if (this.Selection != this.Selection_DefaultValue)
			{
				hashtables.Add("selection", this.Selection);
				Highcharts.AddFunction("ChartEventsSelection.selection", this.Selection);
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