#pragma checksum "..\..\..\Fruits\FruitInfo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "263F2A0CABED2501AABBC28E5CEA2E69453696FB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using InterviewTest.App.Fruits;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace InterviewTest.App.Fruits
{


    /// <summary>
    /// FruitInfo
    /// </summary>
    public partial class FruitInfo : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/InterviewTest.App;component/fruits/fruitinfo.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Fruits\FruitInfo.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this._type = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 2:
                    this._name = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this._quantity = ((System.Windows.Controls.TextBox)(target));

#line 36 "..\..\..\Fruits\FruitInfo.xaml"
                    this._quantity.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this._quantity_PreviewTextInput);

#line default
#line hidden
                    return;
                case 4:
                    this._unitprice = ((System.Windows.Controls.TextBox)(target));

#line 41 "..\..\..\Fruits\FruitInfo.xaml"
                    this._unitprice.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this._unitprice_PreviewTextInput);

#line default
#line hidden
                    return;
                case 5:
                    this.button = ((System.Windows.Controls.Button)(target));

#line 43 "..\..\..\Fruits\FruitInfo.xaml"
                    this.button.Click += new System.Windows.RoutedEventHandler(this.button_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

