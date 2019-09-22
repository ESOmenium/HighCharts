using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsLinePoint : BaseObject
	{
		public PlotOptionsLinePointEvents Events
		{
			get;
			set;
		}

		private PlotOptionsLinePointEvents Events_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsLinePoint()
		{
			PlotOptionsLinePointEvents plotOptionsLinePointEvent = new PlotOptionsLinePointEvents();
			PlotOptionsLinePointEvents plotOptionsLinePointEvent1 = plotOptionsLinePointEvent;
			this.Events_DefaultValue = plotOptionsLinePointEvent;
			this.Events = plotOptionsLinePointEvent1;
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