using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsAreaMarkerStates : BaseObject
	{
		public PlotOptionsAreaMarkerStatesHover Hover
		{
			get;
			set;
		}

		private PlotOptionsAreaMarkerStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsAreaMarkerStatesSelect Select
		{
			get;
			set;
		}

		private PlotOptionsAreaMarkerStatesSelect Select_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsAreaMarkerStates()
		{
			PlotOptionsAreaMarkerStatesHover plotOptionsAreaMarkerStatesHover = new PlotOptionsAreaMarkerStatesHover();
			PlotOptionsAreaMarkerStatesHover plotOptionsAreaMarkerStatesHover1 = plotOptionsAreaMarkerStatesHover;
			this.Hover_DefaultValue = plotOptionsAreaMarkerStatesHover;
			this.Hover = plotOptionsAreaMarkerStatesHover1;
			PlotOptionsAreaMarkerStatesSelect plotOptionsAreaMarkerStatesSelect = new PlotOptionsAreaMarkerStatesSelect();
			PlotOptionsAreaMarkerStatesSelect plotOptionsAreaMarkerStatesSelect1 = plotOptionsAreaMarkerStatesSelect;
			this.Select_DefaultValue = plotOptionsAreaMarkerStatesSelect;
			this.Select = plotOptionsAreaMarkerStatesSelect1;
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