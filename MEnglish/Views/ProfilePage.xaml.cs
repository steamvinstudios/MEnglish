﻿using MEnglish.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace MEnglish.Views
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class ProfilePage : Page
    {
        public Words Words { get; set; } = new Words();
        public ProfilePage()
        {
            this.InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var oneWord = new Word
            {
                LastRepeat = DateTime.Now,
                Rating = new Random().Next(101),
                IsLearned = true
            };
            oneWord.EnglishForms.Add(new EnglishForm { Form = "asdasdasdsa" });
            using (WordContext db = new WordContext())
            {
                db.Words.Add(oneWord);
                db.SaveChanges();
                wordsList.ItemsSource = db.Words.ToList();
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(WordPage), null, new DrillInNavigationTransitionInfo());
        }

        private void LoadDatabaseButton_Click(object sender, RoutedEventArgs e)
        {
            using (WordContext db = new WordContext())
            {
                wordsList.ItemsSource = db.Words.ToList();
            }
        }
    }
}
