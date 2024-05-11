using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC_Converter
{
    public static class ThreadHelperClass
    {
        delegate void SetTextCallback(Form f, Control ctrl, string text);
        delegate void SetSpeedCallback(Form f, Control ctrl, int value);
        delegate void SetStyleCallback(Form f, Control ctrl, ProgressBarStyle value);
        /// <summary>
        /// Set text property of various controls
        /// </summary>
        /// <param name="form">The calling form</param>
        /// <param name="ctrl"></param>
        /// <param name="text"></param>
        public static void SetText(Form form, Control ctrl, string text)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (ctrl.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                form.Invoke(d, new object[] { form, ctrl, text });
            }
            else
            {
                ctrl.Text = text;
            }
        }
        public static void SetMarqueeSpeed(Form form, Control ctrl, int speed)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (ctrl.InvokeRequired)
            {
                SetSpeedCallback d = new SetSpeedCallback(SetMarqueeSpeed);
                form.Invoke(d, new object[] { form, ctrl, speed });
            }
            else
            {
                ((ProgressBar)ctrl).MarqueeAnimationSpeed = speed;
            }
        }
        public static void SetProgressbarStyle(Form form, Control ctrl, ProgressBarStyle style)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (ctrl.InvokeRequired)
            {
                SetStyleCallback d = new SetStyleCallback(SetProgressbarStyle);
                form.Invoke(d, new object[] { form, ctrl, style });
            }
            else
            {
                ((ProgressBar)ctrl).Style = style;
            }
        }
    }
}
