using SavasLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasLibrary.Interface
{
    internal interface IHareketEden
    {
        Size HareketAlaniBoyutlari {  get; }

        int HareketMesafesi { get; }
        
        /// <summary>
        /// cismi istenilen yönde hareket ettirir.
        /// </summary>
        /// <param name="yon">hangi yöne hareket edileceği</param>
        /// <returns>cisim duvara çarparsa true döndürür</returns>
        bool HareketEttir(Yon yon);
    }
}
