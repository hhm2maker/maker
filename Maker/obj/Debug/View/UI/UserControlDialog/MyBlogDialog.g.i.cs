﻿#pragma checksum "..\..\..\..\..\View\UI\UserControlDialog\MyBlogDialog.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A17A322CF63D29EC806FFA22B4A745DC2864FC45"
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


namespace Maker.View.UI.UserControlDialog {
    
    
    /// <summary>
    /// MyBlogDialog
    /// </summary>
    public partial class MyBlogDialog : Maker.View.UI.UserControlDialog.MakerDialog, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\..\..\View\UI\UserControlDialog\MyBlogDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image iHead;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\View\UI\UserControlDialog\MyBlogDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbAuthor;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\..\View\UI\UserControlDialog\MyBlogDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbContact;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\..\View\UI\UserControlDialog\MyBlogDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border bShortcut;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\..\View\UI\UserControlDialog\MyBlogDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbShortcut;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\..\View\UI\UserControlDialog\MyBlogDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbIntroduce;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\..\View\UI\UserControlDialog\MyBlogDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbMain;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\..\View\UI\UserControlDialog\MyBlogDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOk;
        
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
            System.Uri resourceLocater = new System.Uri("/Maker;component/view/ui/usercontroldialog/myblogdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\UI\UserControlDialog\MyBlogDialog.xaml"
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
            this.iHead = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.tbAuthor = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.tbContact = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.bShortcut = ((System.Windows.Controls.Border)(target));
            
            #line 49 "..\..\..\..\..\View\UI\UserControlDialog\MyBlogDialog.xaml"
            this.bShortcut.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.bShortcut_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbShortcut = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.tbIntroduce = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.lbMain = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.btnOk = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\..\..\View\UI\UserControlDialog\MyBlogDialog.xaml"
            this.btnOk.Click += new System.Windows.RoutedEventHandler(this.btnOk_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
