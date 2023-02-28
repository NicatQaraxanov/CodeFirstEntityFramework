using codeFirst.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirst.Models
{
    public class Followed : Entity
    {
        public int UserId { get; set; }

        public User User { get; set; }

    }
}
