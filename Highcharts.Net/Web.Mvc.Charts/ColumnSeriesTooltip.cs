using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class ColumnSeriesTooltip : BaseObject
	{
		public Hashtable DateTimeLabelFormats
		{
			get;
			set;
		}

		private Hashtable DateTimeLabelFormats_DefaultValue
		{
			get;
			set;
		}

		public bool? FollowPointer
		{
			get;
			set;
		}

		private bool? FollowPointer_DefaultValue
		{
			get;
			set;
		}

		public bool? FollowTouchMove
		{
			get;
			set;
		}

		private bool? FollowTouchMove_DefaultValue
		{
			get;
			set;
		}

		public string FooterFormat
		{
			get;
			set;
		}

		private string FooterFormat_DefaultValue
		{
			get;
			set;
		}

		public string HeaderFormat
		{
			get;
			set;
		}

		private string HeaderFormat_DefaultValue
		{
			get;
			set;
		}

		public double? HideDelay
		{
			get;
			set;
		}

		private double? HideDelay_DefaultValue
		{
			get;
			set;
		}

		public double? Padding
		{
			get;
			set;
		}

		private double? Padding_DefaultValue
		{
			get;
			set;
		}

		public string PointFormat
		{
			get;
			set;
		}

		private string PointFormat_DefaultValue
		{
			get;
			set;
		}

		public string PointFormatter
		{
			get;
			set;
		}

		private string PointFormatter_DefaultValue
		{
			get;
			set;
		}

		public bool? Split
		{
			get;
			set;
		}

		private bool? Split_DefaultValue
		{
			get;
			set;
		}

		public double? ValueDecimals
		{
			get;
			set;
		}

		private double? ValueDecimals_DefaultValue
		{
			get;
			set;
		}

		public string ValuePrefix
		{
			get;
			set;
		}

		private string ValuePrefix_DefaultValue
		{
			get;
			set;
		}

		public string ValueSuffix
		{
			get;
			set;
		}

		private string ValueSuffix_DefaultValue
		{
			get;
			set;
		}

		public string XDateFormat
		{
			get;
			set;
		}

		private string XDateFormat_DefaultValue
		{
			get;
			set;
		}

		public ColumnSeriesTooltip()
		{
			Hashtable hashtables = new Hashtable();
			Hashtable hashtables1 = hashtables;
			this.DateTimeLabelFormats_DefaultValue = hashtables;
			this.DateTimeLabelFormats = hashtables1;
			bool? nullable = new bool?(false);
			this.FollowPointer_DefaultValue = nullable;
			this.FollowPointer = nullable;
			nullable = new bool?(true);
			this.FollowTouchMove_DefaultValue = nullable;
			this.FollowTouchMove = nullable;
			string str = "false";
			string str1 = str;
			this.FooterFormat_DefaultValue = str;
			this.FooterFormat = str1;
			string str2 = "";
			str1 = str2;
			this.HeaderFormat_DefaultValue = str2;
			this.HeaderFormat = str1;
			double? nullable1 = new double?((double)500);
			this.HideDelay_DefaultValue = nullable1;
			this.HideDelay = nullable1;
			nullable1 = new double?((double)8);
			this.Padding_DefaultValue = nullable1;
			this.Padding = nullable1;
			string str3 = "<span style='color:{point.color}'>●</span> {series.name}: <b>{point.y}</b><br/>";
			str1 = str3;
			this.PointFormat_DefaultValue = str3;
			this.PointFormat = str1;
			string str4 = "";
			str1 = str4;
			this.PointFormatter_DefaultValue = str4;
			this.PointFormatter = str1;
			nullable = new bool?(false);
			this.Split_DefaultValue = nullable;
			this.Split = nullable;
			nullable1 = null;
			this.ValueDecimals_DefaultValue = nullable1;
			this.ValueDecimals = nullable1;
			object obj = null;
			str1 = (string)obj;
			this.ValuePrefix_DefaultValue = (string)obj;
			this.ValuePrefix = str1;
			object obj1 = null;
			str1 = (string)obj1;
			this.ValueSuffix_DefaultValue = (string)obj1;
			this.ValueSuffix = str1;
			object obj2 = null;
			str1 = (string)obj2;
			this.XDateFormat_DefaultValue = (string)obj2;
			this.XDateFormat = str1;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.DateTimeLabelFormats != this.DateTimeLabelFormats_DefaultValue)
			{
				hashtables.Add("dateTimeLabelFormats", this.DateTimeLabelFormats);
			}
			bool? followPointer = this.FollowPointer;
			bool? followPointerDefaultValue = this.FollowPointer_DefaultValue;
			if ((followPointer.GetValueOrDefault() == followPointerDefaultValue.GetValueOrDefault() ? followPointer.HasValue != followPointerDefaultValue.HasValue : true))
			{
				hashtables.Add("followPointer", this.FollowPointer);
			}
			followPointerDefaultValue = this.FollowTouchMove;
			followPointer = this.FollowTouchMove_DefaultValue;
			if ((followPointerDefaultValue.GetValueOrDefault() == followPointer.GetValueOrDefault() ? followPointerDefaultValue.HasValue != followPointer.HasValue : true))
			{
				hashtables.Add("followTouchMove", this.FollowTouchMove);
			}
			if (this.FooterFormat != this.FooterFormat_DefaultValue)
			{
				hashtables.Add("footerFormat", this.FooterFormat);
			}
			if (this.HeaderFormat != this.HeaderFormat_DefaultValue)
			{
				hashtables.Add("headerFormat", this.HeaderFormat);
			}
			double? hideDelay = this.HideDelay;
			double? hideDelayDefaultValue = this.HideDelay_DefaultValue;
			if ((hideDelay.GetValueOrDefault() == hideDelayDefaultValue.GetValueOrDefault() ? hideDelay.HasValue != hideDelayDefaultValue.HasValue : true))
			{
				hashtables.Add("hideDelay", this.HideDelay);
			}
			hideDelayDefaultValue = this.Padding;
			hideDelay = this.Padding_DefaultValue;
			if ((hideDelayDefaultValue.GetValueOrDefault() == hideDelay.GetValueOrDefault() ? hideDelayDefaultValue.HasValue != hideDelay.HasValue : true))
			{
				hashtables.Add("padding", this.Padding);
			}
			if (this.PointFormat != this.PointFormat_DefaultValue)
			{
				hashtables.Add("pointFormat", this.PointFormat);
			}
			if (this.PointFormatter != this.PointFormatter_DefaultValue)
			{
				hashtables.Add("pointFormatter", this.PointFormatter);
				Highcharts.AddFunction("ColumnSeriesTooltipPointFormatter.pointFormatter", this.PointFormatter);
			}
			followPointer = this.Split;
			followPointerDefaultValue = this.Split_DefaultValue;
			if ((followPointer.GetValueOrDefault() == followPointerDefaultValue.GetValueOrDefault() ? followPointer.HasValue != followPointerDefaultValue.HasValue : true))
			{
				hashtables.Add("split", this.Split);
			}
			hideDelay = this.ValueDecimals;
			hideDelayDefaultValue = this.ValueDecimals_DefaultValue;
			if ((hideDelay.GetValueOrDefault() == hideDelayDefaultValue.GetValueOrDefault() ? hideDelay.HasValue != hideDelayDefaultValue.HasValue : true))
			{
				hashtables.Add("valueDecimals", this.ValueDecimals);
			}
			if (this.ValuePrefix != this.ValuePrefix_DefaultValue)
			{
				hashtables.Add("valuePrefix", this.ValuePrefix);
			}
			if (this.ValueSuffix != this.ValueSuffix_DefaultValue)
			{
				hashtables.Add("valueSuffix", this.ValueSuffix);
			}
			if (this.XDateFormat != this.XDateFormat_DefaultValue)
			{
				hashtables.Add("xDateFormat", this.XDateFormat);
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