using System.Collections;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class ArearangeSeriesPoint : BaseObject
	{
		public ArearangeSeriesPointEvents Events { get; set; }

		private ArearangeSeriesPointEvents Events_DefaultValue { get; set; }

		public ArearangeSeriesPoint()
		{
			ArearangeSeriesPointEvents arearangeSeriesPointEvent = new ArearangeSeriesPointEvents();
			ArearangeSeriesPointEvents arearangeSeriesPointEvent1 = arearangeSeriesPointEvent;
			Events_DefaultValue = arearangeSeriesPointEvent;
			Events = arearangeSeriesPointEvent1;
		}

		internal override bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (Events.IsDirty())
			{
				hashtables.Add("events", Events.ToHashtable());
			}
			return hashtables;
		}

		internal override string ToJSON()
		{
			string str;
			Hashtable hashtable = ToHashtable();
			JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer
			{
				MaxJsonLength = 2147483647
			};
			str = (hashtable.Count <= 0 ? "" : javaScriptSerializer.Serialize(ToHashtable()));
			return str;
		}
	}
}