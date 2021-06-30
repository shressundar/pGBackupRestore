using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libsyssoln
{
    public abstract class CBackupRestoreBase 
    {
    public abstract bool createConnection();
    public abstract List<string> Getdatabases(string constr);
    public abstract List<string> Getdatabases();

        //public abstract List<Dictionary<string,bool>> BackupRestoreOptions();
        //public abstract string Filename { get; set; }
        //public abstract string Format { get; set; }
        //public abstract string Encoding { get; set; }
        //public abstract int NoofJobs { get; set; }


 
    }
}
