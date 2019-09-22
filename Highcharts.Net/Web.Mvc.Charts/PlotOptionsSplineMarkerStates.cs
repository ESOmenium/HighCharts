using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsSplineMarkerStates : BaseObject
	{
		public PlotOptionsSplineMarkerStatesHover Hover
		{
			get;
			set;
		}

		private PlotOptionsSplineMarkerStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsSplineMarkerStatesSelect Select
		{
			get;
			set;
		}

		private PlotOptionsSplineMarkerStatesSelect Select_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsSplineMarkerStates()
		{
			PlotOptionsSplineMarkerStatesHover plotOptionsSplineMarkerStatesHover = new PlotOptionsSplineMarkerStatesHover();
			PlotOptionsSplineMarkerStatesHover plotOptionsSplineMarkerStatesHover1 = plotOptionsSplineMarkerStatesHover;
			this.Hover_DefaultValue = plotOptionsSplineMarkerStatesHover;
			this.Hover = plotOptionsSplineMarkerStatesHover1;
			PlotOptionsSplineMarkerStatesSelect plotOptionsSplineMarkerStatesSelect = new PlotOptionsSplineMarkerStatesSelect();
			PlotOptionsSplineMarkerStatesSelect plotOptionsSplineMarkerStatesSelect1 = plotOptionsSplineMarkerStatesSelect;
			this.Select_DefaultValue = plotOptionsSplineMarkerStatesSelect;
			this.Select = plotOptionsSplineMarkerStatesSelect1;
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