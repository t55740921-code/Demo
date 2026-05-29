    public partial class AdminPage : Page
    {
        DemoTestEntities db = new DemoTestEntities();
        public AdminPage()
        {
            InitializeComponent();
            StaticObject.dataGrid = DtGrid;
            StaticObject.dataGrid.ItemsSource = db.Users.ToList();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new AddUser().ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Users user = DtGrid.SelectedItem as Users;
            if (user != null)
            {
                EditUser editUser = new EditUser(user);
                editUser.ShowDialog();
            }
            else
            {
                MessageBox.Show("Пользователь не выбран");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Users user = DtGrid.SelectedItem as Users;
            if(MessageBox.Show("Удалить?", "Удаление", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                db.Users.Remove(user);
                db.SaveChanges();
                StaticObject.dataGrid.ItemsSource = db.Users.ToList();
            }
        }
    }
}
