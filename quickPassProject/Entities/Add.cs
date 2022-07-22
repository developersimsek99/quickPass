using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace quickPassProject.Entities
{
    public class Add
    {
        public string add()
        {
            Guid random = Guid.NewGuid();
            string sender = random.ToString().Substring(0, 8);
            return sender;
        }
    }
}