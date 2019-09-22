using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Highsoft.Web.Mvc.Charts
{
	public class Symbol : BaseObject
	{
		public Highsoft.Web.Mvc.Charts.SymbolEnum SymbolEnum
		{
			get;
			set;
		}

		public string Url
		{
			get;
			set;
		}

		public Symbol()
		{
			this.Url = "";
			this.SymbolEnum = Highsoft.Web.Mvc.Charts.SymbolEnum.Null;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.Url != null)
			{
				hashtables.Add("symbol", this.Url);
			}
			else if (this.SymbolEnum != Highsoft.Web.Mvc.Charts.SymbolEnum.Null)
			{
				Highsoft.Web.Mvc.Charts.SymbolEnum symbolEnum = this.SymbolEnum;
				hashtables.Add("symbol", symbolEnum.ToString().ToLower());
			}
			return hashtables;
		}

		internal override string ToJSON()
		{
			string str;
			if (this.Url == null)
			{
				str = (this.SymbolEnum == Highsoft.Web.Mvc.Charts.SymbolEnum.Null ? "" : this.SymbolEnum.ToString().ToLower());
			}
			else
			{
				str = this.Url.ToString();
			}
			return str;
		}
	}
}