using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cison.BoxView {
    internal sealed class BoxView : Form {
        private Button buttonClose;
        private Button buttonMessageText;
        private PictureBox pictureBoxAlert;

        private readonly string _messageErroDefault = "Aconteceu um error!";
        private readonly string _messageSuccessDefault = "Operação Concluída";
        private static readonly Bitmap _imageErro = Properties.Resources.error;
        private static readonly Bitmap _imageSuccess = Properties.Resources.success;

        public BoxView() {
            InitializeComponent();
            this.buttonClose.Click += Form_MouseClick;
            this.KeyPress += FormBoxAlert_KeyPress;
            this.MouseClick += Form_MouseClick;

        }

        public void Show(
                        IconBox iconBox, 
                        string message, 
                        ThemeBox themeBox = ThemeBox.Light, 
                        BoxViewBorderStyle borderStyle = BoxViewBorderStyle.SizeDialog ) {

            ApplyTheme(themeBox);
            ApplyStyleBorder(borderStyle);

            switch (iconBox) {
                case IconBox.Erro:
                    ShowError(message);
                    break;
                case IconBox.Success:
                    ShowSuccess(message);
                    break;
                default:
                    break;
            }
        }

        public void Show(
                        IconBox iconBox, 
                        ThemeBox themeBox = ThemeBox.Light, 
                        BoxViewBorderStyle borderStyle = BoxViewBorderStyle.SizeDialog) {
            
            ApplyTheme(themeBox);
            ApplyStyleBorder(borderStyle);

            switch (iconBox) {
                case IconBox.Erro:
                    ShowErrorDefault();
                    break;
                case IconBox.Success:
                    ShowSuccessDefault();
                    break;
                default:
                    break;
            }
        }

        private void ApplyTheme(ThemeBox themeBox) {
            switch (themeBox) {
                case ThemeBox.Light:
                    FormThemLight();
                    break;
                case ThemeBox.Dark:
                    FormThemDark();
                    break;
                default:
                    FormThemLight();
                    break;
            }
        }

        private void ApplyStyleBorder(BoxViewBorderStyle borderStyle) {
            switch (borderStyle) {
                case BoxViewBorderStyle.None:
                    this.FormBorderStyle = FormBorderStyle.None;
                    break;
                case BoxViewBorderStyle.Single:
                    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                    break;
                case BoxViewBorderStyle.SizeDialog:
                    this.FormBorderStyle = FormBorderStyle.FixedDialog;
                    break;
                default:
                    this.FormBorderStyle = FormBorderStyle.FixedDialog;
                    break;
            }
        }

        private void FormThemDark() {
            try {
                this.BackColor = Color.Black;
                this.buttonMessageText.ForeColor = Color.White;
                this.buttonClose.ForeColor = Color.White;
                this.buttonClose.FlatAppearance.MouseDownBackColor = Color.Red;
                this.buttonClose.FlatAppearance.MouseOverBackColor = Color.Black;
                this.buttonMessageText.FlatAppearance.MouseDownBackColor = Color.Black;
                this.buttonMessageText.FlatAppearance.MouseOverBackColor = Color.Black;
            }
            catch (Exception) {
                throw;
            }
        }
        private void FormThemLight() {
            try {
                this.BackColor = Color.White;
                this.buttonMessageText.ForeColor = Color.Black;
                this.buttonClose.ForeColor = Color.Black;
                this.buttonClose.FlatAppearance.MouseDownBackColor = Color.Red;
                this.buttonClose.FlatAppearance.MouseOverBackColor = Color.White;
                this.buttonMessageText.FlatAppearance.MouseDownBackColor = Color.White;
                this.buttonMessageText.FlatAppearance.MouseOverBackColor = Color.White;
            }
            catch (Exception) {
                throw;
            }
        }

        private void ShowErrorDefault() {
            this.buttonMessageText.Text = _messageErroDefault;
            this.pictureBoxAlert.Image = _imageErro;
            this.ShowDialog();
        }
        private void ShowSuccessDefault() {
            this.pictureBoxAlert.Image = _imageSuccess;
            this.buttonMessageText.Text = _messageSuccessDefault;
            this.ShowDialog();
        }

        private void ShowError(string message) {
            this.buttonMessageText.Text = message;
            this.pictureBoxAlert.Image = _imageErro;
            this.ShowDialog();
        }

        private void ShowSuccess(string message) {
            this.pictureBoxAlert.Image = _imageSuccess;
            this.buttonMessageText.Text = message;
            this.ShowDialog();
        }

        private void Form_MouseClick(object sender, EventArgs e) {
            this.Close();
        }
        private void ButtonClose_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void FormBoxAlert_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar > -1)
                this.Close();
        }

        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoxView));
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonMessageText = new System.Windows.Forms.Button();
            this.pictureBoxAlert = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(278, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(24, 23);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonMessageText
            // 
            this.buttonMessageText.AutoEllipsis = true;
            this.buttonMessageText.FlatAppearance.BorderSize = 0;
            this.buttonMessageText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonMessageText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonMessageText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMessageText.Location = new System.Drawing.Point(27, 99);
            this.buttonMessageText.Name = "buttonMessageText";
            this.buttonMessageText.Size = new System.Drawing.Size(260, 23);
            this.buttonMessageText.TabIndex = 6;
            this.buttonMessageText.UseVisualStyleBackColor = true;
            // 
            // pictureBoxAlert
            // 
            this.pictureBoxAlert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAlert.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAlert.Image")));
            this.pictureBoxAlert.Location = new System.Drawing.Point(107, 34);
            this.pictureBoxAlert.Name = "pictureBoxAlert";
            this.pictureBoxAlert.Size = new System.Drawing.Size(100, 59);
            this.pictureBoxAlert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAlert.TabIndex = 5;
            this.pictureBoxAlert.TabStop = false;
            // 
            // BoxView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 147);
            this.ControlBox = false;
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonMessageText);
            this.Controls.Add(this.pictureBoxAlert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BoxView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlert)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
