using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PaneBackground : BaseObject
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

		public string InnerRadius
		{
			get;
			set;
		}

		private string InnerRadius_DefaultValue
		{
			get;
			set;
		}

		public string OuterRadius
		{
			get;
			set;
		}

		private string OuterRadius_DefaultValue
		{
			get;
			set;
		}

		public PaneBackgroundShape Shape
		{
			get;
			set;
		}

		private PaneBackgroundShape Shape_DefaultValue
		{
			get;
			set;
		}

		public PaneBackground()
		{
			string str = "";
			string str1 = str;
			this.BackgroundColor_DefaultValue = str;
			this.BackgroundColor = str1;
			string str2 = "#cccccc";
			str1 = str2;
			this.BorderColor_DefaultValue = str2;
			this.BorderColor = str1;
			double? nullable = new double?((double)1);
			this.BorderWidth_DefaultValue = nullable;
			this.BorderWidth = nullable;
			string str3 = "highcharts-pane";
			str1 = str3;
			this.ClassName_DefaultValue = str3;
			this.ClassName = str1;
			string str4 = "0";
			str1 = str4;
			this.InnerRadius_DefaultValue = str4;
			this.InnerRadius = str1;
			string str5 = "105%";
			str1 = str5;
			this.OuterRadius_DefaultValue = str5;
			this.OuterRadius = str1;
			int num = 0;
			PaneBackgroundShape paneBackgroundShape = (PaneBackgroundShape)num;
			this.Shape_DefaultValue = (PaneBackgroundShape)num;
			this.Shape = paneBackgroundShape;
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
			if (this.ClassName != this.ClassName_DefaultValue)
			{
				hashtables.Add("className", this.ClassName);
			}
			if (this.InnerRadius != this.InnerRadius_DefaultValue)
			{
				hashtables.Add("innerRadius", this.InnerRadius);
			}
			if (this.OuterRadius != this.OuterRadius_DefaultValue)
			{
				hashtables.Add("outerRadius", this.OuterRadius);
			}
			if (this.Shape != this.Shape_DefaultValue)
			{
				PaneBackgroundShape shape = this.Shape;
				hashtables.Add("shape", Highcharts.FirstCharacterToLower(shape.ToString()));
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