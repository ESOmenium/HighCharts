using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsPiePoint : BaseObject
	{
		public PlotOptionsPiePointEvents Events
		{
			get;
			set;
		}

		private PlotOptionsPiePointEvents Events_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsPiePoint()
		{
			PlotOptionsPiePointEvents plotOptionsPiePointEvent = new PlotOptionsPiePointEvents();
			PlotOptionsPiePointEvents plotOptionsPiePointEvent1 = plotOptionsPiePointEvent;
			this.Events_DefaultValue = plotOptionsPiePointEvent;
			this.Events = plotOptionsPiePointEvent1;
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