using System.Collections;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class Accessibility : BaseObject
	{
		public bool? DescribeSingleSeries { get; set; }

		private bool? DescribeSingleSeries_DefaultValue { get; }

		public bool? Enabled { get; set; }

		private bool? Enabled_DefaultValue { get; }

		public AccessibilityKeyboardNavigation KeyboardNavigation { get; set; }

		private AccessibilityKeyboardNavigation KeyboardNavigation_DefaultValue { get; set; }

		public string OnTableAnchorClick { get; set; }

		private string OnTableAnchorClick_DefaultValue { get; }

		public string PointDateFormat { get; set; }

		private string PointDateFormat_DefaultValue { get; }

		public string PointDateFormatter { get; set; }

		private string PointDateFormatter_DefaultValue { get; }

		public string PointDescriptionFormatter { get; set; }

		private string PointDescriptionFormatter_DefaultValue { get; }

		public long? PointDescriptionThreshold { get; set; }

		private long? PointDescriptionThreshold_DefaultValue { get; }

		public string ScreenReaderSectionFormatter { get; set; }

		private string ScreenReaderSectionFormatter_DefaultValue { get; }

		public string SeriesDescriptionFormatter { get; set; }

		private string SeriesDescriptionFormatter_DefaultValue { get; }

		public Accessibility()
		{
			bool? nullable = false;
			DescribeSingleSeries_DefaultValue = nullable;
			DescribeSingleSeries = nullable;
			nullable = true;
			Enabled_DefaultValue = nullable;
			Enabled = nullable;
			AccessibilityKeyboardNavigation accessibilityKeyboardNavigation = new AccessibilityKeyboardNavigation();
			AccessibilityKeyboardNavigation accessibilityKeyboardNavigation1 = accessibilityKeyboardNavigation;
			KeyboardNavigation_DefaultValue = accessibilityKeyboardNavigation;
			KeyboardNavigation = accessibilityKeyboardNavigation1;
			string str = "";
			string str1 = str;
			OnTableAnchorClick_DefaultValue = str;
			OnTableAnchorClick = str1;
			object obj = null;
			str1 = (string) obj;
			PointDateFormat_DefaultValue = (string) obj;
			PointDateFormat = str1;
			string str2 = "";
			str1 = str2;
			PointDateFormatter_DefaultValue = str2;
			PointDateFormatter = str1;
			string str3 = "";
			str1 = str3;
			PointDescriptionFormatter_DefaultValue = str3;
			PointDescriptionFormatter = str1;
			long? nullable1 = 30;
			PointDescriptionThreshold_DefaultValue = nullable1;
			PointDescriptionThreshold = nullable1;
			string str4 = "";
			str1 = str4;
			ScreenReaderSectionFormatter_DefaultValue = str4;
			ScreenReaderSectionFormatter = str1;
			string str5 = "";
			str1 = str5;
			SeriesDescriptionFormatter_DefaultValue = str5;
			SeriesDescriptionFormatter = str1;
		}

		internal override bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			bool? describeSingleSeries = DescribeSingleSeries;
			bool? describeSingleSeriesDefaultValue = DescribeSingleSeries_DefaultValue;
			if ((describeSingleSeries.GetValueOrDefault() == describeSingleSeriesDefaultValue.GetValueOrDefault()
				? describeSingleSeries.HasValue != describeSingleSeriesDefaultValue.HasValue
				: true))
			{
				hashtables.Add("describeSingleSeries", DescribeSingleSeries);
			}
			describeSingleSeriesDefaultValue = Enabled;
			describeSingleSeries = Enabled_DefaultValue;
			if ((describeSingleSeriesDefaultValue.GetValueOrDefault() == describeSingleSeries.GetValueOrDefault()
				? describeSingleSeriesDefaultValue.HasValue != describeSingleSeries.HasValue
				: true))
			{
				hashtables.Add("enabled", Enabled);
			}
			if (KeyboardNavigation.IsDirty())
			{
				hashtables.Add("keyboardNavigation", KeyboardNavigation.ToHashtable());
			}
			if (OnTableAnchorClick != OnTableAnchorClick_DefaultValue)
			{
				hashtables.Add("onTableAnchorClick", OnTableAnchorClick);
				Highcharts.AddFunction("AccessibilityOnTableAnchorClick.onTableAnchorClick", OnTableAnchorClick);
			}
			if (PointDateFormat != PointDateFormat_DefaultValue)
			{
				hashtables.Add("pointDateFormat", PointDateFormat);
			}
			if (PointDateFormatter != PointDateFormatter_DefaultValue)
			{
				hashtables.Add("pointDateFormatter", PointDateFormatter);
				Highcharts.AddFunction("AccessibilityPointDateFormatter.pointDateFormatter", PointDateFormatter);
			}
			if (PointDescriptionFormatter != PointDescriptionFormatter_DefaultValue)
			{
				hashtables.Add("pointDescriptionFormatter", PointDescriptionFormatter);
				Highcharts.AddFunction("AccessibilityPointDescriptionFormatter.pointDescriptionFormatter", PointDescriptionFormatter);
			}
			long? pointDescriptionThreshold = PointDescriptionThreshold;
			long? pointDescriptionThresholdDefaultValue = PointDescriptionThreshold_DefaultValue;
			if ((pointDescriptionThreshold.GetValueOrDefault() == pointDescriptionThresholdDefaultValue.GetValueOrDefault()
				? pointDescriptionThreshold.HasValue != pointDescriptionThresholdDefaultValue.HasValue
				: true))
			{
				pointDescriptionThresholdDefaultValue = PointDescriptionThreshold;
				if (!pointDescriptionThresholdDefaultValue.HasValue)
				{
					hashtables.Add("pointDescriptionThreshold", false);
				}
				else
				{
					hashtables.Add("pointDescriptionThreshold", PointDescriptionThreshold);
				}
			}
			if (ScreenReaderSectionFormatter != ScreenReaderSectionFormatter_DefaultValue)
			{
				hashtables.Add("screenReaderSectionFormatter", ScreenReaderSectionFormatter);
				Highcharts.AddFunction("AccessibilityScreenReaderSectionFormatter.screenReaderSectionFormatter",
					ScreenReaderSectionFormatter);
			}
			if (SeriesDescriptionFormatter != SeriesDescriptionFormatter_DefaultValue)
			{
				hashtables.Add("seriesDescriptionFormatter", SeriesDescriptionFormatter);
				Highcharts.AddFunction("AccessibilitySeriesDescriptionFormatter.seriesDescriptionFormatter",
					SeriesDescriptionFormatter);
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