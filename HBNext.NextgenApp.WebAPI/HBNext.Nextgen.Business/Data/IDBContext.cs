using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBNext.Nextgen.BusinessManager.Data
{
    internal interface IDBContext
    {
        void Insert ();
        void Update();
        void Delete();
    }
}
