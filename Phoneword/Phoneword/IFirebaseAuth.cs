using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoneword
{
    public interface IFirebaseAuth
    {
        bool InitFirebaseAuth();

        void CreateNewUser();
    }
}
