﻿#pragma checksum "..\..\..\..\View\Tool\PlayerManagementUserControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F67A3320011E2249806E9F70D33FCD60015BD945"
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
using Maker.View.Device;
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
    /// PlayerManagementUserControl
    /// </summary>
    public partial class PlayerManagementUserControl : Maker.View.BaseUserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\View\Tool\PlayerManagementUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gMain;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\View\Tool\PlayerManagementUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Maker.View.Device.LaunchpadPro mLaunchpad;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\View\Tool\PlayerManagementUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbDeviceType;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\View\Tool\PlayerManagementUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbBackGround;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\View\Tool\PlayerManagementUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnChangeColor;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\View\Tool\PlayerManagementUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOpenFile;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\View\Tool\PlayerManagementUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbMembrane;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\View\Tool\PlayerManagementUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDeviceSize;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\View\Tool\PlayerManagementUserControl.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Maker;component/view/tool/playermanagementusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Tool\PlayerManagementUserControl.xaml"
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
            this.mLaunchpad = ((Maker.View.Device.LaunchpadPro)(target));
            return;
            case 3:
            
            #line 26 "..\..\..\..\View\Tool\PlayerManagementUserControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteDevice);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbDeviceType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.tbBackGround = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.btnChangeColor = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\View\Tool\PlayerManagementUserControl.xaml"
            this.btnChangeColor.Click += new System.Windows.RoutedEventHandler(this.btnChangeColor_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnOpenFile = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\View\Tool\PlayerManagementUserControl.xaml"
            this.btnOpenFile.Click += new System.Windows.RoutedEventHandler(this.btnOpenFile_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cbMembrane = ((System.Windows.Controls.CheckBox)(target));
            
            #line 44 "..\..\..\..\View\Tool\PlayerManagementUserControl.xaml"
            this.cbMembrane.Checked += new System.Windows.RoutedEventHandler(this.cbMembrane_Checked);
            
            #line default
            #line hidden
            
            #line 44 "..\..\..\..\View\Tool\PlayerManagementUserControl.xaml"
            this.cbMembrane.Unchecked += new System.Windows.RoutedEventHandler(this.cbMembrane_Unchecked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.tbDeviceSize = ((System.Windows.Controls.TextBox)(target));
            
            #line 48 "..\..\..\..\View\Tool\PlayerManagementUserControl.xaml"
            this.tbDeviceSize.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbDeviceSize_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnOk = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\..\View\Tool\PlayerManagementUserControl.xaml"
            this.btnOk.Click += new System.Windows.RoutedEventHandler(this.btnOk_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

