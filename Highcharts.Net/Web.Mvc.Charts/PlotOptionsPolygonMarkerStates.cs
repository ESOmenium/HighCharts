using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsPolygonMarkerStates : BaseObject
	{
		public PlotOptionsPolygonMarkerStatesHover Hover
		{
			get;
			set;
		}

		private PlotOptionsPolygonMarkerStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsPolygonMarkerStatesSelect Select
		{
			get;
			set;
		}

		private PlotOptionsPolygonMarkerStatesSelect Select_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsPolygonMarkerStates()
		{
			PlotOptionsPolygonMarkerStatesHover plotOptionsPolygonMarkerStatesHover = new PlotOptionsPolygonMarkerStatesHover();
			PlotOptionsPolygonMarkerStatesHover plotOptionsPolygonMarkerStatesHover1 = plotOptionsPolygonMarkerStatesHover;
			this.Hover_DefaultValue = plotOptionsPolygonMarkerStatesHover;
			this.Hover = plotOptionsPolygonMarkerStatesHover1;
			PlotOptionsPolygonMarkerStatesSelect plotOptionsPolygonMarkerStatesSelect = new PlotOptionsPolygonMarkerStatesSelect();
			PlotOptionsPolygonMarkerStatesSelect plotOptionsPolygonMarkerStatesSelect1 = plotOptionsPolygonMarkerStatesSelect;
			this.Select_DefaultValue = plotOptionsPolygonMarkerStatesSelect;
			this.Select = plotOptionsPolygonMarkerStatesSelect1;
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