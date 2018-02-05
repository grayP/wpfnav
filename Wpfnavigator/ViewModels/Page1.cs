using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Wpfnavigator.Common;

namespace Wpfnavigator.ViewModels
{
    public class Page1 : ViewModelBase
    {
        public Page1(): base(new  DispatcherWrapper())
        {

        }

        public override void ExecutePreviousCommand()
        {
            base.ExecutePreviousCommand();
        }

        public override void ExecuteNextCommand()
        {
            base.ExecuteNextCommand();
        }
    }
}
