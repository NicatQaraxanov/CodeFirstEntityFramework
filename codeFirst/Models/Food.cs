using codeFirst.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirst.Models
{
    public class Food : Entity
    {
        public string Name { get; set; }

        public int? PhotoId { get; set; }

        public int CategoryId { get; set; }

        public int RestaurantId { get; set; }

        public double Rating { get; set; }

        public double Price { get; set; }

        public Media Photo { get; set; }

        public Category Category { get; set; }

        public Restaurant Restaurant { get; set; }

        public List<Review> Reviews { get; set; }
    }
}
