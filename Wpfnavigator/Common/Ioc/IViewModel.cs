using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpfnavigator.Common.Ioc;

namespace Wpfnavigator.Common.Ioc
{
    public interface IViewModel     : IDisposable, INotifyPropertyChanged
    {
    }
}
