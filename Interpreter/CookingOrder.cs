using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPParser.Interpreter
{
    internal class CookingOrder : ICookingOrder
    {
        private ICookingOrder[] orders;
        public CookingOrder(params ICookingOrder[] orders) 
        {
            this.orders = orders;
        }
        public void Interpret(CookingRecipeOrder context)
        {
            foreach (var order in orders)
            {
                order.Interpret(context);
            }
        }
    }
}
