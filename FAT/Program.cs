using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Data[] memory = new Data[5];
            memory[0] = new Data(10, false);
            memory[1] = new Data(12, false);
            memory[2] = new Data(5, false);
            memory[3] = new Data(7, false);
            memory[4] = new Data(2, false);

            while (true)
            {
                Console.WriteLine("Medida del archivo que quieres ingresar a memoria");
                int archivo = int.Parse(Console.ReadLine());

                int mem = memory.Count(x => x.isInUse == false);
                if (mem != 0)
                {
                    foreach (var m in memory)
                    {
                        if (m.isInUse == false)
                        {
                            if (archivo >= 0)
                            {
                                archivo -= m.memory;
                                m.isInUse = true;
                            }
                            else
                            {
                                Console.WriteLine("Tu archivo fue ingresado a memoria exitosamente");
                                break;
                            }
                        }
                    }
                }

                else
                {
                    Console.WriteLine("No hay espacio en memoria");
                }
            }
        }
    }
}
