﻿#pragma checksum "..\..\..\..\View\Style\StyleWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4083BCAD2D705E1AB421FF7D8013A14A8EBF6964"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Maker.View.Style;
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


namespace Maker.View.Style {
    
    
    /// <summary>
    /// StyleWindow
    /// </summary>
    public partial class StyleWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\View\Style\StyleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbCatalog;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\View\Style\StyleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNewFx;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\View\Style\StyleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgUp;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\View\Style\StyleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgDown;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\View\Style\StyleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image btnRemoveFx;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\View\Style\StyleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup popup;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\View\Style\StyleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbFx;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\View\Style\StyleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel svMain;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\View\Style\StyleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOk;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\View\Style\StyleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/Maker;component/view/style/stylewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Style\StyleWindow.xaml"
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
            
            #line 14 "..\..\..\..\View\Style\StyleWindow.xaml"
            ((Maker.View.Style.StyleWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lbCatalog = ((System.Windows.Controls.ListBox)(target));
            
            #line 18 "..\..\..\..\View\Style\StyleWindow.xaml"
            this.lbCatalog.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lbCatalog_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnNewFx = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\View\Style\StyleWindow.xaml"
            this.btnNewFx.Click += new System.Windows.RoutedEventHandler(this.btnNewFx_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.imgUp = ((System.Windows.Controls.Image)(target));
            
            #line 22 "..\..\..\..\View\Style\StyleWindow.xaml"
            this.imgUp.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ImgUp_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.imgDown = ((System.Windows.Controls.Image)(target));
            
            #line 25 "..\..\..\..\View\Style\StyleWindow.xaml"
            this.imgDown.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ImgDown_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnRemoveFx = ((System.Windows.Controls.Image)(target));
            
            #line 28 "..\..\..\..\View\Style\StyleWindow.xaml"
            this.btnRemoveFx.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.BtnRemoveFx_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.popup = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 8:
            this.lbFx = ((System.Windows.Controls.ListBox)(target));
            
            #line 34 "..\..\..\..\View\Style\StyleWindow.xaml"
            this.lbFx.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lbFx_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.svMain = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 10:
            this.btnOk = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\View\Style\StyleWindow.xaml"
            this.btnOk.Click += new System.Windows.RoutedEventHandler(this.btnOk_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\View\Style\StyleWindow.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.btnCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

