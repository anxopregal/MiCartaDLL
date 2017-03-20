using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartaLib
{
    public partial class ucImaxe : UserControl
    {
        public ucImaxe()
        {
            InitializeComponent();
        }

        public void setImaxe(System.Drawing.Image imagen)
        {
            this.pbImagen.Image = imagen;
        }

        public PictureBox getImaxe()
        {
            return this.pbImagen;
        }

        public void sClick(System.EventHandler obj)
        {
            this.pbImagen.Click += obj;
        }


    }
}
