using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class TreemapSeriesLevels : BaseObject
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

		public string BorderDashStyle
		{
			get;
			set;
		}

		private string BorderDashStyle_DefaultValue
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

		public TreemapSeriesLevelsLayoutAlgorithm LayoutAlgorithm
		{
			get;
			set;
		}

		private TreemapSeriesLevelsLayoutAlgorithm LayoutAlgorithm_DefaultValue
		{
			get;
			set;
		}

		public TreemapSeriesLevelsLayoutStartingDirection LayoutStartingDirection
		{
			get;
			set;
		}

		private TreemapSeriesLevelsLayoutStartingDirection LayoutStartingDirection_DefaultValue
		{
			get;
			set;
		}

		public double? Level
		{
			get;
			set;
		}

		private double? Level_DefaultValue
		{
			get;
			set;
		}

		public TreemapSeriesLevels()
		{
			object obj = null;
			string str = (string)obj;
			this.BorderColor_DefaultValue = (string)obj;
			this.BorderColor = str;
			object obj1 = null;
			str = (string)obj1;
			this.BorderDashStyle_DefaultValue = (string)obj1;
			this.BorderDashStyle = str;
			double? nullable = null;
			this.BorderWidth_DefaultValue = nullable;
			this.BorderWidth = nullable;
			object obj2 = null;
			str = (string)obj2;
			this.Color_DefaultValue = (string)obj2;
			this.Color = str;
			object obj3 = null;
			object obj4 = obj3;
			this.DataLabels_DefaultValue = obj3;
			this.DataLabels = obj4;
			int num = 0;
			TreemapSeriesLevelsLayoutAlgorithm treemapSeriesLevelsLayoutAlgorithm = (TreemapSeriesLevelsLayoutAlgorithm)num;
			this.LayoutAlgorithm_DefaultValue = (TreemapSeriesLevelsLayoutAlgorithm)num;
			this.LayoutAlgorithm = treemapSeriesLevelsLayoutAlgorithm;
			int num1 = 0;
			TreemapSeriesLevelsLayoutStartingDirection treemapSeriesLevelsLayoutStartingDirection = (TreemapSeriesLevelsLayoutStartingDirection)num1;
			this.LayoutStartingDirection_DefaultValue = (TreemapSeriesLevelsLayoutStartingDirection)num1;
			this.LayoutStartingDirection = treemapSeriesLevelsLayoutStartingDirection;
			nullable = null;
			this.Level_DefaultValue = nullable;
			this.Level = nullable;
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
			if (this.BorderDashStyle != this.BorderDashStyle_DefaultValue)
			{
				hashtables.Add("borderDashStyle", this.BorderDashStyle);
			}
			double? borderWidth = this.BorderWidth;
			double? borderWidthDefaultValue = this.BorderWidth_DefaultValue;
			if ((borderWidth.GetValueOrDefault() == borderWidthDefaultValue.GetValueOrDefault() ? borderWidth.HasValue != borderWidthDefaultValue.HasValue : true))
			{
				hashtables.Add("borderWidth", this.BorderWidth);
			}
			if (this.Color != this.Color_DefaultValue)
			{
				hashtables.Add("color", this.Color);
			}
			if (this.DataLabels != this.DataLabels_DefaultValue)
			{
				hashtables.Add("dataLabels", this.DataLabels);
			}
			if (this.LayoutAlgorithm != this.LayoutAlgorithm_DefaultValue)
			{
				TreemapSeriesLevelsLayoutAlgorithm layoutAlgorithm = this.LayoutAlgorithm;
				hashtables.Add("layoutAlgorithm", Highcharts.FirstCharacterToLower(layoutAlgorithm.ToString()));
			}
			if (this.LayoutStartingDirection != this.LayoutStartingDirection_DefaultValue)
			{
				TreemapSeriesLevelsLayoutStartingDirection layoutStartingDirection = this.LayoutStartingDirection;
				hashtables.Add("layoutStartingDirection", Highcharts.FirstCharacterToLower(layoutStartingDirection.ToString()));
			}
			borderWidthDefaultValue = this.Level;
			borderWidth = this.Level_DefaultValue;
			if ((borderWidthDefaultValue.GetValueOrDefault() == borderWidth.GetValueOrDefault() ? borderWidthDefaultValue.HasValue != borderWidth.HasValue : true))
			{
				hashtables.Add("level", this.Level);
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