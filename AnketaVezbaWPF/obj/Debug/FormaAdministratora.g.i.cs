﻿#pragma checksum "..\..\FormaAdministratora.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70B0E975BC67A1E3052C3DB451F59FEA6D8EEDAC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AnketaVezbaWPF;
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


namespace AnketaVezbaWPF {
    
    
    /// <summary>
    /// FormaAdministratora
    /// </summary>
    public partial class FormaAdministratora : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\FormaAdministratora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\FormaAdministratora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radioButtonAnkete;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\FormaAdministratora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radioButtonKorisnici;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\FormaAdministratora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpisBtn;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\FormaAdministratora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button IzmenaBtn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\FormaAdministratora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BrisanjeBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/AnketaVezbaWPF;component/formaadministratora.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FormaAdministratora.xaml"
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
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.radioButtonAnkete = ((System.Windows.Controls.RadioButton)(target));
            
            #line 11 "..\..\FormaAdministratora.xaml"
            this.radioButtonAnkete.Checked += new System.Windows.RoutedEventHandler(this.radioButtonAnkete_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.radioButtonKorisnici = ((System.Windows.Controls.RadioButton)(target));
            
            #line 12 "..\..\FormaAdministratora.xaml"
            this.radioButtonKorisnici.Checked += new System.Windows.RoutedEventHandler(this.radioButtonKorisnici_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.UpisBtn = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\FormaAdministratora.xaml"
            this.UpisBtn.Click += new System.Windows.RoutedEventHandler(this.UpisBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.IzmenaBtn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\FormaAdministratora.xaml"
            this.IzmenaBtn.Click += new System.Windows.RoutedEventHandler(this.IzmenaBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BrisanjeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\FormaAdministratora.xaml"
            this.BrisanjeBtn.Click += new System.Windows.RoutedEventHandler(this.BrisanjeBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

