using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class ScatterSeriesMarkerStates : BaseObject
	{
		public ScatterSeriesMarkerStatesHover Hover
		{
			get;
			set;
		}

		private ScatterSeriesMarkerStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public ScatterSeriesMarkerStatesSelect Select
		{
			get;
			set;
		}

		private ScatterSeriesMarkerStatesSelect Select_DefaultValue
		{
			get;
			set;
		}

		public ScatterSeriesMarkerStates()
		{
			ScatterSeriesMarkerStatesHover scatterSeriesMarkerStatesHover = new ScatterSeriesMarkerStatesHover();
			ScatterSeriesMarkerStatesHover scatterSeriesMarkerStatesHover1 = scatterSeriesMarkerStatesHover;
			this.Hover_DefaultValue = scatterSeriesMarkerStatesHover;
			this.Hover = scatterSeriesMarkerStatesHover1;
			ScatterSeriesMarkerStatesSelect scatterSeriesMarkerStatesSelect = new ScatterSeriesMarkerStatesSelect();
			ScatterSeriesMarkerStatesSelect scatterSeriesMarkerStatesSelect1 = scatterSeriesMarkerStatesSelect;
			this.Select_DefaultValue = scatterSeriesMarkerStatesSelect;
			this.Select = scatterSeriesMarkerStatesSelect1;
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