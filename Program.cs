
using DPParser.Ingredient.Basic;
using DPParser.Ingredient;
using DPParser.Interpreter;
using DPParser.Operation.Simple;
using DPParser.Operation;
using DPParser.Operation.Complex;

Ingredient egg = new Egg();


// Création des recettes
CookingOrder TakeYellow = new CookingOrder(
    new SimpleOperationCookingOrder(new SimpleOperation("Prendre jaune")),
    new IngredientCookingOrder(new BasicIngredient("Oeuf"))
);

CookingOrder Mix = new CookingOrder(
    new NaryOperationCookingOrder(new NaryOperation("Mélanger"), new ICookingOrder[] {
                    TakeYellow,
                    new IngredientCookingOrder(new BasicIngredient("Moutarde")),
                    new IngredientCookingOrder(new BasicIngredient("Vinaigre"))
    })
);

CookingOrder Add = new CookingOrder(
    new NaryOperationCookingOrder(new NaryOperation("Ajouter"), new ICookingOrder[] {
                    Mix,
                    new IngredientCookingOrder(new BasicIngredient("Huile"))
    })
);

CookingOrder Mayonnaise = new CookingOrder(
    new SimpleOperationCookingOrder(new SimpleOperation("Touiller")),
    Add
);

CookingRecipeOrder MayonnaiseR = new CookingRecipeOrder(egg);
Console.WriteLine("ça cook :");
Mayonnaise.Interpret(MayonnaiseR);

Console.WriteLine(MayonnaiseR.Ingredient.Name);