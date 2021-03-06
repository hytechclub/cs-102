﻿using System;
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

namespace MovieList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Movie> movieList;

        public MainWindow()
        {
            InitializeComponent();

            movieList = new List<Movie>();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Movie movieToAdd = new Movie(titleInput.Text, int.Parse(releaseYearInput.Text));

            movieList.Add(movieToAdd);

            titleInput.Clear();
            releaseYearInput.Clear();
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Movie m in movieList)
            {
                m.ShowDetails();
            }
        }
    }
}
