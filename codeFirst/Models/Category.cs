using codeFirst.Models.Abstraction;
using System.Collections.Generic;

namespace codeFirst.Models
{
    public class Category :Entity
    {
        public string Name { get; set; }

        public List<Food> Foods { get; set; }

    }
}
