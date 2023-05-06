using PootisApp.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace PootisApp
{
    internal class Services
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]

        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
           IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        private PrivateFontCollection fonts = new PrivateFontCollection();

        public Font GetResourceFont(byte[] fontData, float fontSize)
        {
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, fontData.Length);
            AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            return new Font(fonts.Families[0], fontSize);
        }

        public List<UnmanagedMemoryStream> GetResourceAudio()
        {
            List<UnmanagedMemoryStream> sounds = new List<UnmanagedMemoryStream>();

            ResourceManager MyResourceClass = new ResourceManager(typeof(Resources));
            ResourceSet resourceSet = MyResourceClass.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            foreach (DictionaryEntry entry in resourceSet)
            {
                string resourceKey = entry.Key.ToString();
                object resource = entry.Value;

                if (resource.GetType() == typeof(UnmanagedMemoryStream))
                {
                    sounds.Add((UnmanagedMemoryStream)resource);
                }
            }

            return sounds;
        }
    }
}
