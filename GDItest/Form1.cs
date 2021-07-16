using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDItest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            TextFormatFlags flags = TextFormatFlags.Bottom | TextFormatFlags.EndEllipsis;
            
            System.Windows.Forms.TextRenderer.DrawText(
                g, "hello world", this.Font,
                new Rectangle(10, 10, 100, 50),
                Color.FromArgb(255, 0, 0),
                Color.FromArgb(100, 200, 200),
                flags
            );
        }
    }
}
