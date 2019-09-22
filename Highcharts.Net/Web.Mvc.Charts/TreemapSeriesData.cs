using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class TreemapSeriesData : BaseObject
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

		public double? ColorValue
		{
			get;
			set;
		}

		private double? ColorValue_DefaultValue
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

		public TreemapSeriesDataEvents Events
		{
			get;
			set;
		}

		private TreemapSeriesDataEvents Events_DefaultValue
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

		public string Parent
		{
			get;
			set;
		}

		private string Parent_DefaultValue
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

		public TreemapSeriesData()
		{
			object obj = null;
			string str = (string)obj;
			this.ClassName_DefaultValue = (string)obj;
			this.ClassName = str;
			object obj1 = null;
			str = (string)obj1;
			this.Color_DefaultValue = (string)obj1;
			this.Color = str;
			double? nullable = null;
			this.ColorIndex_DefaultValue = nullable;
			this.ColorIndex = nullable;
			nullable = null;
			this.ColorValue_DefaultValue = nullable;
			this.ColorValue = nullable;
			object obj2 = null;
			object obj3 = obj2;
			this.DataLabels_DefaultValue = obj2;
			this.DataLabels = obj3;
			string str1 = "undefined";
			str = str1;
			this.Description_DefaultValue = str1;
			this.Description = str;
			string str2 = "";
			str = str2;
			this.Drilldown_DefaultValue = str2;
			this.Drilldown = str;
			TreemapSeriesDataEvents treemapSeriesDataEvent = new TreemapSeriesDataEvents();
			TreemapSeriesDataEvents treemapSeriesDataEvent1 = treemapSeriesDataEvent;
			this.Events_DefaultValue = treemapSeriesDataEvent;
			this.Events = treemapSeriesDataEvent1;
			object obj4 = null;
			str = (string)obj4;
			this.Id_DefaultValue = (string)obj4;
			this.Id = str;
			nullable = null;
			this.Labelrank_DefaultValue = nullable;
			this.Labelrank = nullable;
			object obj5 = null;
			str = (string)obj5;
			this.Name_DefaultValue = (string)obj5;
			this.Name = str;
			string str3 = "undefined";
			str = str3;
			this.Parent_DefaultValue = str3;
			this.Parent = str;
			bool? nullable1 = new bool?(false);
			this.Selected_DefaultValue = nullable1;
			this.Selected = nullable1;
			nullable = null;
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
			double? colorIndex = this.ColorIndex;
			double? colorIndexDefaultValue = this.ColorIndex_DefaultValue;
			if ((colorIndex.GetValueOrDefault() == colorIndexDefaultValue.GetValueOrDefault() ? colorIndex.HasValue != colorIndexDefaultValue.HasValue : true))
			{
				hashtables.Add("colorIndex", this.ColorIndex);
			}
			colorIndexDefaultValue = this.ColorValue;
			colorIndex = this.ColorValue_DefaultValue;
			if ((colorIndexDefaultValue.GetValueOrDefault() == colorIndex.GetValueOrDefault() ? colorIndexDefaultValue.HasValue != colorIndex.HasValue : true))
			{
				hashtables.Add("colorValue", this.ColorValue);
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
			colorIndex = this.Labelrank;
			colorIndexDefaultValue = this.Labelrank_DefaultValue;
			if ((colorIndex.GetValueOrDefault() == colorIndexDefaultValue.GetValueOrDefault() ? colorIndex.HasValue != colorIndexDefaultValue.HasValue : true))
			{
				hashtables.Add("labelrank", this.Labelrank);
			}
			if (this.Name != this.Name_DefaultValue)
			{
				hashtables.Add("name", this.Name);
			}
			if (this.Parent != this.Parent_DefaultValue)
			{
				hashtables.Add("parent", this.Parent);
			}
			bool? selected = this.Selected;
			bool? selectedDefaultValue = this.Selected_DefaultValue;
			if ((selected.GetValueOrDefault() == selectedDefaultValue.GetValueOrDefault() ? selected.HasValue != selectedDefaultValue.HasValue : true))
			{
				hashtables.Add("selected", this.Selected);
			}
			colorIndexDefaultValue = this.Value;
			colorIndex = this.Value_DefaultValue;
			if ((colorIndexDefaultValue.GetValueOrDefault() == colorIndex.GetValueOrDefault() ? colorIndexDefaultValue.HasValue != colorIndex.HasValue : true))
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