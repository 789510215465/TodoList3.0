using System;
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

namespace todoList
{
    /// <summary>
    /// TodoItem.xaml 的互動邏輯
    /// </summary>
    public partial class TodoItem : UserControl
    {
        public TodoItem()
        {
            InitializeComponent();
        }

        private void Price_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Price.Text = "";
        }

        private void Date_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Date.Text = "";
        }

        private void Item_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //----//
        }

       

    }
}
