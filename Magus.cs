namespace karakterek
{
   class Magus : Karakter
   {
      private bool tudTamadni;
      private int mana;
      public int Mana { get => mana; set {
         mana = value;
         if (mana <= 0)
         {
            Medital();
         }
      } }

      public Magus(string nev, int ero, int egeszseg, int mana = 50) : base(nev, ero, 10, egeszseg)
      {
         Mana = mana;
         tudTamadni = true;
      }

      public void Medital()
      {
         Mana += 20;
         tudTamadni = false;
      }

      public override void Gyogyul()
      {
         base.Gyogyul();
         Egeszseg += 5;
         Mana -= 5;
      }

      public override int Tamad()
      {
         if (tudTamadni)
         {
            Mana -= 5;
            return base.Tamad() + 1;
         }
         else
         {
            tudTamadni = true;
            return 0;
         }
      }

      public override int Vedekezik()
      {
         int pluszDmg = tudTamadni ? 5 : 10;
         tudTamadni = true;

         return base.Vedekezik() - pluszDmg;
      }
   }
}