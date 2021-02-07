using System;

namespace GameSaleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, DogumYili = 1984, Adi = "Emre", Soyad = "Keskiner", TcKimlikNo = 12345 });
        }
    }
}
