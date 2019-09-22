using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class Subtitle : BaseObject
	{
		public SubtitleAlign Align
		{
			get;
			set;
		}

		private SubtitleAlign Align_DefaultValue
		{
			get;
			set;
		}

		public bool? Floating
		{
			get;
			set;
		}

		private bool? Floating_DefaultValue
		{
			get;
			set;
		}

		public Hashtable Style
		{
			get;
			set;
		}

		private Hashtable Style_DefaultValue
		{
			get;
			set;
		}

		public string Text
		{
			get;
			set;
		}

		private string Text_DefaultValue
		{
			get;
			set;
		}

		public bool? UseHTML
		{
			get;
			set;
		}

		private bool? UseHTML_DefaultValue
		{
			get;
			set;
		}

		public SubtitleVerticalAlign VerticalAlign
		{
			get;
			set;
		}

		private SubtitleVerticalAlign VerticalAlign_DefaultValue
		{
			get;
			set;
		}

		public double? WidthAdjust
		{
			get;
			set;
		}

		private double? WidthAdjust_DefaultValue
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

		public Subtitle()
		{
			int num = 1;
			SubtitleAlign subtitleAlign = (SubtitleAlign)num;
			this.Align_DefaultValue = (SubtitleAlign)num;
			this.Align = subtitleAlign;
			bool? nullable = new bool?(false);
			this.Floating_DefaultValue = nullable;
			this.Floating = nullable;
			Hashtable hashtables = new Hashtable()
			{
				{ "color", "#666666" }
			};
			Hashtable hashtables1 = hashtables;
			this.Style_DefaultValue = hashtables;
			this.Style = hashtables1;
			object obj = null;
			string str = (string)obj;
			this.Text_DefaultValue = (string)obj;
			this.Text = str;
			nullable = new bool?(false);
			this.UseHTML_DefaultValue = nullable;
			this.UseHTML = nullable;
			int num1 = 0;
			SubtitleVerticalAlign subtitleVerticalAlign = (SubtitleVerticalAlign)num1;
			this.VerticalAlign_DefaultValue = (SubtitleVerticalAlign)num1;
			this.VerticalAlign = subtitleVerticalAlign;
			double? nullable1 = new double?((double)-44);
			this.WidthAdjust_DefaultValue = nullable1;
			this.WidthAdjust = nullable1;
			nullable1 = new double?(0);
			this.X_DefaultValue = nullable1;
			this.X = nullable1;
			nullable1 = null;
			this.Y_DefaultValue = nullable1;
			this.Y = nullable1;
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
				SubtitleAlign align = this.Align;
				hashtables.Add("align", Highcharts.FirstCharacterToLower(align.ToString()));
			}
			bool? floating = this.Floating;
			bool? floatingDefaultValue = this.Floating_DefaultValue;
			if ((floating.GetValueOrDefault() == floatingDefaultValue.GetValueOrDefault() ? floating.HasValue != floatingDefaultValue.HasValue : true))
			{
				hashtables.Add("floating", this.Floating);
			}
			if (this.Style != this.Style_DefaultValue)
			{
				hashtables.Add("style", this.Style);
			}
			if (this.Text != this.Text_DefaultValue)
			{
				hashtables.Add("text", this.Text);
			}
			floatingDefaultValue = this.UseHTML;
			floating = this.UseHTML_DefaultValue;
			if ((floatingDefaultValue.GetValueOrDefault() == floating.GetValueOrDefault() ? floatingDefaultValue.HasValue != floating.HasValue : true))
			{
				hashtables.Add("useHTML", this.UseHTML);
			}
			if (this.VerticalAlign != this.VerticalAlign_DefaultValue)
			{
				SubtitleVerticalAlign verticalAlign = this.VerticalAlign;
				hashtables.Add("verticalAlign", Highcharts.FirstCharacterToLower(verticalAlign.ToString()));
			}
			double? widthAdjust = this.WidthAdjust;
			double? widthAdjustDefaultValue = this.WidthAdjust_DefaultValue;
			if ((widthAdjust.GetValueOrDefault() == widthAdjustDefaultValue.GetValueOrDefault() ? widthAdjust.HasValue != widthAdjustDefaultValue.HasValue : true))
			{
				hashtables.Add("widthAdjust", this.WidthAdjust);
			}
			widthAdjustDefaultValue = this.X;
			widthAdjust = this.X_DefaultValue;
			if ((widthAdjustDefaultValue.GetValueOrDefault() == widthAdjust.GetValueOrDefault() ? widthAdjustDefaultValue.HasValue != widthAdjust.HasValue : true))
			{
				hashtables.Add("x", this.X);
			}
			widthAdjust = this.Y;
			widthAdjustDefaultValue = this.Y_DefaultValue;
			if ((widthAdjust.GetValueOrDefault() == widthAdjustDefaultValue.GetValueOrDefault() ? widthAdjust.HasValue != widthAdjustDefaultValue.HasValue : true))
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