using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class Background : BaseObject
	{
		public string BackgroundColor
		{
			get;
			set;
		}

		public string BorderColor
		{
			get;
			set;
		}

		public int BorderWidth
		{
			get;
			set;
		}

		public string InnerRadius
		{
			get;
			set;
		}

		public int InnerWidth
		{
			get;
			set;
		}

		public string OuterRadius
		{
			get;
			set;
		}

		public int OuterWidth
		{
			get;
			set;
		}

		public string Shape
		{
			get;
			set;
		}

		public Background()
		{
			this.BackgroundColor = "";
			this.InnerWidth = 0;
			this.OuterWidth = 0;
			this.BorderWidth = 0;
			this.BorderColor = "";
			this.InnerRadius = "";
			this.OuterRadius = "";
			this.Shape = "";
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (!string.IsNullOrEmpty(this.BackgroundColor))
			{
				hashtables.Add("backgroundColor", this.BackgroundColor);
			}
			if (!string.IsNullOrEmpty(this.BorderColor))
			{
				hashtables.Add("borderColor", this.BorderColor);
			}
			if (!string.IsNullOrEmpty(this.Shape))
			{
				hashtables.Add("shape", this.Shape);
			}
			if (!string.IsNullOrEmpty(this.InnerRadius))
			{
				hashtables.Add("innerRadius", this.InnerRadius);
			}
			if (!string.IsNullOrEmpty(this.OuterRadius))
			{
				hashtables.Add("outerRadius", this.OuterRadius);
			}
			if (this.InnerWidth != 0)
			{
				hashtables.Add("innerWidth", this.InnerWidth);
			}
			if (this.OuterWidth != 0)
			{
				hashtables.Add("outerWidth", this.OuterWidth);
			}
			if (this.BorderWidth != 0)
			{
				hashtables.Add("borderWidth", this.BorderWidth);
			}
			return hashtables;
		}

		internal override string ToJSON()
		{
			return (new JavaScriptSerializer()).Serialize(this.ToHashtable());
		}
	}
}