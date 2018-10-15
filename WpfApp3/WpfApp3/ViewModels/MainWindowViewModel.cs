using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    class MainWindowViewModel
    {
        //List<Visitor> visitors;
        public MainWindowViewModel()
        {
            WindowLogin windowLogin = new WindowLogin();
            windowLogin.ShowDialog();
        }

        public List<Visitor> Visitors
        {
            get
            {
                try
                {
                    return App.Db.Visitor.ToList();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }
    }
}
