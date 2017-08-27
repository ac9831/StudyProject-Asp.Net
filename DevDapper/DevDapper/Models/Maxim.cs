using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevDapper.Models
{
    public class Maxim
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
    }
}