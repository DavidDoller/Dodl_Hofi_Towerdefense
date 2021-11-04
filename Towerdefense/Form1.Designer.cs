
namespace Towerdefense
{
    partial class Login
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_login = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.brn_exit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_login = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(57, 229);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(227, 31);
            this.txt_login.TabIndex = 0;
            this.txt_login.Text = "Login";
            this.txt_login.UseVisualStyleBackColor = true;
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(57, 266);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(227, 31);
            this.btn_register.TabIndex = 1;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            // 
            // brn_exit
            // 
            this.brn_exit.Location = new System.Drawing.Point(139, 313);
            this.brn_exit.Name = "brn_exit";
            this.brn_exit.Size = new System.Drawing.Size(66, 31);
            this.brn_exit.TabIndex = 2;
            this.brn_exit.Text = "Exit";
            this.brn_exit.UseVisualStyleBackColor = true;
            this.brn_exit.Click += new System.EventHandler(this.brn_exit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // pb_login
            // 
            this.pb_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_login.Image = global::Towerdefense.Properties.Resources.login;
            this.pb_login.Location = new System.Drawing.Point(110, 12);
            this.pb_login.Name = "pb_login";
            this.pb_login.Size = new System.Drawing.Size(127, 123);
            this.pb_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_login.TabIndex = 7;
            this.pb_login.TabStop = false;
            this.pb_login.UseWaitCursor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 355);
            this.Controls.Add(this.pb_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.brn_exit);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.txt_login);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txt_login;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button brn_exit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_login;
    }
}

