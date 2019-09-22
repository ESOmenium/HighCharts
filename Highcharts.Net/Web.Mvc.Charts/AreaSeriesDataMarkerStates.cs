using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class AreaSeriesDataMarkerStates : BaseObject
	{
		public AreaSeriesDataMarkerStatesHover Hover
		{
			get;
			set;
		}

		private AreaSeriesDataMarkerStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public AreaSeriesDataMarkerStatesSelect Select
		{
			get;
			set;
		}

		private AreaSeriesDataMarkerStatesSelect Select_DefaultValue
		{
			get;
			set;
		}

		public AreaSeriesDataMarkerStates()
		{
			AreaSeriesDataMarkerStatesHover areaSeriesDataMarkerStatesHover = new AreaSeriesDataMarkerStatesHover();
			AreaSeriesDataMarkerStatesHover areaSeriesDataMarkerStatesHover1 = areaSeriesDataMarkerStatesHover;
			this.Hover_DefaultValue = areaSeriesDataMarkerStatesHover;
			this.Hover = areaSeriesDataMarkerStatesHover1;
			AreaSeriesDataMarkerStatesSelect areaSeriesDataMarkerStatesSelect = new AreaSeriesDataMarkerStatesSelect();
			AreaSeriesDataMarkerStatesSelect areaSeriesDataMarkerStatesSelect1 = areaSeriesDataMarkerStatesSelect;
			this.Select_DefaultValue = areaSeriesDataMarkerStatesSelect;
			this.Select = areaSeriesDataMarkerStatesSelect1;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.Hover.IsDirty())
			{
				hashtables.Add("hover", this.Hover.ToHashtable());
			}
			if (this.Select.IsDirty())
			{
				hashtables.Add("select", this.Select.ToHashtable());
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