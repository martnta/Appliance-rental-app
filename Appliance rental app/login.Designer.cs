
namespace Appliance_rental_app
{
    partial class login
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtUser = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtPass = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblError = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.SlateBlue;
            this.materialLabel1.Location = new System.Drawing.Point(229, 166);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(155, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Enter Your credentials";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(274, 414);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(64, 36);
            this.materialButton1.TabIndex = 3;
            this.materialButton1.Text = "Login";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(273, 482);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 20);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Register";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtUser
            // 
            this.txtUser.AnimateReadOnly = false;
            this.txtUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUser.Depth = 0;
            this.txtUser.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUser.HelperText = "Username";
            this.txtUser.HideSelection = true;
            this.txtUser.Hint = "Username";
            this.txtUser.LeadingIcon = null;
            this.txtUser.Location = new System.Drawing.Point(180, 235);
            this.txtUser.MaxLength = 32767;
            this.txtUser.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PrefixSuffixText = null;
            this.txtUser.ReadOnly = false;
            this.txtUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(275, 48);
            this.txtUser.TabIndex = 7;
            this.txtUser.TabStop = false;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUser.TrailingIcon = null;
            this.txtUser.UseSystemPasswordChar = false;
            // 
            // txtPass
            // 
            this.txtPass.AnimateReadOnly = false;
            this.txtPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPass.Depth = 0;
            this.txtPass.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPass.HideSelection = true;
            this.txtPass.Hint = "Password";
            this.txtPass.LeadingIcon = null;
            this.txtPass.Location = new System.Drawing.Point(180, 326);
            this.txtPass.MaxLength = 32767;
            this.txtPass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PrefixSuffixText = null;
            this.txtPass.ReadOnly = false;
            this.txtPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(275, 48);
            this.txtPass.TabIndex = 8;
            this.txtPass.TabStop = false;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPass.TrailingIcon = null;
            this.txtPass.UseSystemPasswordChar = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Depth = 0;
            this.lblError.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(197, 383);
            this.lblError.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(208, 19);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "Please wait for some time......";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 570);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialLabel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Name = "login";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtUser;
        private MaterialSkin.Controls.MaterialTextBox2 txtPass;
        private MaterialSkin.Controls.MaterialLabel lblError;
    }
}