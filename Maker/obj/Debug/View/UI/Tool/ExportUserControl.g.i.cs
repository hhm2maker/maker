﻿#pragma checksum "..\..\..\..\..\View\UI\Tool\ExportUserControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3E77B501F76B181075822B9974658B87AFBC69C6"
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
using Maker.View.Tool;
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


namespace Maker.View.Tool {
    
    
    /// <summary>
    /// ExportUserControl
    /// </summary>
    public partial class ExportUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\..\View\UI\Tool\ExportUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Maker.View.Tool.ExportUserControl wMain;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\View\UI\Tool\ExportUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox miImport;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\View\UI\Tool\ExportUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button miMidiFile;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\View\UI\Tool\ExportUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button miLightFile;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\View\UI\Tool\ExportUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox miExport;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\View\UI\Tool\ExportUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button miExportMidi;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\View\UI\Tool\ExportUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button miExportLight;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\View\UI\Tool\ExportUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button miExportAdvanced;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\..\View\UI\Tool\ExportUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image btnPaved;
        
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
            System.Uri resourceLocater = new System.Uri("/Maker;component/view/ui/tool/exportusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\UI\Tool\ExportUserControl.xaml"
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
            this.wMain = ((Maker.View.Tool.ExportUserControl)(target));
            
            #line 10 "..\..\..\..\..\View\UI\Tool\ExportUserControl.xaml"
            this.wMain.Loaded += new System.Windows.RoutedEventHandler(this.wMain_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.miImport = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 3:
            this.miMidiFile = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\..\View\UI\Tool\ExportUserControl.xaml"
            this.miMidiFile.Click += new System.Windows.RoutedEventHandler(this.ImportFile);
            
            #line default
            #line hidden
            return;
            case 4:
            this.miLightFile = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\..\View\UI\Tool\ExportUserControl.xaml"
            this.miLightFile.Click += new System.Windows.RoutedEventHandler(this.ImportFile);
            
            #line default
            #line hidden
            return;
            case 5:
            this.miExport = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 6:
            this.miExportMidi = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\..\View\UI\Tool\ExportUserControl.xaml"
            this.miExportMidi.Click += new System.Windows.RoutedEventHandler(this.ExportFile);
            
            #line default
            #line hidden
            return;
            case 7:
            this.miExportLight = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\..\View\UI\Tool\ExportUserControl.xaml"
            this.miExportLight.Click += new System.Windows.RoutedEventHandler(this.ExportFile);
            
            #line default
            #line hidden
            return;
            case 8:
            this.miExportAdvanced = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\..\View\UI\Tool\ExportUserControl.xaml"
            this.miExportAdvanced.Click += new System.Windows.RoutedEventHandler(this.ExportFile);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnPaved = ((System.Windows.Controls.Image)(target));
            
            #line 44 "..\..\..\..\..\View\UI\Tool\ExportUserControl.xaml"
            this.btnPaved.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.btnPaved_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

