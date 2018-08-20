using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VNCloudWeb.Services
{
    public interface ITodoService
    {
		Task<int> GetIncompleteItemsAsync();
	}
}
