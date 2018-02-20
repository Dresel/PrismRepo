namespace PrismRepo.ViewModels
{
	using System.Diagnostics;
	using System.Windows.Input;
	using Prism.Commands;
	using Prism.Mvvm;
	using Prism.Navigation;

	public class CarouselItemViewModel : BindableBase, INavigationAware
	{
		public CarouselItemViewModel(INavigationService navigationService)
		{
			NavigationService = navigationService;

			NavigateCommand = new DelegateCommand(() => { NavigationService.NavigateAsync("SecondPage"); });
		}

		public ICommand NavigateCommand { get; set; }

		public string Title { get; set; }

		protected INavigationService NavigationService { get; private set; }

		public virtual void OnNavigatedFrom(INavigationParameters parameters)
		{
			Debug.WriteLine($"{GetType()}: OnNavigatedFrom");
		}

		public virtual void OnNavigatedTo(INavigationParameters parameters)
		{
			Debug.WriteLine($"{GetType()}: OnNavigatedTo");
		}

		public virtual void OnNavigatingTo(INavigationParameters parameters)
		{
			Debug.WriteLine($"{GetType()}: OnNavigatingTo");
		}
	}
}