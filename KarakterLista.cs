namespace karakterek
{
   class KarakterLista
   {
      public List<Karakter> Karakterek { get; set; }

      public KarakterLista(List<Karakter>? karakterek)
      {
         Karakterek = karakterek ?? new List<Karakter>();
      }

      public void KarakterHozzaad(Karakter karakter)
      {
         Karakterek.Add(karakter);
      }

      public void KarakterekListaz()
      {
         foreach (var karakter in Karakterek)
         {
            karakter.KarakterInfo();
         }
      }
   }
}