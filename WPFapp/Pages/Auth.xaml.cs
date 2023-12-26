using HuinaEbat.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
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
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        public Auth()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            HttpClient httpClient = new HttpClient();


            g.users = await httpClient.GetFromJsonAsync<List<User>>("https://localhost:44378/api/Users");
            g.roles = await httpClient.GetFromJsonAsync<List<Role>>("https://localhost:44378/api/Roles");
            g.childs = await httpClient.GetFromJsonAsync<List<Child>>("https://localhost:44378/api/Children");

            //this.NavigationService.Navigate(new UserLists());

            User us = new User { city = "adsada", Email = "", Password = "", phone = "", Name = "Дияз", RoleID = 0, zarplata = 34232312, Id = 0 };

            //g.users.Add(us);
            //using var response = await httpClient.PostAsJsonAsync<User>("https://localhost:44378/api/Users", us);

            us.Name = "ЧИПА";
            us.Id = 7;
            using var respinse2 = await httpClient.PutAsJsonAsync<User>("https://localhost:44378/api/Users/" + us.Id.ToString(), us);

            //using var res = await httpClient.DeleteAsync("https://localhost:44378/api/Users/2");

        }
    }
}
