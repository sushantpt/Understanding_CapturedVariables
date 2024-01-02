// See https://aka.ms/new-console-template for more information
using Understanding_CapturedVariables.Classes;

Console.WriteLine("Hello, World!");


List<int> someNumbers = new List<int> { 1, 5, 6, 9, 4, 2, 7, 11, 3, 16 };
Example eg = new Example();
int sum = eg.sumOfList(someNumbers); // invokes the delegate which invokes the anonymous function.
Console.WriteLine(sum);



Console.WriteLine("Sum of odd numbers which are less than 6 in the list.");
int sumOfOddNums = eg.sumOfOddNums(someNumbers);
Console.WriteLine(sumOfOddNums);



eg.squaredValTest();


Action<int> action = eg.IncrementCounterAction(5);
action(2);


Console.WriteLine("---- Closure examples ----");

// understanding closures

Action closureAction = eg.CreateCounterAction();
closureAction();
closureAction();
closureAction();
closureAction();


Console.WriteLine("---- Closure examples (in loop)----");


Action[] closureLoopActions = eg.ClosureActionInLoop();
foreach(var loopAction in closureLoopActions)
{
    loopAction();
}

Console.WriteLine("---- Closure examples (in loop: fixed)----");


Action[] fixedClosureLoopActions = eg.FixedClosureActionInLoop();
foreach(var loopAction in fixedClosureLoopActions)
{
    loopAction();
}
