﻿

#pragma checksum "C:\Users\acancie1\Documents\Checkers-App\CheckersApp\CheckersApp\SettingsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5BE7CD4BB3921F1BB77D61758F3D7B50"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CheckersApp
{
    partial class SettingsPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 54 "..\..\SettingsPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.StartGame_Click_1;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 51 "..\..\SettingsPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.pvp_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 52 "..\..\SettingsPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.pvc_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


