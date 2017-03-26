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

namespace ExtendedResourceSample
{
    /// <summary>
    /// Interaction logic for CodeBehindResource.xaml
    /// </summary>
    public partial class CodeBehindResource : Window
    {
        public CodeBehindResource()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(Object sender, EventArgs e)
        {
            //lbResult.Items.Clear();
            lbResult.Items.Add(pnlMain.FindResource("strPanel").ToString());
            lbResult.Items.Add(this.FindResource("strWindow").ToString());
            lbResult.Items.Add(Application.Current.FindResource("strApplication").ToString());
        }
    }
}
