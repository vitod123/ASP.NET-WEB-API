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
    public static class Years
    {
        public class OrderedByData : Specification<Year>
        {
            public OrderedByData()
            {
                Query
                    .OrderBy(y => y.Date);
            }
        }
        public class ById : Specification<Year>
        {
            public ById(int id)
            {
                Query
                    .Where(y => y.Id == id);
            }
        }
    }
}
