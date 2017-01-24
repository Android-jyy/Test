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
using System.Windows.Shapes;

namespace WPFApplicationDemo.StyleStudy
{
    /// <summary>
    /// Interaction logic for StyleWindowTwo.xaml
    /// </summary>
    public partial class StyleWindowTwo : Window
    {
        public StyleWindowTwo()
        {
            InitializeComponent();
            InitialCarList();
        }
        private void InitialCarList()
        {
            List<Car> carList = new List<Car>()
            {
                new Car() {AutoMaker="1", Name="1", Year="1", TopSpeed = "1" },
                new Car() {AutoMaker="2", Name="2", Year="1", TopSpeed = "1" },
                new Car() {AutoMaker="3", Name="3", Year="1", TopSpeed = "1" },
                new Car() {AutoMaker="4", Name="4", Year="1", TopSpeed = "1" },
                new Car() {AutoMaker="5", Name="5", Year="1", TopSpeed = "1" }
            };
            this.listBoxCars.ItemsSource = carList;
        }
    }
}
