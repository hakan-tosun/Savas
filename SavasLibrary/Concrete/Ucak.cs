using SavasLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SavasLibrary.Concrete
{
    internal class Ucak : Cisim
    {
        private static readonly Random Random = new Random();
        public Ucak(Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {
            HareketMesafesi = (int)(Height * .1);

            int sutunSayisi = hareketAlaniBoyutlari.Width / Width;
            int rastgeleSutun = Random.Next(0, sutunSayisi);
            Left = rastgeleSutun * Width;
        }

        public Mermi VurulduMu(List<Mermi> mermiler)
        {
            foreach (var mermi in mermiler)
            {
                var vurulduMu = mermi.Top < Bottom && mermi.Right > Left && mermi.Left < Right;
                if (vurulduMu) return mermi;
            }

            return null;
        }
    }
}
