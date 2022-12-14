using System;
using System.Collections.Generic;
using System.Linq;
using PeluqueriaStar.App.Dominio;

namespace PeluqueriaStar.App.Persistencia
{

    public interface IRepositorioCliente
    {
      IEnumerable<Cliente>  GetAllClientes();
      Cliente AddCliente(Cliente cliente);
      Cliente UpdateCliente (Cliente cliente);

      void DeleteCliente (int idCliente);
      Cliente  GetCliente (int idCliente);
      
      //Medico AsignarMedico (int idPaciente, int idMedico);
    }
}
