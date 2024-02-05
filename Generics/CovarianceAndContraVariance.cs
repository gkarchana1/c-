using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Animal
    {
        public void Eat() => Console.WriteLine("Eat");
    }

    public class Bird : Animal {

        public void Fly() => Console.WriteLine("Fly");
    }

    class CovarianceAndContraVariance
    {
        delegate Animal ReturnAnimalDelegate();
        delegate Bird ReturnBirdDelegate();

        //COVARIANCE
        public static Bird GetBird() => new Bird();
        public static Animal GetAnimal() => new Animal();


        //CONTRA
        delegate void TakeAnimalDelegate(Animal a);
        delegate void TakeBirdDelegate(Bird b);

        public static void Eat(Animal a) => a.Eat();
        public static void Fly(Bird b) => b.Fly();

        static void Main(string[] args)
        {
            //COVARIANCE

            //  Animal a = new Bird();
            /* ReturnAnimalDelegate d11 = GetBird;
             ReturnAnimalDelegate d12 = GetAnimal;


             ReturnBirdDelegate d21 = GetBird;
             ReturnBirdDelegate d22 = GetAnimal;*/



            //CONTRAVARIANCE

        /*    TakeBirdDelegate d41 = Eat;
            TakeBirdDelegate d42 = Fly;

            TakeAnimalDelegate d51 = Eat;
            TakeAnimalDelegate d52 = Fly;*/


        }

    }
}
