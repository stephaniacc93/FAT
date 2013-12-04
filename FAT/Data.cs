using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAT
{
    class Data
    {
        public int memory;
        public bool isInUse;
        public string nombre;

        public Data(int memory, bool isInUse)
        {
            this.memory = memory;
            this.isInUse = isInUse;
        }
    }
}
