using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPParser.Interpreter
{
    class CookingRecipeOrder
    {
        DPParser.Ingredient.Ingredient ingredient { get; set; }

        public CookingRecipeOrder(DPParser.Ingredient.Ingredient ingredient)
        {
            this.ingredient = ingredient;
        }
    }
}
