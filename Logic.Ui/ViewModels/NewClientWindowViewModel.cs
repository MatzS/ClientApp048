﻿using De.HsFlensburg.ClientApp048.Logic.Ui.Wrapper;
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
        public int Identifier { get; set; }
        public String Name { get; set; }

        private ClientCollectionViewModel clientCollectionViewModel;
        public ICommand AddClient { get; }

        public NewClientWindowViewModel(ClientCollectionViewModel viewModelCollection)
        {
            AddClient = new RelayCommand(AddClientMethod);
            clientCollectionViewModel = viewModelCollection;
        }

        private void AddClientMethod()
        {
            ClientViewModel cvm = new ClientViewModel();
            cvm.Id = Identifier;
            cvm.Name = Name;
            clientCollectionViewModel.Add(cvm);
        }
    }
}
