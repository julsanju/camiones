using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ICamiones
{
    public interface ICamiones
    {
        Task Agregar_Camiones(Camion c);
    }
}
