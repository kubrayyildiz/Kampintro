using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamermanager = new GamerManager(new UserValidationManager());
            gamermanager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1985,
                FirstName = "Engin",
                LastName = "demiroğ",
                InendtityNumber = 123456789
            });
        }
    }
}
