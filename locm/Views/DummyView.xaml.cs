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

namespace locm.Views
{
    /// <summary>
    /// Logique d'interaction pour DummyView.xaml
    /// </summary>
    public partial class DummyView : UserControl
    {
        public DummyView()
        {
            InitializeComponent();
            TextField.Text = "Coucou c'est moi je suis la textbox";
        }
    }
}
