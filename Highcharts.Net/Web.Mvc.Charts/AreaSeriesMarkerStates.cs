using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class AreaSeriesMarkerStates : BaseObject
	{
		public AreaSeriesMarkerStatesHover Hover
		{
			get;
			set;
		}

		private AreaSeriesMarkerStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public AreaSeriesMarkerStatesSelect Select
		{
			get;
			set;
		}

		private AreaSeriesMarkerStatesSelect Select_DefaultValue
		{
			get;
			set;
		}

		public AreaSeriesMarkerStates()
		{
			AreaSeriesMarkerStatesHover areaSeriesMarkerStatesHover = new AreaSeriesMarkerStatesHover();
			AreaSeriesMarkerStatesHover areaSeriesMarkerStatesHover1 = areaSeriesMarkerStatesHover;
			this.Hover_DefaultValue = areaSeriesMarkerStatesHover;
			this.Hover = areaSeriesMarkerStatesHover1;
			AreaSeriesMarkerStatesSelect areaSeriesMarkerStatesSelect = new AreaSeriesMarkerStatesSelect();
			AreaSeriesMarkerStatesSelect areaSeriesMarkerStatesSelect1 = areaSeriesMarkerStatesSelect;
			this.Select_DefaultValue = areaSeriesMarkerStatesSelect;
			this.Select = areaSeriesMarkerStatesSelect1;
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