using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class SolidgaugeSeriesData : BaseObject
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

		public SolidgaugeSeriesDataEvents Events
		{
			get;
			set;
		}

		private SolidgaugeSeriesDataEvents Events_DefaultValue
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

		public SolidgaugeSeriesData()
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
			SolidgaugeSeriesDataEvents solidgaugeSeriesDataEvent = new SolidgaugeSeriesDataEvents();
			SolidgaugeSeriesDataEvents solidgaugeSeriesDataEvent1 = solidgaugeSeriesDataEvent;
			this.Events_DefaultValue = solidgaugeSeriesDataEvent;
			this.Events = solidgaugeSeriesDataEvent1;
			object obj3 = null;
			str = (string)obj3;
			this.Id_DefaultValue = (string)obj3;
			this.Id = str;
			string str3 = "";
			str = str3;
			this.InnerRadius_DefaultValue = str3;
			this.InnerRadius = str;
			nullable = null;
			this.Labelrank_DefaultValue = nullable;
			this.Labelrank = nullable;
			object obj4 = null;
			str = (string)obj4;
			this.Name_DefaultValue = (string)obj4;
			this.Name = str;
			string str4 = "";
			str = str4;
			this.Radius_DefaultValue = str4;
			this.Radius = str;
			bool? nullable1 = new bool?(false);
			this.Selected_DefaultValue = nullable1;
			this.Selected = nullable1;
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
			if (this.Events.IsDirty())
			{
				hashtables.Add("events", this.Events.ToHashtable());
			}
			if (this.Id != this.Id_DefaultValue)
			{
				hashtables.Add("id", this.Id);
			}
			if (this.InnerRadius != this.InnerRadius_DefaultValue)
			{
				hashtables.Add("innerRadius", this.InnerRadius);
			}
			colorIndexDefaultValue = this.Labelrank;
			colorIndex = this.Labelrank_DefaultValue;
			if ((colorIndexDefaultValue.GetValueOrDefault() == colorIndex.GetValueOrDefault() ? colorIndexDefaultValue.HasValue != colorIndex.HasValue : true))
			{
				hashtables.Add("labelrank", this.Labelrank);
			}
			if (this.Name != this.Name_DefaultValue)
			{
				hashtables.Add("name", this.Name);
			}
			if (this.Radius != this.Radius_DefaultValue)
			{
				hashtables.Add("radius", this.Radius);
			}
			bool? selected = this.Selected;
			bool? selectedDefaultValue = this.Selected_DefaultValue;
			if ((selected.GetValueOrDefault() == selectedDefaultValue.GetValueOrDefault() ? selected.HasValue != selectedDefaultValue.HasValue : true))
			{
				hashtables.Add("selected", this.Selected);
			}
			colorIndex = this.Y;
			colorIndexDefaultValue = this.Y_DefaultValue;
			if ((colorIndex.GetValueOrDefault() == colorIndexDefaultValue.GetValueOrDefault() ? colorIndex.HasValue != colorIndexDefaultValue.HasValue : true))
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