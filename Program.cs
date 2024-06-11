// A callback refers to some code passed as an argument to another code block that executes it later

//we have made two classes; A and B. A has the Main function defined and instantiates an object of class B.
using System.Security.Claims;

public class A
{
    public delegate void send_back(int num);
    static void Main(String[] args)
    {
        // THE CLASS B(THE FIRST CALLBACK METHOD)
        B func = new B();
        func.send_back(callbackMethod);

        // DELEGATE METHOD
        send_back handle = callbackMethod;
        handle(4);
    }

    static void callbackMethod(int number)
    {
        Console.WriteLine("The number is: " + number);
    }
}

// THE CLASS B (THE FIRST CALLBACK METHOD)
public class B
{
    // we have made a method that takes the function as a parameter and then invokes that function
    public void send_back(Action<int> Callback)
    {
        Callback(4);
    }
}

