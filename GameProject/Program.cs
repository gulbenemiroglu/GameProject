using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            Gamer gamer1=new Gamer(){ Id = 1, FirstName = "Gülben", LastName = "Emiroğlu", BirthYear = 1992, IdentityNumber = 12345, userName = "zuddurubuduk" };
            Gamer gamer2 = new Gamer() { Id = 2, FirstName = "Erdem", LastName = "Emiroğlu", BirthYear = 1992, IdentityNumber = 12345, userName = "zuddurubuduk" };

            gamerManager.Add(gamer1);
            gamerManager.Update(gamer1, "gulben");
            gamerManager.Delete(gamer1);

            gamerManager.Add(gamer2);
            gamerManager.Update(gamer2, "gulben");
            gamerManager.Delete(gamer2);
        }
    }
}
