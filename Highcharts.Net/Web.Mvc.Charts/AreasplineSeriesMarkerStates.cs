using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class AreasplineSeriesMarkerStates : BaseObject
	{
		public AreasplineSeriesMarkerStatesHover Hover
		{
			get;
			set;
		}

		private AreasplineSeriesMarkerStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public AreasplineSeriesMarkerStatesSelect Select
		{
			get;
			set;
		}

		private AreasplineSeriesMarkerStatesSelect Select_DefaultValue
		{
			get;
			set;
		}

		public AreasplineSeriesMarkerStates()
		{
			AreasplineSeriesMarkerStatesHover areasplineSeriesMarkerStatesHover = new AreasplineSeriesMarkerStatesHover();
			AreasplineSeriesMarkerStatesHover areasplineSeriesMarkerStatesHover1 = areasplineSeriesMarkerStatesHover;
			this.Hover_DefaultValue = areasplineSeriesMarkerStatesHover;
			this.Hover = areasplineSeriesMarkerStatesHover1;
			AreasplineSeriesMarkerStatesSelect areasplineSeriesMarkerStatesSelect = new AreasplineSeriesMarkerStatesSelect();
			AreasplineSeriesMarkerStatesSelect areasplineSeriesMarkerStatesSelect1 = areasplineSeriesMarkerStatesSelect;
			this.Select_DefaultValue = areasplineSeriesMarkerStatesSelect;
			this.Select = areasplineSeriesMarkerStatesSelect1;
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