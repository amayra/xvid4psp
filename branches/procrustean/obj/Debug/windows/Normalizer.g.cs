﻿#pragma checksum "..\..\..\windows\Normalizer.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "09FF23F2C93C80D2EFA9BA3755F93B12"
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
    /// Normalize
    /// </summary>
    public partial class Normalize : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\windows\Normalizer.xaml"
        internal XviD4PSP.Normalize Window;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\windows\Normalizer.xaml"
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\windows\Normalizer.xaml"
        internal System.Windows.Controls.Label text_info;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\windows\Normalizer.xaml"
        internal System.Windows.Controls.ProgressBar prTotal;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\windows\Normalizer.xaml"
        internal System.Windows.Controls.ProgressBar prCurrent;
        
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
            System.Uri resourceLocater = new System.Uri("/XviD4PSP;component/windows/normalizer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\windows\Normalizer.xaml"
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
            this.Window = ((XviD4PSP.Normalize)(target));
            
            #line 8 "..\..\..\windows\Normalizer.xaml"
            this.Window.Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.text_info = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.prTotal = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 5:
            this.prCurrent = ((System.Windows.Controls.ProgressBar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}