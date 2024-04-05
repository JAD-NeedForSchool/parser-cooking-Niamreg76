using DPParser.Operation.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPParser.Interpreter
{
    class SimpleOperationCookingOrder : ICookingOrder
    {
        SimpleOperation operation {  get; set; }

        void ICookingOrder.Interpret(CookingRecipeOrder context)
        {
            Console.WriteLine($"Simple operation '{operation.Name}' pour '{context.Ingredient.Name}'  ");
        }

        public SimpleOperationCookingOrder(SimpleOperation operation)
        {
            this.operation = operation;
        }
    }
}
