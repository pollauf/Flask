using Flask.TELAS.Analises;
using Flask.TELAS.METODOS;
using Flask.TELAS.Reagentes;
using FlaskMODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flask.TELAS
{
    public partial class FrmPrincipal : Form
    {
        public string StrJanelaAberta { get; set; } = string.Empty;

        private AbasMenu menuAtual;

        public AbasMenu MenuAtual
        {
            get { return menuAtual; }
            set
            {
                menuAtual = value;

                btnReagentes.BackColor =
                    btnAnalises.BackColor =
                    btnRelatorios.BackColor =
                    btnInfo.BackColor = Color.FromArgb(45, 54, 76);

                switch (MenuAtual)
                {
                    case AbasMenu.Oculto:                        
                        MenuLateral.Hide();                        
                        break;
                    case AbasMenu.Reagentes:
                        SetMenu("REAGENTES", new string[]
                        {
                            "CADASTRO",
                        });
                        btnReagentes.BackColor = Color.FromArgb(90, 59, 137);
                        break;
                    case AbasMenu.Analises:
                        SetMenu("ANÁLISES", new string[]
                        {
                            "{title}TITULAÇÃO ÁCIDO-BASE",
                            "{sep}",
                            "ACIDIMETRIA",
                            "ALCALIMETRIA",
                            "RETROTITULAÇÃO",
                            "POTENCIOMETRIA",
                            "CÁLCULO KI"
                        });
                        btnAnalises.BackColor = Color.FromArgb(90, 59, 137);
                        break;
                    case AbasMenu.Relatorios:
                        SetMenu("REGISTROS", new string[]
                        {
                            "CADASTRO",
                        });
                        btnRelatorios.BackColor = Color.FromArgb(90, 59, 137);
                        break;
                    case AbasMenu.Sobre:
                        SetMenu("SOBRE", new string[]
                        {
                            "{title}VERSÃO 1.0",
                            "{sep}",
                            "INFO"
                        });
                        btnInfo.BackColor = Color.FromArgb(90, 59, 137);
                        break;
                    default:
                        break;
                }

                if (MenuAtual != AbasMenu.Oculto)
                    MenuLateral.Show();
            }
        }

        public FrmPrincipal()
        {
            InitializeComponent();

            var frm = new FrmLogin();
            frm.ShowDialog();

            if (frm.Validado)
                Application.Exit();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            MenuAtual = AbasMenu.Oculto;
            Tela.FormPrincipal = this;
        }

        private void SetMenu(string Titulo, string[] Opcoes)
        {
            MenuLateral.Titulo = Titulo;
            MenuLateral.Opcoes = Opcoes;
        }    

        private void MenuLateral_ButtonClick(object sender, EventArgs e)
        {
            string janelaAbrir = ((Control)sender).Text;

            if (janelaAbrir == StrJanelaAberta)
                return;

            if (MenuAtual == AbasMenu.Reagentes)
            {
                switch (janelaAbrir)
                {
                    case "CADASTRO":
                        Tela.Abrir(new FrmCadastroReagente(), janelaAbrir + " REAGENTE");
                        break;
                    default:
                        break;
                }
            }
            else if (MenuAtual == AbasMenu.Analises)
            {
                switch (janelaAbrir)
                {
                    case "ACIDIMETRIA":
                        Tela.Abrir(new FrmTitulacaoAcidoBaseNormal(TipoAnalise.Acidimetria), janelaAbrir);
                        break;
                    case "ALCALIMETRIA":
                        Tela.Abrir(new FrmTitulacaoAcidoBaseNormal(TipoAnalise.Alcalimetria), janelaAbrir);
                        break;
                    case "RETROTITULAÇÃO":
                        Tela.Abrir(new FrmRetrotitulacao(), janelaAbrir);
                        break;
                    case "POTENCIOMETRIA":
                        Tela.Abrir(new FrmPotenciometrica(), janelaAbrir);
                        break;
                    default:
                        break;
                }
            }
            else if (MenuAtual == AbasMenu.Relatorios)
            {
                switch (janelaAbrir)
                {
                    case "CADASTRO":
                        Tela.Abrir(new FrmRelatorio(), janelaAbrir + " REGISTRO");
                        break;
                    default:
                        break;
                }
            }

            MenuAtual = AbasMenu.Oculto;
        }

        private void BtnReagentes_Click(object sender, EventArgs e) => MudarMenu(AbasMenu.Reagentes);
        private void BtnAnalises_Click(object sender, EventArgs e) => MudarMenu(AbasMenu.Analises);
        private void BtnRelatorios_Click(object sender, EventArgs e) => MudarMenu(AbasMenu.Relatorios);
        private void BtnInfo_Click(object sender, EventArgs e) => MudarMenu(AbasMenu.Sobre);

        private void MudarMenu(AbasMenu menuReferente)
        {
            if (menuReferente == MenuAtual)
                MenuAtual = AbasMenu.Oculto;
            else
                MenuAtual = menuReferente;
        }

        private void PnlMain_SizeChanged(object sender, EventArgs e)
        {
            Tela.Centralizar();

            if (ucAbas.AbaSelecionada != null && ucAbas.AbaSelecionada.Tela.WindowState == FormWindowState.Maximized)
            {
                ucAbas.AbaSelecionada.Tela.WindowState = FormWindowState.Normal;                
                ucAbas.AbaSelecionada.Tela.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
