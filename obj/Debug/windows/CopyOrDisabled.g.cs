﻿#pragma checksum "..\..\..\windows\CopyOrDisabled.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D2772E75D97CEF8D5026ECE06CAD2A3C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace XviD4PSP {
    
    
    /// <summary>
    /// CopyOrDisabled
    /// </summary>
    public partial class CopyOrDisabled : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\..\windows\CopyOrDisabled.xaml"
        internal XviD4PSP.CopyOrDisabled UserControl;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\windows\CopyOrDisabled.xaml"
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\windows\CopyOrDisabled.xaml"
        internal System.Windows.Controls.Label text_info;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/XviD4PSP;component/windows/copyordisabled.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\windows\CopyOrDisabled.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.UserControl = ((XviD4PSP.CopyOrDisabled)(target));
            return;
            case 2:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.text_info = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}