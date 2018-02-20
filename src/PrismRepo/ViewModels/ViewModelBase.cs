using Prism.Mvvm;
using Prism.Navigation;

namespace PrismRepo.ViewModels
{
	using System.Diagnostics;

	public class ViewModelBase : BindableBase, INavigationAware, IDestructible
	{
		public ViewModelBase(INavigationService navigationService)
		{
			NavigationService = navigationService;
		}

		protected INavigationService NavigationService { get; private set; }

		public string Title { get; set; }

		public virtual void Destroy()
		{
		}

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