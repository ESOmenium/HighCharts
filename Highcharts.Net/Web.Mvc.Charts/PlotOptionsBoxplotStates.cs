using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsBoxplotStates : BaseObject
	{
		public PlotOptionsBoxplotStatesHover Hover
		{
			get;
			set;
		}

		private PlotOptionsBoxplotStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsBoxplotStates()
		{
			PlotOptionsBoxplotStatesHover plotOptionsBoxplotStatesHover = new PlotOptionsBoxplotStatesHover();
			PlotOptionsBoxplotStatesHover plotOptionsBoxplotStatesHover1 = plotOptionsBoxplotStatesHover;
			this.Hover_DefaultValue = plotOptionsBoxplotStatesHover;
			this.Hover = plotOptionsBoxplotStatesHover1;
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