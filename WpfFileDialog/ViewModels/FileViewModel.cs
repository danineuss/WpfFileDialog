using System.Windows.Input;
using WpfFileDialog.Models;
using WpfTreeView;

namespace WpfFileDialog.ViewModels
{
    public class FileViewModel : BaseViewModel
    {
        #region Private Members

        private string name;

        private ICommand _clickCommand;

        private bool canExecute;

        private FileContainer fileContainer;

        #endregion

        #region Constructor

        public FileViewModel()
        {
            name = "";
            fileContainer = new FileContainer(name);
        }

        #endregion

        public string Name
        {
            get => name;
            set
            {
                name = value;
                fileContainer.Name = value;
            }
        }

        public ICommand ClickCommand
        {
            get
            {
                if (_clickCommand == null)
                {
                    _clickCommand = new RelayCommand(FetchFile, canExecute);
                }
                return _clickCommand;
            }
        }

        public void FetchFile()
        {
            FileDialog fileDialog = new FileDialog();
            Name = fileDialog.FetchName();
        }
    }
}
