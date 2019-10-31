using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Interface
{
    public interface IMathematical
    {
        Task<int> AddAsync(int firstNum, int secondNum);
        Task<int> SubtractAsync(int firstNum, int secondNum);
        Task<int> MultiplyAsync(int firstNum, int secondNum);
        Task<int> DivideAsync(int firstNum, int secondNum);
    }
}
