using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class Crosshair : BaseObject
	{
		public bool XAxis
		{
			get;
			set;
		}

		public bool YAxis
		{
			get;
			set;
		}

		public Crosshair()
		{
			this.XAxis = false;
			this.YAxis = false;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.XAxis)
			{
				hashtables.Add("xAxis", this.XAxis);
			}
			if (this.YAxis)
			{
				hashtables.Add("yAxis", this.YAxis);
			}
			return hashtables;
		}

		internal override string ToJSON()
		{
			return (new JavaScriptSerializer()).Serialize(this.ToHashtable());
		}
	}
}