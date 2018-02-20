namespace PrismRepo.ViewModels
{
	using System.Collections.Generic;
	using System.Windows.Input;
	using Prism.Commands;
	using Prism.Navigation;

	public class MainPageViewModel : ViewModelBase
	{
		public MainPageViewModel(INavigationService navigationService) : base(navigationService)
		{
			Title = "Main Page";

			NavigateCommand = new DelegateCommand(() => { NavigationService.NavigateAsync("SecondPage"); });

			Items = new List<CarouselItemViewModel>()
			{
				new CarouselItemViewModel(navigationService)
				{
					Title = "Carousel Page 1"
				},
				new CarouselItemViewModel(navigationService)
				{
					Title = "Carousel Page 2"
				},
				new CarouselItemViewModel(navigationService)
				{
					Title = "Carousel Page 3"
				}
			};
		}

		public ICollection<CarouselItemViewModel> Items { get; set; }

		public ICommand NavigateCommand { get; set; }
	}
}