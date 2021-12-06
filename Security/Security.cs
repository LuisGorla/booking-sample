using BE.ViewModels;
using DAL.Models;
using DAL.Repositories;
using Encriptacion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Security
{
    public static class Security
    {
        public static Usuario LoggedUser { get; set; }

        public static bool VerificarUsuario (LoginViewModel usuario) {

            var repository = new GenericRepository<Usuario>();
            var a = repository.GetAll();
            LoggedUser = repository.GetAll().Where(x => Encriptacion.Encriptacion.DecryptString(x.Dni) == usuario.DNI).FirstOrDefault();

            if (LoggedUser == null)
            {
                return false;
            }

            if (LoggedUser.Dni == Encriptacion.Encriptacion.EncryptString(usuario.DNI) && LoggedUser.ContraseA == usuario.Password)
            {
                

                return true;
            }
            else
            {
                LoggedUser = null;
                return false;
            }
        }

        public static IEnumerable<PatenteUsuario> VerificarPatente() {
            try
            {
                var repository = new GenericRepository<PatenteUsuario>();
                var LoggedUserPatentes = repository.GetAll().Where(x => x.IdUsuario == LoggedUser.IdUsuario).ToList();

                if (LoggedUserPatentes.Count > 0)
                {
                    return LoggedUserPatentes;
                }
                else
                {
                    return null;
                }
            }
            catch 
            {
                return null;
            }
            
            
        }
        public static Dictionary<int?, List<int?>> VerificarFamilia() {

            try
            {
                var repository = new GenericRepository<FamiliaUsuario>();
                var LoggedUserFamilias = repository.GetAll().Where(x => x.IdUsuario == LoggedUser.IdUsuario).ToList();
                
                var repository2 = new GenericRepository<PatenteFamilium>();
                var dictionaryPatentes = new Dictionary<int?,List<int?>>();

                foreach (var Familia in LoggedUserFamilias)
                {
                    var currentPatentes = repository2.GetAll().Where(x => x.IdFamilia == Familia.IdFamilia).ToList();
                    var filteredPatentes = currentPatentes.Select(x => x.IdPatente).Distinct().ToList();

                    dictionaryPatentes.Add(Familia.IdFamilia, filteredPatentes);
                }                

                if (dictionaryPatentes.Count > 0)
                {
                    return dictionaryPatentes;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public static string CrearDVH(string dvh)
        {
            var encriptarDvh = Encriptacion.Encriptacion.EncriptarIrreversible(dvh);

            return encriptarDvh;
        }
        public static bool VerificarIntegridad()
        {
            var repoPatente = new GenericRepository<Patente>();
            var patentes = repoPatente.GetAll();

            var repoFamilia = new GenericRepository<Familia>();
            var familias = repoFamilia.GetAll();

            var repoFamiliaUsuario = new GenericRepository<FamiliaUsuario>();
            var familiaUsuarios = repoFamiliaUsuario.GetAll();

            var repoPatenteFamilia = new GenericRepository<PatenteFamilium>();
            var patenteFamilias = repoPatenteFamilia.GetAll();

            var repoPatenteUsuario = new GenericRepository<PatenteUsuario>();
            var patenteUsuarios = repoPatenteUsuario.GetAll();

            var repoUsuarios = new GenericRepository<Usuario>();
            var usuarios = repoUsuarios.GetAll();

            var dictionaryIntegridad = new Dictionary<int, bool>();

            foreach (var patente in patentes)
            {
                string concat = $"{patente.Detalle}{patente.IdPatente}";
                if (patente.Dvh == CrearDVH(concat))
                {
                    dictionaryIntegridad.Add(patente.IdPatente, true);
                }
                else
                {
                    dictionaryIntegridad.Add(patente.IdPatente, false);
                }
                    
            }

            foreach (var familia in familias)
            {
                string concat = $"{familia.Detalle}";
                if (familia.Dvh == CrearDVH(concat))
                {
                    dictionaryIntegridad.Add((familia.IdFamilia * 5), true);
                }
                else
                {
                    dictionaryIntegridad.Add((familia.IdFamilia * 5), false);
                }

            }

            foreach (var familiaUsuario in familiaUsuarios)
            {
                string concat = $"{familiaUsuario.IdFamilia}{familiaUsuario.IdUsuario}";
                if (familiaUsuario.Dvh == CrearDVH(concat))
                {
                    dictionaryIntegridad.Add(familiaUsuario.IdFamiliaUsuario * 7, true);
                }
                else
                {
                    dictionaryIntegridad.Add(familiaUsuario.IdFamiliaUsuario * 7, false);
                }

            }

            foreach (var patenteFamilia in patenteFamilias)
            {
                string concat = $"{patenteFamilia.IdPatente}{patenteFamilia.IdFamilia}";
                if (patenteFamilia.Dvh == CrearDVH(concat))
                {
                    dictionaryIntegridad.Add(patenteFamilia.IdPatenteFamilia * 11, true);
                }
                else
                {
                    dictionaryIntegridad.Add(patenteFamilia.IdPatenteFamilia * 11, false);
                }
            }

            foreach (var patenteUsuario in patenteUsuarios)
            {
                string concat = $"{patenteUsuario.IdPatente}{patenteUsuario.IdUsuario}";
                if (patenteUsuario.Dvh == CrearDVH(concat))
                {
                    dictionaryIntegridad.Add(patenteUsuario.IdPatenteUsuario * 13, true);
                }
                else
                {
                    dictionaryIntegridad.Add(patenteUsuario.IdPatenteUsuario * 13, false);
                }
            }

            foreach (var usuario in usuarios)
            {
                string concat = $"{usuario.Nombre}{usuario.Apellido}{usuario.Dni}{usuario.ContraseA}{usuario.Contacto}";
                if (usuario.Dvh == CrearDVH(concat))
                {
                    dictionaryIntegridad.Add(usuario.IdUsuario * 17, true);
                }
                else
                {
                    dictionaryIntegridad.Add(usuario.IdUsuario * 17, false);
                }
            }
            var listIntegridad = dictionaryIntegridad.Select(x => x.Value).Distinct().ToList();
            if (listIntegridad.Exists(x => x.Equals(false)))
            {
                return false;                
            }
            else
            {
                return true;
            }

            
        }

        public static void RegistrarBitacora(string nombreTabla, string dvh)
        {

        }
        public static void CargarDvv()
        {
        //    var repo = new GenericRepository<Dvv>();

        //    var repoPatente = new GenericRepository<Patente>();
        //    var patentes = repoPatente.GetAll().Select(x => x.Dvh);

        //    var repoFamilia = new GenericRepository<Familia>();
        //    var familias = repoFamilia.GetAll().Select(x => x.Dvh);

        //    var repoFamiliaUsuario = new GenericRepository<FamiliaUsuario>();
        //    var familiaUsuarios = repoFamiliaUsuario.GetAll().Select(x => x.Dvh);

        //    var repoPatenteFamilia = new GenericRepository<PatenteFamilium>();
        //    var patenteFamilias = repoPatenteFamilia.GetAll().Select(x => x.Dvh);

        //    var repoPatenteUsuario = new GenericRepository<PatenteUsuario>();
        //    var patenteUsuarios = repoPatenteUsuario.GetAll().Select(x => x.Dvh);

        //    var repoUsuarios = new GenericRepository<Usuario>();
        //    var usuarios = repoUsuarios.GetAll().Select(x => x.Dvh);


        //    var dv1 = new Dvv();
        //    var dv2 = new Dvv();
        //    var dv3 = new Dvv();
        //    var dv4 = new Dvv();
        //    var dv5 = new Dvv();
        //    var dv6 = new Dvv();

        //    var concatPatentes = string.Join("", patentes);
        //    dv1.Tabla = "Patentes";
        //    dv1.Dvv1 = CrearDVH(concatPatentes);
        //    repo.Insert(dv1);

        //    var concatfamilias = string.Join("", familias);
        //    dv2.Tabla = "Familias";
        //    dv2.Dvv1 = CrearDVH(concatfamilias);
        //    repo.Insert(dv2);

        //    var concatfamiliaUsuarios = string.Join("", familiaUsuarios);
        //    dv3.Tabla = "FamiliaUsuario";
        //    dv3.Dvv1 = CrearDVH(concatfamiliaUsuarios);
        //    repo.Insert(dv3);

        //    var concatpatenteFamilias = string.Join("", patenteFamilias);
        //    dv4.Tabla = "PatenteFamilia";
        //    dv4.Dvv1 = CrearDVH(concatpatenteFamilias);
        //    repo.Insert(dv4);

        //    var concatpatenteUsuarios = string.Join("", patenteUsuarios);
        //    dv5.Tabla = "PatenteUsuario";
        //    dv5.Dvv1 = CrearDVH(concatpatenteUsuarios);
        //    repo.Insert(dv5);

        //    var concatusuarios = string.Join("", usuarios);
        //    dv6.Tabla = "Usuarios";
        //    dv6.Dvv1 = CrearDVH(concatusuarios);
        //    repo.Insert(dv6);
        }
    }
}
