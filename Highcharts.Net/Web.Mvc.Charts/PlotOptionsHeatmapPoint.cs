using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class PlotOptionsHeatmapPoint : BaseObject
	{
		public PlotOptionsHeatmapPointEvents Events
		{
			get;
			set;
		}

		private PlotOptionsHeatmapPointEvents Events_DefaultValue
		{
			get;
			set;
		}

		public PlotOptionsHeatmapPoint()
		{
			PlotOptionsHeatmapPointEvents plotOptionsHeatmapPointEvent = new PlotOptionsHeatmapPointEvents();
			PlotOptionsHeatmapPointEvents plotOptionsHeatmapPointEvent1 = plotOptionsHeatmapPointEvent;
			this.Events_DefaultValue = plotOptionsHeatmapPointEvent;
			this.Events = plotOptionsHeatmapPointEvent1;
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