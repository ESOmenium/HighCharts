using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class DrilldownDrillUpButton : BaseObject
	{
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

		public string RelativeTo
		{
			get;
			set;
		}

		private string RelativeTo_DefaultValue
		{
			get;
			set;
		}

		public object Theme
		{
			get;
			set;
		}

		private object Theme_DefaultValue
		{
			get;
			set;
		}

		public DrilldownDrillUpButton()
		{
			Hashtable hashtables = new Hashtable();
			Hashtable hashtables1 = hashtables;
			this.Position_DefaultValue = hashtables;
			this.Position = hashtables1;
			string str = "plotBox";
			string str1 = str;
			this.RelativeTo_DefaultValue = str;
			this.RelativeTo = str1;
			object obj = null;
			object obj1 = obj;
			this.Theme_DefaultValue = obj;
			this.Theme = obj1;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.Position != this.Position_DefaultValue)
			{
				hashtables.Add("position", this.Position);
			}
			if (this.RelativeTo != this.RelativeTo_DefaultValue)
			{
				hashtables.Add("relativeTo", this.RelativeTo);
			}
			if (this.Theme != this.Theme_DefaultValue)
			{
				hashtables.Add("theme", this.Theme);
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