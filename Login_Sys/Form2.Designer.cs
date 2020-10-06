namespace Login_Sys
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Lblogin = new System.Windows.Forms.Label();
            this.Lbsenha = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.Entlogin = new System.Windows.Forms.TextBox();
            this.entSenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lblogin
            // 
            this.Lblogin.AutoSize = true;
            this.Lblogin.Location = new System.Drawing.Point(63, 200);
            this.Lblogin.Name = "Lblogin";
            this.Lblogin.Size = new System.Drawing.Size(33, 13);
            this.Lblogin.TabIndex = 0;
            this.Lblogin.Text = "Login";
            this.Lblogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbsenha
            // 
            this.Lbsenha.AutoSize = true;
            this.Lbsenha.Location = new System.Drawing.Point(63, 240);
            this.Lbsenha.Name = "Lbsenha";
            this.Lbsenha.Size = new System.Drawing.Size(38, 13);
            this.Lbsenha.TabIndex = 1;
            this.Lbsenha.Text = "Senha";
            this.Lbsenha.Click += new System.EventHandler(this.Lbsenha_Click);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(158, 295);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(147, 47);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Logar";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // Entlogin
            // 
            this.Entlogin.Location = new System.Drawing.Point(139, 193);
            this.Entlogin.Name = "Entlogin";
            this.Entlogin.Size = new System.Drawing.Size(180, 20);
            this.Entlogin.TabIndex = 3;
            // 
            // entSenha
            // 
            this.entSenha.Location = new System.Drawing.Point(139, 240);
            this.entSenha.Name = "entSenha";
            this.entSenha.Size = new System.Drawing.Size(180, 20);
            this.entSenha.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 189);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 395);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.entSenha);
            this.Controls.Add(this.Entlogin);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.Lbsenha);
            this.Controls.Add(this.Lblogin);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lblogin;
        private System.Windows.Forms.Label Lbsenha;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox Entlogin;
        private System.Windows.Forms.TextBox entSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}