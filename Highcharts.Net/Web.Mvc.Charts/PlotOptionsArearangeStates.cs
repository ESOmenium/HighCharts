using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsArearangeStates : BaseObject
	{
		public PlotOptionsArearangeStatesHover Hover
		{
			get;
			set;
		}

		private PlotOptionsArearangeStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsArearangeStates()
		{
			PlotOptionsArearangeStatesHover plotOptionsArearangeStatesHover = new PlotOptionsArearangeStatesHover();
			PlotOptionsArearangeStatesHover plotOptionsArearangeStatesHover1 = plotOptionsArearangeStatesHover;
			this.Hover_DefaultValue = plotOptionsArearangeStatesHover;
			this.Hover = plotOptionsArearangeStatesHover1;
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