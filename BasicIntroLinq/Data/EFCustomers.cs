using System.Collections.Generic;
using BasicIntroLinq.Data;
using BasicIntroLinq.Models;

namespace BasicIntroLinq.Data
{
    public class EFCustomers : IGeneric<Customer>
    {
        private DataStreams _pds = new DataStreams();

        public List<Customer> Get => _pds.CustomerStream();
    }

}