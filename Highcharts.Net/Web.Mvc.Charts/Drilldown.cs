using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class Drilldown : BaseObject
	{
		public Hashtable ActiveAxisLabelStyle
		{
			get;
			set;
		}

		private Hashtable ActiveAxisLabelStyle_DefaultValue
		{
			get;
			set;
		}

		public Hashtable ActiveDataLabelStyle
		{
			get;
			set;
		}

		private Hashtable ActiveDataLabelStyle_DefaultValue
		{
			get;
			set;
		}

		public bool? AllowPointDrilldown
		{
			get;
			set;
		}

		private bool? AllowPointDrilldown_DefaultValue
		{
			get;
			set;
		}

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

		public DrilldownDrillUpButton DrillUpButton
		{
			get;
			set;
		}

		private DrilldownDrillUpButton DrillUpButton_DefaultValue
		{
			get;
			set;
		}

		public List<Highsoft.Web.Mvc.Charts.Series> Series
		{
			get;
			set;
		}

		private List<Highsoft.Web.Mvc.Charts.Series> Series_DefaultValue
		{
			get;
			set;
		}

		public Drilldown()
		{
			Hashtable hashtables = new Hashtable()
			{
				{ "cursor", "pointer" },
				{ "color", "#003399" },
				{ "fontWeight", "bold" },
				{ "textDecoration", "underline" }
			};
			Hashtable hashtables1 = hashtables;
			Hashtable hashtables2 = hashtables1;
			this.ActiveAxisLabelStyle_DefaultValue = hashtables1;
			this.ActiveAxisLabelStyle = hashtables2;
			hashtables = new Hashtable()
			{
				{ "cursor", "pointer" },
				{ "color", "#003399" },
				{ "fontWeight", "bold" },
				{ "textDecoration", "underline" }
			};
			Hashtable hashtables3 = hashtables;
			hashtables2 = hashtables3;
			this.ActiveDataLabelStyle_DefaultValue = hashtables3;
			this.ActiveDataLabelStyle = hashtables2;
			bool? nullable = new bool?(true);
			this.AllowPointDrilldown_DefaultValue = nullable;
			this.AllowPointDrilldown = nullable;
			Highsoft.Web.Mvc.Charts.Animation animation = new Highsoft.Web.Mvc.Charts.Animation()
			{
				Enabled = true
			};
			Highsoft.Web.Mvc.Charts.Animation animation1 = animation;
			this.Animation_DefaultValue = animation;
			this.Animation = animation1;
			DrilldownDrillUpButton drilldownDrillUpButton = new DrilldownDrillUpButton();
			DrilldownDrillUpButton drilldownDrillUpButton1 = drilldownDrillUpButton;
			this.DrillUpButton_DefaultValue = drilldownDrillUpButton;
			this.DrillUpButton = drilldownDrillUpButton1;
			object obj = null;
			List<Highsoft.Web.Mvc.Charts.Series> series = (List<Highsoft.Web.Mvc.Charts.Series>)obj;
			this.Series_DefaultValue = (List<Highsoft.Web.Mvc.Charts.Series>)obj;
			this.Series = series;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.ActiveAxisLabelStyle != this.ActiveAxisLabelStyle_DefaultValue)
			{
				hashtables.Add("activeAxisLabelStyle", this.ActiveAxisLabelStyle);
			}
			if (this.ActiveDataLabelStyle != this.ActiveDataLabelStyle_DefaultValue)
			{
				hashtables.Add("activeDataLabelStyle", this.ActiveDataLabelStyle);
			}
			bool? allowPointDrilldown = this.AllowPointDrilldown;
			bool? allowPointDrilldownDefaultValue = this.AllowPointDrilldown_DefaultValue;
			if ((allowPointDrilldown.GetValueOrDefault() == allowPointDrilldownDefaultValue.GetValueOrDefault() ? allowPointDrilldown.HasValue != allowPointDrilldownDefaultValue.HasValue : true))
			{
				hashtables.Add("allowPointDrilldown", this.AllowPointDrilldown);
			}
			if (this.Animation.IsDirty())
			{
				hashtables.Add("animation", this.Animation.ToJSON());
			}
			if (this.DrillUpButton.IsDirty())
			{
				hashtables.Add("drillUpButton", this.DrillUpButton.ToHashtable());
			}
			if (this.Series != this.Series_DefaultValue)
			{
				hashtables.Add("series", this.Series);
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