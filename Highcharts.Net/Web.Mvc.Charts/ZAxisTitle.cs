using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class ZAxisTitle : BaseObject
	{
		public ZAxisTitleAlign Align
		{
			get;
			set;
		}

		private ZAxisTitleAlign Align_DefaultValue
		{
			get;
			set;
		}

		public string[] Margin
		{
			get;
			set;
		}

		private string[] Margin_DefaultValue
		{
			get;
			set;
		}

		public double? Offset
		{
			get;
			set;
		}

		private double? Offset_DefaultValue
		{
			get;
			set;
		}

		public double? Rotation
		{
			get;
			set;
		}

		private double? Rotation_DefaultValue
		{
			get;
			set;
		}

		public Hashtable Style
		{
			get;
			set;
		}

		private Hashtable Style_DefaultValue
		{
			get;
			set;
		}

		public string Text
		{
			get;
			set;
		}

		private string Text_DefaultValue
		{
			get;
			set;
		}

		public double? X
		{
			get;
			set;
		}

		private double? X_DefaultValue
		{
			get;
			set;
		}

		public double? Y
		{
			get;
			set;
		}

		private double? Y_DefaultValue
		{
			get;
			set;
		}

		public ZAxisTitle()
		{
			int num = 1;
			ZAxisTitleAlign zAxisTitleAlign = (ZAxisTitleAlign)num;
			this.Align_DefaultValue = (ZAxisTitleAlign)num;
			this.Align = zAxisTitleAlign;
			object obj = null;
			string[] strArrays = (string[])obj;
			this.Margin_DefaultValue = (string[])obj;
			this.Margin = strArrays;
			double? nullable = null;
			this.Offset_DefaultValue = nullable;
			this.Offset = nullable;
			nullable = new double?(0);
			this.Rotation_DefaultValue = nullable;
			this.Rotation = nullable;
			Hashtable hashtables = new Hashtable()
			{
				{ "color", "#666666" }
			};
			Hashtable hashtables1 = hashtables;
			this.Style_DefaultValue = hashtables;
			this.Style = hashtables1;
			object obj1 = null;
			string str = (string)obj1;
			this.Text_DefaultValue = (string)obj1;
			this.Text = str;
			nullable = new double?(0);
			this.X_DefaultValue = nullable;
			this.X = nullable;
			nullable = null;
			this.Y_DefaultValue = nullable;
			this.Y = nullable;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.Align != this.Align_DefaultValue)
			{
				ZAxisTitleAlign align = this.Align;
				hashtables.Add("align", Highcharts.FirstCharacterToLower(align.ToString()));
			}
			if (this.Margin != this.Margin_DefaultValue)
			{
				hashtables.Add("margin", this.Margin);
			}
			double? offset = this.Offset;
			double? offsetDefaultValue = this.Offset_DefaultValue;
			if ((offset.GetValueOrDefault() == offsetDefaultValue.GetValueOrDefault() ? offset.HasValue != offsetDefaultValue.HasValue : true))
			{
				hashtables.Add("offset", this.Offset);
			}
			offsetDefaultValue = this.Rotation;
			offset = this.Rotation_DefaultValue;
			if ((offsetDefaultValue.GetValueOrDefault() == offset.GetValueOrDefault() ? offsetDefaultValue.HasValue != offset.HasValue : true))
			{
				hashtables.Add("rotation", this.Rotation);
			}
			if (this.Style != this.Style_DefaultValue)
			{
				hashtables.Add("style", this.Style);
			}
			if (this.Text != this.Text_DefaultValue)
			{
				hashtables.Add("text", this.Text);
			}
			offset = this.X;
			offsetDefaultValue = this.X_DefaultValue;
			if ((offset.GetValueOrDefault() == offsetDefaultValue.GetValueOrDefault() ? offset.HasValue != offsetDefaultValue.HasValue : true))
			{
				hashtables.Add("x", this.X);
			}
			offsetDefaultValue = this.Y;
			offset = this.Y_DefaultValue;
			if ((offsetDefaultValue.GetValueOrDefault() == offset.GetValueOrDefault() ? offsetDefaultValue.HasValue != offset.HasValue : true))
			{
				hashtables.Add("y", this.Y);
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