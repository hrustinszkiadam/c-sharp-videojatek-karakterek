namespace karakterek
{
   class Karakter
   {
      public string Nev { get; set; }
      public int Ero { get; set; }
      public int Ugyesseg { get; set; }
      private int Hp { get; set; }
      public int Egeszseg { get => Hp; set => Hp = value < 0 ? 0 : value; }

      public Karakter(string nev, int ero, int ugyesseg, int egeszseg)
      {
         Nev = nev;
         Ero = ero;
         Ugyesseg = ugyesseg;
         Egeszseg = egeszseg;
      }

      public void KarakterInfo()
      {
         Console.WriteLine($"Név: {Nev}, Erő: {Ero}, Ügyesség: {Ugyesseg}, Egészség: {Egeszseg}");
      }

      public virtual void Gyogyul()
      {
         Egeszseg += 10;
      }

      public virtual int Tamad()
      {
         return Ero + Ugyesseg;
      }

      public virtual int Vedekezik()
      {
         return 0;
      }
   }
}