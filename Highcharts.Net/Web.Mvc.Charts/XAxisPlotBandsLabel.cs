using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class XAxisPlotBandsLabel : BaseObject
	{
		public string Align
		{
			get;
			set;
		}

		private string Align_DefaultValue
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

		public string TextAlign
		{
			get;
			set;
		}

		private string TextAlign_DefaultValue
		{
			get;
			set;
		}

		public bool? UseHTML
		{
			get;
			set;
		}

		private bool? UseHTML_DefaultValue
		{
			get;
			set;
		}

		public string VerticalAlign
		{
			get;
			set;
		}

		private string VerticalAlign_DefaultValue
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

		public XAxisPlotBandsLabel()
		{
			string str = "center";
			string str1 = str;
			this.Align_DefaultValue = str;
			this.Align = str1;
			double? nullable = new double?(0);
			this.Rotation_DefaultValue = nullable;
			this.Rotation = nullable;
			Hashtable hashtables = new Hashtable();
			Hashtable hashtables1 = hashtables;
			this.Style_DefaultValue = hashtables;
			this.Style = hashtables1;
			object obj = null;
			str1 = (string)obj;
			this.Text_DefaultValue = (string)obj;
			this.Text = str1;
			object obj1 = null;
			str1 = (string)obj1;
			this.TextAlign_DefaultValue = (string)obj1;
			this.TextAlign = str1;
			bool? nullable1 = new bool?(false);
			this.UseHTML_DefaultValue = nullable1;
			this.UseHTML = nullable1;
			string str2 = "top";
			str1 = str2;
			this.VerticalAlign_DefaultValue = str2;
			this.VerticalAlign = str1;
			nullable = null;
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
				hashtables.Add("align", this.Align);
			}
			double? rotation = this.Rotation;
			double? rotationDefaultValue = this.Rotation_DefaultValue;
			if ((rotation.GetValueOrDefault() == rotationDefaultValue.GetValueOrDefault() ? rotation.HasValue != rotationDefaultValue.HasValue : true))
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
			if (this.TextAlign != this.TextAlign_DefaultValue)
			{
				hashtables.Add("textAlign", this.TextAlign);
			}
			bool? useHTML = this.UseHTML;
			bool? useHTMLDefaultValue = this.UseHTML_DefaultValue;
			if ((useHTML.GetValueOrDefault() == useHTMLDefaultValue.GetValueOrDefault() ? useHTML.HasValue != useHTMLDefaultValue.HasValue : true))
			{
				hashtables.Add("useHTML", this.UseHTML);
			}
			if (this.VerticalAlign != this.VerticalAlign_DefaultValue)
			{
				hashtables.Add("verticalAlign", this.VerticalAlign);
			}
			rotationDefaultValue = this.X;
			rotation = this.X_DefaultValue;
			if ((rotationDefaultValue.GetValueOrDefault() == rotation.GetValueOrDefault() ? rotationDefaultValue.HasValue != rotation.HasValue : true))
			{
				hashtables.Add("x", this.X);
			}
			rotation = this.Y;
			rotationDefaultValue = this.Y_DefaultValue;
			if ((rotation.GetValueOrDefault() == rotationDefaultValue.GetValueOrDefault() ? rotation.HasValue != rotationDefaultValue.HasValue : true))
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