using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPParser.Interpreter
{
    class CookingRecipeOrder
    {
        public DPParser.Ingredient.Ingredient Ingredient { get; set; }

        public CookingRecipeOrder(DPParser.Ingredient.Ingredient ingredient)
        {
            this.Ingredient = ingredient;
        }
    }
}
