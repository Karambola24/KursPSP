﻿#pragma checksum "..\..\..\View\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "56DE432A5BA6402D7D1197D168A4037AD0DE08A2932B035761C66F9E834E5666"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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


namespace PspClient {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 50 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl mainTabControl;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid StudentDataGrid;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DisciplineDataGrid;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GradeDataGrid;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CalculateTopStudentsButton;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CalculateStrugglingStudentsButton;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TopPercentageTextBlock;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock StrugglingPercentageTextBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/PspClient;component/view/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\MainWindow.xaml"
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
            this.mainTabControl = ((System.Windows.Controls.TabControl)(target));
            return;
            case 2:
            this.StudentDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            
            #line 74 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnShowStudents_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 75 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenAddStudentWindow);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 76 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenDeleteStudentWindow);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DisciplineDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            
            #line 94 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnShowDisciplines_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 95 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenAddDisciplineWindow);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 96 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenDeleteDisciplineWindow);
            
            #line default
            #line hidden
            return;
            case 10:
            this.GradeDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 11:
            
            #line 119 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnShowGrade_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 120 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenAddGradeWindow);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 121 "..\..\..\View\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenDeleteGradeWindow);
            
            #line default
            #line hidden
            return;
            case 14:
            this.CalculateTopStudentsButton = ((System.Windows.Controls.Button)(target));
            
            #line 127 "..\..\..\View\MainWindow.xaml"
            this.CalculateTopStudentsButton.Click += new System.Windows.RoutedEventHandler(this.TopStudentsPercentageButton_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.CalculateStrugglingStudentsButton = ((System.Windows.Controls.Button)(target));
            
            #line 128 "..\..\..\View\MainWindow.xaml"
            this.CalculateStrugglingStudentsButton.Click += new System.Windows.RoutedEventHandler(this.StrugglingStudentsPercentageButton_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.TopPercentageTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 17:
            this.StrugglingPercentageTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

