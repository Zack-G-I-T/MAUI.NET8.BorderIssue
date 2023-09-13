namespace BorderIssue
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            testCoverFlow.ItemsSource = new int[] { 1, 2, 3, 4 };
            testCoverFlow2.ItemsSource = new int[] { 1, 2, 3, 4 };
        }

    }

}
