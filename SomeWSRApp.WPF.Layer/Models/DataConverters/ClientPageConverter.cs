using SomeWSRApp.WPF.Layer.Models.DataModels;
using SomeWSRApp.WPF.Layer.Views.Pages.ClientPages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeWSRApp.WPF.Layer.Models.DataConverters
{
    public class ClientPageConverter : BaseValueConverter<ClientPageConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((ClientPage)value)
            {
                case ClientPage.Profile:
                    return new ClientProfilePage();
                case ClientPage.Sales:
                    return new ClientSalesPage();
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
