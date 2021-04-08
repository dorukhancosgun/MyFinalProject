using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        private bool v1;
        private string v2;
                                                  
        public Result(bool success, string message): this(success)
        {
            Message = message;
           
        }
        public Result(bool success)
        {           
            Success = success;
        }

        //Gets are `read only` and can be set in constractors.
        public bool Success { get; }

        public string Message { get; }
    }
}
