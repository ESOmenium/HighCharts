using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class ChartOptions3dFrameBottom : BaseObject
	{
		public string Color
		{
			get;
			set;
		}

		private string Color_DefaultValue
		{
			get;
			set;
		}

		public double? Size
		{
			get;
			set;
		}

		private double? Size_DefaultValue
		{
			get;
			set;
		}

		public ChartOptions3dFrameBottom()
		{
			string str = "transparent";
			string str1 = str;
			this.Color_DefaultValue = str;
			this.Color = str1;
			double? nullable = new double?((double)1);
			this.Size_DefaultValue = nullable;
			this.Size = nullable;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.Color != this.Color_DefaultValue)
			{
				hashtables.Add("color", this.Color);
			}
			double? size = this.Size;
			double? sizeDefaultValue = this.Size_DefaultValue;
			if ((size.GetValueOrDefault() == sizeDefaultValue.GetValueOrDefault() ? size.HasValue != sizeDefaultValue.HasValue : true))
			{
				hashtables.Add("size", this.Size);
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