using System.Collections.Generic;
using BasicIntroLinq.Data;
using BasicIntroLinq.Models;

namespace BasicIntroLinq.RestrictionOperators.Data
{
    public class EFProducts : IGeneric<Product>
    {
        private DataStreams _pds = new DataStreams();

        public List<Product> Get => _pds.ProductStream();
    }
}