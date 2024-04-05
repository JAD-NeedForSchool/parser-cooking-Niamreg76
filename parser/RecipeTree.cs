namespace ParserCookingRecipe.parser
{
    public class RecipeTree(String Token)
    {
        public String Token { get; set; } = Token;

        public List<RecipeTree> SubRecipeTrees { get; set; } = [];

        public void AddSubRecipe(RecipeTree SubRecipeTree)
        {
            SubRecipeTrees.Add(SubRecipeTree);
        }
    }
}