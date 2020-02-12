using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulacka
{
    class Calculator
    {
        class NumberOperation<T1, T2>
        {
            public T1 Number { get; set; }

            public T2 Operation { get; set; }

            public NumberOperation(T1 number, T2 operation)
            {
                Number = number;
                Operation = operation;
            }
        }
        
        List<NumberOperation<double, Operation>> Operations;

        public Calculator()
        {
            Operations = new List<NumberOperation<double, Operation>>();
        }

        public void AddOperation(double number, Operation type)
        {
            if (Operations.Count == 0)
                type = Operation.Add;

            Operations.Add(new NumberOperation<double, Operation>(number, type));
        }

        public void ClearOperations()
        {
            Operations.Clear();
        }

        public double ComputeOperations()
        {
            double output = 0;
            
            foreach (var step in Operations)
            {
                Operation type = step.Operation;

                if (type == Operation.Add)
                    output += step.Number;
                else if (type == Operation.Substract)
                    output -= step.Number;
                else if (type == Operation.Multiply)
                    output *= step.Number;
                else if (type == Operation.Divide)
                    output /= step.Number;
                else if (type == Operation.SquareRoot)
                    output = Math.Sqrt(output);
            }

            Operations.Clear();

            return output;
        }
    }
}
