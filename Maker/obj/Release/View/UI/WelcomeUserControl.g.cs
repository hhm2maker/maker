﻿#pragma checksum "..\..\..\..\View\UI\WelcomeUserControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "143E23F70A5E2B273A3E116742A7FE49F527C801"
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
using Maker.View.Utils;
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


namespace Maker.View {
    
    
    /// <summary>
    /// WelcomeUserControl
    /// </summary>
    public partial class WelcomeUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\View\UI\WelcomeUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas cLeft;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\View\UI\WelcomeUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid spMain;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\View\UI\WelcomeUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbHistorical;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\View\UI\WelcomeUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas cRight;
        
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
            System.Uri resourceLocater = new System.Uri("/Maker;component/view/ui/welcomeusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\UI\WelcomeUserControl.xaml"
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
            
            #line 9 "..\..\..\..\View\UI\WelcomeUserControl.xaml"
            ((Maker.View.WelcomeUserControl)(target)).SizeChanged += new System.Windows.SizeChangedEventHandler(this.UserControl_SizeChanged);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\..\View\UI\WelcomeUserControl.xaml"
            ((Maker.View.WelcomeUserControl)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cLeft = ((System.Windows.Controls.Canvas)(target));
            return;
            case 3:
            this.spMain = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            
            #line 36 "..\..\..\..\View\UI\WelcomeUserControl.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ToABCVideo);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lbHistorical = ((System.Windows.Controls.ListBox)(target));
            
            #line 40 "..\..\..\..\View\UI\WelcomeUserControl.xaml"
            this.lbHistorical.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lbHistorical_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 46 "..\..\..\..\View\UI\WelcomeUserControl.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.TextBlock_MouseEnter);
            
            #line default
            #line hidden
            
            #line 46 "..\..\..\..\View\UI\WelcomeUserControl.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.TextBlock_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 50 "..\..\..\..\View\UI\WelcomeUserControl.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ToNewFile);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 51 "..\..\..\..\View\UI\WelcomeUserControl.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ToOpenTheTopPlayer);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 52 "..\..\..\..\View\UI\WelcomeUserControl.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ToOpenTheSetting);
            
            #line default
            #line hidden
            return;
            case 10:
            this.cRight = ((System.Windows.Controls.Canvas)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
