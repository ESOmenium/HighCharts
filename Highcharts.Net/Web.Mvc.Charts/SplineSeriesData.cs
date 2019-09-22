using System.Collections;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class SplineSeriesData : BaseObject
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

		public SplineSeriesDataEvents Events { get; set; }

		private SplineSeriesDataEvents Events_DefaultValue { get; set; }

		public string Id { get; set; }

		private string Id_DefaultValue { get; }

		public double? Labelrank { get; set; }

		private double? Labelrank_DefaultValue { get; }

		public SplineSeriesDataMarker Marker { get; set; }

		private SplineSeriesDataMarker Marker_DefaultValue { get; set; }

		public string Name { get; set; }

		private string Name_DefaultValue { get; }

		public bool? Selected { get; set; }

		private bool? Selected_DefaultValue { get; }

		public double? X { get; set; }

		private double? X_DefaultValue { get; }

		public double? Y { get; set; }

		private double? Y_DefaultValue { get; }

		public SplineSeriesData()
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
			SplineSeriesDataEvents splineSeriesDataEvent = new SplineSeriesDataEvents();
			SplineSeriesDataEvents splineSeriesDataEvent1 = splineSeriesDataEvent;
			Events_DefaultValue = splineSeriesDataEvent;
			Events = splineSeriesDataEvent1;
			object obj3 = null;
			str = (string) obj3;
			Id_DefaultValue = (string) obj3;
			Id = str;
			nullable = null;
			Labelrank_DefaultValue = nullable;
			Labelrank = nullable;
			SplineSeriesDataMarker splineSeriesDataMarker = new SplineSeriesDataMarker();
			SplineSeriesDataMarker splineSeriesDataMarker1 = splineSeriesDataMarker;
			Marker_DefaultValue = splineSeriesDataMarker;
			Marker = splineSeriesDataMarker1;
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
			nullable = double.MinValue;
			Y_DefaultValue = nullable;
			Y = nullable;
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
			if (Id != Id_DefaultValue)
			{
				hashtables.Add("id", Id);
			}
			colorIndexDefaultValue = Labelrank;
			colorIndex = Labelrank_DefaultValue;
			if ((colorIndexDefaultValue.GetValueOrDefault() == colorIndex.GetValueOrDefault()
				? colorIndexDefaultValue.HasValue != colorIndex.HasValue
				: true))
			{
				hashtables.Add("labelrank", Labelrank);
			}
			if (Marker.IsDirty())
			{
				hashtables.Add("marker", Marker.ToHashtable());
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
			colorIndexDefaultValue = Y;
			colorIndex = Y_DefaultValue;
			if ((colorIndexDefaultValue.GetValueOrDefault() == colorIndex.GetValueOrDefault()
				? colorIndexDefaultValue.HasValue != colorIndex.HasValue
				: true))
			{
				hashtables.Add("y", Y);
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