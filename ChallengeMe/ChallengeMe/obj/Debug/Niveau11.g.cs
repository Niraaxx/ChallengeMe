﻿#pragma checksum "..\..\Niveau11.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B16291E2D031988E91689EEF15C37F04C235088F5E5BF75C8824F38B92C1EFED"
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
    /// Niveau11
    /// </summary>
    public partial class Niveau11 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\Niveau11.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label pseudo;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Niveau11.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label scoring;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Niveau11.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox reponse;
        
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
            System.Uri resourceLocater = new System.Uri("/ChallengeMe;component/niveau11.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Niveau11.xaml"
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
            
            #line 12 "..\..\Niveau11.xaml"
            this.pseudo.Loaded += new System.Windows.RoutedEventHandler(this.pseudoAfficher);
            
            #line default
            #line hidden
            return;
            case 2:
            this.scoring = ((System.Windows.Controls.Label)(target));
            
            #line 13 "..\..\Niveau11.xaml"
            this.scoring.Loaded += new System.Windows.RoutedEventHandler(this.scoreAfficher);
            
            #line default
            #line hidden
            return;
            case 3:
            this.reponse = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\Niveau11.xaml"
            this.reponse.KeyDown += new System.Windows.Input.KeyEventHandler(this.changerNiveau);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
