using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libsyssoln
{
    interface IPostgreSQL
    {
        string pgUser { get; set; }
        string pgPassword { get; set; }
        string pgDatabase { get; set; }
        int pgPort { get; set; }
        string ConString { get; }

    }
<<<<<<< HEAD

=======
    interface IBackupRestoreOption
    {

    }
>>>>>>> 0af3a86cd0d4de32496510c3f6ab89fbe8740f01
}
