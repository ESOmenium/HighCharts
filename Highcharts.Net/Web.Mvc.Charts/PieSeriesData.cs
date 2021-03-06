using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PieSeriesData : BaseObject
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

		public PieSeriesDataEvents Events
		{
			get;
			set;
		}

		private PieSeriesDataEvents Events_DefaultValue
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

		public double? LegendIndex
		{
			get;
			set;
		}

		private double? LegendIndex_DefaultValue
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

		public bool? Sliced
		{
			get;
			set;
		}

		private bool? Sliced_DefaultValue
		{
			get;
			set;
		}

		public double? Y
		{
			get;
			set;
		}

		private double? Y_DefaultValue
		{
			get;
			set;
		}

		public PieSeriesData()
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
			PieSeriesDataEvents pieSeriesDataEvent = new PieSeriesDataEvents();
			PieSeriesDataEvents pieSeriesDataEvent1 = pieSeriesDataEvent;
			this.Events_DefaultValue = pieSeriesDataEvent;
			this.Events = pieSeriesDataEvent1;
			object obj3 = null;
			str = (string)obj3;
			this.Id_DefaultValue = (string)obj3;
			this.Id = str;
			nullable = null;
			this.Labelrank_DefaultValue = nullable;
			this.Labelrank = nullable;
			nullable = null;
			this.LegendIndex_DefaultValue = nullable;
			this.LegendIndex = nullable;
			object obj4 = null;
			str = (string)obj4;
			this.Name_DefaultValue = (string)obj4;
			this.Name = str;
			bool? nullable1 = new bool?(false);
			this.Selected_DefaultValue = nullable1;
			this.Selected = nullable1;
			nullable1 = new bool?(false);
			this.Sliced_DefaultValue = nullable1;
			this.Sliced = nullable1;
			nullable = new double?(double.MinValue);
			this.Y_DefaultValue = nullable;
			this.Y = nullable;
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
			if (this.Id != this.Id_DefaultValue)
			{
				hashtables.Add("id", this.Id);
			}
			colorIndexDefaultValue = this.Labelrank;
			colorIndex = this.Labelrank_DefaultValue;
			if ((colorIndexDefaultValue.GetValueOrDefault() == colorIndex.GetValueOrDefault() ? colorIndexDefaultValue.HasValue != colorIndex.HasValue : true))
			{
				hashtables.Add("labelrank", this.Labelrank);
			}
			colorIndex = this.LegendIndex;
			colorIndexDefaultValue = this.LegendIndex_DefaultValue;
			if ((colorIndex.GetValueOrDefault() == colorIndexDefaultValue.GetValueOrDefault() ? colorIndex.HasValue != colorIndexDefaultValue.HasValue : true))
			{
				hashtables.Add("legendIndex", this.LegendIndex);
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
			selectedDefaultValue = this.Sliced;
			selected = this.Sliced_DefaultValue;
			if ((selectedDefaultValue.GetValueOrDefault() == selected.GetValueOrDefault() ? selectedDefaultValue.HasValue != selected.HasValue : true))
			{
				hashtables.Add("sliced", this.Sliced);
			}
			colorIndexDefaultValue = this.Y;
			colorIndex = this.Y_DefaultValue;
			if ((colorIndexDefaultValue.GetValueOrDefault() == colorIndex.GetValueOrDefault() ? colorIndexDefaultValue.HasValue != colorIndex.HasValue : true))
			{
				hashtables.Add("y", this.Y);
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