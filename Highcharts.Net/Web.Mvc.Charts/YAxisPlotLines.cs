using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class YAxisPlotLines : BaseObject
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

		public YAxisPlotLinesDashStyle DashStyle
		{
			get;
			set;
		}

		private YAxisPlotLinesDashStyle DashStyle_DefaultValue
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

		public YAxisPlotLinesLabel Label
		{
			get;
			set;
		}

		private YAxisPlotLinesLabel Label_DefaultValue
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

		public double? Width
		{
			get;
			set;
		}

		private double? Width_DefaultValue
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

		public YAxisPlotLines()
		{
			string str = "";
			string str1 = str;
			this.ClassName_DefaultValue = str;
			this.ClassName = str1;
			object obj = null;
			str1 = (string)obj;
			this.Color_DefaultValue = (string)obj;
			this.Color = str1;
			int num = 0;
			YAxisPlotLinesDashStyle yAxisPlotLinesDashStyle = (YAxisPlotLinesDashStyle)num;
			this.DashStyle_DefaultValue = (YAxisPlotLinesDashStyle)num;
			this.DashStyle = yAxisPlotLinesDashStyle;
			object obj1 = null;
			object obj2 = obj1;
			this.Events_DefaultValue = obj1;
			this.Events = obj2;
			object obj3 = null;
			str1 = (string)obj3;
			this.Id_DefaultValue = (string)obj3;
			this.Id = str1;
			YAxisPlotLinesLabel yAxisPlotLinesLabel = new YAxisPlotLinesLabel();
			YAxisPlotLinesLabel yAxisPlotLinesLabel1 = yAxisPlotLinesLabel;
			this.Label_DefaultValue = yAxisPlotLinesLabel;
			this.Label = yAxisPlotLinesLabel1;
			double? nullable = null;
			this.Value_DefaultValue = nullable;
			this.Value = nullable;
			nullable = null;
			this.Width_DefaultValue = nullable;
			this.Width = nullable;
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
				YAxisPlotLinesDashStyle dashStyle = this.DashStyle;
				hashtables.Add("dashStyle", Highcharts.FirstCharacterToLower(dashStyle.ToString()));
			}
			if (this.Events != this.Events_DefaultValue)
			{
				hashtables.Add("events", this.Events);
			}
			if (this.Id != this.Id_DefaultValue)
			{
				hashtables.Add("id", this.Id);
			}
			if (this.Label.IsDirty())
			{
				hashtables.Add("label", this.Label.ToHashtable());
			}
			double? value = this.Value;
			double? valueDefaultValue = this.Value_DefaultValue;
			if ((value.GetValueOrDefault() == valueDefaultValue.GetValueOrDefault() ? value.HasValue != valueDefaultValue.HasValue : true))
			{
				hashtables.Add("value", this.Value);
			}
			valueDefaultValue = this.Width;
			value = this.Width_DefaultValue;
			if ((valueDefaultValue.GetValueOrDefault() == value.GetValueOrDefault() ? valueDefaultValue.HasValue != value.HasValue : true))
			{
				hashtables.Add("width", this.Width);
			}
			value = this.ZIndex;
			valueDefaultValue = this.ZIndex_DefaultValue;
			if ((value.GetValueOrDefault() == valueDefaultValue.GetValueOrDefault() ? value.HasValue != valueDefaultValue.HasValue : true))
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