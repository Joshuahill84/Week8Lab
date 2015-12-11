using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week8Lab.Api.Models
{
    public class user
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;  }
        public virtual List<Post> Post { get; set; }
    }
}