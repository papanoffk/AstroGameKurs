using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace astroGame
{
    public class WindowManager
    {
        public static Gamer g;
        int w = 1280, h = 720;
        public string SpriteFolder = AppDomain.CurrentDomain.BaseDirectory + @"sprite\\";
        public WindowManager(Form form, string bg, Button buttonAccept, Button buttonCancel)
        {
            form.Size = new Size(w, h);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.BackgroundImage = new Bitmap(SpriteFolder + bg);
            form.BackgroundImageLayout = ImageLayout.Center;
            form.AcceptButton = buttonAccept;
            form.CancelButton = buttonCancel;
        }
        public WindowManager(Form form, string bg)
        {
            form.Size = new Size(w, h);
            form.StartPosition = FormStartPosition.CenterScreen;
            //form.BackgroundImage = new Bitmap(SpriteFolder + bg);
            //form.BackgroundImageLayout = ImageLayout.Center;
        }
    }
}
