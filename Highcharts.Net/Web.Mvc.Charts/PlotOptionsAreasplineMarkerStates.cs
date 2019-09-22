using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsAreasplineMarkerStates : BaseObject
	{
		public PlotOptionsAreasplineMarkerStatesHover Hover
		{
			get;
			set;
		}

		private PlotOptionsAreasplineMarkerStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsAreasplineMarkerStatesSelect Select
		{
			get;
			set;
		}

		private PlotOptionsAreasplineMarkerStatesSelect Select_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsAreasplineMarkerStates()
		{
			PlotOptionsAreasplineMarkerStatesHover plotOptionsAreasplineMarkerStatesHover = new PlotOptionsAreasplineMarkerStatesHover();
			PlotOptionsAreasplineMarkerStatesHover plotOptionsAreasplineMarkerStatesHover1 = plotOptionsAreasplineMarkerStatesHover;
			this.Hover_DefaultValue = plotOptionsAreasplineMarkerStatesHover;
			this.Hover = plotOptionsAreasplineMarkerStatesHover1;
			PlotOptionsAreasplineMarkerStatesSelect plotOptionsAreasplineMarkerStatesSelect = new PlotOptionsAreasplineMarkerStatesSelect();
			PlotOptionsAreasplineMarkerStatesSelect plotOptionsAreasplineMarkerStatesSelect1 = plotOptionsAreasplineMarkerStatesSelect;
			this.Select_DefaultValue = plotOptionsAreasplineMarkerStatesSelect;
			this.Select = plotOptionsAreasplineMarkerStatesSelect1;
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