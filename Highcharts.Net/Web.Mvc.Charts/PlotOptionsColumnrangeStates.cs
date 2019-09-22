using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsColumnrangeStates : BaseObject
	{
		public PlotOptionsColumnrangeStatesHover Hover
		{
			get;
			set;
		}

		private PlotOptionsColumnrangeStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsColumnrangeStates()
		{
			PlotOptionsColumnrangeStatesHover plotOptionsColumnrangeStatesHover = new PlotOptionsColumnrangeStatesHover();
			PlotOptionsColumnrangeStatesHover plotOptionsColumnrangeStatesHover1 = plotOptionsColumnrangeStatesHover;
			this.Hover_DefaultValue = plotOptionsColumnrangeStatesHover;
			this.Hover = plotOptionsColumnrangeStatesHover1;
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