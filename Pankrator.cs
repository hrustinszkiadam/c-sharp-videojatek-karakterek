namespace karakterek
{
   class Pankrator : Karakter
   {
      public Pankrator(string nev, int ero, int egeszseg) : base(nev, ero + 5, 3, egeszseg)
      {
      }

      public override int Tamad()
      {
         return base.Tamad() + 3;
      }
   }
}