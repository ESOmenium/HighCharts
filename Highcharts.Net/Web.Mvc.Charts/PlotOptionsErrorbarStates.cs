using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsErrorbarStates : BaseObject
	{
		public PlotOptionsErrorbarStatesHover Hover
		{
			get;
			set;
		}

		private PlotOptionsErrorbarStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsErrorbarStates()
		{
			PlotOptionsErrorbarStatesHover plotOptionsErrorbarStatesHover = new PlotOptionsErrorbarStatesHover();
			PlotOptionsErrorbarStatesHover plotOptionsErrorbarStatesHover1 = plotOptionsErrorbarStatesHover;
			this.Hover_DefaultValue = plotOptionsErrorbarStatesHover;
			this.Hover = plotOptionsErrorbarStatesHover1;
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