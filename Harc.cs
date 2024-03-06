namespace karakterek
{
   static class Harc
   {
      public static void Harcol(Karakter karakter1, Karakter karakter2)
      {
         Console.WriteLine($"{karakter1.Nev} vs {karakter2.Nev}!");

         Karakter tamado = new Random().Next(0, 2) == 0 ? karakter1 : karakter2;

         Console.WriteLine($"{tamado.Nev} kezdi a támadást!\n");

         while (karakter1.Egeszseg > 0 && karakter2.Egeszseg > 0)
         {
            Karakter vedo = tamado == karakter1 ? karakter2 : karakter1;
            Console.WriteLine($"{tamado.Nev} támadja {vedo.Nev}-t!");

            int dmgReduction = vedo.Vedekezik();
            int dmg = tamado.Tamad() - dmgReduction;
            if(dmg < 0)
            {
               dmg = 0;
            }
            Console.WriteLine($"{vedo.Nev} védekezése miatt a sebzés: {dmg} pont!");

            vedo.Egeszseg -= dmg;
            if (new Random().Next(0, 4) == 0)
            {
               vedo.Gyogyul();
               Console.WriteLine($"{vedo.Nev} gyógyul!");
            }

            Console.WriteLine($"{vedo.Nev} életereje: {vedo.Egeszseg} pont!\n");

            tamado = vedo;
         }

         if (karakter1.Egeszseg > 0)
         {
            Console.WriteLine($"{karakter1.Nev} nyert!");
         }
         else
         {
            Console.WriteLine($"{karakter2.Nev} nyert!");
         }
         Console.WriteLine("\n");
      }
   }
}