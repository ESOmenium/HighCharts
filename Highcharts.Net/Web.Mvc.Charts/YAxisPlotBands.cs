using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class YAxisPlotBands : BaseObject
	{
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

		public object Events
		{
			get;
			set;
		}

		private object Events_DefaultValue
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

		public string Id
		{
			get;
			set;
		}

		private string Id_DefaultValue
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

		public YAxisPlotBandsLabel Label
		{
			get;
			set;
		}

		private YAxisPlotBandsLabel Label_DefaultValue
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

		public string Thickness
		{
			get;
			set;
		}

		private string Thickness_DefaultValue
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

		public double? ZIndex
		{
			get;
			set;
		}

		private double? ZIndex_DefaultValue
		{
			get;
			set;
		}

		public YAxisPlotBands()
		{
			string str = "null";
			string str1 = str;
			this.BorderColor_DefaultValue = str;
			this.BorderColor = str1;
			double? nullable = new double?(0);
			this.BorderWidth_DefaultValue = nullable;
			this.BorderWidth = nullable;
			string str2 = "";
			str1 = str2;
			this.ClassName_DefaultValue = str2;
			this.ClassName = str1;
			object obj = null;
			str1 = (string)obj;
			this.Color_DefaultValue = (string)obj;
			this.Color = str1;
			object obj1 = null;
			object obj2 = obj1;
			this.Events_DefaultValue = obj1;
			this.Events = obj2;
			nullable = null;
			this.From_DefaultValue = nullable;
			this.From = nullable;
			object obj3 = null;
			str1 = (string)obj3;
			this.Id_DefaultValue = (string)obj3;
			this.Id = str1;
			string str3 = "null";
			str1 = str3;
			this.InnerRadius_DefaultValue = str3;
			this.InnerRadius = str1;
			YAxisPlotBandsLabel yAxisPlotBandsLabel = new YAxisPlotBandsLabel();
			YAxisPlotBandsLabel yAxisPlotBandsLabel1 = yAxisPlotBandsLabel;
			this.Label_DefaultValue = yAxisPlotBandsLabel;
			this.Label = yAxisPlotBandsLabel1;
			string str4 = "100%";
			str1 = str4;
			this.OuterRadius_DefaultValue = str4;
			this.OuterRadius = str1;
			string str5 = "10";
			str1 = str5;
			this.Thickness_DefaultValue = str5;
			this.Thickness = str1;
			nullable = null;
			this.To_DefaultValue = nullable;
			this.To = nullable;
			nullable = null;
			this.ZIndex_DefaultValue = nullable;
			this.ZIndex = nullable;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
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
			if (this.Color != this.Color_DefaultValue)
			{
				hashtables.Add("color", this.Color);
			}
			if (this.Events != this.Events_DefaultValue)
			{
				hashtables.Add("events", this.Events);
			}
			borderWidthDefaultValue = this.From;
			borderWidth = this.From_DefaultValue;
			if ((borderWidthDefaultValue.GetValueOrDefault() == borderWidth.GetValueOrDefault() ? borderWidthDefaultValue.HasValue != borderWidth.HasValue : true))
			{
				hashtables.Add("from", this.From);
			}
			if (this.Id != this.Id_DefaultValue)
			{
				hashtables.Add("id", this.Id);
			}
			if (this.InnerRadius != this.InnerRadius_DefaultValue)
			{
				hashtables.Add("innerRadius", this.InnerRadius);
			}
			if (this.Label.IsDirty())
			{
				hashtables.Add("label", this.Label.ToHashtable());
			}
			if (this.OuterRadius != this.OuterRadius_DefaultValue)
			{
				hashtables.Add("outerRadius", this.OuterRadius);
			}
			if (this.Thickness != this.Thickness_DefaultValue)
			{
				hashtables.Add("thickness", this.Thickness);
			}
			borderWidth = this.To;
			borderWidthDefaultValue = this.To_DefaultValue;
			if ((borderWidth.GetValueOrDefault() == borderWidthDefaultValue.GetValueOrDefault() ? borderWidth.HasValue != borderWidthDefaultValue.HasValue : true))
			{
				hashtables.Add("to", this.To);
			}
			borderWidthDefaultValue = this.ZIndex;
			borderWidth = this.ZIndex_DefaultValue;
			if ((borderWidthDefaultValue.GetValueOrDefault() == borderWidth.GetValueOrDefault() ? borderWidthDefaultValue.HasValue != borderWidth.HasValue : true))
			{
				hashtables.Add("zIndex", this.ZIndex);
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