using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class Credits : BaseObject
	{
		public bool? Enabled
		{
			get;
			set;
		}

		private bool? Enabled_DefaultValue
		{
			get;
			set;
		}

		public string Href
		{
			get;
			set;
		}

		private string Href_DefaultValue
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

		public Credits()
		{
			bool? nullable = new bool?(true);
			this.Enabled_DefaultValue = nullable;
			this.Enabled = nullable;
			string str = "http://www.highcharts.com";
			string str1 = str;
			this.Href_DefaultValue = str;
			this.Href = str1;
			Hashtable hashtables = new Hashtable();
			Hashtable hashtables1 = hashtables;
			this.Position_DefaultValue = hashtables;
			this.Position = hashtables1;
			Hashtable hashtables2 = new Hashtable()
			{
				{ "cursor", "pointer" },
				{ "color", "#999999" },
				{ "fontSize", "10px" }
			};
			Hashtable hashtables3 = hashtables2;
			hashtables1 = hashtables3;
			this.Style_DefaultValue = hashtables3;
			this.Style = hashtables1;
			string str2 = "Highcharts.com";
			str1 = str2;
			this.Text_DefaultValue = str2;
			this.Text = str1;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			bool? enabled = this.Enabled;
			bool? enabledDefaultValue = this.Enabled_DefaultValue;
			if ((enabled.GetValueOrDefault() == enabledDefaultValue.GetValueOrDefault() ? enabled.HasValue != enabledDefaultValue.HasValue : true))
			{
				hashtables.Add("enabled", this.Enabled);
			}
			if (this.Href != this.Href_DefaultValue)
			{
				hashtables.Add("href", this.Href);
			}
			if (this.Position.Count > 0)
			{
				hashtables.Add("position", this.Position);
			}
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