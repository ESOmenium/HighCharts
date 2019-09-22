using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class YAxisCrosshair : BaseObject
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

		public YAxisCrosshairDashStyle DashStyle
		{
			get;
			set;
		}

		private YAxisCrosshairDashStyle DashStyle_DefaultValue
		{
			get;
			set;
		}

		public bool? Snap
		{
			get;
			set;
		}

		private bool? Snap_DefaultValue
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

		public YAxisCrosshair()
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
			YAxisCrosshairDashStyle yAxisCrosshairDashStyle = (YAxisCrosshairDashStyle)num;
			this.DashStyle_DefaultValue = (YAxisCrosshairDashStyle)num;
			this.DashStyle = yAxisCrosshairDashStyle;
			bool? nullable = new bool?(true);
			this.Snap_DefaultValue = nullable;
			this.Snap = nullable;
			double? nullable1 = null;
			this.Width_DefaultValue = nullable1;
			this.Width = nullable1;
			nullable1 = new double?((double)2);
			this.ZIndex_DefaultValue = nullable1;
			this.ZIndex = nullable1;
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
				YAxisCrosshairDashStyle dashStyle = this.DashStyle;
				hashtables.Add("dashStyle", Highcharts.FirstCharacterToLower(dashStyle.ToString()));
			}
			bool? snap = this.Snap;
			bool? snapDefaultValue = this.Snap_DefaultValue;
			if ((snap.GetValueOrDefault() == snapDefaultValue.GetValueOrDefault() ? snap.HasValue != snapDefaultValue.HasValue : true))
			{
				hashtables.Add("snap", this.Snap);
			}
			double? width = this.Width;
			double? widthDefaultValue = this.Width_DefaultValue;
			if ((width.GetValueOrDefault() == widthDefaultValue.GetValueOrDefault() ? width.HasValue != widthDefaultValue.HasValue : true))
			{
				hashtables.Add("width", this.Width);
			}
			widthDefaultValue = this.ZIndex;
			width = this.ZIndex_DefaultValue;
			if ((widthDefaultValue.GetValueOrDefault() == width.GetValueOrDefault() ? widthDefaultValue.HasValue != width.HasValue : true))
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