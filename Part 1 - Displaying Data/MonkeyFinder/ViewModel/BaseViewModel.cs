
namespace MonkeyFinder.ViewModel;

public partial class BaseViewModel : ObservableObject
{
    public BaseViewModel() 
    {
        
    }

    [ObservableProperty]
    bool isBusy;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    string title;


    public bool IsNotBusy => !isBusy;
}
