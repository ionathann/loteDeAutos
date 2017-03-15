using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Context;
using DataAccess.Data;
using System.Data.Entity;

namespace DataAccess.Metodos
{
    public class CsVenta
    {
        public static void savePagoPorRegistro(int idusr)
        {
            try
            {
                var ctx = new DtContext();
                ventas pg = new ventas();

                int max = ctx.autos.Max(p => p.idauto);
                autos au = ctx.autos.Where(x => x.idauto == max).FirstOrDefault();
                int maxp = ctx.propietarios.Max(m => m.idpropietario);
                Clientes pr = ctx.clientes.Where(x => x.idcomprador == maxp).FirstOrDefault();
                Usuario usr = ctx.usuarios.Where(x => x.pkUsuario == idusr).FirstOrDefault();
                ctx.usuarios.Attach(usr);
                ctx.autos.Attach(au);
                ctx.clientes.Attach(pr);

                pg.autos = au;                
                pg.compradores = pr;
                pg.usuarios = usr;
                pg.total = 200;

                pg.fecha = DateTime.Now;
                ctx.Entry(pg).State = EntityState.Added;
                ctx.SaveChanges();


            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Venta(int idAuto, int usuario, int comprador, ventas Venta)
        {
            try
            {
                var ctx = new DtContext();
                autos aut = ctx.autos.Where(r => r.idauto == idAuto).FirstOrDefault();
                ctx.autos.Attach(aut);
                Venta.autos = aut;

                Usuario usu = ctx.usuarios.Where(r => r.pkUsuario == usuario).FirstOrDefault();
                ctx.usuarios.Attach(usu);
                Venta.usuarios = usu;

                Clientes com = ctx.clientes.Where(r => r.idcomprador == idAuto).FirstOrDefault();
                ctx.clientes.Attach(com);
                Venta.compradores = com;

                ctx.Entry(Venta).State = EntityState.Added;
                ctx.SaveChanges();

            }
            catch (Exception ex)
            {
            }
        }

        public static void GuardarComprador(Clientes ine)
        {
            try
            {
                var ctx = new DtContext();



                ctx.clientes.Add(ine);
               
                ctx.SaveChanges();
            }
            catch (Exception exc)
            {

                throw;
            }
        }

    }
}
