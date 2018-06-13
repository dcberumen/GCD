using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCD
{
    public class GCDinterface : Form
    {
        private Label title = new Label();
        private Label sequencemessage = new Label();
        private Label sequencemessage2 = new Label();
        private TextBox sequenceinputarea = new TextBox();
        private TextBox sequenceinputarea2 = new TextBox();
        private Label outputinfo = new Label();
        private Button computebutton = new Button();
        private Button clearbutton = new Button();
        private Button exitbutton = new Button();
        public GCDinterface()
        {
            //Initialize text strings
            Text = "Greatest Common Devisor";
            title.Text = "GCD";
            sequencemessage.Text = "Enter first intiger";
            sequencemessage2.Text = "Enter second intiger";
            sequenceinputarea.Text = "";
            sequenceinputarea2.Text = "";
            outputinfo.Text = "Click on a button below";
            computebutton.Text = "GCD";
            clearbutton.Text = "Clear";
            exitbutton.Text = "Exit";

            //Set sizes
            Size = new Size(400, 300);
            title.Size = new Size(150, 30);
            sequencemessage.Size = new Size(150, 30);
            sequencemessage2.Size = new Size(150, 30);
            sequenceinputarea.Size = new Size(150, 30);
            sequenceinputarea2.Size = new Size(150, 30);
            outputinfo.Size = new Size(370, 30);
            computebutton.Size = new Size(90, 30);
            clearbutton.Size = new Size(90, 30);
            exitbutton.Size = new Size(90, 30);

            //Set locations
            title.Location = new Point(140, 20);
            sequencemessage.Location = new Point(20, 80);
            sequencemessage2.Location = new Point(200, 80);
            sequenceinputarea.Location = new Point(20, 110);
            sequenceinputarea2.Location = new Point(200, 110);
            outputinfo.Location = new Point(20, 150);
            computebutton.Location = new Point(20, 200);
            clearbutton.Location = new Point(150, 200);
            exitbutton.Location = new Point(270, 200);

            AcceptButton = computebutton;

            //Add controls to the form
            Controls.Add(title);
            Controls.Add(sequencemessage);
            Controls.Add(sequencemessage2);
            Controls.Add(sequenceinputarea);
            Controls.Add(sequenceinputarea2);
            Controls.Add(outputinfo);
            Controls.Add(computebutton);
            Controls.Add(clearbutton);
            Controls.Add(exitbutton);

            //Register the event handler.  In this case each button has an event handler, but no other 
            //controls have event handlers.
            computebutton.Click += new EventHandler(computeGCD);
            clearbutton.Click += new EventHandler(cleartext);
            exitbutton.Click += new EventHandler(stoprun);  //The '+' is required.
        }

        protected void computeGCD(Object sender, EventArgs events)
        {
            var text1 = sequenceinputarea.Text;
            var text2 = sequenceinputarea2.Text;
            long int1, int2;
            string output = "";
            if (long.TryParse(text1, out int1) && long.TryParse(text2, out int2))
            {
                if (int1 <= 0 || int2 <= 0)
                {
                    output = "Error in input: try again";
                    outputinfo.Text = output;
                }
                else
                {
                    long GCD = GCDlogic.computeGCD(int1, int2);
                    output = "GCD(" + int1 + ", " + int2 + "): " + GCD;
                    outputinfo.Text = output;
                }
            }
            else
            {
                output = "Error in input: try again";
                outputinfo.Text = output;
            }
        }

        protected void cleartext(Object sender, EventArgs events)
        {
            sequenceinputarea.Text = "";
            sequenceinputarea2.Text = "";
            outputinfo.Text = "";
        }

        protected void stoprun(Object sender, EventArgs args)
        {
            Close();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GCDinterface
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "GCDinterface";
            this.Load += new System.EventHandler(this.GCDinterface_Load);
            this.ResumeLayout(false);

        }

        private void GCDinterface_Load(object sender, EventArgs e)
        {

        }
    }
}
