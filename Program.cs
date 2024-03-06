using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karakterek
{
   internal class Program
   {
      static void Main(string[] args)
      {
         KarakterLista karakterek = new KarakterLista(new List<Karakter>() {
            new Magus("Gandalf", 5, 100),
            new Harcos("Conan", 10, 100),
            new Ijasz("Legolas", 7, 100),
            new Pankrator("Hercules", 8, 100)
         });

         karakterek.KarakterekListaz();
         Console.WriteLine();
         
         Harc.Harcol(karakterek.Karakterek[0], karakterek.Karakterek[1]);

         Harc.Harcol(karakterek.Karakterek[2], karakterek.Karakterek[3]);

         Console.ReadKey();
      }
   }
}