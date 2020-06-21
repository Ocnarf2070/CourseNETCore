using LinqToDB;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Conection : DataConnection
    {
        public Conection() : base("School") { }
       public ITable<Studient> _Studient { get => GetTable<Studient>(); }

    }
}
