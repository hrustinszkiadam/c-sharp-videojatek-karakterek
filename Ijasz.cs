namespace karakterek
{
   class Ijasz : Karakter
   {
      public Ijasz(string nev, int ero, int egeszseg) : base(nev, ero, 7, egeszseg)
      {

      }

      public override int Vedekezik()
      {
         Random rnd = new Random();
         if (rnd.Next(1, 5) == 1)
            return int.MaxValue;
         else
            return base.Vedekezik();
      }
   }
}