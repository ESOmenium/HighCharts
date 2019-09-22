using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class LineSeriesMarkerStates : BaseObject
	{
		public LineSeriesMarkerStatesHover Hover
		{
			get;
			set;
		}

		private LineSeriesMarkerStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public LineSeriesMarkerStatesSelect Select
		{
			get;
			set;
		}

		private LineSeriesMarkerStatesSelect Select_DefaultValue
		{
			get;
			set;
		}

		public LineSeriesMarkerStates()
		{
			LineSeriesMarkerStatesHover lineSeriesMarkerStatesHover = new LineSeriesMarkerStatesHover();
			LineSeriesMarkerStatesHover lineSeriesMarkerStatesHover1 = lineSeriesMarkerStatesHover;
			this.Hover_DefaultValue = lineSeriesMarkerStatesHover;
			this.Hover = lineSeriesMarkerStatesHover1;
			LineSeriesMarkerStatesSelect lineSeriesMarkerStatesSelect = new LineSeriesMarkerStatesSelect();
			LineSeriesMarkerStatesSelect lineSeriesMarkerStatesSelect1 = lineSeriesMarkerStatesSelect;
			this.Select_DefaultValue = lineSeriesMarkerStatesSelect;
			this.Select = lineSeriesMarkerStatesSelect1;
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