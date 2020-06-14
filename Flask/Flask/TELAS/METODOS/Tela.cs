using Flask.TELAS.CONTROLES;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flask.TELAS.METODOS
{
    public static class Tela
    {
        public static FrmPrincipal FormPrincipal { get; set; }
        public static void Abrir(Form janela, string nomeJanela)
        {
            if (FormPrincipal == null)
                return;

            FormPrincipal.StrJanelaAberta = nomeJanela;

            //---- Selecionar Aba
            if (FormPrincipal.ucAbas.SelecionarAbaPorNome(janela.Name))
                return;

            janela.TopLevel = false;
            janela.AutoScroll = true;
            FormPrincipal.pnlMain.Controls.Add(janela);
            janela.Show();

            string textoFormAberto = "Sem Título";

            foreach (Control item in janela.Controls)
            {
                if (item is UcHeader)
                {
                    textoFormAberto = ((UcHeader)item).Titulo;
                    break;
                }
            }

            FormPrincipal.ucAbas.AdicionarAba(new Aba(janela, textoFormAberto));
        }

        public static void Fechar()
        {
            if (FormPrincipal == null)
                return;

            if (FormPrincipal.ucAbas.AbaSelecionada == null)
                return;

            FormPrincipal.StrJanelaAberta = string.Empty;

            FormPrincipal.ucAbas.RemoverAba(FormPrincipal.ucAbas.AbaSelecionada.Tela.Name);
        }
    }
}
