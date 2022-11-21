using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp1.Other
{
    public class LearnJoin
    {
        public void FullOuterJoin()
        {
            var firstNames = new[]
                {
                    new { ID = 1, Name = "John" },
                    new { ID = 2, Name = "Sue" },
                };
            var lastNames = new[]
                {
                    new { ID = 1, Name = "Doe" },
                    new { ID = 3, Name = "Smith" },
                };
            var leftOuterJoin = from first in firstNames
                                join last in lastNames
                                on first.ID equals last.ID
                                into temp
                                from last in temp.DefaultIfEmpty(new { first.ID, Name = default(string) })
                                select new
                                {
                                    first.ID,
                                    FirstName = first.Name,
                                    LastName = last.Name,
                                };
            //var leftOuterJoin = from first in firstNames
            //                    join last in lastNames
            //                    on first.ID equals last.ID
            //                    into temp
            //                    from last in temp.DefaultIfEmpty()
            //                    select new
            //                    {
            //                        first.ID,
            //                        FirstName = first.Name,
            //                        LastName = last != null ? last.Name : default(string),
            //                    };
            Console.WriteLine("Left Join:" + JsonConvert.SerializeObject(leftOuterJoin));
            var rightOuterJoin = from last in lastNames
                                 join first in firstNames
                                 on last.ID equals first.ID
                                 into temp
                                 from first in temp.DefaultIfEmpty(new { last.ID, Name = default(string) })
                                 select new
                                 {
                                     last.ID,
                                     FirstName = first.Name,
                                     LastName = last.Name,
                                 };
            Console.WriteLine("Right Join:" + JsonConvert.SerializeObject(rightOuterJoin));
            var fullOuterJoin = leftOuterJoin.Union(rightOuterJoin);
            Console.WriteLine("Full Join:" + JsonConvert.SerializeObject(fullOuterJoin));

        }
    }
}
