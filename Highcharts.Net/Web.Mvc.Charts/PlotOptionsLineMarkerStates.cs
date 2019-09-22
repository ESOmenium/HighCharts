using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsLineMarkerStates : BaseObject
	{
		public PlotOptionsLineMarkerStatesHover Hover
		{
			get;
			set;
		}

		private PlotOptionsLineMarkerStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsLineMarkerStatesSelect Select
		{
			get;
			set;
		}

		private PlotOptionsLineMarkerStatesSelect Select_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsLineMarkerStates()
		{
			PlotOptionsLineMarkerStatesHover plotOptionsLineMarkerStatesHover = new PlotOptionsLineMarkerStatesHover();
			PlotOptionsLineMarkerStatesHover plotOptionsLineMarkerStatesHover1 = plotOptionsLineMarkerStatesHover;
			this.Hover_DefaultValue = plotOptionsLineMarkerStatesHover;
			this.Hover = plotOptionsLineMarkerStatesHover1;
			PlotOptionsLineMarkerStatesSelect plotOptionsLineMarkerStatesSelect = new PlotOptionsLineMarkerStatesSelect();
			PlotOptionsLineMarkerStatesSelect plotOptionsLineMarkerStatesSelect1 = plotOptionsLineMarkerStatesSelect;
			this.Select_DefaultValue = plotOptionsLineMarkerStatesSelect;
			this.Select = plotOptionsLineMarkerStatesSelect1;
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