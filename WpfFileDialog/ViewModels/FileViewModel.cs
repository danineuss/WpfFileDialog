using WpfFileDialog.Models;

namespace WpfFileDialog.ViewModels
{
    public class FileViewModel : BaseViewModel
    {
        private string mName;

        private FileContainer fileContainer;

        public string Name
        {
            get => mName;
            set
            {
                mName = value;
                fileContainer.Name = value;
            }
        }

        public void FetchFile()
        {
            Name = "abc";
        }
    }
}
