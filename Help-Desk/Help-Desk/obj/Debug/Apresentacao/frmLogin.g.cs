﻿#pragma checksum "..\..\..\Apresentacao\frmLogin.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "15FDFDFF03A64DAA634E8E38C02C145F"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using Help_Desk;
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


namespace Help_Desk {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\Apresentacao\frmLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Help_Desk.MainWindow frmLogin;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Apresentacao\frmLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblUsuario;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Apresentacao\frmLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblSenha;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Apresentacao\frmLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbUsuario;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Apresentacao\frmLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button txbEntrar;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Apresentacao\frmLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblRecuperarSenha;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Apresentacao\frmLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pswSenha;
        
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
            System.Uri resourceLocater = new System.Uri("/Help-Desk;component/apresentacao/frmlogin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Apresentacao\frmLogin.xaml"
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
            this.frmLogin = ((Help_Desk.MainWindow)(target));
            return;
            case 2:
            this.lblUsuario = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblSenha = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txbUsuario = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txbEntrar = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Apresentacao\frmLogin.xaml"
            this.txbEntrar.Click += new System.Windows.RoutedEventHandler(this.txbEntrar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lblRecuperarSenha = ((System.Windows.Controls.Label)(target));
            
            #line 19 "..\..\..\Apresentacao\frmLogin.xaml"
            this.lblRecuperarSenha.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.lblRecuperarSenha_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.pswSenha = ((System.Windows.Controls.PasswordBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

