using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libsyssoln
{
    public class CBackupModel : CBackupRestoreBase, IPostgreSQL
    {
        
        private string _pgSQLUser = string.Empty;
        private string _pgSQLPwd = string.Empty;
        private string _pgSQLDbname = string.Empty;
        private string _pgSQLConstr = string.Empty;
        private int _pgSQLPort = 0;
        public string pgUser { get => _pgSQLUser; set => _pgSQLUser = value; }
        public string pgPassword { get => _pgSQLPwd; set => _pgSQLPwd=value; }
        public string pgDatabase { get => _pgSQLDbname; set => _pgSQLDbname = value; }
        public int pgPort { get => _pgSQLPort; set => _pgSQLPort=value; }

        public string ConString { get => _pgSQLConstr; private set => _pgSQLConstr = value; }
<<<<<<< Updated upstream
=======
        public  string RoleName { get; set; }
        public  int CompressionRation { get; set; }
        public override string Filename { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Format { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Encoding { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int NoofJobs { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
>>>>>>> Stashed changes

        public override List<Dictionary<string, bool>> BackupRestoreOptions()
        {
            List<Dictionary<string, bool>> option = new();
            Dictionary<string, bool> optionkeyv = new();
            option.Add(optionkeyv);


            return option;
        }

        public override bool createConnection()
        {
            throw new NotImplementedException();
        }

        public override List<string> Getdatabases(string constr)
        {
            throw new NotImplementedException();
        }

        public override List<string> Getdatabases()
        {
            throw new NotImplementedException();
        }
    }
}
