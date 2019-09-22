using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class ScatterSeriesDataMarkerStates : BaseObject
	{
		public ScatterSeriesDataMarkerStatesHover Hover
		{
			get;
			set;
		}

		private ScatterSeriesDataMarkerStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public ScatterSeriesDataMarkerStatesSelect Select
		{
			get;
			set;
		}

		private ScatterSeriesDataMarkerStatesSelect Select_DefaultValue
		{
			get;
			set;
		}

		public ScatterSeriesDataMarkerStates()
		{
			ScatterSeriesDataMarkerStatesHover scatterSeriesDataMarkerStatesHover = new ScatterSeriesDataMarkerStatesHover();
			ScatterSeriesDataMarkerStatesHover scatterSeriesDataMarkerStatesHover1 = scatterSeriesDataMarkerStatesHover;
			this.Hover_DefaultValue = scatterSeriesDataMarkerStatesHover;
			this.Hover = scatterSeriesDataMarkerStatesHover1;
			ScatterSeriesDataMarkerStatesSelect scatterSeriesDataMarkerStatesSelect = new ScatterSeriesDataMarkerStatesSelect();
			ScatterSeriesDataMarkerStatesSelect scatterSeriesDataMarkerStatesSelect1 = scatterSeriesDataMarkerStatesSelect;
			this.Select_DefaultValue = scatterSeriesDataMarkerStatesSelect;
			this.Select = scatterSeriesDataMarkerStatesSelect1;
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