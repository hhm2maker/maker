﻿#pragma checksum "..\..\..\..\..\View\UI\Style\StyleWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CBD4FB06BAB6862F69096C5F0EB6036E2022CBE1"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Maker.View.UI.UserControlDialog;
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
    public partial class StyleWindow : Maker.View.UI.UserControlDialog.MakerDialog, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\..\View\UI\Style\StyleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbCatalog;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\View\UI\Style\StyleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgUp;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\..\View\UI\Style\StyleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgDown;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\..\View\UI\Style\StyleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image btnRemoveFx;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\..\View\UI\Style\StyleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel svMain;
        
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
            System.Uri resourceLocater = new System.Uri("/Maker;component/view/ui/style/stylewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\UI\Style\StyleWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.lbCatalog = ((System.Windows.Controls.ListBox)(target));
            
            #line 26 "..\..\..\..\..\View\UI\Style\StyleWindow.xaml"
            this.lbCatalog.MouseEnter += new System.Windows.Input.MouseEventHandler(this.lbCatalog_MouseEnter);
            
            #line default
            #line hidden
            
            #line 26 "..\..\..\..\..\View\UI\Style\StyleWindow.xaml"
            this.lbCatalog.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lbCatalog_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.imgUp = ((System.Windows.Controls.Image)(target));
            
            #line 37 "..\..\..\..\..\View\UI\Style\StyleWindow.xaml"
            this.imgUp.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ImgUp_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.imgDown = ((System.Windows.Controls.Image)(target));
            
            #line 40 "..\..\..\..\..\View\UI\Style\StyleWindow.xaml"
            this.imgDown.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ImgDown_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnRemoveFx = ((System.Windows.Controls.Image)(target));
            
            #line 43 "..\..\..\..\..\View\UI\Style\StyleWindow.xaml"
            this.btnRemoveFx.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.BtnRemoveFx_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.svMain = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            
            #line 52 "..\..\..\..\..\View\UI\Style\StyleWindow.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

