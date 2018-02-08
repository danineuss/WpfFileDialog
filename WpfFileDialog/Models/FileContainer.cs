namespace WpfFileDialog.Models
{
    public class FileContainer
    {
        private string name;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public FileContainer(string name)
        {
            this.name = name;
        }
    }
}
