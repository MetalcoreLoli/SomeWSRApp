using SomeWSRApp.WPF.Layer.Models.DataModels;
using SomeWSRApp.WPF.Layer.Views.Pages;
using SomeWSRApp.WPF.Layer.Views.Pages.ManagerPages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeWSRApp.WPF.Layer.Models.DataConverters
{
    public class ManagerPageConverter : BaseValueConverter<ManagerPageConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((ManagerPage)value)
            {
                case ManagerPage.SalesPage:
                    return new ManagerSalesPage();
                case ManagerPage.ClientPage:
                    return new ManagerClientsPage();
                case ManagerPage.NewSalePage:
                    return new ManagerNewSalePage();
                case ManagerPage.NewClientPage:
                    return new ManagerNewClientRegistrationPage();
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
