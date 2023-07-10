namespace RotaProject
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            pictureBox1 = new PictureBox();
            lblUsername = new Label();
            lblLogIn = new Label();
            txtbxUsername = new TextBox();
            txtbxPassword = new TextBox();
            lblPassword = new Label();
            btnLogIn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Rota_Logo;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // lblUsername
            // 
            resources.ApplyResources(lblUsername, "lblUsername");
            lblUsername.Name = "lblUsername";
            // 
            // lblLogIn
            // 
            resources.ApplyResources(lblLogIn, "lblLogIn");
            lblLogIn.Name = "lblLogIn";
            // 
            // txtbxUsername
            // 
            resources.ApplyResources(txtbxUsername, "txtbxUsername");
            txtbxUsername.Name = "txtbxUsername";
            // 
            // txtbxPassword
            // 
            resources.ApplyResources(txtbxPassword, "txtbxPassword");
            txtbxPassword.Name = "txtbxPassword";
            // 
            // lblPassword
            // 
            resources.ApplyResources(lblPassword, "lblPassword");
            lblPassword.Name = "lblPassword";
            // 
            // btnLogIn
            // 
            resources.ApplyResources(btnLogIn, "btnLogIn");
            btnLogIn.Name = "btnLogIn";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // LogInForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(btnLogIn);
            Controls.Add(txtbxPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtbxUsername);
            Controls.Add(lblLogIn);
            Controls.Add(lblUsername);
            Controls.Add(pictureBox1);
            Name = "LogInForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblUsername;
        private Label lblLogIn;
        private TextBox txtbxUsername;
        private TextBox txtbxPassword;
        private Label lblPassword;
        private Button btnLogIn;
    }
}