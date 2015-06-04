using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenTask2.Core
{
    interface IAppConfigManager
    {
        bool Save();

        bool Load();

        void Reset();
    }
}
