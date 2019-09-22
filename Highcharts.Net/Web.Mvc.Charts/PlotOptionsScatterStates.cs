using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsScatterStates : BaseObject
	{
		public PlotOptionsScatterStatesHover Hover
		{
			get;
			set;
		}

		private PlotOptionsScatterStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsScatterStates()
		{
			PlotOptionsScatterStatesHover plotOptionsScatterStatesHover = new PlotOptionsScatterStatesHover();
			PlotOptionsScatterStatesHover plotOptionsScatterStatesHover1 = plotOptionsScatterStatesHover;
			this.Hover_DefaultValue = plotOptionsScatterStatesHover;
			this.Hover = plotOptionsScatterStatesHover1;
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