using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Data;
using DataAccess.Context;
using System.Data.Entity;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace DataAccess.Metodos
{
    public class CsPropietario
    {
        
        public static void GuardarPropietario(propietario propietario)
        {
            try
            {
                var ctx = new DtContext();

                ctx.propietarios.Add(propietario);
                
                ctx.SaveChanges();

            }
            catch (Exception exc)
            {

                throw;
            }
        }

        public static propietario obtenerPropietario(int ID)
        {
            try
            {
                var ctx = new DtContext();
                return ctx.propietarios.Where(r => r.idpropietario == ID).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static int gridvg(DataGridView dgv)
        {
            int valorsito;
            int i;
            i = dgv.SelectedCells[0].RowIndex;
            valorsito = Convert.ToInt32(dgv.Rows[i].Cells[0].Value);

            return valorsito;

        }

                    

       
    }
}
