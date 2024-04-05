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
        NaryOperation[] operations { get; set; }
        void ICookingOrder.Interpret(CookingRecipeOrder context)
        {
            Console.WriteLine("ça cook");
        }

        public NaryOperationCookingOrder(NaryOperation[] operations)
        {
            this.operations = operations;
        }
    }
}
