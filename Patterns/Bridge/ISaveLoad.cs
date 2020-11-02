using System.Collections.Generic;

namespace Bridge
{
    public interface ISaveLoad<T> where T : class 
    {
        public List<T> Load(string path);
        public void Save(List<T> data, string path);
    }

}
