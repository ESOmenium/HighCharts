using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PieSeriesPoint : BaseObject
	{
		public PieSeriesPointEvents Events
		{
			get;
			set;
		}

		private PieSeriesPointEvents Events_DefaultValue
		{
			get;
			set;
		}

		public PieSeriesPoint()
		{
			PieSeriesPointEvents pieSeriesPointEvent = new PieSeriesPointEvents();
			PieSeriesPointEvents pieSeriesPointEvent1 = pieSeriesPointEvent;
			this.Events_DefaultValue = pieSeriesPointEvent;
			this.Events = pieSeriesPointEvent1;
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