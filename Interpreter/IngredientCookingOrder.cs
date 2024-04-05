using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPParser.Interpreter
{
    class IngredientCookingOrder : ICookingOrder
    {
        DPParser.Ingredient.Ingredient ingredient { get; set; }
        public void Interpret(CookingRecipeOrder context)
        {
            Console.WriteLine($"Ajout de l'ingredient {ingredient.Name} à la recette");
        }

        public IngredientCookingOrder(DPParser.Ingredient.Ingredient ingredient)
        {
            this.ingredient = ingredient;
        }
    }
}
