namespace Assignment_01_Cita_255
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object? sender, EventArgs e)
        {
          float dayAmount = float.Parse(dayEntry.Text);
            float hours = dayAmount * 24;
            float minutes = hours * 60;
            float seconds = minutes * 60;

          resultLabel.Text = $"{dayAmount} days is equal to {hours:N0} hours.";
          resultLabel2.Text = $"{dayAmount} days is equal to {minutes:N0} minutes.";
          resultLabel3.Text = $"{dayAmount} days is equal to {seconds:N0} seconds.";
        }
    }
}
