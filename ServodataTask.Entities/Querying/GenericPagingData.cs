using System;
using System.Collections.Generic;

namespace ServodataTask.Entities.Querying
{
    public class GenericPagingData<T>
    { 
        public GenericPagingData(long count, List<T> items)
        {
            TotalCount = count;
            Items = items;
        }

        public GenericPagingData()
        {

        }

        public long TotalCount { get; set; }

        public List<T> Items { get; set; }

        public DateTime GenerationDateTime => DateTime.UtcNow;
    }
}