using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class YAxisStackLabels : BaseObject
	{
		public YAxisStackLabelsAlign Align
		{
			get;
			set;
		}

		private YAxisStackLabelsAlign Align_DefaultValue
		{
			get;
			set;
		}

		public bool? Enabled
		{
			get;
			set;
		}

		private bool? Enabled_DefaultValue
		{
			get;
			set;
		}

		public string Format
		{
			get;
			set;
		}

		private string Format_DefaultValue
		{
			get;
			set;
		}

		public string Formatter
		{
			get;
			set;
		}

		private string Formatter_DefaultValue
		{
			get;
			set;
		}

		public double? Rotation
		{
			get;
			set;
		}

		private double? Rotation_DefaultValue
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

		public YAxisStackLabelsTextAlign TextAlign
		{
			get;
			set;
		}

		private YAxisStackLabelsTextAlign TextAlign_DefaultValue
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

		public YAxisStackLabelsVerticalAlign VerticalAlign
		{
			get;
			set;
		}

		private YAxisStackLabelsVerticalAlign VerticalAlign_DefaultValue
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

		public YAxisStackLabels()
		{
			int num = 0;
			YAxisStackLabelsAlign yAxisStackLabelsAlign = (YAxisStackLabelsAlign)num;
			this.Align_DefaultValue = (YAxisStackLabelsAlign)num;
			this.Align = yAxisStackLabelsAlign;
			bool? nullable = new bool?(false);
			this.Enabled_DefaultValue = nullable;
			this.Enabled = nullable;
			string str = "{total}";
			string str1 = str;
			this.Format_DefaultValue = str;
			this.Format = str1;
			string str2 = "";
			str1 = str2;
			this.Formatter_DefaultValue = str2;
			this.Formatter = str1;
			double? nullable1 = new double?(0);
			this.Rotation_DefaultValue = nullable1;
			this.Rotation = nullable1;
			Hashtable hashtables = new Hashtable()
			{
				{ "color", "#000000" },
				{ "fontSize", "11px" },
				{ "fontWeight", "bold" },
				{ "textShadow", "1px 1px contrast},{ -1px -1px contrast},{ -1px 1px contrast},{ 1px -1px contrast" }
			};
			Hashtable hashtables1 = hashtables;
			Hashtable hashtables2 = hashtables1;
			this.Style_DefaultValue = hashtables1;
			this.Style = hashtables2;
			int num1 = 0;
			YAxisStackLabelsTextAlign yAxisStackLabelsTextAlign = (YAxisStackLabelsTextAlign)num1;
			this.TextAlign_DefaultValue = (YAxisStackLabelsTextAlign)num1;
			this.TextAlign = yAxisStackLabelsTextAlign;
			nullable = new bool?(false);
			this.UseHTML_DefaultValue = nullable;
			this.UseHTML = nullable;
			int num2 = 0;
			YAxisStackLabelsVerticalAlign yAxisStackLabelsVerticalAlign = (YAxisStackLabelsVerticalAlign)num2;
			this.VerticalAlign_DefaultValue = (YAxisStackLabelsVerticalAlign)num2;
			this.VerticalAlign = yAxisStackLabelsVerticalAlign;
			nullable1 = null;
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
				YAxisStackLabelsAlign align = this.Align;
				hashtables.Add("align", Highcharts.FirstCharacterToLower(align.ToString()));
			}
			bool? enabled = this.Enabled;
			bool? enabledDefaultValue = this.Enabled_DefaultValue;
			if ((enabled.GetValueOrDefault() == enabledDefaultValue.GetValueOrDefault() ? enabled.HasValue != enabledDefaultValue.HasValue : true))
			{
				hashtables.Add("enabled", this.Enabled);
			}
			if (this.Format != this.Format_DefaultValue)
			{
				hashtables.Add("format", this.Format);
			}
			if (this.Formatter != this.Formatter_DefaultValue)
			{
				hashtables.Add("formatter", this.Formatter);
				Highcharts.AddFunction("YAxisStackLabelsFormatter.formatter", this.Formatter);
			}
			double? rotation = this.Rotation;
			double? rotationDefaultValue = this.Rotation_DefaultValue;
			if ((rotation.GetValueOrDefault() == rotationDefaultValue.GetValueOrDefault() ? rotation.HasValue != rotationDefaultValue.HasValue : true))
			{
				hashtables.Add("rotation", this.Rotation);
			}
			if (this.Style != this.Style_DefaultValue)
			{
				hashtables.Add("style", this.Style);
			}
			if (this.TextAlign != this.TextAlign_DefaultValue)
			{
				YAxisStackLabelsTextAlign textAlign = this.TextAlign;
				hashtables.Add("textAlign", Highcharts.FirstCharacterToLower(textAlign.ToString()));
			}
			enabledDefaultValue = this.UseHTML;
			enabled = this.UseHTML_DefaultValue;
			if ((enabledDefaultValue.GetValueOrDefault() == enabled.GetValueOrDefault() ? enabledDefaultValue.HasValue != enabled.HasValue : true))
			{
				hashtables.Add("useHTML", this.UseHTML);
			}
			if (this.VerticalAlign != this.VerticalAlign_DefaultValue)
			{
				YAxisStackLabelsVerticalAlign verticalAlign = this.VerticalAlign;
				hashtables.Add("verticalAlign", Highcharts.FirstCharacterToLower(verticalAlign.ToString()));
			}
			rotationDefaultValue = this.X;
			rotation = this.X_DefaultValue;
			if ((rotationDefaultValue.GetValueOrDefault() == rotation.GetValueOrDefault() ? rotationDefaultValue.HasValue != rotation.HasValue : true))
			{
				hashtables.Add("x", this.X);
			}
			rotation = this.Y;
			rotationDefaultValue = this.Y_DefaultValue;
			if ((rotation.GetValueOrDefault() == rotationDefaultValue.GetValueOrDefault() ? rotation.HasValue != rotationDefaultValue.HasValue : true))
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