namespace WalshApp {
    partial class Visio {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visio));
            this.axViewer1 = new AxVisioViewer.AxViewer();
            ((System.ComponentModel.ISupportInitialize)(this.axViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axViewer1
            // 
            this.axViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axViewer1.Enabled = true;
            this.axViewer1.Location = new System.Drawing.Point(0, 0);
            this.axViewer1.Name = "axViewer1";
            this.axViewer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axViewer1.OcxState")));
            this.axViewer1.Size = new System.Drawing.Size(454, 416);
            this.axViewer1.TabIndex = 0;
            // 
            // Visio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.axViewer1);
            this.Name = "Visio";
            this.Size = new System.Drawing.Size(454, 416);
            ((System.ComponentModel.ISupportInitialize)(this.axViewer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxVisioViewer.AxViewer axViewer1;
    }
}
