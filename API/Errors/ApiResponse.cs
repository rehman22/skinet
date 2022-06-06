using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string messege = null)
        {
            StatusCode = statusCode;
            Messege = messege ??GetDefaultMessegeForStatusCode(statusCode);
        }

       

        public int StatusCode { get; set; }
        public string Messege { get; set; }

         private string GetDefaultMessegeForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "bad request you made",
                401 => "Autorized, You are not",
                404 => "Resource found , i am not",
                500 => "server Error",
                _ => null
            };
        }
        
    }
}