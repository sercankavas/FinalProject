using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        

        public Result(bool success, string message) :this(success)
        {
            Message = message;
            //Success = success; bu kod 2. constructordan alarak calistiralim. ustteki: dan itibaren 
        }

        public Result(bool success)
        {
            
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
