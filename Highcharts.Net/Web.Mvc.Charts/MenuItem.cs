using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class MenuItem : BaseObject
	{
		public string OnClick
		{
			get;
			set;
		}

		public string Text
		{
			get;
			set;
		}

		public MenuItem()
		{
			this.Text = "";
			this.OnClick = "";
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (!string.IsNullOrEmpty(this.Text))
			{
				hashtables.Add("text", this.Text);
			}
			if (!string.IsNullOrEmpty(this.OnClick))
			{
				hashtables.Add("borderColor", this.OnClick);
			}
			return hashtables;
		}

		internal override string ToJSON()
		{
			return (new JavaScriptSerializer()).Serialize(this.ToHashtable());
		}
	}
}