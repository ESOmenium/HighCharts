using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class SplineSeriesMarkerStates : BaseObject
	{
		public SplineSeriesMarkerStatesHover Hover
		{
			get;
			set;
		}

		private SplineSeriesMarkerStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public SplineSeriesMarkerStatesSelect Select
		{
			get;
			set;
		}

		private SplineSeriesMarkerStatesSelect Select_DefaultValue
		{
			get;
			set;
		}

		public SplineSeriesMarkerStates()
		{
			SplineSeriesMarkerStatesHover splineSeriesMarkerStatesHover = new SplineSeriesMarkerStatesHover();
			SplineSeriesMarkerStatesHover splineSeriesMarkerStatesHover1 = splineSeriesMarkerStatesHover;
			this.Hover_DefaultValue = splineSeriesMarkerStatesHover;
			this.Hover = splineSeriesMarkerStatesHover1;
			SplineSeriesMarkerStatesSelect splineSeriesMarkerStatesSelect = new SplineSeriesMarkerStatesSelect();
			SplineSeriesMarkerStatesSelect splineSeriesMarkerStatesSelect1 = splineSeriesMarkerStatesSelect;
			this.Select_DefaultValue = splineSeriesMarkerStatesSelect;
			this.Select = splineSeriesMarkerStatesSelect1;
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