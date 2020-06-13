using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Flask.TELAS.CONTROLES
{
    public partial class UcMenuLateral : UserControl
    {
        private string titulo;

        public string Titulo
        {
            get { return titulo; }
            set
            {
                titulo = value;
                lblTitulo.Text = titulo.ToUpper();
                lblTitulo.Refresh();
            }
        }

        private string[] opcoes;

        public string[] Opcoes
        {
            get { return opcoes; }
            set
            {
                opcoes = value;
                flp.Controls.Clear();

                foreach (var item in Opcoes)
                {
                    if (item == "{sep}")
                    {
                        flp.Controls.Add(new Panel
                        {
                            BackColor = Color.White,
                            Size = new Size(240, 1)
                        });

                        continue;
                    }
                    else if (item.Contains("{title}"))
                    {
                        flp.Controls.Add(new Label
                        {
                            AutoSize = false,
                            Size = new Size(240, 40),
                            Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
                            ForeColor = Color.White,
                            Text = item.Replace("{title}", "").ToUpper(),
                            TextAlign = ContentAlignment.MiddleCenter,
                        });

                        continue;
                    }

                    Button btnAdd = new Button
                    {
                        FlatStyle = FlatStyle.Flat,
                        Cursor = Cursors.Hand,
                        ForeColor = Color.White,
                        Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold),
                        Size = new Size(234, 50),
                        Text = item,
                    };

                    btnAdd.Click += BtnClick;

                    // btnAdd.FlatAppearance.BorderColor = Color.White;
                    btnAdd.FlatAppearance.BorderSize = 0;
                    btnAdd.FlatAppearance.MouseOverBackColor =
                    btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(115, 60, 195);

                    flp.Controls.Add(btnAdd);
                }
            }
        }

        public UcMenuLateral()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler ButtonClick;

        protected void BtnClick(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (this.ButtonClick != null)
                this.ButtonClick(sender, e);
        }
    }
}
