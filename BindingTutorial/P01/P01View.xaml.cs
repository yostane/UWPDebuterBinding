using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace BindingTutorial.P01
{
    public partial class P01View : Page
    {
        private int classroomStudents = 0;

        public P01View()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            classroomStudents += 1;
            textBlock.Text = "" + classroomStudents;
        }
    }
}
