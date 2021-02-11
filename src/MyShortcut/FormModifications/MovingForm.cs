using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShortcut.FormModifications
{

    public class MovingForm
    {
        #region Moving Window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        private readonly Form form;

        public MovingForm(Form form)
        {
            this.form = form;
        }

        public void Initialize(Point? location)
        {
            // restore location
            if (location.HasValue && IsOnScreen(location.Value))
            {
                form.Location = location.Value;
            }

            form.MouseDown += Form_MouseDown;
            foreach (var cntrl in form.Controls)
            {
                if(cntrl is TextBox txt)
                {
                    txt.MouseDown += Form_MouseDown;
                }
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(form.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public Point? RecordWindowPosition()
        {
            Rectangle bounds = form.Bounds;

            bool isOnScreen = IsOnScreen(bounds.Location, bounds.Size);
            if (isOnScreen)
            {
                return bounds.Location;
            }
            return null;
        }


        private bool IsOnScreen(Point location, Size size)
        {
            return IsOnScreen(location) && IsOnScreen(location + size);
        }

        private bool IsOnScreen(Point location)
        {
            foreach (var screen in Screen.AllScreens)
            {
                Rectangle workingArea = new Rectangle(
                    screen.WorkingArea.Location,
                    screen.WorkingArea.Size);
                workingArea.Inflate(1, 1);
                if (workingArea.Contains(location))
                {
                    return true;
                }
            }
            return false;
        }

    
    }
}
