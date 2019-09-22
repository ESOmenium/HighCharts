using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsAreaZones : BaseObject
	{
		public string ClassName
		{
			get;
			set;
		}

		private string ClassName_DefaultValue
		{
			get;
			set;
		}

		public string Color
		{
			get;
			set;
		}

		private string Color_DefaultValue
		{
			get;
			set;
		}

		public string DashStyle
		{
			get;
			set;
		}

		private string DashStyle_DefaultValue
		{
			get;
			set;
		}

		public object FillColor
		{
			get;
			set;
		}

		private object FillColor_DefaultValue
		{
			get;
			set;
		}

		public double? Value
		{
			get;
			set;
		}

		private double? Value_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsAreaZones()
		{
			string str = "";
			string str1 = str;
			this.ClassName_DefaultValue = str;
			this.ClassName = str1;
			object obj = null;
			str1 = (string)obj;
			this.Color_DefaultValue = (string)obj;
			this.Color = str1;
			object obj1 = null;
			str1 = (string)obj1;
			this.DashStyle_DefaultValue = (string)obj1;
			this.DashStyle = str1;
			object obj2 = null;
			object obj3 = obj2;
			this.FillColor_DefaultValue = obj2;
			this.FillColor = obj3;
			double? nullable = null;
			this.Value_DefaultValue = nullable;
			this.Value = nullable;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.ClassName != this.ClassName_DefaultValue)
			{
				hashtables.Add("className", this.ClassName);
			}
			if (this.Color != this.Color_DefaultValue)
			{
				hashtables.Add("color", this.Color);
			}
			if (this.DashStyle != this.DashStyle_DefaultValue)
			{
				hashtables.Add("dashStyle", this.DashStyle);
			}
			if (this.FillColor != this.FillColor_DefaultValue)
			{
				hashtables.Add("fillColor", this.FillColor);
			}
			double? value = this.Value;
			double? valueDefaultValue = this.Value_DefaultValue;
			if ((value.GetValueOrDefault() == valueDefaultValue.GetValueOrDefault() ? value.HasValue != valueDefaultValue.HasValue : true))
			{
				hashtables.Add("value", this.Value);
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