namespace INF_PLFUE_Ampelschaltung
{
    public partial class Form1 : Form
    {
        Boolean isRed = false;

        public Form1()
        {
            InitializeComponent();
            tDrive.Start();

            rbManuel.Checked = true; 
        }

        private void btRed_Click(object sender, EventArgs e)
        {
            paTrafficLight.BackColor = Color.Red;
            isRed = true;
        }

        private void btGreen_Click(object sender, EventArgs e)
        {
            paTrafficLight.BackColor = Color.Green;
            isRed = false;
        }



        private void tDrive_Tick_1(object sender, EventArgs e)
        {

            if (paC1.Location.X > (this.ClientSize.Width))
            {
                paC1.Left = -paC1.Width;
            }

            if (!(paC1.Location.X == (paTrafficLight.Location.X - paC1.Width) && isRed == true))
            {
                paC1.Location = new Point(paC1.Location.X + 10, paC1.Location.Y);
            }
        }

        private async void rbMode(object sender, EventArgs e)
        {
            try
            {
                if (rbAutomatic.Checked == true)
                {
                    btGreen.Enabled = false;
                    btRed.Enabled = false;

                    int greenValue = Convert.ToInt32(tbGreenDuration.Text) * 1000;
                    int redValue = Convert.ToInt32(tbRedDuration.Text)*1000;

                    if (isRed == false)
                    {
                        isRed = true;
                        paTrafficLight.BackColor = Color.Red;
                    }

                    while (rbAutomatic.Checked)
                    {
                        await System.Threading.Tasks.Task.Delay(redValue);
                        isRed = false;
                        paTrafficLight.BackColor = Color.Green;
                        await System.Threading.Tasks.Task.Delay(greenValue);
                        isRed = true;
                        paTrafficLight.BackColor = Color.Red;
                        await System.Threading.Tasks.Task.Delay(redValue);
                    }
                }
                else if (rbManuel.Checked == true)
                {
                    btGreen.Enabled = true;
                    btRed.Enabled = true; 
                }
            }
            catch (Exception e1)
            {
                rbAutomatic.Checked = false;
                rbManuel.Checked = true;
                MessageBox.Show("Fehler: " + e1.ToString());
            }
            

        }
    }
}
