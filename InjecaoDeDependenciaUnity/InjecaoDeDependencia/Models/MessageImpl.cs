using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InjecaoDeDependencia.Models
{
    public class MessageImpl : IMessage
    {
        public string Message()
        {
            return "Hello World!!";
        }
    }
}