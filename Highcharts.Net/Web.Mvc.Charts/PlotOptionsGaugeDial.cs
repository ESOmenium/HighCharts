using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsGaugeDial : BaseObject
	{
		public string BackgroundColor
		{
			get;
			set;
		}

		private string BackgroundColor_DefaultValue
		{
			get;
			set;
		}

		public string BaseLength
		{
			get;
			set;
		}

		private string BaseLength_DefaultValue
		{
			get;
			set;
		}

		public double? BaseWidth
		{
			get;
			set;
		}

		private double? BaseWidth_DefaultValue
		{
			get;
			set;
		}

		public string BorderColor
		{
			get;
			set;
		}

		private string BorderColor_DefaultValue
		{
			get;
			set;
		}

		public double? BorderWidth
		{
			get;
			set;
		}

		private double? BorderWidth_DefaultValue
		{
			get;
			set;
		}

		public string Radius
		{
			get;
			set;
		}

		private string Radius_DefaultValue
		{
			get;
			set;
		}

		public string RearLength
		{
			get;
			set;
		}

		private string RearLength_DefaultValue
		{
			get;
			set;
		}

		public double? TopWidth
		{
			get;
			set;
		}

		private double? TopWidth_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsGaugeDial()
		{
			string str = "#000000";
			string str1 = str;
			this.BackgroundColor_DefaultValue = str;
			this.BackgroundColor = str1;
			string str2 = "70%";
			str1 = str2;
			this.BaseLength_DefaultValue = str2;
			this.BaseLength = str1;
			double? nullable = new double?((double)3);
			this.BaseWidth_DefaultValue = nullable;
			this.BaseWidth = nullable;
			string str3 = "#cccccc";
			str1 = str3;
			this.BorderColor_DefaultValue = str3;
			this.BorderColor = str1;
			nullable = new double?(0);
			this.BorderWidth_DefaultValue = nullable;
			this.BorderWidth = nullable;
			string str4 = "80%";
			str1 = str4;
			this.Radius_DefaultValue = str4;
			this.Radius = str1;
			string str5 = "10%";
			str1 = str5;
			this.RearLength_DefaultValue = str5;
			this.RearLength = str1;
			nullable = new double?((double)1);
			this.TopWidth_DefaultValue = nullable;
			this.TopWidth = nullable;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.BackgroundColor != this.BackgroundColor_DefaultValue)
			{
				hashtables.Add("backgroundColor", this.BackgroundColor);
			}
			if (this.BaseLength != this.BaseLength_DefaultValue)
			{
				hashtables.Add("baseLength", this.BaseLength);
			}
			double? baseWidth = this.BaseWidth;
			double? baseWidthDefaultValue = this.BaseWidth_DefaultValue;
			if ((baseWidth.GetValueOrDefault() == baseWidthDefaultValue.GetValueOrDefault() ? baseWidth.HasValue != baseWidthDefaultValue.HasValue : true))
			{
				hashtables.Add("baseWidth", this.BaseWidth);
			}
			if (this.BorderColor != this.BorderColor_DefaultValue)
			{
				hashtables.Add("borderColor", this.BorderColor);
			}
			baseWidthDefaultValue = this.BorderWidth;
			baseWidth = this.BorderWidth_DefaultValue;
			if ((baseWidthDefaultValue.GetValueOrDefault() == baseWidth.GetValueOrDefault() ? baseWidthDefaultValue.HasValue != baseWidth.HasValue : true))
			{
				hashtables.Add("borderWidth", this.BorderWidth);
			}
			if (this.Radius != this.Radius_DefaultValue)
			{
				hashtables.Add("radius", this.Radius);
			}
			if (this.RearLength != this.RearLength_DefaultValue)
			{
				hashtables.Add("rearLength", this.RearLength);
			}
			baseWidth = this.TopWidth;
			baseWidthDefaultValue = this.TopWidth_DefaultValue;
			if ((baseWidth.GetValueOrDefault() == baseWidthDefaultValue.GetValueOrDefault() ? baseWidth.HasValue != baseWidthDefaultValue.HasValue : true))
			{
				hashtables.Add("topWidth", this.TopWidth);
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