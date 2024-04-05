using DPParser.Operation;
using DPParser.Operation.Complex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPParser.Interpreter
{
    class NaryOperationCookingOrder : ICookingOrder
    {
        NaryOperation operation { get; set; }
        ICookingOrder[] subOrders { get; set; }
        void ICookingOrder.Interpret(CookingRecipeOrder context)
        {
            Console.WriteLine($"n-ary operation '{operation.Name}' for '{context.Ingredient.Name}'");
            foreach (var subOrder in subOrders)
            {
                subOrder.Interpret(context);
            }
        }

        public NaryOperationCookingOrder(NaryOperation operation, ICookingOrder[] subOrders)
        {
            this.operation = operation;
            this.subOrders = subOrders;
        }
    }
}
