using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsBubbleMarkerStates : BaseObject
	{
		public PlotOptionsBubbleMarkerStatesHover Hover
		{
			get;
			set;
		}

		private PlotOptionsBubbleMarkerStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsBubbleMarkerStatesSelect Select
		{
			get;
			set;
		}

		private PlotOptionsBubbleMarkerStatesSelect Select_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsBubbleMarkerStates()
		{
			PlotOptionsBubbleMarkerStatesHover plotOptionsBubbleMarkerStatesHover = new PlotOptionsBubbleMarkerStatesHover();
			PlotOptionsBubbleMarkerStatesHover plotOptionsBubbleMarkerStatesHover1 = plotOptionsBubbleMarkerStatesHover;
			this.Hover_DefaultValue = plotOptionsBubbleMarkerStatesHover;
			this.Hover = plotOptionsBubbleMarkerStatesHover1;
			PlotOptionsBubbleMarkerStatesSelect plotOptionsBubbleMarkerStatesSelect = new PlotOptionsBubbleMarkerStatesSelect();
			PlotOptionsBubbleMarkerStatesSelect plotOptionsBubbleMarkerStatesSelect1 = plotOptionsBubbleMarkerStatesSelect;
			this.Select_DefaultValue = plotOptionsBubbleMarkerStatesSelect;
			this.Select = plotOptionsBubbleMarkerStatesSelect1;
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