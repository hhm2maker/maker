﻿#pragma checksum "..\..\..\..\..\View\Style\Child\ColorChild.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8FEB0EFF6F1470FA43557251FA6BECF1A207732E"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Maker.View.Style.Child;
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


namespace Maker.View.Style.Child {
    
    
    /// <summary>
    /// ColorChild
    /// </summary>
    public partial class ColorChild : Maker.View.Style.Child.BaseChild, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\..\View\Style\Child\ColorChild.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbColorTypeFormat;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\View\Style\Child\ColorChild.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbColorFormatType;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\View\Style\Child\ColorChild.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbColorFormatDiy;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\View\Style\Child\ColorChild.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbColorTypeShape;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\View\Style\Child\ColorChild.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbColorShapeType;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\View\Style\Child\ColorChild.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbColorShapeRadialOrientation;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\View\Style\Child\ColorChild.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbColorShapeNumber;
        
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
            System.Uri resourceLocater = new System.Uri("/Maker;component/view/style/child/colorchild.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\Style\Child\ColorChild.xaml"
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
            this.rbColorTypeFormat = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 2:
            this.cbColorFormatType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 17 "..\..\..\..\..\View\Style\Child\ColorChild.xaml"
            this.cbColorFormatType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbColorFormatType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbColorFormatDiy = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.rbColorTypeShape = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.cbColorShapeType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 31 "..\..\..\..\..\View\Style\Child\ColorChild.xaml"
            this.cbColorShapeType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbColorShapeType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cbColorShapeRadialOrientation = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.tbColorShapeNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

