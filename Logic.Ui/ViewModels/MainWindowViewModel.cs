using De.HsFlensburg.ClientApp048.Logic.Ui.Wrapper;
using De.HsFlensburg.ClientApp048.Services.SerializationService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace De.HsFlensburg.ClientApp048.Logic.Ui.ViewModels
{
    public class MainWindowViewModel
    {
        private ModelFileHandler modelFileHandler;
        private String pathForSerialization;
        public ICommand RenameValueInModelCommand { get; }

        public ICommand SaveCommand { get; }

        public ICommand LoadCommand { get; }
        public ClientCollectionViewModel MyList { get; set; }

        public MainWindowViewModel()
        {
            RenameValueInModelCommand = new RelayCommand(RenameValueInModel);
            SaveCommand = new RelayCommand(SaveModel);
            LoadCommand = new RelayCommand(LoadModel);
            MyList = new ClientCollectionViewModel();
            modelFileHandler = new ModelFileHandler();
            pathForSerialization = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ClientCollectionSerialization\\MyClients.cc";
        }

        private void RenameValueInModel()
        {
            //var collection = this.myDataGrid.ItemsSource as ClientCollectionViewModel;
            var first = MyList.FirstOrDefault();
            first.Model.Name = "Rename in the model";
        }

        private void SaveModel()
        {
            modelFileHandler.WriteModelToFile(pathForSerialization, MyList.Model);
        }

        private void LoadModel()
        {
            MyList.Model = modelFileHandler.ReadModelFromFile(pathForSerialization);
        }
    }
}
