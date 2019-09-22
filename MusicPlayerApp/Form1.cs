using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }
        String[] paths, files;
        int trackNumber = 1;
        private void LblLogo_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            //close app
            this.Close();
        }

        private void BtnSelectSongs_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog.SafeFileNames; //save tracknames in files array
                paths = openFileDialog.FileNames; //save pathnames in paths array

                for (int i = 0; i < files.Length; i++)
                {
                    ListBoxSongs.Items.Add(trackNumber.ToString() + ". " + files[i]);
                    trackNumber++;
                }
            }
        }

        private void ListBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayerMusic.URL = paths[ListBoxSongs.SelectedIndex];
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AxWindowsMediaPlayerMusic_Enter(object sender, EventArgs e)
        {

        }
    }
}
