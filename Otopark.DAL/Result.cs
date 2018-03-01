using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.DAL
{
    public class Result
    {
        public bool IsSucceded { get; set; }
        public int returnResult { get; set; }
        public Result()
        {
            IsSucceded = false; //defaultta false çektik
        }
    }
    public class Result<T> : Result
    {
        public T TransactionResult { get; set; }
    }
}
