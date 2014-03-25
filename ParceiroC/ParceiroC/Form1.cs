using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParceiroC.ServiceReferenceCliente;
using System.Globalization;

namespace ParceiroC
{
    public partial class Form1 : Form
    {
        private ServiceReferenceCliente.ClienteClient servicoCliente = new ServiceReferenceCliente.ClienteClient();
        private int Cliente_IdSel = 0;

        public Form1()
        {
            InitializeComponent();
            CarregaGrid();
        }

        public void CarregaGrid()
        {
            try
            {
                Cliente[] arrayCliente = servicoCliente.RetornaClientes();//Retorna os clientes e preenche o gridview
                if (arrayCliente != null)
                {
                    foreach (Cliente cliente in arrayCliente)
                    {
                        dtGridView.Rows.Add(cliente.Cliente_id, cliente.Nome, cliente.TelefoneResidencial, cliente.Endereco, (cliente.DataNascimento == DateTime.MinValue ? string.Empty : cliente.DataNascimento.ToString("dd/MM/yyyy")), (cliente.TelefoneCelular == null ? string.Empty : cliente.TelefoneCelular));
                    }
                }
                else
                {
                    MessageBox.Show("Houve um erro ao recuperar os clientes!");
                }
            }
            catch
            {
                MessageBox.Show("Houve um erro ao conectar com servidor!");
            }
            dtGridView.ClearSelection();
        }

        private void dtGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex > -1) //preenche os campos ao clicar na linha do gridView
            {
                btnAtualizar.Enabled = true;
                Cliente_IdSel = Convert.ToInt32(dtGridView.Rows[e.RowIndex].Cells[0].Value);
                txtNome.Text = dtGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTelefoneResidencial.Text = dtGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEndereco.Text = dtGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDataNascimento.Text = dtGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtTelefoneCelular.Text = dtGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (verificaDados())// verifica se os dados informados estão corretos
            {
                bool retorno = false;
                Cliente cliente = new Cliente();
                cliente.Cliente_id = Cliente_IdSel;
                if (txtDataNascimento.MaskFull)
                    cliente.DataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
                if (txtTelefoneCelular.MaskFull)
                    cliente.TelefoneCelular = txtTelefoneCelular.Text;
                else
                    cliente.TelefoneCelular = string.Empty;

                retorno = servicoCliente.AtualizarDados(cliente);

                if (retorno)
                {
                    MessageBox.Show("Os dados do cliente foram atualizados com sucesso!");
                    dtGridView.SelectedRows[0].Cells[4].Value = cliente.DataNascimento.ToString("dd/MM/yyyy");
                    dtGridView.SelectedRows[0].Cells[5].Value = cliente.TelefoneCelular;
                    lblErros.Visible = false;
                    lblErros2.Visible = false;
                }
                else
                    MessageBox.Show("Houve algum erro na conexão com o servidor!");
            }
        }

        public bool verificaDados()
        {
            bool erros = false;
            DateTime dateTime;
            string format = "dd/MM/yyyy";
            if (!DateTime.TryParseExact(txtDataNascimento.Text.ToString(), format, CultureInfo.InvariantCulture,
                 DateTimeStyles.None, out dateTime))
            {
                lblErros.Text = "* Informe a data de nascimento no formato correto";
                lblErros.Visible = true;
                txtDataNascimento.Text = string.Empty;
            }
            if (!txtTelefoneCelular.MaskFull)
            {
                lblErros2.Text = "* Informe o telefone celular no formato correto";
                txtTelefoneCelular.Text = string.Empty;
                lblErros2.Visible = true;
            }
            else
                erros = true;

            return erros;
        }
    }
}
