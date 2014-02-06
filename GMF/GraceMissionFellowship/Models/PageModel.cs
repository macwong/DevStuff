using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GraceMissionFellowship.Helpers;

namespace GraceMissionFellowship.Models
{
	public class PageModel
	{
		public PageType Type;

		public PageModel(PageType type)
		{
			this.Type = type;
		}
	}
}