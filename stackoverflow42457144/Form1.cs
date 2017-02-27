using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stackoverflow42457144
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var video = webBrowser1.Document.GetElementById("video1");
            video.SetAttribute("muted", "true");
        }
    }
}
