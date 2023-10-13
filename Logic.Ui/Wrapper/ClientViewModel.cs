using System;
using De.HsFlensburg.ClientApp048.Business.Model.BusinessObjects;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using De.HsFlensburg.ClientApp048.Logic.Ui.Base;

namespace De.HsFlensburg.ClientApp048.Logic.Ui.Wrapper
{
    public class ClientViewModel: ViewModelBase<Client>
    {
        private int id;

        public int Id
        {
            get {
                return Model.Id;
            }
            set { 
                Model.Id = value;
                OnPropertyChanged("Id");
            }
        }

        private String name;

        public String Name
        {
            get { return Model.Name; }
            set { 
                Model.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public override void NewModelAssigned()
        {
            throw new NotImplementedException();
        }
    }
}
