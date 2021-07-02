using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
            // Righ-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers
        public int AddTool(int numOne, int numTwo, int numThree)
        {
            int answer = numOne + numTwo + numThree;
            return answer;
        }

        // Create a Subtract method that passes 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend
        public int SubtractTool(int numOne, int numTwo)
        {
            int answer = numOne - numTwo;
            return answer;
        }

        // Create a Multiply method that passes 2 integers
        public int MultiplyTool(int numOne, int numTwo)
        {
            int answer = numOne * numTwo;
            return answer;
        }

        // Create a Divide method that passes 2 integers
        public int DivideTool(int numOne, int numTwo)
        {
            int answer = numOne / numTwo;
            return answer;
        }


        // Create 2 methods that will utilize the [Fact] tests you wrote
        public string SayHello()
        {
            return "Hello";
        }
        public int PlusMinus(int numOne, int numTwo, int numThree)
        {
            int answer = numOne + numTwo - numThree;
            return answer;
        }



    }
}
