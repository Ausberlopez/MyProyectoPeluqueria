using System.Collections;
using System.Collections.Generic;
using System.Linq;
using PeluqueriaStar.App.Dominio;


namespace PeluqueriaStar.App.Persistencia
{
    public class RepositorioAdministrador : IRepositorioAdministrador
    {
        private readonly AppContext _appContext;

        public RepositorioAdministrador(AppContext appContext){
            _appContext = appContext;
        }

        Administrador IRepositorioAdministrador.AddAdministrador(Administrador administrador ){
            var administradorAdicionado = _appContext.Administrador.Add(administrador);
            _appContext.SaveChanges();
            return administradorAdicionado.Entity;
        }

        //este metodo permitira eliminar 
        void IRepositorioAdministrador.DeleteAdministrador(int idAdministrador)
        {
            var administradorEncontrado = _appContext.Administrador.FirstOrDefault(c => c.Id == idAdministrador);
            if(administradorEncontrado == null) 
            return;
              _appContext.Administrador.Remove(administradorEncontrado);
              _appContext.SaveChanges();           
        }

        IEnumerable<Administrador> IRepositorioAdministrador.GetAllAdministrador()
        {
            return _appContext.Administrador;//aqui
        }

        Administrador IRepositorioAdministrador.GetAdministrador(int idAdministrador) 
        { 
            Administrador administrador = new Administrador();
            administrador = _appContext.Administrador.FirstOrDefault(c => c.Id == idAdministrador);
            return administrador;
        }

        Administrador IRepositorioAdministrador.UpdateAdministrador(Administrador administrador)
        {
            var administradorEncontrado =
                _appContext.Administrador.FirstOrDefault(c => c.Id == administrador.Id);
                if(administradorEncontrado != null)
                {
                administradorEncontrado.Nombre = administrador.Nombre;
                administradorEncontrado.Apellidos = administrador.Apellidos;
                administradorEncontrado.EstadoSalud = administrador.EstadoSalud;
                administradorEncontrado.Celular = administrador.Celular;               
                administradorEncontrado.Cliente = administrador.Cliente; 
                administradorEncontrado.Estelista = administrador.Estelista;
                administradorEncontrado.CitaAsignada = administrador.CitaAsignada;
                

                _appContext.SaveChanges();
                }
                return administradorEncontrado;
        }

                /*
Medico IRepositorioPaciente.AsignarMedico(int idPaciente, int idMedico)
{
   var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente );
   if(pacienteEncontrado != null)
   {
      var medicoEncontrado = _appContext.Medicos.FirstOrDefault(m => m.Id == idMedico);
      if(medicoEncontrado != null)
      { 
        pacienteEncontrado.Medico = medicoEncontrado;
        _appContext.SaveChanges();
      }
      return medicoEncontrado;
   }
   return null;
}*/

    }
}