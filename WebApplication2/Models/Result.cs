using System.Collections.Generic;
namespace WebApplication2.Models
{
    public class Result<T>
    {
        public Result(int count, List<T> items)
        {
            Count = count;
            Items = items;
        }

        public int Count { get; private set; }
        public List<T> Items { get; private set; }
    }
}