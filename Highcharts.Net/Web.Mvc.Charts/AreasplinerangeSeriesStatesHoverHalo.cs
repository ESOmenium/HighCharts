using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class AreasplinerangeSeriesStatesHoverHalo : BaseObject
	{
		public object Attributes
		{
			get;
			set;
		}

		private object Attributes_DefaultValue
		{
			get;
			set;
		}

		public double? Opacity
		{
			get;
			set;
		}

		private double? Opacity_DefaultValue
		{
			get;
			set;
		}

		public double? Size
		{
			get;
			set;
		}

		private double? Size_DefaultValue
		{
			get;
			set;
		}

		public AreasplinerangeSeriesStatesHoverHalo()
		{
			string str = "";
			object obj = str;
			this.Attributes_DefaultValue = str;
			this.Attributes = obj;
			double? nullable = new double?(0.25);
			this.Opacity_DefaultValue = nullable;
			this.Opacity = nullable;
			nullable = new double?((double)10);
			this.Size_DefaultValue = nullable;
			this.Size = nullable;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.Attributes != this.Attributes_DefaultValue)
			{
				hashtables.Add("attributes", this.Attributes);
			}
			double? opacity = this.Opacity;
			double? opacityDefaultValue = this.Opacity_DefaultValue;
			if ((opacity.GetValueOrDefault() == opacityDefaultValue.GetValueOrDefault() ? opacity.HasValue != opacityDefaultValue.HasValue : true))
			{
				hashtables.Add("opacity", this.Opacity);
			}
			opacityDefaultValue = this.Size;
			opacity = this.Size_DefaultValue;
			if ((opacityDefaultValue.GetValueOrDefault() == opacity.GetValueOrDefault() ? opacityDefaultValue.HasValue != opacity.HasValue : true))
			{
				hashtables.Add("size", this.Size);
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