using System.Collections;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class ArearangeSeriesEvents : BaseObject
	{
		public string AfterAnimate { get; set; }

		private string AfterAnimate_DefaultValue { get; }

		public string CheckboxClick { get; set; }

		private string CheckboxClick_DefaultValue { get; }

		public string Click { get; set; }

		private string Click_DefaultValue { get; }

		public string Hide { get; set; }

		private string Hide_DefaultValue { get; }

		public string LegendItemClick { get; set; }

		private string LegendItemClick_DefaultValue { get; }

		public string MouseOut { get; set; }

		private string MouseOut_DefaultValue { get; }

		public string MouseOver { get; set; }

		private string MouseOver_DefaultValue { get; }

		public string Show { get; set; }

		private string Show_DefaultValue { get; }

		public ArearangeSeriesEvents()
		{
			string str = "";
			string str1 = str;
			AfterAnimate_DefaultValue = str;
			AfterAnimate = str1;
			string str2 = "";
			str1 = str2;
			CheckboxClick_DefaultValue = str2;
			CheckboxClick = str1;
			string str3 = "";
			str1 = str3;
			Click_DefaultValue = str3;
			Click = str1;
			string str4 = "";
			str1 = str4;
			Hide_DefaultValue = str4;
			Hide = str1;
			string str5 = "";
			str1 = str5;
			LegendItemClick_DefaultValue = str5;
			LegendItemClick = str1;
			string str6 = "";
			str1 = str6;
			MouseOut_DefaultValue = str6;
			MouseOut = str1;
			string str7 = "";
			str1 = str7;
			MouseOver_DefaultValue = str7;
			MouseOver = str1;
			string str8 = "";
			str1 = str8;
			Show_DefaultValue = str8;
			Show = str1;
		}

		internal override bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (AfterAnimate != AfterAnimate_DefaultValue)
			{
				hashtables.Add("afterAnimate", AfterAnimate);
				Highcharts.AddFunction("ArearangeSeriesEventsAfterAnimate.afterAnimate", AfterAnimate);
			}
			if (CheckboxClick != CheckboxClick_DefaultValue)
			{
				hashtables.Add("checkboxClick", CheckboxClick);
				Highcharts.AddFunction("ArearangeSeriesEventsCheckboxClick.checkboxClick", CheckboxClick);
			}
			if (Click != Click_DefaultValue)
			{
				hashtables.Add("click", Click);
				Highcharts.AddFunction("ArearangeSeriesEventsClick.click", Click);
			}
			if (Hide != Hide_DefaultValue)
			{
				hashtables.Add("hide", Hide);
				Highcharts.AddFunction("ArearangeSeriesEventsHide.hide", Hide);
			}
			if (LegendItemClick != LegendItemClick_DefaultValue)
			{
				hashtables.Add("legendItemClick", LegendItemClick);
				Highcharts.AddFunction("ArearangeSeriesEventsLegendItemClick.legendItemClick", LegendItemClick);
			}
			if (MouseOut != MouseOut_DefaultValue)
			{
				hashtables.Add("mouseOut", MouseOut);
				Highcharts.AddFunction("ArearangeSeriesEventsMouseOut.mouseOut", MouseOut);
			}
			if (MouseOver != MouseOver_DefaultValue)
			{
				hashtables.Add("mouseOver", MouseOver);
				Highcharts.AddFunction("ArearangeSeriesEventsMouseOver.mouseOver", MouseOver);
			}
			if (Show != Show_DefaultValue)
			{
				hashtables.Add("show", Show);
				Highcharts.AddFunction("ArearangeSeriesEventsShow.show", Show);
			}
			return hashtables;
		}

		internal override string ToJSON()
		{
			string str;
			Hashtable hashtable = ToHashtable();
			JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer
			{
				MaxJsonLength = 2147483647
			};
			str = (hashtable.Count <= 0 ? "" : javaScriptSerializer.Serialize(ToHashtable()));
			return str;
		}
	}
}