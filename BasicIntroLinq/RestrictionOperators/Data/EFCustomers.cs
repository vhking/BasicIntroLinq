using System.Collections.Generic;
using BasicIntroLinq.RestrictionOperators.Models;

namespace BasicIntroLinq.RestrictionOperators.Data
{
    public class EFCustomers : IGeneric<Customer>
    {
        private DataStreams _pds = new DataStreams();

        public List<Customer> Get => _pds.CustomerStream();
    }

}