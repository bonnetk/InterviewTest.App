﻿#pragma checksum "..\..\..\Items\AddItemView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54CA9500E3BD4D8EC7F899D1CBAE099F7264A5D5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace InterviewTest.App.Items {
    
    
    /// <summary>
    /// AddItemView
    /// </summary>
    public partial class AddItemView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Items\AddItemView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ItemDetails;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Items\AddItemView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Items\AddItemView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Quantity;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Items\AddItemView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Unitprice;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Items\AddItemView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/InterviewTest.App;component/items/additemview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Items\AddItemView.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ItemDetails = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Quantity = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\..\Items\AddItemView.xaml"
            this.Quantity.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this._quantity_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Unitprice = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\Items\AddItemView.xaml"
            this.Unitprice.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this._unitprice_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.button = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
