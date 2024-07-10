using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTO_DE_VENTA.conexion
{
    internal class tamaño_datatablas
    {
    public static void multilinea(ref DataGridView List)
        {
            List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            List.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            List.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            List.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle stilo_dgv = new DataGridViewCellStyle();
            stilo_dgv.BackColor =System.Drawing.Color.White;
            stilo_dgv.ForeColor = System.Drawing.Color.Black;
            stilo_dgv.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            List.ColumnHeadersDefaultCellStyle = stilo_dgv;


            }

    }

}
