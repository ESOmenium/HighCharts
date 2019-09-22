using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class XAxisEvents : BaseObject
	{
		public string AfterBreaks
		{
			get;
			set;
		}

		private string AfterBreaks_DefaultValue
		{
			get;
			set;
		}

		public string AfterSetExtremes
		{
			get;
			set;
		}

		private string AfterSetExtremes_DefaultValue
		{
			get;
			set;
		}

		public string PointBreak
		{
			get;
			set;
		}

		private string PointBreak_DefaultValue
		{
			get;
			set;
		}

		public string PointInBreak
		{
			get;
			set;
		}

		private string PointInBreak_DefaultValue
		{
			get;
			set;
		}

		public string SetExtremes
		{
			get;
			set;
		}

		private string SetExtremes_DefaultValue
		{
			get;
			set;
		}

		public XAxisEvents()
		{
			string str = "";
			string str1 = str;
			this.AfterBreaks_DefaultValue = str;
			this.AfterBreaks = str1;
			string str2 = "";
			str1 = str2;
			this.AfterSetExtremes_DefaultValue = str2;
			this.AfterSetExtremes = str1;
			string str3 = "";
			str1 = str3;
			this.PointBreak_DefaultValue = str3;
			this.PointBreak = str1;
			string str4 = "";
			str1 = str4;
			this.PointInBreak_DefaultValue = str4;
			this.PointInBreak = str1;
			string str5 = "";
			str1 = str5;
			this.SetExtremes_DefaultValue = str5;
			this.SetExtremes = str1;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.AfterBreaks != this.AfterBreaks_DefaultValue)
			{
				hashtables.Add("afterBreaks", this.AfterBreaks);
				Highcharts.AddFunction("XAxisEventsAfterBreaks.afterBreaks", this.AfterBreaks);
			}
			if (this.AfterSetExtremes != this.AfterSetExtremes_DefaultValue)
			{
				hashtables.Add("afterSetExtremes", this.AfterSetExtremes);
				Highcharts.AddFunction("XAxisEventsAfterSetExtremes.afterSetExtremes", this.AfterSetExtremes);
			}
			if (this.PointBreak != this.PointBreak_DefaultValue)
			{
				hashtables.Add("pointBreak", this.PointBreak);
				Highcharts.AddFunction("XAxisEventsPointBreak.pointBreak", this.PointBreak);
			}
			if (this.PointInBreak != this.PointInBreak_DefaultValue)
			{
				hashtables.Add("pointInBreak", this.PointInBreak);
				Highcharts.AddFunction("XAxisEventsPointInBreak.pointInBreak", this.PointInBreak);
			}
			if (this.SetExtremes != this.SetExtremes_DefaultValue)
			{
				hashtables.Add("setExtremes", this.SetExtremes);
				Highcharts.AddFunction("XAxisEventsSetExtremes.setExtremes", this.SetExtremes);
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