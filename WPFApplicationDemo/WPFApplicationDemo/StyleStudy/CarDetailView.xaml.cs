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

namespace WPFApplicationDemo.StyleStudy
{
    /// <summary>
    /// Interaction logic for CarDetailView.xaml
    /// </summary>
    public partial class CarDetailView : UserControl
    {
        private Car car;
        public CarDetailView()
        {
            InitializeComponent();
        }
        public Car Car
        {
            get { return car; }
            set
            {
                car = value;
                this.textBlockName.Text = car.Name;
                this.textBlockYear.Text = car.Year;
                this.textBlockTopSpeed.Text = car.TopSpeed;
                this.textBlockAutomaker.Text = car.AutoMaker;
                string uriStr = string.Format(@"/Resources/Logos/{0}.png", car.Name);
                this.imagePhoto.Source = new BitmapImage(new Uri(uriStr, UriKind.Relative));
            }
        }
    }
}
