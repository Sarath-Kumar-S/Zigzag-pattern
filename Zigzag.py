# Python3 program to prthe given 
# zigzag pattern 
  
# Function to prthe zigzag pattern  
def printPattern(n): 
      
    var = 0
    var = 1
      
    for i in range(1, n + 1): 
  
        # for odd rows 
        if(i % 2 != 0): 
              
            # calculate starting value 
            var = var + i - 1
            for j in range(1, i + 1): 
              
                if(j == 1): 
                  
                    print(var, end = "") 
                else: 
                    print("*", end = "") 
                    print(var, end = "") 
                      
                var += 1
              
          
        else: # for even rows 
                  
            var1 = var + i -1 # calculate starting value  
            for j in range(1, i + 1): 
              
                if(j == 1): 
                  
                    # prwithout star 
                    print(var1, end = "") 
                  
                else: 
                  
                    # prwith star 
                    print("*", end = "") 
                    print(var1, end = "") 
                  
                var1 -= 1
              
        print() 
      
# Driver code 
n = 5
  
printPattern(n) 
