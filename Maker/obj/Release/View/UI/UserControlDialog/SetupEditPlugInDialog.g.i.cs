﻿#pragma checksum "..\..\..\..\..\View\UI\UserControlDialog\SetupEditPlugInDialog.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A21E05AF7CDDB388B983348F7398BCC8E662726B"
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
    /// SetupEditPlugInDialog
    /// </summary>
    public partial class SetupEditPlugInDialog : Maker.View.UI.UserControlDialog.MakerDialog, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\..\View\UI\UserControlDialog\SetupEditPlugInDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbTitle;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\View\UI\UserControlDialog\SetupEditPlugInDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbContent;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\View\UI\UserControlDialog\SetupEditPlugInDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReplace;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\View\UI\UserControlDialog\SetupEditPlugInDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNoReplacement;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\View\UI\UserControlDialog\SetupEditPlugInDialog.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Maker;component/view/ui/usercontroldialog/setupeditplugindialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\UI\UserControlDialog\SetupEditPlugInDialog.xaml"
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
            this.tbTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.tbContent = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.btnReplace = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\..\View\UI\UserControlDialog\SetupEditPlugInDialog.xaml"
            this.btnReplace.Click += new System.Windows.RoutedEventHandler(this.btnReplace_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnNoReplacement = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\..\View\UI\UserControlDialog\SetupEditPlugInDialog.xaml"
            this.btnNoReplacement.Click += new System.Windows.RoutedEventHandler(this.btnNoReplacement_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\..\View\UI\UserControlDialog\SetupEditPlugInDialog.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.btnCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
