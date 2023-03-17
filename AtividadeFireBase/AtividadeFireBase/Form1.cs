using AtividadeFireBase.Firebase;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;

namespace AtividadeFireBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IFirebaseConfig fc = new FirebaseConfig()
        {
            AuthSecret = "GSDRd70nGDEoCgefWZg0MA8adsjSmogyNbnVe1ES",
            BasePath = "https://banco-python-4205b-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fc);
            }
            catch
            {
                MessageBox.Show("Houve algum erro de internet!");
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Variaveis fcCadastro = new Variaveis()
            {
                Nome = textBoxNomeCadastro.Text,
                Email = textBoxEmailCadastro.Text,
                Telefone = textBoxTelefoneCadastro.Text
            };
            Random numAleatorio = new Random();
            Random numAleatorio02 = new Random();
            Random numAleatorio03 = new Random();
            Random numAleatorio04 = new Random();
            int valorInteiro01 = numAleatorio.Next(0, 20);//entre 1 e 19
            int valorInteiro02 = numAleatorio02.Next(0, 20);
            int valorInteiro03 = numAleatorio03.Next(0, 20);
            int valorInteiro04 = numAleatorio04.Next(0, 20);
            var setCadastro = client.Set(@"AtividadeCharp/"+ valorInteiro01 + valorInteiro02 + valorInteiro03 + valorInteiro04, fcCadastro);
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            Variaveis fcUpdate = new Variaveis()
            {
                Nome = textBoxNomeAtualizar.Text,
                Email = textBoxEmailAtualizar.Text,
                Telefone = textBoxTelefoneAtualizar.Text
            };
            var setAtualizar = client.Update("AtividadeCharp/"+textBoxIDAtualizar.Text, fcUpdate);
        }

        private void buttonVisualizar_Click(object sender, EventArgs e)
        {
            dataGridViewVisualizar.Rows.Clear();
            dataGridViewVisualizar.Columns.Clear();
            dataGridViewVisualizar.Columns.Add("Tabela", "Tabela");
            dataGridViewVisualizar.Columns.Add("Nome", "Nome");
            dataGridViewVisualizar.Columns.Add("E-mail", "E-mail");
            dataGridViewVisualizar.Columns.Add("Telefone", "Telefone");
            FirebaseResponse getFire = client.Get(@"AtividadeCharp");
            Dictionary<string, Variaveis> data = JsonConvert.DeserializeObject<Dictionary<string, Variaveis>>(getFire.Body.ToString());
            VisualizarFireBase(data);
        }

        private void VisualizarFireBase(Dictionary<string, Variaveis> record)
        {
            if (record != null)
            {
                foreach(var item in record)
                {
                    dataGridViewVisualizar.Rows.Add(item.Key, item.Value.Nome, item.Value.Email, item.Value.Telefone);
                }
            }
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            if(comboBoxTabelaSelecionar.Text != null)
            {
                var setDelete = client.Delete(@"AtividadeCharp");
            }
        }

        private void comboBoxTabelaSelecionar_MouseLeave(object sender, EventArgs e)
        {
            comboBoxTabelaSelecionar.Items.Clear();
            TrazerDados();
        }

        private void comboBoxTabelaSelecionar_MouseMove(object sender, MouseEventArgs e)
        {
            comboBoxTabelaSelecionar.Items.Clear();
            TrazerDados();
        }

        private void comboBoxTabelaSelecionar_TextChanged(object sender, EventArgs e)
        {
            TrazerDados();
        }
        private void TrazerDados()
        {
            FirebaseResponse trazerD = client.Get(@"AtividadeCharp");
            Dictionary<string, Variaveis> data = JsonConvert.DeserializeObject<Dictionary<string, Variaveis>>(trazerD.Body.ToString());
            TrazerDadosFireBase(data);
        }

        private void TrazerDadosFireBase(Dictionary<string, Variaveis> record)
        {
            if (record != null)
            { 
                foreach (var item in record)
                {
                    comboBoxTabelaSelecionar.Items.Add(item.Key);
                    if(comboBoxTabelaSelecionar.Text == item.Key)
                    {
                        textBoxNomeAtualizar.Text = item.Value.Nome.ToString();
                        textBoxEmailAtualizar.Text = item.Value.Email.ToString();
                        textBoxTelefoneAtualizar.Text = item.Value.Telefone.ToString();
                        textBoxIDAtualizar.Text = item.Key.ToString();
                        textBoxTabelaDeletar.Text = item.Key.ToString();
                    }
                }
            }
        }
    }
}