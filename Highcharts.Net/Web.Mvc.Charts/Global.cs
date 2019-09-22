using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class Global : BaseObject
	{
		public string GetTimezoneOffset
		{
			get;
			set;
		}

		private string GetTimezoneOffset_DefaultValue
		{
			get;
			set;
		}

		public string Timezone
		{
			get;
			set;
		}

		private string Timezone_DefaultValue
		{
			get;
			set;
		}

		public double? TimezoneOffset
		{
			get;
			set;
		}

		private double? TimezoneOffset_DefaultValue
		{
			get;
			set;
		}

		public bool? UseUTC
		{
			get;
			set;
		}

		private bool? UseUTC_DefaultValue
		{
			get;
			set;
		}

		public string VMLRadialGradientURL
		{
			get;
			set;
		}

		private string VMLRadialGradientURL_DefaultValue
		{
			get;
			set;
		}

		public Global()
		{
			string str = "http://code.highcharts.com/{version}/gfx/vml-radial-gradient.png";
			string str1 = str;
			this.VMLRadialGradientURL_DefaultValue = str;
			this.VMLRadialGradientURL = str1;
			string str2 = "";
			str1 = str2;
			this.GetTimezoneOffset_DefaultValue = str2;
			this.GetTimezoneOffset = str1;
			string str3 = "undefined";
			str1 = str3;
			this.Timezone_DefaultValue = str3;
			this.Timezone = str1;
			double? nullable = new double?(0);
			this.TimezoneOffset_DefaultValue = nullable;
			this.TimezoneOffset = nullable;
			bool? nullable1 = new bool?(true);
			this.UseUTC_DefaultValue = nullable1;
			this.UseUTC = nullable1;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.VMLRadialGradientURL != this.VMLRadialGradientURL_DefaultValue)
			{
				hashtables.Add("vMLRadialGradientURL", this.VMLRadialGradientURL);
			}
			if (this.GetTimezoneOffset != this.GetTimezoneOffset_DefaultValue)
			{
				hashtables.Add("getTimezoneOffset", this.GetTimezoneOffset);
				Highcharts.AddFunction("GlobalGetTimezoneOffset.getTimezoneOffset", this.GetTimezoneOffset);
			}
			if (this.Timezone != this.Timezone_DefaultValue)
			{
				hashtables.Add("timezone", this.Timezone);
			}
			double? timezoneOffset = this.TimezoneOffset;
			double? timezoneOffsetDefaultValue = this.TimezoneOffset_DefaultValue;
			if ((timezoneOffset.GetValueOrDefault() == timezoneOffsetDefaultValue.GetValueOrDefault() ? timezoneOffset.HasValue != timezoneOffsetDefaultValue.HasValue : true))
			{
				hashtables.Add("timezoneOffset", this.TimezoneOffset);
			}
			bool? useUTC = this.UseUTC;
			bool? useUTCDefaultValue = this.UseUTC_DefaultValue;
			if ((useUTC.GetValueOrDefault() == useUTCDefaultValue.GetValueOrDefault() ? useUTC.HasValue != useUTCDefaultValue.HasValue : true))
			{
				hashtables.Add("useUTC", this.UseUTC);
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