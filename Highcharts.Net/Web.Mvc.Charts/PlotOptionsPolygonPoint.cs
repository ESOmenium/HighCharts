using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsPolygonPoint : BaseObject
	{
		public PlotOptionsPolygonPointEvents Events
		{
			get;
			set;
		}

		private PlotOptionsPolygonPointEvents Events_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsPolygonPoint()
		{
			PlotOptionsPolygonPointEvents plotOptionsPolygonPointEvent = new PlotOptionsPolygonPointEvents();
			PlotOptionsPolygonPointEvents plotOptionsPolygonPointEvent1 = plotOptionsPolygonPointEvent;
			this.Events_DefaultValue = plotOptionsPolygonPointEvent;
			this.Events = plotOptionsPolygonPointEvent1;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.Events.IsDirty())
			{
				hashtables.Add("events", this.Events.ToHashtable());
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