using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsSeriesMarkerStates : BaseObject
	{
		public PlotOptionsSeriesMarkerStatesHover Hover
		{
			get;
			set;
		}

		private PlotOptionsSeriesMarkerStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsSeriesMarkerStatesSelect Select
		{
			get;
			set;
		}

		private PlotOptionsSeriesMarkerStatesSelect Select_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsSeriesMarkerStates()
		{
			PlotOptionsSeriesMarkerStatesHover plotOptionsSeriesMarkerStatesHover = new PlotOptionsSeriesMarkerStatesHover();
			PlotOptionsSeriesMarkerStatesHover plotOptionsSeriesMarkerStatesHover1 = plotOptionsSeriesMarkerStatesHover;
			this.Hover_DefaultValue = plotOptionsSeriesMarkerStatesHover;
			this.Hover = plotOptionsSeriesMarkerStatesHover1;
			PlotOptionsSeriesMarkerStatesSelect plotOptionsSeriesMarkerStatesSelect = new PlotOptionsSeriesMarkerStatesSelect();
			PlotOptionsSeriesMarkerStatesSelect plotOptionsSeriesMarkerStatesSelect1 = plotOptionsSeriesMarkerStatesSelect;
			this.Select_DefaultValue = plotOptionsSeriesMarkerStatesSelect;
			this.Select = plotOptionsSeriesMarkerStatesSelect1;
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