using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using MediaToolkit;
using System.IO;
using System.Net;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int progress = 0;
        public Form1()
        {
            InitializeComponent();
        }

        Boolean format = true;

        private async void btnTelecharger_Click(object sender, EventArgs e)
            
        {
            try
            {
                if (this.txtBoxAddresse.Text == "")
                {
                    MessageBox.Show("veuillez coller le lien dans le carre specifique svp!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { 
                    using (FolderBrowserDialog fdb = new FolderBrowserDialog() { Description = "Telechargerment video ou audio" })
                    {
                        if (fdb.ShowDialog() == DialogResult.OK)
                        {
                            GetTitle();
                            MessageBox.Show("le téléchargement a commencé veuillez patienter!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            var ytb = YouTube.Default;
                            var video = await ytb.GetVideoAsync(txtBoxAddresse.Text);
                            File.WriteAllBytes(fdb.SelectedPath + @"\" + video.FullName, await video.GetBytesAsync());

                            var inpFile = new MediaToolkit.Model.MediaFile { Filename = fdb.SelectedPath + @"\" + video.FullName };
                            var outFile = new MediaToolkit.Model.MediaFile { Filename = $"{fdb.SelectedPath + @"\" + video.FullName }.mp3" };

                            using (var engine = new Engine())
                            {
                                engine.GetMetadata(inpFile);
                                engine.Convert(inpFile, outFile);
                            }
                            if (format == true)
                            {
                                File.Delete(fdb.SelectedPath + @"\" + video.FullName);
                            }
                            else
                            {
                                File.Delete($"{ fdb.SelectedPath + @"\" + video.FullName}.mp3");
                            }


                            //// progressBar1.Value = 100;
                            timer1.Enabled = true;
                            lblpercentage.Visible = true;

                            if (progress >= 100)
                            {
                                MessageBox.Show("téléchargement terminé", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("veuillez choisir le fichier du dossier!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
            }
            }catch(Exception ex)
            {
                MessageBox.Show("Tachez a coller le lien dans le bar pour continuer", "Erreure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void radioBtnAudio_CheckedChanged(object sender, EventArgs e)
        {
            format = true;
        }

        private void radioBtnVideo_CheckedChanged(object sender, EventArgs e)
        {
            format = false;
        }

        void GetTitle()
        {
            WebRequest damande = HttpWebRequest.Create(txtBoxAddresse.Text);
            WebResponse reponse;

            reponse = damande.GetResponse();
            StreamReader sreader = new StreamReader(reponse.GetResponseStream());
            string entrant = sreader.ReadToEnd();
            int a = entrant.IndexOf("<title>") + 7;
            int b = entrant.Substring(a).IndexOf("</title>");
            string c = entrant.Substring(a , b);
            labeltitle.Text = (c);

        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            txtBoxAddresse.Text = "";
            progressBar1.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progress++;
            if (progress >= 100)
            {
                timer1.Enabled = false;
                timer1.Stop();
            }
            //otherwise
            else
            {
                progressBar1.Value = progress;

                lblpercentage.Text = progressBar1.Value.ToString() + "%";
            }
        }
    }
}
