using codeFirst.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirst.Models
{
    public class Media : Entity
    {
        public string Url { get; set; }

        public string Name { get; set; }

        public User User { get; set; }

        public Food Food { get; set; }

    }
}
