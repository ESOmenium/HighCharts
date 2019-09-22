using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class Series : BaseObject
	{
		public List<SeriesData> Data
		{
			get;
			set;
		}

		private List<SeriesData> Data_DefaultValue
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

		public double? Index
		{
			get;
			set;
		}

		private double? Index_DefaultValue
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

		public string Stack
		{
			get;
			set;
		}

		private string Stack_DefaultValue
		{
			get;
			set;
		}

		public SeriesType Type
		{
			get;
			set;
		}

		private SeriesType Type_DefaultValue
		{
			get;
			set;
		}

		public string XAxis
		{
			get;
			set;
		}

		private string XAxis_DefaultValue
		{
			get;
			set;
		}

		public string YAxis
		{
			get;
			set;
		}

		private string YAxis_DefaultValue
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

		public Series()
		{
			List<SeriesData> seriesDatas = new List<SeriesData>();
			List<SeriesData> seriesDatas1 = seriesDatas;
			this.Data_DefaultValue = seriesDatas;
			this.Data = seriesDatas1;
			string str = "";
			string str1 = str;
			this.Id_DefaultValue = str;
			this.Id = str1;
			double? nullable = null;
			this.Index_DefaultValue = nullable;
			this.Index = nullable;
			nullable = null;
			this.LegendIndex_DefaultValue = nullable;
			this.LegendIndex = nullable;
			object obj = null;
			str1 = (string)obj;
			this.Name_DefaultValue = (string)obj;
			this.Name = str1;
			object obj1 = null;
			str1 = (string)obj1;
			this.Stack_DefaultValue = (string)obj1;
			this.Stack = str1;
			int num = 0;
			SeriesType seriesType = (SeriesType)num;
			this.Type_DefaultValue = (SeriesType)num;
			this.Type = seriesType;
			string str2 = "0";
			str1 = str2;
			this.XAxis_DefaultValue = str2;
			this.XAxis = str1;
			string str3 = "0";
			str1 = str3;
			this.YAxis_DefaultValue = str3;
			this.YAxis = str1;
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
			if (this.Data.Any<SeriesData>())
			{
				hashtables.Add("data", base.HashifyList(this.Data));
			}
			if (this.Id != this.Id_DefaultValue)
			{
				hashtables.Add("id", this.Id);
			}
			double? index = this.Index;
			double? indexDefaultValue = this.Index_DefaultValue;
			if ((index.GetValueOrDefault() == indexDefaultValue.GetValueOrDefault() ? index.HasValue != indexDefaultValue.HasValue : true))
			{
				hashtables.Add("index", this.Index);
			}
			indexDefaultValue = this.LegendIndex;
			index = this.LegendIndex_DefaultValue;
			if ((indexDefaultValue.GetValueOrDefault() == index.GetValueOrDefault() ? indexDefaultValue.HasValue != index.HasValue : true))
			{
				hashtables.Add("legendIndex", this.LegendIndex);
			}
			if (this.Name != this.Name_DefaultValue)
			{
				hashtables.Add("name", this.Name);
			}
			if (this.Stack != this.Stack_DefaultValue)
			{
				hashtables.Add("stack", this.Stack);
			}
			if (this.Type != this.Type_DefaultValue)
			{
				SeriesType type = this.Type;
				hashtables.Add("type", Highcharts.FirstCharacterToLower(type.ToString()));
			}
			if (this.XAxis != this.XAxis_DefaultValue)
			{
				hashtables.Add("xAxis", this.XAxis);
			}
			if (this.YAxis != this.YAxis_DefaultValue)
			{
				hashtables.Add("yAxis", this.YAxis);
			}
			index = this.ZIndex;
			indexDefaultValue = this.ZIndex_DefaultValue;
			if ((index.GetValueOrDefault() == indexDefaultValue.GetValueOrDefault() ? index.HasValue != indexDefaultValue.HasValue : true))
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