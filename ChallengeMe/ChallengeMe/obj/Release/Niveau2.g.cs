﻿#pragma checksum "..\..\Niveau2.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4F0016EE55CACB497FA5E8109EA3892AE6735452C1AE2014D39C225A2B7C36CA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using ChallengeMe;
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


namespace ChallengeMe {
    
    
    /// <summary>
    /// Niveau2
    /// </summary>
    public partial class Niveau2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\Niveau2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label pseudo;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Niveau2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label scoring;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Niveau2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_carre;
        
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
            System.Uri resourceLocater = new System.Uri("/ChallengeMe;component/niveau2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Niveau2.xaml"
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
            this.pseudo = ((System.Windows.Controls.Label)(target));
            
            #line 17 "..\..\Niveau2.xaml"
            this.pseudo.Loaded += new System.Windows.RoutedEventHandler(this.pseudoAfficher);
            
            #line default
            #line hidden
            return;
            case 2:
            this.scoring = ((System.Windows.Controls.Label)(target));
            
            #line 18 "..\..\Niveau2.xaml"
            this.scoring.Loaded += new System.Windows.RoutedEventHandler(this.scoreAfficher);
            
            #line default
            #line hidden
            
            #line 18 "..\..\Niveau2.xaml"
            this.scoring.SourceUpdated += new System.EventHandler<System.Windows.Data.DataTransferEventArgs>(this.scoreUpdate);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_carre = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\Niveau2.xaml"
            this.btn_carre.Click += new System.Windows.RoutedEventHandler(this.changerNiveau);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

