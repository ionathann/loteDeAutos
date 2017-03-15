using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Context;
using DataAccess.Data;
using System.Drawing;
using System.IO;
using System.Data.Entity;

namespace DataAccess.Metodos
{
    public class CsAuto
    {
        public static List<autos> Listar()
        {
            try
            {
                var ctx = new DtContext();
                return ctx.autos.ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static List<autos> Buscar(string dato)
        {
            try
            {
                var ctx = new DtContext();
                return ctx.autos.Include("propietarios").Where(r => r.marca.Contains(dato) || r.modelo.Contains(dato)).ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

      

        public static List<autos> BuscarAutos(int idauto)
        {
            try
            {
                var ctx = new DtContext();
                return
                ctx.autos
                .Include("propietarios")
                .Where(r => r.propietarios.idpropietario == idauto).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
               

        public int idauto { get; set; }
        public Image fotografia { get; set; }

        public static void UpdateAuto(int idauton)
        {
            using (var ctx = new DtContext())
            {

                var au = ctx.autos.Find(idauton);
                au.bStatus = false;
                ctx.SaveChanges();
            }
                                    
        }

        public static void Guardar(autos datosauto, int idPropietario)
        {
            try
            {
                var ctx = new DtContext();
                propietario prop = ctx.propietarios.Where(r => r.idpropietario == idPropietario).FirstOrDefault();
                ctx.propietarios.Attach(prop);
                datosauto.propietarios = prop;
                ctx.Entry(datosauto).State = EntityState.Added;
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private static propietario ObtenetPropietario(int id)
        {
            try
            {
                var ctx = new DtContext();
                return ctx.propietarios.Where(r => r.idpropietario == id).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw;
            }
        }


    }

}
