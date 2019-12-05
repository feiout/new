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

namespace New.Views
{
    /// <summary>
    /// Content.xaml 的交互逻辑
    /// </summary>
    public partial class CallList : UserControl
    {
        private int _loadedTimes;
        public CallList()
        {
            InitializeComponent();
            
            
        }

        private void CallList_OnInitialized(object sender, EventArgs e)
        {
            if (_loadedTimes > 0)
            {
                return;
            }
//            MessageBox.Show("Call ....");
            _loadedTimes++;
        }
    }
}
