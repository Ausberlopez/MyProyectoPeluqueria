using System.Collections;
using System.Collections.Generic;
using System.Linq;
using PeluqueriaStar.App.Dominio;


namespace PeluqueriaStar.App.Persistencia
{
    public class ReposopitorioAdministrador : IRepositorioAdministrador
    {
        private readonly AppContext _appContext;

        public ReposopitorioAdministrador(AppContext appContext){
            _appContext = appContext;
        }

        Admistrador IRepositorioAdmistrador.AddAdmistrador(Admistrador admistrador ){
            var admistradorAdicionado = _appContext.Admistrador.Add(admistrador);
            _appContext.SaveChanges();
            return admistradorAdicionado.Entity;
        }

        //este metodo permitira eliminar 
        void IRepositorioAdmistrador.DeleteAdmistrador(int idAdmistrador)
        {
            var admistradorEncontrado = _appContext.Admistrador.FirstOrDefault(c => c.Id == idAdmistrador);
            if(admistradorEncontrado == null) 
            return;
              _appContext.Admistrador.Remove(admistradorEncontrado);
              _appContext.SaveChanges();           
        }

        IEnumerable<Admistrador> IRepositorioAdmistrador.GetAllAdmistradores()
        {
            return _appContext.Admistrador;//aqui
        }

        Admistrador IRepositorioAdmistrador.GetAdmistrador(int idAdmistrador) 
        { 
            Admistrador admistrador = new Admistrador();
            admistrador = _appContext.Clientes.FirstOrDefault(c => c.Id == idAdmistrador);
            return admistrador;
        }

        Admistrador IRepositorioAdmistrador.UpdateAdmistrador(Admistrador admistrador)
        {
            var clienteEncontrado =
                _appContext.Admistrador.FirstOrDefault(c => c.Id == admistrador.Id);
                if(admistradorEncontrado != null)
                {
                admistradorEncontrado.Nombre = admistrador.Nombre;
                admistradorEncontrado.Apellidos = admistrador.Apellidos;
                admistradorEncontrado.EstadoSalud = admistrador.EstadoSalud;
                admistradorEncontrado.Celular = admistrador.Celular;
                admistradorEncontrado.Dirrecion = admistrador.Dirrecion;
                admistradorEncontrado.Edad = admistrador.Edad;
                admistradorEncontrado.Genero = admistrador.Genero;
                admistradorEncontrado.Estelista = admistrador.Estelista;
                admistradorEncontrado.CitaAsignada = admistrador.CitaAsignada;
                

                _appContext.SaveChanges();
                }
                return admistradorEncontrado;
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