using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class Shadow : BaseObject
	{
		public string Color
		{
			get;
			set;
		}

		public bool Enabled
		{
			get;
			set;
		}

		public int OffsetX
		{
			get;
			set;
		}

		public int OffsetY
		{
			get;
			set;
		}

		public double Opacity
		{
			get;
			set;
		}

		public int Width
		{
			get;
			set;
		}

		public Shadow()
		{
			this.Enabled = false;
			this.Color = "";
			this.OffsetX = 0;
			this.OffsetY = 0;
			this.Opacity = 0;
			this.Width = 0;
		}

		internal override bool IsDirty()
		{
			return (this.Enabled ? true : this.ToHashtable().Count > 0);
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (!string.IsNullOrEmpty(this.Color))
			{
				hashtables.Add("color", this.Color);
			}
			if (this.OffsetX != 0)
			{
				hashtables.Add("offsetX", this.OffsetX);
			}
			if (this.OffsetY != 0)
			{
				hashtables.Add("offsetY", this.OffsetY);
			}
			if (this.Opacity != 0)
			{
				hashtables.Add("opacity", this.Opacity);
			}
			if (this.Width != 0)
			{
				hashtables.Add("width", this.Width);
			}
			return hashtables;
		}

		internal override string ToJSON()
		{
			string str;
			str = (this.ToHashtable().Count <= 0 ? this.Enabled.ToString().ToLower() : (new JavaScriptSerializer()).Serialize(this.ToHashtable()));
			return str;
		}
	}
}