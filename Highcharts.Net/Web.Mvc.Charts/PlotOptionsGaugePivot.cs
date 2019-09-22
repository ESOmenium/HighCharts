using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsGaugePivot : BaseObject
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

		public double? Radius
		{
			get;
			set;
		}

		private double? Radius_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsGaugePivot()
		{
			string str = "#000000";
			string str1 = str;
			this.BackgroundColor_DefaultValue = str;
			this.BackgroundColor = str1;
			string str2 = "#cccccc";
			str1 = str2;
			this.BorderColor_DefaultValue = str2;
			this.BorderColor = str1;
			double? nullable = new double?(0);
			this.BorderWidth_DefaultValue = nullable;
			this.BorderWidth = nullable;
			nullable = new double?((double)5);
			this.Radius_DefaultValue = nullable;
			this.Radius = nullable;
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
			if (this.BorderColor != this.BorderColor_DefaultValue)
			{
				hashtables.Add("borderColor", this.BorderColor);
			}
			double? borderWidth = this.BorderWidth;
			double? borderWidthDefaultValue = this.BorderWidth_DefaultValue;
			if ((borderWidth.GetValueOrDefault() == borderWidthDefaultValue.GetValueOrDefault() ? borderWidth.HasValue != borderWidthDefaultValue.HasValue : true))
			{
				hashtables.Add("borderWidth", this.BorderWidth);
			}
			borderWidthDefaultValue = this.Radius;
			borderWidth = this.Radius_DefaultValue;
			if ((borderWidthDefaultValue.GetValueOrDefault() == borderWidth.GetValueOrDefault() ? borderWidthDefaultValue.HasValue != borderWidth.HasValue : true))
			{
				hashtables.Add("radius", this.Radius);
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