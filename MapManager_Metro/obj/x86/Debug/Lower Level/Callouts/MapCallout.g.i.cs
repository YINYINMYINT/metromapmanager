﻿

#pragma checksum "H:\Users\Carl\Visual Studio\Projects\Metro\MapManager_Metro\Lower Level\Callouts\MapCallout.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2A77A6C89CECF37A860F19C69F8C21DE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

namespace FatAttitude.Utilities.Metro.Mapping
{
    partial class MapCallout : Windows.UI.Xaml.Controls.UserControl
    {
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private Windows.UI.Xaml.Media.Animation.Storyboard storyboardAppearance; 
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private Windows.UI.Xaml.Media.Animation.Storyboard storyboardDisappearance; 
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private Windows.UI.Xaml.Controls.Grid myGrid; 
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private Windows.UI.Xaml.Media.ScaleTransform gridScaleTransform; 
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            Application.LoadComponent(this, new System.Uri("ms-appx:///MapUtilities_Metro/Lower Level/Callouts/MapCallout.xaml"), Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Nested);
 
            storyboardAppearance = (Windows.UI.Xaml.Media.Animation.Storyboard)this.FindName("storyboardAppearance");
            storyboardDisappearance = (Windows.UI.Xaml.Media.Animation.Storyboard)this.FindName("storyboardDisappearance");
            myGrid = (Windows.UI.Xaml.Controls.Grid)this.FindName("myGrid");
            gridScaleTransform = (Windows.UI.Xaml.Media.ScaleTransform)this.FindName("gridScaleTransform");
        }
    }
}



