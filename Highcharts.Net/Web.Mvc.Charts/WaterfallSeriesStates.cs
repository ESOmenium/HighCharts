using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class WaterfallSeriesStates : BaseObject
	{
		public WaterfallSeriesStatesHover Hover
		{
			get;
			set;
		}

		private WaterfallSeriesStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public WaterfallSeriesStates()
		{
			WaterfallSeriesStatesHover waterfallSeriesStatesHover = new WaterfallSeriesStatesHover();
			WaterfallSeriesStatesHover waterfallSeriesStatesHover1 = waterfallSeriesStatesHover;
			this.Hover_DefaultValue = waterfallSeriesStatesHover;
			this.Hover = waterfallSeriesStatesHover1;
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