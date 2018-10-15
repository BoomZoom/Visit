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
        private Action close;
        public MainWindowViewModel(
            Action Close)
        {
            close = Close;

            WindowLogin windowLogin = new WindowLogin();
            bool? dialogResult = windowLogin.ShowDialog();
            System.Windows.Forms.MessageBox.Show(dialogResult.ToString());
            //if (dialogResult==true)
            //{
            //    System.Windows.Forms.MessageBox.Show(windowLogin.Password.ToString());                
            //}
        }
       

        public List<Visitor> Visitors
        {
            get
            {
                try
                {
                    return App.Db.Visitor.ToList();
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Ошибка соединения с базой данных");
                    //System.Windows.Forms.MessageBox.Show(ex.Message+"\n"+ ex.ToString());
                    close.Invoke();//TODO <-- Delete this line
                    return null;
                }
            }
        }
    }
}
