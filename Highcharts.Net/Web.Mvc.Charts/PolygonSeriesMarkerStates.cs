using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PolygonSeriesMarkerStates : BaseObject
	{
		public PolygonSeriesMarkerStatesHover Hover
		{
			get;
			set;
		}

		private PolygonSeriesMarkerStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public PolygonSeriesMarkerStatesSelect Select
		{
			get;
			set;
		}

		private PolygonSeriesMarkerStatesSelect Select_DefaultValue
		{
			get;
			set;
		}

		public PolygonSeriesMarkerStates()
		{
			PolygonSeriesMarkerStatesHover polygonSeriesMarkerStatesHover = new PolygonSeriesMarkerStatesHover();
			PolygonSeriesMarkerStatesHover polygonSeriesMarkerStatesHover1 = polygonSeriesMarkerStatesHover;
			this.Hover_DefaultValue = polygonSeriesMarkerStatesHover;
			this.Hover = polygonSeriesMarkerStatesHover1;
			PolygonSeriesMarkerStatesSelect polygonSeriesMarkerStatesSelect = new PolygonSeriesMarkerStatesSelect();
			PolygonSeriesMarkerStatesSelect polygonSeriesMarkerStatesSelect1 = polygonSeriesMarkerStatesSelect;
			this.Select_DefaultValue = polygonSeriesMarkerStatesSelect;
			this.Select = polygonSeriesMarkerStatesSelect1;
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