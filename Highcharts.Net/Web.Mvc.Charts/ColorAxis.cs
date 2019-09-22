using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class ColorAxis : BaseObject
	{
		public bool? EndOnTick
		{
			get;
			set;
		}

		private bool? EndOnTick_DefaultValue
		{
			get;
			set;
		}

		public double? Max
		{
			get;
			set;
		}

		private double? Max_DefaultValue
		{
			get;
			set;
		}

		public string MaxColor
		{
			get;
			set;
		}

		private string MaxColor_DefaultValue
		{
			get;
			set;
		}

		public double? Min
		{
			get;
			set;
		}

		private double? Min_DefaultValue
		{
			get;
			set;
		}

		public string MinColor
		{
			get;
			set;
		}

		private string MinColor_DefaultValue
		{
			get;
			set;
		}

		public bool? StartOnTick
		{
			get;
			set;
		}

		private bool? StartOnTick_DefaultValue
		{
			get;
			set;
		}

		public List<Stop> Stops
		{
			get;
			set;
		}

		private List<Stop> Stops_DefaultValue
		{
			get;
			set;
		}

		public ColorAxis()
		{
			object obj = null;
			List<Stop> stops = (List<Stop>)obj;
			this.Stops_DefaultValue = (List<Stop>)obj;
			this.Stops = stops;
			double? nullable = null;
			this.Min_DefaultValue = nullable;
			this.Min = nullable;
			nullable = null;
			this.Max_DefaultValue = nullable;
			this.Max = nullable;
			bool? nullable1 = new bool?(false);
			this.StartOnTick_DefaultValue = nullable1;
			this.StartOnTick = nullable1;
			nullable1 = new bool?(false);
			this.EndOnTick_DefaultValue = nullable1;
			this.EndOnTick = nullable1;
			object obj1 = null;
			string str = (string)obj1;
			this.MinColor_DefaultValue = (string)obj1;
			this.MinColor = str;
			object obj2 = null;
			str = (string)obj2;
			this.MaxColor_DefaultValue = (string)obj2;
			this.MaxColor = str;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.Stops != this.Stops_DefaultValue)
			{
				hashtables.Add("stops", base.HashifyList(this.Stops));
			}
			double? min = this.Min;
			double? minDefaultValue = this.Min_DefaultValue;
			if ((min.GetValueOrDefault() == minDefaultValue.GetValueOrDefault() ? min.HasValue != minDefaultValue.HasValue : true))
			{
				hashtables.Add("min", this.Min);
			}
			minDefaultValue = this.Max;
			min = this.Max_DefaultValue;
			if ((minDefaultValue.GetValueOrDefault() == min.GetValueOrDefault() ? minDefaultValue.HasValue != min.HasValue : true))
			{
				hashtables.Add("max", this.Max);
			}
			bool? startOnTick = this.StartOnTick;
			bool? startOnTickDefaultValue = this.StartOnTick_DefaultValue;
			if ((startOnTick.GetValueOrDefault() == startOnTickDefaultValue.GetValueOrDefault() ? startOnTick.HasValue != startOnTickDefaultValue.HasValue : true))
			{
				hashtables.Add("startOnTick", this.StartOnTick);
			}
			startOnTickDefaultValue = this.EndOnTick;
			startOnTick = this.EndOnTick_DefaultValue;
			if ((startOnTickDefaultValue.GetValueOrDefault() == startOnTick.GetValueOrDefault() ? startOnTickDefaultValue.HasValue != startOnTick.HasValue : true))
			{
				hashtables.Add("endOnTick", this.EndOnTick);
			}
			if (this.MinColor != this.MinColor_DefaultValue)
			{
				hashtables.Add("minColor", this.MinColor);
			}
			if (this.MaxColor != this.MaxColor_DefaultValue)
			{
				hashtables.Add("maxColor", this.MaxColor);
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