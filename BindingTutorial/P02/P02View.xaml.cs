using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace BindingTutorial.P02
{
    public partial class P02View : Page
    {
        P02Classroom classroom = new P02Classroom();

        public P02View()
        {
            InitializeComponent();
        }

        void updateControls()
        {
            studentCountSlider.Value = classroom.studentCount;
            studentCountTextBlock.Text = "" + classroom.studentCount;
        }

        private void button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            classroom.addStudent();
            this.updateControls();
        }

        private void studentCountSlider_ValueChanged(object sender, Windows.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventArgs e)
        {
            classroom.studentCount = (int)e.NewValue;
            this.updateControls();
        }
    }
}
