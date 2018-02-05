using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpfnavigator.Common;

namespace Wpfnavigator.ViewModels
{
    public class Page2 : ViewModelBase
    {
        public Page2() : base(new DispatcherWrapper())
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
