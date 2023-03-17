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
    public static class Cars
    {
        public class GetAll : Specification<Car>
        {
            public GetAll()
            {
                Query
                    .Include(c => c.Model)
                    .Include(c => c.Model)
                    .Include(c => c.Engine)
                    .Include(c => c.Year);
            }
        }
        public class OrderedByModelName : Specification<Car>
        {
            public OrderedByModelName()
            {
                Query
                    .Include(c => c.Model)
                    .OrderBy(c => c.Model.Name)
                    .Include(c => c.Model)
                    .Include(c => c.Engine)
                    .Include(c => c.Year);
            }
        }
        public class OrderedByMakeName : Specification<Car>
        {
            public OrderedByMakeName()
            {
                Query
                    .Include(c => c.Make)
                    .OrderBy(c => c.Make.Name)
                    .Include(c => c.Model)
                    .Include(c => c.Engine)
                    .Include(c => c.Year);
            }
        }
        public class OrderedByCountry : Specification<Car>
        {
            public OrderedByCountry()
            {
                Query
                    .Include(c => c.Make)
                    .OrderBy(c => c.Make.Country)
                    .Include(c => c.Model)
                    .Include(c => c.Engine)
                    .Include(c => c.Year);
            }
        }
        public class OrderedByYear : Specification<Car>
        {
            public OrderedByYear()
            {
                Query
                    .Include(c => c.Year)
                    .OrderBy(c => c.Year.Date)
                    .Include(c => c.Make)
                    .Include(c => c.Model)
                    .Include(c => c.Engine);
            }
        }
        public class OrderedByMaxSpeed : Specification<Car>
        {
            public OrderedByMaxSpeed()
            {
                Query
                    .OrderBy(c => c.MaxSpeed)
                    .Include(c => c.Make)
                    .Include(c => c.Model)
                    .Include(c => c.Engine)
                    .Include(c => c.Year);
            }
        }
        public class ById : Specification<Car>
        {
            public ById(int id)
            {
                Query
                    .Where(c => c.Id == id)
                    .Include(c => c.Make)
                    .Include(c => c.Model)
                    .Include(c => c.Engine)
                    .Include(c => c.Year);
            }
        }
    }
}
