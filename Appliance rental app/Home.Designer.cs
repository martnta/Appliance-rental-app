
namespace Appliance_rental_app
{
    partial class Home
    {
        private const string V = "Home";

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
            this.btnCart = new MaterialSkin.Controls.MaterialButton();
            this.btnAddToCart = new MaterialSkin.Controls.MaterialButton();
            this.txtFee = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtColo = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtMod = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtEnerg = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtdime = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtBrand = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvAppliances = new System.Windows.Forms.DataGridView();
            this.btnSort = new MaterialSkin.Controls.MaterialButton();
            this.btnSearch = new MaterialSkin.Controls.MaterialButton();
            this.txtSearch = new MaterialSkin.Controls.MaterialTextBox2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppliances)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCart
            // 
            this.btnCart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCart.Depth = 0;
            this.btnCart.HighEmphasis = true;
            this.btnCart.Icon = null;
            this.btnCart.Location = new System.Drawing.Point(1193, 120);
            this.btnCart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCart.Name = "btnCart";
            this.btnCart.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCart.Size = new System.Drawing.Size(97, 36);
            this.btnCart.TabIndex = 32;
            this.btnCart.Text = "View Cart";
            this.btnCart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCart.UseAccentColor = false;
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToCart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddToCart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddToCart.Depth = 0;
            this.btnAddToCart.HighEmphasis = true;
            this.btnAddToCart.Icon = null;
            this.btnAddToCart.Location = new System.Drawing.Point(975, 502);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddToCart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddToCart.Size = new System.Drawing.Size(114, 36);
            this.btnAddToCart.TabIndex = 31;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddToCart.UseAccentColor = false;
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // txtFee
            // 
            this.txtFee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFee.AnimateReadOnly = false;
            this.txtFee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFee.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFee.Depth = 0;
            this.txtFee.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFee.HideSelection = true;
            this.txtFee.Hint = "Fee";
            this.txtFee.LeadingIcon = null;
            this.txtFee.Location = new System.Drawing.Point(1111, 397);
            this.txtFee.MaxLength = 32767;
            this.txtFee.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFee.Name = "txtFee";
            this.txtFee.PasswordChar = '\0';
            this.txtFee.PrefixSuffixText = null;
            this.txtFee.ReadOnly = false;
            this.txtFee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFee.SelectedText = "";
            this.txtFee.SelectionLength = 0;
            this.txtFee.SelectionStart = 0;
            this.txtFee.ShortcutsEnabled = true;
            this.txtFee.Size = new System.Drawing.Size(199, 48);
            this.txtFee.TabIndex = 30;
            this.txtFee.TabStop = false;
            this.txtFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFee.TrailingIcon = null;
            this.txtFee.UseSystemPasswordChar = false;
            // 
            // txtColo
            // 
            this.txtColo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtColo.AnimateReadOnly = false;
            this.txtColo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtColo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtColo.Depth = 0;
            this.txtColo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtColo.HideSelection = true;
            this.txtColo.Hint = "Color";
            this.txtColo.LeadingIcon = null;
            this.txtColo.Location = new System.Drawing.Point(1111, 296);
            this.txtColo.MaxLength = 32767;
            this.txtColo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtColo.Name = "txtColo";
            this.txtColo.PasswordChar = '\0';
            this.txtColo.PrefixSuffixText = null;
            this.txtColo.ReadOnly = false;
            this.txtColo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtColo.SelectedText = "";
            this.txtColo.SelectionLength = 0;
            this.txtColo.SelectionStart = 0;
            this.txtColo.ShortcutsEnabled = true;
            this.txtColo.Size = new System.Drawing.Size(199, 48);
            this.txtColo.TabIndex = 29;
            this.txtColo.TabStop = false;
            this.txtColo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtColo.TrailingIcon = null;
            this.txtColo.UseSystemPasswordChar = false;
            // 
            // txtMod
            // 
            this.txtMod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMod.AnimateReadOnly = false;
            this.txtMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMod.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMod.Depth = 0;
            this.txtMod.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMod.HideSelection = true;
            this.txtMod.Hint = "Model";
            this.txtMod.LeadingIcon = null;
            this.txtMod.Location = new System.Drawing.Point(1111, 189);
            this.txtMod.MaxLength = 32767;
            this.txtMod.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMod.Name = "txtMod";
            this.txtMod.PasswordChar = '\0';
            this.txtMod.PrefixSuffixText = null;
            this.txtMod.ReadOnly = false;
            this.txtMod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMod.SelectedText = "";
            this.txtMod.SelectionLength = 0;
            this.txtMod.SelectionStart = 0;
            this.txtMod.ShortcutsEnabled = true;
            this.txtMod.Size = new System.Drawing.Size(199, 48);
            this.txtMod.TabIndex = 28;
            this.txtMod.TabStop = false;
            this.txtMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMod.TrailingIcon = null;
            this.txtMod.UseSystemPasswordChar = false;
            // 
            // txtEnerg
            // 
            this.txtEnerg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnerg.AnimateReadOnly = false;
            this.txtEnerg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEnerg.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEnerg.Depth = 0;
            this.txtEnerg.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEnerg.HideSelection = true;
            this.txtEnerg.Hint = "Energy Consuption";
            this.txtEnerg.LeadingIcon = null;
            this.txtEnerg.Location = new System.Drawing.Point(898, 397);
            this.txtEnerg.MaxLength = 32767;
            this.txtEnerg.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEnerg.Name = "txtEnerg";
            this.txtEnerg.PasswordChar = '\0';
            this.txtEnerg.PrefixSuffixText = null;
            this.txtEnerg.ReadOnly = false;
            this.txtEnerg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEnerg.SelectedText = "";
            this.txtEnerg.SelectionLength = 0;
            this.txtEnerg.SelectionStart = 0;
            this.txtEnerg.ShortcutsEnabled = true;
            this.txtEnerg.Size = new System.Drawing.Size(199, 48);
            this.txtEnerg.TabIndex = 27;
            this.txtEnerg.TabStop = false;
            this.txtEnerg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEnerg.TrailingIcon = null;
            this.txtEnerg.UseSystemPasswordChar = false;
            // 
            // txtdime
            // 
            this.txtdime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdime.AnimateReadOnly = false;
            this.txtdime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtdime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtdime.Depth = 0;
            this.txtdime.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtdime.HideSelection = true;
            this.txtdime.Hint = "Dimensions";
            this.txtdime.LeadingIcon = null;
            this.txtdime.Location = new System.Drawing.Point(898, 296);
            this.txtdime.MaxLength = 32767;
            this.txtdime.MouseState = MaterialSkin.MouseState.OUT;
            this.txtdime.Name = "txtdime";
            this.txtdime.PasswordChar = '\0';
            this.txtdime.PrefixSuffixText = null;
            this.txtdime.ReadOnly = false;
            this.txtdime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtdime.SelectedText = "";
            this.txtdime.SelectionLength = 0;
            this.txtdime.SelectionStart = 0;
            this.txtdime.ShortcutsEnabled = true;
            this.txtdime.Size = new System.Drawing.Size(199, 48);
            this.txtdime.TabIndex = 26;
            this.txtdime.TabStop = false;
            this.txtdime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtdime.TrailingIcon = null;
            this.txtdime.UseSystemPasswordChar = false;
            // 
            // txtBrand
            // 
            this.txtBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBrand.AnimateReadOnly = false;
            this.txtBrand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBrand.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBrand.Depth = 0;
            this.txtBrand.ErrorMessage = "Enter something";
            this.txtBrand.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBrand.HideSelection = true;
            this.txtBrand.Hint = "Brand";
            this.txtBrand.LeadingIcon = null;
            this.txtBrand.Location = new System.Drawing.Point(898, 189);
            this.txtBrand.MaxLength = 32767;
            this.txtBrand.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.PasswordChar = '\0';
            this.txtBrand.PrefixSuffixText = null;
            this.txtBrand.ReadOnly = false;
            this.txtBrand.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBrand.SelectedText = "";
            this.txtBrand.SelectionLength = 0;
            this.txtBrand.SelectionStart = 0;
            this.txtBrand.ShortcutsEnabled = true;
            this.txtBrand.Size = new System.Drawing.Size(199, 48);
            this.txtBrand.TabIndex = 25;
            this.txtBrand.TabStop = false;
            this.txtBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBrand.TrailingIcon = null;
            this.txtBrand.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(36, 89);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(109, 19);
            this.materialLabel1.TabIndex = 24;
            this.materialLabel1.Text = "Available items";
            // 
            // dgvAppliances
            // 
            this.dgvAppliances.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvAppliances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppliances.Location = new System.Drawing.Point(1, 190);
            this.dgvAppliances.Name = "dgvAppliances";
            this.dgvAppliances.RowHeadersWidth = 62;
            this.dgvAppliances.RowTemplate.Height = 28;
            this.dgvAppliances.Size = new System.Drawing.Size(886, 402);
            this.dgvAppliances.TabIndex = 33;
            this.dgvAppliances.SelectionChanged += new System.EventHandler(this.dgvAppliances_SelectionChanged);
            // 
            // btnSort
            // 
            this.btnSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSort.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSort.Depth = 0;
            this.btnSort.HighEmphasis = true;
            this.btnSort.Icon = null;
            this.btnSort.Location = new System.Drawing.Point(39, 120);
            this.btnSort.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSort.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSort.Name = "btnSort";
            this.btnSort.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSort.Size = new System.Drawing.Size(64, 36);
            this.btnSort.TabIndex = 34;
            this.btnSort.Text = "Sort ";
            this.btnSort.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSort.UseAccentColor = false;
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearch.Depth = 0;
            this.btnSearch.HighEmphasis = true;
            this.btnSearch.Icon = null;
            this.btnSearch.Location = new System.Drawing.Point(458, 132);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearch.Size = new System.Drawing.Size(78, 36);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "search";
            this.btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearch.UseAccentColor = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.AnimateReadOnly = false;
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Depth = 0;
            this.txtSearch.ErrorMessage = "Enter something";
            this.txtSearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.HideSelection = true;
            this.txtSearch.Hint = "search by brand.....";
            this.txtSearch.LeadingIcon = null;
            this.txtSearch.Location = new System.Drawing.Point(206, 120);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PrefixSuffixText = null;
            this.txtSearch.ReadOnly = false;
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(245, 48);
            this.txtSearch.TabIndex = 36;
            this.txtSearch.TabStop = false;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TrailingIcon = null;
            this.txtSearch.UseSystemPasswordChar = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 668);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.dgvAppliances);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.txtColo);
            this.Controls.Add(this.txtMod);
            this.Controls.Add(this.txtEnerg);
            this.Controls.Add(this.txtdime);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppliances)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnCart;
        private MaterialSkin.Controls.MaterialButton btnAddToCart;
        private MaterialSkin.Controls.MaterialTextBox2 txtFee;
        private MaterialSkin.Controls.MaterialTextBox2 txtColo;
        private MaterialSkin.Controls.MaterialTextBox2 txtMod;
        private MaterialSkin.Controls.MaterialTextBox2 txtEnerg;
        private MaterialSkin.Controls.MaterialTextBox2 txtdime;
        private MaterialSkin.Controls.MaterialTextBox2 txtBrand;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dgvAppliances;
        private MaterialSkin.Controls.MaterialButton btnSort;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private MaterialSkin.Controls.MaterialTextBox2 txtSearch;
    }
}