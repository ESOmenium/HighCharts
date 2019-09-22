using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class Tooltip : BaseObject
	{
		public Highsoft.Web.Mvc.Charts.Animation Animation
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.Animation Animation_DefaultValue
		{
			get;
			set;
		}

		public string BackgroundColor
		{
			get;
			set;
		}

		private string BackgroundColor_DefaultValue
		{
			get;
			set;
		}

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

		public double? BorderRadius
		{
			get;
			set;
		}

		private double? BorderRadius_DefaultValue
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

		public string Positioner
		{
			get;
			set;
		}

		private string Positioner_DefaultValue
		{
			get;
			set;
		}

		public Highsoft.Web.Mvc.Charts.Shadow Shadow
		{
			get;
			set;
		}

		private Highsoft.Web.Mvc.Charts.Shadow Shadow_DefaultValue
		{
			get;
			set;
		}

		public string Shape
		{
			get;
			set;
		}

		private string Shape_DefaultValue
		{
			get;
			set;
		}

		public bool? Shared
		{
			get;
			set;
		}

		private bool? Shared_DefaultValue
		{
			get;
			set;
		}

		public double? Snap
		{
			get;
			set;
		}

		private double? Snap_DefaultValue
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

		public Tooltip()
		{
			Highsoft.Web.Mvc.Charts.Animation animation = new Highsoft.Web.Mvc.Charts.Animation()
			{
				Enabled = true
			};
			Highsoft.Web.Mvc.Charts.Animation animation1 = animation;
			this.Animation_DefaultValue = animation;
			this.Animation = animation1;
			string str = "rgba(247,247,247,0.85)";
			string str1 = str;
			this.BackgroundColor_DefaultValue = str;
			this.BackgroundColor = str1;
			string str2 = "null";
			str1 = str2;
			this.BorderColor_DefaultValue = str2;
			this.BorderColor = str1;
			double? nullable = new double?((double)3);
			this.BorderRadius_DefaultValue = nullable;
			this.BorderRadius = nullable;
			nullable = new double?((double)1);
			this.BorderWidth_DefaultValue = nullable;
			this.BorderWidth = nullable;
			Hashtable hashtables = new Hashtable();
			Hashtable hashtables1 = hashtables;
			this.DateTimeLabelFormats_DefaultValue = hashtables;
			this.DateTimeLabelFormats = hashtables1;
			bool? nullable1 = new bool?(true);
			this.Enabled_DefaultValue = nullable1;
			this.Enabled = nullable1;
			nullable1 = new bool?(false);
			this.FollowPointer_DefaultValue = nullable1;
			this.FollowPointer = nullable1;
			nullable1 = new bool?(true);
			this.FollowTouchMove_DefaultValue = nullable1;
			this.FollowTouchMove = nullable1;
			string str3 = "false";
			str1 = str3;
			this.FooterFormat_DefaultValue = str3;
			this.FooterFormat = str1;
			string str4 = "";
			str1 = str4;
			this.Formatter_DefaultValue = str4;
			this.Formatter = str1;
			string str5 = "";
			str1 = str5;
			this.HeaderFormat_DefaultValue = str5;
			this.HeaderFormat = str1;
			nullable = new double?((double)500);
			this.HideDelay_DefaultValue = nullable;
			this.HideDelay = nullable;
			nullable = new double?((double)8);
			this.Padding_DefaultValue = nullable;
			this.Padding = nullable;
			string str6 = "<span style='color:{point.color}'>●</span> {series.name}: <b>{point.y}</b><br/>";
			str1 = str6;
			this.PointFormat_DefaultValue = str6;
			this.PointFormat = str1;
			string str7 = "";
			str1 = str7;
			this.PointFormatter_DefaultValue = str7;
			this.PointFormatter = str1;
			string str8 = "";
			str1 = str8;
			this.Positioner_DefaultValue = str8;
			this.Positioner = str1;
			Highsoft.Web.Mvc.Charts.Shadow shadow = new Highsoft.Web.Mvc.Charts.Shadow()
			{
				Enabled = false
			};
			Highsoft.Web.Mvc.Charts.Shadow shadow1 = shadow;
			this.Shadow_DefaultValue = shadow;
			this.Shadow = shadow1;
			string str9 = "callout";
			str1 = str9;
			this.Shape_DefaultValue = str9;
			this.Shape = str1;
			nullable1 = new bool?(false);
			this.Shared_DefaultValue = nullable1;
			this.Shared = nullable1;
			nullable = null;
			this.Snap_DefaultValue = nullable;
			this.Snap = nullable;
			nullable1 = new bool?(false);
			this.Split_DefaultValue = nullable1;
			this.Split = nullable1;
			Hashtable hashtables2 = new Hashtable()
			{
				{ "color", "#333333" },
				{ "cursor", "default" },
				{ "fontSize", "12px" },
				{ "pointerEvents", "none" },
				{ "whiteSpace", "nowrap" }
			};
			Hashtable hashtables3 = hashtables2;
			hashtables1 = hashtables3;
			this.Style_DefaultValue = hashtables3;
			this.Style = hashtables1;
			nullable1 = new bool?(false);
			this.UseHTML_DefaultValue = nullable1;
			this.UseHTML = nullable1;
			nullable = null;
			this.ValueDecimals_DefaultValue = nullable;
			this.ValueDecimals = nullable;
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
			if (this.Animation.IsDirty())
			{
				hashtables.Add("animation", this.Animation.ToJSON());
			}
			if (this.BackgroundColor != this.BackgroundColor_DefaultValue)
			{
				hashtables.Add("backgroundColor", this.BackgroundColor);
			}
			if (this.BorderColor != this.BorderColor_DefaultValue)
			{
				hashtables.Add("borderColor", this.BorderColor);
			}
			double? borderRadius = this.BorderRadius;
			double? borderRadiusDefaultValue = this.BorderRadius_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault() ? borderRadius.HasValue != borderRadiusDefaultValue.HasValue : true))
			{
				hashtables.Add("borderRadius", this.BorderRadius);
			}
			borderRadiusDefaultValue = this.BorderWidth;
			borderRadius = this.BorderWidth_DefaultValue;
			if ((borderRadiusDefaultValue.GetValueOrDefault() == borderRadius.GetValueOrDefault() ? borderRadiusDefaultValue.HasValue != borderRadius.HasValue : true))
			{
				hashtables.Add("borderWidth", this.BorderWidth);
			}
			if (this.DateTimeLabelFormats != this.DateTimeLabelFormats_DefaultValue)
			{
				hashtables.Add("dateTimeLabelFormats", this.DateTimeLabelFormats);
			}
			bool? enabled = this.Enabled;
			bool? enabledDefaultValue = this.Enabled_DefaultValue;
			if ((enabled.GetValueOrDefault() == enabledDefaultValue.GetValueOrDefault() ? enabled.HasValue != enabledDefaultValue.HasValue : true))
			{
				hashtables.Add("enabled", this.Enabled);
			}
			enabledDefaultValue = this.FollowPointer;
			enabled = this.FollowPointer_DefaultValue;
			if ((enabledDefaultValue.GetValueOrDefault() == enabled.GetValueOrDefault() ? enabledDefaultValue.HasValue != enabled.HasValue : true))
			{
				hashtables.Add("followPointer", this.FollowPointer);
			}
			enabled = this.FollowTouchMove;
			enabledDefaultValue = this.FollowTouchMove_DefaultValue;
			if ((enabled.GetValueOrDefault() == enabledDefaultValue.GetValueOrDefault() ? enabled.HasValue != enabledDefaultValue.HasValue : true))
			{
				hashtables.Add("followTouchMove", this.FollowTouchMove);
			}
			if (this.FooterFormat != this.FooterFormat_DefaultValue)
			{
				hashtables.Add("footerFormat", this.FooterFormat);
			}
			if (this.Formatter != this.Formatter_DefaultValue)
			{
				hashtables.Add("formatter", this.Formatter);
				Highcharts.AddFunction("TooltipFormatter.formatter", this.Formatter);
			}
			if (this.HeaderFormat != this.HeaderFormat_DefaultValue)
			{
				hashtables.Add("headerFormat", this.HeaderFormat);
			}
			borderRadius = this.HideDelay;
			borderRadiusDefaultValue = this.HideDelay_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault() ? borderRadius.HasValue != borderRadiusDefaultValue.HasValue : true))
			{
				hashtables.Add("hideDelay", this.HideDelay);
			}
			borderRadiusDefaultValue = this.Padding;
			borderRadius = this.Padding_DefaultValue;
			if ((borderRadiusDefaultValue.GetValueOrDefault() == borderRadius.GetValueOrDefault() ? borderRadiusDefaultValue.HasValue != borderRadius.HasValue : true))
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
				Highcharts.AddFunction("TooltipPointFormatter.pointFormatter", this.PointFormatter);
			}
			if (this.Positioner != this.Positioner_DefaultValue)
			{
				hashtables.Add("positioner", this.Positioner);
				Highcharts.AddFunction("TooltipPositioner.positioner", this.Positioner);
			}
			if (this.Shadow != this.Shadow_DefaultValue)
			{
				hashtables.Add("shadow", this.Shadow);
			}
			if (this.Shape != this.Shape_DefaultValue)
			{
				hashtables.Add("shape", this.Shape);
			}
			enabledDefaultValue = this.Shared;
			enabled = this.Shared_DefaultValue;
			if ((enabledDefaultValue.GetValueOrDefault() == enabled.GetValueOrDefault() ? enabledDefaultValue.HasValue != enabled.HasValue : true))
			{
				hashtables.Add("shared", this.Shared);
			}
			borderRadius = this.Snap;
			borderRadiusDefaultValue = this.Snap_DefaultValue;
			if ((borderRadius.GetValueOrDefault() == borderRadiusDefaultValue.GetValueOrDefault() ? borderRadius.HasValue != borderRadiusDefaultValue.HasValue : true))
			{
				hashtables.Add("snap", this.Snap);
			}
			enabled = this.Split;
			enabledDefaultValue = this.Split_DefaultValue;
			if ((enabled.GetValueOrDefault() == enabledDefaultValue.GetValueOrDefault() ? enabled.HasValue != enabledDefaultValue.HasValue : true))
			{
				hashtables.Add("split", this.Split);
			}
			if (this.Style != this.Style_DefaultValue)
			{
				hashtables.Add("style", this.Style);
			}
			enabledDefaultValue = this.UseHTML;
			enabled = this.UseHTML_DefaultValue;
			if ((enabledDefaultValue.GetValueOrDefault() == enabled.GetValueOrDefault() ? enabledDefaultValue.HasValue != enabled.HasValue : true))
			{
				hashtables.Add("useHTML", this.UseHTML);
			}
			borderRadiusDefaultValue = this.ValueDecimals;
			borderRadius = this.ValueDecimals_DefaultValue;
			if ((borderRadiusDefaultValue.GetValueOrDefault() == borderRadius.GetValueOrDefault() ? borderRadiusDefaultValue.HasValue != borderRadius.HasValue : true))
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