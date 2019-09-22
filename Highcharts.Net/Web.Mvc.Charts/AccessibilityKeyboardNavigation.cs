using System.Collections;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class AccessibilityKeyboardNavigation : BaseObject
	{
		public bool? Enabled { get; set; }

		private bool? Enabled_DefaultValue { get; }

		public bool? SkipNullPoints { get; set; }

		private bool? SkipNullPoints_DefaultValue { get; }

		public AccessibilityKeyboardNavigation()
		{
			bool? nullable = true;
			Enabled_DefaultValue = nullable;
			Enabled = nullable;
			nullable = false;
			SkipNullPoints_DefaultValue = nullable;
			SkipNullPoints = nullable;
		}

		internal override bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			bool? enabled = Enabled;
			bool? enabledDefaultValue = Enabled_DefaultValue;
			if ((enabled.GetValueOrDefault() == enabledDefaultValue.GetValueOrDefault()
				? enabled.HasValue != enabledDefaultValue.HasValue
				: true))
			{
				hashtables.Add("enabled", Enabled);
			}
			enabledDefaultValue = SkipNullPoints;
			enabled = SkipNullPoints_DefaultValue;
			if ((enabledDefaultValue.GetValueOrDefault() == enabled.GetValueOrDefault()
				? enabledDefaultValue.HasValue != enabled.HasValue
				: true))
			{
				hashtables.Add("skipNullPoints", SkipNullPoints);
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