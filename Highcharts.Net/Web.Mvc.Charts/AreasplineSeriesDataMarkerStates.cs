using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class AreasplineSeriesDataMarkerStates : BaseObject
	{
		public AreasplineSeriesDataMarkerStatesHover Hover
		{
			get;
			set;
		}

		private AreasplineSeriesDataMarkerStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public AreasplineSeriesDataMarkerStatesSelect Select
		{
			get;
			set;
		}

		private AreasplineSeriesDataMarkerStatesSelect Select_DefaultValue
		{
			get;
			set;
		}

		public AreasplineSeriesDataMarkerStates()
		{
			AreasplineSeriesDataMarkerStatesHover areasplineSeriesDataMarkerStatesHover = new AreasplineSeriesDataMarkerStatesHover();
			AreasplineSeriesDataMarkerStatesHover areasplineSeriesDataMarkerStatesHover1 = areasplineSeriesDataMarkerStatesHover;
			this.Hover_DefaultValue = areasplineSeriesDataMarkerStatesHover;
			this.Hover = areasplineSeriesDataMarkerStatesHover1;
			AreasplineSeriesDataMarkerStatesSelect areasplineSeriesDataMarkerStatesSelect = new AreasplineSeriesDataMarkerStatesSelect();
			AreasplineSeriesDataMarkerStatesSelect areasplineSeriesDataMarkerStatesSelect1 = areasplineSeriesDataMarkerStatesSelect;
			this.Select_DefaultValue = areasplineSeriesDataMarkerStatesSelect;
			this.Select = areasplineSeriesDataMarkerStatesSelect1;
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