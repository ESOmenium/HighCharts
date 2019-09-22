using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PolygonSeriesDataMarkerStates : BaseObject
	{
		public PolygonSeriesDataMarkerStatesHover Hover
		{
			get;
			set;
		}

		private PolygonSeriesDataMarkerStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public PolygonSeriesDataMarkerStatesSelect Select
		{
			get;
			set;
		}

		private PolygonSeriesDataMarkerStatesSelect Select_DefaultValue
		{
			get;
			set;
		}

		public PolygonSeriesDataMarkerStates()
		{
			PolygonSeriesDataMarkerStatesHover polygonSeriesDataMarkerStatesHover = new PolygonSeriesDataMarkerStatesHover();
			PolygonSeriesDataMarkerStatesHover polygonSeriesDataMarkerStatesHover1 = polygonSeriesDataMarkerStatesHover;
			this.Hover_DefaultValue = polygonSeriesDataMarkerStatesHover;
			this.Hover = polygonSeriesDataMarkerStatesHover1;
			PolygonSeriesDataMarkerStatesSelect polygonSeriesDataMarkerStatesSelect = new PolygonSeriesDataMarkerStatesSelect();
			PolygonSeriesDataMarkerStatesSelect polygonSeriesDataMarkerStatesSelect1 = polygonSeriesDataMarkerStatesSelect;
			this.Select_DefaultValue = polygonSeriesDataMarkerStatesSelect;
			this.Select = polygonSeriesDataMarkerStatesSelect1;
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