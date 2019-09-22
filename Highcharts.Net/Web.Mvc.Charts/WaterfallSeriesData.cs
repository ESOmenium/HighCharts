using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class WaterfallSeriesData : BaseObject
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

		public WaterfallSeriesDataEvents Events
		{
			get;
			set;
		}

		private WaterfallSeriesDataEvents Events_DefaultValue
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

		public bool? IsIntermediateSum
		{
			get;
			set;
		}

		private bool? IsIntermediateSum_DefaultValue
		{
			get;
			set;
		}

		public bool? IsSum
		{
			get;
			set;
		}

		private bool? IsSum_DefaultValue
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

		public WaterfallSeriesData()
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
			WaterfallSeriesDataEvents waterfallSeriesDataEvent = new WaterfallSeriesDataEvents();
			WaterfallSeriesDataEvents waterfallSeriesDataEvent1 = waterfallSeriesDataEvent;
			this.Events_DefaultValue = waterfallSeriesDataEvent;
			this.Events = waterfallSeriesDataEvent1;
			object obj3 = null;
			str = (string)obj3;
			this.Id_DefaultValue = (string)obj3;
			this.Id = str;
			bool? nullable1 = new bool?(false);
			this.IsIntermediateSum_DefaultValue = nullable1;
			this.IsIntermediateSum = nullable1;
			nullable1 = new bool?(false);
			this.IsSum_DefaultValue = nullable1;
			this.IsSum = nullable1;
			nullable = null;
			this.Labelrank_DefaultValue = nullable;
			this.Labelrank = nullable;
			object obj4 = null;
			str = (string)obj4;
			this.Name_DefaultValue = (string)obj4;
			this.Name = str;
			nullable1 = new bool?(false);
			this.Selected_DefaultValue = nullable1;
			this.Selected = nullable1;
			nullable = new double?(double.MinValue);
			this.X_DefaultValue = nullable;
			this.X = nullable;
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
			bool? isIntermediateSum = this.IsIntermediateSum;
			bool? isIntermediateSumDefaultValue = this.IsIntermediateSum_DefaultValue;
			if ((isIntermediateSum.GetValueOrDefault() == isIntermediateSumDefaultValue.GetValueOrDefault() ? isIntermediateSum.HasValue != isIntermediateSumDefaultValue.HasValue : true))
			{
				hashtables.Add("isIntermediateSum", this.IsIntermediateSum);
			}
			isIntermediateSumDefaultValue = this.IsSum;
			isIntermediateSum = this.IsSum_DefaultValue;
			if ((isIntermediateSumDefaultValue.GetValueOrDefault() == isIntermediateSum.GetValueOrDefault() ? isIntermediateSumDefaultValue.HasValue != isIntermediateSum.HasValue : true))
			{
				hashtables.Add("isSum", this.IsSum);
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
			isIntermediateSum = this.Selected;
			isIntermediateSumDefaultValue = this.Selected_DefaultValue;
			if ((isIntermediateSum.GetValueOrDefault() == isIntermediateSumDefaultValue.GetValueOrDefault() ? isIntermediateSum.HasValue != isIntermediateSumDefaultValue.HasValue : true))
			{
				hashtables.Add("selected", this.Selected);
			}
			colorIndex = this.X;
			colorIndexDefaultValue = this.X_DefaultValue;
			if ((colorIndex.GetValueOrDefault() == colorIndexDefaultValue.GetValueOrDefault() ? colorIndex.HasValue != colorIndexDefaultValue.HasValue : true))
			{
				hashtables.Add("x", this.X);
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