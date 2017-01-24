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

namespace WPFApplicationDemo.ICustomCommand
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            PasteCommand pc = new PasteCommand();
            ClearCommand cc = new ClearCommand();

            this.pasteSource.Command = pc;
            this.clearSource.Command = cc;

            this.pasteSource.CommandTarget = this.target;
            this.clearSource.CommandTarget = this.target;
        }

    }
}
