using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
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

            var membersData = File.ReadAllText("D:/Dev/CSharp/Learn/CSharp/HKTeam/WPF//SeedData/members.json");
            var memberList = JsonSerializer.Deserialize<List<Member>>(membersData);
            foreach (var item in memberList)
            {
                members.Add(item);
            }

            membersDataGrid.ItemsSource = members;
        }
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void DataGrid_MouseLeftButtonDoubleClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (sender != null)
                {
                    DataGrid grid = sender as DataGrid;
                    if (grid != null && grid.SelectedItems != null && grid.SelectedItems.Count == 1)
                    {
                        //This is the code which helps to show the data when the row is double clicked.
                        //DataGridRow dgr = grid.ItemContainerGenerator.ContainerFromItem(grid.SelectedItem) as DataGridRow;
                        //DataRowView dr = (DataRowView)dgr.Item;

                        //String ProductName = dr[1].ToString();
                        //String ProductDescription = dr[2].ToString();
                        MessageBox.Show("You Clicked : \r\nName : " +  "\r\nDescription : ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private bool IsMaximized = false;
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                //if (IsMaximized)
                //{
                //    this.WindowState = WindowState.Normal;
                //    this.Height = 720;
                //    this.Width = 1080;

                //    IsMaximized = false;
                //}
                this.DragMove();
            }
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Height = 720;
                    this.Width = 1080;

                    IsMaximized = false;
                }
                else
                {
                    this.WindowState=WindowState.Maximized;

                    IsMaximized = true;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

    public class Member
    {
        public string Character { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Brush BgColor { get; set; }
    }
}
