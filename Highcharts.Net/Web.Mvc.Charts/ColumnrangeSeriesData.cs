using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class ColumnrangeSeriesData : BaseObject
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

		public double? ColorIndex
		{
			get;
			set;
		}

		private double? ColorIndex_DefaultValue
		{
			get;
			set;
		}

		public object DataLabels
		{
			get;
			set;
		}

		private object DataLabels_DefaultValue
		{
			get;
			set;
		}

		public string Description
		{
			get;
			set;
		}

		private string Description_DefaultValue
		{
			get;
			set;
		}

		public string Drilldown
		{
			get;
			set;
		}

		private string Drilldown_DefaultValue
		{
			get;
			set;
		}

		public ColumnrangeSeriesDataEvents Events
		{
			get;
			set;
		}

		private ColumnrangeSeriesDataEvents Events_DefaultValue
		{
			get;
			set;
		}

		public double? High
		{
			get;
			set;
		}

		private double? High_DefaultValue
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

		public double? Labelrank
		{
			get;
			set;
		}

		private double? Labelrank_DefaultValue
		{
			get;
			set;
		}

		public double? Low
		{
			get;
			set;
		}

		private double? Low_DefaultValue
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

		private string Name_DefaultValue
		{
			get;
			set;
		}

		public bool? Selected
		{
			get;
			set;
		}

		private bool? Selected_DefaultValue
		{
			get;
			set;
		}

		public double? X
		{
			get;
			set;
		}

		private double? X_DefaultValue
		{
			get;
			set;
		}

		public ColumnrangeSeriesData()
		{
			object obj = null;
			string str = (string)obj;
			this.ClassName_DefaultValue = (string)obj;
			this.ClassName = str;
			string str1 = "undefined";
			str = str1;
			this.Color_DefaultValue = str1;
			this.Color = str;
			double? nullable = null;
			this.ColorIndex_DefaultValue = nullable;
			this.ColorIndex = nullable;
			object obj1 = null;
			object obj2 = obj1;
			this.DataLabels_DefaultValue = obj1;
			this.DataLabels = obj2;
			string str2 = "undefined";
			str = str2;
			this.Description_DefaultValue = str2;
			this.Description = str;
			string str3 = "";
			str = str3;
			this.Drilldown_DefaultValue = str3;
			this.Drilldown = str;
			ColumnrangeSeriesDataEvents columnrangeSeriesDataEvent = new ColumnrangeSeriesDataEvents();
			ColumnrangeSeriesDataEvents columnrangeSeriesDataEvent1 = columnrangeSeriesDataEvent;
			this.Events_DefaultValue = columnrangeSeriesDataEvent;
			this.Events = columnrangeSeriesDataEvent1;
			nullable = null;
			this.High_DefaultValue = nullable;
			this.High = nullable;
			object obj3 = null;
			str = (string)obj3;
			this.Id_DefaultValue = (string)obj3;
			this.Id = str;
			nullable = null;
			this.Labelrank_DefaultValue = nullable;
			this.Labelrank = nullable;
			nullable = null;
			this.Low_DefaultValue = nullable;
			this.Low = nullable;
			object obj4 = null;
			str = (string)obj4;
			this.Name_DefaultValue = (string)obj4;
			this.Name = str;
			bool? nullable1 = new bool?(false);
			this.Selected_DefaultValue = nullable1;
			this.Selected = nullable1;
			nullable = new double?(double.MinValue);
			this.X_DefaultValue = nullable;
			this.X = nullable;
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
			double? colorIndex = this.ColorIndex;
			double? colorIndexDefaultValue = this.ColorIndex_DefaultValue;
			if ((colorIndex.GetValueOrDefault() == colorIndexDefaultValue.GetValueOrDefault() ? colorIndex.HasValue != colorIndexDefaultValue.HasValue : true))
			{
				hashtables.Add("colorIndex", this.ColorIndex);
			}
			if (this.DataLabels != this.DataLabels_DefaultValue)
			{
				hashtables.Add("dataLabels", this.DataLabels);
			}
			if (this.Description != this.Description_DefaultValue)
			{
				hashtables.Add("description", this.Description);
			}
			if (this.Drilldown != this.Drilldown_DefaultValue)
			{
				hashtables.Add("drilldown", this.Drilldown);
			}
			if (this.Events.IsDirty())
			{
				hashtables.Add("events", this.Events.ToHashtable());
			}
			colorIndexDefaultValue = this.High;
			colorIndex = this.High_DefaultValue;
			if ((colorIndexDefaultValue.GetValueOrDefault() == colorIndex.GetValueOrDefault() ? colorIndexDefaultValue.HasValue != colorIndex.HasValue : true))
			{
				hashtables.Add("high", this.High);
			}
			if (this.Id != this.Id_DefaultValue)
			{
				hashtables.Add("id", this.Id);
			}
			colorIndex = this.Labelrank;
			colorIndexDefaultValue = this.Labelrank_DefaultValue;
			if ((colorIndex.GetValueOrDefault() == colorIndexDefaultValue.GetValueOrDefault() ? colorIndex.HasValue != colorIndexDefaultValue.HasValue : true))
			{
				hashtables.Add("labelrank", this.Labelrank);
			}
			colorIndexDefaultValue = this.Low;
			colorIndex = this.Low_DefaultValue;
			if ((colorIndexDefaultValue.GetValueOrDefault() == colorIndex.GetValueOrDefault() ? colorIndexDefaultValue.HasValue != colorIndex.HasValue : true))
			{
				hashtables.Add("low", this.Low);
			}
			if (this.Name != this.Name_DefaultValue)
			{
				hashtables.Add("name", this.Name);
			}
			bool? selected = this.Selected;
			bool? selectedDefaultValue = this.Selected_DefaultValue;
			if ((selected.GetValueOrDefault() == selectedDefaultValue.GetValueOrDefault() ? selected.HasValue != selectedDefaultValue.HasValue : true))
			{
				hashtables.Add("selected", this.Selected);
			}
			colorIndex = this.X;
			colorIndexDefaultValue = this.X_DefaultValue;
			if ((colorIndex.GetValueOrDefault() == colorIndexDefaultValue.GetValueOrDefault() ? colorIndex.HasValue != colorIndexDefaultValue.HasValue : true))
			{
				hashtables.Add("x", this.X);
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