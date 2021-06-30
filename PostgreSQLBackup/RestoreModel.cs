using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSQLBackup
{
    class RestoreModel : RestoreModelBase, IRestoreModel
    {
        public override string GetFilePath { get; set; }
        public override string GetExtension { get; set; }
    }
}
