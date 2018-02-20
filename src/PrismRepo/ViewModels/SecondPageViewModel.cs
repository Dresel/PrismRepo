namespace PrismRepo.ViewModels
{
	using System.Windows.Input;
	using Prism.Commands;
	using Prism.Navigation;

	public class SecondPageViewModel : ViewModelBase
	{
		public SecondPageViewModel(INavigationService navigationService) : base(navigationService)
		{
			Title = "Second Page";

			GoBackCommand = new DelegateCommand(() => { NavigationService.GoBackAsync(); });
		}

		public ICommand GoBackCommand { get; set; }
	}
}