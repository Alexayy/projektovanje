﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "68009105DDC0D355DF4B32ABAF3557AF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using Video;




/// <summary>
/// Video
/// </summary>
public partial class Video : System.Windows.Window, System.Windows.Markup.IComponentConnector {
    
    
    #line 59 "..\..\MainWindow.xaml"
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
    internal System.Windows.Controls.MediaElement videoMediaElement;
    
    #line default
    #line hidden
    
    
    #line 62 "..\..\MainWindow.xaml"
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
    internal System.Windows.Controls.RadioButton playRadioButton;
    
    #line default
    #line hidden
    
    
    #line 67 "..\..\MainWindow.xaml"
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
    internal System.Windows.Controls.RadioButton pauseRadioButton;
    
    #line default
    #line hidden
    
    
    #line 72 "..\..\MainWindow.xaml"
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
    internal System.Windows.Controls.RadioButton stopRadioButton;
    
    #line default
    #line hidden
    
    
    #line 78 "..\..\MainWindow.xaml"
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
    internal System.Windows.Controls.CheckBox powerCheckBox;
    
    #line default
    #line hidden
    
    
    #line 121 "..\..\MainWindow.xaml"
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
    internal System.Windows.Shapes.Rectangle reflectionRectangle;
    
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
        System.Uri resourceLocater = new System.Uri("/Video;component/mainwindow.xaml", System.UriKind.Relative);
        
        #line 1 "..\..\MainWindow.xaml"
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
        this.videoMediaElement = ((System.Windows.Controls.MediaElement)(target));
        return;
            case 2:
        this.playRadioButton = ((System.Windows.Controls.RadioButton)(target));
        
        #line 64 "..\..\MainWindow.xaml"
        this.playRadioButton.Checked += new System.Windows.RoutedEventHandler(this.playRadioButton_Checked);
        
        #line default
        #line hidden
        return;
            case 3:
        this.pauseRadioButton = ((System.Windows.Controls.RadioButton)(target));
        
        #line 69 "..\..\MainWindow.xaml"
        this.pauseRadioButton.Checked += new System.Windows.RoutedEventHandler(this.pauseRadioButton_Checked);
        
        #line default
        #line hidden
        return;
            case 4:
        this.stopRadioButton = ((System.Windows.Controls.RadioButton)(target));
        
        #line 74 "..\..\MainWindow.xaml"
        this.stopRadioButton.Checked += new System.Windows.RoutedEventHandler(this.stopRadioButton_Checked);
        
        #line default
        #line hidden
        return;
            case 5:
        this.powerCheckBox = ((System.Windows.Controls.CheckBox)(target));
        
        #line 79 "..\..\MainWindow.xaml"
        this.powerCheckBox.Checked += new System.Windows.RoutedEventHandler(this.powerCheckBox_Checked);
        
        #line default
        #line hidden
        
        #line 80 "..\..\MainWindow.xaml"
        this.powerCheckBox.Unchecked += new System.Windows.RoutedEventHandler(this.powerCheckBox_Unchecked);
        
        #line default
        #line hidden
        return;
            case 6:
        this.reflectionRectangle = ((System.Windows.Shapes.Rectangle)(target));
        return;
            }
        this._contentLoaded = true;
    }
}

