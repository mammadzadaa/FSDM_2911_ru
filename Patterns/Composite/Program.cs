using System.Threading;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new Folder("Root");
            root.Add(new Folder("Some Folder"));
            root.Add(new File("Some File"));

            var subFolder = new Folder("Another Folder");
            subFolder.Add(new File("NewFile1"));
            subFolder.Add(new File("NewFile2"));

            root.Add(subFolder);
            root.Display(0);
        }      
    }
}
