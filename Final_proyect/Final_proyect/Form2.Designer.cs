namespace Final_proyect
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnUrgencias = new System.Windows.Forms.Button();
            this.btnQuirofano = new System.Windows.Forms.Button();
            this.btnRadiologia = new System.Windows.Forms.Button();
            this.btnTococirugia = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(169, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Areas";
            // 
            // btnUrgencias
            // 
            this.btnUrgencias.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrgencias.Location = new System.Drawing.Point(160, 47);
            this.btnUrgencias.Name = "btnUrgencias";
            this.btnUrgencias.Size = new System.Drawing.Size(80, 23);
            this.btnUrgencias.TabIndex = 1;
            this.btnUrgencias.Text = "Urgencias";
            this.btnUrgencias.UseVisualStyleBackColor = true;
            this.btnUrgencias.Click += new System.EventHandler(this.btnUrgencias_Click);
            // 
            // btnQuirofano
            // 
            this.btnQuirofano.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuirofano.Location = new System.Drawing.Point(160, 76);
            this.btnQuirofano.Name = "btnQuirofano";
            this.btnQuirofano.Size = new System.Drawing.Size(80, 23);
            this.btnQuirofano.TabIndex = 2;
            this.btnQuirofano.Text = "Quirofano";
            this.btnQuirofano.UseVisualStyleBackColor = true;
            this.btnQuirofano.Click += new System.EventHandler(this.btnQuirofano_Click);
            // 
            // btnRadiologia
            // 
            this.btnRadiologia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadiologia.Location = new System.Drawing.Point(160, 105);
            this.btnRadiologia.Name = "btnRadiologia";
            this.btnRadiologia.Size = new System.Drawing.Size(80, 23);
            this.btnRadiologia.TabIndex = 3;
            this.btnRadiologia.Text = "Radiologia";
            this.btnRadiologia.UseVisualStyleBackColor = true;
            this.btnRadiologia.Click += new System.EventHandler(this.btnRadiologia_Click);
            // 
            // btnTococirugia
            // 
            this.btnTococirugia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTococirugia.Location = new System.Drawing.Point(160, 134);
            this.btnTococirugia.Name = "btnTococirugia";
            this.btnTococirugia.Size = new System.Drawing.Size(80, 23);
            this.btnTococirugia.TabIndex = 4;
            this.btnTococirugia.Text = "Tococirugia";
            this.btnTococirugia.UseVisualStyleBackColor = true;
            this.btnTococirugia.Click += new System.EventHandler(this.btnTococirugia_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Turquoise;
            this.btnLogOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(119, 169);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(290, 204);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnTococirugia);
            this.Controls.Add(this.btnRadiologia);
            this.Controls.Add(this.btnQuirofano);
            this.Controls.Add(this.btnUrgencias);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUrgencias;
        private System.Windows.Forms.Button btnQuirofano;
        private System.Windows.Forms.Button btnRadiologia;
        private System.Windows.Forms.Button btnTococirugia;
        private System.Windows.Forms.Button btnLogOut;
    }
}