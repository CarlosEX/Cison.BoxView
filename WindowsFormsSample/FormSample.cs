//desenvolvido por Carlos Antonio
//site: https://carlosantoniocison.editorx.io/portifolio

using System;
using Cison.BoxView;
using System.Windows.Forms;

namespace WindowsFormsSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            LoadEvents();
        }

        private void LoadEvents() {
            this.buttonDefaultLightErro.Click += DefaultLightErro_Click;
            this.buttonDefaultLightSuccess.Click += DefaultLightSuccess_Click;
            this.buttonCustomDark.Click += CustomMessageDark_Click;
            this.buttonCustomLight.Click += CustomMessageLight_Click;
        }
        private void DefaultLightErro_Click(object sender, EventArgs e) {
            BoxViewFactory.Show(IconBox.Erro);
        }
        private void DefaultLightSuccess_Click(object sender, EventArgs e) {
            BoxViewFactory.Show(IconBox.Success);
        }
        private void CustomMessageDark_Click(object sender, EventArgs e) {
            BoxViewFactory.Show(IconBox.Success, "Message ths success...", ThemeBox.Dark, BoxViewBorderStyle.None);
        }
        private void CustomMessageLight_Click(object sender, EventArgs e) {
            BoxViewFactory.Show(IconBox.Erro, "Message ths error...", ThemeBox.Light, BoxViewBorderStyle.Single);
        }
    }
}
