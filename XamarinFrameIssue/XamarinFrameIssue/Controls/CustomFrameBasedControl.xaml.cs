using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFrameIssue.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomFrameBasedControl : ContentView
    {
        public CustomFrameBasedControl()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty TitleProperty = BindableProperty.Create(
            nameof(Title),
            typeof(string),
            typeof(CustomFrameBasedControl),
            "Title");

        public string Title { get => (string)GetValue(TitleProperty); set => SetValue(TitleProperty, value); }
    }
}