﻿#pragma checksum "..\..\StudentWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7310668B74AB40E4E8AD6086DD18ECB6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
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


namespace WpfApplication2 {
    
    
    /// <summary>
    /// StudentWindow
    /// </summary>
    public partial class StudentWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 132 "..\..\StudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backBtn;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\StudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button forwardBtn;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\StudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button homeBtn;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\StudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button aboutBtn;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\StudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button photoBtn;
        
        #line default
        #line hidden
        
        
        #line 190 "..\..\StudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button eventsBtn;
        
        #line default
        #line hidden
        
        
        #line 213 "..\..\StudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button studyBtn;
        
        #line default
        #line hidden
        
        
        #line 236 "..\..\StudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button newsBtn;
        
        #line default
        #line hidden
        
        
        #line 259 "..\..\StudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button restBtn;
        
        #line default
        #line hidden
        
        
        #line 282 "..\..\StudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button libraryBtn;
        
        #line default
        #line hidden
        
        
        #line 305 "..\..\StudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sportBtn;
        
        #line default
        #line hidden
        
        
        #line 328 "..\..\StudentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sdoBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApplication2;component/studentwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StudentWindow.xaml"
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
            
            #line 4 "..\..\StudentWindow.xaml"
            ((WpfApplication2.StudentWindow)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.backBtn = ((System.Windows.Controls.Button)(target));
            
            #line 132 "..\..\StudentWindow.xaml"
            this.backBtn.Click += new System.Windows.RoutedEventHandler(this.backBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.forwardBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.homeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 143 "..\..\StudentWindow.xaml"
            this.homeBtn.Click += new System.Windows.RoutedEventHandler(this.homeBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.aboutBtn = ((System.Windows.Controls.Button)(target));
            
            #line 146 "..\..\StudentWindow.xaml"
            this.aboutBtn.Click += new System.Windows.RoutedEventHandler(this.aboutBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.photoBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.eventsBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.studyBtn = ((System.Windows.Controls.Button)(target));
            
            #line 213 "..\..\StudentWindow.xaml"
            this.studyBtn.Click += new System.Windows.RoutedEventHandler(this.studyBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.newsBtn = ((System.Windows.Controls.Button)(target));
            
            #line 236 "..\..\StudentWindow.xaml"
            this.newsBtn.Click += new System.Windows.RoutedEventHandler(this.newsBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.restBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 11:
            this.libraryBtn = ((System.Windows.Controls.Button)(target));
            
            #line 282 "..\..\StudentWindow.xaml"
            this.libraryBtn.Click += new System.Windows.RoutedEventHandler(this.libraryBtn_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.sportBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 13:
            this.sdoBtn = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

