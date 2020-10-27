using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    sealed class DataHolder
    {
        private static DataHolder instance;
        private DataHolder() { Lines = new List<string>(); }

        public static DataHolder Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataHolder();
                }
                return instance;
            }
        }

        public List<string> Lines { get; set; }

    }
}
