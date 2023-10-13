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
        public override void NewModelAssigned()
        {
            throw new NotImplementedException();
        }
    }
}
