
namespace ConsoleAppClient
{
    enum ItemType { File, Directory, Nothing, Something, TxtFile };
    class Item
    {
        public ItemType type { get; private set; }
        public string fullName { get; private set; }
        public string name { get; private set; }

        public Item(string fullName, ItemType type)
        {
            this.fullName = fullName;
            this.name = fullName.Substring(fullName.LastIndexOf('\\') + 1);
            this.type = type;
        }
    }
}
