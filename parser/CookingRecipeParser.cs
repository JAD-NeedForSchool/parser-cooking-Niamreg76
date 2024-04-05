using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserCookingRecipe.parser
{
    internal class CookingRecipeParser
    {
        private readonly char OpenCharacter = '(';
        private readonly char CloseCharacter = ')';
        private readonly char SeparatorCharacter = ' ';
        
        public RecipeTree TextToTree(string Text)
        {
            RecipeTree tree = new RecipeTree(null);
            string token = "";
            int openCount = 0;
            int closeCount = 0;
            foreach (char character in Text)
            {
                if (character == OpenCharacter)
                {
                    openCount += 1;
                    if (openCount == 1)
                    {
                        tree.AddSubRecipe(new RecipeTree(token));
                        token = "";
                    }
                }
                else if (character == CloseCharacter)
                {
                    closeCount += 1;
                    if (closeCount == 1)
                    {
                        tree.AddSubRecipe(new RecipeTree(token));
                        token = "";
                    }
                }
                else if (character == SeparatorCharacter)
                {
                    if (openCount == closeCount)
                    {
                        tree.AddSubRecipe(new RecipeTree(token));
                        token = "";
                    }
                    else
                    {
                        token += character;
                    }
                }
                else
                {
                    token += character;
                    Console.WriteLine(token);
                }
            }
            return tree;
        }   
    }
}
