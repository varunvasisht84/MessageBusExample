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

namespace MessageBusPatternInWPF
{
    /// <summary>
    /// Interaction logic for Control1.xaml
    /// </summary>
    public partial class Control1 : UserControl
    {
        public Control1()
        {
            InitializeComponent();
            MessageBusManager.Instance.Bus.Subscribe<ChangeTabTextMessageWithParameter>(HandleChangeTabTextMessageWithParameter);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBusManager.Instance.Bus.Publish(new ChangeTabTextMessage());
        }
        private void HandleChangeTabTextMessageWithParameter(ChangeTabTextMessageWithParameter message)
        {
            tab1Text.Text = message.Text;
        }
    }
}
