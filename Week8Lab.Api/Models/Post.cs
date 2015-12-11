using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week8Lab.Api.Models
{
    public class Post
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Title { get; set; }
            public string Text { get; set; }
            public string URL { get; set; }
            public DateTime PostTime { get; set; }
    }
}