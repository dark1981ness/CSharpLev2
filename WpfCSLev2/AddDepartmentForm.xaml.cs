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
using System.Windows.Shapes;

namespace WpfCSLev2
{
    /// <summary>
    /// Interaction logic for AddDepartmentForm.xaml
    /// </summary>
    public partial class AddDepartmentForm : Window
    {
        
        public Department DepInfo { get; set; }
        public event EventHandler<Department> AddDepData;
        public event EventHandler<Department> UpdateDepData;
        public event EventHandler<Department> RemoveDepData;
        public AddDepartmentForm()
        {
            InitializeComponent();
            
        }

        private void OnDragMoveWindow(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2 && this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else if (e.ClickCount == 2 && this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            this.DragMove();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            AddDepData?.Invoke(this, new Department
            {
                Id = Convert.ToInt32(this.depId.Text),
                Name = this.depName.Text
            });
            depId.Text = String.Empty;
            depName.Text = String.Empty;
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ChangeDepartment_Click(object sender, RoutedEventArgs e)
        {
            UpdateDepData?.Invoke(this, new Department
            {
                Id = Convert.ToInt32(this.depId.Text),
                Name = this.depName.Text
            });
            depId.Text = String.Empty;
            depName.Text = String.Empty;
        }

        private void RemoveDepartment_Click(object sender, RoutedEventArgs e)
        {
            RemoveDepData?.Invoke(this, new Department
            {
                Id = Convert.ToInt32(this.depId.Text),
            });
            depId.Text = String.Empty;
            depName.Text = String.Empty;
        }
    }
}
