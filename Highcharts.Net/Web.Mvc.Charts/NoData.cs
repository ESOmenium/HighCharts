using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class NoData : BaseObject
	{
		public Hashtable Attr
		{
			get;
			set;
		}

		private Hashtable Attr_DefaultValue
		{
			get;
			set;
		}

		public Hashtable Position
		{
			get;
			set;
		}

		private Hashtable Position_DefaultValue
		{
			get;
			set;
		}

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

		public bool? UseHTML
		{
			get;
			set;
		}

		private bool? UseHTML_DefaultValue
		{
			get;
			set;
		}

		public NoData()
		{
			object obj = null;
			Hashtable hashtables = (Hashtable)obj;
			this.Attr_DefaultValue = (Hashtable)obj;
			this.Attr = hashtables;
			Hashtable hashtables1 = new Hashtable();
			hashtables = hashtables1;
			this.Position_DefaultValue = hashtables1;
			this.Position = hashtables;
			Hashtable hashtables2 = new Hashtable()
			{
				{ "fontSize", "12px" },
				{ "fontWeight", "bold" },
				{ "color", "#666666" }
			};
			Hashtable hashtables3 = hashtables2;
			hashtables = hashtables3;
			this.Style_DefaultValue = hashtables3;
			this.Style = hashtables;
			bool? nullable = new bool?(false);
			this.UseHTML_DefaultValue = nullable;
			this.UseHTML = nullable;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.Attr != this.Attr_DefaultValue)
			{
				hashtables.Add("attr", this.Attr);
			}
			if (this.Position.Count > 0)
			{
				hashtables.Add("position", this.Position);
			}
			if (this.Style != this.Style_DefaultValue)
			{
				hashtables.Add("style", this.Style);
			}
			bool? useHTML = this.UseHTML;
			bool? useHTMLDefaultValue = this.UseHTML_DefaultValue;
			if ((useHTML.GetValueOrDefault() == useHTMLDefaultValue.GetValueOrDefault() ? useHTML.HasValue != useHTMLDefaultValue.HasValue : true))
			{
				hashtables.Add("useHTML", this.UseHTML);
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