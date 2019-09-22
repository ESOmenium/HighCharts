using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class ChartResetZoomButtonPosition : BaseObject
	{
		public string Align
		{
			get;
			set;
		}

		private string Align_DefaultValue
		{
			get;
			set;
		}

		public ChartResetZoomButtonPositionVerticalAlign VerticalAlign
		{
			get;
			set;
		}

		private ChartResetZoomButtonPositionVerticalAlign VerticalAlign_DefaultValue
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

		public ChartResetZoomButtonPosition()
		{
			object obj = null;
			string str = (string)obj;
			this.Align_DefaultValue = (string)obj;
			this.Align = str;
			int num = 0;
			ChartResetZoomButtonPositionVerticalAlign chartResetZoomButtonPositionVerticalAlign = (ChartResetZoomButtonPositionVerticalAlign)num;
			this.VerticalAlign_DefaultValue = (ChartResetZoomButtonPositionVerticalAlign)num;
			this.VerticalAlign = chartResetZoomButtonPositionVerticalAlign;
			double? nullable = new double?((double)-10);
			this.X_DefaultValue = nullable;
			this.X = nullable;
			nullable = new double?((double)10);
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
			if (this.Align != this.Align_DefaultValue)
			{
				hashtables.Add("align", this.Align);
			}
			if (this.VerticalAlign != this.VerticalAlign_DefaultValue)
			{
				ChartResetZoomButtonPositionVerticalAlign verticalAlign = this.VerticalAlign;
				hashtables.Add("verticalAlign", Highcharts.FirstCharacterToLower(verticalAlign.ToString()));
			}
			double? x = this.X;
			double? xDefaultValue = this.X_DefaultValue;
			if ((x.GetValueOrDefault() == xDefaultValue.GetValueOrDefault() ? x.HasValue != xDefaultValue.HasValue : true))
			{
				hashtables.Add("x", this.X);
			}
			xDefaultValue = this.Y;
			x = this.Y_DefaultValue;
			if ((xDefaultValue.GetValueOrDefault() == x.GetValueOrDefault() ? xDefaultValue.HasValue != x.HasValue : true))
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