using ConcatetionLogicLibrary;

namespace HelloWorldMaui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        Entry entry;
        public MainPage()
        {
            InitializeComponent();
            entry = new Entry
            {
                Placeholder = "Input your name",
                FontFamily = "Helvetica",
                FontSize = 22,
                MaxLength = 20,
                MaximumWidthRequest = 300
            };
            MyStackLayout.Children.Insert(1, entry);
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            ConcatetionLogic concatetionLogic = new ConcatetionLogic();
            HelloLabel.Text = concatetionLogic.Output(entry.Text);
            SemanticScreenReader.Announce(HelloLabel.Text);
        }
    }
}