using System;
using System.Collections.Generic;
using System.Linq;
using PeluqueriaStar.App.Dominio;

namespace PeluqueriaStar.App.Persistencia
{

    public interface IRepositorioAdministrador
    {
      IEnumerable<Administrador>  GetAllAdministrador();
      Administrador AddAdministrador(Administrador administrador);
      Administrador UpdateAdministrador (Administrador administrador);

      void DeleteAdministrador (int idAdministrador);
      Administrador  GetAdministrador (int idAdministrador);
      
      //Medico AsignarMedico (int idPaciente, int idMedico);
    }
}
