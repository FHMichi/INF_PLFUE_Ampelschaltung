namespace INF_PLFUE_Ampelschaltung
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tbRedDuration = new TextBox();
            tbGreenDuration = new TextBox();
            label1 = new Label();
            label2 = new Label();
            paTrafficLight = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            rbManuel = new RadioButton();
            rbAutomatic = new RadioButton();
            btRed = new Button();
            btGreen = new Button();
            tDrive = new System.Windows.Forms.Timer(components);
            paC1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbRedDuration
            // 
            tbRedDuration.Location = new Point(183, 12);
            tbRedDuration.Name = "tbRedDuration";
            tbRedDuration.Size = new Size(200, 39);
            tbRedDuration.TabIndex = 0;
            // 
            // tbGreenDuration
            // 
            tbGreenDuration.Location = new Point(183, 57);
            tbGreenDuration.Name = "tbGreenDuration";
            tbGreenDuration.Size = new Size(200, 39);
            tbGreenDuration.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 57);
            label1.Name = "label1";
            label1.Size = new Size(172, 32);
            label1.TabIndex = 2;
            label1.Text = "Grünphase (s): ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(148, 32);
            label2.TabIndex = 3;
            label2.Text = "Rotphase (s):";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // paTrafficLight
            // 
            paTrafficLight.BackColor = Color.Green;
            paTrafficLight.Location = new Point(710, 243);
            paTrafficLight.Name = "paTrafficLight";
            paTrafficLight.Size = new Size(89, 71);
            paTrafficLight.TabIndex = 5;
            // 
            // label3
            // 
            label3.BackColor = Color.Gray;
            label3.Location = new Point(-2, 671);
            label3.Name = "label3";
            label3.Size = new Size(1504, 47);
            label3.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbManuel);
            panel1.Controls.Add(rbAutomatic);
            panel1.Location = new Point(1188, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 120);
            panel1.TabIndex = 0;
            // 
            // rbManuel
            // 
            rbManuel.AutoSize = true;
            rbManuel.Location = new Point(3, 52);
            rbManuel.Name = "rbManuel";
            rbManuel.Size = new Size(132, 36);
            rbManuel.TabIndex = 1;
            rbManuel.TabStop = true;
            rbManuel.Text = "Manuell";
            rbManuel.UseVisualStyleBackColor = true;
            rbManuel.CheckedChanged += rbMode;
            // 
            // rbAutomatic
            // 
            rbAutomatic.AutoSize = true;
            rbAutomatic.Location = new Point(3, 10);
            rbAutomatic.Name = "rbAutomatic";
            rbAutomatic.Size = new Size(178, 36);
            rbAutomatic.TabIndex = 0;
            rbAutomatic.TabStop = true;
            rbAutomatic.Text = "Automatisch";
            rbAutomatic.UseVisualStyleBackColor = true;
            rbAutomatic.CheckedChanged += rbMode;
            // 
            // btRed
            // 
            btRed.Location = new Point(644, 29);
            btRed.Name = "btRed";
            btRed.Size = new Size(150, 46);
            btRed.TabIndex = 2;
            btRed.Text = "Rot";
            btRed.UseVisualStyleBackColor = true;
            btRed.Click += btRed_Click;
            // 
            // btGreen
            // 
            btGreen.Location = new Point(800, 29);
            btGreen.Name = "btGreen";
            btGreen.Size = new Size(150, 46);
            btGreen.TabIndex = 3;
            btGreen.Text = "Grün";
            btGreen.UseVisualStyleBackColor = true;
            btGreen.Click += btGreen_Click;
            // 
            // tDrive
            // 
            tDrive.Interval = 33;
            tDrive.Tick += tDrive_Tick_1;
            // 
            // paC1
            // 
            paC1.BackColor = Color.Cyan;
            paC1.Location = new Point(0, 595);
            paC1.Name = "paC1";
            paC1.Size = new Size(200, 73);
            paC1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1499, 875);
            Controls.Add(paC1);
            Controls.Add(btRed);
            Controls.Add(btGreen);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(paTrafficLight);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbGreenDuration);
            Controls.Add(tbRedDuration);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbRedDuration;
        private TextBox tbGreenDuration;
        private Label label1;
        private Label label2;
        private Panel paTrafficLight;
        private Label label3;
        private Panel panel1;
        private RadioButton rbManuel;
        private RadioButton rbAutomatic;
        private Button btRed;
        private Button btGreen;
        private System.Windows.Forms.Timer tDrive;
        private Panel paC1;
    }
}
