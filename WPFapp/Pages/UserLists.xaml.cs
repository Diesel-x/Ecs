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

namespace WPFapp.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserLists.xaml
    /// </summary>
    public partial class UserLists : Page
    {
        public UserLists()
        {
            InitializeComponent();

            foreach (var item in g.users)
            {
                ListBox.Items.Add(new TextBlock() { Text = item.Name });
            }

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(g.users[ListBox.SelectedIndex].Name);
        }
    }
}
