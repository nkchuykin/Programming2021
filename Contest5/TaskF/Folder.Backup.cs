using System;
using System.Collections.Generic;

internal sealed partial class Folder
{
    internal class Backup
    {
        private List<File> files = new List<File>();

        public Backup(Folder folder)
        {
            throw new NotImplementedException();
        }
        
        public static void Restore(Folder folder, Backup backup)
        {
            throw new NotImplementedException();
        }
    }

    public void AddFile(string name, int size)
    {
        throw new NotImplementedException();
    }

    public void RemoveFile(File file)
    {
        throw new NotImplementedException();
    }

    public File this[int i] => throw new NotImplementedException();

    public File this[string filename] => throw new NotImplementedException();
}