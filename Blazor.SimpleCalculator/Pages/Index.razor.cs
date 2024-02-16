namespace Blazor.SimpleCalculator.Pages
{
    public partial class Index
    {
        private Calculator calculator = new Calculator();
        private int result;
        private int firstNumber;
        private int secondNumber;
        private Operation operation = Operation.Add;

        private void Add() => result = calculator.Add(firstNumber, secondNumber);
        private void Subtract() => result = calculator.Subtract(firstNumber, secondNumber);
        private void Multiply() => result = calculator.Multiply(firstNumber, secondNumber);
        private void Divide() => result = calculator.Divide(firstNumber, secondNumber);

        private void Calculate()
        {
            switch (operation)
            {
                case Operation.Add:
                    Add();
                    break;
                case Operation.Subtract:
                    Subtract();
                    break;
                case Operation.Multiply:
                    Multiply();
                    break;
                case Operation.Divide:
                    Divide();
                    break;
            }
        }
    }
}
