namespace ToDoList
{
    public partial class FormJanelaToDoList : Form
    {
        public FormJanelaToDoList()
        {
            InitializeComponent();
        }

          
       
        private void btnIncluir_Click(object sender, EventArgs e)
        {

                        

                if(txtTarefa.Text != "")
            {
                listboxListagemDeTarefas.Items.Add($"{dateTimeData.Value}-{txtTarefa.Text}");
                txtTarefa.Clear();
             }else
            {
                MessageBox.Show("Tarefa não pode ser vazia!");
            }                                     
           
            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {


            if (listboxListagemDeTarefas.SelectedItem != null)
            {
                listboxListagemDeTarefas.Items.Remove(listboxListagemDeTarefas.SelectedItem);
            }
            else
            {
                MessageBox.Show("Não há tarefa para ser removida!");
            }
        }

             
    }
}