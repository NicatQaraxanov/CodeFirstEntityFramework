using codeFirst.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirst.Models
{
    public class Review : Entity
    {
        public int UserId { get; set; }

        public string Content { get; set; }

        public int Raiting { get; set; }

        public int FoodId { get; set; }

        public User User { get; set; }

        public Food Food { get; set; }


    }
}
