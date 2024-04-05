// Création d'ingrédients
using DPParser.Ingredient.Basic;
using DPParser.Ingredient;
using DPParser.Interpreter;
using DPParser.Operation.Simple;
using DPParser.Operation;

Ingredient egg = new Egg();
Ingredient salad = new Salad();

SimpleOperation cutOperation = new Cut();
SimpleOperation chopOperation = new Chop();

CookingRecipeOrder recipeOrder1 = new CookingRecipeOrder(egg);
CookingRecipeOrder recipeOrder2 = new CookingRecipeOrder(salad);

ICookingOrder order1 = new SimpleOperationCookingOrder(cutOperation);
ICookingOrder order2 = new SimpleOperationCookingOrder(chopOperation);
ICookingOrder order3 = new IngredientCookingOrder(egg);
ICookingOrder order4 = new IngredientCookingOrder(salad);

order1.Interpret(recipeOrder1);
order2.Interpret(recipeOrder2);
order3.Interpret(recipeOrder1);
order4.Interpret(recipeOrder2);