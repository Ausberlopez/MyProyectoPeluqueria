using System;
using System.Collections.Generic;
using System.Linq;
using PeluqueriaStar.App.Dominio;

namespace PeluqueriaStar.App.Persistencia
{

    public interface IRepositorioAdmistrador
    {
      IEnumerable<Administrador>  GetAllAdministrador();
      Admistrador AddAdmistrador(Admistrador admistrador);
      Admistrador UpdateAdmistrador (Admistrador admistrador);

      void DeleteAdmistrador (int idAdmistrador);
      Admistrador  GetAdmistrador (int idAdmistrador);
      
      //Medico AsignarMedico (int idPaciente, int idMedico);
    }
}
