using System.Reflection.Metadata.Ecma335;

namespace MathOperationsAPI.Services
{
    public class CalculationService : ICalculationService
    {
        public int add(int a, int b) => a + b;

        public int divide(int a, int b) => a / b;

        public int multiply(int a, int b) => a * b;

        public int subtract(int a, int b) => a - b;
    }
}
