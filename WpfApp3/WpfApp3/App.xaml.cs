using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Data.Entity;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static visitorsDBEntities _db;
        public static visitorsDBEntities Db
        {
            get
            {
                if (_db == null)
                {
                    _db = new visitorsDBEntities();
                }
                return _db;
            }
        }

        public  DbSet<Visitor> Visitor { get => Db.Visitor; }
        
    }
}
