namespace ToDoList
{
    public partial class FormJanelaToDoList : Form
    {
        public FormJanelaToDoList()
        {
            InitializeComponent();
        }

                private void dateTimeData_ValueChanged(object sender, EventArgs e)
            {

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

        private void toolTipMensagem_Popup(object sender, PopupEventArgs e)
        {

        }

        private void txtTarefa_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}