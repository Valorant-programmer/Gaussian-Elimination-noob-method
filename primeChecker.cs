using System; 
namespace sheesh   
{
    class program
    { 
 static void Main()
        {

            //main user interface part
Console.Title="Mathematics hub"; 
Console.ForegroundColor =ConsoleColor.Green;
Console.WriteLine("Hi. What's your name?");
string userName= Convert.ToString(Console.ReadLine());
a:
Console.Clear(); 
Console.ForegroundColor=ConsoleColor.DarkYellow; 
string words= ("Hello "+ userName+ " \n I am an automated hub for mathematics function. \n Please Select any one of the below mentioned operations.  \n 1. Prime Number within specified range. \n 2. Twin prime within specified range. \n 3. Linear eqation");
Console.WriteLine(words); 
int choice= Convert.ToInt16(Console.ReadLine()); 
//user interface ends and begin of function refer. 
switch (choice)
{
    case 1:
    primeNumber(); 
    break; 

case 2:
twinPrime(); 
break; 

case 3:
linearEqation_input(); 
break; 
}




//linear equation
static void linearEqation_input()
{
Console.Clear();
Console.ForegroundColor=ConsoleColor.DarkYellow; 
Console.WriteLine("How many variables? \n (either 2 or 3)"); 
int variables=Convert.ToInt16(Console.ReadLine()); 
//array declaration 
        double[]x= new double[3];
        double[]y=new double[3]; 
        double[]z=new double [3] ;
        double[]constant=new double[3];
        double[]ratio_x=new double [3];  
        double[]ratio_y=new double [3]; 
        double[]ratio_z=new double [3]; 

switch (variables)
{
    case 2:
    //input part  
               for (int i = 0; i < 2; i++)
               {
                int j= i+1; 
                Console.Clear(); 
                Console.WriteLine("Hello. Welcome to 2 variable equation solver. "); 
                Console.ForegroundColor=ConsoleColor.DarkYellow;
                Console.WriteLine("Write coefficient of x in equation "+j); 
                x[i]=Convert.ToDouble(Console.ReadLine()); 
                Console.WriteLine("Write coefficient of y in equation "+j); 
                y[i]=Convert.ToDouble(Console.ReadLine());
                  Console.WriteLine("Write constant term in equation "+j); 
                  constant[i]=Convert.ToDouble(Console.ReadLine());
                  Console.WriteLine("Your equation "+j+" is        :"+x[i]+" x+ "+y[i]+" y + = "+constant[i]);
                  Console.WriteLine("Press any key to continue"); 
                  Console.ReadKey(); 
                 
               } 
break; 

        case 3:

        //input part  
               for (int i = 0; i < 3; i++)
               {
                int j= i+1; 
                Console.Clear(); 
                Console.WriteLine("Hello. Welcome to 3 variable equation solver. "); 
                Console.ForegroundColor=ConsoleColor.DarkYellow;
                Console.WriteLine("Write coefficient of x in equation "+j); 
                x[i]=Convert.ToDouble(Console.ReadLine()); 
                Console.WriteLine("Write coefficient of y in equation "+j); 
                y[i]=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Write coefficient of z in equation "+j); 
                 z[i]=Convert.ToDouble(Console.ReadLine());
                  Console.WriteLine("Write constant term in equation "+j); 
                  constant[i]=Convert.ToDouble(Console.ReadLine());
                  Console.WriteLine("Your equation "+j+" is        :"+x[i]+" x+ "+y[i]+" y +"+z[i]+" z = "+constant[i]);
                  Console.WriteLine("Press any key to continue"); 
                  Console.ReadKey(); 
                  
               }
break; 
}
//magic happens
//compariosion of row 1 and row 2 for x

if (variables==3)

Console.WriteLine("Your sets of equations are:");
for (int i = 0; i < 3; i++)
{
   Console.WriteLine( x[i]+"x + "+y[i]+"y +"+z[i]+"z      = "+constant[i]); 
}

if (variables==2)

Console.WriteLine("Your sets of equations are:");
for (int i = 0; i < 2; i++)
{
   Console.WriteLine( x[i]+"x + "+y[i]+"y      = "+constant[i]); 
}

while(x[1]!=0)
{
    double adish= lcm(x[0], x[1]); 
    ratio_x[0]= adish/x[0];
    ratio_x[1]=adish/x[1]; 

    x[0]=ratio_x[0]*x[0];
    y[0]=ratio_x[0]*y[0];
    z[0]=ratio_x[0]*z[0]; 
    constant[0]=ratio_x[0]*constant[0]; 



    x[1]=ratio_x[1]*x[1];
    y[1]=ratio_x[1]*y[1];
    z[1]=ratio_x[1]*z[1]; 
    constant[1]=ratio_x[1]*constant[1]; 

    x[1]=x[0]-x[1];
    y[1]=y[0]-y[1]; 
    z[1]=z[0]-z[1]; 
    constant[1]=constant[0]-constant[1]; 
}
//check for pivot
    if (x[0]!=0)
    {
        
    }
    else 
    {
    if (x[1]!=0) 
    {
        x[0]=x[1];
        y[0]=y[1];
        z[0]=z[1];
        constant[0]=constant[1]; 
            }
            else
            {
                x[0]=x[2];
                y[0]=y[2]; 
                z[0]=z[2];
                constant[0]=constant[2]; 
            }
    }

if (y[1]!=0)
    {
        
    }
    else
    { 
    if (y[0]!=0) 
    {
        x[1]=x[0];
        y[1]=y[0];
        z[1]=z[0];
        constant[1]=constant[0]; 
            }
            else
            {
                x[1]=x[2];
                y[1]=y[2]; 
                z[1]=z[2];
                constant[1]=constant[2]; 
            }
    }


            if (z[2]!=0)
    {
       
    }
    else 
 {
    if (z[0]!=0) 
    {
        x[2]=x[0];
        y[2]=y[0];
        z[2]=z[0];
        constant[2]=constant[0]; 
            }
            else
            {
                x[2]=x[1];
                y[2]=y[1]; 
                z[2]=z[1];
                constant[2]=constant[1]; 
            }
 }








    //comparision of row 1 and row 3 for x


while (x[2]!=0)
{
    double adish1= lcm(x[0], x[2]); 
    ratio_x[0]= adish1/x[0];
    ratio_x[2]=adish1/x[2]; 

    x[0]=ratio_x[0]*x[0];
    y[0]=ratio_x[0]*y[0];
    z[0]=ratio_x[0]*z[0]; 
    constant[0]=ratio_x[0]*constant[0]; 



    x[2]=ratio_x[2]*x[2];
    y[2]=ratio_x[2]*y[2];
    z[2]=ratio_x[2]*z[2]; 
    constant[2]=ratio_x[2]*constant[2]; 

    x[2]=x[0]-x[2];
    y[2]=y[0]-y[2]; 
    z[2]=z[0]-z[2]; 
    constant[2]=constant[0]-constant[2]; 
}




//check for pivot
    if (x[0]!=0)
    {
       
    }
    else{ 
    if (x[1]!=0) 
    {
        x[0]=x[1];
        y[0]=y[1];
        z[0]=z[1];
        constant[0]=constant[1]; 
            }
            else
            {
                x[0]=x[2];
                y[0]=y[2]; 
                z[0]=z[2];
                constant[0]=constant[2]; 
            }
    }

if (y[1]!=0)
    {
        
    }
    else{ 
    if (y[0]!=0) 
    {
        x[1]=x[0];
        y[1]=y[0];
        z[1]=z[0];
        constant[1]=constant[0]; 
            }
            else
            
            {
                x[1]=x[2];
                y[1]=y[2]; 
                z[1]=z[2];
                constant[1]=constant[2]; 
            }
    }


            if (z[2]!=0)
    {
       
    }
    else{ 
    if (z[0]!=0) 
    {
        x[2]=x[0];
        y[2]=y[0];
        z[2]=z[0];
        constant[2]=constant[0]; 
            }
            else
           
            {
                x[2]=x[1];
                y[2]=y[1]; 
                z[2]=z[1];
                constant[2]=constant[1]; 
            }
    }




    
    
    //comparision of row 2 and row 3 for y
    
    while (y[2]!=0)
    {
    double adish2= lcm(y[1], y[2]); 
    ratio_y[1]=adish2/y[1]; 
    ratio_y[2]=adish2/y[2]; 

x[1]=ratio_y[1]*x[1]; 
    y[1]=ratio_y[1]*y[1]; 
    z[1]=ratio_y[1]*z[1]; 
    constant[1]=ratio_y[1]*constant[1]; 


x[2]=ratio_y[2]*x[2]; 
    y[2]=ratio_y[2]*y[2]; 
    z[2]=ratio_y[2]*z[2]; 
    constant[2]=ratio_y[2]*constant[2];

x[2]=x[1]-x[2];
    y[2]=y[1]-y[2]; 
    z[2]=z[1]-z[2]; 

    constant[2]=constant[1]-constant[2]; 
    }


//check for pivot
    if (x[0]!=0)
    {
        
    }
    else {
    if (x[1]!=0) 
    {
        x[0]=x[1];
        y[0]=y[1];
        z[0]=z[1];
        constant[0]=constant[1]; 
            }
            else
            
            {
                x[0]=x[2];
                y[0]=y[2]; 
                z[0]=z[2];
                constant[0]=constant[2]; 
            }
    }
if (y[1]!=0)
    {
        
    }
    else
    { 
    if (y[0]!=0) 
    {
        x[1]=x[0];
        y[1]=y[0];
        z[1]=z[0];
        constant[1]=constant[0]; 
            }
            else
            {
                x[1]=x[2];
                y[1]=y[2]; 
                z[1]=z[2];
                constant[1]=constant[2]; 
            }}

            if (z[2]!=0)
    {
        
    }
    else {
    if (z[0]!=0) 
    {
        x[2]=x[0];
        y[2]=y[0];
        z[2]=z[0];
        constant[2]=constant[0]; 
            }
            else
            
            {
                x[2]=x[1];
                y[2]=y[1]; 
                z[2]=z[1];
                constant[2]=constant[1]; 
            }}




//comparision of row 3 and row 1 for z

while (z[0]!=0)
{
 double adish3= lcm(z[2], z[0]); 
    ratio_z[0]= adish3/z[0];
    ratio_z[2]=adish3/z[2]; 

    x[0]=ratio_z[0]*x[0];
    y[0]=ratio_z[0]*y[0];
    z[0]=ratio_z[0]*z[0]; 
    constant[0]=ratio_z[0]*constant[0]; 



    x[2]=ratio_z[2]*x[2];
    y[2]=ratio_z[2]*y[2];
    z[2]=ratio_z[2]*z[2]; 
    constant[2]=ratio_z[2]*constant[2]; 

    x[0]=x[2]-x[0];
    y[0]=y[2]-y[0]; 
    z[0]=z[2]-z[0]; 
    constant[0]=constant[2]-constant[0];
}


//check for pivot
    if (x[0]!=0)
    {
       
    }
    else 
    {
    if (x[1]!=0) 
    {
        x[0]=x[1];
        y[0]=y[1];
        z[0]=z[1];
        constant[0]=constant[1]; 
            }
            else
            
            {
                x[0]=x[2];
                y[0]=y[2]; 
                z[0]=z[2];
                constant[0]=constant[2]; 
            }
    }

if (y[1]!=0)
    {
       
    }
    else{ 
    if (y[0]!=0) 
    {
        x[1]=x[0];
        y[1]=y[0];
        z[1]=z[0];
        constant[1]=constant[0]; 
            }
            else
            
            {
                x[1]=x[2];
                y[1]=y[2]; 
                z[1]=z[2];
                constant[1]=constant[2]; 
            }
    }


            if (z[2]!=0)
    {
       
    }
    else 
    {
    if (z[0]!=0) 
    {
        x[2]=x[0];
        y[2]=y[0];
        z[2]=z[0];
        constant[2]=constant[0]; 
            }
            else
            
            {
                x[2]=x[1];
                y[2]=y[1]; 
                z[2]=z[1];
                constant[2]=constant[1]; 
            }
    }


//comparision of row 3 and row 2 for z
while  (z[1]!=0)
{
 double adish4= lcm(z[2], z[1]); 
    ratio_z[1]= adish4/z[1];
    ratio_z[2]=adish4/z[2]; 

    x[1]=ratio_z[1]*x[1];
    y[1]=ratio_z[1]*y[1];
    z[1]=ratio_z[1]*z[1]; 
    constant[1]=ratio_z[1]*constant[1]; 



    x[2]=ratio_z[2]*x[2];
    y[2]=ratio_z[2]*y[2];
    z[2]=ratio_z[2]*z[2]; 
    constant[2]=ratio_z[2]*constant[2]; 

    x[1]=x[2]-x[1];
    y[1]=y[2]-y[1]; 
    z[1]=z[2]-z[1]; 
    constant[1]=constant[2]-constant[1];

}
  
//check for pivot
    if (x[0]!=0)
    {
       
    }
    else
    { 
    if (x[1]!=0) 
    {
        x[0]=x[1];
        y[0]=y[1];
        z[0]=z[1];
        constant[0]=constant[1]; 
            }
            else
            
            {
                x[0]=x[2];
                y[0]=y[2]; 
                z[0]=z[2];
                constant[0]=constant[2]; 
            }
    }

if (y[1]!=0)
    {
       
    }
    else {
    if (y[0]!=0) 
    {
        x[1]=x[0];
        y[1]=y[0];
        z[1]=z[0];
        constant[1]=constant[0]; 
            }
            else
           
            {
                x[1]=x[2];
                y[1]=y[2]; 
                z[1]=z[2];
                constant[1]=constant[2]; 
            }}


            if (z[2]!=0)
    {
        
    }
    else 
    {
    if (z[0]!=0) 
    {
        x[2]=x[0];
        y[2]=y[0];
        z[2]=z[0];
        constant[2]=constant[0]; 
            }
            else
           
            {
                x[2]=x[1];
                y[2]=y[1]; 
                z[2]=z[1];
                constant[2]=constant[1]; 
            }

    }
  
    //comparision of row 2 and row 3 for y

    while (y[0]!=0)
    {
  double adish5= lcm(y[1], y[0]); 
    ratio_y[1]=adish5/y[1]; 
    ratio_y[0]=adish5/y[0]; 

x[1]=ratio_y[1]*x[1]; 
    y[1]=ratio_y[1]*y[1]; 
    z[1]=ratio_y[1]*z[1]; 
    constant[1]=ratio_y[1]*constant[1]; 


    x[0]=ratio_y[0]*x[0]; 
    y[0]=ratio_y[0]*y[0]; 
    z[0]=ratio_y[0]*z[0]; 
    constant[0]=ratio_y[0]*constant[0];

    x[0]=x[1]-x[0];
    y[0]=y[1]-y[0]; 
    z[0]=z[1]-z[0]; 

    constant[0]=constant[1]-constant[0]; 

    }
//check for pivot
    if (x[0]!=0)
    {
    }
    else 
    {
    if (x[1]!=0) 
    {
        x[0]=x[1];
        y[0]=y[1];
        z[0]=z[1];
        constant[0]=constant[1]; 
            }
            else
           
            {
                x[0]=x[2];
                y[0]=y[2]; 
                z[0]=z[2];
                constant[0]=constant[2]; 
            }
    }

if (y[1]!=0)
    {
    }
    else{ 
    if (y[0]!=0) 
    {
        x[1]=x[0];
        y[1]=y[0];
        z[1]=z[0];
        constant[1]=constant[0]; 
            }
            else
           
            {
                x[1]=x[2];
                y[1]=y[2]; 
                z[1]=z[2];
                constant[1]=constant[2]; 
            }
    }


            if (z[2]!=0)
    {
    }
    else {
    if (z[0]!=0) 
    {
        x[2]=x[0];
        y[2]=y[0];
        z[2]=z[0];
        constant[2]=constant[0]; 
            }
            else
          
            {
                x[2]=x[1];
                y[2]=y[1]; 
                z[2]=z[1];
                constant[2]=constant[1]; 
            }
    }

double   ans_x= constant[0]/x[0];
double ans_y=constant[1]/y[1]; 
double ans_z=constant[2]/z[2]; 


if (variables==2)
{
    Console.WriteLine("The solution for x="+ans_x);
Console.WriteLine("The Solutiopn for y="+ans_y);
}

if (variables==3)
{
    
Console.WriteLine("The solution for x="+ans_x);
Console.WriteLine("The Solutiopn for y="+ans_y);
Console.WriteLine("The solution for z="+ans_z);
}

}


//lcm function for linear equation
static double gcf(double a, double b)
{
    while (b != 0)
    {
        double temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

static double lcm(double a, double b)
{
    return   (a / gcf(a, b)) * b;
}
//linear function ends        


               
      




            //prime funciton
static void primeNumber()
{
    Console.ForegroundColor= ConsoleColor.DarkYellow; 
 Console.Clear();    
    Console.WriteLine("Hello. I am an Automated  Prime Checker. \n Enter the desired range");
int target= Convert.ToInt16(Console.ReadLine());
    int o=0; 
Console.WriteLine("The prime numbers in the specified range are:");
for (int i = 1; i <= target; i++)
{
    int c=0;  
for (int j = 1; j <=i; j++)
{
    if (i%j==0)
{ 
    c=c+1; 
}
}
if (c==2)
{
    Console.WriteLine(i);
o=o+1; 
}
}
Console.WriteLine("Total Prime within the specified range= "+o); 
}



//twin prime function
static void twinPrime()
{
    
    Console.Clear();
    Console.ForegroundColor=ConsoleColor.DarkYellow; 
     int o=0; 
            // program here
Console.WriteLine("Hello. I am an Automated  twin Prime Checker. \n Enter the desired range");
int target= Convert.ToInt16(Console.ReadLine());
Console.WriteLine("The prime numbers in the specified range are:");
for (int i = 1; i <= target; i++)
{
    int c=0;  
for (int j = 1; j <=i; j++)
{
    if (i%j==0)
{ 
    c=c+1; 
}
}
if (c==2)
{
int target2= i+2; 
int y=0; 
for (int p = 1; p <= target2; p++)
{
if (target2%p==0)
{
y=y+1; 
}    
    }
    if (y==2)
    {
        Console.WriteLine("("+i+","+target2+")");
        o=o+1; 
    }
}
}


Console.WriteLine("Total  Twinprime in specified range="+o);
}

//readkey broo and refer to go again. 
Console.ReadKey();  
      Console.WriteLine("Hey "+userName+" wanna go again? (Y/N)");
string sheesh= Convert.ToString(Console.ReadLine()); 
 string harry=sheesh.ToUpper(); 
if (harry=="Y")
{
    goto a;
}
      
        }
    }
}






 

 