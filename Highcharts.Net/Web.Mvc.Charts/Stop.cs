using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class Stop : BaseObject
	{
		public string Color
		{
			get;
			set;
		}

		public double Position
		{
			get;
			set;
		}

		public Stop()
		{
			this.Position = 0;
			this.Color = "";
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (!string.IsNullOrEmpty(this.Color))
			{
				hashtables.Add("color", this.Color);
			}
			if (this.Position != 0)
			{
				hashtables.Add("position", this.Position);
			}
			return hashtables;
		}

		internal override string ToJSON()
		{
			return (new JavaScriptSerializer()).Serialize(this.ToHashtable());
		}
	}
}