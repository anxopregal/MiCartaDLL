namespace aplicacion
{
    partial class Form1
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
            this.ucImaxe1 = new CartaLib.ucImaxe();
            this.SuspendLayout();
            // 
            // ucImaxe1
            // 
            this.ucImaxe1.Location = new System.Drawing.Point(0, 0);
            this.ucImaxe1.Name = "ucImaxe1";
            this.ucImaxe1.Size = new System.Drawing.Size(300, 300);
            this.ucImaxe1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 299);
            this.Controls.Add(this.ucImaxe1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CartaLib.ucImaxe ucImaxe1;
    }
}

