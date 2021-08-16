
namespace WindowsFormsSample {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.buttonDefaultLightErro = new System.Windows.Forms.Button();
            this.buttonCustomDark = new System.Windows.Forms.Button();
            this.buttonDefaultLightSuccess = new System.Windows.Forms.Button();
            this.buttonCustomLight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDefaultLightErro
            // 
            this.buttonDefaultLightErro.Location = new System.Drawing.Point(38, 36);
            this.buttonDefaultLightErro.Name = "buttonDefaultLightErro";
            this.buttonDefaultLightErro.Size = new System.Drawing.Size(125, 23);
            this.buttonDefaultLightErro.TabIndex = 0;
            this.buttonDefaultLightErro.Text = "Default Light (Erro)";
            this.buttonDefaultLightErro.UseVisualStyleBackColor = true;
            // 
            // buttonCustomDark
            // 
            this.buttonCustomDark.Location = new System.Drawing.Point(196, 36);
            this.buttonCustomDark.Name = "buttonCustomDark";
            this.buttonCustomDark.Size = new System.Drawing.Size(165, 23);
            this.buttonCustomDark.TabIndex = 1;
            this.buttonCustomDark.Text = "Custom message Dark";
            this.buttonCustomDark.UseVisualStyleBackColor = true;
            // 
            // buttonDefaultLightSuccess
            // 
            this.buttonDefaultLightSuccess.Location = new System.Drawing.Point(38, 65);
            this.buttonDefaultLightSuccess.Name = "buttonDefaultLightSuccess";
            this.buttonDefaultLightSuccess.Size = new System.Drawing.Size(125, 23);
            this.buttonDefaultLightSuccess.TabIndex = 2;
            this.buttonDefaultLightSuccess.Text = "Default Light (Success)";
            this.buttonDefaultLightSuccess.UseVisualStyleBackColor = true;
            // 
            // buttonCustomLight
            // 
            this.buttonCustomLight.Location = new System.Drawing.Point(196, 65);
            this.buttonCustomLight.Name = "buttonCustomLight";
            this.buttonCustomLight.Size = new System.Drawing.Size(165, 23);
            this.buttonCustomLight.TabIndex = 3;
            this.buttonCustomLight.Text = "Custom message Light";
            this.buttonCustomLight.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 128);
            this.Controls.Add(this.buttonCustomLight);
            this.Controls.Add(this.buttonDefaultLightSuccess);
            this.Controls.Add(this.buttonCustomDark);
            this.Controls.Add(this.buttonDefaultLightErro);
            this.Name = "Form1";
            this.Text = "Examples";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDefaultLightErro;
        private System.Windows.Forms.Button buttonCustomDark;
        private System.Windows.Forms.Button buttonDefaultLightSuccess;
        private System.Windows.Forms.Button buttonCustomLight;
    }
}

