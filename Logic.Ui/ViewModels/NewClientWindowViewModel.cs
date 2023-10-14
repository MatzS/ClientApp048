using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace De.HsFlensburg.ClientApp048.Logic.Ui.ViewModels
{
    public class NewClientWindowViewModel
    {
        public ICommand AddClient { get; }

        public NewClientWindowViewModel()
        {
            AddClient = new RelayCommand(AddClientMethod);
        }

        private void AddClientMethod()
        {
            Console.Out.WriteLine("Kunde hinzugefügt");
        }
    }
}
