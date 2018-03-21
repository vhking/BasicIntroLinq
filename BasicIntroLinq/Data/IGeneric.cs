using System.Collections.Generic;
using BasicIntroLinq.Models;

namespace BasicIntroLinq.Data
{
    public interface IGeneric<T> where T : class
    {
        List<T> Get {get;}
    }
}