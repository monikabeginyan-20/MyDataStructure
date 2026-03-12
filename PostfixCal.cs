
using System.Numerics;
using System.Security.Principal;

namespace PostfixAlgorithm;

public class Program
{
    private static void Main()
    {
        foreach token
            if token is integer
            push token
                else if token is operator
                    pop right - side value
                    pop left - side value
                    evaluate operator
                    push result 
        next
    }
}
