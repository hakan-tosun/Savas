using SavasLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasLibrary.Interface
{
    internal interface IOyun
    {
        bool DevamEdiyorMu {  get; }
        TimeSpan GecenSure {  get; }
        void Baslat();
        void AtesEt();
        void UcaksavariHareketEttir(Yon yon);
    }
}
