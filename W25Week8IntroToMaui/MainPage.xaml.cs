using System.Collections.ObjectModel;

namespace W25Week8IntroToMaui
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<string> tasks = new ObservableCollection<string>();

        public MainPage()
        {
            InitializeComponent();
            lvTasks.ItemsSource = tasks;
        }

        private void btnAddTask_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTask.Text))
            {
                tasks.Add(txtTask.Text);
                txtTask.Text = string.Empty;
            }
        }
    }

}
