using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 鸿合智能电子教鞭
{
    public partial class Form1 : Form
    {
        private string localFilePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SoundPlayer player = new SoundPlayer(localFilePath);
            player.Play();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            localFilePath = null;
            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = false,
                Title = "选择教鞭声音文件",
                Filter = ".wav|*.wav*"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                localFilePath = ofd.FileName;//返回文件的完整路径
                MessageBox.Show("音频文件已成功加载！");
            }
            button1.Enabled = !string.IsNullOrEmpty(localFilePath);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
