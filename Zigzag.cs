// C# program to print the given  
// zigzag pattern  
using System; 
class GFG 
{ 
// Function to print the  
// zigzag pattern  
static void printPattern(int n)  
{  
    int var1, var = 1;  
      
    for(int i = 1; i <= n; i++)  
    {  
        // for odd rows  
        if(i % 2 != 0)  
        {  
            // calculate starting value  
            var = var + i - 1;  
            for(int j = 1; j <= i; j++)  
            {  
                if(j == 1)  
                {  
                    Console.Write(var);  
                }  
                else
                    Console.Write("*" + var);  
                      
            var++;  
            }  
        }  
        else // for even rows  
        {      
            var1 = var + i -1; // calculate starting value  
            for(int j = 1; j <= i; j++)  
            {  
                if(j == 1)  
                {  
                    // print without star  
                    Console.Write(var1);  
                }  
                else
                {  
                    // print with star  
                    Console.Write("*" + var1);  
                }  
                var1--;  
            }  
        }  
        Console.Write("\n");  
    }  
      
}  
  
// Driver code  
public static void Main()  
{  
    int n = 5;  
      
    printPattern(n);  
} 
}  
