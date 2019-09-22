using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class ZAxisLabels : BaseObject
	{
		public ZAxisLabelsAlign Align
		{
			get;
			set;
		}

		private ZAxisLabelsAlign Align_DefaultValue
		{
			get;
			set;
		}

		public List<double> AutoRotation
		{
			get;
			set;
		}

		private List<double> AutoRotation_DefaultValue
		{
			get;
			set;
		}

		public double? AutoRotationLimit
		{
			get;
			set;
		}

		private double? AutoRotationLimit_DefaultValue
		{
			get;
			set;
		}

		public double? Distance
		{
			get;
			set;
		}

		private double? Distance_DefaultValue
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

		public bool? ReserveSpace
		{
			get;
			set;
		}

		private bool? ReserveSpace_DefaultValue
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

		public double? StaggerLines
		{
			get;
			set;
		}

		private double? StaggerLines_DefaultValue
		{
			get;
			set;
		}

		public double? Step
		{
			get;
			set;
		}

		private double? Step_DefaultValue
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

		public ZAxisLabels()
		{
			int num = 0;
			ZAxisLabelsAlign zAxisLabelsAlign = (ZAxisLabelsAlign)num;
			this.Align_DefaultValue = (ZAxisLabelsAlign)num;
			this.Align = zAxisLabelsAlign;
			List<double> nums = new List<double>()
			{
				-45
			};
			List<double> nums1 = nums;
			this.AutoRotation_DefaultValue = nums;
			this.AutoRotation = nums1;
			double? nullable = new double?((double)80);
			this.AutoRotationLimit_DefaultValue = nullable;
			this.AutoRotationLimit = nullable;
			nullable = new double?((double)15);
			this.Distance_DefaultValue = nullable;
			this.Distance = nullable;
			bool? nullable1 = new bool?(true);
			this.Enabled_DefaultValue = nullable1;
			this.Enabled = nullable1;
			string str = "{value}";
			string str1 = str;
			this.Format_DefaultValue = str;
			this.Format = str1;
			string str2 = "";
			str1 = str2;
			this.Formatter_DefaultValue = str2;
			this.Formatter = str1;
			nullable = new double?((double)5);
			this.Padding_DefaultValue = nullable;
			this.Padding = nullable;
			nullable1 = new bool?(true);
			this.ReserveSpace_DefaultValue = nullable1;
			this.ReserveSpace = nullable1;
			nullable = new double?(0);
			this.Rotation_DefaultValue = nullable;
			this.Rotation = nullable;
			nullable = null;
			this.StaggerLines_DefaultValue = nullable;
			this.StaggerLines = nullable;
			nullable = null;
			this.Step_DefaultValue = nullable;
			this.Step = nullable;
			Hashtable hashtables = new Hashtable()
			{
				{ "color", "#666666" },
				{ "cursor", "default" },
				{ "fontSize", "11px" }
			};
			Hashtable hashtables1 = hashtables;
			Hashtable hashtables2 = hashtables1;
			this.Style_DefaultValue = hashtables1;
			this.Style = hashtables2;
			nullable1 = new bool?(false);
			this.UseHTML_DefaultValue = nullable1;
			this.UseHTML = nullable1;
			nullable = new double?(0);
			this.X_DefaultValue = nullable;
			this.X = nullable;
			nullable = null;
			this.Y_DefaultValue = nullable;
			this.Y = nullable;
			nullable = new double?((double)7);
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
			if (this.Align != this.Align_DefaultValue)
			{
				ZAxisLabelsAlign align = this.Align;
				hashtables.Add("align", Highcharts.FirstCharacterToLower(align.ToString()));
			}
			if (this.AutoRotation != this.AutoRotation_DefaultValue)
			{
				hashtables.Add("autoRotation", this.AutoRotation);
			}
			double? autoRotationLimit = this.AutoRotationLimit;
			double? autoRotationLimitDefaultValue = this.AutoRotationLimit_DefaultValue;
			if ((autoRotationLimit.GetValueOrDefault() == autoRotationLimitDefaultValue.GetValueOrDefault() ? autoRotationLimit.HasValue != autoRotationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("autoRotationLimit", this.AutoRotationLimit);
			}
			autoRotationLimitDefaultValue = this.Distance;
			autoRotationLimit = this.Distance_DefaultValue;
			if ((autoRotationLimitDefaultValue.GetValueOrDefault() == autoRotationLimit.GetValueOrDefault() ? autoRotationLimitDefaultValue.HasValue != autoRotationLimit.HasValue : true))
			{
				hashtables.Add("distance", this.Distance);
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
				Highcharts.AddFunction("ZAxisLabelsFormatter.formatter", this.Formatter);
			}
			autoRotationLimit = this.Padding;
			autoRotationLimitDefaultValue = this.Padding_DefaultValue;
			if ((autoRotationLimit.GetValueOrDefault() == autoRotationLimitDefaultValue.GetValueOrDefault() ? autoRotationLimit.HasValue != autoRotationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("padding", this.Padding);
			}
			enabledDefaultValue = this.ReserveSpace;
			enabled = this.ReserveSpace_DefaultValue;
			if ((enabledDefaultValue.GetValueOrDefault() == enabled.GetValueOrDefault() ? enabledDefaultValue.HasValue != enabled.HasValue : true))
			{
				hashtables.Add("reserveSpace", this.ReserveSpace);
			}
			autoRotationLimitDefaultValue = this.Rotation;
			autoRotationLimit = this.Rotation_DefaultValue;
			if ((autoRotationLimitDefaultValue.GetValueOrDefault() == autoRotationLimit.GetValueOrDefault() ? autoRotationLimitDefaultValue.HasValue != autoRotationLimit.HasValue : true))
			{
				hashtables.Add("rotation", this.Rotation);
			}
			autoRotationLimit = this.StaggerLines;
			autoRotationLimitDefaultValue = this.StaggerLines_DefaultValue;
			if ((autoRotationLimit.GetValueOrDefault() == autoRotationLimitDefaultValue.GetValueOrDefault() ? autoRotationLimit.HasValue != autoRotationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("staggerLines", this.StaggerLines);
			}
			autoRotationLimitDefaultValue = this.Step;
			autoRotationLimit = this.Step_DefaultValue;
			if ((autoRotationLimitDefaultValue.GetValueOrDefault() == autoRotationLimit.GetValueOrDefault() ? autoRotationLimitDefaultValue.HasValue != autoRotationLimit.HasValue : true))
			{
				hashtables.Add("step", this.Step);
			}
			if (this.Style != this.Style_DefaultValue)
			{
				hashtables.Add("style", this.Style);
			}
			enabled = this.UseHTML;
			enabledDefaultValue = this.UseHTML_DefaultValue;
			if ((enabled.GetValueOrDefault() == enabledDefaultValue.GetValueOrDefault() ? enabled.HasValue != enabledDefaultValue.HasValue : true))
			{
				hashtables.Add("useHTML", this.UseHTML);
			}
			autoRotationLimit = this.X;
			autoRotationLimitDefaultValue = this.X_DefaultValue;
			if ((autoRotationLimit.GetValueOrDefault() == autoRotationLimitDefaultValue.GetValueOrDefault() ? autoRotationLimit.HasValue != autoRotationLimitDefaultValue.HasValue : true))
			{
				hashtables.Add("x", this.X);
			}
			autoRotationLimitDefaultValue = this.Y;
			autoRotationLimit = this.Y_DefaultValue;
			if ((autoRotationLimitDefaultValue.GetValueOrDefault() == autoRotationLimit.GetValueOrDefault() ? autoRotationLimitDefaultValue.HasValue != autoRotationLimit.HasValue : true))
			{
				hashtables.Add("y", this.Y);
			}
			autoRotationLimit = this.ZIndex;
			autoRotationLimitDefaultValue = this.ZIndex_DefaultValue;
			if ((autoRotationLimit.GetValueOrDefault() == autoRotationLimitDefaultValue.GetValueOrDefault() ? autoRotationLimit.HasValue != autoRotationLimitDefaultValue.HasValue : true))
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