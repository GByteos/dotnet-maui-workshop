namespace MonkeyFinder.ViewModel;

[QueryProperty("Monkey", "Monkey")]
public partial class MonkeyDetailsViewModel : BaseViewModel
{
    public MonkeyDetailsViewModel()
    {
        
    }
    [ObservableProperty]
    Monkey monkey;

    [RelayCommand]
    async Task GoBackAsync()
    {
        await Shell.Current.GoToAsync("..", true);
    }
}
