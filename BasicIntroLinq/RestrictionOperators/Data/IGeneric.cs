using System.Collections.Generic;
using BasicIntroLinq.RestrictionOperators.Models;

namespace BasicIntroLinq.RestrictionOperators.Data
{
    public interface IGeneric<T> where T : class
    {
        List<T> Get {get;}
    }
}