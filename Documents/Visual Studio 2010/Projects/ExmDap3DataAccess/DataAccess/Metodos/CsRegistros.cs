using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Context;
using DataAccess.Data;

namespace DataAccess.Metodos
{
   public class CsRegistros
    {
       

       




       public static void GuardarAccesso(int idusr, string descrip)
       {
           try
           {
               var ctx = new DtContext();


               Usuario user = ctx.usuarios.Where(x => x.pkUsuario == idusr).FirstOrDefault();
               ctx.usuarios.Attach(user);

               var regis = new Registros() { usuario = user, Descripcion = descrip };
               ctx.registros.Add(regis);
               ctx.SaveChanges();
           }
           catch (Exception)
           {               
               throw;
           }
                
       
       }
       

    }
}
