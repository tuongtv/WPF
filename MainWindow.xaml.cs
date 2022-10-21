using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var converter = new BrushConverter();
            ObservableCollection<Member> members = new ObservableCollection<Member>();

            //Create DataGrid Items info
            members.Add(new Member { Number = "1", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "Tinker Truong", Position = "Slicer", Email = "vinhtuong.contact@gmail.com", Phone = "0455990697" });
            members.Add(new Member { Number = "2", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "Tinker Truong", Position = "Slicer", Email = "vinhtuong.contact@gmail.com", Phone = "0455990697" });
            members.Add(new Member { Number = "3", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "Tinker Truong", Position = "Slicer", Email = "vinhtuong.contact@gmail.com", Phone = "0455990697" });
            members.Add(new Member { Number = "4", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "Tinker Truong", Position = "Slicer", Email = "vinhtuong.contact@gmail.com", Phone = "0455990697" });
            members.Add(new Member { Number = "5", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "Tinker Truong", Position = "Slicer", Email = "vinhtuong.contact@gmail.com", Phone = "0455990697" });
            members.Add(new Member { Number = "6", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "Tinker Truong123123123", Position = "Slicer", Email = "vinhtuong.contact@gmail.com", Phone = "0455990697" });
            members.Add(new Member { Number = "7", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "Tinker Truong", Position = "Slicer", Email = "vinhtuong.contact@gmail.com", Phone = "0455990697" });
            members.Add(new Member { Number = "8", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "Tinker Truong", Position = "Slicer", Email = "vinhtuong.contact@gmail.com", Phone = "0455990697" });
            members.Add(new Member { Number = "9", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "Tinker Truong", Position = "Slicer", Email = "vinhtuong.contact@gmail.com", Phone = "0455990697" });
            members.Add(new Member { Number = "10", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "Tinker Truong", Position = "Slicer", Email = "vinhtuong.contact@gmail.com", Phone = "0455990697" });
            members.Add(new Member { Number = "11", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "Tinker Truong", Position = "Slicer", Email = "vinhtuong.contact@gmail.com", Phone = "0455990697" });
            members.Add(new Member { Number = "12", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "Tinker Truong", Position = "Slicer", Email = "vinhtuong.contact@gmail.com", Phone = "0455990697" });

            membersDataGrid.ItemsSource = members;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private bool IsMaximized = false;
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                //this.WindowState = WindowState.Minimized;
                this.Width = 1080;
                this.Height = 720;

                IsMaximized = false;
            } 
            else
            {
                this.WindowState = WindowState.Maximized;

                IsMaximized = true;
            }
        }

    }
    
    public class Member
    {
        public string Character { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Brush BgColor { get; set; }
    }
}
