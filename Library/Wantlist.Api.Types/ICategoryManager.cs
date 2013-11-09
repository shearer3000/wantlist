
using System.Collections.Generic;

namespace Wantlist.Api.Types
{
	public interface ICategoryManager
	{
		IEnumerable<Category> GetCategoryStructure();
	}
}
