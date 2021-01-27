using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //GamerManager gamerManager = new GamerManager(new UserValidationManager());
            //gamerManager.Add(new Gamer { Id = 1, BirthYear = 1985, FirstName = "Engin", LastName = "Demirog", IdentityNumber = 12345 });

            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1985, FirstName = "Engin", LastName = "Demirog", IdentityNumber = 12345 });
        }
    }
}
