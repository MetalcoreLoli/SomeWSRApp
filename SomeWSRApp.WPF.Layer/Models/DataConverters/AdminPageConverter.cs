using SomeWSRApp.WPF.Layer.Models.DataModels;
using SomeWSRApp.WPF.Layer.Views.Pages.AdminPages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeWSRApp.WPF.Layer.Models.DataConverters
{
    public class AdminPageConverter : BaseValueConverter<AdminPageConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((AdminPage)value)
            {
                case AdminPage.Clients:
                    return new AdminClientsPage();
                case AdminPage.Managers:
                    return new AdminManagersPage();
                case AdminPage.EditClient:
                    return new AdminEditClientPage();
                case AdminPage.EditManager:
                    return new AdminEditManagerPage();
                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
