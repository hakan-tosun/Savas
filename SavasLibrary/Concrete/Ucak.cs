using SavasLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasLibrary.Concrete
{
    internal class Ucak : Cisim
    {
        private static readonly Random Random = new Random();
        public Ucak(Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {
            int sutunSayisi = hareketAlaniBoyutlari.Width / Width;
            int rastgeleSutun = Random.Next(0, sutunSayisi);
            Left = rastgeleSutun * Width;
        }
    }
}
