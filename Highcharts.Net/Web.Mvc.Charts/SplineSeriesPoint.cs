using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class SplineSeriesPoint : BaseObject
	{
		public SplineSeriesPointEvents Events
		{
			get;
			set;
		}

		private SplineSeriesPointEvents Events_DefaultValue
		{
			get;
			set;
		}

		public SplineSeriesPoint()
		{
			SplineSeriesPointEvents splineSeriesPointEvent = new SplineSeriesPointEvents();
			SplineSeriesPointEvents splineSeriesPointEvent1 = splineSeriesPointEvent;
			this.Events_DefaultValue = splineSeriesPointEvent;
			this.Events = splineSeriesPointEvent1;
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