using System.Collections;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class ArearangeSeriesDataEvents : BaseObject
	{
		public string Click { get; set; }

		private string Click_DefaultValue { get; }

		public string MouseOut { get; set; }

		private string MouseOut_DefaultValue { get; }

		public string MouseOver { get; set; }

		private string MouseOver_DefaultValue { get; }

		public string Remove { get; set; }

		private string Remove_DefaultValue { get; }

		public string Select { get; set; }

		private string Select_DefaultValue { get; }

		public string Unselect { get; set; }

		private string Unselect_DefaultValue { get; }

		public string Update { get; set; }

		private string Update_DefaultValue { get; }

		public ArearangeSeriesDataEvents()
		{
			string str = "";
			string str1 = str;
			Click_DefaultValue = str;
			Click = str1;
			string str2 = "";
			str1 = str2;
			MouseOut_DefaultValue = str2;
			MouseOut = str1;
			string str3 = "";
			str1 = str3;
			MouseOver_DefaultValue = str3;
			MouseOver = str1;
			string str4 = "";
			str1 = str4;
			Remove_DefaultValue = str4;
			Remove = str1;
			string str5 = "";
			str1 = str5;
			Select_DefaultValue = str5;
			Select = str1;
			string str6 = "";
			str1 = str6;
			Unselect_DefaultValue = str6;
			Unselect = str1;
			string str7 = "";
			str1 = str7;
			Update_DefaultValue = str7;
			Update = str1;
		}

		internal override bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (Click != Click_DefaultValue)
			{
				hashtables.Add("click", Click);
				Highcharts.AddFunction("ArearangeSeriesDataEventsClick.click", Click);
			}
			if (MouseOut != MouseOut_DefaultValue)
			{
				hashtables.Add("mouseOut", MouseOut);
				Highcharts.AddFunction("ArearangeSeriesDataEventsMouseOut.mouseOut", MouseOut);
			}
			if (MouseOver != MouseOver_DefaultValue)
			{
				hashtables.Add("mouseOver", MouseOver);
				Highcharts.AddFunction("ArearangeSeriesDataEventsMouseOver.mouseOver", MouseOver);
			}
			if (Remove != Remove_DefaultValue)
			{
				hashtables.Add("remove", Remove);
				Highcharts.AddFunction("ArearangeSeriesDataEventsRemove.remove", Remove);
			}
			if (Select != Select_DefaultValue)
			{
				hashtables.Add("select", Select);
				Highcharts.AddFunction("ArearangeSeriesDataEventsSelect.select", Select);
			}
			if (Unselect != Unselect_DefaultValue)
			{
				hashtables.Add("unselect", Unselect);
				Highcharts.AddFunction("ArearangeSeriesDataEventsUnselect.unselect", Unselect);
			}
			if (Update != Update_DefaultValue)
			{
				hashtables.Add("update", Update);
				Highcharts.AddFunction("ArearangeSeriesDataEventsUpdate.update", Update);
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