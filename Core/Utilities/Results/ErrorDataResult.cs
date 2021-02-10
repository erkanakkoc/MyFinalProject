using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {
            //hem mesaj hemde data verir
        }
        public ErrorDataResult(T data) : base(data, false)
        {
            //sadece data ver
        }
        public ErrorDataResult(string message) : base(default, false, message)
        {
            //sadece mesaj ver
        }
        public ErrorDataResult() : base(default, false)
        {
            //hiç bir şey verme
        }
    }
}
