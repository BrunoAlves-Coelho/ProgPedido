using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEnumComp.Entities.Enums
{
    enum PedidoStatus : int
    {
        Pagamento_Pendente = 0,
        Processandp = 1,
        Enviado = 2,
        Entregue = 3
    }
}