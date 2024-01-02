namespace Understanding_CapturedVariables.Classes
{
    public class Example
    {

        public int externalVariable = 7;

        // A delegate with lambda expression to get the total sum of a list.
        public Func<List<int>, int> sumOfList = (listOfNums) => listOfNums.Sum();

        // A delegate with lambda expression to get the total sum of odd numbers that are less than 6 a list.
        public Func<List<int>, int> sumOfOddNums = (listOfNums) => listOfNums.Where(x => x < 6 && x % 2 != 0).Sum();


        // captured variable.
        public Func<int, int> squaredVal = x => x * x;


        public Action<int> IncrementCounterAction(int incrementBy)
        {
            int defaultNumber = 2;
            Action<int> action = input =>
            {
                Console.WriteLine($"Default counter value: {defaultNumber}");
                int result = input + defaultNumber + incrementBy;
                Console.WriteLine($"Increment action by (method argument): {incrementBy}");
                Console.WriteLine($"Sum of method argument, lambda argument, and default local method value: {result}");
            };
            // update default number.
            defaultNumber = 10; 
            return action;
        }


        public void squaredValTest()
        {
            
            Console.WriteLine($"External variable: {externalVariable}");

            Console.WriteLine(squaredVal(externalVariable));

            // modify externalVariable
            externalVariable = 5;

            Console.WriteLine($"External variable after modified to 5: {externalVariable}");

            Console.WriteLine(squaredVal(externalVariable));
        }


        /// <summary>
        /// Example of forming closures.
        /// </summary>
        /// <returns></returns>
        public Action CreateCounterAction()
        {
            int incrementBy = 5;
            // here, action doesnt take any arguments.
            Action action = () => 
            {
                incrementBy++;
                Console.WriteLine($"Counter at: {incrementBy}");
            };

            return action;
        }



        public Action[] ClosureActionInLoop()
        {
            Action[] actions = new Action[4];
            for(int i = 0; i < 4; i++)
            {
                actions[i] = () => Console.WriteLine(i);
            }
            return actions;
        }
        
        
        public Action[] FixedClosureActionInLoop()
        {
            Action[] actions = new Action[4];
            for(int i = 0; i < 4; i++)
            {
                int localVar = i; // introduce local variable to let closure remember
                actions[i] = () => Console.WriteLine(localVar);
            }
            return actions;
        }
    }
}
