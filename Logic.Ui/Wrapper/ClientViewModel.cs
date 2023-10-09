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
        private Client myClient = new Client();

        public ClientViewModel(Client client)
        {
            this.myClient = client;
        }
        public ClientViewModel() 
        { 
        }
        public int Id
        {
            get { return myClient.Id; }
            set { myClient.Id = value; }
        }

        private String name;

        public String Name
        {
            get { return myClient.Name; }
            set { myClient.Name = value; }
        }

        public override void NewModelAssigned()
        {
            throw new NotImplementedException();
        }
    }
}
