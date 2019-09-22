using System;

namespace Highsoft.Web.Mvc.Charts
{
	internal static class CompiledOn
	{
		internal static DateTime CompilationDate;

		static CompiledOn()
		{
			CompiledOn.CompilationDate = new DateTime(2017, 4, 6);
		}
	}
}