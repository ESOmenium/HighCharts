using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class Navigation : BaseObject
	{
		public NavigationButtonOptions ButtonOptions
		{
			get;
			set;
		}

		private NavigationButtonOptions ButtonOptions_DefaultValue
		{
			get;
			set;
		}

		public Hashtable MenuItemHoverStyle
		{
			get;
			set;
		}

		private Hashtable MenuItemHoverStyle_DefaultValue
		{
			get;
			set;
		}

		public Hashtable MenuItemStyle
		{
			get;
			set;
		}

		private Hashtable MenuItemStyle_DefaultValue
		{
			get;
			set;
		}

		public Hashtable MenuStyle
		{
			get;
			set;
		}

		private Hashtable MenuStyle_DefaultValue
		{
			get;
			set;
		}

		public Navigation()
		{
			NavigationButtonOptions navigationButtonOption = new NavigationButtonOptions();
			NavigationButtonOptions navigationButtonOption1 = navigationButtonOption;
			this.ButtonOptions_DefaultValue = navigationButtonOption;
			this.ButtonOptions = navigationButtonOption1;
			Hashtable hashtables = new Hashtable()
			{
				{ "background", "#335cad" },
				{ "color", "#ffffff" }
			};
			Hashtable hashtables1 = hashtables;
			Hashtable hashtables2 = hashtables1;
			this.MenuItemHoverStyle_DefaultValue = hashtables1;
			this.MenuItemHoverStyle = hashtables2;
			hashtables = new Hashtable()
			{
				{ "padding", "0.5em 1em" },
				{ "color", "#333333" },
				{ "background", "none" }
			};
			Hashtable hashtables3 = hashtables;
			hashtables2 = hashtables3;
			this.MenuItemStyle_DefaultValue = hashtables3;
			this.MenuItemStyle = hashtables2;
			hashtables = new Hashtable()
			{
				{ "border", "1px solid #999999" },
				{ "background", "#ffffff" },
				{ "padding", "5px 0" }
			};
			Hashtable hashtables4 = hashtables;
			hashtables2 = hashtables4;
			this.MenuStyle_DefaultValue = hashtables4;
			this.MenuStyle = hashtables2;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.ButtonOptions.IsDirty())
			{
				hashtables.Add("buttonOptions", this.ButtonOptions.ToHashtable());
			}
			if (this.MenuItemHoverStyle != this.MenuItemHoverStyle_DefaultValue)
			{
				hashtables.Add("menuItemHoverStyle", this.MenuItemHoverStyle);
			}
			if (this.MenuItemStyle != this.MenuItemStyle_DefaultValue)
			{
				hashtables.Add("menuItemStyle", this.MenuItemStyle);
			}
			if (this.MenuStyle != this.MenuStyle_DefaultValue)
			{
				hashtables.Add("menuStyle", this.MenuStyle);
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