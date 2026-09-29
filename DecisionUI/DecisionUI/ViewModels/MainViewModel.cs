using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace DecisionUI.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial string Greeting { get; set; } = "Jah Man!!";

}
