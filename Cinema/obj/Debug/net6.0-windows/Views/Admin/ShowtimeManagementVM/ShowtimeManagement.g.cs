﻿#pragma checksum "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\ShowtimeManagement.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DF8A030DDFBB302AA91D6525C76EF765E20E873E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Cinema.Views.Admin.ShowtimeManagementVM;
using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Cinema.Views.Admin.ShowtimeManagementVM {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\ShowtimeManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _FilterBox;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\ShowtimeManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Calendar;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\ShowtimeManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton all;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\ShowtimeManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton r1;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\ShowtimeManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton r2;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\ShowtimeManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton r3;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\ShowtimeManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton r4;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\ShowtimeManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton r5;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\ShowtimeManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listShowTime;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Cinema;component/views/admin/showtimemanagementvm/showtimemanagement.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\ShowtimeManagement.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this._FilterBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\ShowtimeManagement.xaml"
            this._FilterBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FilterBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Calendar = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.all = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.r1 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.r2 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.r3 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.r4 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.r5 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 9:
            this.listShowTime = ((System.Windows.Controls.ListView)(target));
            
            #line 155 "..\..\..\..\..\..\Views\Admin\ShowtimeManagementVM\ShowtimeManagement.xaml"
            this.listShowTime.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
