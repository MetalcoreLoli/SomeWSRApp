#pragma checksum "..\..\..\..\..\Views\Windowes\LoginWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45732B3C0CB95E6A7C8D1E641EEF342600E5E23A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SomeWSRApp.WPF.Layer.ViewModels;
using SomeWSRApp.WPF.Layer.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace SomeWSRApp.WPF.Layer.Views {
    
    
    /// <summary>
    /// LoginWindow
    /// </summary>
    public partial class LoginWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\..\..\Views\Windowes\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SomeWSRApp.WPF.Layer.Views.LoginWindow LoginWin;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\Views\Windowes\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SomeWSRApp.WPF.Layer.ViewModels.LogInViewModel loginVM;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\Views\Windowes\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginBox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\Views\Windowes\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordBox;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\..\Views\Windowes\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoginButton;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\..\Views\Windowes\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SomeWSRApp.WPF.Layer;component/views/windowes/loginwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Windowes\LoginWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LoginWin = ((SomeWSRApp.WPF.Layer.Views.LoginWindow)(target));
            return;
            case 2:
            this.loginVM = ((SomeWSRApp.WPF.Layer.ViewModels.LogInViewModel)(target));
            return;
            case 3:
            this.LoginBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.PasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.LoginButton = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\..\..\Views\Windowes\LoginWindow.xaml"
            this.LoginButton.Click += new System.Windows.RoutedEventHandler(this.LogInButtonClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\..\..\Views\Windowes\LoginWindow.xaml"
            this.CloseButton.Click += new System.Windows.RoutedEventHandler(this.CloseButtonClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

