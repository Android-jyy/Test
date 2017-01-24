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
    /// Interaction logic for CarListItemView.xaml
    /// </summary>
    public partial class CarListItemView : UserControl
    {
        private Car car;
        public CarListItemView()
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
                string uriStr = string.Format(@"/Resources/logos/{0}.png", car.AutoMaker);
                this.imageLogo.Source = new BitmapImage(new Uri(uriStr, UriKind.Relative));
            }
        }
    }
}
