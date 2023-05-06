using PootisApp.Properties;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Media;
using System.Net.Security;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using System.Xml;
namespace PootisApp

{
    public partial class pootisForm : Form
    {
        
        private List<UnmanagedMemoryStream> resourceSounds = new List<UnmanagedMemoryStream>();
        private Services fs = new Services();
        public pootisForm()
        {
            InitializeComponent();
            pootisButton.Font = fs.GetResourceFont(Resources.tf2build, 18.0f);
            resourceSounds = fs.GetResourceAudio();
        }

        private void pootisButton_click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int songIndex = rnd.Next(0, 9);
            SoundPlayer sound = new SoundPlayer(resourceSounds[songIndex]);
            sound.Stream.Position = 0; // needs to reset before sound plays
            sound.Play();
        }
    }
}