using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SqLiteTesteDefi1 {
    public partial class TelaInicial : Form {

        public TelaInicial() {
            InitializeComponent();

                        

            try {
                DataTable dt = new DataTable();
                dt = DalHelper.GetClientes();
                dgvDados.DataSource = dt;
            }
            catch (Exception ex) {
                MessageBox.Show("Erro : " + ex.Message);
            }

            dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void TelaInicial_Load(object sender, EventArgs e) {



        }

        private void butSair_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void textInputNome_TextChanged(object sender, EventArgs e) {



        }

        private void textInputEndereco_TextChanged(object sender, EventArgs e) {

        }

        private void textInputTelefone_TextChanged(object sender, EventArgs e) {

        }

        private void butCadastrar_Click(object sender, EventArgs e) {
        
                if (!Valida()) {
                    MessageBox.Show("Informe os dados cliente a incluir");
                    return;
                }
                try {
                    DadosPessoas cli = new DadosPessoas();
                    
                    cli.Nome = textInputNome.Text;
                    cli.Email = TextInputEmail.Text;
                    cli.Telefone = Convert.ToInt32(textInputTelefone.Text);
                    cli.Endereço = textInputEndereco.Text;

                    DalHelper.Add(cli);

                    ExibirDados();
                    LimpaDados();
                }
                catch (Exception ex) {
                    MessageBox.Show("Erro : " + ex.Message);
                }
        }




        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
       
                if (e.RowIndex >= 0) {

                    DataGridViewRow row = this.dgvDados.Rows[e.RowIndex];
                    textInputID.Text = row.Cells["Id"].Value.ToString();
                    textInputNome.Text = row.Cells["Nome"].Value.ToString();
                    TextInputEmail.Text = row.Cells["Email"].Value.ToString();
                    textInputEndereco.Text = row.Cells["Endereço"].Value.ToString();
                    textInputTelefone.Text = row.Cells["Telefone"].Value.ToString();

                }
        }
        

        private void butExibirDados_Click(object sender, EventArgs e) {

            ExibirDados();
            
        }

        public void ExibirDados() {
            try {
                DataTable dt = new DataTable();
                dt = DalHelper.GetClientes();
                dgvDados.DataSource = dt;
            }
            catch (Exception ex) {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }



       

        private void label4_Click(object sender, EventArgs e) {

        }

        private void butAtualizarDados_Click(object sender, EventArgs e) {

            if (!Valida()) {

                MessageBox.Show("Informe os dados cliente a atualizar");
                return;

             }

            try {

                DadosPessoas cli = new DadosPessoas();

                cli.Nome = textInputNome.Text;
                cli.Email = TextInputEmail.Text;
                cli.Telefone = Convert.ToInt32(textInputTelefone.Text);
                cli.Endereço = textInputEndereco.Text;
                cli.Id = Convert.ToInt32(textInputID.Text);

                DalHelper.Update(cli);
                ExibirDados();


            }
            catch (Exception ex) {

                MessageBox.Show("Erro : " + ex.Message);

            }

            
        }














        
        private void LimpaDados() {

            TextInputEmail.Text = "";
            textInputNome.Text = "";
            textInputEndereco.Text = "";
            textInputTelefone.Text = "";
            textInputID.Text = "";

        }

        private bool Valida() {
            if (string.IsNullOrEmpty(textInputNome.Text) && string.IsNullOrEmpty(TextInputEmail.Text) && string.IsNullOrEmpty(textInputEndereco.Text) &&
                string.IsNullOrEmpty(textInputTelefone.Text)) {

                return false;
            }

            else {
                return true;
            }
        }








        private void textInputID_TextChanged(object sender, EventArgs e) {

        }

        private void butExcluir_Click(object sender, EventArgs e) {
                    
           if (string.IsNullOrEmpty(textInputID.Text)) {

               MessageBox.Show("Informe o ID do cliente a ser Excluído");
               return;
           }

            try {


                const string mensagem = "Deseja Excluir ?";
                const string titulo = "Excluir";
                var resultado = MessageBox.Show(mensagem, titulo,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes) {
                  
               
                int codigo = Convert.ToInt32(textInputID.Text);
                DalHelper.Delete(codigo);
                ExibirDados();
                LimpaDados();

                }

            }
            catch (Exception ex) {
                MessageBox.Show("Erro : " + ex.Message);

            }      
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

                DataTable dt = new DataTable();
                dt = DalHelper.GetClientes();
                                                        

                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("Nome LIKE '%{0}%'", textBox1.Text);
                dgvDados.DataSource = dv.ToTable();
                       
           
        }

    }
}


