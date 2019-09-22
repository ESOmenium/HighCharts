using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Highsoft.Web.Mvc.Charts
{
	public class PointPlacement : BaseObject
	{
		public Highsoft.Web.Mvc.Charts.PointPlacementEnum PointPlacementEnum
		{
			get;
			set;
		}

		public double? Value
		{
			get;
			set;
		}

		public PointPlacement()
		{
			this.Value = null;
			this.PointPlacementEnum = Highsoft.Web.Mvc.Charts.PointPlacementEnum.Null;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.Value.HasValue)
			{
				hashtables.Add("pointPlacement", this.Value);
			}
			else if (this.PointPlacementEnum != Highsoft.Web.Mvc.Charts.PointPlacementEnum.Null)
			{
				Highsoft.Web.Mvc.Charts.PointPlacementEnum pointPlacementEnum = this.PointPlacementEnum;
				hashtables.Add("pointPlacement", pointPlacementEnum.ToString().ToLower());
			}
			return hashtables;
		}

		internal override string ToJSON()
		{
			string str;
			str = (this.PointPlacementEnum == Highsoft.Web.Mvc.Charts.PointPlacementEnum.Null ? "" : this.PointPlacementEnum.ToString().ToLower());
			return str;
		}

		internal double? ToJSONDouble()
		{
			double? nullable;
			nullable = (!this.Value.HasValue ? new double?(0) : this.Value);
			return nullable;
		}
	}
}