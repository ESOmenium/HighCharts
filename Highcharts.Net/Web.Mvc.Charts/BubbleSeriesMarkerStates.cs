using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class BubbleSeriesMarkerStates : BaseObject
	{
		public BubbleSeriesMarkerStatesHover Hover
		{
			get;
			set;
		}

		private BubbleSeriesMarkerStatesHover Hover_DefaultValue
		{
			get;
			set;
		}

		public BubbleSeriesMarkerStatesSelect Select
		{
			get;
			set;
		}

		private BubbleSeriesMarkerStatesSelect Select_DefaultValue
		{
			get;
			set;
		}

		public BubbleSeriesMarkerStates()
		{
			BubbleSeriesMarkerStatesHover bubbleSeriesMarkerStatesHover = new BubbleSeriesMarkerStatesHover();
			BubbleSeriesMarkerStatesHover bubbleSeriesMarkerStatesHover1 = bubbleSeriesMarkerStatesHover;
			this.Hover_DefaultValue = bubbleSeriesMarkerStatesHover;
			this.Hover = bubbleSeriesMarkerStatesHover1;
			BubbleSeriesMarkerStatesSelect bubbleSeriesMarkerStatesSelect = new BubbleSeriesMarkerStatesSelect();
			BubbleSeriesMarkerStatesSelect bubbleSeriesMarkerStatesSelect1 = bubbleSeriesMarkerStatesSelect;
			this.Select_DefaultValue = bubbleSeriesMarkerStatesSelect;
			this.Select = bubbleSeriesMarkerStatesSelect1;
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