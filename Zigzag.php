<?php 
// PHP program to print the given  
// zigzag pattern  
  
// Function to print the zigzag pattern  
function printPattern($n)  
{  
    $var1; $var = 1;  
      
    for($i = 1; $i <= $n; $i++)  
    {  
        // for odd rows  
        if($i % 2 != 0)  
        {  
            // calculate starting value  
            $var = $var + $i - 1;  
            for($j = 1; $j <= $i; $j++)  
            {  
                if($j == 1)  
                {  
                    echo $var;  
                }  
                else
                    echo "*" . $var;  
                      
                $var++;  
            }  
        }  
        else // for even rows  
        {      
            // calculate starting value  
            $var1 = $var + $i - 1;  
            for($j = 1; $j <= $i; $j++)  
            {  
                if($j == 1)  
                {  
                    // print without star  
                    echo $var1;  
                }  
                else
                {  
                    // print with star  
                    echo "*" . $var1;  
                }  
                $var1--;  
            }  
        }  
        echo "\n";  
    }  
      
}  
  
// Driver code  
$n = 5;  
  
printPattern($n);  
  

?> 
