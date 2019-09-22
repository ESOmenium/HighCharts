using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class ResponsiveRulesCondition : BaseObject
	{
		public string Callback
		{
			get;
			set;
		}

		private string Callback_DefaultValue
		{
			get;
			set;
		}

		public double? MaxHeight
		{
			get;
			set;
		}

		private double? MaxHeight_DefaultValue
		{
			get;
			set;
		}

		public double? MaxWidth
		{
			get;
			set;
		}

		private double? MaxWidth_DefaultValue
		{
			get;
			set;
		}

		public double? MinHeight
		{
			get;
			set;
		}

		private double? MinHeight_DefaultValue
		{
			get;
			set;
		}

		public double? MinWidth
		{
			get;
			set;
		}

		private double? MinWidth_DefaultValue
		{
			get;
			set;
		}

		public ResponsiveRulesCondition()
		{
			string str = "";
			string str1 = str;
			this.Callback_DefaultValue = str;
			this.Callback = str1;
			double? nullable = null;
			this.MaxHeight_DefaultValue = nullable;
			this.MaxHeight = nullable;
			nullable = null;
			this.MaxWidth_DefaultValue = nullable;
			this.MaxWidth = nullable;
			nullable = new double?(0);
			this.MinHeight_DefaultValue = nullable;
			this.MinHeight = nullable;
			nullable = new double?(0);
			this.MinWidth_DefaultValue = nullable;
			this.MinWidth = nullable;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.Callback != this.Callback_DefaultValue)
			{
				hashtables.Add("callback", this.Callback);
				Highcharts.AddFunction("ResponsiveRulesConditionCallback.callback", this.Callback);
			}
			double? maxHeight = this.MaxHeight;
			double? maxHeightDefaultValue = this.MaxHeight_DefaultValue;
			if ((maxHeight.GetValueOrDefault() == maxHeightDefaultValue.GetValueOrDefault() ? maxHeight.HasValue != maxHeightDefaultValue.HasValue : true))
			{
				hashtables.Add("maxHeight", this.MaxHeight);
			}
			maxHeightDefaultValue = this.MaxWidth;
			maxHeight = this.MaxWidth_DefaultValue;
			if ((maxHeightDefaultValue.GetValueOrDefault() == maxHeight.GetValueOrDefault() ? maxHeightDefaultValue.HasValue != maxHeight.HasValue : true))
			{
				hashtables.Add("maxWidth", this.MaxWidth);
			}
			maxHeight = this.MinHeight;
			maxHeightDefaultValue = this.MinHeight_DefaultValue;
			if ((maxHeight.GetValueOrDefault() == maxHeightDefaultValue.GetValueOrDefault() ? maxHeight.HasValue != maxHeightDefaultValue.HasValue : true))
			{
				hashtables.Add("minHeight", this.MinHeight);
			}
			maxHeightDefaultValue = this.MinWidth;
			maxHeight = this.MinWidth_DefaultValue;
			if ((maxHeightDefaultValue.GetValueOrDefault() == maxHeight.GetValueOrDefault() ? maxHeightDefaultValue.HasValue != maxHeight.HasValue : true))
			{
				hashtables.Add("minWidth", this.MinWidth);
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