using System;
using System.ComponentModel.DataAnnotations;

namespace HelloDocker.Web.Model
{
    public class Blog
    {
        public Blog()
        {}

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
