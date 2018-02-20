using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace PrismRepo
{
	using Prism;
	using Prism.DryIoc;
	using Prism.Ioc;
	using PrismRepo.Views;
	using Xamarin.Forms;

	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer) : base(initializer)
		{
		}

		protected override async void OnInitialized()
		{
			InitializeComponent();

			await NavigationService.NavigateAsync("NavigationPage/MainPage");
		}

		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{
			containerRegistry.RegisterForNavigation<NavigationPage>();
			containerRegistry.RegisterForNavigation<MainPage>();
			containerRegistry.RegisterForNavigation<SecondPage>();
		}
	}
}