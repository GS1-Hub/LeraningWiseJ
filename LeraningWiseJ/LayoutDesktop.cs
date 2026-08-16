using LeraningWiseJ.Models;
using LeraningWiseJ.Services;
using LeraningWiseJ.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Wisej.Web;

namespace LeraningWiseJ
{
    public partial class LayoutDesktop : Desktop
    {
        private IFinoraService _context;

        public LayoutDesktop()
        {
            InitializeComponent();
            _context = new FinoraService(new HttpClient());
        }

        private void LayoutDesktop_Load(object sender, EventArgs e)
        {
            var fins = _context.GetFinoras().Result;

            gdvFin.AutoGenerateColumns = true;
            gdvFin.DataSource = fins;
            gdvFin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gdvFin.RowHeadersVisible = false;
            gdvFin.Columns["Id"].Visible = false;

            finName.Visible = false;
            finAmount.Visible = false;
            finDescription.Visible = false;
            txtName.Visible = false;
            txtAmount.Visible = false;
            txtDescription.Visible = false;
            btnSave.Visible = false;

            AtualizarTotal(fins);
        }

        public void AtualizarTotal(List<Finora> fins)
        {
            decimal total = fins.Sum(f => f.Amount);
            lblTotal.Text = $"{total:C2}";
            if (total == 0)
            {
                lblTotal.ForeColor = System.Drawing.Color.Green;
            }
            else if (total < 100)
            {
                lblTotal.ForeColor = System.Drawing.Color.Yellow;
            }
            else
            {
                lblTotal.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnCreateFin_Click(object sender, EventArgs e)
        {
            finName.Visible = true;
            finAmount.Visible = true;
            finDescription.Visible = true;
            txtName.Visible = true;
            txtAmount.Visible = true;
            txtDescription.Visible = true;
            btnSave.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtDescription.Text) || string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Something text is empty", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Valor de Amount inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var fin = new Finora
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
                Amount = amount
            };

            _context.CreateFinora(fin).Wait();

            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtAmount.Text = string.Empty;

            finName.Visible = false;
            finAmount.Visible = false;
            finDescription.Visible = false;
            txtName.Visible = false;
            txtAmount.Visible = false;
            txtDescription.Visible = false;
            btnSave.Visible = false;

            var fins = _context.GetFinoras().Result;
            gdvFin.DataSource = fins;
            AtualizarTotal(fins);
        }
    }
}