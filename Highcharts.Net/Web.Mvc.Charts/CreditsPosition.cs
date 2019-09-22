using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class CreditsPosition : BaseObject
	{
		public CreditsPositionAlign Align
		{
			get;
			set;
		}

		private CreditsPositionAlign Align_DefaultValue
		{
			get;
			set;
		}

		public CreditsPositionVerticalAlign VerticalAlign
		{
			get;
			set;
		}

		private CreditsPositionVerticalAlign VerticalAlign_DefaultValue
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

		public CreditsPosition()
		{
			int num = 2;
			CreditsPositionAlign creditsPositionAlign = (CreditsPositionAlign)num;
			this.Align_DefaultValue = (CreditsPositionAlign)num;
			this.Align = creditsPositionAlign;
			int num1 = 2;
			CreditsPositionVerticalAlign creditsPositionVerticalAlign = (CreditsPositionVerticalAlign)num1;
			this.VerticalAlign_DefaultValue = (CreditsPositionVerticalAlign)num1;
			this.VerticalAlign = creditsPositionVerticalAlign;
			double? nullable = new double?((double)-10);
			this.X_DefaultValue = nullable;
			this.X = nullable;
			nullable = new double?((double)-5);
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
				CreditsPositionAlign align = this.Align;
				hashtables.Add("align", Highcharts.FirstCharacterToLower(align.ToString()));
			}
			if (this.VerticalAlign != this.VerticalAlign_DefaultValue)
			{
				CreditsPositionVerticalAlign verticalAlign = this.VerticalAlign;
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