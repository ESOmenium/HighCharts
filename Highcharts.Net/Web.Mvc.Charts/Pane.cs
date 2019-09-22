using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class Pane : BaseObject
	{
		public List<Highsoft.Web.Mvc.Charts.Background> Background
		{
			get;
			set;
		}

		private List<Highsoft.Web.Mvc.Charts.Background> Background_DefaultValue
		{
			get;
			set;
		}

		public string[] Center
		{
			get;
			set;
		}

		private string[] Center_DefaultValue
		{
			get;
			set;
		}

		public double? EndAngle
		{
			get;
			set;
		}

		private double? EndAngle_DefaultValue
		{
			get;
			set;
		}

		public string Size
		{
			get;
			set;
		}

		private string Size_DefaultValue
		{
			get;
			set;
		}

		public double? StartAngle
		{
			get;
			set;
		}

		private double? StartAngle_DefaultValue
		{
			get;
			set;
		}

		public Pane()
		{
			List<Highsoft.Web.Mvc.Charts.Background> backgrounds = new List<Highsoft.Web.Mvc.Charts.Background>();
			List<Highsoft.Web.Mvc.Charts.Background> backgrounds1 = backgrounds;
			this.Background_DefaultValue = backgrounds;
			this.Background = backgrounds1;
			string[] strArrays = new string[2];
			string[] strArrays1 = strArrays;
			this.Center_DefaultValue = strArrays;
			this.Center = strArrays1;
			double? nullable = null;
			this.EndAngle_DefaultValue = nullable;
			this.EndAngle = nullable;
			string str = "85%";
			string str1 = str;
			this.Size_DefaultValue = str;
			this.Size = str1;
			nullable = null;
			this.StartAngle_DefaultValue = nullable;
			this.StartAngle = nullable;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.Background != this.Background_DefaultValue)
			{
				hashtables.Add("background", base.HashifyList(this.Background));
			}
			if (this.Center != this.Center_DefaultValue)
			{
				hashtables.Add("center", this.Center);
			}
			double? endAngle = this.EndAngle;
			double? endAngleDefaultValue = this.EndAngle_DefaultValue;
			if ((endAngle.GetValueOrDefault() == endAngleDefaultValue.GetValueOrDefault() ? endAngle.HasValue != endAngleDefaultValue.HasValue : true))
			{
				hashtables.Add("endAngle", this.EndAngle);
			}
			if (this.Size != this.Size_DefaultValue)
			{
				hashtables.Add("size", this.Size);
			}
			endAngleDefaultValue = this.StartAngle;
			endAngle = this.StartAngle_DefaultValue;
			if ((endAngleDefaultValue.GetValueOrDefault() == endAngle.GetValueOrDefault() ? endAngleDefaultValue.HasValue != endAngle.HasValue : true))
			{
				hashtables.Add("startAngle", this.StartAngle);
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