using System;
using System.Collections;
using System.Collections.Generic;

namespace Highsoft.Web.Mvc.Charts
{
	public abstract class BaseObject
	{
		protected BaseObject()
		{
		}

		internal List<Hashtable> HashifyList(IEnumerable list)
		{
			List<Hashtable> hashtables = new List<Hashtable>();
			foreach (BaseObject baseObject in list)
			{
				hashtables.Add(baseObject.ToHashtable());
			}
			return hashtables;
		}

		internal abstract bool IsDirty();

		internal abstract Hashtable ToHashtable();

		internal abstract string ToJSON();
	}
}