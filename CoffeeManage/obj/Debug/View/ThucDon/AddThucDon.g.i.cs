﻿#pragma checksum "..\..\..\..\View\ThucDon\AddThucDon.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A419FCDB9FEE3C51757D66154A81440A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CoffeeManage.View.ThucDon;
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


namespace CoffeeManage.View.ThucDon {
    
    
    /// <summary>
    /// AddThucDon
    /// </summary>
    public partial class AddThucDon : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\..\View\ThucDon\AddThucDon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIdthucdon;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\View\ThucDon\AddThucDon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTenthucdon;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\View\ThucDon\AddThucDon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbbLoaithucdon;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\View\ThucDon\AddThucDon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtGiatien;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\View\ThucDon\AddThucDon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtKhuyenmai;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\..\View\ThucDon\AddThucDon.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbbNoiIn;
        
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
            System.Uri resourceLocater = new System.Uri("/CoffeeManage;component/view/thucdon/addthucdon.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\ThucDon\AddThucDon.xaml"
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
            this.txtIdthucdon = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtTenthucdon = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.cbbLoaithucdon = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.txtGiatien = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtKhuyenmai = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.cbbNoiIn = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            
            #line 104 "..\..\..\..\View\ThucDon\AddThucDon.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 105 "..\..\..\..\View\ThucDon\AddThucDon.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

