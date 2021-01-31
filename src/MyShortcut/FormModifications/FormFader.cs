using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyShortcut.FormModifications
{
    public class FormFader
    {
        private static double MIN_OPACITY = 0.4;
        private static double OPACITY_STEP = 0.02;
        private static int FADE_WAITING_TIMER_INTERVAL = 5000;

        private readonly Form fadingForm;
        private readonly Timer fadeTimer = new Timer();
        private readonly Timer fadeWaitingTimer = new Timer();

        private bool FadingActive = true;
        public FormFader(Form form)
        {
            fadingForm = form;
        }

        public void Initialize()
        {
            // Set initial opacity
            fadingForm.Opacity = MIN_OPACITY;

            // Mouse enter/leave for all the form
            fadingForm.MouseEnter += new EventHandler(FormFading_MouseEnter);
            fadingForm.MouseLeave += new EventHandler(FormFading_MouseLeave);
            foreach (Control cnt in fadingForm.Controls)
            {
                cnt.MouseEnter += new EventHandler(FormFading_MouseEnter);
                cnt.MouseLeave += new EventHandler(FormFading_MouseLeave);

                if (cnt is TextBox textBox)
                {
                    textBox.GotFocus += TextBox_HasUserAction;
                    textBox.TextChanged += TextBox_HasUserAction;
                }
            }

            // Form fading timer. When active it hides the form.
            fadeTimer.Interval = 50;
            fadeTimer.Tick += new EventHandler(FadeTimer_Tick);

            // Form waiting timer
            fadeWaitingTimer.Interval = FADE_WAITING_TIMER_INTERVAL;
            fadeWaitingTimer.Tick += new EventHandler(FadeWaitingTimer_Tick);
        }

        public void PauseFading()
        {
            fadeWaitingTimer.Stop();
            StopFading();
            FadingActive = false;
        }
        public void ResumeFading()
        {
            FadingActive = true;
            fadeWaitingTimer.Start();
        }

        private void StartFading()
        {
            fadeTimer.Start();
        }
        private void StopFading()
        {
            fadingForm.Opacity = 1;
            fadeTimer.Stop();
        }

        /// <summary>
        /// The user takes action on the textbox. 
        /// We must give them some seconds until next action or we must start fading
        /// </summary>
        private void TextBox_HasUserAction(object sender, EventArgs e)
        {
            StopFading();

            // restart timer whenever the textBox get some action
            fadeWaitingTimer.Stop();
            fadeWaitingTimer.Start();
        }

        private void FormFading_MouseEnter(object sender, EventArgs e)
        {
            StopFading();
        }

        private void FormFading_MouseLeave(object sender, EventArgs e)
        {
            // Don't fade if fadeWaitingTimer is enabled and ready to fade
            if (!fadeWaitingTimer.Enabled && FadingActive)
                StartFading();
        }

        private void FadeWaitingTimer_Tick(object sender, EventArgs e)
        {
            fadeWaitingTimer.Stop();
            StartFading();
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            //if (txtInput.Focused == true)
            //    fadeTimer.Stop();

            if (fadingForm.Opacity > MIN_OPACITY)
            {
                fadingForm.Opacity -= OPACITY_STEP;
            }
            else
            {
                fadeTimer.Stop();
            }
        }
    }
}
