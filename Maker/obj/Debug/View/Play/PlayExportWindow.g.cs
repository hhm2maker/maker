﻿#pragma checksum "..\..\..\..\View\Play\PlayExportWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08E6FB51343CDAC3F8B14E80258D221B8CF1F152"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Maker.View;
using Maker.View.Play;
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


namespace Maker.View.Play {
    
    
    /// <summary>
    /// PlayExportWindow
    /// </summary>
    public partial class PlayExportWindow : Maker.View.BaseWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\View\Play\PlayExportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gMain;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\View\Play\PlayExportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbTutorialPath;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\View\Play\PlayExportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSelectFile;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\View\Play\PlayExportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemoveFile;
        
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
            System.Uri resourceLocater = new System.Uri("/Maker;component/view/play/playexportwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Play\PlayExportWindow.xaml"
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
            this.gMain = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.tbTutorialPath = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.btnSelectFile = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\View\Play\PlayExportWindow.xaml"
            this.btnSelectFile.Click += new System.Windows.RoutedEventHandler(this.btnSelectFile_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnRemoveFile = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\View\Play\PlayExportWindow.xaml"
            this.btnRemoveFile.Click += new System.Windows.RoutedEventHandler(this.btnRemoveFile_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 20 "..\..\..\..\View\Play\PlayExportWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GenerateExe);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

