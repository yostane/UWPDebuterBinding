using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace BindingTutorial.P03
{
    public partial class P03View: Page
    {
        //has to be public
        public P03Classroom classroom { get; set; }

        public P03View()
        {
            InitializeComponent();
            this.classroom = new P03Classroom();
            this.classroom.addStudent();
        }

        private void button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            classroom.addStudent();
        }
    }
}
