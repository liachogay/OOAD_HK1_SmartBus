using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BusMap
{
    class Connect : LoginApp
    {
        public void OnClickButtonConnect(string txtEmtpy)
        {
            if (txtEmtpy != "")
            {
                MessageBox.Show("Mua vé thành công", "Thanh toán mua vé", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("String empty");
            }
        }
    }
}
