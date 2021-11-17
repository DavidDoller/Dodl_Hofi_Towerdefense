
namespace Towerdefense
{
    partial class menu
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
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_option = new System.Windows.Forms.Button();
            this.btn_description = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(89, 50);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(251, 47);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_option
            // 
            this.btn_option.Location = new System.Drawing.Point(89, 114);
            this.btn_option.Name = "btn_option";
            this.btn_option.Size = new System.Drawing.Size(251, 47);
            this.btn_option.TabIndex = 1;
            this.btn_option.Text = "Option";
            this.btn_option.UseVisualStyleBackColor = true;
            // 
            // btn_description
            // 
            this.btn_description.Location = new System.Drawing.Point(89, 177);
            this.btn_description.Name = "btn_description";
            this.btn_description.Size = new System.Drawing.Size(251, 47);
            this.btn_description.TabIndex = 2;
            this.btn_description.Text = "Beschreibung";
            this.btn_description.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(89, 243);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(251, 47);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 361);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_description);
            this.Controls.Add(this.btn_option);
            this.Controls.Add(this.btn_start);
            this.Name = "menu";
            this.Text = "menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_option;
        private System.Windows.Forms.Button btn_description;
        private System.Windows.Forms.Button btn_exit;
    }
}