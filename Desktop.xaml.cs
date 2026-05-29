    public partial class Desktop : Window
    {
        public Desktop()
        {
            InitializeComponent();
            StaticObject.DesktopFrame = DesktopFrame;
            new Autorization().ShowDialog();
            DesktopFrame.Navigate(new AdminPage());
            DesktopFrame.Navigate(new UserPage());
        }
    }
}
