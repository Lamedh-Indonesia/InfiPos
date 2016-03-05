using System;
using System.Collections.Generic;
using InfiPos.Core;

namespace InfiPos.Infras.Data.InMemory
{
    public class ProductMemRepo : MemoryRepoBase<Product>
    {
        public override List<Product> Search(string key)
        {
            throw new NotImplementedException();
        }
    }
}
