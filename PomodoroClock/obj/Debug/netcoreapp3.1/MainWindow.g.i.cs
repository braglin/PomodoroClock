﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BC09F8357603E0F72C0BE9635D464E283DB34F4E"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using PomodoroClock;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using System.Windows.Shell;


namespace PomodoroClock {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image plusBtn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image minusBtn;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image setBtn;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label timerLbl;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label startLbl;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush mainBgImg;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PomodoroClock;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 12 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).PreviewMouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.windowMoveDown);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).PreviewMouseMove += new System.Windows.Input.MouseEventHandler(this.windowMove);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).PreviewMouseRightButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.windowMoveUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.plusBtn = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            
            #line 14 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.plusBtnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.minusBtn = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            
            #line 16 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.minusBtnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.setBtn = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            
            #line 18 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.setMenu);
            
            #line default
            #line hidden
            return;
            case 8:
            this.MainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.timerLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.startLbl = ((System.Windows.Controls.Label)(target));
            
            #line 26 "..\..\..\MainWindow.xaml"
            this.startLbl.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.countDownStart);
            
            #line default
            #line hidden
            return;
            case 11:
            this.mainBgImg = ((System.Windows.Media.ImageBrush)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

