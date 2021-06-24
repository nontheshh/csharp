
namespace ConsoleAppServer
{
    class FolderContent
    {
        public string[] directories { get; set; }
        public string[] files { get; set; }
        public FolderContent(string[] directories, string[] files)
        {
            this.directories = directories;
            this.files = files;
        }
    }
}
