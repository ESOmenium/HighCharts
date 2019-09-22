using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;

namespace Highsoft.Web.Mvc.Charts
{
	public class ExportingButtons : BaseObject
	{
		public ExportingButtonsContextButton ContextButton
		{
			get;
			set;
		}

		private ExportingButtonsContextButton ContextButton_DefaultValue
		{
			get;
			set;
		}

		public ExportingButtons()
		{
			ExportingButtonsContextButton exportingButtonsContextButton = new ExportingButtonsContextButton();
			ExportingButtonsContextButton exportingButtonsContextButton1 = exportingButtonsContextButton;
			this.ContextButton_DefaultValue = exportingButtonsContextButton;
			this.ContextButton = exportingButtonsContextButton1;
		}

		internal override bool IsDirty()
		{
			return this.ToHashtable().Count > 0;
		}

		internal override Hashtable ToHashtable()
		{
			Hashtable hashtables = new Hashtable();
			if (this.ContextButton.IsDirty())
			{
				hashtables.Add("contextButton", this.ContextButton.ToHashtable());
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