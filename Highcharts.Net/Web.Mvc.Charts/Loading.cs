using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class Loading : BaseObject
	{
		public double? HideDuration
		{
			get;
			set;
		}

		private double? HideDuration_DefaultValue
		{
			get;
			set;
		}

		public Hashtable LabelStyle
		{
			get;
			set;
		}

		private Hashtable LabelStyle_DefaultValue
		{
			get;
			set;
		}

		public double? ShowDuration
		{
			get;
			set;
		}

		private double? ShowDuration_DefaultValue
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

		public Loading()
		{
			double? nullable = new double?((double)100);
			this.HideDuration_DefaultValue = nullable;
			this.HideDuration = nullable;
			Hashtable hashtables = new Hashtable()
			{
				{ "fontWeight", "bold" },
				{ "position", "relative" },
				{ "top", "45%" }
			};
			Hashtable hashtables1 = hashtables;
			Hashtable hashtables2 = hashtables1;
			this.LabelStyle_DefaultValue = hashtables1;
			this.LabelStyle = hashtables2;
			nullable = new double?((double)100);
			this.ShowDuration_DefaultValue = nullable;
			this.ShowDuration = nullable;
			hashtables = new Hashtable()
			{
				{ "position", "absolute" },
				{ "backgroundColor", "#ffffff" },
				{ "opacity", 0.5 },
				{ "textAlign", "center" }
			};
			Hashtable hashtables3 = hashtables;
			hashtables2 = hashtables3;
			this.Style_DefaultValue = hashtables3;
			this.Style = hashtables2;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			double? hideDuration = this.HideDuration;
			double? hideDurationDefaultValue = this.HideDuration_DefaultValue;
			if ((hideDuration.GetValueOrDefault() == hideDurationDefaultValue.GetValueOrDefault() ? hideDuration.HasValue != hideDurationDefaultValue.HasValue : true))
			{
				hashtables.Add("hideDuration", this.HideDuration);
			}
			if (this.LabelStyle != this.LabelStyle_DefaultValue)
			{
				hashtables.Add("labelStyle", this.LabelStyle);
			}
			hideDurationDefaultValue = this.ShowDuration;
			hideDuration = this.ShowDuration_DefaultValue;
			if ((hideDurationDefaultValue.GetValueOrDefault() == hideDuration.GetValueOrDefault() ? hideDurationDefaultValue.HasValue != hideDuration.HasValue : true))
			{
				hashtables.Add("showDuration", this.ShowDuration);
			}
			if (this.Style != this.Style_DefaultValue)
			{
				hashtables.Add("style", this.Style);
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