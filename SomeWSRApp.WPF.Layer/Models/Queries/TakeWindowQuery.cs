using System;
using System.Linq;
using System.Windows;
using SomeWSRApp.Domain.Layer.Queries;

namespace SomeWSRApp.WPF.Layer.Models.Queries
{
    public class TakeViewByNameQuery: IQuery<Window>
    {
        private readonly string _winName;

        public TakeViewByNameQuery(string winName)
        {
            _winName = winName;
        }

        public Window Execute()
        {
            foreach (Window win in Application.Current.Windows.AsParallel())
            {
                if (win.Name == _winName)
                    return win;
            }
            throw new ArgumentOutOfRangeException($"Cannot find window with name {_winName}");
        }
    }
}