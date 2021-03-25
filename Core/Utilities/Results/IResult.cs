using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //begining of basic voids
    public interface IResult
    {
        bool Success { get; } //yapilan islem basarili ise true basarisizsa false
        string Message { get; }//bu da ustteki sonucu bir mesajla bilgilendirir
    }
}
