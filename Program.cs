using System;
/*public class Demo
{
   public static int add(int a, int b)
   {
       return a + b;
   }
   public static int add(int a, int b, int c)
   {
       return a + b + c;
   }
   public static int add(int a, int b, int c, int d)
   {
       return a + b + c + d;
   }

}
public class Program
{
   public static void Main()
   {
       Console.WriteLine("Addition of two numbers: " + Demo.add(2, 4));
       Console.WriteLine("Addition of three numbers: " + Demo.add(2, 4, 6));
       Console.WriteLine("Addition of four numbers: " + Demo.add(2, 4, 6, 8));
   }
}*/
/*
 class Animal

{
    public virtual void animalsound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}
class Dog : Animal
{
    public override void animalsound()
    {
        Console.WriteLine("The Dog says:vhau vhau"); 
    }
}
class Frog:Animal
{
    public override void animalsound()
        {
        Console.WriteLine("The Frog says:twar twar");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        Animal myDog = new Dog();
        Animal myFrog=new Frog();

        myAnimal.animalsound();
        myDog.animalsound();
        myFrog.animalsound();  
    }
*/


/*
namespace muliplyExample
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int num1 = 1, num2 = 2, num3, num4;
            Console.Write("Enter Size of Numbers : ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Multiplication of last two numbers");
            Console.Write(num1 + " " + num2 + " ");
            for (int i = 2; i < num3; i++)
            {
                num4 = num1 * num2;
                Console.Write(num4 + " ");
                num1 = num2;
                num2 = num4;
            }
            Console.ReadKey();

        }
    }
}
public class patternexample
{
    public static void Main(string[]args)
    {
        int i, j, k, l, n;
        Console.WriteLine("enter the range =");
        n=int.Parse(Console.ReadLine());
        for(i=1;i<=n;i++)
        {
            for (j = 1; j <=n-i; j++)
            {
                Console.Write(" ");

            }
            for(k=1;k<=i ; k++)
            {
                Console.Write(k);
            }
            for(l=i-1;l>=1 ; l--)
            {
                Console.Write(l);   
            }
            Console.Write("\n");

           

            }
        }

    }
/*interface IVehicle
{
    void vehiclemodel();
}
class Car:IVehicle
{ 
    public void vehiclemodel()
    {
        Console.WriteLine("BMW has a also a two wheeler"); 
   }
 }
class Jeep : IVehicle
{
    public void vehiclemodel()
    {
        Console.WriteLine("Ford has only four wheeler ");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        Jeep myJeep = new Jeep();
        myCar.vehiclemodel();
        myJeep.vehiclemodel();
    }
}
*/