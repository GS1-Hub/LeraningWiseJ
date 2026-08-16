using LeraningWiseJ.Models;
using LeraningWiseJ.Services;
using LeraningWiseJ.Services.Interface;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Formatters;
using System.Threading.Tasks;
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

        private async void LayoutDesktop_Load(object sender, EventArgs e)
        {
            var fins = await _context.GetFinoras();

            gdvFin.AutoGenerateColumns = true;
            gdvFin.DataSource = fins;
            gdvFin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gdvFin.RowHeadersVisible = false;
            gdvFin.Columns["ID"].Visible = false;

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
    }
}
