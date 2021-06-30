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
    public abstract List<Dictionary<string,bool>> BackupRestoreOptions();
    
    public  struct BackupRestoreDataType
        {
            public bool PreData { get; }
            public bool DataOnly { get; }
            public bool PostData { get; }


        }

        public struct BackupRestorePriviledges
        {
            public bool PostData { get; }

        }

    }
}
