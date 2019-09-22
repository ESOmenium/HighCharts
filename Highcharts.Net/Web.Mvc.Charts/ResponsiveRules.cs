using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class ResponsiveRules : BaseObject
	{
		public object ChartOptions
		{
			get;
			set;
		}

		private object ChartOptions_DefaultValue
		{
			get;
			set;
		}

		public ResponsiveRulesCondition Condition
		{
			get;
			set;
		}

		private ResponsiveRulesCondition Condition_DefaultValue
		{
			get;
			set;
		}

		public ResponsiveRules()
		{
			object obj = null;
			object obj1 = obj;
			this.ChartOptions_DefaultValue = obj;
			this.ChartOptions = obj1;
			ResponsiveRulesCondition responsiveRulesCondition = new ResponsiveRulesCondition();
			ResponsiveRulesCondition responsiveRulesCondition1 = responsiveRulesCondition;
			this.Condition_DefaultValue = responsiveRulesCondition;
			this.Condition = responsiveRulesCondition1;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.ChartOptions != this.ChartOptions_DefaultValue)
			{
				hashtables.Add("chartOptions", this.ChartOptions);
			}
			if (this.Condition.IsDirty())
			{
				hashtables.Add("condition", this.Condition.ToHashtable());
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