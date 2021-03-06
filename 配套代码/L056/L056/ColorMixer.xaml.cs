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

namespace L056
{
    /// <summary>
    /// ColorMixer.xaml 的交互逻辑
    /// </summary>
    public partial class ColorMixer : UserControl
    {
        public ColorMixer()
        {
            InitializeComponent();
        }


        public Color SelectedColor
        {
            get { return (Color)GetValue(SelectedColorProperty); }
            set { SetValue(SelectedColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedColorProperty =
            DependencyProperty.Register("SelectedColor", typeof(Color), typeof(ColorMixer), new PropertyMetadata(Colors.DarkBlue));

        public delegate void OnOKClick(object sender,EventArgs e);
        public delegate void OnCancelClick(object sender, EventArgs e);

        public event OnOKClick OnOKButtonClick;
        public event OnCancelClick OnCancelButtonClick;

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            OnOKButtonClick?.Invoke(sender,e);
        }

       
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            OnCancelButtonClick?.Invoke(sender, e);
        }
    }
}
