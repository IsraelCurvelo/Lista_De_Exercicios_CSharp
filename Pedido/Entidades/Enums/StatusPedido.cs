using System;
using System.Collections.Generic;
using System.Text;

namespace Pedido.Entidades.Enums
{
    enum StatusPedido : int
    {
        AguardandoPagamento =0,
        Processando =1,
        Enviado =2,
        Entregue =3 
    }
}
