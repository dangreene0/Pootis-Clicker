namespace PootisApp
{
    partial class pootisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pootisForm));
            this.pootisButton = new System.Windows.Forms.Button();
            this.pootisPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pootisPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pootisButton
            // 
            this.pootisButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pootisButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pootisButton.Font = new System.Drawing.Font("TF2 Build", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pootisButton.Location = new System.Drawing.Point(195, 28);
            this.pootisButton.Name = "pootisButton";
            this.pootisButton.Size = new System.Drawing.Size(130, 64);
            this.pootisButton.TabIndex = 0;
            this.pootisButton.Text = "Click 2 Poot";
            this.pootisButton.UseVisualStyleBackColor = false;
            this.pootisButton.Click += new System.EventHandler(this.pootisButton_click);
            // 
            // pootisPicture
            // 
            this.pootisPicture.Image = global::PootisApp.Properties.Resources.heavy;
            this.pootisPicture.InitialImage = global::PootisApp.Properties.Resources.heavy;
            this.pootisPicture.Location = new System.Drawing.Point(-52, -6);
            this.pootisPicture.Name = "pootisPicture";
            this.pootisPicture.Size = new System.Drawing.Size(440, 455);
            this.pootisPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pootisPicture.TabIndex = 1;
            this.pootisPicture.TabStop = false;
            // 
            // pootisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(382, 430);
            this.Controls.Add(this.pootisButton);
            this.Controls.Add(this.pootisPicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pootisForm";
            this.Text = "Pootis Clicker";
            ((System.ComponentModel.ISupportInitialize)(this.pootisPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button pootisButton;
        private PictureBox pootisPicture;
    }
}