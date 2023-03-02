using System;

namespace GamesProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            //mernis doğrulama yepyeni bir sisteme geçtiği zaman burda ki new kısmıyla değişebiliriz.
            //Onu da yeni oluşturduğumuz sınıfı doğrulama ile implamante ettiğmiz zaman yapabiiriz.
            gamerManager.Add(new Gamer                                                
            {
                Id = 1,
                BirthYear=1998,
                FirstName="Furkan",
                LastName="KARATAŞ",
                IdentityNumber= 9874654

            });

           
        }
    }
}
