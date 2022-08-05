using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOynat_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MediaPlayer\\waltz.mp3";
        }

        private void btnIstanbul_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MediaPlayer\\istanbul.mp3";
        }

        private void btnEvgenyGrinko_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MediaPlayer\\onceupon.mp3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\TULPAR\\OneDrive\\Masaüstü\\c_sharp_form\\csharp_ornekler\\MediaPlayer\\brahms.mp3";
        }
    }
}
