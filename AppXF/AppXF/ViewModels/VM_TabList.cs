using AppXF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppXF.ViewModels
{
    class VM_TabList:VM_TabMain
    {
        public VM_TabList()
        {
            
        }

        public ObservableCollection<M_Person> People
        {
            get
            {
                return MS_Common.People;
            }
        }
    }
}
