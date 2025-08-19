using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.DAL.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public int Description { get; set; }
        [ForeignKey("Use")]
        public int UserId { get; set; }

        public User Use { get; set; }
    }
}
