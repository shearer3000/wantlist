
using System.Collections.Generic;

namespace Wantlist.Api.Types
{
	public class Category
	{
		public string Number { get; set; }
		public string Name { get; set; }

		public IEnumerable<Category> SubCategories { get; set; }
	}
}
