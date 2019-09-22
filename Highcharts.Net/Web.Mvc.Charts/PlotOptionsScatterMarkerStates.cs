using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsScatterMarkerStates : BaseObject
	{
		public PlotOptionsScatterMarkerStatesHover Hover
		{
			get;
			set;
		}

		private PlotOptionsScatterMarkerStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsScatterMarkerStatesSelect Select
		{
			get;
			set;
		}

		private PlotOptionsScatterMarkerStatesSelect Select_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsScatterMarkerStates()
		{
			PlotOptionsScatterMarkerStatesHover plotOptionsScatterMarkerStatesHover = new PlotOptionsScatterMarkerStatesHover();
			PlotOptionsScatterMarkerStatesHover plotOptionsScatterMarkerStatesHover1 = plotOptionsScatterMarkerStatesHover;
			this.Hover_DefaultValue = plotOptionsScatterMarkerStatesHover;
			this.Hover = plotOptionsScatterMarkerStatesHover1;
			PlotOptionsScatterMarkerStatesSelect plotOptionsScatterMarkerStatesSelect = new PlotOptionsScatterMarkerStatesSelect();
			PlotOptionsScatterMarkerStatesSelect plotOptionsScatterMarkerStatesSelect1 = plotOptionsScatterMarkerStatesSelect;
			this.Select_DefaultValue = plotOptionsScatterMarkerStatesSelect;
			this.Select = plotOptionsScatterMarkerStatesSelect1;
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