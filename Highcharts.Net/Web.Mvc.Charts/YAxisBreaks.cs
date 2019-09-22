using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class YAxisBreaks : BaseObject
	{
		public double? BreakSize
		{
			get;
			set;
		}

		private double? BreakSize_DefaultValue
		{
			get;
			set;
		}

		public double? From
		{
			get;
			set;
		}

		private double? From_DefaultValue
		{
			get;
			set;
		}

		public double? Repeat
		{
			get;
			set;
		}

		private double? Repeat_DefaultValue
		{
			get;
			set;
		}

		public double? To
		{
			get;
			set;
		}

		private double? To_DefaultValue
		{
			get;
			set;
		}

		public YAxisBreaks()
		{
			double? nullable = new double?(0);
			this.BreakSize_DefaultValue = nullable;
			this.BreakSize = nullable;
			nullable = null;
			this.From_DefaultValue = nullable;
			this.From = nullable;
			nullable = new double?(0);
			this.Repeat_DefaultValue = nullable;
			this.Repeat = nullable;
			nullable = null;
			this.To_DefaultValue = nullable;
			this.To = nullable;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			double? breakSize = this.BreakSize;
			double? breakSizeDefaultValue = this.BreakSize_DefaultValue;
			if ((breakSize.GetValueOrDefault() == breakSizeDefaultValue.GetValueOrDefault() ? breakSize.HasValue != breakSizeDefaultValue.HasValue : true))
			{
				hashtables.Add("breakSize", this.BreakSize);
			}
			breakSizeDefaultValue = this.From;
			breakSize = this.From_DefaultValue;
			if ((breakSizeDefaultValue.GetValueOrDefault() == breakSize.GetValueOrDefault() ? breakSizeDefaultValue.HasValue != breakSize.HasValue : true))
			{
				hashtables.Add("from", this.From);
			}
			breakSize = this.Repeat;
			breakSizeDefaultValue = this.Repeat_DefaultValue;
			if ((breakSize.GetValueOrDefault() == breakSizeDefaultValue.GetValueOrDefault() ? breakSize.HasValue != breakSizeDefaultValue.HasValue : true))
			{
				hashtables.Add("repeat", this.Repeat);
			}
			breakSizeDefaultValue = this.To;
			breakSize = this.To_DefaultValue;
			if ((breakSizeDefaultValue.GetValueOrDefault() == breakSize.GetValueOrDefault() ? breakSizeDefaultValue.HasValue != breakSize.HasValue : true))
			{
				hashtables.Add("to", this.To);
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