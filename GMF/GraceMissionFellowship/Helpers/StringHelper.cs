using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace GraceMissionFellowship.Helpers
{
	public class StringHelper
	{
		public static string AddSpaceToCamelCase(string text)
		{
			return Regex.Replace(text, "(\\B[A-Z])", " $1");
		}
	}
}