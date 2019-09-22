using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class ChartOptions3dFrame : BaseObject
	{
		public ChartOptions3dFrameBack Back
		{
			get;
			set;
		}

		private ChartOptions3dFrameBack Back_DefaultValue
		{
			get;
			set;
		}

		public ChartOptions3dFrameBottom Bottom
		{
			get;
			set;
		}

		private ChartOptions3dFrameBottom Bottom_DefaultValue
		{
			get;
			set;
		}

		public ChartOptions3dFrameSide Side
		{
			get;
			set;
		}

		private ChartOptions3dFrameSide Side_DefaultValue
		{
			get;
			set;
		}

		public ChartOptions3dFrame()
		{
			ChartOptions3dFrameBack chartOptions3dFrameBack = new ChartOptions3dFrameBack();
			ChartOptions3dFrameBack chartOptions3dFrameBack1 = chartOptions3dFrameBack;
			this.Back_DefaultValue = chartOptions3dFrameBack;
			this.Back = chartOptions3dFrameBack1;
			ChartOptions3dFrameBottom chartOptions3dFrameBottom = new ChartOptions3dFrameBottom();
			ChartOptions3dFrameBottom chartOptions3dFrameBottom1 = chartOptions3dFrameBottom;
			this.Bottom_DefaultValue = chartOptions3dFrameBottom;
			this.Bottom = chartOptions3dFrameBottom1;
			ChartOptions3dFrameSide chartOptions3dFrameSide = new ChartOptions3dFrameSide();
			ChartOptions3dFrameSide chartOptions3dFrameSide1 = chartOptions3dFrameSide;
			this.Side_DefaultValue = chartOptions3dFrameSide;
			this.Side = chartOptions3dFrameSide1;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.Back.IsDirty())
			{
				hashtables.Add("back", this.Back.ToHashtable());
			}
			if (this.Bottom.IsDirty())
			{
				hashtables.Add("bottom", this.Bottom.ToHashtable());
			}
			if (this.Side.IsDirty())
			{
				hashtables.Add("side", this.Side.ToHashtable());
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