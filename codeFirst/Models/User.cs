using codeFirst.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirst.Models
{
    public class User : Entity
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int PhotoId { get; set; }

        public Media Photo { get; set; }

        public List<Follower> Followers { get; set; }


        public List<Followed> Followeds { get; set; }

        public List<Review> Reviews { get; set; }



    }
}
