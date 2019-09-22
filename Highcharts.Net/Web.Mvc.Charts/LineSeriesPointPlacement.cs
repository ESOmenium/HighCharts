using System;
using System.Collections;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class LineSeriesPointPlacement : BaseObject
	{
		public LineSeriesPointPlacement()
		{
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			return new Hashtable();
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