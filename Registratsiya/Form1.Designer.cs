namespace Registratsiya
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
            button1 = new Button();
            textBox_eskiLogin = new TextBox();
            textBox_eskiniParoli = new TextBox();
            eskiniLogini = new Label();
            eskiniParoli = new Label();
            button_kirish = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(123, 243);
            button1.Name = "button1";
            button1.Size = new Size(140, 23);
            button1.TabIndex = 0;
            button1.Text = "Yangi bo'lsangiz bosing";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox_eskiLogin
            // 
            textBox_eskiLogin.Location = new Point(35, 65);
            textBox_eskiLogin.Name = "textBox_eskiLogin";
            textBox_eskiLogin.Size = new Size(228, 23);
            textBox_eskiLogin.TabIndex = 1;
            // 
            // textBox_eskiniParoli
            // 
            textBox_eskiniParoli.Location = new Point(35, 144);
            textBox_eskiniParoli.Name = "textBox_eskiniParoli";
            textBox_eskiniParoli.Size = new Size(228, 23);
            textBox_eskiniParoli.TabIndex = 2;
            // 
            // eskiniLogini
            // 
            eskiniLogini.AutoSize = true;
            eskiniLogini.Location = new Point(120, 31);
            eskiniLogini.Name = "eskiniLogini";
            eskiniLogini.Size = new Size(36, 15);
            eskiniLogini.TabIndex = 3;
            eskiniLogini.Text = "Email";
            // 
            // eskiniParoli
            // 
            eskiniParoli.AutoSize = true;
            eskiniParoli.Location = new Point(122, 112);
            eskiniParoli.Name = "eskiniParoli";
            eskiniParoli.Size = new Size(34, 15);
            eskiniParoli.TabIndex = 4;
            eskiniParoli.Text = "parol";
            // 
            // button_kirish
            // 
            button_kirish.Location = new Point(35, 243);
            button_kirish.Name = "button_kirish";
            button_kirish.Size = new Size(75, 23);
            button_kirish.TabIndex = 5;
            button_kirish.Text = "tekshir";
            button_kirish.UseVisualStyleBackColor = true;
            button_kirish.Click += button_kirish_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 289);
            Controls.Add(button_kirish);
            Controls.Add(eskiniParoli);
            Controls.Add(eskiniLogini);
            Controls.Add(textBox_eskiniParoli);
            Controls.Add(textBox_eskiLogin);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Kirish";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox_eskiLogin;
        private TextBox textBox_eskiniParoli;
        private Label eskiniLogini;
        private Label eskiniParoli;
        private Button button_kirish;
    }
}