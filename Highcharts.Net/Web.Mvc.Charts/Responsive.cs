using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class Responsive : BaseObject
	{
		public ResponsiveRules Rules
		{
			get;
			set;
		}

		private ResponsiveRules Rules_DefaultValue
		{
			get;
			set;
		}

		public Responsive()
		{
			ResponsiveRules responsiveRule = new ResponsiveRules();
			ResponsiveRules responsiveRule1 = responsiveRule;
			this.Rules_DefaultValue = responsiveRule;
			this.Rules = responsiveRule1;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.Rules.IsDirty())
			{
				hashtables.Add("rules", this.Rules.ToHashtable());
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