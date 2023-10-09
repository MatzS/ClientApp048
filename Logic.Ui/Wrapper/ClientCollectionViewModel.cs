using De.HsFlensburg.ClientApp048.Business.Model.BusinessObjects;
using De.HsFlensburg.ClientApp048.Logic.Ui.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.HsFlensburg.ClientApp048.Logic.Ui.Wrapper
{
    public class ClientCollectionViewModel : ViewModelSyncCollection<ClientViewModel, Client, ClientCollection>
    {
        private ClientCollection myClients;
        public ClientCollectionViewModel()
        {
            myClients = new ClientCollection();

            foreach(Client client in myClients)
            {
                this.Add(new ClientViewModel(client));
            }
        }
        public override void NewModelAssigned()
        {
            throw new NotImplementedException();
        }
    }
}
