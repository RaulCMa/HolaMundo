﻿using System;
using System.Collections.Generic;
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

namespace HolaMundo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            if (SaludoTextBlock.Text != "")
            {
                SaludoTextBlock.Text = "Hola " + NombreTextBox.Text;
                NombreTextBox.Text = "";
            }
            else
                SaludoTextBlock.Text = "Hola mundo!";
        }

        private void ClickLimpiar_Button(object sender, RoutedEventArgs e)
        {
            NombreTextBox.Text = "";
            SaludoTextBlock.Text = "Hola mundo!";
        }
    }
}
