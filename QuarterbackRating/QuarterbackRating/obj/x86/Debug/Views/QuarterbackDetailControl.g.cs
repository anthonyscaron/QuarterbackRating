﻿#pragma checksum "C:\GithubRepos\QuarterbackRating\QuarterbackRating\QuarterbackRating\Views\QuarterbackDetailControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6F9026778F2CA9DCFB8BA0B929DA3A660E3F181C59F7B5276B74B01FD10216AE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuarterbackRating.Views
{
    partial class QuarterbackDetailControl : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class QuarterbackDetailControl_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IQuarterbackDetailControl_Bindings
        {
            private global::QuarterbackRating.Views.QuarterbackDetailControl dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj6;
            private global::Windows.UI.Xaml.Controls.TextBlock obj7;
            private global::Windows.UI.Xaml.Controls.TextBlock obj8;
            private global::Windows.UI.Xaml.Controls.TextBlock obj9;
            private global::Windows.UI.Xaml.Controls.TextBlock obj10;
            private global::Windows.UI.Xaml.Controls.TextBlock obj11;
            private global::Windows.UI.Xaml.Controls.TextBlock obj12;
            private global::Windows.UI.Xaml.Controls.TextBlock obj13;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj6TextDisabled = false;
            private static bool isobj7TextDisabled = false;
            private static bool isobj8TextDisabled = false;
            private static bool isobj9TextDisabled = false;
            private static bool isobj10TextDisabled = false;
            private static bool isobj11TextDisabled = false;
            private static bool isobj12TextDisabled = false;
            private static bool isobj13TextDisabled = false;

            private QuarterbackDetailControl_obj1_BindingsTracking bindingsTracking;

            public QuarterbackDetailControl_obj1_Bindings()
            {
                this.bindingsTracking = new QuarterbackDetailControl_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 94 && columnNumber == 113)
                {
                    isobj6TextDisabled = true;
                }
                else if (lineNumber == 87 && columnNumber == 110)
                {
                    isobj7TextDisabled = true;
                }
                else if (lineNumber == 80 && columnNumber == 105)
                {
                    isobj8TextDisabled = true;
                }
                else if (lineNumber == 73 && columnNumber == 111)
                {
                    isobj9TextDisabled = true;
                }
                else if (lineNumber == 66 && columnNumber == 108)
                {
                    isobj10TextDisabled = true;
                }
                else if (lineNumber == 59 && columnNumber == 106)
                {
                    isobj11TextDisabled = true;
                }
                else if (lineNumber == 30 && columnNumber == 25)
                {
                    isobj12TextDisabled = true;
                }
                else if (lineNumber == 37 && columnNumber == 25)
                {
                    isobj13TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 6: // Views\QuarterbackDetailControl.xaml line 94
                        this.obj6 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 7: // Views\QuarterbackDetailControl.xaml line 87
                        this.obj7 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 8: // Views\QuarterbackDetailControl.xaml line 80
                        this.obj8 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 9: // Views\QuarterbackDetailControl.xaml line 73
                        this.obj9 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 10: // Views\QuarterbackDetailControl.xaml line 66
                        this.obj10 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 11: // Views\QuarterbackDetailControl.xaml line 59
                        this.obj11 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 12: // Views\QuarterbackDetailControl.xaml line 26
                        this.obj12 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 13: // Views\QuarterbackDetailControl.xaml line 32
                        this.obj13 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IQuarterbackDetailControl_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::QuarterbackRating.Views.QuarterbackDetailControl)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::QuarterbackRating.Views.QuarterbackDetailControl obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ListMenuItem(obj.ListMenuItem, phase);
                    }
                }
            }
            private void Update_ListMenuItem(global::QuarterbackRating.Core.Models.Quarterback obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ListMenuItem_Interceptions(obj.Interceptions, phase);
                        this.Update_ListMenuItem_Touchdowns(obj.Touchdowns, phase);
                        this.Update_ListMenuItem_PassingYards(obj.PassingYards, phase);
                        this.Update_ListMenuItem_PassCompletions(obj.PassCompletions, phase);
                        this.Update_ListMenuItem_PassAttempts(obj.PassAttempts, phase);
                        this.Update_ListMenuItem_Rating(obj.Rating, phase);
                        this.Update_ListMenuItem_Name(obj.Name, phase);
                        this.Update_ListMenuItem_Id(obj.Id, phase);
                    }
                }
            }
            private void Update_ListMenuItem_Interceptions(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\QuarterbackDetailControl.xaml line 94
                    if (!isobj6TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj6, obj.ToString(), null);
                    }
                }
            }
            private void Update_ListMenuItem_Touchdowns(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\QuarterbackDetailControl.xaml line 87
                    if (!isobj7TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj7, obj.ToString(), null);
                    }
                }
            }
            private void Update_ListMenuItem_PassingYards(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\QuarterbackDetailControl.xaml line 80
                    if (!isobj8TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj8, obj.ToString(), null);
                    }
                }
            }
            private void Update_ListMenuItem_PassCompletions(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\QuarterbackDetailControl.xaml line 73
                    if (!isobj9TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj9, obj.ToString(), null);
                    }
                }
            }
            private void Update_ListMenuItem_PassAttempts(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\QuarterbackDetailControl.xaml line 66
                    if (!isobj10TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj10, obj.ToString(), null);
                    }
                }
            }
            private void Update_ListMenuItem_Rating(global::System.Decimal obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\QuarterbackDetailControl.xaml line 59
                    if (!isobj11TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj11, obj.ToString(), null);
                    }
                }
            }
            private void Update_ListMenuItem_Name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\QuarterbackDetailControl.xaml line 26
                    if (!isobj12TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj12, obj, null);
                    }
                }
            }
            private void Update_ListMenuItem_Id(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\QuarterbackDetailControl.xaml line 32
                    if (!isobj13TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj13, obj.ToString(), null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class QuarterbackDetailControl_obj1_BindingsTracking
            {
                private global::System.WeakReference<QuarterbackDetailControl_obj1_Bindings> weakRefToBindingObj; 

                public QuarterbackDetailControl_obj1_BindingsTracking(QuarterbackDetailControl_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<QuarterbackDetailControl_obj1_Bindings>(obj);
                }

                public QuarterbackDetailControl_obj1_Bindings TryGetBindingObject()
                {
                    QuarterbackDetailControl_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void DependencyPropertyChanged_ListMenuItem(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    QuarterbackDetailControl_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::QuarterbackRating.Views.QuarterbackDetailControl obj = sender as global::QuarterbackRating.Views.QuarterbackDetailControl;
                        if (obj != null)
                        {
                            bindings.Update_ListMenuItem(obj.ListMenuItem, DATA_CHANGED);
                        }
                    }
                }
                private long tokenDPC_ListMenuItem = 0;
                public void UpdateChildListeners_(global::QuarterbackRating.Views.QuarterbackDetailControl obj)
                {
                    QuarterbackDetailControl_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::QuarterbackRating.Views.QuarterbackDetailControl.ListMenuItemProperty, tokenDPC_ListMenuItem);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_ListMenuItem = obj.RegisterPropertyChangedCallback(global::QuarterbackRating.Views.QuarterbackDetailControl.ListMenuItemProperty, DependencyPropertyChanged_ListMenuItem);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\QuarterbackDetailControl.xaml line 11
                {
                    this.ForegroundElement = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                }
                break;
            case 3: // Views\QuarterbackDetailControl.xaml line 98
                {
                    this.DeleteButton = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    ((global::Windows.UI.Xaml.Controls.GridView)this.DeleteButton).ItemClick += this.DeleteButton_ItemClick;
                }
                break;
            case 6: // Views\QuarterbackDetailControl.xaml line 94
                {
                    this.InterceptionsBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // Views\QuarterbackDetailControl.xaml line 87
                {
                    this.TouchdownsBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // Views\QuarterbackDetailControl.xaml line 80
                {
                    this.YardsBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // Views\QuarterbackDetailControl.xaml line 73
                {
                    this.CompletionsBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // Views\QuarterbackDetailControl.xaml line 66
                {
                    this.AttemptsBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // Views\QuarterbackDetailControl.xaml line 59
                {
                    this.RatingBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // Views\QuarterbackDetailControl.xaml line 26
                {
                    this.NameBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // Views\QuarterbackDetailControl.xaml line 32
                {
                    this.IdBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\QuarterbackDetailControl.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    QuarterbackDetailControl_obj1_Bindings bindings = new QuarterbackDetailControl_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

