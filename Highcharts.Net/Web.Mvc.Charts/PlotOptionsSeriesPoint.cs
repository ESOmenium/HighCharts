using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsSeriesPoint : BaseObject
	{
		public PlotOptionsSeriesPointEvents Events
		{
			get;
			set;
		}

		private PlotOptionsSeriesPointEvents Events_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsSeriesPoint()
		{
			PlotOptionsSeriesPointEvents plotOptionsSeriesPointEvent = new PlotOptionsSeriesPointEvents();
			PlotOptionsSeriesPointEvents plotOptionsSeriesPointEvent1 = plotOptionsSeriesPointEvent;
			this.Events_DefaultValue = plotOptionsSeriesPointEvent;
			this.Events = plotOptionsSeriesPointEvent1;
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