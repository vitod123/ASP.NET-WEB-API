using Ardalis.Specification;
using Core.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public static class Makes
    {
        public class OrderedByName : Specification<Make>
        {
            public OrderedByName()
            {
                Query
                    .OrderBy(m => m.Name);
            }
        }
        public class ById : Specification<Make>
        {
            public ById(int id)
            {
                Query
                    .Where(m => m.Id == id);
            }
        }
    }
}
