using System; 
namespace W_Program
{
    class program
    {
        static void Main(string[]args  )
        {

            
            //program here
        //array declaration 
        double[]x= new double[3];
        double[]y=new double[3]; 
        double[]z=new double [3] ;
        double[]constant=new double[3];
        double[]ratio_x=new double [3];  
        double[]ratio_y=new double [3]; 
        double[]ratio_z=new double [3]; 
        //input part  
               for (int i = 0; i < 3; i++)
               {
                int j= i+1; 
                Console.Clear(); 
                Console.WriteLine("Hello. Welcome to 3 variable equation solver. "); 
                Console.ForegroundColor=ConsoleColor.Green;
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
//magic happens
//compariosion of row 1 and row 2 for x

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


Console.WriteLine("The solution for x="+ans_x);
Console.WriteLine("The Solutiopn for y="+ans_y);
Console.WriteLine("The solution for z="+ans_z);


    
    



//lcm function
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
 
 




                

               

        
             


            
            
            
            
            //readkey
            Console.ReadKey(); 
        }
    }
}
