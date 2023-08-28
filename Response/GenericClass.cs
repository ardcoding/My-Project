using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Response
{
    public class Response<T>
    {
        public bool IsSuccess { get; private set; }
        public T Data { get; private set; }
        public IEnumerable<string> Errors { get; private set; }

        private Response(bool isSuccess, T data, IEnumerable<string> errors)
        {
            IsSuccess = isSuccess;
            Data = data;
            Errors = errors;
        }

        public static Response<T> Success(T data)
        {
            return new Response<T>(true, data, null);
        }

        public static Response<T> Error(IEnumerable<string> errors)
        {
            return new Response<T>(false, default(T), errors);
        }
    }
}
