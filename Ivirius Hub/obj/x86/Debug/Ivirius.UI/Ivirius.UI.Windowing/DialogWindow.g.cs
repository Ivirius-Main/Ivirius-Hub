﻿#pragma checksum "D:\Ivirius Company\Programări\Visual Studio\Apps\Ivirius-Hub-Git\Ivirius Hub\Ivirius.UI\Ivirius.UI.Windowing\DialogWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A8571AC098EE8FB45E796285491390218AA61C5DFE89F77AA8A45AEF7A4CA741"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ivirius.UI.Windowing
{
    partial class DialogWindow : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // Ivirius.UI\Ivirius.UI.Windowing\DialogWindow.xaml line 1
                {
                    this.FullBox = (global::Windows.UI.Xaml.Controls.UserControl)(target);
                    ((global::Windows.UI.Xaml.Controls.UserControl)this.FullBox).LayoutUpdated += this.UserControl_LayoutUpdated;
                    ((global::Windows.UI.Xaml.Controls.UserControl)this.FullBox).Loaded += this.UserControl_Loaded;
                    ((global::Windows.UI.Xaml.Controls.UserControl)this.FullBox).PointerPressed += this.FullBox_PointerPressed;
                }
                break;
            case 2: // Ivirius.UI\Ivirius.UI.Windowing\DialogWindow.xaml line 83
                {
                    this.FullAnimationOpen = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 3: // Ivirius.UI\Ivirius.UI.Windowing\DialogWindow.xaml line 100
                {
                    this.FullAnimationClose = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                    ((global::Windows.UI.Xaml.Media.Animation.Storyboard)this.FullAnimationClose).Completed += this.FullAnimationClose_Completed;
                }
                break;
            case 11: // Ivirius.UI\Ivirius.UI.Windowing\DialogWindow.xaml line 119
                {
                    this.ShadowBorder = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 12: // Ivirius.UI\Ivirius.UI.Windowing\DialogWindow.xaml line 121
                {
                    this.WindowBorder = (global::Windows.UI.Xaml.Controls.Border)(target);
                    ((global::Windows.UI.Xaml.Controls.Border)this.WindowBorder).SizeChanged += this.WindowBorder_SizeChanged;
                }
                break;
            case 13: // Ivirius.UI\Ivirius.UI.Windowing\DialogWindow.xaml line 123
                {
                    this.scale = (global::Windows.UI.Xaml.Media.CompositeTransform)(target);
                }
                break;
            case 14: // Ivirius.UI\Ivirius.UI.Windowing\DialogWindow.xaml line 126
                {
                    this.TBAccent = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 15: // Ivirius.UI\Ivirius.UI.Windowing\DialogWindow.xaml line 127
                {
                    this.TBar = (global::Windows.UI.Xaml.Controls.Border)(target);
                    ((global::Windows.UI.Xaml.Controls.Border)this.TBar).PointerPressed += this.DialogWindow_PointerPressed;
                    ((global::Windows.UI.Xaml.Controls.Border)this.TBar).PointerReleased += this.DialogWindow_PointerReleased;
                    ((global::Windows.UI.Xaml.Controls.Border)this.TBar).PointerMoved += this.DialogWindow_PointerMoved;
                }
                break;
            case 16: // Ivirius.UI\Ivirius.UI.Windowing\DialogWindow.xaml line 145
                {
                    this.CloseButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.CloseButton).Click += this.CloseButton_Click;
                }
                break;
            case 17: // Ivirius.UI\Ivirius.UI.Windowing\DialogWindow.xaml line 138
                {
                    this.DialogWindowContent = (global::Windows.UI.Xaml.Controls.ContentPresenter)(target);
                }
                break;
            case 18: // Ivirius.UI\Ivirius.UI.Windowing\DialogWindow.xaml line 140
                {
                    this.BTN3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BTN3).Click += this.CancelButton_Click;
                }
                break;
            case 19: // Ivirius.UI\Ivirius.UI.Windowing\DialogWindow.xaml line 141
                {
                    this.BTN2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BTN2).Click += this.SecondButton_Click;
                }
                break;
            case 20: // Ivirius.UI\Ivirius.UI.Windowing\DialogWindow.xaml line 142
                {
                    this.BTN1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BTN1).Click += this.FirstButton_Click;
                }
                break;
            case 21: // Ivirius.UI\Ivirius.UI.Windowing\DialogWindow.xaml line 133
                {
                    this.TitleBarIcon = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 22: // Ivirius.UI\Ivirius.UI.Windowing\DialogWindow.xaml line 129
                {
                    this.ABrush = (global::Windows.UI.Xaml.Media.AcrylicBrush)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

