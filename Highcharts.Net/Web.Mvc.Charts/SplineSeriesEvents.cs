using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class SplineSeriesEvents : BaseObject
	{
		public string AfterAnimate
		{
			get;
			set;
		}

		private string AfterAnimate_DefaultValue
		{
			get;
			set;
		}

		public string CheckboxClick
		{
			get;
			set;
		}

		private string CheckboxClick_DefaultValue
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

		public string Hide
		{
			get;
			set;
		}

		private string Hide_DefaultValue
		{
			get;
			set;
		}

		public string LegendItemClick
		{
			get;
			set;
		}

		private string LegendItemClick_DefaultValue
		{
			get;
			set;
		}

		public string MouseOut
		{
			get;
			set;
		}

		private string MouseOut_DefaultValue
		{
			get;
			set;
		}

		public string MouseOver
		{
			get;
			set;
		}

		private string MouseOver_DefaultValue
		{
			get;
			set;
		}

		public string Show
		{
			get;
			set;
		}

		private string Show_DefaultValue
		{
			get;
			set;
		}

		public SplineSeriesEvents()
		{
			string str = "";
			string str1 = str;
			this.AfterAnimate_DefaultValue = str;
			this.AfterAnimate = str1;
			string str2 = "";
			str1 = str2;
			this.CheckboxClick_DefaultValue = str2;
			this.CheckboxClick = str1;
			string str3 = "";
			str1 = str3;
			this.Click_DefaultValue = str3;
			this.Click = str1;
			string str4 = "";
			str1 = str4;
			this.Hide_DefaultValue = str4;
			this.Hide = str1;
			string str5 = "";
			str1 = str5;
			this.LegendItemClick_DefaultValue = str5;
			this.LegendItemClick = str1;
			string str6 = "";
			str1 = str6;
			this.MouseOut_DefaultValue = str6;
			this.MouseOut = str1;
			string str7 = "";
			str1 = str7;
			this.MouseOver_DefaultValue = str7;
			this.MouseOver = str1;
			string str8 = "";
			str1 = str8;
			this.Show_DefaultValue = str8;
			this.Show = str1;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.AfterAnimate != this.AfterAnimate_DefaultValue)
			{
				hashtables.Add("afterAnimate", this.AfterAnimate);
				Highcharts.AddFunction("SplineSeriesEventsAfterAnimate.afterAnimate", this.AfterAnimate);
			}
			if (this.CheckboxClick != this.CheckboxClick_DefaultValue)
			{
				hashtables.Add("checkboxClick", this.CheckboxClick);
				Highcharts.AddFunction("SplineSeriesEventsCheckboxClick.checkboxClick", this.CheckboxClick);
			}
			if (this.Click != this.Click_DefaultValue)
			{
				hashtables.Add("click", this.Click);
				Highcharts.AddFunction("SplineSeriesEventsClick.click", this.Click);
			}
			if (this.Hide != this.Hide_DefaultValue)
			{
				hashtables.Add("hide", this.Hide);
				Highcharts.AddFunction("SplineSeriesEventsHide.hide", this.Hide);
			}
			if (this.LegendItemClick != this.LegendItemClick_DefaultValue)
			{
				hashtables.Add("legendItemClick", this.LegendItemClick);
				Highcharts.AddFunction("SplineSeriesEventsLegendItemClick.legendItemClick", this.LegendItemClick);
			}
			if (this.MouseOut != this.MouseOut_DefaultValue)
			{
				hashtables.Add("mouseOut", this.MouseOut);
				Highcharts.AddFunction("SplineSeriesEventsMouseOut.mouseOut", this.MouseOut);
			}
			if (this.MouseOver != this.MouseOver_DefaultValue)
			{
				hashtables.Add("mouseOver", this.MouseOver);
				Highcharts.AddFunction("SplineSeriesEventsMouseOver.mouseOver", this.MouseOver);
			}
			if (this.Show != this.Show_DefaultValue)
			{
				hashtables.Add("show", this.Show);
				Highcharts.AddFunction("SplineSeriesEventsShow.show", this.Show);
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