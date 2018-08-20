using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace VNCloudWeb.Services
{
    public class TodoService : ITodoService
    {
		public Task<int> GetIncompleteItemsAsync() 
		{
			return Task.FromResult(1);
		}

	}
}
