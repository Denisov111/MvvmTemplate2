using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmTemplate
{
    internal class Main : BaseModel
    {
        internal override void Run()
        {
            OnSendMessage("Hello!!!");
        }
    }
}
