namespace karakterek
{
   class Harcos : Karakter
   {
      public int Pancel { get; set; }

      public Harcos(string nev, int ero, int egeszseg) : base(nev, ero + 5, 1, egeszseg)
      {
         Pancel = 5;
      }

      public override int Vedekezik()
      {
         return base.Vedekezik() + Pancel;
      }
   }
}