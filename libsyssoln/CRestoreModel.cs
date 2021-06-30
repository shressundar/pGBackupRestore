using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libsyssoln
{
    public class CRestoreModel : CBackupRestoreBase, IPostgreSQL
    {
        private string _pgSQLUser = string.Empty;
        private string _pgSQLPwd = string.Empty;
        private string _pgSQLDbname = string.Empty;
        private string _pgSQLConstr = string.Empty;
        private int _pgSQLPort = 0;
        public string pgUser { get => _pgSQLUser; set => _pgSQLUser = value; }
        public string pgPassword { get => _pgSQLPwd; set => _pgSQLPwd = value; }
        public string pgDatabase { get => _pgSQLDbname; set => _pgSQLDbname = value; }
        public int pgPort { get => _pgSQLPort; set => _pgSQLPort = value; }

        public string ConString { get => _pgSQLConstr; private set => _pgSQLConstr = value; }
        /// <summary>
        /// <para>Restore Role</para>
        /// </summary>
        public string RoleName { get; set; }



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
