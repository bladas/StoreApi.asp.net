using System;
using System.Collections.Generic;
using System.Text;

namespace Store.BLL.Infrastructure
{
    public class OperationDetails
    {
        public OperationDetails() { }
        public OperationDetails(bool succedeed, string message, string prop)
        {
            Succeeded = succedeed;
            Message = message;
            Property = prop;
        }
        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public string Property { get; set; }
    }
}
