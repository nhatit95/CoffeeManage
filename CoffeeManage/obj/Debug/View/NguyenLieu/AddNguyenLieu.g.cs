﻿#pragma checksum "..\..\..\..\View\NguyenLieu\AddNguyenLieu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DDC865B05979BC78CAC84B5029343BA0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CoffeeManage.View.NguyenLieu;
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


namespace CoffeeManage.View.NguyenLieu {
    
    
    /// <summary>
    /// AddNguyenLieu
    /// </summary>
    public partial class AddNguyenLieu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\..\View\NguyenLieu\AddNguyenLieu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIdnguyenlieu;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\View\NguyenLieu\AddNguyenLieu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTennguyenlieu;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\View\NguyenLieu\AddNguyenLieu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbbDonvitinh;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\View\NguyenLieu\AddNguyenLieu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtGiatien;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\View\NguyenLieu\AddNguyenLieu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSoluong;
        
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
            System.Uri resourceLocater = new System.Uri("/CoffeeManage;component/view/nguyenlieu/addnguyenlieu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\NguyenLieu\AddNguyenLieu.xaml"
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
            this.txtIdnguyenlieu = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtTennguyenlieu = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.cbbDonvitinh = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.txtGiatien = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtSoluong = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 90 "..\..\..\..\View\NguyenLieu\AddNguyenLieu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

