using System.Collections.Generic;

namespace Bridge
{
    public abstract class Storage<T> where T : class
    {
        public Storage(ISaveLoad<T> saveLoad)
        {
            this.saveLoad = saveLoad;
        }
        protected ISaveLoad<T> saveLoad;
        protected List<T> elements = new List<T>();
        public void Add(T element)
        {
            elements.Add(element);
        }
        public void Load(string path)
        {
            saveLoad.Load(path);
        }

        public void Save(string path)
        {
            saveLoad.Save(elements, path);
        }
    }

}
