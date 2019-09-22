using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsPyramidStates : BaseObject
	{
		public PlotOptionsPyramidStatesHover Hover
		{
			get;
			set;
		}

		private PlotOptionsPyramidStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsPyramidStates()
		{
			PlotOptionsPyramidStatesHover plotOptionsPyramidStatesHover = new PlotOptionsPyramidStatesHover();
			PlotOptionsPyramidStatesHover plotOptionsPyramidStatesHover1 = plotOptionsPyramidStatesHover;
			this.Hover_DefaultValue = plotOptionsPyramidStatesHover;
			this.Hover = plotOptionsPyramidStatesHover1;
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