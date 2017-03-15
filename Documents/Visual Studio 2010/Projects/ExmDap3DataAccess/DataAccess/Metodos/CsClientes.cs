using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Data;
using DataAccess.Context;

namespace DataAccess.Metodos
{
    public class CsClientes
    {

        public static Clientes obtenerCliente(int id)
        {
            try
            {
                var ctx = new DtContext();
                return ctx.clientes.Where(r => r.idcomprador == id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void borrarcli(int id)
        {
            var agre = new DtContext();
            Clientes clien = agre.clientes.Where(x => x.idcomprador == id).First();
            agre.clientes.Remove(clien);
            agre.SaveChanges();
        }

      
    }
}
