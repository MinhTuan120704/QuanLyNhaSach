﻿using BLL.IServices;
using BLL.Services;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUI
{
    /// <summary>
    /// Interaction logic for BookManagementPage.xaml
    /// </summary>
    public class AutoWidthGridViewColumn : GridViewColumn
    {
        public AutoWidthGridViewColumn()
        {
            WidthProperty.OverrideMetadata(typeof(AutoWidthGridViewColumn), new FrameworkPropertyMetadata(null, new CoerceValueCallback(OnCoerceWidth)));
        }

        private static object OnCoerceWidth(DependencyObject o, object baseValue)
        {
            return double.NaN;
        }
    }

    public partial class BookManagementPage : Page
    {
        //public List<Book> Books { get; set; }
        public ObservableCollection<Book> Books { get; set; }
        public BookManagementPage()
        {
            InitializeComponent();
            BookService bookService = new BookService();
            Books = new ObservableCollection<Book>(bookService.GetAllBook());
            BooksListView.ItemsSource = Books;

        }
                

        private bool isAdminBorderVisible = false;
        private void home_MouseEnter(object sender, MouseEventArgs e)
        {
            home.Cursor = Cursors.Hand;
        }

        private void home_MouseLeave(object sender, MouseEventArgs e)
        {
            home.Cursor = Cursors.Arrow;
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage newPage = new MainPage();


            this.NavigationService.Navigate(newPage);
        }

        private void filterButton_Click(object sender, RoutedEventArgs e)
        {
            filterBorder.Visibility = Visibility.Visible;
        }

        private void filterButton_MouseEnter(object sender, MouseEventArgs e)
        {
            filterButton.Cursor = Cursors.Hand;
        }

        private void filterButton_MouseLeave(object sender, MouseEventArgs e)
        {
            filterButton.Cursor = Cursors.Arrow;
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            filterBorder.Visibility = Visibility.Collapsed;

        }

        private void closeButton_MouseEnter(object sender, MouseEventArgs e)
        {
            closeButton.Cursor = Cursors.Hand;
        }

        private void closeButton_MouseLeave(object sender, MouseEventArgs e)
        {
            closeButton.Cursor = Cursors.Arrow;
        }



        private void logOutButton_Click(object sender, RoutedEventArgs e)
        {
            LoginPage newPage = new LoginPage();
            this.NavigationService.Navigate(newPage);
        }

        private void logOutButton_MouseEnter(object sender, MouseEventArgs e)
        {
            logOutButton.Cursor = Cursors.Hand;
        }

        private void logOutButton_MouseLeave(object sender, MouseEventArgs e)
        {
            logOutButton.Cursor = Cursors.Arrow;
        }

        private void settingButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void settingButton_MouseEnter(object sender, MouseEventArgs e)
        {
            settingButton.Cursor = Cursors.Hand;
        }

        private void settingButton_MouseLeave(object sender, MouseEventArgs e)
        {
            settingButton.Cursor = Cursors.Arrow;
        }

        private void adminButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isAdminBorderVisible)
            {
                adminBorder.Visibility = Visibility.Visible;
                isAdminBorderVisible = true;
            }
            else
            {
                adminBorder.Visibility = Visibility.Collapsed;
                isAdminBorderVisible = false;
            }
        }

        private void adminButton_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void adminButton_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void addBook_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            AddBookWindow newWindow = new AddBookWindow();
            newWindow.Show();
        }
    }
}
