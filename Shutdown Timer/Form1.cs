using System.Diagnostics;

namespace Shutdown_Timer
{
    public partial class Form1 : Form
    {

        private static void Shutdown(float seconds)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "shutdown",
                Arguments = $"/s /t {seconds}",
                CreateNoWindow = true,
                UseShellExecute = false
            });

            MessageBox.Show("Der PC wird in " + (seconds / 60) + " Minuten heruntergefahren!", "Shutdown Timer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void StopShutdown()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "shutdown",
                Arguments = $"/a",
                CreateNoWindow = true,
                UseShellExecute = false
            });
            MessageBox.Show("Herunterfahren wurde abgebrochen!", "Shutdown Timer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                float input = float.Parse(textBox1.Text);
                float hours = (input * 60) * 60; //Berechne Sekunden des Timers
                Shutdown(hours);
            } else
            {
                MessageBox.Show("Bitte eine Zahl eingeben!", "Shutdown Timer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StopShutdown();
        }
    }
}
