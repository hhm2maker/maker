﻿#pragma checksum "..\..\..\..\View\LightUserControl\TextBoxUserControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D15D0F557877C308878AA51BBDCA8063ED3D182A"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Maker.View.LightUserControl;
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


namespace Maker.View.LightUserControl {
    
    
    /// <summary>
    /// TextBoxUserControl
    /// </summary>
    public partial class TextBoxUserControl : Maker.View.LightUserControl.BaseLightUserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\..\View\LightUserControl\TextBoxUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gMain;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\View\LightUserControl\TextBoxUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbTime;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\View\LightUserControl\TextBoxUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbAction;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\View\LightUserControl\TextBoxUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbPosition;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\View\LightUserControl\TextBoxUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbColor;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\View\LightUserControl\TextBoxUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid spMain;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\View\LightUserControl\TextBoxUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbMain;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\View\LightUserControl\TextBoxUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbError;
        
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
            System.Uri resourceLocater = new System.Uri("/Maker;component/view/lightusercontrol/textboxusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\LightUserControl\TextBoxUserControl.xaml"
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
            this.rbTime = ((System.Windows.Controls.RadioButton)(target));
            
            #line 43 "..\..\..\..\View\LightUserControl\TextBoxUserControl.xaml"
            this.rbTime.Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.rbAction = ((System.Windows.Controls.RadioButton)(target));
            
            #line 44 "..\..\..\..\View\LightUserControl\TextBoxUserControl.xaml"
            this.rbAction.Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.rbPosition = ((System.Windows.Controls.RadioButton)(target));
            
            #line 45 "..\..\..\..\View\LightUserControl\TextBoxUserControl.xaml"
            this.rbPosition.Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.rbColor = ((System.Windows.Controls.RadioButton)(target));
            
            #line 46 "..\..\..\..\View\LightUserControl\TextBoxUserControl.xaml"
            this.rbColor.Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.spMain = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.tbMain = ((System.Windows.Controls.TextBox)(target));
            
            #line 66 "..\..\..\..\View\LightUserControl\TextBoxUserControl.xaml"
            this.tbMain.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lbError = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

