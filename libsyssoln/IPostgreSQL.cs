using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libsyssoln
{
    internal interface IPostgreSQL
    {
        string pgUser { get; set; }
        string pgPassword { get; set; }
        string pgDatabase { get; set; }
        int pgPort { get; set; }
        string ConString { get; }

    }
}
