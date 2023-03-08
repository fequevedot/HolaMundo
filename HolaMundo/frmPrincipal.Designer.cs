namespace HolaMundo
{
    partial class frmPrincipal
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
            btnSalid = new Button();
            SuspendLayout();
            // 
            // btnSalid
            // 
            btnSalid.Location = new Point(660, 377);
            btnSalid.Name = "btnSalid";
            btnSalid.Size = new Size(94, 29);
            btnSalid.TabIndex = 0;
            btnSalid.Text = "Salir";
            btnSalid.UseVisualStyleBackColor = true;
            btnSalid.Click += btnSalid_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalid);
            Name = "frmPrincipal";
            Text = "Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalid;
    }
}