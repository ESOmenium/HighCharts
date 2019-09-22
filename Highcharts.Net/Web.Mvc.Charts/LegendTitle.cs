using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class LegendTitle : BaseObject
	{
		public Hashtable Style
		{
			get;
			set;
		}

		private Hashtable Style_DefaultValue
		{
			get;
			set;
		}

		public string Text
		{
			get;
			set;
		}

		private string Text_DefaultValue
		{
			get;
			set;
		}

		public LegendTitle()
		{
			Hashtable hashtables = new Hashtable()
			{
				{ "fontWeight", "bold" }
			};
			Hashtable hashtables1 = hashtables;
			this.Style_DefaultValue = hashtables;
			this.Style = hashtables1;
			string str = "null";
			string str1 = str;
			this.Text_DefaultValue = str;
			this.Text = str1;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.Style != this.Style_DefaultValue)
			{
				hashtables.Add("style", this.Style);
			}
			if (this.Text != this.Text_DefaultValue)
			{
				hashtables.Add("text", this.Text);
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