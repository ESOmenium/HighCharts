using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PieSeriesDataEvents : BaseObject
	{
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

		public string Remove
		{
			get;
			set;
		}

		private string Remove_DefaultValue
		{
			get;
			set;
		}

		public string Select
		{
			get;
			set;
		}

		private string Select_DefaultValue
		{
			get;
			set;
		}

		public string Unselect
		{
			get;
			set;
		}

		private string Unselect_DefaultValue
		{
			get;
			set;
		}

		public string Update
		{
			get;
			set;
		}

		private string Update_DefaultValue
		{
			get;
			set;
		}

		public PieSeriesDataEvents()
		{
			string str = "";
			string str1 = str;
			this.Click_DefaultValue = str;
			this.Click = str1;
			string str2 = "";
			str1 = str2;
			this.MouseOut_DefaultValue = str2;
			this.MouseOut = str1;
			string str3 = "";
			str1 = str3;
			this.MouseOver_DefaultValue = str3;
			this.MouseOver = str1;
			string str4 = "";
			str1 = str4;
			this.Remove_DefaultValue = str4;
			this.Remove = str1;
			string str5 = "";
			str1 = str5;
			this.Select_DefaultValue = str5;
			this.Select = str1;
			string str6 = "";
			str1 = str6;
			this.Unselect_DefaultValue = str6;
			this.Unselect = str1;
			string str7 = "";
			str1 = str7;
			this.Update_DefaultValue = str7;
			this.Update = str1;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.Click != this.Click_DefaultValue)
			{
				hashtables.Add("click", this.Click);
				Highcharts.AddFunction("PieSeriesDataEventsClick.click", this.Click);
			}
			if (this.MouseOut != this.MouseOut_DefaultValue)
			{
				hashtables.Add("mouseOut", this.MouseOut);
				Highcharts.AddFunction("PieSeriesDataEventsMouseOut.mouseOut", this.MouseOut);
			}
			if (this.MouseOver != this.MouseOver_DefaultValue)
			{
				hashtables.Add("mouseOver", this.MouseOver);
				Highcharts.AddFunction("PieSeriesDataEventsMouseOver.mouseOver", this.MouseOver);
			}
			if (this.Remove != this.Remove_DefaultValue)
			{
				hashtables.Add("remove", this.Remove);
				Highcharts.AddFunction("PieSeriesDataEventsRemove.remove", this.Remove);
			}
			if (this.Select != this.Select_DefaultValue)
			{
				hashtables.Add("select", this.Select);
				Highcharts.AddFunction("PieSeriesDataEventsSelect.select", this.Select);
			}
			if (this.Unselect != this.Unselect_DefaultValue)
			{
				hashtables.Add("unselect", this.Unselect);
				Highcharts.AddFunction("PieSeriesDataEventsUnselect.unselect", this.Unselect);
			}
			if (this.Update != this.Update_DefaultValue)
			{
				hashtables.Add("update", this.Update);
				Highcharts.AddFunction("PieSeriesDataEventsUpdate.update", this.Update);
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