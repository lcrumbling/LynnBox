namespace HDPClient
{
    using Gu.Wpf.ModernUI;

    using HDPClient.ViewModel;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ModernWindow
    {
        HomeViewModel vm = new HomeViewModel();

        public MainWindow()
        {

            this.DataContext = vm;
            InitializeComponent();
        }
    }
}
