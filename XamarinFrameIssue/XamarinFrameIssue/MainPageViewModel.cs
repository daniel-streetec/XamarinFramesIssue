using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFrameIssue
{
    [ObservableObject]
    public partial class MainPageViewModel 
    {
        #region fields
        [ObservableProperty]
        private bool _toggled = false;
        #endregion
    }
}
