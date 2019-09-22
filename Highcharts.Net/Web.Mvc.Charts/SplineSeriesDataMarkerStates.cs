using System.Collections;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class SplineSeriesDataMarkerStates : BaseObject
	{
		public SplineSeriesDataMarkerStatesHover Hover { get; set; }

		private SplineSeriesDataMarkerStatesHover Hover_DefaultValue { get; set; }

		public SplineSeriesDataMarkerStatesSelect Select { get; set; }

		private SplineSeriesDataMarkerStatesSelect Select_DefaultValue { get; set; }

		public SplineSeriesDataMarkerStates()
		{
			SplineSeriesDataMarkerStatesHover splineSeriesDataMarkerStatesHover = new SplineSeriesDataMarkerStatesHover();
			SplineSeriesDataMarkerStatesHover splineSeriesDataMarkerStatesHover1 = splineSeriesDataMarkerStatesHover;
			Hover_DefaultValue = splineSeriesDataMarkerStatesHover;
			Hover = splineSeriesDataMarkerStatesHover1;
			SplineSeriesDataMarkerStatesSelect splineSeriesDataMarkerStatesSelect = new SplineSeriesDataMarkerStatesSelect();
			SplineSeriesDataMarkerStatesSelect splineSeriesDataMarkerStatesSelect1 = splineSeriesDataMarkerStatesSelect;
			Select_DefaultValue = splineSeriesDataMarkerStatesSelect;
			Select = splineSeriesDataMarkerStatesSelect1;
		}

		internal override bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (Hover.IsDirty())
			{
				hashtables.Add("hover", Hover.ToHashtable());
			}
			if (Select.IsDirty())
			{
				hashtables.Add("select", Select.ToHashtable());
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