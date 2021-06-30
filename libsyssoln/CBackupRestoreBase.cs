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

        public abstract string Filename { get; set; }
        public abstract string Format { get; set; }
        public abstract string Encoding { get; set; }
        public abstract int NoofJobs { get; set; }


        public  struct BackupRestoreObjects
        {
            public bool PreData { get; }
            public bool Data { get; }
            public bool PostData { get; }
        }
    public  struct BackupRestoreSections
        {
            public bool OnlyData { get; }
            public bool OnlySchema { get; }
            public bool Blobs { get; }


        }    
     public  struct BackupRestoreNoSave
        {
            public bool Owner { get; }
            public bool Priviledge { get; }
            public bool TableSpace { get; }
            public bool UnloggedtableData { get; }


        }

        public struct BackupRestoreQueries
        {
            public bool UseColumn { get; }
            public bool UseInsert { get; }
            public bool IncludeCreateDBStatement { get; }
            public bool IncludeDropDBStatement { get; }

        }        
        public struct BackupRestoreDisables
        {
            public bool Tiggers { get; }
            public bool quoting { get; }


        }        
        public struct BackupRestoreMiscellaneous
        {
            public bool WithOIDs { get; }
            public bool VerboseMessages { get; }
            public bool ErroronExit { get; }
            public bool ForceDoubleQuoteIndentifiers { get; }
            public bool SessionAuthorization { get; }

        }

    }
}
