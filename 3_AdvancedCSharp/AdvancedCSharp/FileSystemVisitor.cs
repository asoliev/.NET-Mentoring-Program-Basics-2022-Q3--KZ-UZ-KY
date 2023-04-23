namespace AdvancedCSharp
{
    internal class FileSystemVisitor
    {
        private string path;

        public FileSystemVisitor(string path)
        {
            this.path = path;
        }

        public IEnumerable<string> GetFileTree(string filter = "")
        {
            var directory = new DirectoryInfo(path);
            if (directory.Exists)
            {
                return GetFileSystemTree(directory, filter);
            }
            else
            {
                return Enumerable.Empty<string>();
            }
        }

        private IEnumerable<string> GetFileSystemTree(DirectoryInfo directory, string filter)
        {
            IList<string> result = new List<string>();
            DirectoryInfo[] dirs = directory.GetDirectories();
            foreach (DirectoryInfo dir in dirs)
            {
                result.Add(dir.FullName);

                FileInfo[] files = dir.GetFiles(filter);
                foreach (FileInfo file in files)
                {
                    result.Add(file.FullName);
                }

                if (Directory.Exists(dir.FullName))
                    result.Union(GetFileSystemTree(dir, filter));
            }
            return result;
        }
    }
}
