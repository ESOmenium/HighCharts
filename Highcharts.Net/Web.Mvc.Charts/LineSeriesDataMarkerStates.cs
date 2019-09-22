using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class LineSeriesDataMarkerStates : BaseObject
	{
		public LineSeriesDataMarkerStatesHover Hover
		{
			get;
			set;
		}

		private LineSeriesDataMarkerStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public LineSeriesDataMarkerStatesSelect Select
		{
			get;
			set;
		}

		private LineSeriesDataMarkerStatesSelect Select_DefaultValue
		{
			get;
			set;
		}

		public LineSeriesDataMarkerStates()
		{
			LineSeriesDataMarkerStatesHover lineSeriesDataMarkerStatesHover = new LineSeriesDataMarkerStatesHover();
			LineSeriesDataMarkerStatesHover lineSeriesDataMarkerStatesHover1 = lineSeriesDataMarkerStatesHover;
			this.Hover_DefaultValue = lineSeriesDataMarkerStatesHover;
			this.Hover = lineSeriesDataMarkerStatesHover1;
			LineSeriesDataMarkerStatesSelect lineSeriesDataMarkerStatesSelect = new LineSeriesDataMarkerStatesSelect();
			LineSeriesDataMarkerStatesSelect lineSeriesDataMarkerStatesSelect1 = lineSeriesDataMarkerStatesSelect;
			this.Select_DefaultValue = lineSeriesDataMarkerStatesSelect;
			this.Select = lineSeriesDataMarkerStatesSelect1;
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