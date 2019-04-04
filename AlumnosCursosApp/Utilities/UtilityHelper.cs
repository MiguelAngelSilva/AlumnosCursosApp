using AlumnosCursosDAL.EF;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AlumnosCursosApp.Utilities
{
    public static class UtilityHelper
    {
        #region Constantes
        public const string GUARDAR = "Confirmar acción: Guardar";
        public const string ELIMINAR = "Confirmar acción: Eliminar";
        public const string VALIDACION_TEXTBOX = "Debe completar el campo: ";

        #endregion
        
        public static void ClearForm(Form frm) {
            frm.Controls[0].Controls[0].Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = string.Empty);
        }

        public static bool ValidarDatos(Form frm) {
            foreach (var item in frm.Controls[0].Controls[0].Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(item.Text))
                {
                    MessageBox.Show(UtilityHelper.VALIDACION_TEXTBOX + item.Tag.ToString(), "Validación", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return false;
                }
            }
            return true;
        }
        static AlumnosCursosEntities _db = new AlumnosCursosEntities();
        public static AlumnosCursosEntities GetDbContext() {
            return _db;
        }
        
    }
}
