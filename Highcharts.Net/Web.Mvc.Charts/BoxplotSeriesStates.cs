using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class BoxplotSeriesStates : BaseObject
	{
		public BoxplotSeriesStatesHover Hover
		{
			get;
			set;
		}

		private BoxplotSeriesStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public BoxplotSeriesStates()
		{
			BoxplotSeriesStatesHover boxplotSeriesStatesHover = new BoxplotSeriesStatesHover();
			BoxplotSeriesStatesHover boxplotSeriesStatesHover1 = boxplotSeriesStatesHover;
			this.Hover_DefaultValue = boxplotSeriesStatesHover;
			this.Hover = boxplotSeriesStatesHover1;
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