namespace Registratsiya
{
    partial class YangiUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            malumotQoshish_button = new Button();
            textBox_yangIsm = new TextBox();
            textBox_yangiFamiliya = new TextBox();
            textBox_yangiUserName = new TextBox();
            textBox_yangiEmail = new TextBox();
            textBox_yangiParol = new TextBox();
            label_ism = new Label();
            label_familiya = new Label();
            label_UserName = new Label();
            label_email = new Label();
            label_parol = new Label();
            SuspendLayout();
            // 
            // malumotQoshish_button
            // 
            malumotQoshish_button.Location = new Point(122, 360);
            malumotQoshish_button.Name = "malumotQoshish_button";
            malumotQoshish_button.Size = new Size(75, 23);
            malumotQoshish_button.TabIndex = 0;
            malumotQoshish_button.Text = "Bo'ldi";
            malumotQoshish_button.UseVisualStyleBackColor = true;
            malumotQoshish_button.Click += malumotQoshish_button_Click;
            // 
            // textBox_yangIsm
            // 
            textBox_yangIsm.Location = new Point(71, 49);
            textBox_yangIsm.Name = "textBox_yangIsm";
            textBox_yangIsm.Size = new Size(202, 23);
            textBox_yangIsm.TabIndex = 1;
            // 
            // textBox_yangiFamiliya
            // 
            textBox_yangiFamiliya.Location = new Point(71, 110);
            textBox_yangiFamiliya.Name = "textBox_yangiFamiliya";
            textBox_yangiFamiliya.Size = new Size(202, 23);
            textBox_yangiFamiliya.TabIndex = 2;
            // 
            // textBox_yangiUserName
            // 
            textBox_yangiUserName.Location = new Point(71, 169);
            textBox_yangiUserName.Name = "textBox_yangiUserName";
            textBox_yangiUserName.Size = new Size(202, 23);
            textBox_yangiUserName.TabIndex = 3;
            // 
            // textBox_yangiEmail
            // 
            textBox_yangiEmail.Location = new Point(71, 230);
            textBox_yangiEmail.Name = "textBox_yangiEmail";
            textBox_yangiEmail.Size = new Size(202, 23);
            textBox_yangiEmail.TabIndex = 4;
            // 
            // textBox_yangiParol
            // 
            textBox_yangiParol.Location = new Point(71, 284);
            textBox_yangiParol.Name = "textBox_yangiParol";
            textBox_yangiParol.Size = new Size(202, 23);
            textBox_yangiParol.TabIndex = 5;
            // 
            // label_ism
            // 
            label_ism.AutoSize = true;
            label_ism.Location = new Point(71, 22);
            label_ism.Name = "label_ism";
            label_ism.Size = new Size(26, 15);
            label_ism.TabIndex = 6;
            label_ism.Text = "Ism";
            // 
            // label_familiya
            // 
            label_familiya.AutoSize = true;
            label_familiya.Location = new Point(72, 89);
            label_familiya.Name = "label_familiya";
            label_familiya.Size = new Size(51, 15);
            label_familiya.TabIndex = 7;
            label_familiya.Text = "Familiya";
            // 
            // label_UserName
            // 
            label_UserName.AutoSize = true;
            label_UserName.Location = new Point(71, 151);
            label_UserName.Name = "label_UserName";
            label_UserName.Size = new Size(117, 15);
            label_UserName.TabIndex = 8;
            label_UserName.Text = "Foydalanuvchi Nomi";
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Location = new Point(71, 212);
            label_email.Name = "label_email";
            label_email.Size = new Size(36, 15);
            label_email.TabIndex = 9;
            label_email.Text = "Email";
            // 
            // label_parol
            // 
            label_parol.AutoSize = true;
            label_parol.Location = new Point(75, 263);
            label_parol.Name = "label_parol";
            label_parol.Size = new Size(34, 15);
            label_parol.TabIndex = 10;
            label_parol.Text = "Parol";
            // 
            // YangiUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 395);
            Controls.Add(label_parol);
            Controls.Add(label_email);
            Controls.Add(label_UserName);
            Controls.Add(label_familiya);
            Controls.Add(label_ism);
            Controls.Add(textBox_yangiParol);
            Controls.Add(textBox_yangiEmail);
            Controls.Add(textBox_yangiUserName);
            Controls.Add(textBox_yangiFamiliya);
            Controls.Add(textBox_yangIsm);
            Controls.Add(malumotQoshish_button);
            Name = "YangiUser";
            Text = "YangiUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button malumotQoshish_button;
        private TextBox textBox_yangIsm;
        private TextBox textBox_yangiFamiliya;
        private TextBox textBox_yangiUserName;
        private TextBox textBox_yangiEmail;
        private TextBox textBox_yangiParol;
        private Label label_ism;
        private Label label_familiya;
        private Label label_UserName;
        private Label label_email;
        private Label label_parol;
    }
}