using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppXF.Models
{
    public static class MS_Common
    {
        static MS_Common()
        {
            People = new ObservableCollection<M_Person>();
        }
        public static ObservableCollection<M_Person> People { get; set; }
    }
}
