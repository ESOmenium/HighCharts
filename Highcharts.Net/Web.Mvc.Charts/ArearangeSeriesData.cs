using System.Collections;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class ArearangeSeriesData : BaseObject
	{
		public string ClassName { get; set; }

		private string ClassName_DefaultValue { get; }

		public string Color { get; set; }

		private string Color_DefaultValue { get; }

		public double? ColorIndex { get; set; }

		private double? ColorIndex_DefaultValue { get; }

		public object DataLabels { get; set; }

		private object DataLabels_DefaultValue { get; }

		public string Description { get; set; }

		private string Description_DefaultValue { get; }

		public string Drilldown { get; set; }

		private string Drilldown_DefaultValue { get; }

		public ArearangeSeriesDataEvents Events { get; set; }

		private ArearangeSeriesDataEvents Events_DefaultValue { get; set; }

		public double? High { get; set; }

		private double? High_DefaultValue { get; }

		public string Id { get; set; }

		private string Id_DefaultValue { get; }

		public double? Labelrank { get; set; }

		private double? Labelrank_DefaultValue { get; }

		public double? Low { get; set; }

		private double? Low_DefaultValue { get; }

		public string Name { get; set; }

		private string Name_DefaultValue { get; }

		public bool? Selected { get; set; }

		private bool? Selected_DefaultValue { get; }

		public double? X { get; set; }

		private double? X_DefaultValue { get; }

		public ArearangeSeriesData()
		{
			object obj = null;
			string str = (string) obj;
			ClassName_DefaultValue = (string) obj;
			ClassName = str;
			string str1 = "undefined";
			str = str1;
			Color_DefaultValue = str1;
			Color = str;
			double? nullable = null;
			ColorIndex_DefaultValue = nullable;
			ColorIndex = nullable;
			object obj1 = null;
			object obj2 = obj1;
			DataLabels_DefaultValue = obj1;
			DataLabels = obj2;
			string str2 = "undefined";
			str = str2;
			Description_DefaultValue = str2;
			Description = str;
			string str3 = "";
			str = str3;
			Drilldown_DefaultValue = str3;
			Drilldown = str;
			ArearangeSeriesDataEvents arearangeSeriesDataEvent = new ArearangeSeriesDataEvents();
			ArearangeSeriesDataEvents arearangeSeriesDataEvent1 = arearangeSeriesDataEvent;
			Events_DefaultValue = arearangeSeriesDataEvent;
			Events = arearangeSeriesDataEvent1;
			nullable = null;
			High_DefaultValue = nullable;
			High = nullable;
			object obj3 = null;
			str = (string) obj3;
			Id_DefaultValue = (string) obj3;
			Id = str;
			nullable = null;
			Labelrank_DefaultValue = nullable;
			Labelrank = nullable;
			nullable = null;
			Low_DefaultValue = nullable;
			Low = nullable;
			object obj4 = null;
			str = (string) obj4;
			Name_DefaultValue = (string) obj4;
			Name = str;
			bool? nullable1 = false;
			Selected_DefaultValue = nullable1;
			Selected = nullable1;
			nullable = double.MinValue;
			X_DefaultValue = nullable;
			X = nullable;
		}

		internal override bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (ClassName != ClassName_DefaultValue)
			{
				hashtables.Add("className", ClassName);
			}
			if (Color != Color_DefaultValue)
			{
				hashtables.Add("color", Color);
			}
			double? colorIndex = ColorIndex;
			double? colorIndexDefaultValue = ColorIndex_DefaultValue;
			if ((colorIndex.GetValueOrDefault() == colorIndexDefaultValue.GetValueOrDefault()
				? colorIndex.HasValue != colorIndexDefaultValue.HasValue
				: true))
			{
				hashtables.Add("colorIndex", ColorIndex);
			}
			if (DataLabels != DataLabels_DefaultValue)
			{
				hashtables.Add("dataLabels", DataLabels);
			}
			if (Description != Description_DefaultValue)
			{
				hashtables.Add("description", Description);
			}
			if (Drilldown != Drilldown_DefaultValue)
			{
				hashtables.Add("drilldown", Drilldown);
			}
			if (Events.IsDirty())
			{
				hashtables.Add("events", Events.ToHashtable());
			}
			colorIndexDefaultValue = High;
			colorIndex = High_DefaultValue;
			if ((colorIndexDefaultValue.GetValueOrDefault() == colorIndex.GetValueOrDefault()
				? colorIndexDefaultValue.HasValue != colorIndex.HasValue
				: true))
			{
				hashtables.Add("high", High);
			}
			if (Id != Id_DefaultValue)
			{
				hashtables.Add("id", Id);
			}
			colorIndex = Labelrank;
			colorIndexDefaultValue = Labelrank_DefaultValue;
			if ((colorIndex.GetValueOrDefault() == colorIndexDefaultValue.GetValueOrDefault()
				? colorIndex.HasValue != colorIndexDefaultValue.HasValue
				: true))
			{
				hashtables.Add("labelrank", Labelrank);
			}
			colorIndexDefaultValue = Low;
			colorIndex = Low_DefaultValue;
			if ((colorIndexDefaultValue.GetValueOrDefault() == colorIndex.GetValueOrDefault()
				? colorIndexDefaultValue.HasValue != colorIndex.HasValue
				: true))
			{
				hashtables.Add("low", Low);
			}
			if (Name != Name_DefaultValue)
			{
				hashtables.Add("name", Name);
			}
			bool? selected = Selected;
			bool? selectedDefaultValue = Selected_DefaultValue;
			if ((selected.GetValueOrDefault() == selectedDefaultValue.GetValueOrDefault()
				? selected.HasValue != selectedDefaultValue.HasValue
				: true))
			{
				hashtables.Add("selected", Selected);
			}
			colorIndex = X;
			colorIndexDefaultValue = X_DefaultValue;
			if ((colorIndex.GetValueOrDefault() == colorIndexDefaultValue.GetValueOrDefault()
				? colorIndex.HasValue != colorIndexDefaultValue.HasValue
				: true))
			{
				hashtables.Add("x", X);
			}
			return hashtables;
		}

		internal override string ToJSON()
		{
			string str;
			Hashtable hashtable = ToHashtable();
			JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer
			{
				MaxJsonLength = 2147483647
			};
			str = (hashtable.Count <= 0 ? "" : javaScriptSerializer.Serialize(ToHashtable()));
			return str;
		}
	}
}