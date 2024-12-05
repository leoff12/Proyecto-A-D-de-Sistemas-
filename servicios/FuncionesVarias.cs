using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using ProyectoFinal.Formularios;

namespace ProyectoFinal.Servicios
{
    
    //Función para desplegar el menú
    internal class FuncionesVarias
    {
        public static void ToggleMenu(Panel guna2PanelMenu, bool menuExpandido)
        {
            if (menuExpandido)
            {
                guna2PanelMenu.Width = 40; // Reducir el ancho del panel

                // Ocultar texto de los botones
                foreach (Control control in guna2PanelMenu.Controls)
                {
                    if (control is Guna2Button button)
                    {
                        button.Text = "";
                        button.ImageAlign = HorizontalAlignment.Center;
                    }
                }
            }
            else
            {
                guna2PanelMenu.Width = 187; // Expandir el ancho del panel

                // Restaurar texto de los botones
                foreach (Control control in guna2PanelMenu.Controls)
                {
                    if (control is Guna2Button button)
                    {
                        button.Text = button.Tag?.ToString();
                        button.ImageAlign = HorizontalAlignment.Left;
                    }
                }
            }
        }
    }
}

