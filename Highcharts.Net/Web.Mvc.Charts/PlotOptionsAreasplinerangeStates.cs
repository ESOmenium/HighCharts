using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsAreasplinerangeStates : BaseObject
	{
		public PlotOptionsAreasplinerangeStatesHover Hover
		{
			get;
			set;
		}

		private PlotOptionsAreasplinerangeStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsAreasplinerangeStates()
		{
			PlotOptionsAreasplinerangeStatesHover plotOptionsAreasplinerangeStatesHover = new PlotOptionsAreasplinerangeStatesHover();
			PlotOptionsAreasplinerangeStatesHover plotOptionsAreasplinerangeStatesHover1 = plotOptionsAreasplinerangeStatesHover;
			this.Hover_DefaultValue = plotOptionsAreasplinerangeStatesHover;
			this.Hover = plotOptionsAreasplinerangeStatesHover1;
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