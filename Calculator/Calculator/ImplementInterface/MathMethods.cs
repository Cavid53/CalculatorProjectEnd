using CalculationProject;
using Calculator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.ImplementInterface
{
    public class MathMethods : IMathematical
    {
        private  CalculatorSoap _calculatorSoap;

        public MathMethods(CalculatorSoap calculatorSoap)
        {
            _calculatorSoap = calculatorSoap;
        }
        public async Task<int> AddAsync(int firstNum, int secondNum)
        {
            return await _calculatorSoap.AddAsync(firstNum, secondNum);
        }

        public async Task<int> DivideAsync(int firstNum, int secondNum)
        {
            return await _calculatorSoap.DivideAsync(firstNum, secondNum);
        }

        public async Task<int> MultiplyAsync(int firstNum, int secondNum)
        {
            return await _calculatorSoap.MultiplyAsync(firstNum, secondNum);
        }

        public async Task<int> SubtractAsync(int firstNum, int secondNum)
        {
            return await _calculatorSoap.SubtractAsync(firstNum, secondNum);
        }
    }
}
