using FlaskMODEL.CONSULTAS;
using FlaskUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flask.TELAS
{
    public partial class FrmConsultaGeral : FlaskForm
    {
        public FrmConsultaGeral(string nomeConsulta, object dataSource)
        {
            InitializeComponent();
            ucHeader1.Titulo = nomeConsulta;
            flaskDataGridView1.DataSource = dataSource;

        }
        public FrmConsultaGeral(string nomeConsulta, object dataSource, List<ConfiguracaoCabecalho> cabecalhos)
        {
            InitializeComponent();
            ucHeader1.Titulo = nomeConsulta;
            flaskDataGridView1.DataSource = dataSource;

            if (cabecalhos.Count > 0)
            {
                for (int i = 0; i < flaskDataGridView1.Columns.Count; i++)
                {
                    var alinhamento = DataGridViewContentAlignment.MiddleLeft;

                    if (cabecalhos[i].Alinhamento == FlaskMODEL.Alinhamento.Centro)
                        alinhamento = DataGridViewContentAlignment.MiddleCenter;
                    else if (cabecalhos[i].Alinhamento == FlaskMODEL.Alinhamento.Direita)
                        alinhamento = DataGridViewContentAlignment.MiddleRight;

                    flaskDataGridView1.Columns[i].HeaderText = cabecalhos[i].Nome;
                    flaskDataGridView1.Columns[i].DefaultCellStyle.Alignment = alinhamento;
                }

            }
        }

    }
}