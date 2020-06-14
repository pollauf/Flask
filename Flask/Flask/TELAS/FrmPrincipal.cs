using Flask.TELAS.METODOS;
using Flask.TELAS.Reagentes;
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
                            "CONSULTA",
                            "RASTREIO",
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
                            "POTENCIOMETRIA"
                        });
                        btnAnalises.BackColor = Color.FromArgb(90, 59, 137);
                        break;
                    case AbasMenu.Relatorios:
                        SetMenu("RELATÓRIOS", new string[]
                        {
                            "CONSULTA",
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
                        Tela.Abrir(new FrmCadastroReagente(), janelaAbrir);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Tela.Abrir(new FrmTeste(), janelaAbrir);
            }            
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
            if (ucAbas.AbaSelecionada != null)
            {
                ucAbas.AbaSelecionada.Tela.WindowState = FormWindowState.Normal;                
                ucAbas.AbaSelecionada.Tela.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
