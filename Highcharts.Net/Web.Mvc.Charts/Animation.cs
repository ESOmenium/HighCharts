using System.Collections;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class Animation : BaseObject
	{
		public int Duration { get; set; }

		public string Easing { get; set; }

		public bool Enabled { get; set; }

		public Animation()
		{
			Enabled = true;
			Duration = 0;
			Easing = "";
		}

		internal override bool IsDirty()
		{
			return (!Enabled ? true : ToHashtable().Count > 0);
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (!string.IsNullOrEmpty(Easing))
			{
				hashtables.Add("easing", Easing);
			}
			if (Duration > 0)
			{
				hashtables.Add("duration", Duration);
			}
			return hashtables;
		}

		internal override string ToJSON()
		{
			string str;
			str = (ToHashtable().Count <= 0
				? Enabled.ToString().ToLower()
				: (new JavaScriptSerializer()).Serialize(ToHashtable()));
			return str;
		}
	}
}